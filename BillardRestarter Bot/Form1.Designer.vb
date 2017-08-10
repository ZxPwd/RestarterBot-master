<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tmrStartBot = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPause = New System.Windows.Forms.Timer(Me.components)
        Me.tmrWait = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStartBot2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStartBot3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBsTv = New System.Windows.Forms.Timer(Me.components)
        Me.tmrWelcome = New System.Windows.Forms.Timer(Me.components)
        Me.tmrHotkey = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New BillardRestarter_Bot.FormSkin()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FlatListBox1 = New System.Windows.Forms.ListBox()
        Me.lblItemCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlatMini1 = New BillardRestarter_Bot.FlatMini()
        Me.FlatClose1 = New BillardRestarter_Bot.FlatClose()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrStartBot
        '
        Me.tmrStartBot.Interval = 2000
        '
        'tmrPause
        '
        Me.tmrPause.Interval = 25000
        '
        'tmrWait
        '
        Me.tmrWait.Interval = 3000
        '
        'tmrStartBot2
        '
        Me.tmrStartBot2.Interval = 2000
        '
        'tmrStartBot3
        '
        Me.tmrStartBot3.Interval = 2000
        '
        'tmrBsTv
        '
        Me.tmrBsTv.Interval = 2500
        '
        'tmrWelcome
        '
        Me.tmrWelcome.Interval = 5000
        '
        'tmrHotkey
        '
        Me.tmrHotkey.Interval = 900
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.Label6)
        Me.FormSkin1.Controls.Add(Me.FlatListBox1)
        Me.FormSkin1.Controls.Add(Me.lblItemCount)
        Me.FormSkin1.Controls.Add(Me.Label4)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.lblStatus)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(304, 614)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Billard RestarterBot"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(5, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 21)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "MAX 75:"
        '
        'FlatListBox1
        '
        Me.FlatListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FlatListBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatListBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FlatListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FlatListBox1.FormattingEnabled = True
        Me.FlatListBox1.ItemHeight = 15
        Me.FlatListBox1.Location = New System.Drawing.Point(0, 119)
        Me.FlatListBox1.Name = "FlatListBox1"
        Me.FlatListBox1.Size = New System.Drawing.Size(304, 495)
        Me.FlatListBox1.TabIndex = 12
        '
        'lblItemCount
        '
        Me.lblItemCount.AutoSize = True
        Me.lblItemCount.BackColor = System.Drawing.Color.Transparent
        Me.lblItemCount.ForeColor = System.Drawing.Color.Red
        Me.lblItemCount.Location = New System.Drawing.Point(74, 84)
        Me.lblItemCount.Name = "lblItemCount"
        Me.lblItemCount.Size = New System.Drawing.Size(19, 21)
        Me.lblItemCount.TabIndex = 10
        Me.lblItemCount.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(213, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Version 2.0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "August 10, 2017"
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(258, 16)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 6
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(282, 16)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 5
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblStatus.Location = New System.Drawing.Point(6, 52)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(63, 16)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Waiting..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 614)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents lblStatus As Label
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents tmrStartBot As Timer
    Friend WithEvents tmrPause As Timer
    Friend WithEvents tmrWait As Timer
    Friend WithEvents tmrStartBot2 As Timer
    Friend WithEvents tmrStartBot3 As Timer
    Friend WithEvents tmrBsTv As Timer
    Friend WithEvents tmrWelcome As Timer
    Friend WithEvents tmrHotkey As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblItemCount As Label
    Friend WithEvents FlatListBox1 As ListBox
    Friend WithEvents Label6 As Label
End Class
