Imports System.Threading

Public Class infos
    Dim Key = "SOFTWARE\Microsoft\Windows NT\CurrentVersion\"
    Private Sub infos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cpuidtxt.Text = EncodeBase64(CpuId())
        pcnametxt.Text = EncodeBase64(Environment.MachineName)
        usernametxt.Text = EncodeBase64(subkey)
    End Sub
    Private Sub copy_Click(sender As Object, e As EventArgs) Handles copy.Click
        Clipboard.SetText("CPUID: " + "```" + cpuidtxt.Text + "```" + "PCNAME: " + "```" + pcnametxt.Text + "```" + "USERNAME: " + "```" + usernametxt.Text + "```")
    End Sub
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
    Public ReadOnly Property subkey As String
        Get
            Return My.Computer.Registry.LocalMachine.OpenSubKey(Key).GetValue("RegisteredOwner").ToString
        End Get
    End Property
    Public Function EncodeBase64(input As String) As String
        Return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input))
    End Function
End Class