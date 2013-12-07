Public Class Form2

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("C:\Users\ian2003.BOWMAN2\Documents\Visual Studio 2010\Projects\TSOEmu True Part 2\TSOEmu True Part 2\tsomusic\tsosas2_v2.wav")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Shell(Application.StartupPath & "\Game\TSOEmu True Part 4.exe")
            Close()
        Catch ex As Exception
        End Try
    End Sub
End Class
