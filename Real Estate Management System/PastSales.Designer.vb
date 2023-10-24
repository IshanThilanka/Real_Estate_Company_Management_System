<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PastSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PastSales))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncusfrmclose = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblAddProperty = New System.Windows.Forms.Label()
        Me.txtdate2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PastsalesDataGrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncusfrmclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txtdate2.SuspendLayout()
        CType(Me.PastsalesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.Guna2Panel2)
        Me.Panel.Controls.Add(Me.btncusfrmclose)
        Me.Panel.Controls.Add(Me.lblAddProperty)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(1250, 83)
        Me.Panel.TabIndex = 42
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.lbldate)
        Me.Guna2Panel2.Controls.Add(Me.lbltime)
        Me.Guna2Panel2.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1250, 83)
        Me.Guna2Panel2.TabIndex = 115
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
        Me.lbltime.Location = New System.Drawing.Point(813, 25)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(55, 30)
        Me.lbltime.TabIndex = 115
        Me.lbltime.Text = "TIme"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(76, 20)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(45, 40)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 114
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.Guna2CirclePictureBox1.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(138, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Details"
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
        Me.lblAddProperty.Size = New System.Drawing.Size(178, 44)
        Me.lblAddProperty.TabIndex = 0
        Me.lblAddProperty.Text = "Recent Sales"
        '
        'txtdate2
        '
        Me.txtdate2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtdate2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtdate2.Controls.Add(Me.PastsalesDataGrid)
        Me.txtdate2.Controls.Add(Me.Panel)
        Me.txtdate2.Location = New System.Drawing.Point(-51, 10)
        Me.txtdate2.Name = "txtdate2"
        Me.txtdate2.Size = New System.Drawing.Size(1250, 620)
        Me.txtdate2.TabIndex = 2
        '
        'PastsalesDataGrid
        '
        Me.PastsalesDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.PastsalesDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.PastsalesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PastsalesDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.PastsalesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PastsalesDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PastsalesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PastsalesDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.PastsalesDataGrid.ColumnHeadersHeight = 50
        Me.PastsalesDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PastsalesDataGrid.DefaultCellStyle = DataGridViewCellStyle7
        Me.PastsalesDataGrid.EnableHeadersVisualStyles = False
        Me.PastsalesDataGrid.GridColor = System.Drawing.Color.White
        Me.PastsalesDataGrid.Location = New System.Drawing.Point(53, 99)
        Me.PastsalesDataGrid.Name = "PastsalesDataGrid"
        Me.PastsalesDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PastsalesDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.PastsalesDataGrid.RowHeadersVisible = False
        Me.PastsalesDataGrid.RowHeadersWidth = 51
        Me.PastsalesDataGrid.RowTemplate.Height = 50
        Me.PastsalesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PastsalesDataGrid.Size = New System.Drawing.Size(1182, 499)
        Me.PastsalesDataGrid.TabIndex = 43
        Me.PastsalesDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.PastsalesDataGrid.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PastsalesDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PastsalesDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PastsalesDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.PastsalesDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.PastsalesDataGrid.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.PastsalesDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PastsalesDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.PastsalesDataGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PastsalesDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.PastsalesDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.PastsalesDataGrid.ThemeStyle.HeaderStyle.Height = 50
        Me.PastsalesDataGrid.ThemeStyle.ReadOnly = False
        Me.PastsalesDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.PastsalesDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PastsalesDataGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PastsalesDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.PastsalesDataGrid.ThemeStyle.RowsStyle.Height = 50
        Me.PastsalesDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PastsalesDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column1
        '
        Me.Column1.HeaderText = "Property ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Property Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Customer Name"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Price"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Date"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'PastSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 620)
        Me.Controls.Add(Me.txtdate2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PastSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PastSales"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncusfrmclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txtdate2.ResumeLayout(False)
        CType(Me.PastsalesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btncusfrmclose As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblAddProperty As Label
    Friend WithEvents txtdate2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PastsalesDataGrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbldate As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
End Class
