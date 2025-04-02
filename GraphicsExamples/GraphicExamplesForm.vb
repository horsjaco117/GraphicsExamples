'Graphics Examples
'Spring 2025

Option Strict On
Option Explicit On


Public Class GraphicExamplesForm
    Function ForeGroundColor(Optional newColor As Color = Nothing) As Color
        Static _foreColor As Color = Color.Black

        If newColor <> Nothing Then
            _foreColor = newColor
        End If

        Return _foreColor
    End Function


    Sub DrawWithMouse(oldX As Integer, oldY As Integer, newX As Integer, newY As Integer)
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(ForeGroundColor)


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

    Private Sub GraphicExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Me.MouseDown
        Static oldX, oldY As Integer
        'Only draw when button is held down
        Select Case e.Button.ToString
            Case "Left"
                DrawWithMouse(oldX, oldY, e.X, e.Y)
            Case "Right"
                'MsgBox("Yippe!!")
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

    Private Sub MainContextMenuStrip_MouseClick(sender As Object, e As MouseEventArgs) Handles MainContextMenu.MouseClick

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Me.Refresh()
    End Sub
End Class
