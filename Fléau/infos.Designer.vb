<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infos
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
        Me.cpuidtxt = New System.Windows.Forms.TextBox()
        Me.pcnametxt = New System.Windows.Forms.TextBox()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.copy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cpuidtxt
        '
        Me.cpuidtxt.Location = New System.Drawing.Point(12, 12)
        Me.cpuidtxt.Name = "cpuidtxt"
        Me.cpuidtxt.Size = New System.Drawing.Size(355, 20)
        Me.cpuidtxt.TabIndex = 0
        '
        'pcnametxt
        '
        Me.pcnametxt.Location = New System.Drawing.Point(12, 38)
        Me.pcnametxt.Name = "pcnametxt"
        Me.pcnametxt.Size = New System.Drawing.Size(355, 20)
        Me.pcnametxt.TabIndex = 1
        '
        'usernametxt
        '
        Me.usernametxt.Location = New System.Drawing.Point(12, 64)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(355, 20)
        Me.usernametxt.TabIndex = 2
        '
        'copy
        '
        Me.copy.Location = New System.Drawing.Point(13, 91)
        Me.copy.Name = "copy"
        Me.copy.Size = New System.Drawing.Size(354, 23)
        Me.copy.TabIndex = 3
        Me.copy.Text = "Copier"
        Me.copy.UseVisualStyleBackColor = True
        '
        'infos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 126)
        Me.Controls.Add(Me.copy)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.pcnametxt)
        Me.Controls.Add(Me.cpuidtxt)
        Me.Name = "infos"
        Me.Text = "infos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cpuidtxt As TextBox
    Friend WithEvents pcnametxt As TextBox
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents copy As Button
End Class
