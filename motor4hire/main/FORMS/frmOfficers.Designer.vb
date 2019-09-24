<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOfficers
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
        Me.txtpresident = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.txtvicepresident = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txttresurer = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtsecretary = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txauditor = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ListView4 = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ListView5 = New System.Windows.Forms.ListView
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtElection = New System.Windows.Forms.DateTimePicker
        Me.dtendterm = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.btnPresident = New System.Windows.Forms.Button
        Me.lblpres = New System.Windows.Forms.Label
        Me.lblvice = New System.Windows.Forms.Label
        Me.lbltreasurer = New System.Windows.Forms.Label
        Me.lblSecretary = New System.Windows.Forms.Label
        Me.lblauditor = New System.Windows.Forms.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.btnpresremove = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpresident
        '
        Me.txtpresident.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpresident.Location = New System.Drawing.Point(24, 262)
        Me.txtpresident.Name = "txtpresident"
        Me.txtpresident.Size = New System.Drawing.Size(254, 23)
        Me.txtpresident.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "President"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(24, 287)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(254, 75)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Officer's Name"
        Me.ColumnHeader2.Width = 365
        '
        'txtvicepresident
        '
        Me.txtvicepresident.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvicepresident.Location = New System.Drawing.Point(318, 263)
        Me.txtvicepresident.Name = "txtvicepresident"
        Me.txtvicepresident.Size = New System.Drawing.Size(256, 23)
        Me.txtvicepresident.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(315, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Vice President"
        '
        'txttresurer
        '
        Me.txttresurer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttresurer.Location = New System.Drawing.Point(22, 597)
        Me.txttresurer.Name = "txttresurer"
        Me.txttresurer.Size = New System.Drawing.Size(256, 23)
        Me.txttresurer.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 578)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Treasurer"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(612, 628)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(257, 68)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(612, 557)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(257, 68)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtsecretary
        '
        Me.txtsecretary.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsecretary.Location = New System.Drawing.Point(318, 597)
        Me.txtsecretary.Name = "txtsecretary"
        Me.txtsecretary.Size = New System.Drawing.Size(256, 23)
        Me.txtsecretary.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(318, 578)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Secretary"
        '
        'txauditor
        '
        Me.txauditor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txauditor.Location = New System.Drawing.Point(612, 261)
        Me.txauditor.Name = "txauditor"
        Me.txauditor.Size = New System.Drawing.Size(256, 23)
        Me.txauditor.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(609, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Auditor"
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(612, 281)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(256, 77)
        Me.ListView2.TabIndex = 30
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "id"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Officer's Name"
        Me.ColumnHeader4.Width = 365
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.Location = New System.Drawing.Point(321, 622)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(253, 74)
        Me.ListView3.TabIndex = 31
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "id"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Officer's Name"
        Me.ColumnHeader6.Width = 365
        '
        'ListView4
        '
        Me.ListView4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView4.FullRowSelect = True
        Me.ListView4.GridLines = True
        Me.ListView4.Location = New System.Drawing.Point(318, 283)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(256, 75)
        Me.ListView4.TabIndex = 32
        Me.ListView4.UseCompatibleStateImageBehavior = False
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "id"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Officer's Name"
        Me.ColumnHeader8.Width = 365
        '
        'ListView5
        '
        Me.ListView5.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView5.FullRowSelect = True
        Me.ListView5.GridLines = True
        Me.ListView5.Location = New System.Drawing.Point(22, 619)
        Me.ListView5.Name = "ListView5"
        Me.ListView5.Size = New System.Drawing.Size(256, 77)
        Me.ListView5.TabIndex = 33
        Me.ListView5.UseCompatibleStateImageBehavior = False
        Me.ListView5.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "id"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Officer's Name"
        Me.ColumnHeader10.Width = 365
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(609, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Election Date"
        '
        'dtElection
        '
        Me.dtElection.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtElection.Location = New System.Drawing.Point(613, 402)
        Me.dtElection.Name = "dtElection"
        Me.dtElection.Size = New System.Drawing.Size(256, 20)
        Me.dtElection.TabIndex = 35
        '
        'dtendterm
        '
        Me.dtendterm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtendterm.Location = New System.Drawing.Point(612, 456)
        Me.dtendterm.Name = "dtendterm"
        Me.dtendterm.Size = New System.Drawing.Size(256, 20)
        Me.dtendterm.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(608, 429)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "End Term"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(24, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(318, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(256, 167)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(22, 349)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(256, 167)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 40
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(612, 11)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(256, 167)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 41
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Location = New System.Drawing.Point(318, 349)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(256, 167)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 42
        Me.PictureBox5.TabStop = False
        '
        'btnPresident
        '
        Me.btnPresident.Location = New System.Drawing.Point(24, 214)
        Me.btnPresident.Name = "btnPresident"
        Me.btnPresident.Size = New System.Drawing.Size(126, 26)
        Me.btnPresident.TabIndex = 43
        Me.btnPresident.Text = "Browse"
        Me.btnPresident.UseVisualStyleBackColor = True
        '
        'lblpres
        '
        Me.lblpres.AutoSize = True
        Me.lblpres.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpres.Location = New System.Drawing.Point(21, 188)
        Me.lblpres.Name = "lblpres"
        Me.lblpres.Size = New System.Drawing.Size(61, 16)
        Me.lblpres.TabIndex = 48
        Me.lblpres.Text = "President"
        '
        'lblvice
        '
        Me.lblvice.AutoSize = True
        Me.lblvice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvice.Location = New System.Drawing.Point(316, 184)
        Me.lblvice.Name = "lblvice"
        Me.lblvice.Size = New System.Drawing.Size(89, 16)
        Me.lblvice.TabIndex = 49
        Me.lblvice.Text = "Vice President"
        '
        'lbltreasurer
        '
        Me.lbltreasurer.AutoSize = True
        Me.lbltreasurer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltreasurer.Location = New System.Drawing.Point(20, 522)
        Me.lbltreasurer.Name = "lbltreasurer"
        Me.lbltreasurer.Size = New System.Drawing.Size(65, 16)
        Me.lbltreasurer.TabIndex = 50
        Me.lbltreasurer.Text = "Treasurer"
        '
        'lblSecretary
        '
        Me.lblSecretary.AutoSize = True
        Me.lblSecretary.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretary.Location = New System.Drawing.Point(318, 522)
        Me.lblSecretary.Name = "lblSecretary"
        Me.lblSecretary.Size = New System.Drawing.Size(63, 16)
        Me.lblSecretary.TabIndex = 51
        Me.lblSecretary.Text = "Secretary"
        '
        'lblauditor
        '
        Me.lblauditor.AutoSize = True
        Me.lblauditor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblauditor.Location = New System.Drawing.Point(609, 187)
        Me.lblauditor.Name = "lblauditor"
        Me.lblauditor.Size = New System.Drawing.Size(49, 16)
        Me.lblauditor.TabIndex = 52
        Me.lblauditor.Text = "Auditor"
        '
        'btnpresremove
        '
        Me.btnpresremove.Location = New System.Drawing.Point(156, 213)
        Me.btnpresremove.Name = "btnpresremove"
        Me.btnpresremove.Size = New System.Drawing.Size(122, 26)
        Me.btnpresremove.TabIndex = 54
        Me.btnpresremove.Text = "Remove"
        Me.btnpresremove.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(452, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 26)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(320, 209)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 26)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(746, 209)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(122, 26)
        Me.Button5.TabIndex = 58
        Me.Button5.Text = "Remove"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(614, 209)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(126, 26)
        Me.Button7.TabIndex = 57
        Me.Button7.Text = "Browse"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(154, 544)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 26)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(22, 544)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(126, 26)
        Me.Button4.TabIndex = 59
        Me.Button4.Text = "Browse"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(453, 544)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(122, 26)
        Me.Button8.TabIndex = 62
        Me.Button8.Text = "Remove"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(321, 544)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(126, 26)
        Me.Button9.TabIndex = 61
        Me.Button9.Text = "Browse"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(612, 499)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox1.TabIndex = 64
        Me.CheckBox1.Text = "Status"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmOfficers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 746)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnpresremove)
        Me.Controls.Add(Me.lblauditor)
        Me.Controls.Add(Me.lblSecretary)
        Me.Controls.Add(Me.lbltreasurer)
        Me.Controls.Add(Me.lblvice)
        Me.Controls.Add(Me.lblpres)
        Me.Controls.Add(Me.btnPresident)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtendterm)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtElection)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.ListView5)
        Me.Controls.Add(Me.ListView4)
        Me.Controls.Add(Me.txauditor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsecretary)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttresurer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtvicepresident)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtpresident)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOfficers"
        Me.Tag = ""
        Me.Text = "Officers Entry"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpresident As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtvicepresident As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttresurer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtsecretary As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txauditor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView4 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView5 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtElection As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtendterm As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents btnPresident As System.Windows.Forms.Button
    Friend WithEvents lblpres As System.Windows.Forms.Label
    Friend WithEvents lblvice As System.Windows.Forms.Label
    Friend WithEvents lbltreasurer As System.Windows.Forms.Label
    Friend WithEvents lblSecretary As System.Windows.Forms.Label
    Friend WithEvents lblauditor As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnpresremove As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
