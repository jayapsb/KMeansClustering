Imports System.Math
Public Class FormHitungMix
    Dim tabel As OleDb.OleDbDataAdapter
    Dim data As DataSet
    Dim record As New BindingSource
    Sub DataMix()
        Call koneksi()
        tabel = New Data.OleDb.OleDbDataAdapter("SELECT * FROM TbDataMix WHERE Periode LIKE '" & DateTimePicker1.Text & "'", database)
        data = New DataSet
        tabel.Fill(data)
        record.DataSource = data
        record.DataMember = data.Tables(0).ToString()
        DataGridView1.DataSource = record
        cbkode.Text = ""
        txtnamamenu.Text = ""
        txtqty.Text = ""
        txtnilai.Text = ""
        txtmenumix.Text = ""
        txtsalesmix.Text = ""
    End Sub
    Sub combobox()
        Dim oke As OleDb.OleDbCommand
        Dim cb As OleDb.OleDbDataReader
        oke = New OleDb.OleDbCommand("SELECT Kode FROM TbDataMenu", database)
        cb = oke.ExecuteReader()
        While cb.Read()
            cbkode.Items.Add(cb("Kode"))
        End While
    End Sub

    Private Sub FormHitungMix_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DataMix()
        Call combobox()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMM yyyy"
        DateTimePicker1.Value = Format(Now)
        Dim oke As OleDb.OleDbCommand
        Dim baca As OleDb.OleDbDataReader
        Dim periode As Date
        periode = Format(DateTimePicker1.Value.Date, "MMM yyyy")
        oke = New OleDb.OleDbCommand("SELECT * FROM TbDataTotal WHERE Periode LIKE '" & periode & "'", database)
        baca = oke.ExecuteReader()
        If baca.Read() Then
            txttotalqty.Text = baca("TotalQty")
            txttotalnilai.Text = baca("TotalNilai")
        End If
    End Sub

    Private Sub cbkode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkode.SelectedIndexChanged
        Call koneksi()
        Dim oke As OleDb.OleDbCommand
        Dim baca As OleDb.OleDbDataReader
        Dim periode2 As Date
        periode2 = Format(DateTimePicker1.Value.Date, "MMM yyyy")
        oke = New OleDb.OleDbCommand("SELECT * FROM TbDataPenjualan WHERE Periode LIKE '" & periode2 & "' AND Kode LIKE '" & cbkode.Text & "'", database)
        baca = oke.ExecuteReader()
        If baca.Read() Then
            txtnamamenu.Text = baca("NamaMenu")
            txtqty.Text = baca("Qty")
            txtnilai.Text = baca("Nilai")
        Else
            MessageBox.Show("Data Tidak Ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbkode.Text = ""
            txtnamamenu.Text = ""
            txtqty.Text = ""
            txtnilai.Text = ""
        End If
    End Sub

    Private Sub btnhitungmix_Click(sender As Object, e As EventArgs) Handles btnhitungmix.Click
        Dim qty, nilai, totalqty, totalnilai As Integer
        Dim menumix, salesmix As Double
        qty = txtqty.Text
        nilai = txtnilai.Text
        totalqty = txttotalqty.Text
        totalnilai = txttotalnilai.Text
        menumix = Round(Val(qty / totalqty) * 100, 2)
        salesmix = Round(Val(nilai / totalnilai) * 100, 2)
        txtmenumix.Text = menumix
        txtsalesmix.Text = salesmix
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim oke As OleDb.OleDbCommand
        Dim baca As OleDb.OleDbDataReader
        Dim periode As Date
        periode = Format(DateTimePicker1.Value.Date, "MMM yyyy")
        oke = New OleDb.OleDbCommand("SELECT * FROM TbDataTotal WHERE Periode LIKE '" & periode & "'", database)
        baca = oke.ExecuteReader()
        If baca.Read() Then
            txttotalqty.Text = baca("TotalQty")
            txttotalnilai.Text = baca("TotalNilai")
        Else
            txttotalqty.Text = ""
            txttotalnilai.Text = ""
        End If
        tabel = New Data.OleDb.OleDbDataAdapter("SELECT * FROM TbDataMix WHERE Periode LIKE '%" & periode & "%'", database)
        data = New DataSet
        tabel.Fill(data)
        record.DataSource = data
        record.DataMember = data.Tables(0).ToString()
        DataGridView1.DataSource = record
    End Sub
    Sub tampil()
        Dim oke As OleDb.OleDbCommand
        Dim baca As OleDb.OleDbDataReader
        Dim periode As Date
        periode = Format(DateTimePicker1.Value.Date, "MMM yyyy")
        oke = New OleDb.OleDbCommand("SELECT * FROM TbDataTotal WHERE Periode LIKE '" & periode & "'", database)
        baca = oke.ExecuteReader()
        If baca.Read() Then
            txttotalqty.Text = baca("TotalQty")
            txttotalnilai.Text = baca("TotalNilai")
        Else
            txttotalqty.Text = ""
            txttotalnilai.Text = ""
        End If
        tabel = New Data.OleDb.OleDbDataAdapter("SELECT * FROM TbDataMix WHERE Periode LIKE '%" & periode & "%'", database)
        data = New DataSet
        tabel.Fill(data)
        record.DataSource = data
        record.DataMember = data.Tables(0).ToString()
        DataGridView1.DataSource = record
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If (cbkode.Text = "") Then
            MessageBox.Show("Pilih Kode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim oke As New OleDb.OleDbCommand
            Dim oke2 As New OleDb.OleDbCommand
            Dim baca As OleDb.OleDbDataReader
            Dim periode As Date
            periode = Format(DateTimePicker1.Value.Date, "MMM yyyy")
            oke = New OleDb.OleDbCommand("SELECT * FROM TbDataMix WHERE Periode LIKE '" & periode & "' AND Kode LIKE '" & cbkode.Text & "'", database)
            baca = oke.ExecuteReader()
            If baca.Read() Then
                MessageBox.Show("Data Sudah Ada", "Input Data Lain", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                oke2.Connection = database
                oke2.CommandType = CommandType.Text
                oke2.CommandText = "INSERT INTO TbDataMix VALUES ('" & periode & "','" & cbkode.Text & "','" & txtnamamenu.Text & "','" & txtmenumix.Text & "','" & txtsalesmix.Text & "')"
                oke2.ExecuteNonQuery()
                MessageBox.Show("Data Disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call tampil()
            End If
        End If
    End Sub
End Class