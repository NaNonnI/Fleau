<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menu_fileconvertor
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.filechoose = New System.Windows.Forms.Button()
        Me.folderchoose = New System.Windows.Forms.Button()
        Me.filepath = New System.Windows.Forms.TextBox()
        Me.folderpath = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.filechoosetxt = New System.Windows.Forms.Label()
        Me.folderchoosetxt = New System.Windows.Forms.Label()
        Me.edbutton = New System.Windows.Forms.Button()
        Me.startconvertion = New System.Windows.Forms.Button()
        Me.pbstep = New System.Windows.Forms.ProgressBar()
        Me.pbpanel = New System.Windows.Forms.Panel()
        Me.steps = New System.Windows.Forms.Label()
        Me.picturebox = New System.Windows.Forms.PictureBox()
        Me.pbpanel.SuspendLayout()
        CType(Me.picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'filechoose
        '
        Me.filechoose.Location = New System.Drawing.Point(12, 25)
        Me.filechoose.Name = "filechoose"
        Me.filechoose.Size = New System.Drawing.Size(75, 23)
        Me.filechoose.TabIndex = 0
        Me.filechoose.Text = "Choisir"
        Me.filechoose.UseVisualStyleBackColor = True
        '
        'folderchoose
        '
        Me.folderchoose.Location = New System.Drawing.Point(12, 69)
        Me.folderchoose.Name = "folderchoose"
        Me.folderchoose.Size = New System.Drawing.Size(75, 23)
        Me.folderchoose.TabIndex = 1
        Me.folderchoose.Text = "Choisir"
        Me.folderchoose.UseVisualStyleBackColor = True
        '
        'filepath
        '
        Me.filepath.Location = New System.Drawing.Point(93, 27)
        Me.filepath.Name = "filepath"
        Me.filepath.Size = New System.Drawing.Size(695, 20)
        Me.filepath.TabIndex = 2
        '
        'folderpath
        '
        Me.folderpath.Location = New System.Drawing.Point(93, 71)
        Me.folderpath.Name = "folderpath"
        Me.folderpath.Size = New System.Drawing.Size(695, 20)
        Me.folderpath.TabIndex = 3
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'filechoosetxt
        '
        Me.filechoosetxt.AutoSize = True
        Me.filechoosetxt.ForeColor = System.Drawing.Color.White
        Me.filechoosetxt.Location = New System.Drawing.Point(12, 9)
        Me.filechoosetxt.Name = "filechoosetxt"
        Me.filechoosetxt.Size = New System.Drawing.Size(128, 13)
        Me.filechoosetxt.TabIndex = 5
        Me.filechoosetxt.Text = "Choisir le fichier a encodé"
        '
        'folderchoosetxt
        '
        Me.folderchoosetxt.AutoSize = True
        Me.folderchoosetxt.ForeColor = System.Drawing.Color.White
        Me.folderchoosetxt.Location = New System.Drawing.Point(12, 51)
        Me.folderchoosetxt.Name = "folderchoosetxt"
        Me.folderchoosetxt.Size = New System.Drawing.Size(151, 13)
        Me.folderchoosetxt.TabIndex = 6
        Me.folderchoosetxt.Text = "Choisir l'emplacement de sortie"
        '
        'edbutton
        '
        Me.edbutton.Location = New System.Drawing.Point(713, 97)
        Me.edbutton.Name = "edbutton"
        Me.edbutton.Size = New System.Drawing.Size(75, 23)
        Me.edbutton.TabIndex = 7
        Me.edbutton.Text = "Encode"
        Me.edbutton.UseVisualStyleBackColor = True
        '
        'startconvertion
        '
        Me.startconvertion.Location = New System.Drawing.Point(12, 97)
        Me.startconvertion.Name = "startconvertion"
        Me.startconvertion.Size = New System.Drawing.Size(695, 23)
        Me.startconvertion.TabIndex = 8
        Me.startconvertion.Text = "Go"
        Me.startconvertion.UseVisualStyleBackColor = True
        '
        'pbstep
        '
        Me.pbstep.Location = New System.Drawing.Point(0, 0)
        Me.pbstep.Name = "pbstep"
        Me.pbstep.Size = New System.Drawing.Size(776, 23)
        Me.pbstep.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbstep.TabIndex = 9
        '
        'pbpanel
        '
        Me.pbpanel.Controls.Add(Me.pbstep)
        Me.pbpanel.Location = New System.Drawing.Point(12, 126)
        Me.pbpanel.Name = "pbpanel"
        Me.pbpanel.Size = New System.Drawing.Size(776, 13)
        Me.pbpanel.TabIndex = 10
        '
        'steps
        '
        Me.steps.AutoSize = True
        Me.steps.ForeColor = System.Drawing.Color.White
        Me.steps.Location = New System.Drawing.Point(12, 142)
        Me.steps.Name = "steps"
        Me.steps.Size = New System.Drawing.Size(16, 13)
        Me.steps.TabIndex = 11
        Me.steps.Text = "..."
        '
        'picturebox
        '
        Me.picturebox.Location = New System.Drawing.Point(15, 158)
        Me.picturebox.Name = "picturebox"
        Me.picturebox.Size = New System.Drawing.Size(256, 256)
        Me.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picturebox.TabIndex = 12
        Me.picturebox.TabStop = False
        '
        'menu_fileconvertor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 425)
        Me.Controls.Add(Me.picturebox)
        Me.Controls.Add(Me.steps)
        Me.Controls.Add(Me.pbpanel)
        Me.Controls.Add(Me.startconvertion)
        Me.Controls.Add(Me.edbutton)
        Me.Controls.Add(Me.folderchoosetxt)
        Me.Controls.Add(Me.filechoosetxt)
        Me.Controls.Add(Me.folderpath)
        Me.Controls.Add(Me.filepath)
        Me.Controls.Add(Me.folderchoose)
        Me.Controls.Add(Me.filechoose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "menu_fileconvertor"
        Me.Text = "menu_fileconvertor"
        Me.pbpanel.ResumeLayout(False)
        CType(Me.picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents filechoose As Button
    Friend WithEvents folderchoose As Button
    Friend WithEvents filepath As TextBox
    Friend WithEvents folderpath As TextBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents filechoosetxt As Label
    Friend WithEvents folderchoosetxt As Label
    Friend WithEvents edbutton As Button
    Friend WithEvents startconvertion As Button
    Friend WithEvents pbstep As ProgressBar
    Friend WithEvents pbpanel As Panel
    Friend WithEvents steps As Label
    Friend WithEvents picturebox As PictureBox
End Class
