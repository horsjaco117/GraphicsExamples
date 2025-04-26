<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GraphicExamplesForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForegroundColorContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WidthContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox2 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WidthToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ForegroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.DrawWaveButton = New System.Windows.Forms.Button()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopMenuStrip.SuspendLayout()
        Me.MainContextMenuStrip.SuspendLayout()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(956, 33)
        Me.TopMenuStrip.TabIndex = 0
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForegroundColorContextMenuItem, Me.BackgroundColorContextMenuItem, Me.WidthContextMenuItem, Me.FontContextMenuItem, Me.ClearContextMenuItem, Me.WidthToolStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ForegroundColorContextMenuItem
        '
        Me.ForegroundColorContextMenuItem.Name = "ForegroundColorContextMenuItem"
        Me.ForegroundColorContextMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ForegroundColorContextMenuItem.Text = "Foreground &Color"
        '
        'BackgroundColorContextMenuItem
        '
        Me.BackgroundColorContextMenuItem.Name = "BackgroundColorContextMenuItem"
        Me.BackgroundColorContextMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.BackgroundColorContextMenuItem.Text = "Background Color"
        '
        'WidthContextMenuItem
        '
        Me.WidthContextMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox2, Me.ToolStripSeparator1, Me.ToolStripMenuItem1})
        Me.WidthContextMenuItem.Name = "WidthContextMenuItem"
        Me.WidthContextMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.WidthContextMenuItem.Text = "Width"
        '
        'ToolStripComboBox2
        '
        Me.ToolStripComboBox2.Name = "ToolStripComboBox2"
        Me.ToolStripComboBox2.Size = New System.Drawing.Size(121, 33)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(271, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(274, 34)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'FontContextMenuItem
        '
        Me.FontContextMenuItem.Name = "FontContextMenuItem"
        Me.FontContextMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.FontContextMenuItem.Text = "Font"
        '
        'ClearContextMenuItem
        '
        Me.ClearContextMenuItem.Name = "ClearContextMenuItem"
        Me.ClearContextMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ClearContextMenuItem.Text = "Clear"
        '
        'WidthToolStripMenuItem1
        '
        Me.WidthToolStripMenuItem1.Name = "WidthToolStripMenuItem1"
        Me.WidthToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.WidthToolStripMenuItem1.Text = "Width"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MainContextMenuStrip
        '
        Me.MainContextMenuStrip.AllowDrop = True
        Me.MainContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForegroundColorToolStripMenuItem, Me.ClearToolStripMenuItem, Me.AboutToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.MainContextMenuStrip.Name = "MainContextMenuStrip"
        Me.MainContextMenuStrip.Size = New System.Drawing.Size(179, 132)
        '
        'ForegroundColorToolStripMenuItem
        '
        Me.ForegroundColorToolStripMenuItem.Name = "ForegroundColorToolStripMenuItem"
        Me.ForegroundColorToolStripMenuItem.Size = New System.Drawing.Size(178, 32)
        Me.ForegroundColorToolStripMenuItem.Text = "Select Color"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(178, 32)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(178, 32)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(178, 32)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawingPictureBox.BackColor = System.Drawing.Color.White
        Me.DrawingPictureBox.ContextMenuStrip = Me.MainContextMenuStrip
        Me.DrawingPictureBox.Cursor = System.Windows.Forms.Cursors.Cross
        Me.DrawingPictureBox.Location = New System.Drawing.Point(12, 36)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(932, 535)
        Me.DrawingPictureBox.TabIndex = 2
        Me.DrawingPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.DrawingPictureBox, "Right click for more options")
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGroupBox.Controls.Add(Me.DrawWaveButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(12, 582)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(932, 183)
        Me.ButtonGroupBox.TabIndex = 3
        Me.ButtonGroupBox.TabStop = False
        Me.ButtonGroupBox.Text = "GroupBox1"
        '
        'DrawWaveButton
        '
        Me.DrawWaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawWaveButton.Location = New System.Drawing.Point(725, 25)
        Me.DrawWaveButton.Name = "DrawWaveButton"
        Me.DrawWaveButton.Size = New System.Drawing.Size(201, 152)
        Me.DrawWaveButton.TabIndex = 0
        Me.DrawWaveButton.Text = "&Wave"
        Me.DrawWaveButton.UseVisualStyleBackColor = True
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'GraphicExamplesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 777)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "GraphicExamplesForm"
        Me.Text = "Macrohard Airbrush"
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.MainContextMenuStrip.ResumeLayout(False)
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForegroundColorContextMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorContextMenuItem As ToolStripMenuItem
    Friend WithEvents WidthContextMenuItem As ToolStripMenuItem
    Friend WithEvents FontContextMenuItem As ToolStripMenuItem
    Friend WithEvents ClearContextMenuItem As ToolStripMenuItem
    Friend WithEvents MainContextMenuStrip As ContextMenuStrip
    Friend WithEvents ForegroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents ToolStripComboBox2 As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WidthToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents DrawWaveButton As Button
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
End Class
