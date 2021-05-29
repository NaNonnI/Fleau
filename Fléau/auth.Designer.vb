<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class auth
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
        Me.steps = New System.Windows.Forms.Label()
        Me.verify = New System.Windows.Forms.Button()
        Me.pbpanel = New System.Windows.Forms.Panel()
        Me.pbstep = New System.Windows.Forms.ProgressBar()
        Me.webver = New System.Windows.Forms.Label()
        Me.exever = New System.Windows.Forms.Label()
        Me.exedir = New System.Windows.Forms.Label()
        Me.pbpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'steps
        '
        Me.steps.AutoSize = True
        Me.steps.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.steps.ForeColor = System.Drawing.Color.White
        Me.steps.Location = New System.Drawing.Point(2, 159)
        Me.steps.Name = "steps"
        Me.steps.Size = New System.Drawing.Size(16, 13)
        Me.steps.TabIndex = 8
        Me.steps.Text = "..."
        '
        'verify
        '
        Me.verify.BackColor = System.Drawing.Color.Gray
        Me.verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.verify.ForeColor = System.Drawing.Color.White
        Me.verify.Location = New System.Drawing.Point(0, 175)
        Me.verify.Name = "verify"
        Me.verify.Size = New System.Drawing.Size(465, 23)
        Me.verify.TabIndex = 7
        Me.verify.Text = "Vérifier"
        Me.verify.UseVisualStyleBackColor = False
        '
        'pbpanel
        '
        Me.pbpanel.Controls.Add(Me.pbstep)
        Me.pbpanel.Location = New System.Drawing.Point(0, 204)
        Me.pbpanel.Name = "pbpanel"
        Me.pbpanel.Size = New System.Drawing.Size(465, 12)
        Me.pbpanel.TabIndex = 9
        '
        'pbstep
        '
        Me.pbstep.BackColor = System.Drawing.Color.Indigo
        Me.pbstep.ForeColor = System.Drawing.Color.BlueViolet
        Me.pbstep.Location = New System.Drawing.Point(-8, -16)
        Me.pbstep.Name = "pbstep"
        Me.pbstep.Size = New System.Drawing.Size(482, 39)
        Me.pbstep.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbstep.TabIndex = 4
        '
        'webver
        '
        Me.webver.AutoSize = True
        Me.webver.ForeColor = System.Drawing.Color.White
        Me.webver.Location = New System.Drawing.Point(12, 47)
        Me.webver.Name = "webver"
        Me.webver.Size = New System.Drawing.Size(165, 13)
        Me.webver.TabIndex = 12
        Me.webver.Text = "Version distante de l'executable: -"
        '
        'exever
        '
        Me.exever.AutoSize = True
        Me.exever.ForeColor = System.Drawing.Color.White
        Me.exever.Location = New System.Drawing.Point(12, 28)
        Me.exever.Name = "exever"
        Me.exever.Size = New System.Drawing.Size(156, 13)
        Me.exever.TabIndex = 11
        Me.exever.Text = "Version locale de l'executable: -"
        '
        'exedir
        '
        Me.exedir.AutoSize = True
        Me.exedir.ForeColor = System.Drawing.Color.White
        Me.exedir.Location = New System.Drawing.Point(12, 9)
        Me.exedir.Name = "exedir"
        Me.exedir.Size = New System.Drawing.Size(154, 13)
        Me.exedir.TabIndex = 10
        Me.exedir.Text = "Emplacement de l'executable: -"
        '
        'auth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(464, 216)
        Me.Controls.Add(Me.steps)
        Me.Controls.Add(Me.verify)
        Me.Controls.Add(Me.pbpanel)
        Me.Controls.Add(Me.webver)
        Me.Controls.Add(Me.exever)
        Me.Controls.Add(Me.exedir)
        Me.Name = "auth"
        Me.Text = "Fléau - Auth"
        Me.pbpanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents steps As Label
    Friend WithEvents verify As Button
    Friend WithEvents pbpanel As Panel
    Friend WithEvents pbstep As ProgressBar
    Friend WithEvents webver As Label
    Friend WithEvents exever As Label
    Friend WithEvents exedir As Label
End Class
