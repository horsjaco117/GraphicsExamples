Option Strict On
Option Explicit On
Public Class AboutForm
    Private Sub AboutOkButton_Click(sender As Object, e As EventArgs) Handles AboutOkButton.Click
        GraphicExamplesForm.Show()
        Me.Close()
    End Sub
End Class