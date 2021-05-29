Imports System.IO

Public Class menu_fileconvertor

    Public writing As Boolean = False

    Public Sub reloadColors()
        Me.BackColor = My.Settings.AllBackColor

        filechoosetxt.ForeColor = My.Settings.AllTextColor
        folderchoosetxt.ForeColor = My.Settings.AllTextColor
        steps.ForeColor = My.Settings.AllTextColor

        filechoose.BackColor = My.Settings.AllForeColor
        folderchoose.BackColor = My.Settings.AllForeColor
        edbutton.BackColor = My.Settings.AllForeColor
        startconvertion.BackColor = My.Settings.AllForeColor

        filechoose.ForeColor = My.Settings.AllTextColor
        folderchoose.ForeColor = My.Settings.AllTextColor
        edbutton.ForeColor = My.Settings.AllTextColor
        startconvertion.ForeColor = My.Settings.AllTextColor

        filepath.BackColor = My.Settings.AllForeColor
        folderpath.BackColor = My.Settings.AllForeColor

        filepath.ForeColor = My.Settings.AllTextColor
        folderpath.ForeColor = My.Settings.AllTextColor

        pbpanel.ForeColor = My.Settings.foreColor
        pbpanel.BackColor = My.Settings.backColor

        pbstep.ForeColor = My.Settings.foreColor
        pbstep.BackColor = My.Settings.backColor
    End Sub
    Private Sub menu_fileconvertor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filepath.Text = "C:\"
        folderpath.Text = "C:\"
        reloadColors()
    End Sub

    Private Sub filechoose_Click(sender As Object, e As EventArgs) Handles filechoose.Click
        Dim myStream As Stream = Nothing

        OpenFileDialog.InitialDirectory = filepath.Text
        OpenFileDialog.Filter = "Tout les fichiers (*.*)|*.*"
        OpenFileDialog.FilterIndex = 1
        OpenFileDialog.RestoreDirectory = True
        OpenFileDialog.Multiselect = False

        If OpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = OpenFileDialog.OpenFile()
                If (myStream IsNot Nothing) Then
                    ' Insert code to read the stream here.
                    Dim filename = Path.GetFileName(OpenFileDialog.FileName)
                    Dim directoryname = Path.GetDirectoryName(OpenFileDialog.FileName)
                    Dim fullpath = directoryname & "\" & filename
                    filepath.Text = fullpath
                    folderpath.Text = directoryname
                End If
            Catch Ex As Exception
                MessageBox.Show("Ne peux pas lire le fichier séléctionné. : " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub folderchoose_Click(sender As Object, e As EventArgs) Handles folderchoose.Click
        Dim myStream As Stream = Nothing

        FolderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog.SelectedPath = folderpath.Text

        If FolderBrowserDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            folderpath.Text = FolderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub edbutton_Click(sender As Object, e As EventArgs) Handles edbutton.Click
        If edbutton.Text = "Encode" Then
            edbutton.Text = "Décode"
            filechoosetxt.Text = "Choisir le fichier a décodé"
        ElseIf edbutton.Text = "Décode" Then
            edbutton.Text = "Encode"
            filechoosetxt.Text = "Choisir le fichier a encodé"
        End If
    End Sub

    Public Sub EXEtoImage()
        If writing = True Then
            MsgBox("Déjà en cours de conversion.")
        Else
            writing = True

            Dim buff As Byte() = File.ReadAllBytes(OpenFileDialog.FileName)
            pbstep.Maximum = buff.Length
            Dim size As Integer = Math.Sqrt(buff.Length) + 2
            Dim fs As New System.IO.StreamWriter(folderpath.Text + "\bytes.txt", System.IO.FileMode.Create)

            Dim img As New Bitmap(size, size)
            Dim imgGraphics As Graphics = Graphics.FromImage(img)

            Dim y As Integer = 0
            Dim x As Integer = 0
            Dim c As Integer = 0
            Dim c2 As Integer = 1

            imgGraphics.FillRectangle(Brushes.White, 0, 0, size, size)
            imgGraphics.Save()

            Do While (y < size)
                Do While (x < size)
                    If (c < (buff.Length - 1)) Then
                        Dim r = buff(c)
                        Dim g = c2
                        Dim b2 = c2
                        Dim argb = 255 + ((255 Or r) + ((16 Or g) + (8 Or b2)))

                        Dim br = New SolidBrush(Color.FromArgb(argb))

                        'img.SetPixel(x, y, Color.FromArgb(argb))
                        imgGraphics.FillRectangle(br, x, y, 1, 1)
                        imgGraphics.Save()
                        picturebox.Image = img
                        c = (c + 1)
                        c2 = (c2 + 1)
                        If (c2 = 253) Then
                            c2 = 1
                        End If
                    End If
                    x = (x + 1)
                Loop
                y = (y + 1)
            Loop

            Application.DoEvents()
            For i = 0 To buff.Length - 1 Step 1
                If writing = True Then
                    Application.DoEvents()
                    Console.Write(buff(i) & " ")
                    fs.Write(buff(i) & " ")
                    pbstep.Value = i
                    steps.Text = i.ToString + " / " + buff.Length.ToString
                Else
                    MsgBox("Stop.")
                    fs.Close()
                End If
            Next
            Application.DoEvents()
            fs.Close()
            picturebox.Image = img
            pbstep.Value = 0
            writing = False
            steps.Text = "..."
            img.Save(folderpath.Text + "\image.png", System.Drawing.Imaging.ImageFormat.Png)
            startconvertion.Text = "Converti avec succès!"
            Application.DoEvents()
            Threading.Thread.Sleep(1000)
            startconvertion.Text = "Go"
        End If
    End Sub

    Private Sub startconvertion_Click(sender As Object, e As EventArgs) Handles startconvertion.Click
        EXEtoImage()
    End Sub
End Class