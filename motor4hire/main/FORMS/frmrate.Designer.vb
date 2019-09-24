<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrate
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
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtamount
        '
        Me.txtamount.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(12, 62)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(305, 38)
        Me.txtamount.TabIndex = 27
        Me.txtamount.Tag = "*"
        Me.txtamount.Text = "1500"
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(12, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 31)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "RATE"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(16, 117)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(302, 55)
        Me.btnSave.TabIndex = 31
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmrate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 190)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmrate"
        Me.Text = "Members Fee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
