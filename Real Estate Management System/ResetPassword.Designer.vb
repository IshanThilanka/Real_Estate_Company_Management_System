<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResetPassword))
        Me.Panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblAddProperty = New System.Windows.Forms.Label()
        Me.txtnewpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnewRpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnresetPssword = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.lblAddProperty)
        Me.Panel.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel.Location = New System.Drawing.Point(127, 59)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(847, 86)
        Me.Panel.TabIndex = 42
        '
        'lblAddProperty
        '
        Me.lblAddProperty.AutoSize = True
        Me.lblAddProperty.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblAddProperty.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddProperty.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAddProperty.Location = New System.Drawing.Point(27, 25)
        Me.lblAddProperty.Name = "lblAddProperty"
        Me.lblAddProperty.Size = New System.Drawing.Size(215, 44)
        Me.lblAddProperty.TabIndex = 0
        Me.lblAddProperty.Text = "Reset Password"
        '
        'txtnewpassword
        '
        Me.txtnewpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnewpassword.DefaultText = ""
        Me.txtnewpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnewpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnewpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnewpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnewpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnewpassword.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpassword.ForeColor = System.Drawing.Color.Black
        Me.txtnewpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnewpassword.Location = New System.Drawing.Point(485, 219)
        Me.txtnewpassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnewpassword.Name = "txtnewpassword"
        Me.txtnewpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnewpassword.PlaceholderText = ""
        Me.txtnewpassword.SelectedText = ""
        Me.txtnewpassword.Size = New System.Drawing.Size(351, 36)
        Me.txtnewpassword.TabIndex = 3
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2Panel1.BackgroundImage = CType(resources.GetObject("Guna2Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.txtnewRpassword)
        Me.Guna2Panel1.Controls.Add(Me.txtnewpassword)
        Me.Guna2Panel1.Controls.Add(Me.Panel)
        Me.Guna2Panel1.Controls.Add(Me.btnresetPssword)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-125, -60)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(990, 661)
        Me.Guna2Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(234, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 30)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Retype New Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 30)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "New Password"
        '
        'txtnewRpassword
        '
        Me.txtnewRpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnewRpassword.DefaultText = ""
        Me.txtnewRpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnewRpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnewRpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnewRpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnewRpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnewRpassword.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewRpassword.ForeColor = System.Drawing.Color.Black
        Me.txtnewRpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnewRpassword.Location = New System.Drawing.Point(485, 302)
        Me.txtnewRpassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnewRpassword.Name = "txtnewRpassword"
        Me.txtnewRpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnewRpassword.PlaceholderText = ""
        Me.txtnewRpassword.SelectedText = ""
        Me.txtnewRpassword.Size = New System.Drawing.Size(351, 36)
        Me.txtnewRpassword.TabIndex = 43
        '
        'btnresetPssword
        '
        Me.btnresetPssword.Animated = True
        Me.btnresetPssword.BackColor = System.Drawing.Color.Transparent
        Me.btnresetPssword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnresetPssword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnresetPssword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnresetPssword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnresetPssword.FillColor = System.Drawing.Color.Gold
        Me.btnresetPssword.Font = New System.Drawing.Font("Poppins Light", 10.0!)
        Me.btnresetPssword.ForeColor = System.Drawing.Color.Black
        Me.btnresetPssword.IndicateFocus = True
        Me.btnresetPssword.Location = New System.Drawing.Point(396, 396)
        Me.btnresetPssword.Name = "btnresetPssword"
        Me.btnresetPssword.Size = New System.Drawing.Size(202, 50)
        Me.btnresetPssword.TabIndex = 40
        Me.btnresetPssword.Text = "Reset Password"
        Me.btnresetPssword.UseTransparentBackground = True
        '
        'ResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 496)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ResetPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ResetPassword"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblAddProperty As Label
    Friend WithEvents txtnewpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnresetPssword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtnewRpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
