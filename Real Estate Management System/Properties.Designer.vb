<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Properties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Properties))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblproptime = New Guna.UI2.WinForms.Guna2Panel()
        Me.PropertyDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnclearFilter = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbAgentID = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnviewappointments = New Guna.UI2.WinForms.Guna2Button()
        Me.btnViewProperty = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddProperty = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSearchBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblproptime.SuspendLayout()
        CType(Me.PropertyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblproptime
        '
        Me.lblproptime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblproptime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lblproptime.BackColor = System.Drawing.Color.Transparent
        Me.lblproptime.BackgroundImage = CType(resources.GetObject("lblproptime.BackgroundImage"), System.Drawing.Image)
        Me.lblproptime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lblproptime.Controls.Add(Me.PropertyDataGridView)
        Me.lblproptime.Controls.Add(Me.btnclearFilter)
        Me.lblproptime.Controls.Add(Me.cmbStatus)
        Me.lblproptime.Controls.Add(Me.Label3)
        Me.lblproptime.Controls.Add(Me.Label2)
        Me.lblproptime.Controls.Add(Me.cmbAgentID)
        Me.lblproptime.Controls.Add(Me.btnviewappointments)
        Me.lblproptime.Controls.Add(Me.btnViewProperty)
        Me.lblproptime.Controls.Add(Me.btnAddProperty)
        Me.lblproptime.Controls.Add(Me.Guna2Panel1)
        Me.lblproptime.FillColor = System.Drawing.Color.White
        Me.lblproptime.Location = New System.Drawing.Point(-6, -2)
        Me.lblproptime.Name = "lblproptime"
        Me.lblproptime.Size = New System.Drawing.Size(1395, 813)
        Me.lblproptime.TabIndex = 1
        Me.lblproptime.UseTransparentBackground = True
        '
        'PropertyDataGridView
        '
        Me.PropertyDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.PropertyDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PropertyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PropertyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PropertyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PropertyDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PropertyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PropertyDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PropertyDataGridView.ColumnHeadersHeight = 60
        Me.PropertyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.PropertyDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PropertyDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.PropertyDataGridView.EnableHeadersVisualStyles = False
        Me.PropertyDataGridView.GridColor = System.Drawing.Color.White
        Me.PropertyDataGridView.Location = New System.Drawing.Point(12, 196)
        Me.PropertyDataGridView.Name = "PropertyDataGridView"
        Me.PropertyDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PropertyDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.PropertyDataGridView.RowHeadersVisible = False
        Me.PropertyDataGridView.RowHeadersWidth = 51
        Me.PropertyDataGridView.RowTemplate.Height = 45
        Me.PropertyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PropertyDataGridView.Size = New System.Drawing.Size(1350, 540)
        Me.PropertyDataGridView.TabIndex = 137
        Me.PropertyDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PropertyDataGridView.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PropertyDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PropertyDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PropertyDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.PropertyDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.PropertyDataGridView.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.PropertyDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PropertyDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.PropertyDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.PropertyDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.PropertyDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.PropertyDataGridView.ThemeStyle.HeaderStyle.Height = 60
        Me.PropertyDataGridView.ThemeStyle.ReadOnly = False
        Me.PropertyDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.PropertyDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PropertyDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.PropertyDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PropertyDataGridView.ThemeStyle.RowsStyle.Height = 45
        Me.PropertyDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PropertyDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "Property ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Property Type"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Property Name"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Description"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Price"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Status"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Agent ID"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        '
        'btnclearFilter
        '
        Me.btnclearFilter.Animated = True
        Me.btnclearFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnclearFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnclearFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnclearFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnclearFilter.FillColor = System.Drawing.Color.Gold
        Me.btnclearFilter.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclearFilter.ForeColor = System.Drawing.Color.Black
        Me.btnclearFilter.Location = New System.Drawing.Point(510, 132)
        Me.btnclearFilter.Name = "btnclearFilter"
        Me.btnclearFilter.Size = New System.Drawing.Size(107, 43)
        Me.btnclearFilter.TabIndex = 135
        Me.btnclearFilter.Text = "Clear"
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoRoundedCorners = True
        Me.cmbStatus.BackColor = System.Drawing.Color.Transparent
        Me.cmbStatus.BorderRadius = 17
        Me.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStatus.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbStatus.ItemHeight = 30
        Me.cmbStatus.Items.AddRange(New Object() {"Sold", "Unsold"})
        Me.cmbStatus.Location = New System.Drawing.Point(305, 139)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(180, 36)
        Me.cmbStatus.TabIndex = 134
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(347, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 23)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Filter by Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 23)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Filter by Agent ID"
        '
        'cmbAgentID
        '
        Me.cmbAgentID.AutoRoundedCorners = True
        Me.cmbAgentID.BackColor = System.Drawing.Color.Transparent
        Me.cmbAgentID.BorderRadius = 17
        Me.cmbAgentID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbAgentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAgentID.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAgentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAgentID.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgentID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbAgentID.ItemHeight = 30
        Me.cmbAgentID.Items.AddRange(New Object() {"1145", "4545", "11550"})
        Me.cmbAgentID.Location = New System.Drawing.Point(93, 139)
        Me.cmbAgentID.Name = "cmbAgentID"
        Me.cmbAgentID.Size = New System.Drawing.Size(180, 36)
        Me.cmbAgentID.TabIndex = 131
        '
        'btnviewappointments
        '
        Me.btnviewappointments.Animated = True
        Me.btnviewappointments.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnviewappointments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnviewappointments.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnviewappointments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnviewappointments.FillColor = System.Drawing.Color.Gold
        Me.btnviewappointments.Font = New System.Drawing.Font("Poppins Light", 9.0!)
        Me.btnviewappointments.ForeColor = System.Drawing.Color.Black
        Me.btnviewappointments.Location = New System.Drawing.Point(849, 118)
        Me.btnviewappointments.Name = "btnviewappointments"
        Me.btnviewappointments.Size = New System.Drawing.Size(238, 57)
        Me.btnviewappointments.TabIndex = 130
        Me.btnviewappointments.Text = "View All Appointments"
        '
        'btnViewProperty
        '
        Me.btnViewProperty.Animated = True
        Me.btnViewProperty.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnViewProperty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnViewProperty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewProperty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnViewProperty.FillColor = System.Drawing.Color.Gold
        Me.btnViewProperty.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewProperty.ForeColor = System.Drawing.Color.Black
        Me.btnViewProperty.Location = New System.Drawing.Point(1178, 742)
        Me.btnViewProperty.Name = "btnViewProperty"
        Me.btnViewProperty.Size = New System.Drawing.Size(173, 57)
        Me.btnViewProperty.TabIndex = 129
        Me.btnViewProperty.Text = "View Details"
        '
        'btnAddProperty
        '
        Me.btnAddProperty.Animated = True
        Me.btnAddProperty.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddProperty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddProperty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddProperty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddProperty.FillColor = System.Drawing.Color.Gold
        Me.btnAddProperty.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProperty.ForeColor = System.Drawing.Color.Black
        Me.btnAddProperty.Location = New System.Drawing.Point(1140, 118)
        Me.btnAddProperty.Name = "btnAddProperty"
        Me.btnAddProperty.Size = New System.Drawing.Size(161, 57)
        Me.btnAddProperty.TabIndex = 128
        Me.btnAddProperty.Text = "Add Property"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Gray
        Me.Guna2Panel1.Controls.Add(Me.Button1)
        Me.Guna2Panel1.Controls.Add(Me.txtSearchBox)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1378, 85)
        Me.Guna2Panel1.TabIndex = 110
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(29, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 45)
        Me.Button1.TabIndex = 106
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.txtSearchBox.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchBox.Location = New System.Drawing.Point(779, 20)
        Me.txtSearchBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchBox.PlaceholderText = "Serach For Property"
        Me.txtSearchBox.SelectedText = ""
        Me.txtSearchBox.Size = New System.Drawing.Size(516, 45)
        Me.txtSearchBox.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(107, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 60)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Properties"
        '
        'Properties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 809)
        Me.Controls.Add(Me.lblproptime)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Properties"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Properties"
        Me.lblproptime.ResumeLayout(False)
        Me.lblproptime.PerformLayout()
        CType(Me.PropertyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblproptime As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSearchBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnclearFilter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbAgentID As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnviewappointments As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnViewProperty As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddProperty As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PropertyDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
