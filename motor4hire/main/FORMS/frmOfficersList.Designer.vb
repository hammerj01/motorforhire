<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOfficersList
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
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtyear = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkname = New System.Windows.Forms.CheckBox
        Me.chkyear = New System.Windows.Forms.CheckBox
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(2, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1132, 428)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "President"
        Me.ColumnHeader2.Width = 160
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Vice President"
        Me.ColumnHeader3.Width = 160
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Secretary"
        Me.ColumnHeader4.Width = 160
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Treasurer"
        Me.ColumnHeader5.Width = 160
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Auditor"
        Me.ColumnHeader6.Width = 160
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Date Elected"
        Me.ColumnHeader7.Width = 160
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(818, 471)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(153, 51)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(977, 471)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(151, 51)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(232, 467)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(128, 51)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(450, 514)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(214, 20)
        Me.txtname.TabIndex = 6
        Me.txtname.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(447, 497)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name"
        Me.Label2.Visible = False
        '
        'dtyear
        '
        Me.dtyear.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtyear.Location = New System.Drawing.Point(12, 486)
        Me.dtyear.Name = "dtyear"
        Me.dtyear.Size = New System.Drawing.Size(214, 20)
        Me.dtyear.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 469)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Search by year term"
        '
        'chkname
        '
        Me.chkname.AutoSize = True
        Me.chkname.Location = New System.Drawing.Point(670, 514)
        Me.chkname.Name = "chkname"
        Me.chkname.Size = New System.Drawing.Size(15, 14)
        Me.chkname.TabIndex = 11
        Me.chkname.UseVisualStyleBackColor = True
        Me.chkname.Visible = False
        '
        'chkyear
        '
        Me.chkyear.AutoSize = True
        Me.chkyear.Checked = True
        Me.chkyear.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkyear.Location = New System.Drawing.Point(11, 437)
        Me.chkyear.Name = "chkyear"
        Me.chkyear.Size = New System.Drawing.Size(56, 17)
        Me.chkyear.TabIndex = 12
        Me.chkyear.Text = "Active"
        Me.chkyear.UseVisualStyleBackColor = True
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "End Term"
        Me.ColumnHeader8.Width = 160
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(659, 471)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(153, 51)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(366, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 51)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmOfficersList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 534)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.chkyear)
        Me.Controls.Add(Me.chkname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtyear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmOfficersList"
        Me.Text = "Officer List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtyear As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkname As System.Windows.Forms.CheckBox
    Friend WithEvents chkyear As System.Windows.Forms.CheckBox
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
