'Jacob Horsley
'RCET 0265
'Spring 2025
'URL: https://github.com/horsjaco117/GraphicsExamples 
'I tried renaming everything to Etch a Sketch, but it didn't work so it's technically modified class notes
Option Strict On
Option Explicit On

Imports System.Media
Imports System.Threading.Thread
Imports System.Runtime.CompilerServices
'Serial communications imports
Imports System.IO.Ports
Imports System.Net.Configuration

Public Class GraphicExamplesForm
    Private LastCommand As Byte
    Private currentX As Single = 0
    Private currentY As Single = 0

    'Serial Communications----------------------------------------------------------
    Sub SetDefaults() 'Set's default serial pieces and shows COM ports
        SerialPort1.Close() 'Closes the COM ports but adds settings
        ConnectionStatusLabel.Text = "No connection" 'No connect until port chosen
        GetPorts() 'Shows available ports
    End Sub

    Sub GetPorts()
        Dim ports() = SerialPort1.GetPortNames() 'Available ports

        PortsComboBox.Items.Clear() 'Clears the ports

        For Each port In ports 'For every port available add it to the combobox
            PortsComboBox.Items.Add(port)
        Next

        Try
            PortsComboBox.SelectedIndex = 0
        Catch ex As Exception
            'No results
        End Try
    End Sub

    Sub connect()

        SerialPort1.Close() 'Closes the ports 
        Try  'All these are serial port settings. 
            SerialPort1.BaudRate = 115200
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.DataBits = 8
            SerialPort1.PortName = CStr(PortsComboBox.SelectedItem)
            SerialPort1.Open()


            If IsQuietBoard() Then 'Confirms that communication is with the Quiet Board
                ConnectionStatusLabel.Text = $"Qy@ Connected on {SerialPort1.PortName}"
            Else
                SetDefaults() 'Resets to defaults if not quiet board
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            SetDefaults()
        End Try

    End Sub

    Sub send(data() As Byte)
        SerialPort1.ReadExisting()
        SerialPort1.Write(data, 0, UBound(data))
    End Sub

    Function recieve() As Byte() 'For every byte recieved it will be displayed as the data variable
        Dim data(SerialPort1.BytesToRead) As Byte
        SerialPort1.Read(data, 0, SerialPort1.BytesToRead)
        Return data
    End Function

    'Write
    Sub write() 'This write sub is especially for handshaking
        Dim data(0) As Byte
        data(0) = &B11110000
        SerialPort1.Write(data, 0, 1)
    End Sub

    Private Sub ReadAnalogButton_Click(sender As Object, e As EventArgs) Handles AnalogButton1.Click
        Dim data(0) As Byte
        data(0) = &H5F 'Hex value for reading analog quiet board values
        connect()
        SerialPort1.Write(data, 0, 1)
    End Sub

    Private Sub COMButton_Click(sender As Object, e As EventArgs) Handles COMButton.Click
        'Establishes the com between the quiet board

        connect()
        write()
    End Sub
    Private Sub AnalogTimer_Tick(sender As Object, e As EventArgs) Handles AnalogTimer.Tick
        AnalogRead3() 'For every timer tick the Analog data is interpreted and read
    End Sub

    Sub AnalogRead1() 'Test read for analog data
        Dim data(0) As Byte
        data(0) = &H50 'test command byte
        connect()
        SerialPort1.Write(data, 0, 1)
    End Sub

    Sub AnalogRead2() 'Test sub for analog read
        ' Clear the previous data output for a clean read
        If SerialTextBox IsNot Nothing Then
            SerialTextBox.Text = String.Empty
        End If

        ' Clear the specific byte display too
        If XAxisTextBox IsNot Nothing Then
            XAxisTextBox.Text = String.Empty
        End If

        Dim data(0) As Byte
        data(0) = &H51 ' This command tells the device what data to send back
        connect()
        SerialPort1.Write(data, 0, 1)
    End Sub

    Sub AnalogRead3() 'This analog test worked best
        ' Clear the previous data output for a clean read
        If SerialTextBox IsNot Nothing Then
            SerialTextBox.Text = String.Empty
        End If

        ' Clear the specific byte display too
        If YAxisTextBox IsNot Nothing Then
            YAxisTextBox.Text = String.Empty
        End If

        Dim data(0) As Byte
        data(0) = &H53 ' This command tells the device what data to send back
        connect()
        SerialPort1.Write(data, 0, 1)
    End Sub


    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Dim bytesToRead As Integer = SerialPort1.BytesToRead
            If bytesToRead < 4 Then Exit Sub                 ' not enough data yet

            Dim buffer(bytesToRead - 1) As Byte
            SerialPort1.Read(buffer, 0, bytesToRead)

            Dim hexString As New System.Text.StringBuilder()
            For Each b As Byte In buffer
                hexString.Append(b.ToString("X2") & " ")
            Next

            Dim leftValue As Integer = buffer(1)   ' left analog (X-axis) takes the bytes we want
            Dim rightValue As Integer = buffer(3)  ' right analog (Y-axis)

            ' Update the text boxes with the hex bytes (thread-safe)
            WriteToTextBox(Me.XAxisTextBox, buffer(0).ToString("X2"))
            WriteToTextBox(Me.YAxisTextBox, buffer(2).ToString("X2"))

            Me.Invoke(Sub()
                          SerialTextBox.AppendText(hexString.ToString() & vbCrLf)
                      End Sub)

            ' If PIC control mode is active, draw using values currently present in the hex text boxes
            If PICControlRadioButton.Checked Then
                Me.Invoke(Sub() DrawFromHexTextBoxes()) 'This invoke function safely filters the hex from the text boxes
            End If

        Catch ex As Exception
            Console.WriteLine($"Serial read error: {ex.Message}")
        End Try
    End Sub


    Function IsQuietBoard() As Boolean
        Dim data(0) As Byte 'put bytes into array
        data(0) = &B11110000 'actual data as a byte
        send(data)


        Return True

    End Function

    Public Sub WriteToTextBox(ByVal targetTextBox As System.Windows.Forms.TextBox, ByVal content As String)
        ' Check if the call is coming from a different thread than the one that created the control
        If targetTextBox.InvokeRequired Then
            ' If it is, use Invoke to marshal the call back to the UI thread
            targetTextBox.Invoke(New Action(Sub()
                                                targetTextBox.Text = content
                                            End Sub))
        Else
            ' If it is the UI thread, update directly
            targetTextBox.Text = content
        End If
    End Sub


    'This function changes the color of the pen for the user
    Function PenColor(Optional newColor As Color = Nothing) As Color
        Static _foreColor As Color = Color.Black 'default of black

        If newColor <> Nothing Then
            _foreColor = newColor 'changes when prompted by user
        End If

        Return _foreColor
    End Function
    'Provides a set width for the pen
    Function PenWidth(Optional newWidth As Integer = -1) As Integer
        Static _penWidth As Integer = 1 'Default pen width of 1 is assigned
        Return _penWidth
    End Function
    'Below code is what dictates where the pen draws. It's drawn with the mouse
    Sub DrawWithMouse(oldX As Integer, oldY As Integer, newX As Integer, newY As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics 'Code for the drawing box.
        Dim pen As New Pen(PenColor, PenWidth())

        g.DrawLine(pen, oldX, oldY, newX, newY) 'Allows lines to be drawn with mouse

        g.Dispose() 'This cleans up the graphics object after we're done using it
    End Sub
    Sub DrawSinWave() 'Below the Sin wave is being drawn
        'Graphics and pen
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Lime)
        'Offset and Amplitude
        Dim ymax As Integer = 50
        Dim oldX, newY As Integer
        Dim yOffset As Integer = DrawingPictureBox.Height \ 2 'Helps adjust waveform for height
        Dim degreesPerPoint As Double = 360 \ DrawingPictureBox.Width 'Helps adjust waveform according to width
        Dim oldy As Integer = DrawingPictureBox.Height \ 2
        ymax = yOffset
        oldy = yOffset
        ymax *= -1
        'Draws the sine wave
        For x = 0 To DrawingPictureBox.Width
            newY = CInt(ymax * Math.Sin((x / DrawingPictureBox.Width) * 2 * Math.PI)) + yOffset
            'Bulk of the math is contained above. In this case for the sine wave
            g.DrawLine(pen, oldX, oldy, x, newY)
            oldX = x
            oldy = newY

            Select Case x 'For debugging purposes
                Case 90
                    Console.WriteLine($"x={x} y={newY}")
                Case 180
                    Console.WriteLine($"x={x} y={newY}")
                Case 270
                    Console.WriteLine($"x={x} y={newY}")
                Case 360
                    Console.WriteLine($"x={x} y={newY}")

            End Select
        Next

        g.Dispose()
    End Sub
    Sub drawCosWave()
        ' Setup graphics and pen
        Dim g As Graphics = DrawingPictureBox.CreateGraphics()
        Dim pen As New Pen(Color.DarkRed)
        ' Define offset and amplitude
        Dim yOffset As Integer = DrawingPictureBox.Height \ 2
        Dim amplitude As Integer = yOffset - 1 ' Avoid going out of bounds
        Dim oldX As Integer = 0
        Dim oldY As Integer = CInt(amplitude * Math.Cos(0)) + yOffset ' Correct starting point at x=0
        ' Draw the cosine wave
        For x As Integer = 1 To DrawingPictureBox.Width
            Dim radians As Double = (x / DrawingPictureBox.Width) * 2 * Math.PI
            Dim newY As Integer = CInt(amplitude * Math.Cos(radians)) + yOffset
            ' Ensures the wave is inside drawing box
            newY = Math.Max(0, Math.Min(DrawingPictureBox.Height - 1, newY))
            ' Draw line segment
            g.DrawLine(pen, oldX, oldY, x, newY)
            ' Update old coordinates
            oldX = x
            oldY = newY
        Next
    End Sub
    Sub DrawTanWave() 'Below is the code for the Tangent wave
        'Same dim as the other waveforms. Those can be referred to for context
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Blue)
        Dim ymax As Double = DrawingPictureBox.Height \ 8
        Dim oldX, newY As Integer
        Dim yOffset As Integer = DrawingPictureBox.Height \ 2
        Dim degreesPerPoint As Double = 360 / DrawingPictureBox.Width
        Dim oldy As Integer = yOffset
        ymax *= -1

        For x = 0 To DrawingPictureBox.Width
            If Math.Abs((x * degreesPerPoint) Mod 90) <> 0 Then
                ' Dynamically adjust the tangent calculation based on width
                newY = CInt(ymax * Math.Tan((x / DrawingPictureBox.Width) * 2 * Math.PI)) + yOffset
                'Modified tangent wave math
                g.DrawLine(pen, oldX, oldy, x, newY)
                oldX = x
                oldy = newY
            End If

            Select Case x
                Case 90, 180, 270, 360
                    Console.WriteLine($"x={x} y={newY}")
            End Select
        Next
        'Dispose helps clean up stuff when not in use
        g.Dispose()
    End Sub
    Sub Graticule() '10 x 10 graticule sub
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)
        Dim stepX As Integer = DrawingPictureBox.Width \ 10
        Dim stepY As Integer = DrawingPictureBox.Height \ 10

        ' Vertical lines
        For x As Integer = 0 To DrawingPictureBox.Width Step stepX
            g.DrawLine(pen, x, 0, x, DrawingPictureBox.Height)
        Next

        ' orizontal lines
        For y As Integer = 0 To DrawingPictureBox.Height Step stepY
            g.DrawLine(pen, 0, y, DrawingPictureBox.Width, y)
        Next

        g.Dispose()
    End Sub
    'Event Handlers-----------------------------------------
    'The sub below handles anything with the mouse. Left and middle click in this case
    Private Sub GraphicExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove, DrawingPictureBox.MouseDown
        If Not MouseControlRadioButton.Checked Then Exit Sub  ' Skip if not in mouse mode
        Static oldX, oldY As Integer

        'Only draw when button is held down
        Select Case e.Button.ToString
            Case "Left"
                DrawWithMouse(oldX, oldY, e.X, e.Y)
            Case "Right"
                'Refer to form context menu strip for right click options
            Case "Middle"
                ColorButton.PerformClick() 'When mouse wheel is depress color options appear
        End Select

        oldX = e.X
        oldY = e.Y
    End Sub
    'Below handles anything that will trigger the color menu. Refer to handlers
    Private Sub ChangePenColor(sender As Object, e As EventArgs) Handles PenColorContextMenuItem.Click, PenColorToolStripMenuItem.Click, ColorButton.Click
        Dim result As DialogResult = ColorDialog.ShowDialog()

        If result.ToString = "OK" Then

            PenColor(ColorDialog.Color) 'color box opens

        End If
    End Sub
    'Below is the code that triggers the help menu from the handlers shown. Hides drawing board then shows helpform
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click, AboutToolStripMenuItem1.Click
        Me.Hide()
        HelpForm.Show()
    End Sub
    'Below is splsh screen code
    Private Sub GraphicExamplesForm_activated(sender As Object, e As EventArgs) Handles Me.Activated
        Static isStartUp As Boolean = True
        If isStartUp Then ' activates at startup
            SplashForm.Show() 'See splashform for timer modifications of splashscreen
            isStartUp = False
        End If

    End Sub
    'Below are all the options to draw the waveforms. 
    Private Sub DrawWaveButton_Click(sender As Object, e As EventArgs) Handles DrawWaveButton.Click, DrawWaveformsToolStripMenuItem.Click
        DrawingPictureBox.Refresh() 'Erases what was on the screen
        Graticule() 'Calls 10x10 graticule sub
        DrawSinWave() 'Calls sine wave sub
        drawCosWave() 'Calls cosine wave sub
        DrawTanWave() ' Calls tangent wave sub
    End Sub
    Private Sub ClearContextMenuItem_Click(sender As Object, e As EventArgs) Handles ClearContextMenuItem.Click, ClearToolStripMenuItem.Click, ClearButton.Click
        Dim displacement As Integer = 200 'Controls how far the box is moved
        Try 'This try is in charge shaking screen and playing audio
            My.Computer.Audio.Play(My.Resources.shaker, AudioPlayMode.Background)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        For i = 1 To 10
            Me.Top += displacement
            Me.Left += displacement
            '  Sleep(100)
            displacement *= -1
        Next
        DrawingPictureBox.Refresh() 'Erases everything on screen
    End Sub
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click, ExitToolStripMenuItem.Click, ExitButton.Click
        Me.Close() 'Closes the program upon activation from button
    End Sub
    Private Sub graphicexamplesform_load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CancelButton = Me.ClearButton 'Binds ESC to the clearbutton
        Me.AcceptButton = Me.DrawWaveButton 'Binds Enter to Draw wavebutton
        SetDefaults() 'Serial communication defaults
        MouseControlRadioButton.Checked = True  ' Default to mouse mode
        AnalogTimer.Enabled = False  ' Disable hardware polling initially

        currentX = CSng(DrawingPictureBox.Width / 2)
        currentY = CSng(DrawingPictureBox.Height / 2)
    End Sub

    Private Sub PICControlRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PICControlRadioButton.CheckedChanged
        'Allows the PIC to write on the Etch a sketch
        If PICControlRadioButton.Checked Then
            MouseControlRadioButton.Checked = False
            AnalogTimer.Enabled = True  ' Enable polling for hardware
        Else
            AnalogTimer.Enabled = False  ' Disable polling
        End If
    End Sub

    Private Sub MouseControlRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MouseControlRadioButton.CheckedChanged
        'Returns control back to the mouse
        If MouseControlRadioButton.Checked Then
            PICControlRadioButton.Checked = False
            AnalogTimer.Enabled = False
        End If
    End Sub

    ' Add this helper method (paste into the class with other Subs/Functions)
    Private Sub DrawFromHexTextBoxes()
        ' Read & sanitize the hex strings
        Dim hx As String = If(XAxisTextBox?.Text, "").Trim()
        Dim hy As String = If(YAxisTextBox?.Text, "").Trim()
        If String.IsNullOrEmpty(hx) Or String.IsNullOrEmpty(hy) Then Return

        ' Normalize case and remove common prefixes
        hx = hx.ToUpperInvariant().Replace("0X", "").Replace("&H", "")
        hy = hy.ToUpperInvariant().Replace("0X", "").Replace("&H", "")

        hx = hx.Split(" "c, CChar(vbTab), CChar(vbCrLf)).FirstOrDefault()
        hy = hy.Split(" "c, CChar(vbTab), CChar(vbCrLf)).FirstOrDefault()
        If String.IsNullOrEmpty(hx) Or String.IsNullOrEmpty(hy) Then Return

        Try
            Dim valX As Integer = Convert.ToInt32(hx, 16) ' 0..255 expected
            Dim valY As Integer = Convert.ToInt32(hy, 16)

            ' --- DRAWING LIMITS CONFIG ---
            ' Change these four values to move the drawing area.
            Dim leftRatio As Single = 0.1F   ' 10% from left
            Dim rightRatio As Single = 0.9F  ' 10% from right
            Dim topRatio As Single = 0.1F    ' 10% from top
            Dim bottomRatio As Single = 0.9F ' 10% from bottom

            Dim w As Integer = Math.Max(1, DrawingPictureBox.Width - 1)
            Dim h As Integer = Math.Max(1, DrawingPictureBox.Height - 1)

            Dim minX As Integer = CInt(leftRatio * w)
            Dim maxX As Integer = CInt(rightRatio * w)
            Dim minY As Integer = CInt(topRatio * h)
            Dim maxY As Integer = CInt(bottomRatio * h)

            ' Prevent inverted ranges
            If maxX < minX Then Swap(minX, maxX)
            If maxY < minY Then Swap(minY, maxY)

            ' Map raw 0..255 into the constrained rectangle
            Dim mappedX As Integer = minX + CInt(Math.Round((valX / 255.0F) * (maxX - minX)))
            Dim mappedY As Integer = minY + CInt(Math.Round((valY / 255.0F) * (maxY - minY)))

            ' Remember old position and update current position
            Dim oldX As Integer = CInt(currentX)
            Dim oldY As Integer = CInt(currentY)

            currentX = Math.Max(0, Math.Min(w, mappedX))
            currentY = Math.Max(0, Math.Min(h, mappedY))

            ' Draw on UI thread
            If Me.InvokeRequired Then
                Me.Invoke(Sub() DrawWithMouse(oldX, oldY, CInt(currentX), CInt(currentY)))
            Else
                DrawWithMouse(oldX, oldY, CInt(currentX), CInt(currentY))
            End If
        Catch ex As Exception
            Debug.WriteLine($"DrawFromHexTextBoxes parse error: {ex.Message}")
        End Try
    End Sub

    ' small helper to swap two integers
    Private Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim t As Integer = a
        a = b
        b = t
    End Sub
End Class
