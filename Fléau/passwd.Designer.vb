<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class passwd
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
        Me.infosbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'infosbtn
        '
        Me.infosbtn.Location = New System.Drawing.Point(229, 103)
        Me.infosbtn.Name = "infosbtn"
        Me.infosbtn.Size = New System.Drawing.Size(75, 23)
        Me.infosbtn.TabIndex = 0
        Me.infosbtn.Text = "infos"
        Me.infosbtn.UseVisualStyleBackColor = True
        '
        'passwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 125)
        Me.Controls.Add(Me.infosbtn)
        Me.Name = "passwd"
        Me.Text = "passwd"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents infosbtn As Button
End Class
