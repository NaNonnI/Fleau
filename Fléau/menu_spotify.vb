Public Class menu_spotify

    Const KEYEVENTF_EXTENTEDKEY = 1
    Const KEYEVENTF_KEYUP = 0
    Const VK_MEDIA_NEXT_TRACK = 0xB0
    Const VK_MEDIA_PLAY_PAUSE = 0xB3
    Const VK_MEDIA_PREV_TRACK = 0xB1

    Const WM_APPCOMMAND = &H319

    Declare Auto Function SendMessageW Lib "user32.dll" Alias "SendMessageW" (
    ByVal hWnd As Integer,
    ByVal Msg As Integer,
    ByVal wParam As Integer,
    ByVal lParam As Integer) As Integer

    Public Sub reloadColors()
        Me.BackColor = My.Settings.AllBackColor
    End Sub

    Private Function menu_spotify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadColors()
    End Function

    Private Sub pause_Click(sender As Object, e As EventArgs) Handles pause.Click
        'call the SendMessage function with the current window handle, the command we want to use, same handle, and the button we want to press
        SendMessageW(Handle, WM_APPCOMMAND, Handle, VK_MEDIA_PLAY_PAUSE)
    End Sub

    Private Sub bass_Click(sender As Object, e As EventArgs) Handles bass.Click
        SendMessageW(Handle, WM_APPCOMMAND, Handle, VK_MEDIA_NEXT_TRACK)
    End Sub
End Class