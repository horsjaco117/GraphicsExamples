<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Me.AboutLabel1 = New System.Windows.Forms.Label()
        Me.AboutOkButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AboutLabel1
        '
        Me.AboutLabel1.Location = New System.Drawing.Point(12, 9)
        Me.AboutLabel1.Name = "AboutLabel1"
        Me.AboutLabel1.Size = New System.Drawing.Size(815, 566)
        Me.AboutLabel1.TabIndex = 0
        Me.AboutLabel1.Text = "Macrosoft Airbrush Application" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jacob Horsley" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ACME Software LLC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spring 2025 "
        '
        'AboutOkButton
        '
        Me.AboutOkButton.Location = New System.Drawing.Point(607, 465)
        Me.AboutOkButton.Name = "AboutOkButton"
        Me.AboutOkButton.Size = New System.Drawing.Size(178, 87)
        Me.AboutOkButton.TabIndex = 1
        Me.AboutOkButton.Text = "OK"
        Me.AboutOkButton.UseVisualStyleBackColor = True
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 584)
        Me.Controls.Add(Me.AboutOkButton)
        Me.Controls.Add(Me.AboutLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AboutForm"
        Me.Text = "Macrosoft airbrush"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AboutLabel1 As Label
    Friend WithEvents AboutOkButton As Button
End Class
