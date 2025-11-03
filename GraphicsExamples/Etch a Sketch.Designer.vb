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
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenColorContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PenColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.DrawWaveButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ColorButton = New System.Windows.Forms.Button()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SerialTextBox = New System.Windows.Forms.TextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PortsComboBox = New System.Windows.Forms.ComboBox()
        Me.COMPortLabel = New System.Windows.Forms.Label()
        Me.AnalogButton1 = New System.Windows.Forms.Button()
        Me.COMButton = New System.Windows.Forms.Button()
        Me.AnalogTimer = New System.Windows.Forms.Timer(Me.components)
        Me.XAxisTextBox = New System.Windows.Forms.TextBox()
        Me.DataLabel = New System.Windows.Forms.Label()
        Me.LeftAnalogLabel = New System.Windows.Forms.Label()
        Me.RightAnalogLabel = New System.Windows.Forms.Label()
        Me.YAxisTextBox = New System.Windows.Forms.TextBox()
        Me.PICControlRadioButton = New System.Windows.Forms.RadioButton()
        Me.MouseControlRadioButton = New System.Windows.Forms.RadioButton()
        Me.ConnectionStatusLabel = New System.Windows.Forms.Label()
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
        Me.TopMenuStrip.Size = New System.Drawing.Size(2040, 33)
        Me.TopMenuStrip.TabIndex = 0
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        Me.FileToolStripMenuItem.ToolTipText = "Allows the user to access file options"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(141, 34)
        Me.ExitToolStripMenuItem1.Text = "&Exit"
        Me.ExitToolStripMenuItem1.ToolTipText = "Closes the program"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenColorContextMenuItem, Me.ClearContextMenuItem, Me.DrawWaveformsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.EditToolStripMenuItem.Text = "&Edit"
        Me.EditToolStripMenuItem.ToolTipText = "Allows access to drawing features"
        '
        'PenColorContextMenuItem
        '
        Me.PenColorContextMenuItem.Name = "PenColorContextMenuItem"
        Me.PenColorContextMenuItem.Size = New System.Drawing.Size(247, 34)
        Me.PenColorContextMenuItem.Text = "Pen &Color"
        Me.PenColorContextMenuItem.ToolTipText = "Changes color of the drawing pen"
        '
        'ClearContextMenuItem
        '
        Me.ClearContextMenuItem.Name = "ClearContextMenuItem"
        Me.ClearContextMenuItem.Size = New System.Drawing.Size(247, 34)
        Me.ClearContextMenuItem.Text = "&Erase"
        Me.ClearContextMenuItem.ToolTipText = "Clears what has been drawn on the screen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(247, 34)
        Me.DrawWaveformsToolStripMenuItem.Text = "Draw &waveforms"
        Me.DrawWaveformsToolStripMenuItem.ToolTipText = "Draws a sin, cos, and tan lines on the screen"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        Me.HelpToolStripMenuItem.ToolTipText = "Accesses the help features"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.AboutToolStripMenuItem.Text = "&About"
        Me.AboutToolStripMenuItem.ToolTipText = "Opens access to creator info"
        '
        'MainContextMenuStrip
        '
        Me.MainContextMenuStrip.AllowDrop = True
        Me.MainContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenColorToolStripMenuItem, Me.ClearToolStripMenuItem, Me.AboutToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.MainContextMenuStrip.Name = "MainContextMenuStrip"
        Me.MainContextMenuStrip.Size = New System.Drawing.Size(179, 132)
        '
        'PenColorToolStripMenuItem
        '
        Me.PenColorToolStripMenuItem.Name = "PenColorToolStripMenuItem"
        Me.PenColorToolStripMenuItem.Size = New System.Drawing.Size(178, 32)
        Me.PenColorToolStripMenuItem.Text = "Select Color"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(178, 32)
        Me.ClearToolStripMenuItem.Text = "&Erase"
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
        Me.DrawingPictureBox.Location = New System.Drawing.Point(-113, -43)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(2141, 689)
        Me.DrawingPictureBox.TabIndex = 2
        Me.DrawingPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.DrawingPictureBox, "Right click for more options")
        '
        'DrawWaveButton
        '
        Me.DrawWaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawWaveButton.Location = New System.Drawing.Point(164, 25)
        Me.DrawWaveButton.Name = "DrawWaveButton"
        Me.DrawWaveButton.Size = New System.Drawing.Size(201, 152)
        Me.DrawWaveButton.TabIndex = 0
        Me.DrawWaveButton.Text = "&Wave"
        Me.ToolTip1.SetToolTip(Me.DrawWaveButton, "Draws various waves on the screen." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shortcut Button: Enter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.DrawWaveButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(547, 25)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(186, 158)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Erase"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clears the form. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shortcut Button: ESC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ColorButton
        '
        Me.ColorButton.Location = New System.Drawing.Point(371, 25)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(170, 152)
        Me.ColorButton.TabIndex = 1
        Me.ColorButton.Text = "&Color"
        Me.ToolTip1.SetToolTip(Me.ColorButton, "Choose your color!")
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Controls.Add(Me.MouseControlRadioButton)
        Me.ButtonGroupBox.Controls.Add(Me.ColorButton)
        Me.ButtonGroupBox.Controls.Add(Me.PICControlRadioButton)
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.DrawWaveButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(1096, 914)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(932, 183)
        Me.ButtonGroupBox.TabIndex = 3
        Me.ButtonGroupBox.TabStop = False
        Me.ButtonGroupBox.Text = "Control Box"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(739, 25)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(193, 152)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SerialTextBox
        '
        Me.SerialTextBox.Location = New System.Drawing.Point(26, 761)
        Me.SerialTextBox.Multiline = True
        Me.SerialTextBox.Name = "SerialTextBox"
        Me.SerialTextBox.Size = New System.Drawing.Size(334, 308)
        Me.SerialTextBox.TabIndex = 4
        Me.SerialTextBox.Text = "Shows all serial data"
        '
        'SerialPort1
        '
        '
        'PortsComboBox
        '
        Me.PortsComboBox.FormattingEnabled = True
        Me.PortsComboBox.Location = New System.Drawing.Point(26, 694)
        Me.PortsComboBox.Name = "PortsComboBox"
        Me.PortsComboBox.Size = New System.Drawing.Size(121, 28)
        Me.PortsComboBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.PortsComboBox, "Display your COM ports")
        '
        'COMPortLabel
        '
        Me.COMPortLabel.AutoSize = True
        Me.COMPortLabel.Location = New System.Drawing.Point(22, 671)
        Me.COMPortLabel.Name = "COMPortLabel"
        Me.COMPortLabel.Size = New System.Drawing.Size(86, 20)
        Me.COMPortLabel.TabIndex = 8
        Me.COMPortLabel.Text = "COM Ports"
        '
        'AnalogButton1
        '
        Me.AnalogButton1.Location = New System.Drawing.Point(275, 675)
        Me.AnalogButton1.Name = "AnalogButton1"
        Me.AnalogButton1.Size = New System.Drawing.Size(125, 65)
        Me.AnalogButton1.TabIndex = 9
        Me.AnalogButton1.Text = "Read Analog Data"
        Me.ToolTip1.SetToolTip(Me.AnalogButton1, "Takes 1 sample of the analog data")
        Me.AnalogButton1.UseVisualStyleBackColor = True
        '
        'COMButton
        '
        Me.COMButton.Location = New System.Drawing.Point(167, 675)
        Me.COMButton.Name = "COMButton"
        Me.COMButton.Size = New System.Drawing.Size(87, 65)
        Me.COMButton.TabIndex = 10
        Me.COMButton.Text = "COM Connect"
        Me.ToolTip1.SetToolTip(Me.COMButton, "Connect to your COM Port")
        Me.COMButton.UseVisualStyleBackColor = True
        '
        'AnalogTimer
        '
        Me.AnalogTimer.Enabled = True
        Me.AnalogTimer.Interval = 175
        '
        'XAxisTextBox
        '
        Me.XAxisTextBox.Location = New System.Drawing.Point(370, 851)
        Me.XAxisTextBox.Name = "XAxisTextBox"
        Me.XAxisTextBox.Size = New System.Drawing.Size(84, 26)
        Me.XAxisTextBox.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.XAxisTextBox, "Left Pot data")
        '
        'DataLabel
        '
        Me.DataLabel.AutoSize = True
        Me.DataLabel.Location = New System.Drawing.Point(27, 738)
        Me.DataLabel.Name = "DataLabel"
        Me.DataLabel.Size = New System.Drawing.Size(151, 20)
        Me.DataLabel.TabIndex = 12
        Me.DataLabel.Text = "Serial Data/Controls"
        '
        'LeftAnalogLabel
        '
        Me.LeftAnalogLabel.AutoSize = True
        Me.LeftAnalogLabel.Location = New System.Drawing.Point(366, 828)
        Me.LeftAnalogLabel.Name = "LeftAnalogLabel"
        Me.LeftAnalogLabel.Size = New System.Drawing.Size(130, 20)
        Me.LeftAnalogLabel.TabIndex = 13
        Me.LeftAnalogLabel.Text = "Left Analog Data"
        '
        'RightAnalogLabel
        '
        Me.RightAnalogLabel.AutoSize = True
        Me.RightAnalogLabel.Location = New System.Drawing.Point(366, 894)
        Me.RightAnalogLabel.Name = "RightAnalogLabel"
        Me.RightAnalogLabel.Size = New System.Drawing.Size(140, 20)
        Me.RightAnalogLabel.TabIndex = 14
        Me.RightAnalogLabel.Text = "Right Analog Data"
        '
        'YAxisTextBox
        '
        Me.YAxisTextBox.Location = New System.Drawing.Point(370, 917)
        Me.YAxisTextBox.Name = "YAxisTextBox"
        Me.YAxisTextBox.Size = New System.Drawing.Size(100, 26)
        Me.YAxisTextBox.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.YAxisTextBox, "Right Pot data")
        '
        'PICControlRadioButton
        '
        Me.PICControlRadioButton.AutoSize = True
        Me.PICControlRadioButton.Location = New System.Drawing.Point(6, 53)
        Me.PICControlRadioButton.Name = "PICControlRadioButton"
        Me.PICControlRadioButton.Size = New System.Drawing.Size(115, 24)
        Me.PICControlRadioButton.TabIndex = 16
        Me.PICControlRadioButton.TabStop = True
        Me.PICControlRadioButton.Text = "Knob Mode"
        Me.ToolTip1.SetToolTip(Me.PICControlRadioButton, "Draw with Pot!")
        Me.PICControlRadioButton.UseVisualStyleBackColor = True
        '
        'MouseControlRadioButton
        '
        Me.MouseControlRadioButton.AutoSize = True
        Me.MouseControlRadioButton.Location = New System.Drawing.Point(6, 110)
        Me.MouseControlRadioButton.Name = "MouseControlRadioButton"
        Me.MouseControlRadioButton.Size = New System.Drawing.Size(133, 24)
        Me.MouseControlRadioButton.TabIndex = 17
        Me.MouseControlRadioButton.TabStop = True
        Me.MouseControlRadioButton.Text = "MouseControl"
        Me.ToolTip1.SetToolTip(Me.MouseControlRadioButton, "Draw with Mouse!")
        Me.MouseControlRadioButton.UseVisualStyleBackColor = True
        '
        'ConnectionStatusLabel
        '
        Me.ConnectionStatusLabel.AutoSize = True
        Me.ConnectionStatusLabel.Location = New System.Drawing.Point(366, 980)
        Me.ConnectionStatusLabel.Name = "ConnectionStatusLabel"
        Me.ConnectionStatusLabel.Size = New System.Drawing.Size(56, 20)
        Me.ConnectionStatusLabel.TabIndex = 6
        Me.ConnectionStatusLabel.Text = "Status"
        '
        'GraphicExamplesForm
        '
        Me.AcceptButton = Me.DrawWaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(2040, 1109)
        Me.Controls.Add(Me.YAxisTextBox)
        Me.Controls.Add(Me.RightAnalogLabel)
        Me.Controls.Add(Me.LeftAnalogLabel)
        Me.Controls.Add(Me.DataLabel)
        Me.Controls.Add(Me.XAxisTextBox)
        Me.Controls.Add(Me.COMButton)
        Me.Controls.Add(Me.AnalogButton1)
        Me.Controls.Add(Me.COMPortLabel)
        Me.Controls.Add(Me.PortsComboBox)
        Me.Controls.Add(Me.ConnectionStatusLabel)
        Me.Controls.Add(Me.SerialTextBox)
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
        Me.ButtonGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenColorContextMenuItem As ToolStripMenuItem
    Friend WithEvents ClearContextMenuItem As ToolStripMenuItem
    Friend WithEvents MainContextMenuStrip As ContextMenuStrip
    Friend WithEvents PenColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents DrawWaveButton As Button
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearButton As Button
    Friend WithEvents ColorButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SerialTextBox As TextBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents PortsComboBox As ComboBox
    Friend WithEvents COMPortLabel As Label
    Friend WithEvents AnalogButton1 As Button
    Friend WithEvents COMButton As Button
    Friend WithEvents AnalogTimer As Timer
    Friend WithEvents XAxisTextBox As TextBox
    Friend WithEvents DataLabel As Label
    Friend WithEvents LeftAnalogLabel As Label
    Friend WithEvents RightAnalogLabel As Label
    Friend WithEvents YAxisTextBox As TextBox
    Friend WithEvents PICControlRadioButton As RadioButton
    Friend WithEvents MouseControlRadioButton As RadioButton
    Friend WithEvents ConnectionStatusLabel As Label
End Class
