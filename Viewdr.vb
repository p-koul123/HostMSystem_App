Imports System.Data.OleDb
Public Class Viewdr
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")
    Private Sub Viewdr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select * from Doctor ", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read
                ComboBox1.Items.Add(dr("DrName"))
            End While

        End If

        If cn.State = 1 Then cn.Close()
        Dim cmd1 As New OleDbCommand("select * from Doctor ", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr1 As OleDbDataReader
        dr1 = cmd1.ExecuteReader
        If dr1.HasRows = True Then
            While dr1.Read
                ComboBox2.Items.Add(dr1("Department"))
            End While

        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim da As New OleDbDataAdapter("select DoctorID as DOCTORID , DrName as DRNAME, Qualification as QUALIFICATION, Speciality as SPECIALITY, MobileNumber as MOBILENUMBER, Department as DEPARTMENT, Address as ADDRESS from doctor where DrName like'" & ComboBox1.Text & "%'", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim ds As New DataSet

        da.Fill(ds, "Doctor")
        DataGridView1.DataSource = ds.Tables("Doctor")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim da As New OleDbDataAdapter("select DoctorID as DOCTORID , DrName as DRNAME, Qualification as QUALIFICATION, Speciality as SPECIALITY, MobileNumber as MOBILENUMBER, Address as ADDRESS from doctor where Department like'" & ComboBox2.Text & "%'", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim ds As New DataSet

        da.Fill(ds, "Doctor")
        DataGridView1.DataSource = ds.Tables("Doctor")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class