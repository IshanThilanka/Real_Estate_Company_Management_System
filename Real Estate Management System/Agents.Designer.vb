<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agents))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelcusdetails = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnAgeEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.lblAgeaddress = New System.Windows.Forms.Label()
        Me.picboxAgentimg = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblAgemobile = New System.Windows.Forms.Label()
        Me.lblAgeemail = New System.Windows.Forms.Label()
        Me.lblAgename = New System.Windows.Forms.Label()
        Me.lblcustomeremail = New System.Windows.Forms.Label()
        Me.lblphone = New System.Windows.Forms.Label()
        Me.lblcustomername = New System.Windows.Forms.Label()
        Me.btnAddAgent = New Guna.UI2.WinForms.Guna2Button()
        Me.AgentDataGrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.panelcusdetails.SuspendLayout()
        CType(Me.picboxAgentimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgentDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(88, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1394, 947)
        Me.Guna2Panel2.TabIndex = 0
        Me.Guna2Panel2.UseTransparentBackground = True
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackgroundImage = CType(resources.GetObject("Guna2Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel4.Controls.Add(Me.panelcusdetails)
        Me.Guna2Panel4.Controls.Add(Me.btnAddAgent)
        Me.Guna2Panel4.Controls.Add(Me.AgentDataGrid)
        Me.Guna2Panel4.Location = New System.Drawing.Point(15, 198)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(1376, 729)
        Me.Guna2Panel4.TabIndex = 113
        '
        'panelcusdetails
        '
        Me.panelcusdetails.BackColor = System.Drawing.Color.Transparent
        Me.panelcusdetails.Controls.Add(Me.btnAgeEdit)
        Me.panelcusdetails.Controls.Add(Me.lblAgeaddress)
        Me.panelcusdetails.Controls.Add(Me.picboxAgentimg)
        Me.panelcusdetails.Controls.Add(Me.lblAgemobile)
        Me.panelcusdetails.Controls.Add(Me.lblAgeemail)
        Me.panelcusdetails.Controls.Add(Me.lblAgename)
        Me.panelcusdetails.Controls.Add(Me.lblcustomeremail)
        Me.panelcusdetails.Controls.Add(Me.lblphone)
        Me.panelcusdetails.Controls.Add(Me.lblcustomername)
        Me.panelcusdetails.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelcusdetails.ForeColor = System.Drawing.Color.Black
        Me.panelcusdetails.Location = New System.Drawing.Point(513, 40)
        Me.panelcusdetails.Name = "panelcusdetails"
        Me.panelcusdetails.Size = New System.Drawing.Size(841, 512)
        Me.panelcusdetails.TabIndex = 116
        Me.panelcusdetails.Text = "Details of the Agent"
        '
        'btnAgeEdit
        '
        Me.btnAgeEdit.Animated = True
        Me.btnAgeEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAgeEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAgeEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAgeEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAgeEdit.FillColor = System.Drawing.Color.Gold
        Me.btnAgeEdit.Font = New System.Drawing.Font("Poppins Light", 9.0!)
        Me.btnAgeEdit.ForeColor = System.Drawing.Color.Black
        Me.btnAgeEdit.IndicateFocus = True
        Me.btnAgeEdit.Location = New System.Drawing.Point(647, 367)
        Me.btnAgeEdit.Name = "btnAgeEdit"
        Me.btnAgeEdit.Size = New System.Drawing.Size(163, 95)
        Me.btnAgeEdit.TabIndex = 112
        Me.btnAgeEdit.Text = "Edit Details"
        Me.btnAgeEdit.Visible = False
        '
        'lblAgeaddress
        '
        Me.lblAgeaddress.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeaddress.Location = New System.Drawing.Point(427, 244)
        Me.lblAgeaddress.Name = "lblAgeaddress"
        Me.lblAgeaddress.Size = New System.Drawing.Size(228, 171)
        Me.lblAgeaddress.TabIndex = 9
        Me.lblAgeaddress.Text = "Agent Addrress"
        Me.lblAgeaddress.Visible = False
        '
        'picboxAgentimg
        '
        Me.picboxAgentimg.BackColor = System.Drawing.Color.Transparent
        Me.picboxAgentimg.ImageRotate = 0!
        Me.picboxAgentimg.Location = New System.Drawing.Point(24, 59)
        Me.picboxAgentimg.Name = "picboxAgentimg"
        Me.picboxAgentimg.Size = New System.Drawing.Size(329, 267)
        Me.picboxAgentimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxAgentimg.TabIndex = 8
        Me.picboxAgentimg.TabStop = False
        '
        'lblAgemobile
        '
        Me.lblAgemobile.AutoSize = True
        Me.lblAgemobile.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgemobile.ForeColor = System.Drawing.Color.Black
        Me.lblAgemobile.Location = New System.Drawing.Point(427, 186)
        Me.lblAgemobile.Name = "lblAgemobile"
        Me.lblAgemobile.Size = New System.Drawing.Size(146, 30)
        Me.lblAgemobile.TabIndex = 6
        Me.lblAgemobile.Text = "Agent PNumber"
        Me.lblAgemobile.Visible = False
        '
        'lblAgeemail
        '
        Me.lblAgeemail.AutoSize = True
        Me.lblAgeemail.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeemail.ForeColor = System.Drawing.Color.Black
        Me.lblAgeemail.Location = New System.Drawing.Point(427, 133)
        Me.lblAgeemail.Name = "lblAgeemail"
        Me.lblAgeemail.Size = New System.Drawing.Size(113, 30)
        Me.lblAgeemail.TabIndex = 5
        Me.lblAgeemail.Text = "Agent Email"
        Me.lblAgeemail.Visible = False
        '
        'lblAgename
        '
        Me.lblAgename.AutoSize = True
        Me.lblAgename.Font = New System.Drawing.Font("Poppins Medium", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgename.ForeColor = System.Drawing.Color.Black
        Me.lblAgename.Location = New System.Drawing.Point(422, 59)
        Me.lblAgename.Name = "lblAgename"
        Me.lblAgename.Size = New System.Drawing.Size(241, 60)
        Me.lblAgename.TabIndex = 4
        Me.lblAgename.Text = "Agent Name"
        Me.lblAgename.Visible = False
        '
        'lblcustomeremail
        '
        Me.lblcustomeremail.AutoSize = True
        Me.lblcustomeremail.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomeremail.Location = New System.Drawing.Point(145, 151)
        Me.lblcustomeremail.Name = "lblcustomeremail"
        Me.lblcustomeremail.Size = New System.Drawing.Size(0, 36)
        Me.lblcustomeremail.TabIndex = 2
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone.Location = New System.Drawing.Point(145, 105)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(0, 36)
        Me.lblphone.TabIndex = 1
        '
        'lblcustomername
        '
        Me.lblcustomername.AutoSize = True
        Me.lblcustomername.Font = New System.Drawing.Font("Poppins SemiBold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomername.Location = New System.Drawing.Point(143, 59)
        Me.lblcustomername.Name = "lblcustomername"
        Me.lblcustomername.Size = New System.Drawing.Size(0, 44)
        Me.lblcustomername.TabIndex = 0
        '
        'btnAddAgent
        '
        Me.btnAddAgent.Animated = True
        Me.btnAddAgent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddAgent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddAgent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddAgent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddAgent.FillColor = System.Drawing.Color.Gold
        Me.btnAddAgent.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAgent.ForeColor = System.Drawing.Color.Black
        Me.btnAddAgent.IndicateFocus = True
        Me.btnAddAgent.Location = New System.Drawing.Point(537, 603)
        Me.btnAddAgent.Name = "btnAddAgent"
        Me.btnAddAgent.Size = New System.Drawing.Size(226, 85)
        Me.btnAddAgent.TabIndex = 115
        Me.btnAddAgent.Text = "Add New Agent"
        '
        'AgentDataGrid
        '
        Me.AgentDataGrid.AllowUserToAddRows = False
        Me.AgentDataGrid.AllowUserToDeleteRows = False
        Me.AgentDataGrid.AllowUserToResizeColumns = False
        Me.AgentDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.AgentDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AgentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AgentDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.AgentDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AgentDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.AgentDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AgentDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.AgentDataGrid.ColumnHeadersHeight = 45
        Me.AgentDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AgentDataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.AgentDataGrid.EnableHeadersVisualStyles = False
        Me.AgentDataGrid.GridColor = System.Drawing.Color.White
        Me.AgentDataGrid.Location = New System.Drawing.Point(22, 40)
        Me.AgentDataGrid.Name = "AgentDataGrid"
        Me.AgentDataGrid.ReadOnly = True
        Me.AgentDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AgentDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.AgentDataGrid.RowHeadersVisible = False
        Me.AgentDataGrid.RowHeadersWidth = 51
        Me.AgentDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.AgentDataGrid.RowTemplate.Height = 40
        Me.AgentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AgentDataGrid.Size = New System.Drawing.Size(474, 512)
        Me.AgentDataGrid.TabIndex = 114
        Me.AgentDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.AgentDataGrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.AgentDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.AgentDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.AgentDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.AgentDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.AgentDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.AgentDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AgentDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.AgentDataGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgentDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.AgentDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.AgentDataGrid.ThemeStyle.HeaderStyle.Height = 45
        Me.AgentDataGrid.ThemeStyle.ReadOnly = True
        Me.AgentDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.AgentDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.AgentDataGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgentDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.MintCream
        Me.AgentDataGrid.ThemeStyle.RowsStyle.Height = 40
        Me.AgentDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AgentDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.FillWeight = 64.17112!
        Me.Column2.HeaderText = "ID"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.FillWeight = 135.8289!
        Me.Column1.HeaderText = "Name"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Panel3.Controls.Add(Me.Button1)
        Me.Guna2Panel3.Controls.Add(Me.lbldate)
        Me.Guna2Panel3.Controls.Add(Me.lbltime)
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Location = New System.Drawing.Point(15, 112)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(1379, 86)
        Me.Guna2Panel3.TabIndex = 112
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(29, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 40)
        Me.Button1.TabIndex = 106
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Poppins", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(1029, 28)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(70, 39)
        Me.lbldate.TabIndex = 105
        Me.lbldate.Text = "Date"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Poppins", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(902, 28)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(71, 39)
        Me.lbltime.TabIndex = 104
        Me.lbltime.Text = "TIme"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(97, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 60)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Agents"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.AutoScroll = True
        Me.Guna2Panel1.AutoSize = True
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Panel1.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.MintCream
        Me.Guna2Panel1.Location = New System.Drawing.Point(-103, -118)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1492, 936)
        Me.Guna2Panel1.TabIndex = 3
        '
        'Agents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 809)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Agents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agents"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.panelcusdetails.ResumeLayout(False)
        Me.panelcusdetails.PerformLayout()
        CType(Me.picboxAgentimg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgentDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbldate As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelcusdetails As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnAgeEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblAgeaddress As Label
    Friend WithEvents picboxAgentimg As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblAgemobile As Label
    Friend WithEvents lblAgeemail As Label
    Friend WithEvents lblAgename As Label
    Friend WithEvents lblcustomeremail As Label
    Friend WithEvents lblphone As Label
    Friend WithEvents lblcustomername As Label
    Friend WithEvents btnAddAgent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AgentDataGrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
