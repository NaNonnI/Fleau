<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_rorror
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.copy = New System.Windows.Forms.Button()
        Me.output = New System.Windows.Forms.TextBox()
        Me.input = New System.Windows.Forms.TextBox()
        Me.paste = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'copy
        '
        Me.copy.BackColor = System.Drawing.Color.Gray
        Me.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copy.ForeColor = System.Drawing.Color.White
        Me.copy.Location = New System.Drawing.Point(3, 59)
        Me.copy.Name = "copy"
        Me.copy.Size = New System.Drawing.Size(75, 23)
        Me.copy.TabIndex = 5
        Me.copy.Text = "Copier"
        Me.copy.UseVisualStyleBackColor = False
        '
        'output
        '
        Me.output.BackColor = System.Drawing.Color.Gray
        Me.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.output.ForeColor = System.Drawing.Color.White
        Me.output.Location = New System.Drawing.Point(3, 33)
        Me.output.Name = "output"
        Me.output.ReadOnly = True
        Me.output.Size = New System.Drawing.Size(794, 20)
        Me.output.TabIndex = 4
        '
        'input
        '
        Me.input.BackColor = System.Drawing.Color.Gray
        Me.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.input.ForeColor = System.Drawing.Color.White
        Me.input.Location = New System.Drawing.Point(3, 7)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(794, 20)
        Me.input.TabIndex = 3
        '
        'paste
        '
        Me.paste.BackColor = System.Drawing.Color.Gray
        Me.paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.paste.ForeColor = System.Drawing.Color.White
        Me.paste.Location = New System.Drawing.Point(84, 59)
        Me.paste.Name = "paste"
        Me.paste.Size = New System.Drawing.Size(75, 23)
        Me.paste.TabIndex = 6
        Me.paste.Text = "Coller"
        Me.paste.UseVisualStyleBackColor = False
        '
        'menu_rorror
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 425)
        Me.Controls.Add(Me.paste)
        Me.Controls.Add(Me.copy)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.input)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "menu_rorror"
        Me.Text = "menu_rorror"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents copy As Button
    Friend WithEvents output As TextBox
    Friend WithEvents input As TextBox
    Friend WithEvents paste As Button
End Class
