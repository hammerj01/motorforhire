<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOfficerQuery
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.chkyear = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtyear = New System.Windows.Forms.DateTimePicker
        Me.btnSearch = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(995, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 51)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkyear
        '
        Me.chkyear.AutoSize = True
        Me.chkyear.Checked = True
        Me.chkyear.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkyear.Location = New System.Drawing.Point(569, 513)
        Me.chkyear.Name = "chkyear"
        Me.chkyear.Size = New System.Drawing.Size(56, 17)
        Me.chkyear.TabIndex = 19
        Me.chkyear.Text = "Active"
        Me.chkyear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(637, 493)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Search by year term"
        '
        'dtyear
        '
        Me.dtyear.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtyear.Location = New System.Drawing.Point(641, 510)
        Me.dtyear.Name = "dtyear"
        Me.dtyear.Size = New System.Drawing.Size(214, 20)
        Me.dtyear.TabIndex = 17
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(861, 491)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(128, 51)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(3, 1)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1132, 484)
        Me.ListView1.TabIndex = 15
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
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "End Term"
        Me.ColumnHeader8.Width = 160
        '
        'frmOfficerQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 554)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkyear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtyear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmOfficerQuery"
        Me.Text = "Officer's List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkyear As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtyear As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
End Class
