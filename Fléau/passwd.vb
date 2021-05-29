Imports System.ComponentModel

Public Class passwd
    Private Sub infosbtn_Click(sender As Object, e As EventArgs) Handles infosbtn.Click
        My.Forms.infos.Show()
    End Sub

    Private Sub passwd_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Forms.main.Dispose()
        My.Forms.main.Close()
        Me.Dispose()
        Me.Close()
    End Sub
End Class