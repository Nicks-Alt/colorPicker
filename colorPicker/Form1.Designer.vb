<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColorPicker
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
        Me.panColorPanel = New System.Windows.Forms.Panel()
        Me.tmrBackgroundTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblOnOff = New System.Windows.Forms.Label()
        Me.panStatus = New System.Windows.Forms.Panel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenColorPickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyRGBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyHEXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panColorPanel
        '
        Me.panColorPanel.BackColor = System.Drawing.Color.Black
        Me.panColorPanel.Location = New System.Drawing.Point(12, 24)
        Me.panColorPanel.Name = "panColorPanel"
        Me.panColorPanel.Size = New System.Drawing.Size(124, 100)
        Me.panColorPanel.TabIndex = 2
        '
        'tmrBackgroundTimer
        '
        Me.tmrBackgroundTimer.Interval = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.Location = New System.Drawing.Point(14, 168)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(39, 13)
        Me.lblRed.TabIndex = 3
        Me.lblRed.Text = "Red: 0"
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.Location = New System.Drawing.Point(14, 190)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(48, 13)
        Me.lblGreen.TabIndex = 4
        Me.lblGreen.Text = "Green: 0"
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Location = New System.Drawing.Point(14, 212)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(40, 13)
        Me.lblBlue.TabIndex = 5
        Me.lblBlue.Text = "Blue: 0"
        '
        'lblOnOff
        '
        Me.lblOnOff.AutoSize = True
        Me.lblOnOff.BackColor = System.Drawing.Color.Transparent
        Me.lblOnOff.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOnOff.Location = New System.Drawing.Point(14, 132)
        Me.lblOnOff.Name = "lblOnOff"
        Me.lblOnOff.Size = New System.Drawing.Size(53, 13)
        Me.lblOnOff.TabIndex = 8
        Me.lblOnOff.Text = "STATUS:"
        '
        'panStatus
        '
        Me.panStatus.BackColor = System.Drawing.Color.PaleVioletRed
        Me.panStatus.Location = New System.Drawing.Point(74, 127)
        Me.panStatus.Name = "panStatus"
        Me.panStatus.Size = New System.Drawing.Size(20, 22)
        Me.panStatus.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(155, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenColorPickerToolStripMenuItem, Me.CopyRGBToolStripMenuItem, Me.CopyHEXToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'OpenColorPickerToolStripMenuItem
        '
        Me.OpenColorPickerToolStripMenuItem.Name = "OpenColorPickerToolStripMenuItem"
        Me.OpenColorPickerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenColorPickerToolStripMenuItem.Text = "Open Color Picker"
        '
        'CopyRGBToolStripMenuItem
        '
        Me.CopyRGBToolStripMenuItem.Name = "CopyRGBToolStripMenuItem"
        Me.CopyRGBToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CopyRGBToolStripMenuItem.Text = "Copy RGB"
        '
        'CopyHEXToolStripMenuItem
        '
        Me.CopyHEXToolStripMenuItem.Name = "CopyHEXToolStripMenuItem"
        Me.CopyHEXToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CopyHEXToolStripMenuItem.Text = "Copy HEX"
        '
        'frmColorPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(155, 245)
        Me.Controls.Add(Me.panStatus)
        Me.Controls.Add(Me.lblOnOff)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.panColorPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmColorPicker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panColorPanel As Panel
    Friend WithEvents tmrBackgroundTimer As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblRed As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblOnOff As Label
    Friend WithEvents panStatus As Panel
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyRGBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyHEXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenColorPickerToolStripMenuItem As ToolStripMenuItem
End Class
