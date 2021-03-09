Public Class BSOD
    Dim Anger As Integer = 1
    Private PISSTOPH As Boolean = False
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://quality-entertainment.github.io/qa-website/botiby")
        Form1.Close()
    End Sub

    Private Sub BSOD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If PISSTOPH = False Then
            e.Cancel = True
            Anger = Anger + 1
            Label1.Text = ">:("
            Me.BackColor = Color.Red
            Label1.Font = New Font("Segoe UI", 144 + Anger)
            Label2.Font = New Font("Segoe UI", 36 + Anger)
            Label3.Font = New Font("Segoe UI", 36 + Anger)
            Label4.Font = New Font("Segoe UI", 36 + Anger)
            LinkLabel1.Font = New Font("Segoe UI", 36 + Anger)
            Label5.Font = New Font("Segoe UI", 36 + Anger)
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub BSOD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Anger < 25 Then
            My.Computer.Audio.Play(My.Resources.No, AudioPlayMode.Background)
        ElseIf Anger = 25 Or Anger > 25 And Anger < 50 Then
            My.Computer.Audio.Play(My.Resources.No2, AudioPlayMode.Background)
        ElseIf Anger = 50 Then
            PISSTOPH = True
            Timer1.Enabled = False
            My.Computer.Audio.Play(My.Resources.No3, AudioPlayMode.Background)
            Me.BackColor = Color.Black
            Label1.Font = New Font("Segoe UI", 144)
            Label2.Font = New Font("Segoe UI", 36)
            Label3.Font = New Font("Segoe UI", 36)
            Label4.Font = New Font("Segoe UI", 36)
            LinkLabel1.Font = New Font("Segoe UI", 36)
            Label5.Font = New Font("Segoe UI", 36)
            Threading.Thread.Sleep(857)
            Label2.Text = "NO"
            Application.DoEvents()
            Threading.Thread.Sleep(659)
            Label2.Text = "NO!"
            Application.DoEvents()
            Threading.Thread.Sleep(507)
            Label2.Text = "NO!!"
            Application.DoEvents()
            Threading.Thread.Sleep(492)
            Label2.Text = "NO!!!"
            Application.DoEvents()
            Threading.Thread.Sleep(492)
            Label2.Text = "A THOUSAND F%!@IN TIMES"
            Application.DoEvents()
            Threading.Thread.Sleep(1751)
            Label2.Text = "NOOOOOOOO"
            Application.DoEvents()
            Threading.Thread.Sleep(931)
            Label2.Text = "I'M SICK AND TIRED OF THIS"
            Application.DoEvents()
            Threading.Thread.Sleep(1565)
            Label2.Text = "S!#^T!"
            Application.DoEvents()
            Threading.Thread.Sleep(875)
            Label2.Text = "GET SOMEBODY ELSE TO"
            Application.DoEvents()
            Threading.Thread.Sleep(1454)
            Label2.Text = "F@&*IN DO IT!!!"
            Application.DoEvents()
            Threading.Thread.Sleep(1370)
            Label1.Hide()
            Label2.Hide()
            Label3.Hide()
            Label4.Hide()
            Label5.Hide()
            PictureBox1.Hide()
            LinkLabel1.Hide()
            Label6.Show()
            Application.DoEvents()
            Threading.Thread.Sleep(1238)
            PictureBox2.Show()
            Label6.Hide()
            Application.DoEvents()
            Threading.Thread.Sleep(1574)
            PictureBox2.Hide()
            Me.BackColor = Color.Green
            Application.DoEvents()
            Threading.Thread.Sleep(722)
            PictureBox2.Image = My.Resources.PresentForYou
            PictureBox2.Show()
            Application.DoEvents()
        End If
        Timer1.Enabled = False
    End Sub
End Class