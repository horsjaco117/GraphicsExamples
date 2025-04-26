Public Class HelpForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles InfoLabel.Click

    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        GraphicExamplesForm.Show()
        Me.Close()
    End Sub
End Class