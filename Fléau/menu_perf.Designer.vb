<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_perf
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
        Me.perfCounterCPU = New System.Diagnostics.PerformanceCounter()
        Me.pbdesign1 = New System.Windows.Forms.Panel()
        Me.cpuperfpb = New System.Windows.Forms.ProgressBar()
        Me.cpuperf = New System.Windows.Forms.Label()
        Me.bgWorkerCPU = New System.ComponentModel.BackgroundWorker()
        Me.memperf = New System.Windows.Forms.Label()
        Me.memperfpb = New System.Windows.Forms.ProgressBar()
        Me.pbdesign2 = New System.Windows.Forms.Panel()
        Me.bgWorkerMem = New System.ComponentModel.BackgroundWorker()
        Me.perfCounterMem = New System.Diagnostics.PerformanceCounter()
        Me.perfCounterDisk = New System.Diagnostics.PerformanceCounter()
        Me.bgWorkerDisk = New System.ComponentModel.BackgroundWorker()
        Me.diskperf = New System.Windows.Forms.Label()
        Me.diskperfpb = New System.Windows.Forms.ProgressBar()
        Me.pbdesign3 = New System.Windows.Forms.Panel()
        CType(Me.perfCounterCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pbdesign1.SuspendLayout()
        Me.pbdesign2.SuspendLayout()
        CType(Me.perfCounterMem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.perfCounterDisk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pbdesign3.SuspendLayout()
        Me.SuspendLayout()
        '
        'perfCounterCPU
        '
        Me.perfCounterCPU.CategoryName = "Processor"
        Me.perfCounterCPU.CounterName = "% Processor Time"
        Me.perfCounterCPU.InstanceName = "_Total"
        '
        'pbdesign1
        '
        Me.pbdesign1.BackColor = System.Drawing.Color.Indigo
        Me.pbdesign1.Controls.Add(Me.cpuperfpb)
        Me.pbdesign1.ForeColor = System.Drawing.Color.BlueViolet
        Me.pbdesign1.Location = New System.Drawing.Point(12, 25)
        Me.pbdesign1.Name = "pbdesign1"
        Me.pbdesign1.Size = New System.Drawing.Size(776, 25)
        Me.pbdesign1.TabIndex = 0
        '
        'cpuperfpb
        '
        Me.cpuperfpb.ForeColor = System.Drawing.Color.BlueViolet
        Me.cpuperfpb.Location = New System.Drawing.Point(-2, -13)
        Me.cpuperfpb.Name = "cpuperfpb"
        Me.cpuperfpb.Size = New System.Drawing.Size(779, 47)
        Me.cpuperfpb.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.cpuperfpb.TabIndex = 0
        '
        'cpuperf
        '
        Me.cpuperf.AutoSize = True
        Me.cpuperf.ForeColor = System.Drawing.Color.White
        Me.cpuperf.Location = New System.Drawing.Point(12, 9)
        Me.cpuperf.Name = "cpuperf"
        Me.cpuperf.Size = New System.Drawing.Size(90, 13)
        Me.cpuperf.TabIndex = 1
        Me.cpuperf.Text = "PROCESSEUR: -"
        '
        'bgWorkerCPU
        '
        '
        'memperf
        '
        Me.memperf.AutoSize = True
        Me.memperf.ForeColor = System.Drawing.Color.White
        Me.memperf.Location = New System.Drawing.Point(12, 62)
        Me.memperf.Name = "memperf"
        Me.memperf.Size = New System.Drawing.Size(67, 13)
        Me.memperf.TabIndex = 3
        Me.memperf.Text = "MÉMOIRE: -"
        '
        'memperfpb
        '
        Me.memperfpb.ForeColor = System.Drawing.Color.BlueViolet
        Me.memperfpb.Location = New System.Drawing.Point(-2, -13)
        Me.memperfpb.Name = "memperfpb"
        Me.memperfpb.Size = New System.Drawing.Size(779, 47)
        Me.memperfpb.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.memperfpb.TabIndex = 0
        '
        'pbdesign2
        '
        Me.pbdesign2.BackColor = System.Drawing.Color.Indigo
        Me.pbdesign2.Controls.Add(Me.memperfpb)
        Me.pbdesign2.ForeColor = System.Drawing.Color.BlueViolet
        Me.pbdesign2.Location = New System.Drawing.Point(12, 78)
        Me.pbdesign2.Name = "pbdesign2"
        Me.pbdesign2.Size = New System.Drawing.Size(776, 25)
        Me.pbdesign2.TabIndex = 2
        '
        'bgWorkerMem
        '
        '
        'perfCounterMem
        '
        Me.perfCounterMem.CategoryName = "Mémoire"
        Me.perfCounterMem.CounterName = "Pourcentage d’octets dédiés utilisés"
        '
        'perfCounterDisk
        '
        Me.perfCounterDisk.CategoryName = "Disque physique"
        Me.perfCounterDisk.CounterName = "Pourcentage du temps disque"
        Me.perfCounterDisk.InstanceName = "_Total"
        Me.perfCounterDisk.MachineName = "DESKTOP-MPIDNTC"
        '
        'bgWorkerDisk
        '
        '
        'diskperf
        '
        Me.diskperf.AutoSize = True
        Me.diskperf.ForeColor = System.Drawing.Color.White
        Me.diskperf.Location = New System.Drawing.Point(12, 115)
        Me.diskperf.Name = "diskperf"
        Me.diskperf.Size = New System.Drawing.Size(57, 13)
        Me.diskperf.TabIndex = 5
        Me.diskperf.Text = "DISQUE: -"
        '
        'diskperfpb
        '
        Me.diskperfpb.ForeColor = System.Drawing.Color.BlueViolet
        Me.diskperfpb.Location = New System.Drawing.Point(-2, -13)
        Me.diskperfpb.Name = "diskperfpb"
        Me.diskperfpb.Size = New System.Drawing.Size(779, 47)
        Me.diskperfpb.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.diskperfpb.TabIndex = 0
        '
        'pbdesign3
        '
        Me.pbdesign3.BackColor = System.Drawing.Color.Indigo
        Me.pbdesign3.Controls.Add(Me.diskperfpb)
        Me.pbdesign3.ForeColor = System.Drawing.Color.BlueViolet
        Me.pbdesign3.Location = New System.Drawing.Point(12, 131)
        Me.pbdesign3.Name = "pbdesign3"
        Me.pbdesign3.Size = New System.Drawing.Size(776, 25)
        Me.pbdesign3.TabIndex = 4
        '
        'menu_perf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 425)
        Me.Controls.Add(Me.diskperf)
        Me.Controls.Add(Me.pbdesign3)
        Me.Controls.Add(Me.memperf)
        Me.Controls.Add(Me.pbdesign2)
        Me.Controls.Add(Me.cpuperf)
        Me.Controls.Add(Me.pbdesign1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "menu_perf"
        Me.Text = "menu_perf"
        CType(Me.perfCounterCPU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pbdesign1.ResumeLayout(False)
        Me.pbdesign2.ResumeLayout(False)
        CType(Me.perfCounterMem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.perfCounterDisk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pbdesign3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents perfCounterCPU As PerformanceCounter
    Friend WithEvents pbdesign1 As Panel
    Friend WithEvents cpuperfpb As ProgressBar
    Friend WithEvents cpuperf As Label
    Friend WithEvents bgWorkerCPU As System.ComponentModel.BackgroundWorker
    Friend WithEvents memperf As Label
    Friend WithEvents memperfpb As ProgressBar
    Friend WithEvents pbdesign2 As Panel
    Friend WithEvents bgWorkerMem As System.ComponentModel.BackgroundWorker
    Friend WithEvents perfCounterMem As PerformanceCounter
    Friend WithEvents perfCounterDisk As PerformanceCounter
    Friend WithEvents bgWorkerDisk As System.ComponentModel.BackgroundWorker
    Friend WithEvents diskperf As Label
    Friend WithEvents diskperfpb As ProgressBar
    Friend WithEvents pbdesign3 As Panel
End Class
