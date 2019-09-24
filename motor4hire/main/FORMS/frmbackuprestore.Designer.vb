<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbackuprestore
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.rdoBackup = New System.Windows.Forms.RadioButton
        Me.rdorestore = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(23, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(489, 23)
        Me.TextBox1.TabIndex = 50
        '
        'rdoBackup
        '
        Me.rdoBackup.AutoSize = True
        Me.rdoBackup.Location = New System.Drawing.Point(543, 187)
        Me.rdoBackup.Name = "rdoBackup"
        Me.rdoBackup.Size = New System.Drawing.Size(14, 13)
        Me.rdoBackup.TabIndex = 51
        Me.rdoBackup.TabStop = True
        Me.rdoBackup.UseVisualStyleBackColor = True
        '
        'rdorestore
        '
        Me.rdorestore.AutoSize = True
        Me.rdorestore.Location = New System.Drawing.Point(518, 161)
        Me.rdorestore.Name = "rdorestore"
        Me.rdorestore.Size = New System.Drawing.Size(14, 13)
        Me.rdorestore.TabIndex = 52
        Me.rdorestore.TabStop = True
        Me.rdorestore.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(56, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(439, 76)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Backup Database"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(23, 187)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(489, 41)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "Restore Database"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Filename"
        '
        'frmbackuprestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 109)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rdorestore)
        Me.Controls.Add(Me.rdoBackup)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmbackuprestore"
        Me.Text = "Backup and Restore Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents rdoBackup As System.Windows.Forms.RadioButton
    Friend WithEvents rdorestore As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
