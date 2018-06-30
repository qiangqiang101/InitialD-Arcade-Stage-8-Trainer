<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTrainer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrainer))
        Me.opt1 = New System.Windows.Forms.Label()
        Me.opt2 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAutoPatch = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.BackColor = System.Drawing.Color.Transparent
        Me.opt1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.opt1.ForeColor = System.Drawing.Color.White
        Me.opt1.Location = New System.Drawing.Point(187, 188)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(244, 28)
        Me.opt1.TabIndex = 0
        Me.opt1.Text = "ALT + 1 - Disable Free Play"
        '
        'opt2
        '
        Me.opt2.AutoSize = True
        Me.opt2.BackColor = System.Drawing.Color.Transparent
        Me.opt2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.opt2.ForeColor = System.Drawing.Color.White
        Me.opt2.Location = New System.Drawing.Point(187, 216)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(236, 28)
        Me.opt2.TabIndex = 1
        Me.opt2.Text = "ALT + 2 - Unlimited Coins"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(12, 407)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(190, 15)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "Game not found, trainer is waiting."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 75)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Created by I'm Not MentaL && Lemon The Kid" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Required: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TeknoParrot 1.51 Hot Fi" &
    "x 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "InitialD 8∞ 1.2+B Update" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cbAutoPatch
        '
        Me.cbAutoPatch.AutoSize = True
        Me.cbAutoPatch.BackColor = System.Drawing.Color.Transparent
        Me.cbAutoPatch.ForeColor = System.Drawing.Color.White
        Me.cbAutoPatch.Location = New System.Drawing.Point(328, 406)
        Me.cbAutoPatch.Name = "cbAutoPatch"
        Me.cbAutoPatch.Size = New System.Drawing.Size(130, 19)
        Me.cbAutoPatch.TabIndex = 4
        Me.cbAutoPatch.Text = "Auto Patch && Close"
        Me.cbAutoPatch.UseVisualStyleBackColor = False
        '
        'frmTrainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.InitialD8NoFreePlay.My.Resources.Resources.base_bg_index_trans
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(470, 437)
        Me.Controls.Add(Me.cbAutoPatch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.opt2)
        Me.Controls.Add(Me.opt1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTrainer"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InitialD 8∞ +2 Trainer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents opt1 As Label
    Friend WithEvents opt2 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents cbAutoPatch As CheckBox
End Class
