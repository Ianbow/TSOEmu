Public Class Form2

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
        Form1.PictureBox13.Show()
        Form1.PictureBox12.Show()
        Form1.PictureBox11.Show()
        My.Computer.Audio.Play("C:\Users\ian2003.BOWMAN2\Documents\Visual Studio 2010\Projects\TSOEmu True Client\TSOEmu True Part 2\tsomusic\tsocas1_v2.wav")
        Form1.TextBox3.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class