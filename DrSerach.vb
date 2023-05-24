Imports System.Data.OleDb
Public Class DrSerach
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New OleDbCommand("select * from Doctor where DoctorID=  '" & ComboBox1.Text & "'", cn)

        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read

                TextBox1.Text = dr("DrName")
                TextBox2.Text = dr("Qualification")
                TextBox3.Text = dr("Speciality")
                TextBox4.Text = dr("Post")
                TextBox5.Text = dr("Department")
                TextBox6.Text = dr("Age")
                TextBox7.Text = dr("Address")
                TextBox8.Text = dr("Mobilenumber")
            End While

        Else
            MsgBox("Data not found")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cmd As New OleDbCommand("update Doctor set DrName='" & TextBox1.Text & "', Qualification= '" & TextBox2.Text & "', Speciality ='" & TextBox3.Text & "', Post='" & TextBox4.Text & "', Department= '" & TextBox5.Text & "', Age= '" & TextBox6.Text & "', Address= '" & TextBox7.Text & "',Mobilenumber='" & TextBox8.Text & "' where DoctorID ='" & ComboBox1.Text & "'", cn)

        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        MsgBox("Updated")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cmd As New OleDbCommand(" delete  from Doctor where DoctorID= '" & ComboBox1.Text & "'", cn)

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DrSerach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("select * from Doctor ", cn)
        If cn.State = 1 Then cn.Close()
        cn.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read
                ComboBox1.Items.Add(dr("DoctorID"))
            End While

        End If
    End Sub
End Class