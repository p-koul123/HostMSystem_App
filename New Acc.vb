Imports System.Data.OleDb
Public Class New_Acc
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("Insert into NewAcc(Username,EmailID,sPassword,Confirmpassword) values(@Username,@EmailID,@sPassword,@confirmpassword)", cn)


        cmd.Parameters.AddWithValue("@Username", TextBox1.Text)
        cmd.Parameters.AddWithValue("@EmailID", TextBox2.Text)
        cmd.Parameters.AddWithValue("@sPassword", TextBox3.Text)
        cmd.Parameters.AddWithValue("@Confirmpassword", TextBox4.Text)

        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Saved")

    End Sub
End Class