Imports System.ComponentModel

Public Class menu_perf
    Private Sub menu_perf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadColors()
        bgWorkerCPU.RunWorkerAsync()
        bgWorkerMem.RunWorkerAsync()
        bgWorkerDisk.RunWorkerAsync()
    End Sub

    Public Sub reloadColors()
        cpuperfpb.ForeColor = My.Settings.foreColor
        cpuperfpb.BackColor = My.Settings.backColor

        pbdesign1.ForeColor = My.Settings.foreColor
        pbdesign1.BackColor = My.Settings.backColor

        memperfpb.ForeColor = My.Settings.foreColor
        memperfpb.BackColor = My.Settings.backColor

        pbdesign2.ForeColor = My.Settings.foreColor
        pbdesign2.BackColor = My.Settings.backColor

        diskperfpb.ForeColor = My.Settings.foreColor
        diskperfpb.BackColor = My.Settings.backColor

        pbdesign3.ForeColor = My.Settings.foreColor
        pbdesign3.BackColor = My.Settings.backColor

        Me.BackColor = My.Settings.AllBackColor

        cpuperf.ForeColor = My.Settings.AllTextColor
        memperf.ForeColor = My.Settings.AllTextColor
        diskperf.ForeColor = My.Settings.AllTextColor
    End Sub

    Private Sub bgWorkerCPU_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorkerCPU.DoWork
        While True
            Dim Val As Decimal = perfCounterCPU.NextValue
            Dim ReadableVal As Decimal
            Threading.Thread.Sleep(500)
            Val = perfCounterCPU.NextValue
            ReadableVal = Decimal.Round(Val)
            If cpuperf.InvokeRequired = True Then
                cpuperf.Invoke(Sub() cpuperf.Text = "PROCESSEUR: " + ReadableVal.ToString() + " %")
            Else
                cpuperf.Text = "PROCESSEUR: " + ReadableVal.ToString() + " %"
            End If
            If cpuperfpb.InvokeRequired = True Then
                cpuperfpb.Invoke(Sub() cpuperfpb.Value = Val)
            Else
                cpuperfpb.Value = Val
            End If
        End While
    End Sub

    Private Sub bgWorkerMem_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorkerMem.DoWork
        While True
            Dim Val As Decimal = perfCounterMem.NextValue
            Dim ReadableVal As Decimal
            Threading.Thread.Sleep(500)
            Val = perfCounterMem.NextValue
            ReadableVal = Decimal.Round(Val)
            If memperf.InvokeRequired = True Then
                memperf.Invoke(Sub() memperf.Text = "MÉMOIRE: " + ReadableVal.ToString() + " %")
            Else
                memperf.Text = "MÉMOIRE: " + ReadableVal.ToString() + " %"
            End If
            If memperfpb.InvokeRequired = True Then
                memperfpb.Invoke(Sub() memperfpb.Value = Val)
            Else
                memperfpb.Value = Val
            End If
        End While
    End Sub

    Private Sub bgWorkerDisk_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorkerDisk.DoWork
        While True
            Dim Val As Decimal = perfCounterDisk.NextValue
            Dim ReadableVal As Decimal
            Threading.Thread.Sleep(500)
            Val = perfCounterDisk.NextValue
            ReadableVal = Decimal.Round(Val)
            If diskperf.InvokeRequired = True Then
                diskperf.Invoke(Sub() diskperf.Text = "DISQUE: " + ReadableVal.ToString() + " %")
            Else
                diskperf.Text = "DISQUE: " + ReadableVal.ToString() + " %"
            End If
            If diskperfpb.InvokeRequired = True Then
                diskperfpb.Invoke(Sub() diskperfpb.Value = Val)
            Else
                diskperfpb.Value = Val
            End If
        End While
    End Sub
End Class