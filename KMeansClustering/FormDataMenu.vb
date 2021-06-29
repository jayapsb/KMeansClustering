Public Class FormDataMenu
    Dim tabel As OleDb.OleDbDataAdapter
    Sub buka()
        txtkodeinput.Enabled = False
        txtnamamenuinput.Enabled = False
        txthargainput.Enabled = False
        btnsimpan.Enabled = False
        cbkodeedit.Enabled = False
        txtnamamenuedit.Enabled = False
        txthargaedit.Enabled = False
        btnubah.Enabled = False
        btnhapus.Enabled = False
        Call DataMenu()
        Call combobox()
    End Sub
    Sub DataMenu()
        Call koneksi()
        tabel = New Data.OleDb.OleDbDataAdapter("SELECT * FROM TbDataMenu", database)
    End Sub
    Sub combobox()
        Dim oke As OleDb.OleDbCommand
        Dim cb As OleDb.OleDbDataReader
        oke = New OleDb.OleDbCommand("SELECT Kode FROM TbDataMenu", database)
        cb = oke.ExecuteReader()
        While cb.Read()
            cbkodeedit.Items.Add(cb("Kode"))
        End While
    End Sub
    Private Sub FormDataMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buka()
    End Sub
    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        txtkodeinput.Enabled = True
        txtnamamenuinput.Enabled = True
        txthargainput.Enabled = True
        btnsimpan.Enabled = True
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        cbkodeedit.Enabled = True
        txtnamamenuedit.Enabled = True
        txthargaedit.Enabled = True
        btnubah.Enabled = True
        btnhapus.Enabled = True
    End Sub
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Dim oke As New OleDb.OleDbCommand
        Dim oke2 As New OleDb.OleDbCommand
        Dim baca As OleDb.OleDbDataReader
        oke = New OleDb.OleDbCommand("SELECT * FROM TbDataMenu WHERE Kode LIKE '" & txtkodeinput.Text & "'", database)
        baca = oke.ExecuteReader()
        If baca.Read() Then
            MessageBox.Show("Data Sudah Ada", "Input Data Lain", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtkodeinput.Text = ""
            txtnamamenuinput.Text = ""
            txthargainput.Text = ""
        Else
            oke2.Connection = database
            oke2.CommandType = CommandType.Text
            oke2.CommandText = "INSERT INTO TbDataMenu VALUES('" & txtkodeinput.Text & "','" & txtnamamenuinput.Text & "','" & txthargainput.Text & "')"
            oke2.ExecuteNonQuery()
            MessageBox.Show("Data Disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtkodeinput.Text = ""
            txtnamamenuinput.Text = ""
            txthargainput.Text = ""
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        Dim oke As New OleDb.OleDbCommand
        oke.Connection = database
        oke.CommandType = CommandType.Text
        oke.CommandText = "UPDATE TbDataMenu SET Kode = '" & cbkodeedit.Text & "',NamaMenu = '" & txtnamamenuedit.Text & "',Harga = '" & txthargaedit.Text & "' WHERE Kode ='" & cbkodeedit.Text & "'"
        oke.ExecuteNonQuery()
        MessageBox.Show("Data Diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cbkodeedit.Text = ""
        txtnamamenuedit.Text = ""
        txthargaedit.Text = ""
    End Sub

    Private Sub cbkodeedit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkodeedit.SelectedIndexChanged
        Dim oke As New OleDb.OleDbCommand
        Dim baca As OleDb.OleDbDataReader
        oke = New OleDb.OleDbCommand("SELECT * FROM TbDataMenu WHERE Kode LIKE '" & cbkodeedit.Text & "'", database)
        baca = oke.ExecuteReader()
        If baca.Read() Then
            txtnamamenuedit.Text = baca("NamaMenu")
            txthargaedit.Text = baca("Harga")
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim oke As New OleDb.OleDbCommand
        oke.Connection = database
        oke.CommandType = CommandType.Text
        oke.CommandText = "DELETE FROM TbDataMenu WHERE Kode = '" & cbkodeedit.Text & "'"
        oke.ExecuteNonQuery()
        MessageBox.Show("Data Dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cbkodeedit.Text = ""
        txtnamamenuedit.Text = ""
        txthargaedit.Text = ""
    End Sub
End Class