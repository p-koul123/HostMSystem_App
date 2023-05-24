Imports System.Data.OleDb
Public Class Login
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New OleDbCommand("select * from NewAcc where username=  '" & TextBox1.Text & "' and spassword=  '" & TextBox2.Text & "'", cn)

        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            If RadioButton1.Checked = True Then
                Me.Close()

                Slide.Show()
                MsgBox("Welcome")

            End If
            If RadioButton2.Checked = True Then
                Me.Close()
                Slide.Show()
                Slide.DoctorToolStripMenuItem.Enabled = False
                MsgBox("Welcome")
            End If
        Else
            MsgBox("Data not found")
        End If
        'Me.Hide()

    End Sub
End Class