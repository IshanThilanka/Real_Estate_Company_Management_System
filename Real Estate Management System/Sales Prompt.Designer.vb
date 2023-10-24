<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales_Prompt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales_Prompt))
        Me.lblEditcustomer = New System.Windows.Forms.Label()
        Me.btncusfrmclose = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAgrementID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtCusID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnRemoveProperty = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdateProperty = New Guna.UI2.WinForms.Guna2Button()
        Me.DateTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        CType(Me.btncusfrmclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEditcustomer
        '
        Me.lblEditcustomer.AutoSize = True
        Me.lblEditcustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblEditcustomer.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditcustomer.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblEditcustomer.Location = New System.Drawing.Point(84, 14)
        Me.lblEditcustomer.Name = "lblEditcustomer"
        Me.lblEditcustomer.Size = New System.Drawing.Size(178, 44)
        Me.lblEditcustomer.TabIndex = 0
        Me.lblEditcustomer.Text = "Sales Details"
        '
        'btncusfrmclose
        '
        Me.btncusfrmclose.BackColor = System.Drawing.Color.Transparent
        Me.btncusfrmclose.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btncusfrmclose.Image = CType(resources.GetObject("btncusfrmclose.Image"), System.Drawing.Image)
        Me.btncusfrmclose.ImageRotate = 0!
        Me.btncusfrmclose.Location = New System.Drawing.Point(24, 14)
        Me.btncusfrmclose.Name = "btncusfrmclose"
        Me.btncusfrmclose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btncusfrmclose.Size = New System.Drawing.Size(45, 40)
        Me.btncusfrmclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btncusfrmclose.TabIndex = 114
        Me.btncusfrmclose.TabStop = False
        Me.btncusfrmclose.UseTransparentBackground = True
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.lblEditcustomer)
        Me.Panel.Controls.Add(Me.btncusfrmclose)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(740, 70)
        Me.Panel.TabIndex = 123
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Location = New System.Drawing.Point(31, 231)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(216, 27)
        Me.TextBox6.TabIndex = 49
        Me.TextBox6.Text = "Price"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(31, 173)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(216, 27)
        Me.TextBox3.TabIndex = 46
        Me.TextBox3.Text = "Agreement ID"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(31, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(216, 27)
        Me.TextBox1.TabIndex = 44
        Me.TextBox1.Text = "Date"
        '
        'txtPrice
        '
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(270, 226)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PlaceholderText = ""
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.Size = New System.Drawing.Size(260, 32)
        Me.txtPrice.TabIndex = 37
        '
        'txtAgrementID
        '
        Me.txtAgrementID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAgrementID.DefaultText = ""
        Me.txtAgrementID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAgrementID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAgrementID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAgrementID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAgrementID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAgrementID.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgrementID.ForeColor = System.Drawing.Color.Black
        Me.txtAgrementID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAgrementID.Location = New System.Drawing.Point(270, 168)
        Me.txtAgrementID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAgrementID.Name = "txtAgrementID"
        Me.txtAgrementID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAgrementID.PlaceholderText = ""
        Me.txtAgrementID.SelectedText = ""
        Me.txtAgrementID.Size = New System.Drawing.Size(260, 32)
        Me.txtAgrementID.TabIndex = 38
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.DateTimePicker)
        Me.Guna2GroupBox2.Controls.Add(Me.TextBox6)
        Me.Guna2GroupBox2.Controls.Add(Me.TextBox3)
        Me.Guna2GroupBox2.Controls.Add(Me.TextBox2)
        Me.Guna2GroupBox2.Controls.Add(Me.btnUpdateProperty)
        Me.Guna2GroupBox2.Controls.Add(Me.TextBox1)
        Me.Guna2GroupBox2.Controls.Add(Me.txtCusID)
        Me.Guna2GroupBox2.Controls.Add(Me.txtPrice)
        Me.Guna2GroupBox2.Controls.Add(Me.txtAgrementID)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Poppins Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(38, 92)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(662, 461)
        Me.Guna2GroupBox2.TabIndex = 121
        Me.Guna2GroupBox2.Text = "Property Details"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(31, 61)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(216, 27)
        Me.TextBox2.TabIndex = 45
        Me.TextBox2.Text = "Customer ID"
        '
        'txtCusID
        '
        Me.txtCusID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCusID.DefaultText = ""
        Me.txtCusID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCusID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCusID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCusID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCusID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCusID.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusID.ForeColor = System.Drawing.Color.Black
        Me.txtCusID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCusID.Location = New System.Drawing.Point(270, 56)
        Me.txtCusID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCusID.Name = "txtCusID"
        Me.txtCusID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCusID.PlaceholderText = ""
        Me.txtCusID.SelectedText = ""
        Me.txtCusID.Size = New System.Drawing.Size(260, 32)
        Me.txtCusID.TabIndex = 40
        '
        'btnRemoveProperty
        '
        Me.btnRemoveProperty.Animated = True
        Me.btnRemoveProperty.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveProperty.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemoveProperty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRemoveProperty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemoveProperty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRemoveProperty.FillColor = System.Drawing.Color.Gold
        Me.btnRemoveProperty.Font = New System.Drawing.Font("Poppins Light", 10.0!)
        Me.btnRemoveProperty.ForeColor = System.Drawing.Color.Black
        Me.btnRemoveProperty.Location = New System.Drawing.Point(908, 585)
        Me.btnRemoveProperty.Name = "btnRemoveProperty"
        Me.btnRemoveProperty.Size = New System.Drawing.Size(228, 50)
        Me.btnRemoveProperty.TabIndex = 122
        Me.btnRemoveProperty.Text = "Remove Property"
        Me.btnRemoveProperty.UseTransparentBackground = True
        '
        'btnUpdateProperty
        '
        Me.btnUpdateProperty.Animated = True
        Me.btnUpdateProperty.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateProperty.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateProperty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateProperty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateProperty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateProperty.FillColor = System.Drawing.Color.Gold
        Me.btnUpdateProperty.Font = New System.Drawing.Font("Poppins Light", 10.0!)
        Me.btnUpdateProperty.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateProperty.Location = New System.Drawing.Point(202, 332)
        Me.btnUpdateProperty.Name = "btnUpdateProperty"
        Me.btnUpdateProperty.Size = New System.Drawing.Size(235, 50)
        Me.btnUpdateProperty.TabIndex = 119
        Me.btnUpdateProperty.Text = "Save"
        Me.btnUpdateProperty.UseTransparentBackground = True
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Checked = True
        Me.DateTimePicker.FillColor = System.Drawing.Color.RoyalBlue
        Me.DateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateTimePicker.Location = New System.Drawing.Point(270, 109)
        Me.DateTimePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(260, 36)
        Me.DateTimePicker.TabIndex = 120
        Me.DateTimePicker.Value = New Date(2022, 8, 12, 6, 8, 48, 887)
        '
        'Sales_Prompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 592)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.btnRemoveProperty)
        Me.Name = "Sales_Prompt"
        Me.Text = "Sales_Prompt"
        CType(Me.btncusfrmclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblEditcustomer As Label
    Friend WithEvents btncusfrmclose As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAgrementID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtCusID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRemoveProperty As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdateProperty As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DateTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
