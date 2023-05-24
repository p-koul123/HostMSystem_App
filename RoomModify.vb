Imports System.Data.OleDb
Public Class RoomModify
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub RoomModify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select * from Room ", cn)
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

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New OleDbCommand("select * from Room where PatientID=  '" & ComboBox1.Text & "'", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read

                TextBox1.Text = dr("sName")
                TextBox2.Text = dr("Age")
                ComboBox2.Text = dr("WardType")
                TextBox4.Text = dr("BedNo")
                TextBox5.Text = dr("Diagnosis")
                TextBox7.Text = dr("DrName")
            End While

        Else
            MsgBox("Data not found")
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cmd As New OleDbCommand("Update Room set sName='" & TextBox1.Text & "', Age= '" & TextBox2.Text & "', WardType= '" & ComboBox2.Text & "', BedNo='" & TextBox4.Text & "', Diagnosis= '" & TextBox5.Text & "', DrName= '" & TextBox7.Text & "', where PatientID ='" & ComboBox1.Text & "'", cn)

        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        MsgBox("Updated")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cmd As New OleDbCommand(" delete  from Room where PatientID= '" & ComboBox1.Text & "'", cn)

        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader

        dr = cmd.ExecuteReader
        MsgBox("Deleted", MsgBoxStyle.OkOnly)

        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class