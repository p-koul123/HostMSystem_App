Imports System.Data.OleDb
Public Class appointment
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("Insert into Appoint(PatientName,Mobilenumber,EmailID,Symptoms,sDate,Department,Gender,sTime) values(@PatientName,@Mobilenumber,@EmailID,@Symptoms,@sDate,@Department,@Gender,@sTime)", cn)


        cmd.Parameters.AddWithValue("@PatientName", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Mobilenumber", TextBox2.Text)
        cmd.Parameters.AddWithValue("@EmailID", TextBox3.Text)
        cmd.Parameters.AddWithValue("@Symptoms", TextBox4.Text)
        cmd.Parameters.AddWithValue("@sDate", DateTimePicker1.Value)
        cmd.Parameters.AddWithValue("@Department", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@Gender", ComboBox2.Text)
        cmd.Parameters.AddWithValue("@sTime", TextBox8.Text)

        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Saved")
    End Sub
End Class