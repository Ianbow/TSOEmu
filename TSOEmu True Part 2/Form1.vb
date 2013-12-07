Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = ("username") And TextBox2.Text = ("password") Then
                Timer1.Start()
            Else : MessageBox.Show("The member name or password you have entered is incorrect. Please try again.", "Login Error", MessageBoxButtons.OK)
            End If

        Catch ex As Exception
        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Start()
        ProgressBar2.Hide()
        My.Computer.Audio.Play("music\LOOP.wav")
        PictureBox12.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        PictureBox5.Hide()
        PictureBox6.Hide()
        PictureBox13.Hide()
        PictureBox7.Hide()
        PictureBox8.Hide()
        PictureBox9.Hide()
        PictureBox10.Hide()
        Label1.Hide()
        PictureBox11.Hide()
        TextBox3.Hide()
        While PictureBox3.Visible = True
            Shell(Application.StartupPath & "\music\IanAudio.exe")
        End While
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        PictureBox1.Image = My.Resources.load2
        TextBox1.Hide()
        TextBox2.Hide()
        Button1.Hide()
        Button2.Hide()
        If ProgressBar1.Value = 100 Then
            PictureBox3.Show()
            PictureBox4.Show()
            PictureBox5.Show()
            PictureBox6.Show()
            PictureBox10.Show()
            Label1.Show()
            Timer3.Start()
            Form3.Show()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(1)
        If ProgressBar2.Value = 100 Then
            PictureBox2.Hide()
            ProgressBar2.Hide()
            My.Computer.Audio.Stop()
        End If
        If ProgressBar2.Value = 20 Then
            PictureBox2.Image = My.Resources.maxis
        End If
        If ProgressBar2.Value = 40 Then
            PictureBox2.Image = My.Resources.Untitled2
        End If
        If ProgressBar2.Value = 50 Then
            PictureBox2.Image = My.Resources.Untitled3
        End If
        If ProgressBar2.Value = 60 Then
            PictureBox2.Image = My.Resources.Untitled4
        End If
        If ProgressBar2.Value = 70 Then
            PictureBox2.Image = My.Resources.Untitled5
        End If
        If ProgressBar2.Value = 80 Then
            PictureBox2.Image = My.Resources.Untitled6
        End If
        If ProgressBar2.Value = 90 Then
            PictureBox2.Image = My.Resources.Untitled7
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Form2.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Shell(Application.StartupPath & "\View a Sim\SAS Test.exe")
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If MessageBox.Show("Are you going to exit?", "Exit TSOEmu True", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        PictureBox8.Show()
        PictureBox10.Image = My.Resources.c_b2
        Label1.Hide()
        PictureBox10.Hide()
        PictureBox9.Show()
        PictureBox6.Show()
    End Sub

    Private Sub PictureBox9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        PictureBox8.Hide()
        PictureBox10.Image = My.Resources.Credits_Button
        Label1.Show()
        PictureBox10.Show()
        PictureBox9.Hide()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label1.Text = TimeOfDay
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        PictureBox11.Image = My.Resources.CAS_Screen_female
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        PictureBox11.Image = My.Resources.CAS_Screen
    End Sub
End Class
