<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcomplaints
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
        Me.txtplateno = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtowner = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtComplaints = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcomplaintname = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtcomplaint = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtmodel = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtexpiration = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtplateno
        '
        Me.txtplateno.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplateno.Location = New System.Drawing.Point(12, 38)
        Me.txtplateno.Name = "txtplateno"
        Me.txtplateno.Size = New System.Drawing.Size(318, 27)
        Me.txtplateno.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Plate No."
        '
        'txtowner
        '
        Me.txtowner.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtowner.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtowner.Font = New System.Drawing.Font("Vani", 8.25!)
        Me.txtowner.Location = New System.Drawing.Point(352, 38)
        Me.txtowner.Name = "txtowner"
        Me.txtowner.Size = New System.Drawing.Size(317, 19)
        Me.txtowner.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(349, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Owner"
        '
        'txtComplaints
        '
        Me.txtComplaints.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplaints.Location = New System.Drawing.Point(352, 199)
        Me.txtComplaints.Multiline = True
        Me.txtComplaints.Name = "txtComplaints"
        Me.txtComplaints.Size = New System.Drawing.Size(317, 76)
        Me.txtComplaints.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(349, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Complaints"
        '
        'txtcomplaintname
        '
        Me.txtcomplaintname.Font = New System.Drawing.Font("Vani", 8.25!)
        Me.txtcomplaintname.Location = New System.Drawing.Point(700, 108)
        Me.txtcomplaintname.Name = "txtcomplaintname"
        Me.txtcomplaintname.Size = New System.Drawing.Size(364, 26)
        Me.txtcomplaintname.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(697, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Complaint name"
        '
        'dtcomplaint
        '
        Me.dtcomplaint.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtcomplaint.Location = New System.Drawing.Point(700, 46)
        Me.dtcomplaint.Name = "dtcomplaint"
        Me.dtcomplaint.Size = New System.Drawing.Size(364, 20)
        Me.dtcomplaint.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(697, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Date Complaint"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(700, 146)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(364, 91)
        Me.btnSave.TabIndex = 32
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(11, 65)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(317, 147)
        Me.ListView1.TabIndex = 33
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "mid"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "memID"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Plate No."
        Me.ColumnHeader3.Width = 312
        '
        'txtaddress
        '
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaddress.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(352, 95)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(317, 76)
        Me.txtaddress.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(349, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Address"
        '
        'txtmodel
        '
        Me.txtmodel.BackColor = System.Drawing.Color.White
        Me.txtmodel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmodel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodel.Location = New System.Drawing.Point(13, 95)
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.ReadOnly = True
        Me.txtmodel.Size = New System.Drawing.Size(318, 20)
        Me.txtmodel.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 19)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Motorcycle Model"
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.Color.White
        Me.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdescription.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(13, 152)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.ReadOnly = True
        Me.txtdescription.Size = New System.Drawing.Size(318, 20)
        Me.txtdescription.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 19)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Description"
        '
        'txtexpiration
        '
        Me.txtexpiration.BackColor = System.Drawing.Color.White
        Me.txtexpiration.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtexpiration.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexpiration.Location = New System.Drawing.Point(15, 210)
        Me.txtexpiration.Name = "txtexpiration"
        Me.txtexpiration.ReadOnly = True
        Me.txtexpiration.Size = New System.Drawing.Size(318, 20)
        Me.txtexpiration.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 19)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Expiration"
        '
        'frmcomplaints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 299)
        Me.Controls.Add(Me.txtexpiration)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtmodel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtcomplaint)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcomplaintname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtComplaints)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtowner)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtplateno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmcomplaints"
        Me.Text = "Complaints"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtplateno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtowner As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtComplaints As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcomplaintname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtcomplaint As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtmodel As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtexpiration As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
