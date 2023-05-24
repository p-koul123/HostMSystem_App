Imports System.Data.OleDb
Public Class Doctorin
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("Insert into Doctor(DoctorID,DrName,Qualification,Speciality,Post,Department,Age,Address,Mobilenumber,path,pic) values(@DoctorID,@DrName,@Qualification,@Speciality,@Post,@Department,@Age,@Address,@Mobilenumber,@path,@pic)", cn)


        cmd.Parameters.AddWithValue("@DoctorID", TextBox1.Text)
        cmd.Parameters.AddWithValue("@DrName", TextBox2.Text)
        cmd.Parameters.AddWithValue("@Qualification", TextBox3.Text)
        cmd.Parameters.AddWithValue("@Speciality", TextBox4.Text)
        cmd.Parameters.AddWithValue("@Post", TextBox5.Text)
        cmd.Parameters.AddWithValue("@Department", TextBox6.Text)
        cmd.Parameters.AddWithValue("@Age", TextBox6.Text)
        cmd.Parameters.AddWithValue("@Address", TextBox7.Text)
        cmd.Parameters.AddWithValue("@Mobilenumber", TextBox8.Text)
        cmd.Parameters.AddWithValue("@path", TextBox10.Text)
        cmd.Parameters.AddWithValue("@pic", TextBox11.Text)

        cn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Saved")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox10.Text = OpenFileDialog1.FileName
            PictureBox2.Image = Image.FromFile(TextBox10.Text)
            Dim s As String
            s = TextBox10.Text.Substring(TextBox10.Text.LastIndexOf("\") + 1)
            PictureBox2.Image.Save(Application.StartupPath() & "\pictures\" & s)
            TextBox11.Text = "\pictures\" & s
        End If
    End Sub
End Class