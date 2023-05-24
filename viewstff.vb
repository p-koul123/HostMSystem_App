Imports System.Data.OleDb
Public Class viewstff
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")
    Private Sub viewstff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select * from staff ", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read
                ComboBox1.Items.Add(dr("StaffID"))
            End While

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim da As New OleDbDataAdapter("select sname as NAME, dateofbirth as DATEOFBIRTH , Gender as GENDER,Telephone as TELEPHONE ,ResidenceAddress as RESIDENCEADDRESS , MobileNumber as MOBILENUMBER ,E_mailID as EMAILID from staff  where StaffID like '" & ComboBox1.Text & "%'", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim ds As New DataSet

        da.Fill(ds, "staff")
        DataGridView1.DataSource = ds.Tables("staff")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Slide.Show()
    End Sub
End Class