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

    Sub drawline()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black)

        pen.Color = ForeGroundColor(Color.Lime)

        g.DrawLine(pen, 50, 50, 100, 100)

        g.Dispose()
    End Sub

    Sub drawRectangle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.OrangeRed, 3)

        'pen.Color = Color.PapayaWhip

        g.DrawRectangle(pen, 150, 150, 300, 300)

        g.Dispose()
    End Sub

    Sub drawcircle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Peru, 45)

        'pen.Color = Color.PapayaWhip

        g.DrawEllipse(pen, 160, 160, 290, 290)

        g.Dispose()
    End Sub
    Sub drawstring()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Cornsilk)
        Dim drawfont As New Font("arial", 16)
        Dim drawbrush As New SolidBrush(ForeGroundColor)

        'pen.Color = Color.PapayaWhip

        g.DrawString("Graphics!", drawfont, drawbrush, 200, 200)

        g.Dispose()
    End Sub
    'Event Handlers -----------------------------------------------------------------
    Private Sub GraphicExamplesForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        drawline()
        drawRectangle()
        drawcircle()
        drawstring()
    End Sub

    Private Sub GraphicExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = $"({e.X},{e.Y})"
    End Sub
End Class
