'Jacob Horsley
'RCET 0265
'Spring 2025
'URL:

Option Strict On
Option Explicit On

Imports System.Media
Imports System.Threading.Thread
Imports System.Runtime.CompilerServices

'TODO
' [ ] Add funcionality for all context menu items
'   [ ] Background color
'   [ ] pen width as drop down or text input with max width defined
'   [ ] font
' [ ] match functionality between context menu and top menu
' [ ] add tool tip on picture box
' [ ] plot sine wave
' [ ] Add erase mode
' [ ] Draw shape tool
' [ ] add about form
' [x] add splash screen
' [ ] 


Public Class GraphicExamplesForm
    Function ForegroundColor(Optional newColor As Color = Nothing) As Color
        Static _foreColor As Color = Color.Black

        If newColor <> Nothing Then
            _foreColor = newColor
        End If

        Return _foreColor
    End Function

    Function BackgroundColor(Optional newColor As Color = Nothing) As Color
        Static _backColor As Color = Color.White

        If newColor <> Nothing Then
            _backColor = newColor
        End If

        Return _backColor
    End Function

    Function PenWidth(Optional newWidth As Integer = -1) As Integer
        Static _penWidth As Integer = 1
        'define valid range. Note widths > 1 looks weird, maybe draw rectangles
        If newWidth > 100 Then
            _penWidth = 100
        ElseIf newWidth > 0 Then 'define max pen width
            _penWidth = newWidth
        End If

        Return _penWidth
    End Function


    Sub DrawWithMouse(oldX As Integer, oldY As Integer, newX As Integer, newY As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ForegroundColor, PenWidth())


        'pen.Color = ForeGroundColor(Color.Lime)

        g.DrawLine(pen, oldX, oldY, newX, newY)

        g.Dispose()
    End Sub

    Sub DrawSinWave()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Lime)
        Dim ymax As Integer = 50
        Dim oldX, newY As Integer
        Dim yOffset As Integer = DrawingPictureBox.Height \ 2
        Dim degreesPerPoint As Double = 360 \ DrawingPictureBox.Width
        Dim oldy As Integer = DrawingPictureBox.Height \ 2
        ymax = yOffset
        oldY = yOffset
        ymax *= -1



        'pen.Color = ForeGroundColor(Color.Lime)
        For x = 0 To DrawingPictureBox.Width
            newY = CInt(ymax * Math.Sin((Math.PI / 180) * (x * 1))) + yOffset

            g.DrawLine(pen, oldX, oldY, x, newY)
            oldX = x
            oldY = newY


            Select Case x
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

        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Red)
        Dim ymax As Integer = DrawingPictureBox.Height \ 2
        Dim oldX, newY As Integer
        Dim yOffset As Integer = DrawingPictureBox.Height \ 2
        Dim degreesPerPoint As Double = 360 \ DrawingPictureBox.Width
        Dim oldy As Integer = DrawingPictureBox.Height \ 2
        ymax = yOffset
        oldy = yOffset
        ymax *= -1
        For x = 0 To DrawingPictureBox.Width
            newY = CInt(ymax * Math.Cos((Math.PI / 180) * (x * 1))) + yOffset
            ' newY += DrawingPictureBox.Height \ 4
            g.DrawLine(Pen, oldX, oldY, x, newY)
            oldX = x
            oldY = newY


            Select Case x
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

    End Sub
    'Event Handlers-----------------------------------------

    Private Sub GraphicExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove, DrawingPictureBox.MouseDown
        Static oldX, oldY, lastVerticalLineX As Integer
        Dim lastColor As Color
        Dim lastWidth As Integer
        'Only draw when button is held down
        Select Case e.Button.ToString
            Case "Left"
                DrawWithMouse(oldX, oldY, e.X, e.Y)
            Case "Right"
                'MsgBox("Yippee!!")

                'ignore and use context menu
            Case "Middle"
                'TODO
                '
                ''DrawWithMouse(DrawingPictureBox.Width \ 2, 0, DrawingPictureBox.Width \ 2, DrawingPictureBox.Height)
                'draw a line top to bottom on the current mouse x location
                lastColor = ForegroundColor() 'save user color
                lastWidth = PenWidth() 'save user pen width
                PenWidth(3) ' set wider pen width to eliminate ghosting
                ForegroundColor(BackgroundColor()) 'set foreground color to background color
                DrawWithMouse(lastVerticalLineX, 0, lastVerticalLineX, DrawingPictureBox.Height) ' erase last line

                PenWidth(1) 'set width to 1 pixel
                ForegroundColor(lastColor) 'revert foreground color to user defined
                DrawWithMouse(e.X, 0, e.X, DrawingPictureBox.Height) 'draw vertical line
                lastVerticalLineX = e.X ' store x position of last line
                PenWidth(lastWidth) 'revert pen width to user defined
        End Select

        '   Me.Text = $"({e.X},{e.Y}) {e.Button.ToString} FG {ForeGroundColor.ToString}"

        ' DrawWithMouse(oldX, oldY, e.X, e.Y)
        oldX = e.X
        oldY = e.Y
    End Sub

    Private Sub ChangeForegroundColor(sender As Object, e As EventArgs) Handles ForegroundColorContextMenuItem.Click, ForegroundColorToolStripMenuItem.Click

        Dim result As DialogResult = ColorDialog.ShowDialog()

        If result.ToString = "OK" Then

            ForegroundColor(ColorDialog.Color)
            'Else
            '    MsgBox(result.ToString)
            '    MsgBox(ColorDialog.Color.ToString)

        End If
    End Sub

    'Private Sub ChangeBackgroundColor(sender As Object, e As EventArgs) Handles BackgroundColorContextMenuItem.Click, BackgroundColorToolStripMenuItem.Click


    '    Dim result As DialogResult = ColorDialog.ShowDialog()

    '    If result.ToString = "OK" Then

    '        BackgroundColor(ColorDialog.Color)
    '        'Else
    '        '    MsgBox(result.ToString)
    '        '    MsgBox(ColorDialog.Color.ToString)

    '    End If
    'End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        HelpForm.Show()
    End Sub

    Private Sub GraphicExamplesForm_activated(sender As Object, e As EventArgs) Handles Me.Activated
        Static isStartUp As Boolean = True
        If isStartUp Then
            SplashForm.Show()
            isStartUp = False
        End If
        'SplashForm.Show()

    End Sub

    Private Sub MainContextMenuStrip_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MainContextMenuStrip.Opening

    End Sub

    Private Sub DrawWaveButton_Click(sender As Object, e As EventArgs) Handles DrawWaveButton.Click
        DrawingPictureBox.Refresh()
        DrawSinWave()
        drawCosWave()
    End Sub

    Private Sub ClearContextMenuItem_Click(sender As Object, e As EventArgs) Handles ClearContextMenuItem.Click
        Dim fudge As Integer = 20
        Try
            My.Computer.Audio.Play(My.Resources.shaker, AudioPlayMode.Background)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        For i = 1 To 10
            Me.Top += fudge
            Me.Left += fudge
            Sleep(100)
            fudge *= -1
        Next
        DrawingPictureBox.Refresh()
    End Sub

    Private Sub ForegroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForegroundColorToolStripMenuItem.Click

    End Sub

    Private Sub WidthToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
