<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayments
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
        Me.txtmemberID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtmember = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtamounttender = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtchange = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'txtmemberID
        '
        Me.txtmemberID.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtmemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmemberID.Location = New System.Drawing.Point(25, 90)
        Me.txtmemberID.Name = "txtmemberID"
        Me.txtmemberID.ReadOnly = True
        Me.txtmemberID.Size = New System.Drawing.Size(200, 38)
        Me.txtmemberID.TabIndex = 3
        Me.txtmemberID.Tag = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Member ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(210, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 35)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Payment"
        '
        'txtmember
        '
        Me.txtmember.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmember.Location = New System.Drawing.Point(228, 90)
        Me.txtmember.Name = "txtmember"
        Me.txtmember.Size = New System.Drawing.Size(342, 38)
        Me.txtmember.TabIndex = 23
        Me.txtmember.Tag = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(225, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 31)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Member"
        '
        'txtamount
        '
        Me.txtamount.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(22, 186)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.ReadOnly = True
        Me.txtamount.Size = New System.Drawing.Size(548, 38)
        Me.txtamount.TabIndex = 25
        Me.txtamount.Tag = "*"
        Me.txtamount.Text = "1500"
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(16, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 31)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Amount"
        '
        'txtamounttender
        '
        Me.txtamounttender.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamounttender.Location = New System.Drawing.Point(22, 279)
        Me.txtamounttender.Name = "txtamounttender"
        Me.txtamounttender.Size = New System.Drawing.Size(548, 38)
        Me.txtamounttender.TabIndex = 27
        Me.txtamounttender.Tag = "*"
        Me.txtamounttender.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(19, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 31)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Tendered Amount"
        '
        'txtchange
        '
        Me.txtchange.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtchange.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchange.Location = New System.Drawing.Point(22, 365)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.ReadOnly = True
        Me.txtchange.Size = New System.Drawing.Size(548, 38)
        Me.txtchange.TabIndex = 29
        Me.txtchange.Tag = "*"
        Me.txtchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(19, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 31)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Change"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(25, 420)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(545, 55)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Payment"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.Location = New System.Drawing.Point(231, 127)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(339, 97)
        Me.ListView1.TabIndex = 32
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "memberID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 200
        '
        'frmPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 487)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtchange)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtamounttender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtmember)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtmemberID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmPayments"
        Me.Text = "Payments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmemberID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtmember As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtamounttender As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtchange As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
