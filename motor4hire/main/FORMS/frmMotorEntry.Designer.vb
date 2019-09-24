<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMotorEntry
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
        Me.txtchange = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtamounttender = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtplateno = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.dtmotorexpiry = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtcrno = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtorno = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtmotor = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtchasis = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtowner = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.idmember = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'txtchange
        '
        Me.txtchange.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtchange.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchange.Location = New System.Drawing.Point(404, 301)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.ReadOnly = True
        Me.txtchange.Size = New System.Drawing.Size(320, 38)
        Me.txtchange.TabIndex = 69
        Me.txtchange.Tag = "*"
        Me.txtchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(401, 267)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(115, 31)
        Me.Label22.TabIndex = 68
        Me.Label22.Text = "Change"
        '
        'txtamounttender
        '
        Me.txtamounttender.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamounttender.Location = New System.Drawing.Point(404, 215)
        Me.txtamounttender.Name = "txtamounttender"
        Me.txtamounttender.Size = New System.Drawing.Size(320, 38)
        Me.txtamounttender.TabIndex = 67
        Me.txtamounttender.Tag = "*"
        Me.txtamounttender.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(401, 181)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(245, 31)
        Me.Label23.TabIndex = 66
        Me.Label23.Text = "Tendered Amount"
        '
        'txtamount
        '
        Me.txtamount.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.ForeColor = System.Drawing.Color.Black
        Me.txtamount.Location = New System.Drawing.Point(404, 122)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.ReadOnly = True
        Me.txtamount.Size = New System.Drawing.Size(320, 38)
        Me.txtamount.TabIndex = 65
        Me.txtamount.Tag = "*"
        Me.txtamount.Text = "1500"
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(403, 74)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(113, 31)
        Me.Label24.TabIndex = 64
        Me.Label24.Text = "Amount"
        '
        'txtplateno
        '
        Me.txtplateno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplateno.Location = New System.Drawing.Point(23, 374)
        Me.txtplateno.Name = "txtplateno"
        Me.txtplateno.Size = New System.Drawing.Size(349, 23)
        Me.txtplateno.TabIndex = 62
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(20, 355)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 16)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Plate no."
        '
        'dtmotorexpiry
        '
        Me.dtmotorexpiry.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmotorexpiry.Location = New System.Drawing.Point(22, 428)
        Me.dtmotorexpiry.Name = "dtmotorexpiry"
        Me.dtmotorexpiry.Size = New System.Drawing.Size(350, 20)
        Me.dtmotorexpiry.TabIndex = 59
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(26, 406)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 16)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Expiration Date"
        '
        'txtcrno
        '
        Me.txtcrno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcrno.Location = New System.Drawing.Point(23, 321)
        Me.txtcrno.Name = "txtcrno"
        Me.txtcrno.Size = New System.Drawing.Size(349, 23)
        Me.txtcrno.TabIndex = 57
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(20, 302)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 16)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "C.R. No."
        '
        'txtorno
        '
        Me.txtorno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtorno.Location = New System.Drawing.Point(23, 273)
        Me.txtorno.Name = "txtorno"
        Me.txtorno.Size = New System.Drawing.Size(349, 23)
        Me.txtorno.TabIndex = 55
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(20, 254)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 16)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "O.R No."
        '
        'txtdescription
        '
        Me.txtdescription.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(22, 133)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(349, 49)
        Me.txtdescription.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(19, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 16)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Description"
        '
        'txtmotor
        '
        Me.txtmotor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmotor.Location = New System.Drawing.Point(23, 85)
        Me.txtmotor.Name = "txtmotor"
        Me.txtmotor.Size = New System.Drawing.Size(349, 23)
        Me.txtmotor.TabIndex = 51
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(20, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 16)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Chasis No."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(544, 33)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 23)
        Me.Label21.TabIndex = 63
        Me.Label21.Text = "Payment"
        '
        'txtchasis
        '
        Me.txtchasis.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchasis.Location = New System.Drawing.Point(23, 213)
        Me.txtchasis.Name = "txtchasis"
        Me.txtchasis.Size = New System.Drawing.Size(349, 23)
        Me.txtchasis.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 16)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Motorcycle Model"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(587, 386)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(137, 55)
        Me.btnClear.TabIndex = 74
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(444, 386)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(137, 55)
        Me.btnSave.TabIndex = 73
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(20, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Owner"
        '
        'txtowner
        '
        Me.txtowner.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtowner.Location = New System.Drawing.Point(23, 33)
        Me.txtowner.Name = "txtowner"
        Me.txtowner.Size = New System.Drawing.Size(349, 23)
        Me.txtowner.TabIndex = 75
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idmember, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(23, 57)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(348, 125)
        Me.ListView1.TabIndex = 77
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'idmember
        '
        Me.idmember.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 300
        '
        'frmMotorEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 461)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtowner)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtchasis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtchange)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtamounttender)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtplateno)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dtmotorexpiry)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtcrno)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtorno)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtmotor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmMotorEntry"
        Me.Text = "Motor Entry Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtchange As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtamounttender As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtplateno As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtmotorexpiry As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtcrno As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtorno As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtmotor As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtchasis As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtowner As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents idmember As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
