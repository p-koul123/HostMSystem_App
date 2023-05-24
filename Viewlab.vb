Imports System.Data.OleDb
Public Class Viewlab
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")
    Private Sub Viewlab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select * from  Lab", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read
                ComboBox1.Items.Add(dr("PatientID"))
            End While

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim da As New OleDbDataAdapter("select LABNo as LABNO ,Test as TEST , PatientID as PATIENTID , SName as NAME , Age as AGE , MobileNumber as MOBILENUMBER , DrName as DRNAME from Lab where PatientID like '" & ComboBox1.Text & "%'", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim ds As New DataSet

        da.Fill(ds, "Lab")
        DataGridView1.DataSource = ds.Tables("Lab")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.close
    End Sub
End Class