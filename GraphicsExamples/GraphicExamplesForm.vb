'Graphics Examples
'Spring 2025

Option Strict On
Option Explicit On


Public Class GraphicExamplesForm

    Sub drawline()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black)

        'pen.Color = Color.PapayaWhip

        g.DrawLine(pen, 50, 50, 100, 100)

        g.Dispose()
    End Sub

    'Event Handlers -----------------------------------------------------------------
    Private Sub GraphicExamplesForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        drawline()
    End Sub

    Private Sub GraphicExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = $"({e.X},{e.Y})"
    End Sub
End Class
