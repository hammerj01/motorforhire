<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivity
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
        Me.txtactivityname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtstartdate = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtenddate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtorganizedby = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtactivityname
        '
        Me.txtactivityname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtactivityname.Location = New System.Drawing.Point(23, 50)
        Me.txtactivityname.Name = "txtactivityname"
        Me.txtactivityname.Size = New System.Drawing.Size(456, 23)
        Me.txtactivityname.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Activity Name"
        '
        'txtdescription
        '
        Me.txtdescription.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(23, 99)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(456, 37)
        Me.txtdescription.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Description"
        '
        'dtstartdate
        '
        Me.dtstartdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtstartdate.Location = New System.Drawing.Point(34, 296)
        Me.dtstartdate.Name = "dtstartdate"
        Me.dtstartdate.Size = New System.Drawing.Size(160, 20)
        Me.dtstartdate.TabIndex = 24
        Me.dtstartdate.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Start Date"
        Me.Label9.Visible = False
        '
        'dtenddate
        '
        Me.dtenddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtenddate.Location = New System.Drawing.Point(219, 296)
        Me.dtenddate.Name = "dtenddate"
        Me.dtenddate.Size = New System.Drawing.Size(160, 20)
        Me.dtenddate.TabIndex = 26
        Me.dtenddate.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(216, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "End Date"
        Me.Label3.Visible = False
        '
        'txtorganizedby
        '
        Me.txtorganizedby.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtorganizedby.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtorganizedby.Location = New System.Drawing.Point(23, 164)
        Me.txtorganizedby.Name = "txtorganizedby"
        Me.txtorganizedby.ReadOnly = True
        Me.txtorganizedby.Size = New System.Drawing.Size(408, 23)
        Me.txtorganizedby.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Organized By"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(20, 314)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(456, 55)
        Me.btnSave.TabIndex = 31
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(23, 190)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(408, 124)
        Me.ListView1.TabIndex = 32
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "OFFICERS"
        Me.ColumnHeader2.Width = 400
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(427, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 25)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 375)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtorganizedby)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtenddate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtstartdate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtactivityname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmActivity"
        Me.Text = "Activity Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtactivityname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtstartdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtenddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtorganizedby As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
