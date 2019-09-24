<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMotorList
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
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1206, 427)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "motorID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Owner"
        Me.ColumnHeader2.Width = 190
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Model"
        Me.ColumnHeader3.Width = 190
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Descrition"
        Me.ColumnHeader4.Width = 190
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Plate #"
        Me.ColumnHeader5.Width = 160
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "OR #"
        Me.ColumnHeader6.Width = 160
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Cr #"
        Me.ColumnHeader7.Width = 160
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Chasis"
        Me.ColumnHeader8.Width = 160
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Expiration"
        Me.ColumnHeader9.Width = 160
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "memberID"
        Me.ColumnHeader10.Width = 10
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(748, 446)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 44)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(867, 446)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(113, 44)
        Me.btnedit.TabIndex = 5
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(986, 445)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(113, 44)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1105, 445)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 44)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMotorList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 501)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmMotorList"
        Me.Text = "Motor List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
