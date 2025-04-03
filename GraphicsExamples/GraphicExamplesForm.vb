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
' [ ] add splash screen
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
    'Sub drawline()
    '    Dim g As Graphics = Me.CreateGraphics
    '    Dim pen As New Pen(Color.Black)

    '    'pen.Color = ForeGroundColor(Color.Lime)

    '    g.DrawLine(pen, 50, 50, 100, 100)

    '    g.Dispose()
    'End Sub

    'Sub drawRectangle()
    '    Dim g As Graphics = Me.CreateGraphics
    '    Dim pen As New Pen(Color.OrangeRed, 3)

    '    'pen.Color = Color.PapayaWhip

    '    g.DrawRectangle(pen, 150, 150, 300, 300)

    '    g.Dispose()
    'End Sub

    'Sub drawcircle()
    '    Dim g As Graphics = Me.CreateGraphics
    '    Dim pen As New Pen(Color.Peru, 45)

    '    'pen.Color = Color.PapayaWhip

    '    g.DrawEllipse(pen, 160, 160, 290, 290)

    '    g.Dispose()
    'End Sub
    'Sub drawstring()
    '    Dim g As Graphics = Me.CreateGraphics
    '    Dim pen As New Pen(Color.Cornsilk)
    '    Dim drawfont As New Font("arial", 16)
    '    Dim drawbrush As New SolidBrush(ForeGroundColor)

    '    'pen.Color = Color.PapayaWhip

    '    g.DrawString("Graphics!", drawfont, drawbrush, 200, 200)

    '    g.Dispose()
    'End Sub
    'Event Handlers -----------------------------------------------------------------
    'Private Sub GraphicExamplesForm_Click(sender As Object, e As EventArgs) 'Handles Me.Click
    '    Me.Refresh()
    '    drawline()
    '    drawRectangle()
    '    drawcircle()
    '    drawstring()
    'End Sub

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
End Class
