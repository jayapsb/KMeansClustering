Imports System.Data.OleDb
Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim cmd As New OleDbCommand("SELECT * FROM TbDataUser WHERE UserName='" & txtusername.Text & "' AND Password='" & txtpassword.Text & "'", database)
        Dim da As OleDbDataReader = cmd.ExecuteReader
        da.Read()
        If da.HasRows Then
            FormAntarMuka.Show()
        Else
            MessageBox.Show("User Tidak Ditemukan", "Coba Lagi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class