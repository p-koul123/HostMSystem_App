Public Class Startpage
     Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Login.Show()
            Timer1.Enabled = False
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class