﻿Public Class SplashForm
    Private Sub SplashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub SplashForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        GraphicExamplesForm.SendToBack()
        GraphicExamplesForm.Hide()
        SplashTimer1.Enabled() = True

    End Sub

    Private Sub SplashTimer1_Tick(sender As Object, e As EventArgs) Handles SplashTimer1.Tick
        SplashTimer1.Enabled = False
        GraphicExamplesForm.Show()
        Me.Close()
    End Sub


End Class