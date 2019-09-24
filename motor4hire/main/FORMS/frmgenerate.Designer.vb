<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmgenerate
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
        Me.txtmotor = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtmember = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtStickerNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'txtmotor
        '
        Me.txtmotor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtmotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmotor.ForeColor = System.Drawing.Color.Black
        Me.txtmotor.Location = New System.Drawing.Point(28, 58)
        Me.txtmotor.Name = "txtmotor"
        Me.txtmotor.ReadOnly = True
        Me.txtmotor.Size = New System.Drawing.Size(475, 38)
        Me.txtmotor.TabIndex = 47
        Me.txtmotor.Tag = "*"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(22, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(352, 31)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "Motor name and Plate No."
        '
        'txtmember
        '
        Me.txtmember.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtmember.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmember.ForeColor = System.Drawing.Color.Black
        Me.txtmember.Location = New System.Drawing.Point(28, 141)
        Me.txtmember.Name = "txtmember"
        Me.txtmember.Size = New System.Drawing.Size(475, 38)
        Me.txtmember.TabIndex = 49
        Me.txtmember.Tag = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 31)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Members Name"
        '
        'txtStickerNo
        '
        Me.txtStickerNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtStickerNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStickerNo.ForeColor = System.Drawing.Color.Black
        Me.txtStickerNo.Location = New System.Drawing.Point(28, 221)
        Me.txtStickerNo.Name = "txtStickerNo"
        Me.txtStickerNo.ReadOnly = True
        Me.txtStickerNo.Size = New System.Drawing.Size(475, 38)
        Me.txtStickerNo.TabIndex = 51
        Me.txtStickerNo.Tag = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 31)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Sticker No."
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(28, 300)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(225, 55)
        Me.btnSave.TabIndex = 52
        Me.btnSave.Text = "Generate Sticker"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(272, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 55)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Print Sticker"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(28, 185)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(475, 109)
        Me.ListView1.TabIndex = 54
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
        Me.ColumnHeader2.Text = "Members"
        Me.ColumnHeader2.Width = 450
        '
        'frmgenerate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 367)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtStickerNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtmember)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmotor)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmgenerate"
        Me.Text = "Generate Member Sticker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmotor As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtmember As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStickerNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
