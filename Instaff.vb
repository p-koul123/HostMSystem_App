Imports System.Data.OleDb
Public Class Form1
    Dim cn As New OleDbConnection("provider= microsoft.jet.oledb.4.0;data source=hosipital.mdb")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cn.State = 1 Then cn.Close()
        Dim cmd As New OleDbCommand("Insert into staff (StaffID,Sname,ResidenceAddress,DateofBirth,E_mailID,Gender,Telephone,TemporyAddress,Mobilenumber,path,pic)values(@StaffID,@Sname,@ResidenceAddress,@DateofBirth,@E_mailID,@Gender,@Telephone,@TemporyAddress,@Mobilenumber,@path,@pic)", cn)


        cmd.Parameters.AddWithValue("@StaffID", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Sname", TextBox2.Text)
        cmd.Parameters.AddWithValue("@ResidenceAddress", TextBox3.Text)
        cmd.Parameters.AddWithValue("@Dateofbirth", DateTimePicker1.Value)
        cmd.Parameters.AddWithValue("@E_mailID", TextBox5.Text)
        cmd.Parameters.AddWithValue("@Gender", TextBox6.Text)
        cmd.Parameters.AddWithValue("@Telephone", TextBox7.Text)
        cmd.Parameters.AddWithValue("@TemporyAddress", TextBox8.Text)
        cmd.Parameters.AddWithValue("@MobileNumber", TextBox9.Text)
        cmd.Parameters.AddWithValue("@path", TextBox4.Text)
        cmd.Parameters.AddWithValue("@pic", TextBox10.Text)
        cn.Open()
        cmd.ExecuteNonQuery()


        MsgBox("Saved")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox4.Text = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(TextBox4.Text)
            Dim s As String
            s = TextBox4.Text.Substring(TextBox4.Text.LastIndexOf("\") + 1)
            PictureBox1.Image.Save(Application.StartupPath() & "\pictures\" & s)
            TextBox10.Text = "\pictures\" & s
        End If
    End Sub
End Class
