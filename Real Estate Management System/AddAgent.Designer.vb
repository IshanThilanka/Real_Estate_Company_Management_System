<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAgent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddAgent))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnbrowseAgeimg = New Guna.UI2.WinForms.Guna2Button()
        Me.pcBoxAddAgeImage = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnaddAgent = New Guna.UI2.WinForms.Guna2Button()
        Me.lblPropertyName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtphone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtemail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtaddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDescription = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btncusfrmclose = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblAddcustomer = New System.Windows.Forms.Label()
        Me.Panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.pcBoxAddAgeImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.btncusfrmclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.btnbrowseAgeimg)
        Me.Guna2GroupBox1.Controls.Add(Me.pcBoxAddAgeImage)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Poppins Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(638, 23)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(487, 373)
        Me.Guna2GroupBox1.TabIndex = 43
        Me.Guna2GroupBox1.Text = "Agent Image"
        '
        'btnbrowseAgeimg
        '
        Me.btnbrowseAgeimg.BackColor = System.Drawing.Color.Transparent
        Me.btnbrowseAgeimg.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnbrowseAgeimg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnbrowseAgeimg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnbrowseAgeimg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnbrowseAgeimg.FillColor = System.Drawing.Color.Black
        Me.btnbrowseAgeimg.Font = New System.Drawing.Font("Poppins Light", 8.0!)
        Me.btnbrowseAgeimg.ForeColor = System.Drawing.Color.White
        Me.btnbrowseAgeimg.Location = New System.Drawing.Point(354, 325)
        Me.btnbrowseAgeimg.Name = "btnbrowseAgeimg"
        Me.btnbrowseAgeimg.Size = New System.Drawing.Size(96, 31)
        Me.btnbrowseAgeimg.TabIndex = 30
        Me.btnbrowseAgeimg.Text = "Browse"
        Me.btnbrowseAgeimg.UseTransparentBackground = True
        '
        'pcBoxAddAgeImage
        '
        Me.pcBoxAddAgeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcBoxAddAgeImage.ImageRotate = 0!
        Me.pcBoxAddAgeImage.Location = New System.Drawing.Point(33, 56)
        Me.pcBoxAddAgeImage.Name = "pcBoxAddAgeImage"
        Me.pcBoxAddAgeImage.Size = New System.Drawing.Size(417, 253)
        Me.pcBoxAddAgeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcBoxAddAgeImage.TabIndex = 0
        Me.pcBoxAddAgeImage.TabStop = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.AutoSizeHeightOnly = True
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(57, 58)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(222, 31)
        Me.Guna2HtmlLabel1.TabIndex = 40
        Me.Guna2HtmlLabel1.Text = "Agent Name"
        '
        'btnaddAgent
        '
        Me.btnaddAgent.BackColor = System.Drawing.Color.Transparent
        Me.btnaddAgent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnaddAgent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnaddAgent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnaddAgent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnaddAgent.FillColor = System.Drawing.Color.Gold
        Me.btnaddAgent.Font = New System.Drawing.Font("Poppins Light", 10.0!)
        Me.btnaddAgent.ForeColor = System.Drawing.Color.Black
        Me.btnaddAgent.Location = New System.Drawing.Point(505, 456)
        Me.btnaddAgent.Name = "btnaddAgent"
        Me.btnaddAgent.Size = New System.Drawing.Size(202, 50)
        Me.btnaddAgent.TabIndex = 39
        Me.btnaddAgent.Text = "Add Agent"
        Me.btnaddAgent.UseTransparentBackground = True
        '
        'lblPropertyName
        '
        Me.lblPropertyName.AutoSize = False
        Me.lblPropertyName.AutoSizeHeightOnly = True
        Me.lblPropertyName.BackColor = System.Drawing.Color.Transparent
        Me.lblPropertyName.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropertyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPropertyName.Location = New System.Drawing.Point(57, 130)
        Me.lblPropertyName.Name = "lblPropertyName"
        Me.lblPropertyName.Size = New System.Drawing.Size(222, 31)
        Me.lblPropertyName.TabIndex = 33
        Me.lblPropertyName.Text = "Address"
        '
        'txtphone
        '
        Me.txtphone.Animated = True
        Me.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtphone.DefaultText = ""
        Me.txtphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtphone.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.txtphone.ForeColor = System.Drawing.Color.Black
        Me.txtphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtphone.Location = New System.Drawing.Point(329, 262)
        Me.txtphone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtphone.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtphone.PlaceholderText = "ex:077xxxxxxx"
        Me.txtphone.SelectedText = ""
        Me.txtphone.Size = New System.Drawing.Size(260, 32)
        Me.txtphone.TabIndex = 35
        '
        'txtemail
        '
        Me.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemail.DefaultText = ""
        Me.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemail.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.ForeColor = System.Drawing.Color.Black
        Me.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemail.Location = New System.Drawing.Point(329, 195)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.PlaceholderText = ""
        Me.txtemail.SelectedText = ""
        Me.txtemail.Size = New System.Drawing.Size(260, 32)
        Me.txtemail.TabIndex = 36
        '
        'txtaddress
        '
        Me.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddress.DefaultText = ""
        Me.txtaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddress.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.ForeColor = System.Drawing.Color.Black
        Me.txtaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddress.Location = New System.Drawing.Point(329, 130)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddress.PlaceholderText = ""
        Me.txtaddress.SelectedText = ""
        Me.txtaddress.Size = New System.Drawing.Size(260, 32)
        Me.txtaddress.TabIndex = 37
        '
        'txtname
        '
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.DefaultText = ""
        Me.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.Black
        Me.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.Location = New System.Drawing.Point(329, 58)
        Me.txtname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.PlaceholderText = ""
        Me.txtname.SelectedText = ""
        Me.txtname.Size = New System.Drawing.Size(260, 32)
        Me.txtname.TabIndex = 38
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = False
        Me.lblPrice.AutoSizeHeightOnly = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPrice.Location = New System.Drawing.Point(57, 262)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(261, 31)
        Me.lblPrice.TabIndex = 32
        Me.lblPrice.Text = "Phone Number"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = False
        Me.lblDescription.AutoSizeHeightOnly = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDescription.Location = New System.Drawing.Point(57, 195)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(202, 31)
        Me.lblDescription.TabIndex = 34
        Me.lblDescription.Text = "Email"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel1.BackgroundImage = CType(resources.GetObject("Guna2Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.btnaddAgent)
        Me.Guna2Panel1.Controls.Add(Me.lblPropertyName)
        Me.Guna2Panel1.Controls.Add(Me.txtphone)
        Me.Guna2Panel1.Controls.Add(Me.txtemail)
        Me.Guna2Panel1.Controls.Add(Me.txtaddress)
        Me.Guna2Panel1.Controls.Add(Me.txtname)
        Me.Guna2Panel1.Controls.Add(Me.lblPrice)
        Me.Guna2Panel1.Controls.Add(Me.lblDescription)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-3, 81)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1183, 576)
        Me.Guna2Panel1.TabIndex = 5
        Me.Guna2Panel1.UseWaitCursor = True
        '
        'btncusfrmclose
        '
        Me.btncusfrmclose.BackColor = System.Drawing.Color.Transparent
        Me.btncusfrmclose.FillColor = System.Drawing.Color.Transparent
        Me.btncusfrmclose.Image = CType(resources.GetObject("btncusfrmclose.Image"), System.Drawing.Image)
        Me.btncusfrmclose.ImageRotate = 0!
        Me.btncusfrmclose.Location = New System.Drawing.Point(28, 15)
        Me.btncusfrmclose.Name = "btncusfrmclose"
        Me.btncusfrmclose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btncusfrmclose.Size = New System.Drawing.Size(45, 40)
        Me.btncusfrmclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btncusfrmclose.TabIndex = 114
        Me.btncusfrmclose.TabStop = False
        Me.btncusfrmclose.UseTransparentBackground = True
        '
        'lblAddcustomer
        '
        Me.lblAddcustomer.AutoSize = True
        Me.lblAddcustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblAddcustomer.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddcustomer.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAddcustomer.Location = New System.Drawing.Point(99, 15)
        Me.lblAddcustomer.Name = "lblAddcustomer"
        Me.lblAddcustomer.Size = New System.Drawing.Size(216, 44)
        Me.lblAddcustomer.TabIndex = 0
        Me.lblAddcustomer.Text = "Add New Agent "
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.btncusfrmclose)
        Me.Panel.Controls.Add(Me.lblAddcustomer)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(1172, 75)
        Me.Panel.TabIndex = 4
        '
        'AddAgent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 646)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel)
        Me.Name = "AddAgent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Agent"
        Me.UseWaitCursor = True
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.pcBoxAddAgeImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.btncusfrmclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnbrowseAgeimg As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pcBoxAddAgeImage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnaddAgent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPropertyName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtphone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtemail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtaddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDescription As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btncusfrmclose As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblAddcustomer As Label
    Friend WithEvents Panel As Guna.UI2.WinForms.Guna2Panel
End Class
