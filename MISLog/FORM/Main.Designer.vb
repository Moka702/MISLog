<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.test = New System.Windows.Forms.Button()
        Me.chat_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bot_token = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.save = New System.Windows.Forms.Button()
        Me.send_telegram = New System.Windows.Forms.CheckBox()
        Me.start = New System.Windows.Forms.Button()
        Me.lbl_state = New System.Windows.Forms.Label()
        Me.TimerTelegram = New System.Windows.Forms.Timer(Me.components)
        Me.hidden = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'test
        '
        Me.test.Location = New System.Drawing.Point(197, 127)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(68, 23)
        Me.test.TabIndex = 10
        Me.test.Text = "TEST"
        Me.test.UseVisualStyleBackColor = True
        '
        'chat_id
        '
        Me.chat_id.Location = New System.Drawing.Point(12, 97)
        Me.chat_id.Name = "chat_id"
        Me.chat_id.Size = New System.Drawing.Size(331, 20)
        Me.chat_id.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Chat ID"
        '
        'bot_token
        '
        Me.bot_token.Location = New System.Drawing.Point(12, 56)
        Me.bot_token.Name = "bot_token"
        Me.bot_token.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.bot_token.Size = New System.Drawing.Size(331, 20)
        Me.bot_token.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "BOT Token"
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(275, 127)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(68, 23)
        Me.save.TabIndex = 11
        Me.save.Text = "SAVE"
        Me.save.UseVisualStyleBackColor = True
        '
        'send_telegram
        '
        Me.send_telegram.AutoSize = True
        Me.send_telegram.Location = New System.Drawing.Point(12, 12)
        Me.send_telegram.Name = "send_telegram"
        Me.send_telegram.Size = New System.Drawing.Size(116, 17)
        Me.send_telegram.TabIndex = 12
        Me.send_telegram.Text = "Sendo to Telegram"
        Me.send_telegram.UseVisualStyleBackColor = True
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(12, 161)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(329, 23)
        Me.start.TabIndex = 13
        Me.start.Text = "START"
        Me.start.UseVisualStyleBackColor = True
        '
        'lbl_state
        '
        Me.lbl_state.AutoSize = True
        Me.lbl_state.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_state.Location = New System.Drawing.Point(12, 193)
        Me.lbl_state.Name = "lbl_state"
        Me.lbl_state.Size = New System.Drawing.Size(58, 13)
        Me.lbl_state.TabIndex = 14
        Me.lbl_state.Text = "STOPPED"
        '
        'TimerTelegram
        '
        Me.TimerTelegram.Interval = 60000
        '
        'hidden
        '
        Me.hidden.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.hidden.Icon = CType(resources.GetObject("hidden.Icon"), System.Drawing.Icon)
        Me.hidden.Text = "MISLog"
        Me.hidden.Visible = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 216)
        Me.Controls.Add(Me.lbl_state)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.send_telegram)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.test)
        Me.Controls.Add(Me.chat_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bot_token)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MISLog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents test As Button
    Friend WithEvents chat_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents bot_token As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents save As Button
    Friend WithEvents send_telegram As CheckBox
    Friend WithEvents start As Button
    Friend WithEvents lbl_state As Label
    Friend WithEvents TimerTelegram As Timer
    Friend WithEvents hidden As NotifyIcon
End Class
