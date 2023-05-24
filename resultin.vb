Imports System.Data.OleDb
Public Class resultin
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")
    Private Sub resultin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select * from patient ", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read
                ComboBox3.Items.Add(dr("PatientID"))
            End While

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("Insert into ResultLab(LabNo,PatientID,sName,Test,Result) values(@LabNo,@PatientID,@sName,@Test,@Result)", cn)


        cmd.Parameters.AddWithValue("@LabNo", ComboBox4.Text)
        cmd.Parameters.AddWithValue("@PatientID", ComboBox3.Text)
        cmd.Parameters.AddWithValue("@sName", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Test", ComboBox2.Text)
        cmd.Parameters.AddWithValue("@Result", TextBox2.Text)

        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Saved")
    End Sub
End Class