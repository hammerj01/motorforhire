<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembersEntry
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtfname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtmi = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtbarangay = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtbirthday = New System.Windows.Forms.DateTimePicker
        Me.txtage = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtlicense = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbogender = New System.Windows.Forms.ComboBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.dtexpiry = New System.Windows.Forms.DateTimePicker
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtlnames = New System.Windows.Forms.TextBox
        Me.chkrequirements = New System.Windows.Forms.CheckedListBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnUpload = New System.Windows.Forms.Button
        Me.btnremove = New System.Windows.Forms.Button
        Me.lblpicture = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Firstaname"
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.ForeColor = System.Drawing.Color.Black
        Me.txtfname.Location = New System.Drawing.Point(17, 96)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(200, 23)
        Me.txtfname.TabIndex = 1
        Me.txtfname.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lastname"
        '
        'txtmi
        '
        Me.txtmi.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmi.ForeColor = System.Drawing.Color.Black
        Me.txtmi.Location = New System.Drawing.Point(223, 96)
        Me.txtmi.MaxLength = 1
        Me.txtmi.Name = "txtmi"
        Me.txtmi.Size = New System.Drawing.Size(33, 23)
        Me.txtmi.TabIndex = 5
        Me.txtmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(226, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "M.I"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.ForeColor = System.Drawing.Color.Black
        Me.txtaddress.Location = New System.Drawing.Point(12, 478)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(451, 23)
        Me.txtaddress.TabIndex = 7
        Me.txtaddress.Text = "balilihan"
        Me.txtaddress.Visible = False
        '
        'txtbarangay
        '
        Me.txtbarangay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbarangay.ForeColor = System.Drawing.Color.Black
        Me.txtbarangay.Location = New System.Drawing.Point(17, 198)
        Me.txtbarangay.Name = "txtbarangay"
        Me.txtbarangay.Size = New System.Drawing.Size(451, 23)
        Me.txtbarangay.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Barangay"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Birthday"
        '
        'dtbirthday
        '
        Me.dtbirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtbirthday.Location = New System.Drawing.Point(17, 248)
        Me.dtbirthday.Name = "dtbirthday"
        Me.dtbirthday.Size = New System.Drawing.Size(207, 20)
        Me.dtbirthday.TabIndex = 11
        Me.dtbirthday.Tag = ""
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.ForeColor = System.Drawing.Color.Black
        Me.txtage.Location = New System.Drawing.Point(268, 232)
        Me.txtage.MaxLength = 3
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(69, 23)
        Me.txtage.TabIndex = 13
        Me.txtage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(265, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Age"
        '
        'txtlicense
        '
        Me.txtlicense.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlicense.ForeColor = System.Drawing.Color.Black
        Me.txtlicense.Location = New System.Drawing.Point(17, 346)
        Me.txtlicense.Name = "txtlicense"
        Me.txtlicense.Size = New System.Drawing.Size(200, 23)
        Me.txtlicense.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "License No."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(265, 327)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Expiration Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(14, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Gender"
        '
        'cbogender
        '
        Me.cbogender.ForeColor = System.Drawing.Color.Black
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cbogender.Location = New System.Drawing.Point(20, 300)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(204, 21)
        Me.cbogender.TabIndex = 19
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(188, 447)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(137, 55)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dtexpiry
        '
        Me.dtexpiry.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtexpiry.Location = New System.Drawing.Point(261, 349)
        Me.dtexpiry.Name = "dtexpiry"
        Me.dtexpiry.Size = New System.Drawing.Size(207, 20)
        Me.dtexpiry.TabIndex = 22
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(331, 447)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(137, 55)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtlnames
        '
        Me.txtlnames.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlnames.ForeColor = System.Drawing.Color.Black
        Me.txtlnames.Location = New System.Drawing.Point(17, 140)
        Me.txtlnames.Name = "txtlnames"
        Me.txtlnames.Size = New System.Drawing.Size(235, 23)
        Me.txtlnames.TabIndex = 35
        Me.txtlnames.Tag = ""
        '
        'chkrequirements
        '
        Me.chkrequirements.FormattingEnabled = True
        Me.chkrequirements.Items.AddRange(New Object() {"barangay clearance", "police clearance"})
        Me.chkrequirements.Location = New System.Drawing.Point(130, 391)
        Me.chkrequirements.Name = "chkrequirements"
        Me.chkrequirements.Size = New System.Drawing.Size(149, 49)
        Me.chkrequirements.TabIndex = 38
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(17, 391)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 16)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Requirements :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(272, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'btnUpload
        '
        Me.btnUpload.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(272, 150)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(83, 33)
        Me.btnUpload.TabIndex = 41
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.Location = New System.Drawing.Point(363, 151)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(83, 33)
        Me.btnremove.TabIndex = 42
        Me.btnremove.Text = "Remove"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'lblpicture
        '
        Me.lblpicture.AutoSize = True
        Me.lblpicture.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpicture.ForeColor = System.Drawing.Color.Black
        Me.lblpicture.Location = New System.Drawing.Point(275, 121)
        Me.lblpicture.Name = "lblpicture"
        Me.lblpicture.Size = New System.Drawing.Size(79, 16)
        Me.lblpicture.TabIndex = 43
        Me.lblpicture.Text = "Firstaname"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmMembersEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 514)
        Me.Controls.Add(Me.lblpicture)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.chkrequirements)
        Me.Controls.Add(Me.txtlnames)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dtexpiry)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbogender)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtlicense)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtbirthday)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbarangay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtmi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMembersEntry"
        Me.Text = "Members Entry"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtbarangay As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtbirthday As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtlicense As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dtexpiry As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtlnames As System.Windows.Forms.TextBox
    Friend WithEvents chkrequirements As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents lblpicture As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
