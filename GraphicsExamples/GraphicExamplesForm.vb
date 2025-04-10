'Graphics Examples
'Spring 2025

Option Strict On
Option Explicit On

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
        Static _PenWidth As Integer = 10
        'define valid range. Note widths > 1 looks weird, maybe draw rectangles
        If newWidth > 100 Then
            _PenWidth = 100
        ElseIf newWidth > 0 Then 'define max pen width
            _PenWidth = newWidth
        End If

        Return _PenWidth
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
        Dim oldX, oldY, newY As Integer
        Dim yOffset As Integer = DrawingPictureBox.Height \ 2
        Dim degreesPerPoint As Double = 360 \ DrawingPictureBox.Width

        ymax = yOffset
        ymax *= -1
        oldY = yOffset



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

    Private Sub GraphicExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove, DrawingPictureBox.MouseDown
        Static oldX, oldY As Integer
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
                DrawWithMouse(e.X, 0, e.X, DrawingPictureBox.Height)
        End Select
        Me.Text = $"({e.X},{e.Y}) {e.Button.ToString} FG {ForeGroundColor.ToString}"

        ' DrawWithMouse(oldX, oldY, e.X, e.Y)
        oldX = e.X
        oldY = e.Y
    End Sub

    Private Sub ChangeForegroundColor(sender As Object, e As EventArgs) Handles ForegroundColorContextMenuItem.Click

        Dim result As DialogResult = ColorDialog.ShowDialog()

        If result.ToString = "OK" Then

            ForeGroundColor(ColorDialog.Color)
        Else
            MsgBox(result.ToString)
            MsgBox(ColorDialog.Color.ToString)

        End If
    End Sub

    Private Sub ChangeBackgroundColor(sender As Object, e As EventArgs) Handles BackgroundColorContextMenuItem.Click, BackgroundColorToolStripMenuItem.Click

        Dim result As DialogResult = ColorDialog.ShowDialog()

        If result.ToString = "OK" Then

            BackgroundColor(ColorDialog.Color)
        Else
            MsgBox(result.ToString)
            MsgBox(ColorDialog.Color.ToString)

        End If
    End Sub

    Private Sub MainContextMenuStrip_MouseClick(sender As Object, e As MouseEventArgs) Handles MainContextMenuStrip.MouseClick

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        DrawingPictureBox.BackColor = BackgroundColor()
    End Sub



    Private Sub BackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub

    Private Sub GraphicExamplesForm_activated(sender As Object, e As EventArgs) Handles Me.Activated

        SplashForm.Show()

    End Sub

    Private Sub MainContextMenuStrip_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MainContextMenuStrip.Opening

    End Sub

    Private Sub DrawWaveButton_Click(sender As Object, e As EventArgs) Handles DrawWaveButton.Click
        DrawingPictureBox.Refresh()
        DrawSinWave()
    End Sub
End Class
