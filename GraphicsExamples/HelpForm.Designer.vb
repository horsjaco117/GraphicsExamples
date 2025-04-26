<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.InfoLabel = New System.Windows.Forms.Label()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'InfoLabel
        '
        Me.InfoLabel.Location = New System.Drawing.Point(37, 37)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(605, 328)
        Me.InfoLabel.TabIndex = 0
        Me.InfoLabel.Text = "Jacob Horsley" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RCET 0265" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Etch a Sketch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spring 2025" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ToolTip1.SetToolTip(Me.InfoLabel, "Programmer information")
        '
        'ReturnButton
        '
        Me.ReturnButton.Location = New System.Drawing.Point(626, 313)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(162, 113)
        Me.ReturnButton.TabIndex = 1
        Me.ReturnButton.Text = "Return"
        Me.ToolTip1.SetToolTip(Me.ReturnButton, "Returns back to Main drawing page")
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'HelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.InfoLabel)
        Me.Name = "HelpForm"
        Me.Text = "HelpForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InfoLabel As Label
    Friend WithEvents ReturnButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
