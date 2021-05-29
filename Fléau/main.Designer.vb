<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.pane = New System.Windows.Forms.Panel()
        Me.menu1 = New System.Windows.Forms.Button()
        Me.menu2 = New System.Windows.Forms.Button()
        Me.optionsbtn = New System.Windows.Forms.PictureBox()
        Me.menu3 = New System.Windows.Forms.Button()
        CType(Me.optionsbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pane
        '
        Me.pane.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pane.Location = New System.Drawing.Point(0, 29)
        Me.pane.Name = "pane"
        Me.pane.Size = New System.Drawing.Size(800, 425)
        Me.pane.TabIndex = 0
        '
        'menu1
        '
        Me.menu1.BackColor = System.Drawing.Color.Gray
        Me.menu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menu1.ForeColor = System.Drawing.Color.White
        Me.menu1.Location = New System.Drawing.Point(0, 0)
        Me.menu1.Name = "menu1"
        Me.menu1.Size = New System.Drawing.Size(256, 30)
        Me.menu1.TabIndex = 1
        Me.menu1.Text = "Ror ror."
        Me.menu1.UseVisualStyleBackColor = False
        '
        'menu2
        '
        Me.menu2.BackColor = System.Drawing.Color.Gray
        Me.menu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menu2.ForeColor = System.Drawing.Color.White
        Me.menu2.Location = New System.Drawing.Point(256, 0)
        Me.menu2.Name = "menu2"
        Me.menu2.Size = New System.Drawing.Size(256, 30)
        Me.menu2.TabIndex = 2
        Me.menu2.Text = "Performances"
        Me.menu2.UseVisualStyleBackColor = False
        '
        'optionsbtn
        '
        Me.optionsbtn.Image = Global.Fléau.My.Resources.Resources._option
        Me.optionsbtn.Location = New System.Drawing.Point(769, 0)
        Me.optionsbtn.Name = "optionsbtn"
        Me.optionsbtn.Size = New System.Drawing.Size(30, 30)
        Me.optionsbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.optionsbtn.TabIndex = 3
        Me.optionsbtn.TabStop = False
        '
        'menu3
        '
        Me.menu3.BackColor = System.Drawing.Color.Gray
        Me.menu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menu3.ForeColor = System.Drawing.Color.White
        Me.menu3.Location = New System.Drawing.Point(512, 0)
        Me.menu3.Name = "menu3"
        Me.menu3.Size = New System.Drawing.Size(256, 30)
        Me.menu3.TabIndex = 4
        Me.menu3.Text = "File Encoder"
        Me.menu3.UseVisualStyleBackColor = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.menu3)
        Me.Controls.Add(Me.optionsbtn)
        Me.Controls.Add(Me.menu2)
        Me.Controls.Add(Me.menu1)
        Me.Controls.Add(Me.pane)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "main"
        Me.Text = "Fléau"
        CType(Me.optionsbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pane As Panel
    Friend WithEvents menu1 As Button
    Friend WithEvents menu2 As Button
    Friend WithEvents optionsbtn As PictureBox
    Friend WithEvents menu3 As Button
End Class
