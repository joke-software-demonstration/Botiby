Public Class TaboolaManager

    Private Sub TaboolaManager_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub TaboolaManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.TaboolaSound, AudioPlayMode.BackgroundLoop)
    End Sub
End Class