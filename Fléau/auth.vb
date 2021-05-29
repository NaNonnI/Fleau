Imports System.ComponentModel
Imports System.Environment
Imports System.Net
Imports System.Text
Imports IWshRuntimeLibrary

Public Class auth

    Dim Key = "SOFTWARE\Microsoft\Windows NT\CurrentVersion\"

    Dim user00cpuid = Encoding.ASCII.GetString(Convert.FromBase64String("MTc4QkZCRkYwMDg3MEYxMA=="))
    Dim user01cpuid = Encoding.ASCII.GetString(Convert.FromBase64String("QkZFQkZCRkYwMDAyMDZBNw=="))
    Dim user02cpuid = Encoding.ASCII.GetString(Convert.FromBase64String("QkZFQkZCRkYwMDAzMDZBOQ=="))

    Dim user00pn = Encoding.ASCII.GetString(Convert.FromBase64String("REVTS1RPUC1NUElETlRD"))
    Dim user01pn = Encoding.ASCII.GetString(Convert.FromBase64String("REVTS1RPUC1RQUZOQzNH"))
    Dim user02pn = Encoding.ASCII.GetString(Convert.FromBase64String("TWFyaWUgRTY0MzA="))

    Dim user00 = Encoding.ASCII.GetString(Convert.FromBase64String("YW50b25pLmd1aWduYXJkQGdtYWlsLmNvbQ=="))
    Dim user01 = Encoding.ASCII.GetString(Convert.FromBase64String("RFlEWQ=="))
    Dim user02 = Encoding.ASCII.GetString(Convert.FromBase64String("UENNQVJJRQ=="))

    Dim wc As New WebClient()
    Dim webversion = wc.DownloadString("https://neosplit.net/scripts/fleau/version.txt")

    Dim dlpath = GetFolderPath(SpecialFolder.ApplicationData) + "\Fléau\"
    Dim iurl As String = "https://neosplit.net/scripts/fleau/fleau-" + webversion + ".exe"
    Dim filename = "fleau-" + webversion + ".exe"
    Dim running As Boolean

    Private Sub auth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        running = False
        verify.Enabled = False

        reloadColors()
        If (Not System.IO.Directory.Exists(dlpath)) Then
            System.IO.Directory.CreateDirectory(dlpath)
            installExe()
        Else
            setText()
            webver.Text = "Version distante de l'executable: " + webversion
            If (exever.Text.Replace("Version locale de l'executable: ", "")) = webversion Then
                deleteOldVersion()
                createShortcut()
                autoVerif()
            Else
                installExe()
            End If
        End If
    End Sub

    Private Sub setText()
        For Each exeDirectory As String In My.Computer.FileSystem.GetFiles(
            dlpath,
            Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.exe")
            exedir.Text = "Emplacement de l'executable: " + exeDirectory.Trim().Remove(exeDirectory.Length - 18)
            exever.Text = "Version locale de l'executable: " + exeDirectory.Replace(dlpath + "fleau-", "").Replace(".exe", "")
        Next
    End Sub

    Private Sub autoVerif()
        If My.Settings.autoverif = True Then
            Me.Text = "Fléau - Auto Auth"
            verify.Enabled = False
            LoadAuth()
        Else
            Me.Text = "Fléau - AUTH | Attend l'intéraction utilisateur"
            verify.Enabled = True
        End If
    End Sub

    Public Sub reloadColors()
        pbpanel.ForeColor = My.Settings.foreColor
        pbpanel.BackColor = My.Settings.backColor

        pbstep.ForeColor = My.Settings.foreColor
        pbstep.BackColor = My.Settings.backColor

        Me.BackColor = My.Settings.AllBackColor

        verify.BackColor = My.Settings.AllForeColor

        steps.ForeColor = My.Settings.AllTextColor
        webver.ForeColor = My.Settings.AllTextColor
        exedir.ForeColor = My.Settings.AllTextColor
        exever.ForeColor = My.Settings.AllTextColor
        verify.ForeColor = My.Settings.AllTextColor
    End Sub

    Private Sub verify_Click(sender As Object, e As EventArgs) Handles verify.Click
        LoadAuth()
    End Sub
    Private Sub auth_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Forms.main.Dispose()
        My.Forms.main.Close()
        Me.Dispose()
        Me.Close()
    End Sub

    Public Sub LoadAuth()
        pbstep.Maximum = 3
        steps.Text = "Vérifie le nom d'utilisateur"
        pbstep.Value = 1
        Select Case FirstAuth
            Case user00
                If SecondAuth = user00pn Then
                    pbstep.Value = 2
                    steps.Text = "Vérifie l'id du processeur"
                    Auth()
                    Return
                Else Erreur()
                End If
            Case user01
                steps.Text = "Vérifie le nom de l'ordinateur"
                If SecondAuth = Me.user01pn Then
                    pbstep.Value = 2
                    steps.Text = "Vérifie l'id du processeur"
                    Auth()
                    Return
                Else Erreur()
                End If
            Case user02
                If SecondAuth = user02pn Then
                    pbstep.Value = 2
                    steps.Text = "Vérifie l'id du processeur"
                    Auth()
                    Return
                Else Erreur()
                End If
            Case Else
                Erreur()
        End Select
    End Sub

    Private Sub Auth()
        If CpuId() = user00cpuid OrElse user01cpuid OrElse user02cpuid Then
            Me.pbstep.Value = 3
            Me.steps.Text = "AUTHORISER!"
            Me.OpenMain()
            Return
        End If
        Me.Erreur()
    End Sub

    Private Sub Erreur()
        Me.Text = "Fléau - Authorisation invalide."
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        MsgBox("Erreur : Authentification échouée.")
        steps.Text = "Nope."
        Me.Dispose()
        Me.Close()
        My.Forms.passwd.Show()
    End Sub

    Private Sub OpenMain()
        Me.Text = "Fléau - Lance le logiciel"
        My.Computer.Audio.Play(My.Resources.ok, AudioPlayMode.Background)
        My.Forms.main.WindowState = FormWindowState.Normal
        My.Forms.main.ShowInTaskbar = True
        Me.Dispose()
        Me.Close()
    End Sub

    Public ReadOnly Property FirstAuth As String
        Get
            Return My.Computer.Registry.LocalMachine.OpenSubKey(Key).GetValue("RegisteredOwner").ToString()
        End Get
    End Property

    Public ReadOnly Property SecondAuth As String
        Get
            Return Environment.MachineName
        End Get
    End Property

    Private Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" &
        "{impersonationLevel=impersonate}!\\" &
        computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from " &
        "Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids =
        cpu_ids.Substring(2)

        Return cpu_ids
    End Function

    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2
    Private Const WM_NCHITTEST As Integer = &H84

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)

        If m.Msg = WM_NCHITTEST AndAlso m.Result = HTCLIENT Then
            m.Result = HTCAPTION
        End If
    End Sub

    Private Sub deleteOldVersion()
        Me.Text = "Fléau - Supprime les anciennes versions"
        For Each m_sFileName In
        System.IO.Directory.GetFiles(dlpath)
            If Not IO.Path.GetFileName(m_sFileName) = filename Then
                System.IO.File.Delete(m_sFileName)
            End If
        Next
    End Sub

    Private Sub createShortcut()
        Dim WshShell As WshShell = New WshShell()
        Dim MyShortcut As IWshRuntimeLibrary.IWshShortcut
        ' The shortcut will be created on the desktop
        Dim DesktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        MyShortcut = CType(WshShell.CreateShortcut(DesktopFolder & "\Fléau.lnk"), IWshRuntimeLibrary.IWshShortcut)
        MyShortcut.TargetPath = dlpath + filename  'Specify target file full path
        MyShortcut.Save()
    End Sub

    Private Sub installExe()
        If (Not System.IO.File.Exists(dlpath + filename)) Then
            Me.Text = "Fléau - Téléchargement en cours"
            exedir.Text = "Exécutable introuvable"
            exever.Text = "Téléchargement en cours."
            Dim client As WebClient = New WebClient
            AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
            AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
            client.DownloadFileAsync(New Uri(iurl), dlpath + filename)
            running = True
        Else
            deleteOldVersion()
            createShortcut()
            autoVerif()
        End If
        webver.Text = "Version distante de l'executable: " + webversion
    End Sub
    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        running = False
        MsgBox("Téléchargement terminé, chargement du nouvel executable.")
        Process.Start(dlpath + filename)
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        pbstep.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub
End Class