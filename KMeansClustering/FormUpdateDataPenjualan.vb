Public Class FormUpdateDataPenjualan
    Dim tabel As OleDb.OleDbDataAdapter
    Dim tabel2 As OleDb.OleDbDataAdapter
    Dim data As DataSet
    Dim data2 As DataSet
    Dim record As New BindingSource
    Dim record2 As New BindingSource

    Sub DataPenjualan()
        Call koneksi()
        Dim periode As Date
        Dim totalqty As Double
        Dim totalnilai As Double
        periode = Format(DateTimePicker1.Value.Date, "MMM yyyy")
        tabel = New Data.OleDb.OleDbDataAdapter("SELECT * FROM TbDataPenjualan WHERE Periode LIKE '%" & periode & "%'", database)
        data = New DataSet
        tabel.Fill(data)
        record.DataSource = data
        record.DataMember = data.Tables(0).ToString()
        DataGridView1.DataSource = record
        tabel2 = New Data.OleDb.OleDbDataAdapter("SELECT * FROM TbDataTotal WHERE Periode LIKE '%" & periode & "%'", database)
        data2 = New DataSet
        tabel2.Fill(data2)
        record2.DataSource = data2
        record2.DataMember = data2.Tables(0).ToString()
        DataGridView2.DataSource = record2
        totalqty = 0
        totalnilai = 0
        For t As Integer = 0 To DataGridView1.Rows.Count - 1
            totalqty = totalqty + Val(DataGridView1.Rows(t).Cells(3).Value)
            totalnilai = totalnilai + Val(DataGridView1.Rows(t).Cells(4).Value)
        Next
        txttotalqty.Text = totalqty
        txttotalnilai.Text = totalnilai
        txtnilai1.Text = 0
        txtnilai2.Text = 0
        txtnilai3.Text = 0
        txtnilai4.Text = 0
        txtnilai5.Text = 0
        txtnilai6.Text = 0
        txtnilai7.Text = 0
        txtnilai8.Text = 0
        txtnilai9.Text = 0
        txtnilai10.Text = 0
        txtnilai11.Text = 0
        txtnilai12.Text = 0
        txtnilai13.Text = 0
        txtnilai14.Text = 0
        txtnilai15.Text = 0
        txtnilai16.Text = 0
        txtnilai17.Text = 0
        txtnilai18.Text = 0
        txtnilai19.Text = 0
        txtnilai20.Text = 0
        txtnilai21.Text = 0
        txtnilai22.Text = 0
        txtnilai23.Text = 0
        txtnilai24.Text = 0
        txtnilai25.Text = 0
        txtnilai26.Text = 0
        txtnilai27.Text = 0
        txtnilai28.Text = 0
        txtnilai29.Text = 0
        txtnilai30.Text = 0
        txtnilai31.Text = 0
        txtqty1.Text = 0
        txtqty2.Text = 0
        txtqty3.Text = 0
        txtqty4.Text = 0
        txtqty5.Text = 0
        txtqty6.Text = 0
        txtqty7.Text = 0
        txtqty8.Text = 0
        txtqty9.Text = 0
        txtqty10.Text = 0
        txtqty11.Text = 0
        txtqty12.Text = 0
        txtqty13.Text = 0
        txtqty14.Text = 0
        txtqty15.Text = 0
        txtqty16.Text = 0
        txtqty17.Text = 0
        txtqty18.Text = 0
        txtqty19.Text = 0
        txtqty20.Text = 0
        txtqty21.Text = 0
        txtqty22.Text = 0
        txtqty23.Text = 0
        txtqty24.Text = 0
        txtqty25.Text = 0
        txtqty26.Text = 0
        txtqty27.Text = 0
        txtqty28.Text = 0
        txtqty29.Text = 0
        txtqty30.Text = 0
        txtqty31.Text = 0
        cbkode.Text = ""
        txtnamamenu.Text = ""
        txtharga.Text = ""
        txtjlhqty.Text = ""
        txtjlhnilai.Text = ""
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

    Private Sub FormUpdateDataPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DataPenjualan()
        Call combobox()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMM yyyy"
        DateTimePicker1.Value = Format(Now)
    End Sub

    Private Sub cbkode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkode.SelectedIndexChanged
        Dim oke As New OleDb.OleDbCommand
        Dim baca As OleDb.OleDbDataReader
        oke = New OleDb.OleDbCommand("SELECT * FROM TbDataMenu WHERE Kode LIKE '" & cbkode.Text & "'", database)
        baca = oke.ExecuteReader()
        If baca.Read() Then
            txtnamamenu.Text = baca("NamaMenu")
            txtharga.Text = baca("Harga")
        End If
    End Sub

    Private Sub btnhitungnilai_Click(sender As Object, e As EventArgs) Handles btnhitungnilai.Click
        If cbkode.Text = "" Then
            MessageBox.Show("Pilih Kode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim qty1, qty2, qty3, qty4, qty5, qty6, qty7, qty8, qty9, qty10, qty11, qty12, qty13, qty14, qty15, _
                qty16, qty17, qty18, qty19, qty20, qty21, qty22, qty23, qty24, qty25, qty26, qty27, qty28, qty29, _
                qty30, qty31, harga, nilai1, nilai2, nilai3, nilai4, nilai5, nilai6, nilai7, nilai8, nilai9, _
            nilai10, nilai11, nilai12, nilai13, nilai14, nilai15, nilai16, nilai17, nilai18, nilai19, nilai20, _
            nilai21, nilai22, nilai23, nilai24, nilai25, nilai26, nilai27, nilai28, nilai29, nilai30, nilai31 As Integer
            qty1 = txtqty1.Text
            qty2 = txtqty2.Text
            qty3 = txtqty3.Text
            qty4 = txtqty4.Text
            qty5 = txtqty5.Text
            qty6 = txtqty6.Text
            qty7 = txtqty7.Text
            qty8 = txtqty8.Text
            qty9 = txtqty10.Text
            qty10 = txtqty10.Text
            qty11 = txtqty11.Text
            qty12 = txtqty12.Text
            qty13 = txtqty13.Text
            qty14 = txtqty14.Text
            qty15 = txtqty15.Text
            qty16 = txtqty16.Text
            qty17 = txtqty17.Text
            qty18 = txtqty18.Text
            qty19 = txtqty19.Text
            qty20 = txtqty20.Text
            qty21 = txtqty21.Text
            qty22 = txtqty22.Text
            qty23 = txtqty23.Text
            qty24 = txtqty24.Text
            qty25 = txtqty25.Text
            qty26 = txtqty26.Text
            qty27 = txtqty27.Text
            qty28 = txtqty28.Text
            qty29 = txtqty29.Text
            qty30 = txtqty30.Text
            qty31 = txtqty31.Text
            harga = txtharga.Text
            nilai1 = qty1 * harga
            nilai2 = qty2 * harga
            nilai3 = qty3 * harga
            nilai4 = qty4 * harga
            nilai5 = qty5 * harga
            nilai6 = qty6 * harga
            nilai7 = qty7 * harga
            nilai8 = qty8 * harga
            nilai9 = qty9 * harga
            nilai10 = qty10 * harga
            nilai11 = qty11 * harga
            nilai12 = qty12 * harga
            nilai13 = qty13 * harga
            nilai14 = qty14 * harga
            nilai15 = qty15 * harga
            nilai16 = qty16 * harga
            nilai17 = qty17 * harga
            nilai18 = qty18 * harga
            nilai19 = qty19 * harga
            nilai20 = qty20 * harga
            nilai21 = qty21 * harga
            nilai22 = qty22 * harga
            nilai23 = qty23 * harga
            nilai24 = qty24 * harga
            nilai25 = qty25 * harga
            nilai26 = qty26 * harga
            nilai27 = qty27 * harga
            nilai28 = qty28 * harga
            nilai29 = qty29 * harga
            nilai30 = qty30 * harga
            nilai31 = qty31 * harga
            txtnilai1.Text = nilai1
            txtnilai2.Text = nilai2
            txtnilai3.Text = nilai3
            txtnilai4.Text = nilai4
            txtnilai5.Text = nilai5
            txtnilai5.Text = nilai5
            txtnilai6.Text = nilai6
            txtnilai7.Text = nilai7
            txtnilai8.Text = nilai8
            txtnilai9.Text = nilai9
            txtnilai10.Text = nilai10
            txtnilai11.Text = nilai11
            txtnilai12.Text = nilai12
            txtnilai13.Text = nilai13
            txtnilai14.Text = nilai14
            txtnilai15.Text = nilai15
            txtnilai16.Text = nilai16
            txtnilai17.Text = nilai17
            txtnilai18.Text = nilai18
            txtnilai19.Text = nilai19
            txtnilai20.Text = nilai20
            txtnilai21.Text = nilai21
            txtnilai22.Text = nilai22
            txtnilai23.Text = nilai23
            txtnilai24.Text = nilai24
            txtnilai25.Text = nilai25
            txtnilai26.Text = nilai26
            txtnilai27.Text = nilai27
            txtnilai28.Text = nilai28
            txtnilai29.Text = nilai29
            txtnilai30.Text = nilai30
            txtnilai31.Text = nilai31
            txtjlhqty.Text = qty1 + qty2 + qty3 + qty4 + qty5 + qty6 + qty7 + qty8 + qty9 + qty10 + _
                qty11 + qty12 + qty13 + qty14 + qty15 + qty16 + qty17 + qty18 + qty19 + qty20 + _
                qty21 + qty22 + qty23 + qty24 + qty25 + qty26 + qty27 + qty28 + qty29 + qty30 + qty31
            txtjlhnilai.Text = nilai1 + nilai2 + nilai3 + nilai4 + nilai5 + nilai6 + nilai7 + nilai8 + _
                nilai9 + nilai10 + nilai11 + nilai12 + nilai13 + nilai14 + nilai15 + nilai16 + nilai17 + _
                nilai18 + nilai19 + nilai20 + nilai21 + nilai22 + nilai23 + nilai24 + nilai25 + nilai26 + _
                nilai27 + nilai28 + nilai29 + nilai30 + nilai31
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If (cbkode.Text = "") Or (txtjlhqty.Text = "") Then
            MessageBox.Show("Lengkapi Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim oke As New OleDb.OleDbCommand
            Dim oke2 As New OleDb.OleDbCommand
            Dim baca As OleDb.OleDbDataReader
            Dim periode As Date
            periode = Format(DateTimePicker1.Value.Date, "MMM yyyy")
            oke = New OleDb.OleDbCommand("SELECT * FROM TbDataPenjualan WHERE Periode LIKE '" & periode & "' AND Kode LIKE '" & cbkode.Text & "'", database)
            baca = oke.ExecuteReader()
            If baca.Read() Then
                MessageBox.Show("Data Sudah Ada", "Input Data Lain", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                oke2.Connection = database
                oke2.CommandType = CommandType.Text
                oke2.CommandText = "INSERT INTO TbDataPenjualan VALUES ('" & periode & "','" & cbkode.Text & "','" & txtnamamenu.Text & "','" & txtjlhqty.Text & "','" & txtjlhnilai.Text & "')"
                oke2.ExecuteNonQuery()
                MessageBox.Show("Data Disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call DataPenjualan()
            End If
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim oke As OleDb.OleDbCommand
        Dim oke2 As New OleDb.OleDbCommand
        Dim baca As OleDb.OleDbDataReader
        Dim periode As Date
        periode = Format(DateTimePicker1.Value.Date, "MMM yyyy")
        oke = New OleDb.OleDbCommand("SELECT * FROM TbDataTotal WHERE Periode LIKE '" & periode & "'", database)
        baca = oke.ExecuteReader()
        If baca.Read() Then
            oke2.Connection = database
            oke2.CommandType = CommandType.Text
            oke2.CommandText = "UPDATE TbDataTotal SET Periode = '" & periode & "',TotalQty = '" & txttotalqty.Text & "',TotalNilai = '" & txttotalnilai.Text & "' WHERE Periode LIKE '" & periode & "'"
            oke2.ExecuteNonQuery()
            MessageBox.Show("Data Diupdate", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call DataPenjualan()
        Else
            oke2.Connection = database
            oke2.CommandType = CommandType.Text
            oke2.CommandText = "INSERT INTO TbDataTotal VALUES ('" & periode & "','" & txttotalqty.Text & "','" & txttotalnilai.Text & "')"
            oke2.ExecuteNonQuery()
            MessageBox.Show("Data DiSimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call DataPenjualan()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Call koneksi()
        Dim periode As Date
        Dim totalqty As Double
        Dim totalnilai As Double
        periode = Format(DateTimePicker1.Value.Date, "MMM yyyy")
        tabel = New Data.OleDb.OleDbDataAdapter("SELECT * FROM TbDataPenjualan WHERE Periode LIKE '%" & periode & "%'", database)
        data = New DataSet
        tabel.Fill(data)
        record.DataSource = data
        record.DataMember = data.Tables(0).ToString()
        DataGridView1.DataSource = record
        tabel2 = New Data.OleDb.OleDbDataAdapter("SELECT * FROM TbDataTotal WHERE Periode LIKE '%" & periode & "%'", database)
        data2 = New DataSet
        tabel2.Fill(data2)
        record2.DataSource = data2
        record2.DataMember = data2.Tables(0).ToString()
        DataGridView2.DataSource = record2
        totalqty = 0
        totalnilai = 0
        For t As Integer = 0 To DataGridView1.Rows.Count - 1
            totalqty = totalqty + Val(DataGridView1.Rows(t).Cells(3).Value)
            totalnilai = totalnilai + Val(DataGridView1.Rows(t).Cells(4).Value)
        Next
        txttotalqty.Text = totalqty
        txttotalnilai.Text = totalnilai
    End Sub
    
End Class