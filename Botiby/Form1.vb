Public Class Form1
    Dim refreshperiod As Integer
    Shared random As New Random()
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private PlayingMusic As Boolean = False
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        refreshperiod = random.Next(100, 5000)
        Me.Cursor = Cursors.WaitCursor
        PictureBox1.Hide()
        LinkLabel1.Hide()
        Label2.Hide()
        Label1.Hide()
        Threading.Thread.Sleep(refreshperiod)
        Me.Cursor = Cursors.Default
        PictureBox1.Show()
        Label1.Show()
        Label2.Show()
        LinkLabel1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        If random.Next(3, 3) = 3 Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            BSOD.ShowDialog()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CloseButton.MouseDown
        CloseButton.Image = My.Resources.ClosePress
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseButton.MouseEnter
        CloseButton.Image = My.Resources.CloseHover
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseButton.MouseLeave
        CloseButton.Image = My.Resources.CloseNormal
    End Sub

    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CloseButton.MouseUp
        CloseButton.Image = My.Resources.CloseHover
        Me.Close()
    End Sub

    Private Sub MinimizeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub Panel2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub


    Private Sub PlayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayButton.Click
        Timer1.Enabled = True
        If PlayingMusic = False Then
            PlayButton.Image = My.Resources.PauseButton
            PlayingMusic = True
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        Else
            PlayButton.Image = My.Resources.PlayButton
            PlayingMusic = False
            AxWindowsMediaPlayer1.Ctlcontrols.pause()

        End If
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = TrackBar1.Value
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TrackBar1.Value = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
    End Sub

    Private Sub AxWindowsMediaPlayer1_MediaChange(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_MediaChangeEvent) Handles AxWindowsMediaPlayer1.MediaChange
        PlayingMusic = False
        PlayButton.Image = My.Resources.PlayButton
    End Sub

    Private Sub MaximiseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaximiseButton.Click
        TaboolaManager.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If random.Next(1, 2) = 2 Then
            TaboolaManager.ShowDialog()
        End If
    End Sub
End Class
