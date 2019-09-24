<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmexpiredmembers
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
        Me.dtregister = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(651, 448)
        Me.ListView1.TabIndex = 0
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
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 160
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Address"
        Me.ColumnHeader3.Width = 160
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Expiration date"
        Me.ColumnHeader4.Width = 160
        '
        'dtregister
        '
        Me.dtregister.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtregister.Location = New System.Drawing.Point(232, 485)
        Me.dtregister.Name = "dtregister"
        Me.dtregister.Size = New System.Drawing.Size(207, 20)
        Me.dtregister.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(229, 467)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Register Date"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(526, 466)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(137, 55)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Renew"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 160
        '
        'frmexpiredmembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 536)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtregister)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmexpiredmembers"
        Me.Text = "Expired Members"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtregister As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class
