Imports System.ComponentModel

Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadColors()
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        My.Forms.auth.Show()
    End Sub

    Private Sub menu1_Click(sender As Object, e As EventArgs) Handles menu1.Click
        Me.Text = "Fléau - Chargement..."
        clearPanel(menu_rorror)
        menu1.ForeColor = Color.LightBlue
        switchPanel(menu_rorror)
        Me.Text = "Fléau - Ror ror"
    End Sub
    Private Sub menu2_Click(sender As Object, e As EventArgs) Handles menu2.Click
        Me.Text = "Fléau - Chargement..."
        clearPanel(menu_perf)
        menu2.ForeColor = Color.LightGreen
        switchPanel(menu_perf)
        Me.Text = "Fléau - Performances"
    End Sub
    Private Sub menu3_Click(sender As Object, e As EventArgs) Handles menu3.Click
        Me.Text = "Fléau - Chargement..."
        clearPanel(menu_fileconvertor)
        menu3.ForeColor = Color.LightPink
        switchPanel(menu_fileconvertor)
        Me.Text = "Fléau - Spotify"
    End Sub
    Sub clearPanel(ByVal panel As Form)
        menu1.ForeColor = My.Settings.AllTextColor
        menu2.ForeColor = My.Settings.AllTextColor
        menu3.ForeColor = My.Settings.AllTextColor
        pane.Controls.Clear()
        panel.TopLevel = True
        pane.Controls.Remove(panel)
        panel.Close()
        panel.Dispose()
    End Sub

    Sub switchPanel(ByVal panel As Form)
        pane.Controls.Clear()
        panel.TopLevel = False
        pane.Controls.Add(panel)
        panel.Show()
    End Sub

    Public Sub reloadColors()
        Me.BackColor = My.Settings.AllBackColor

        pane.BackColor = My.Settings.AllBackColor

        menu1.BackColor = My.Settings.AllForeColor
        menu2.BackColor = My.Settings.AllForeColor
        menu3.BackColor = My.Settings.AllForeColor

        menu1.ForeColor = My.Settings.AllTextColor
        menu2.ForeColor = My.Settings.AllTextColor
        menu3.ForeColor = My.Settings.AllTextColor
    End Sub

    Private Sub options_Click(sender As Object, e As EventArgs) Handles optionsbtn.Click
        options.Show()
    End Sub
End Class