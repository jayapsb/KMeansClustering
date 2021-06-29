Imports System.Data.OleDb
Public Class FormDataUser
    Dim tabel As OleDb.OleDbDataAdapter
    Sub buka()
        txtusernameinput.Enabled = False
        txtpasswordinput.Enabled = False
        txtulangipassinput.Enabled = False
        Cbusernamehapus.Enabled = False
        txtpasswordhapus.Enabled = False
        txtulangipasshapus.Enabled = False
        btnsimpan.Enabled = False
        btnhapus2.Enabled = False
        Call DataUser()
        Call combobox()
    End Sub
    Sub DataUser()
        Call koneksi()
        tabel = New Data.OleDb.OleDbDataAdapter("SELECT * FROM TbDataUser", database)
    End Sub
    Sub combobox()
        Dim oke As OleDb.OleDbCommand
        Dim cb As OleDb.OleDbDataReader
        oke = New OleDb.OleDbCommand("SELECT UserName FROM TbDataUser", database)
        cb = oke.ExecuteReader()
        While cb.Read()
            Cbusernamehapus.Items.Add(cb("UserName"))
        End While
    End Sub
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If (txtpasswordinput.Text = txtulangipassinput.Text) Then
            Dim oke As New OleDb.OleDbCommand
            Dim oke2 As New OleDb.OleDbCommand
            Dim baca As OleDb.OleDbDataReader
            oke = New OleDb.OleDbCommand("SELECT * FROM TbDataUser WHERE UserName LIKE '" & txtusernameinput.Text & "'", database)
            baca = oke.ExecuteReader()
            If baca.Read() Then
                MessageBox.Show("Data Sudah Ada", "Input Data Lain", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtusernameinput.Text = ""
                txtpasswordinput.Text = ""
                txtulangipassinput.Text = ""
            Else
                oke2.Connection = database
                oke2.CommandType = CommandType.Text
                oke2.CommandText = "INSERT INTO TbDataUser VALUES('" & txtusernameinput.Text & "','" & txtulangipassinput.Text & "')"
                oke2.ExecuteNonQuery()
                MessageBox.Show("Data Disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtusernameinput.Text = ""
                txtpasswordinput.Text = ""
                txtulangipassinput.Text = ""
                Call buka()
            End If
        Else
            MessageBox.Show("Password Tidak Sama", "Ulangi Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buka()
    End Sub
    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        txtusernameinput.Enabled = True
        txtpasswordinput.Enabled = True
        txtulangipassinput.Enabled = True
        btnsimpan.Enabled = True
    End Sub
    Private Sub btnhapus1_Click(sender As Object, e As EventArgs) Handles btnhapus1.Click
        Cbusernamehapus.Enabled = True
        txtpasswordhapus.Enabled = True
        txtulangipasshapus.Enabled = True
        btnhapus2.Enabled = True
    End Sub
    Private Sub btnhapus2_Click(sender As Object, e As EventArgs) Handles btnhapus2.Click
        If (txtpasswordhapus.Text = txtulangipasshapus.Text) Then
            Dim cmd As New OleDbCommand("SELECT * FROM TbDataUser WHERE UserName='" & Cbusernamehapus.Text & "' AND Password='" & txtulangipasshapus.Text & "'", database)
            Dim da As OleDbDataReader = cmd.ExecuteReader
            Dim oke As New OleDb.OleDbCommand
            da.Read()
            If da.HasRows Then
                oke.Connection = database
                oke.CommandType = CommandType.Text
                oke.CommandText = "DELETE FROM TbDataUser WHERE UserName = '" & Cbusernamehapus.Text & "' AND Password = '" & txtulangipasshapus.Text & "'"
                oke.ExecuteNonQuery()
                MessageBox.Show("Data Dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cbusernamehapus.Text = ""
                txtpasswordhapus.Text = ""
                txtulangipasshapus.Text = ""
            Else
                MessageBox.Show("User Tidak Ditemukan", "Coba Lagi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Password Tidak Sama", "Ulangi Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
