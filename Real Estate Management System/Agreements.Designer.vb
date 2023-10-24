<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agreements
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agreements))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.btncusfrmclose = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblAddProperty = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnreset = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearchBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AgreementDataGrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel.SuspendLayout()
        CType(Me.btncusfrmclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.AgreementDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.lbldate)
        Me.Panel.Controls.Add(Me.lbltime)
        Me.Panel.Controls.Add(Me.btncusfrmclose)
        Me.Panel.Controls.Add(Me.lblAddProperty)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(1260, 83)
        Me.Panel.TabIndex = 42
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lbldate.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbldate.Location = New System.Drawing.Point(955, 25)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(53, 30)
        Me.lbldate.TabIndex = 116
        Me.lbldate.Text = "Date"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lbltime.Font = New System.Drawing.Font("Poppins", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltime.Location = New System.Drawing.Point(810, 26)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(55, 30)
        Me.lbltime.TabIndex = 115
        Me.lbltime.Text = "TIme"
        '
        'btncusfrmclose
        '
        Me.btncusfrmclose.BackColor = System.Drawing.Color.Transparent
        Me.btncusfrmclose.FillColor = System.Drawing.Color.Transparent
        Me.btncusfrmclose.Image = CType(resources.GetObject("btncusfrmclose.Image"), System.Drawing.Image)
        Me.btncusfrmclose.ImageRotate = 0!
        Me.btncusfrmclose.Location = New System.Drawing.Point(76, 20)
        Me.btncusfrmclose.Name = "btncusfrmclose"
        Me.btncusfrmclose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btncusfrmclose.Size = New System.Drawing.Size(45, 40)
        Me.btncusfrmclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btncusfrmclose.TabIndex = 114
        Me.btncusfrmclose.TabStop = False
        Me.btncusfrmclose.UseTransparentBackground = True
        '
        'lblAddProperty
        '
        Me.lblAddProperty.AutoSize = True
        Me.lblAddProperty.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblAddProperty.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddProperty.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAddProperty.Location = New System.Drawing.Point(138, 21)
        Me.lblAddProperty.Name = "lblAddProperty"
        Me.lblAddProperty.Size = New System.Drawing.Size(251, 44)
        Me.lblAddProperty.TabIndex = 0
        Me.lblAddProperty.Text = "Agreement Details"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.Controls.Add(Me.btnreset)
        Me.Guna2Panel1.Controls.Add(Me.txtSearchBox)
        Me.Guna2Panel1.Controls.Add(Me.AgreementDataGrid)
        Me.Guna2Panel1.Controls.Add(Me.Panel)
        Me.Guna2Panel1.Location = New System.Drawing.Point(-53, 1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1260, 660)
        Me.Guna2Panel1.TabIndex = 3
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
        Me.btnreset.Location = New System.Drawing.Point(1101, 91)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(134, 43)
        Me.btnreset.TabIndex = 114
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
        Me.txtSearchBox.Location = New System.Drawing.Point(444, 91)
        Me.txtSearchBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchBox.PlaceholderText = "Serach Agreements"
        Me.txtSearchBox.SelectedText = ""
        Me.txtSearchBox.Size = New System.Drawing.Size(637, 47)
        Me.txtSearchBox.TabIndex = 115
        '
        'AgreementDataGrid
        '
        Me.AgreementDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.AgreementDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.AgreementDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AgreementDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.AgreementDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AgreementDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.AgreementDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AgreementDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.AgreementDataGrid.ColumnHeadersHeight = 50
        Me.AgreementDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AgreementDataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.AgreementDataGrid.EnableHeadersVisualStyles = False
        Me.AgreementDataGrid.GridColor = System.Drawing.Color.White
        Me.AgreementDataGrid.Location = New System.Drawing.Point(58, 143)
        Me.AgreementDataGrid.Name = "AgreementDataGrid"
        Me.AgreementDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AgreementDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.AgreementDataGrid.RowHeadersVisible = False
        Me.AgreementDataGrid.RowHeadersWidth = 51
        Me.AgreementDataGrid.RowTemplate.Height = 50
        Me.AgreementDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AgreementDataGrid.Size = New System.Drawing.Size(1189, 490)
        Me.AgreementDataGrid.TabIndex = 43
        Me.AgreementDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.AgreementDataGrid.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgreementDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AgreementDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AgreementDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.AgreementDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.AgreementDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.AgreementDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AgreementDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AgreementDataGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgreementDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.AgreementDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.AgreementDataGrid.ThemeStyle.HeaderStyle.Height = 50
        Me.AgreementDataGrid.ThemeStyle.ReadOnly = False
        Me.AgreementDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.AgreementDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.AgreementDataGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgreementDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.AgreementDataGrid.ThemeStyle.RowsStyle.Height = 50
        Me.AgreementDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AgreementDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column1
        '
        Me.Column1.HeaderText = "Agreement Number"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Property Name"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Customer Name"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Agreement Link"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Agreements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 637)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Agreements"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agreements"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.btncusfrmclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.AgreementDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btncusfrmclose As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblAddProperty As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents AgreementDataGrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lbldate As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btnreset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearchBox As Guna.UI2.WinForms.Guna2TextBox
End Class
