Public Class options
    Private Sub openColorPicker_Click(sender As Object, e As EventArgs) Handles openColorPickerBC.Click
        Dim colors As DialogResult
        colors = colorPickerBC.ShowDialog()
        If colors = Windows.Forms.DialogResult.OK Then
            openColorPickerBC.BackColor = colorPickerBC.Color
            reloadColors()
        End If
    End Sub
    Private Sub openColorPickerFC_Click(sender As Object, e As EventArgs) Handles openColorPickerFC.Click
        Dim colors As DialogResult
        colors = colorPickerFC.ShowDialog()
        If colors = Windows.Forms.DialogResult.OK Then
            openColorPickerFC.BackColor = colorPickerFC.Color
            reloadColors()
        End If
    End Sub
    Private Sub openColorPickerABC_Click(sender As Object, e As EventArgs) Handles openColorPickerABC.Click
        Dim colors As DialogResult
        colors = colorPickerABC.ShowDialog()
        If colors = Windows.Forms.DialogResult.OK Then
            openColorPickerABC.BackColor = colorPickerABC.Color
            reloadColors()
        End If
    End Sub
    Private Sub openColorPickerAFC_Click(sender As Object, e As EventArgs) Handles openColorPickerAFC.Click
        Dim colors As DialogResult
        colors = colorPickerAFC.ShowDialog()
        If colors = Windows.Forms.DialogResult.OK Then
            openColorPickerAFC.BackColor = colorPickerAFC.Color
            reloadColors()
        End If
    End Sub
    Private Sub openColorPickerATC_Click(sender As Object, e As EventArgs) Handles openColorPickerATC.Click
        Dim colors As DialogResult
        colors = colorPickerATC.ShowDialog()
        If colors = Windows.Forms.DialogResult.OK Then
            openColorPickerATC.BackColor = colorPickerATC.Color
            reloadColors()
        End If
    End Sub
    Private Sub reloadColors()
        My.Settings.Save()
        My.Forms.menu_perf.reloadColors()
        My.Forms.menu_rorror.reloadColors()
        My.Forms.menu_fileconvertor.reloadColors()
        My.Forms.auth.reloadColors()
        My.Forms.main.reloadColors()
        Me.BackColor = My.Settings.AllBackColor
        autoverif.ForeColor = My.Settings.AllTextColor
    End Sub

    Private Sub options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadColors()
    End Sub
End Class