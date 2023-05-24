Imports System.Data.OleDb
Public Class Form3
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("Insert into patient(PatientID,SName,Age,Parentage,Address,Mobilenumber,Emergencynumber,DrName,Balance) values(@PatientID,@SName,@Age,@Parentage,@Address,Mobilenumber,Emergencynumber,DrName,Balance)", cn)
        cmd.Parameters.AddWithValue("@PatientID", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@SName", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Age", TextBox2.Text)
        cmd.Parameters.AddWithValue("@Parentage", TextBox3.Text)
        cmd.Parameters.AddWithValue("@Address", TextBox4.Text)
        cmd.Parameters.AddWithValue("@MobileNumber", TextBox5.Text)
        cmd.Parameters.AddWithValue("@Emergencynumber", TextBox6.Text)
        cmd.Parameters.AddWithValue("@DrName", TextBox7.Text)
        cmd.Parameters.AddWithValue("@Balance", TextBox8.Text)

        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Saved")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class