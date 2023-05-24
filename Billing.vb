Imports System.Data.OleDb
Public Class Billing
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")
  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select * from patient where PatientId='" & ComboBox1.Text & "'", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read

             TextBox1.Text = dr("SName")
                TextBox2.Text = dr("Age")
                TextBox3.Text = dr("Parentage")
                TextBox4.Text = dr("Address")
                TextBox5.Text = dr("MobileNumber")
                TextBox6.Text = dr("EmergencyNumber")
                TextBox7.Text = dr("Balance")
                'TextBox9.Text = dr("Total")
            End While

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox9.Text = Val(TextBox7.Text) + Val(TextBox8.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("Insert into Billing(PatientID,SName,Age,Parentage,Address,MobileNumber,EmergencyNumber,Balance,Total) values(@PatientID,@SName,@Age,@Parentage,@Address,@MobileNumber,@EmergencyNumber,@Balance,@Total)", cn)


        cmd.Parameters.AddWithValue("@PatientID", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@SName", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Age", TextBox2.Text)
        cmd.Parameters.AddWithValue("@Parentage", TextBox3.Text)
        cmd.Parameters.AddWithValue("@Address", TextBox4.Text)
        cmd.Parameters.AddWithValue("@Mobilenumber", TextBox5.Text)
        cmd.Parameters.AddWithValue("@Emergencynumber", TextBox6.Text)
        cmd.Parameters.AddWithValue("@Balance", TextBox7.Text)
        cmd.Parameters.AddWithValue("@Total", TextBox9.Text)

        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Saved")
        cn.Close()
    End Sub

    Private Sub Billing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select * from patient ", cn)
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
End Class