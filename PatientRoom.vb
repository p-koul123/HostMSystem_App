Imports System.Data.OleDb
Public Class PatientRoom
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")
   Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub PatientRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select * from Patient ", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read
                ComboBox1.Items.Add(dr("patientid"))
            End While

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("Insert into Room(PatientID,sName,Age,WardType,BedNo,Diagnosis,Mobilenumber,DrName) values(@PatientID,@sName,@Age,@WardType,@BedNo,@Diagnosis,@Mobilenumber,@DrName)", cn)

        cmd.Parameters.AddWithValue("@PatientID", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@sName", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Age", TextBox2.Text)
        cmd.Parameters.AddWithValue("@WardType", ComboBox2.Text)
        cmd.Parameters.AddWithValue("@BedNo", TextBox4.Text)
        cmd.Parameters.AddWithValue("@Diagnosis", TextBox5.Text)
        cmd.Parameters.AddWithValue("@Mobilenumber", TextBox3.Text)
        cmd.Parameters.AddWithValue("@DrName", TextBox7.Text)

        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Saved")
        cn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Labtest.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Labresult.Show()

    End Sub
End Class