<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_spotify
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
        Me.pause = New System.Windows.Forms.Button()
        Me.bass = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pause
        '
        Me.pause.Location = New System.Drawing.Point(12, 12)
        Me.pause.Name = "pause"
        Me.pause.Size = New System.Drawing.Size(75, 23)
        Me.pause.TabIndex = 0
        Me.pause.Text = "Start/Pause"
        Me.pause.UseVisualStyleBackColor = True
        '
        'bass
        '
        Me.bass.Location = New System.Drawing.Point(12, 41)
        Me.bass.Name = "bass"
        Me.bass.Size = New System.Drawing.Size(75, 23)
        Me.bass.TabIndex = 1
        Me.bass.Text = "Bass"
        Me.bass.UseVisualStyleBackColor = True
        '
        'menu_spotify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 425)
        Me.Controls.Add(Me.bass)
        Me.Controls.Add(Me.pause)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "menu_spotify"
        Me.Text = "menu_spotify"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pause As Button
    Friend WithEvents bass As Button
End Class
