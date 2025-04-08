Public Class SplashForm
    Private Sub SplashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub SplashTimer1_Tick(sender As Object, e As EventArgs) Handles SplashTimer1.Tick
        SplashTimer1.Enabled = False
        GraphicExamplesForm.Show()
        Me.Close()
    End Sub

    Private Sub SplashForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        SplashTimer1.Enabled() = True
        GraphicExamplesForm.Hide()

    End Sub

End Class