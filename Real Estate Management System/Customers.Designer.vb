<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customers))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.CustomerDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnreset = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearchBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.panelcusdetails = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btncusEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.lblcutaddress = New System.Windows.Forms.Label()
        Me.picboxcustomer = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblcusmobile = New System.Windows.Forms.Label()
        Me.lblcusemail = New System.Windows.Forms.Label()
        Me.lblCusname = New System.Windows.Forms.Label()
        Me.lblcustomeremail = New System.Windows.Forms.Label()
        Me.lblphone = New System.Windows.Forms.Label()
        Me.lblcustomername = New System.Windows.Forms.Label()
        Me.btnProperties = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnAdvertisements = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelcusdetails.SuspendLayout()
        CType(Me.picboxcustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Panel3.Controls.Add(Me.Button1)
        Me.Guna2Panel3.Controls.Add(Me.lbldate)
        Me.Guna2Panel3.Controls.Add(Me.lbltime)
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Location = New System.Drawing.Point(53, 3)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(1387, 94)
        Me.Guna2Panel3.TabIndex = 112
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(27, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 49)
        Me.Button1.TabIndex = 106
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(1044, 29)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(70, 39)
        Me.lbldate.TabIndex = 105
        Me.lbldate.Text = "Date"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Poppins", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(911, 29)
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
        Me.Label1.Location = New System.Drawing.Point(112, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 60)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Customers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.AutoScroll = True
        Me.Guna2Panel1.AutoSize = True
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Panel1.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.MintCream
        Me.Guna2Panel1.Location = New System.Drawing.Point(-52, -2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1459, 893)
        Me.Guna2Panel1.TabIndex = 2
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(53, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1372, 843)
        Me.Guna2Panel2.TabIndex = 0
        Me.Guna2Panel2.UseTransparentBackground = True
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.CustomerDataGridView)
        Me.Guna2Panel4.Controls.Add(Me.btnreset)
        Me.Guna2Panel4.Controls.Add(Me.txtSearchBox)
        Me.Guna2Panel4.Controls.Add(Me.panelcusdetails)
        Me.Guna2Panel4.Controls.Add(Me.btnProperties)
        Me.Guna2Panel4.Controls.Add(Me.btnAdvertisements)
        Me.Guna2Panel4.Location = New System.Drawing.Point(4, 98)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(1365, 721)
        Me.Guna2Panel4.TabIndex = 0
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.CustomerDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomerDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CustomerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CustomerDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CustomerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CustomerDataGridView.ColumnHeadersHeight = 40
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.CustomerDataGridView.EnableHeadersVisualStyles = False
        Me.CustomerDataGridView.GridColor = System.Drawing.Color.White
        Me.CustomerDataGridView.Location = New System.Drawing.Point(8, 277)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.CustomerDataGridView.RowHeadersVisible = False
        Me.CustomerDataGridView.RowHeadersWidth = 51
        Me.CustomerDataGridView.RowTemplate.Height = 40
        Me.CustomerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomerDataGridView.Size = New System.Drawing.Size(1343, 389)
        Me.CustomerDataGridView.TabIndex = 120
        Me.CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.CustomerDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.CustomerDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.CustomerDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CustomerDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.CustomerDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.CustomerDataGridView.ThemeStyle.HeaderStyle.Height = 40
        Me.CustomerDataGridView.ThemeStyle.ReadOnly = False
        Me.CustomerDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CustomerDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.CustomerDataGridView.ThemeStyle.RowsStyle.Height = 40
        Me.CustomerDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomerDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column5
        '
        Me.Column5.HeaderText = "Customer ID"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Customer Name"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Customer Address"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Email"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Phone Number"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Agreement Number"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        '
        'btnreset
        '
        Me.btnreset.Animated = True
        Me.btnreset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnreset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnreset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnreset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnreset.FillColor = System.Drawing.Color.Gold
        Me.btnreset.Font = New System.Drawing.Font("Poppins Light", 9.0!)
        Me.btnreset.ForeColor = System.Drawing.Color.Black
        Me.btnreset.IndicateFocus = True
        Me.btnreset.Location = New System.Drawing.Point(1168, 16)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(134, 43)
        Me.btnreset.TabIndex = 118
        Me.btnreset.Text = "Reset"
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchBox.DefaultText = ""
        Me.txtSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchBox.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.txtSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchBox.Location = New System.Drawing.Point(507, 12)
        Me.txtSearchBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchBox.PlaceholderText = "Serach Customers"
        Me.txtSearchBox.SelectedText = ""
        Me.txtSearchBox.Size = New System.Drawing.Size(637, 47)
        Me.txtSearchBox.TabIndex = 119
        '
        'panelcusdetails
        '
        Me.panelcusdetails.Controls.Add(Me.btncusEdit)
        Me.panelcusdetails.Controls.Add(Me.lblcutaddress)
        Me.panelcusdetails.Controls.Add(Me.picboxcustomer)
        Me.panelcusdetails.Controls.Add(Me.lblcusmobile)
        Me.panelcusdetails.Controls.Add(Me.lblcusemail)
        Me.panelcusdetails.Controls.Add(Me.lblCusname)
        Me.panelcusdetails.Controls.Add(Me.lblcustomeremail)
        Me.panelcusdetails.Controls.Add(Me.lblphone)
        Me.panelcusdetails.Controls.Add(Me.lblcustomername)
        Me.panelcusdetails.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelcusdetails.ForeColor = System.Drawing.Color.Black
        Me.panelcusdetails.Location = New System.Drawing.Point(10, 64)
        Me.panelcusdetails.Name = "panelcusdetails"
        Me.panelcusdetails.Size = New System.Drawing.Size(1344, 206)
        Me.panelcusdetails.TabIndex = 116
        Me.panelcusdetails.Text = "Customer Details"
        '
        'btncusEdit
        '
        Me.btncusEdit.Animated = True
        Me.btncusEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btncusEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btncusEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btncusEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btncusEdit.FillColor = System.Drawing.Color.Gold
        Me.btncusEdit.Font = New System.Drawing.Font("Poppins Light", 9.0!)
        Me.btncusEdit.ForeColor = System.Drawing.Color.Black
        Me.btncusEdit.IndicateFocus = True
        Me.btncusEdit.Location = New System.Drawing.Point(1138, 105)
        Me.btncusEdit.Name = "btncusEdit"
        Me.btncusEdit.Size = New System.Drawing.Size(192, 80)
        Me.btncusEdit.TabIndex = 112
        Me.btncusEdit.Text = "Edit Details"
        Me.btncusEdit.Visible = False
        '
        'lblcutaddress
        '
        Me.lblcutaddress.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcutaddress.Location = New System.Drawing.Point(702, 68)
        Me.lblcutaddress.Name = "lblcutaddress"
        Me.lblcutaddress.Size = New System.Drawing.Size(228, 128)
        Me.lblcutaddress.TabIndex = 9
        Me.lblcutaddress.Text = "Customer Address"
        Me.lblcutaddress.Visible = False
        '
        'picboxcustomer
        '
        Me.picboxcustomer.ImageRotate = 0!
        Me.picboxcustomer.Location = New System.Drawing.Point(16, 49)
        Me.picboxcustomer.Name = "picboxcustomer"
        Me.picboxcustomer.Size = New System.Drawing.Size(200, 146)
        Me.picboxcustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxcustomer.TabIndex = 8
        Me.picboxcustomer.TabStop = False
        '
        'lblcusmobile
        '
        Me.lblcusmobile.AutoSize = True
        Me.lblcusmobile.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusmobile.ForeColor = System.Drawing.Color.Black
        Me.lblcusmobile.Location = New System.Drawing.Point(307, 165)
        Me.lblcusmobile.Name = "lblcusmobile"
        Me.lblcusmobile.Size = New System.Drawing.Size(140, 30)
        Me.lblcusmobile.TabIndex = 6
        Me.lblcusmobile.Text = "Phone Number"
        Me.lblcusmobile.Visible = False
        '
        'lblcusemail
        '
        Me.lblcusemail.AutoSize = True
        Me.lblcusemail.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusemail.ForeColor = System.Drawing.Color.Black
        Me.lblcusemail.Location = New System.Drawing.Point(307, 115)
        Me.lblcusemail.Name = "lblcusemail"
        Me.lblcusemail.Size = New System.Drawing.Size(147, 30)
        Me.lblcusemail.TabIndex = 5
        Me.lblcusemail.Text = "Customer Email"
        Me.lblcusemail.Visible = False
        '
        'lblCusname
        '
        Me.lblCusname.AutoSize = True
        Me.lblCusname.Font = New System.Drawing.Font("Poppins Medium", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusname.ForeColor = System.Drawing.Color.Black
        Me.lblCusname.Location = New System.Drawing.Point(299, 49)
        Me.lblCusname.Name = "lblCusname"
        Me.lblCusname.Size = New System.Drawing.Size(308, 60)
        Me.lblCusname.TabIndex = 4
        Me.lblCusname.Text = "Customer Name"
        Me.lblCusname.Visible = False
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
        'btnProperties
        '
        Me.btnProperties.Animated = True
        Me.btnProperties.AutoRoundedCorners = True
        Me.btnProperties.BackColor = System.Drawing.Color.Transparent
        Me.btnProperties.BorderRadius = 30
        Me.btnProperties.CheckedState.FillColor = System.Drawing.Color.Gold
        Me.btnProperties.CheckedState.FillColor2 = System.Drawing.Color.Gold
        Me.btnProperties.CustomizableEdges.BottomRight = False
        Me.btnProperties.CustomizableEdges.TopRight = False
        Me.btnProperties.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnProperties.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnProperties.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnProperties.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnProperties.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnProperties.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnProperties.FillColor = System.Drawing.Color.Transparent
        Me.btnProperties.FillColor2 = System.Drawing.Color.Transparent
        Me.btnProperties.Font = New System.Drawing.Font("Poppins Light", 10.0!)
        Me.btnProperties.ForeColor = System.Drawing.Color.White
        Me.btnProperties.HoverState.FillColor = System.Drawing.Color.Gold
        Me.btnProperties.HoverState.FillColor2 = System.Drawing.Color.Gold
        Me.btnProperties.HoverState.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProperties.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnProperties.Location = New System.Drawing.Point(52, 342)
        Me.btnProperties.Name = "btnProperties"
        Me.btnProperties.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnProperties.Size = New System.Drawing.Size(219, 63)
        Me.btnProperties.TabIndex = 115
        Me.btnProperties.Text = "Properties"
        Me.btnProperties.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnProperties.UseTransparentBackground = True
        '
        'btnAdvertisements
        '
        Me.btnAdvertisements.Animated = True
        Me.btnAdvertisements.AutoRoundedCorners = True
        Me.btnAdvertisements.BackColor = System.Drawing.Color.Transparent
        Me.btnAdvertisements.BorderRadius = 30
        Me.btnAdvertisements.CustomizableEdges.BottomRight = False
        Me.btnAdvertisements.CustomizableEdges.TopRight = False
        Me.btnAdvertisements.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAdvertisements.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdvertisements.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdvertisements.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdvertisements.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdvertisements.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdvertisements.FillColor = System.Drawing.Color.Transparent
        Me.btnAdvertisements.FillColor2 = System.Drawing.Color.Transparent
        Me.btnAdvertisements.Font = New System.Drawing.Font("Poppins Light", 10.0!)
        Me.btnAdvertisements.ForeColor = System.Drawing.Color.White
        Me.btnAdvertisements.HoverState.FillColor = System.Drawing.Color.Gold
        Me.btnAdvertisements.HoverState.FillColor2 = System.Drawing.Color.Gold
        Me.btnAdvertisements.HoverState.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdvertisements.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnAdvertisements.Location = New System.Drawing.Point(93, 302)
        Me.btnAdvertisements.Name = "btnAdvertisements"
        Me.btnAdvertisements.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnAdvertisements.Size = New System.Drawing.Size(219, 63)
        Me.btnAdvertisements.TabIndex = 114
        Me.btnAdvertisements.Text = "Advertisements"
        Me.btnAdvertisements.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdvertisements.UseTransparentBackground = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Address"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Email"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Agreement Number"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 809)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Customers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers"
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelcusdetails.ResumeLayout(False)
        Me.panelcusdetails.PerformLayout()
        CType(Me.picboxcustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerDataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lbldate As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CustomerDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents btnreset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearchBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents panelcusdetails As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btncusEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblcutaddress As Label
    Friend WithEvents picboxcustomer As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblcusmobile As Label
    Friend WithEvents lblcusemail As Label
    Friend WithEvents lblCusname As Label
    Friend WithEvents lblcustomeremail As Label
    Friend WithEvents lblphone As Label
    Friend WithEvents lblcustomername As Label
    Friend WithEvents btnProperties As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnAdvertisements As Guna.UI2.WinForms.Guna2GradientButton
End Class
