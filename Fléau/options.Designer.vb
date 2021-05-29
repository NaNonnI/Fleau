<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class options
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
        Me.colorPickerBC = New System.Windows.Forms.ColorDialog()
        Me.colorPickerFC = New System.Windows.Forms.ColorDialog()
        Me.colorPickerABC = New System.Windows.Forms.ColorDialog()
        Me.openColorPickerAFC = New System.Windows.Forms.Panel()
        Me.openColorPickerABC = New System.Windows.Forms.Panel()
        Me.autoverif = New System.Windows.Forms.CheckBox()
        Me.openColorPickerFC = New System.Windows.Forms.Panel()
        Me.openColorPickerBC = New System.Windows.Forms.Panel()
        Me.colorPickerAFC = New System.Windows.Forms.ColorDialog()
        Me.openColorPickerATC = New System.Windows.Forms.Panel()
        Me.colorPickerATC = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'openColorPickerAFC
        '
        Me.openColorPickerAFC.BackColor = Global.Fléau.My.MySettings.Default.AllForeColor
        Me.openColorPickerAFC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.openColorPickerAFC.Cursor = System.Windows.Forms.Cursors.Cross
        Me.openColorPickerAFC.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Fléau.My.MySettings.Default, "AllForeColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.openColorPickerAFC.Location = New System.Drawing.Point(180, 12)
        Me.openColorPickerAFC.Name = "openColorPickerAFC"
        Me.openColorPickerAFC.Size = New System.Drawing.Size(50, 50)
        Me.openColorPickerAFC.TabIndex = 3
        '
        'openColorPickerABC
        '
        Me.openColorPickerABC.BackColor = Global.Fléau.My.MySettings.Default.AllBackColor
        Me.openColorPickerABC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.openColorPickerABC.Cursor = System.Windows.Forms.Cursors.Cross
        Me.openColorPickerABC.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Fléau.My.MySettings.Default, "AllBackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.openColorPickerABC.Location = New System.Drawing.Point(124, 12)
        Me.openColorPickerABC.Name = "openColorPickerABC"
        Me.openColorPickerABC.Size = New System.Drawing.Size(50, 50)
        Me.openColorPickerABC.TabIndex = 2
        '
        'autoverif
        '
        Me.autoverif.AutoSize = True
        Me.autoverif.Checked = Global.Fléau.My.MySettings.Default.autoverif
        Me.autoverif.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Fléau.My.MySettings.Default, "autoverif", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.autoverif.ForeColor = System.Drawing.Color.White
        Me.autoverif.Location = New System.Drawing.Point(3, 115)
        Me.autoverif.Name = "autoverif"
        Me.autoverif.Size = New System.Drawing.Size(140, 17)
        Me.autoverif.TabIndex = 2
        Me.autoverif.Text = "Vérification Automatique"
        Me.autoverif.UseVisualStyleBackColor = True
        '
        'openColorPickerFC
        '
        Me.openColorPickerFC.BackColor = Global.Fléau.My.MySettings.Default.foreColor
        Me.openColorPickerFC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.openColorPickerFC.Cursor = System.Windows.Forms.Cursors.Cross
        Me.openColorPickerFC.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Fléau.My.MySettings.Default, "foreColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.openColorPickerFC.Location = New System.Drawing.Point(68, 12)
        Me.openColorPickerFC.Name = "openColorPickerFC"
        Me.openColorPickerFC.Size = New System.Drawing.Size(50, 50)
        Me.openColorPickerFC.TabIndex = 1
        '
        'openColorPickerBC
        '
        Me.openColorPickerBC.BackColor = Global.Fléau.My.MySettings.Default.backColor
        Me.openColorPickerBC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.openColorPickerBC.Cursor = System.Windows.Forms.Cursors.Cross
        Me.openColorPickerBC.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Fléau.My.MySettings.Default, "backColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.openColorPickerBC.Location = New System.Drawing.Point(12, 12)
        Me.openColorPickerBC.Name = "openColorPickerBC"
        Me.openColorPickerBC.Size = New System.Drawing.Size(50, 50)
        Me.openColorPickerBC.TabIndex = 0
        '
        'openColorPickerATC
        '
        Me.openColorPickerATC.BackColor = Global.Fléau.My.MySettings.Default.AllTextColor
        Me.openColorPickerATC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.openColorPickerATC.Cursor = System.Windows.Forms.Cursors.Cross
        Me.openColorPickerATC.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.Fléau.My.MySettings.Default, "AllTextColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.openColorPickerATC.Location = New System.Drawing.Point(236, 12)
        Me.openColorPickerATC.Name = "openColorPickerATC"
        Me.openColorPickerATC.Size = New System.Drawing.Size(50, 50)
        Me.openColorPickerATC.TabIndex = 4
        '
        'options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(296, 131)
        Me.Controls.Add(Me.openColorPickerATC)
        Me.Controls.Add(Me.openColorPickerAFC)
        Me.Controls.Add(Me.openColorPickerABC)
        Me.Controls.Add(Me.autoverif)
        Me.Controls.Add(Me.openColorPickerFC)
        Me.Controls.Add(Me.openColorPickerBC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "options"
        Me.Text = "options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents colorPickerBC As ColorDialog
    Friend WithEvents openColorPickerBC As Panel
    Friend WithEvents openColorPickerFC As Panel
    Friend WithEvents colorPickerFC As ColorDialog
    Friend WithEvents autoverif As CheckBox
    Friend WithEvents colorPickerABC As ColorDialog
    Friend WithEvents openColorPickerABC As Panel
    Friend WithEvents openColorPickerAFC As Panel
    Friend WithEvents colorPickerAFC As ColorDialog
    Friend WithEvents openColorPickerATC As Panel
    Friend WithEvents colorPickerATC As ColorDialog
End Class
