Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.AppStat = " Full Version " Then
            Me.Text = My.Settings.AppStat
        Else


            If My.Settings.LoadCount < 0 Then
                Form2.ShowDialog()
            Else
                Me.Text = My.Settings.AppStat & " :: Count > " &
                    My.Settings.LoadCount
                My.Settings.LoadCount -= 1
                My.Settings.Save()

            End If
        End If
    End Sub
End Class
