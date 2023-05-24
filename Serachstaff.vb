Imports System.Data.OleDb
Public Class Serachstaff
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")

    Private Sub Serachstaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select * from Staff ", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read
                ComboBox1.Items.Add(dr("Staffid"))
            End While

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New OleDbCommand("select * from staff where StaffID=  '" & ComboBox1.Text & "'", cn)

        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read

                TextBox1.Text = dr("Sname")
                TextBox2.Text = dr("ResidenceAddress")
                DateTimePicker1.Value = dr("Dateofbirth")
                TextBox4.Text = dr("E_mailID")
                TextBox5.Text = dr("Gender")
                TextBox6.Text = dr("Telephone")
                TextBox7.Text = dr("TemporyAddress")
                TextBox8.Text = dr("Mobilenumber")
            End While

        Else
            MsgBox("Data not found")
        End If
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cmd As New OleDbCommand("update staff set Sname='" & TextBox1.Text & "', ResidenceAddress= '" & TextBox2.Text & "', DateofBirth ='" & DateTimePicker1.Value & "', E_mailID='" & TextBox4.Text & "', Gender= '" & TextBox5.Text & "', Telephone= '" & TextBox6.Text & "', TemporyAddress= '" & TextBox7.Text & "',Mobilenumber='" & TextBox8.Text & "' where StaffID ='" & ComboBox1.Text & "'", cn)

        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        MsgBox("Updated")
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cmd As New OleDbCommand(" delete  from staff where StaffID= '" & ComboBox1.Text & "'", cn)

        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader

        dr = cmd.ExecuteReader
        MsgBox("Deleted", MsgBoxStyle.OkOnly)

        TextBox1.Text = ""
        TextBox2.Text = ""
        DateTimePicker1.Value = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class