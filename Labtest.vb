Imports System.Data.OleDb
Public Class Labtest
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")

    Private Sub Labtest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select * from patient ", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read
                ComboBox3.Items.Add(dr("patientid"))
            End While

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("Insert into Lab(LABNo,Test,PatientID,sName,Age,Parentage,MobileNumber,EmergencyNumber,DrName) values(@LABNo,@Test,@PatientID,@sName,@Age,@Parentage,@MobileNumber,@EmergencyNumber,@DrName)", cn)


        cmd.Parameters.AddWithValue("@LABNo", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@Test", ComboBox2.Text)
        cmd.Parameters.AddWithValue("@PatientID", ComboBox3.Text)
        cmd.Parameters.AddWithValue("@sName", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Age", TextBox2.Text)
        cmd.Parameters.AddWithValue("@Parentage", TextBox3.Text)
        cmd.Parameters.AddWithValue("@Mobilenumber", TextBox4.Text)
        cmd.Parameters.AddWithValue("@Emergencynumber", TextBox5.Text)
        cmd.Parameters.AddWithValue("@DrName", TextBox6.Text)

        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Saved")
        cn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cmd As New OleDbCommand("select * from Patient where PatientID=  '" & ComboBox3.Text & "'", cn)

        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read

                TextBox1.Text = dr("SName")
                TextBox2.Text = dr("Age")
                TextBox3.Text = dr("Parentage")
                TextBox4.Text = dr("Mobilenumber")
                TextBox5.Text = dr("Emergencynumber")
                TextBox6.Text = dr("DrName")

            End While

        Else
            MsgBox("Data not found")
        End If
    End Sub
End Class