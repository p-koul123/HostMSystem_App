Imports System.Data.OleDb
Public Class Patientin
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")

    Private Sub Patientin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("Select * from patient ", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read
                ComboBox1.Items.Add(dr("PatientID"))
            End While
        Else
            MsgBox("Data not found")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New OleDbCommand("select * from patient where PatientID=  '" & ComboBox1.Text & "'", cn)
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
                TextBox6.Text = dr("Emergencynumber")
                TextBox7.Text = dr("DrName")
                TextBox8.Text = dr("Balance")
            End While

        Else
            MsgBox("Data not found")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cmd As New OleDbCommand("Update Patient set SName='" & TextBox1.Text & "', Age= '" & TextBox2.Text & "', Parentage='" & TextBox3.Text & "', Address='" & TextBox4.Text & "', Mobilenumber= '" & TextBox5.Text & "', Emergencynumber= '" & TextBox6.Text & "', DrName= '" & TextBox7.Text & "',Balance='" & TextBox8.Text & "' where PatientID ='" & ComboBox1.Text & "'", cn)

        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        MsgBox("Updated")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cmd As New OleDbCommand("Delete  from Patient where PatientID= '" & ComboBox1.Text & "'", cn)

        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader

        dr = cmd.ExecuteReader
        MsgBox("Deleted", MsgBoxStyle.OkOnly)

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub
End Class