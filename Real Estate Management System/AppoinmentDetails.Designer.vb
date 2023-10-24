<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppoinmentDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppoinmentDetails))
        Me.Panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblEditcustomer = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnsendmsg = New Guna.UI2.WinForms.Guna2Button()
        Me.lblappontStatus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAppointPropID = New System.Windows.Forms.Label()
        Me.lblAppointAgentID = New System.Windows.Forms.Label()
        Me.lblAppointAppDate = New System.Windows.Forms.Label()
        Me.lblAppointCusName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.lblEditcustomer)
        Me.Panel.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel.FillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(793, 70)
        Me.Panel.TabIndex = 117
        '
        'lblEditcustomer
        '
        Me.lblEditcustomer.AutoSize = True
        Me.lblEditcustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblEditcustomer.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditcustomer.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblEditcustomer.Location = New System.Drawing.Point(86, 14)
        Me.lblEditcustomer.Name = "lblEditcustomer"
        Me.lblEditcustomer.Size = New System.Drawing.Size(237, 44)
        Me.lblEditcustomer.TabIndex = 0
        Me.lblEditcustomer.Text = "Appointment Info"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(31, 14)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(45, 40)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 114
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.Guna2CirclePictureBox1.UseTransparentBackground = True
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnsendmsg)
        Me.Guna2Panel1.Controls.Add(Me.lblappontStatus)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.lblAppointPropID)
        Me.Guna2Panel1.Controls.Add(Me.lblAppointAgentID)
        Me.Guna2Panel1.Controls.Add(Me.lblAppointAppDate)
        Me.Guna2Panel1.Controls.Add(Me.lblAppointCusName)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(109, 76)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(581, 477)
        Me.Guna2Panel1.TabIndex = 118
        '
        'btnsendmsg
        '
        Me.btnsendmsg.Animated = True
        Me.btnsendmsg.AutoRoundedCorners = True
        Me.btnsendmsg.BackColor = System.Drawing.Color.Transparent
        Me.btnsendmsg.BorderRadius = 27
        Me.btnsendmsg.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsendmsg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsendmsg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsendmsg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsendmsg.FillColor = System.Drawing.Color.Gold
        Me.btnsendmsg.Font = New System.Drawing.Font("Poppins Light", 9.0!)
        Me.btnsendmsg.ForeColor = System.Drawing.Color.Black
        Me.btnsendmsg.Location = New System.Drawing.Point(183, 386)
        Me.btnsendmsg.Name = "btnsendmsg"
        Me.btnsendmsg.Size = New System.Drawing.Size(213, 56)
        Me.btnsendmsg.TabIndex = 130
        Me.btnsendmsg.Text = "Approve And  Assign"
        '
        'lblappontStatus
        '
        Me.lblappontStatus.AutoSize = True
        Me.lblappontStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblappontStatus.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblappontStatus.ForeColor = System.Drawing.SystemColors.Control
        Me.lblappontStatus.Location = New System.Drawing.Point(343, 303)
        Me.lblappontStatus.Name = "lblappontStatus"
        Me.lblappontStatus.Size = New System.Drawing.Size(66, 30)
        Me.lblappontStatus.TabIndex = 129
        Me.lblappontStatus.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(86, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 30)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Appointment Status"
        '
        'lblAppointPropID
        '
        Me.lblAppointPropID.AutoSize = True
        Me.lblAppointPropID.BackColor = System.Drawing.Color.Transparent
        Me.lblAppointPropID.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppointPropID.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAppointPropID.Location = New System.Drawing.Point(343, 107)
        Me.lblAppointPropID.Name = "lblAppointPropID"
        Me.lblAppointPropID.Size = New System.Drawing.Size(105, 30)
        Me.lblAppointPropID.TabIndex = 127
        Me.lblAppointPropID.Text = "Property ID"
        '
        'lblAppointAgentID
        '
        Me.lblAppointAgentID.AutoSize = True
        Me.lblAppointAgentID.BackColor = System.Drawing.Color.Transparent
        Me.lblAppointAgentID.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppointAgentID.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAppointAgentID.Location = New System.Drawing.Point(343, 172)
        Me.lblAppointAgentID.Name = "lblAppointAgentID"
        Me.lblAppointAgentID.Size = New System.Drawing.Size(84, 30)
        Me.lblAppointAgentID.TabIndex = 126
        Me.lblAppointAgentID.Text = "Agent ID"
        '
        'lblAppointAppDate
        '
        Me.lblAppointAppDate.AutoSize = True
        Me.lblAppointAppDate.BackColor = System.Drawing.Color.Transparent
        Me.lblAppointAppDate.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppointAppDate.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAppointAppDate.Location = New System.Drawing.Point(343, 238)
        Me.lblAppointAppDate.Name = "lblAppointAppDate"
        Me.lblAppointAppDate.Size = New System.Drawing.Size(91, 30)
        Me.lblAppointAppDate.TabIndex = 125
        Me.lblAppointAppDate.Text = "App Date"
        '
        'lblAppointCusName
        '
        Me.lblAppointCusName.AutoSize = True
        Me.lblAppointCusName.BackColor = System.Drawing.Color.Transparent
        Me.lblAppointCusName.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppointCusName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblAppointCusName.Location = New System.Drawing.Point(343, 44)
        Me.lblAppointCusName.Name = "lblAppointCusName"
        Me.lblAppointCusName.Size = New System.Drawing.Size(155, 30)
        Me.lblAppointCusName.TabIndex = 124
        Me.lblAppointCusName.Text = "Customer Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(86, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 30)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Property ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(86, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 30)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Agent ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(86, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 30)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Appointment Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(86, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 30)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Customer Name"
        '
        'AppoinmentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(793, 572)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AppoinmentDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View_Appoinment"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblEditcustomer As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnsendmsg As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblappontStatus As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAppointPropID As Label
    Friend WithEvents lblAppointAgentID As Label
    Friend WithEvents lblAppointAppDate As Label
    Friend WithEvents lblAppointCusName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
