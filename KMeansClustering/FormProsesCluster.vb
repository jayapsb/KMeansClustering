Imports System.Math
Public Class FormProsesCluster
    Dim dt As New DataTable
    Dim dt2 As New DataTable
    Dim dt3 As New DataTable
    Dim dt5 As New DataTable
    Dim dt4 As New DataTable
    Dim bl As Boolean = False
    Dim cluster_1 As String = ""
    Dim cluster_2 As String = ""

    Private Sub FormProsesCluster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        btntampilkan.Enabled = False
        btnlanjutproses.Enabled = False
        Call TampilData()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MMM yyyy"
        DateTimePicker1.Value = Format(Now)
    End Sub
    Sub TampilData()
        Dim periode As Date
        periode = Format(DateTimePicker1.Value.Date, "MMM yyyy")
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM TbDataMix WHERE Periode LIKE '%" & periode & "%'", database)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Sub cluster()
        cluster_1 = ""
        dt3.Clear()
        Try
            dt4.Columns.Add("Kode")
            dt4.Columns.Add("MenuMix")
            dt4.Columns.Add("SalesMix")
        Catch ex As Exception

        End Try
        Try
            dt3.Columns.Add("Kode")
            dt3.Columns.Add("NamaMenu")
            For a As Integer = 1 To DataGridView2.RowCount - 1
                Dim kolom As String = "C" & a
                dt3.Columns.Add(kolom)
            Next
            dt3.Columns.Add("Min")
            dt3.Columns.Add("Cluster")
        Catch ex As Exception

        End Try
        For Each x As DataRow In dt.Rows
            Dim d(100) As Double
            Dim i As Integer = 0
            Dim min As Double = 100
            Dim cluster As String = ""
            Dim code As String = ""
            Dim namamenu As String = ""
            For Each r As DataRow In dt2.Rows
                d(i) = Round(Val(Math.Sqrt((x("MenuMix") - r("MenuMix")) ^ 2 + (x("SalesMix") - r("SalesMix")) ^ 2)), 3)
                If min > d(i) Then
                    cluster = "C" & (i + 1)
                End If
                min = Math.Min(min, d(i))
                i = i + 1
            Next
            code = x("Kode")
            namamenu = x("NamaMenu")
            Dim jlh_c As Integer = DataGridView2.RowCount - 1
            If jlh_c = 1 Then
                dt3.Rows.Add(code, namamenu, d(0), min, cluster)
            ElseIf jlh_c = 2 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), min, cluster)
            ElseIf jlh_c = 3 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), min, cluster)
            ElseIf jlh_c = 4 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), min, cluster)
            ElseIf jlh_c = 5 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), min, cluster)
            ElseIf jlh_c = 6 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), min, cluster)
            ElseIf jlh_c = 7 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), min, cluster)
            ElseIf jlh_c = 8 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), min, cluster)
            ElseIf jlh_c = 9 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), min, cluster)
            ElseIf jlh_c = 10 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), min, cluster)
            ElseIf jlh_c = 11 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), min, cluster)
            ElseIf jlh_c = 12 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), min, cluster)
            ElseIf jlh_c = 13 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), min, cluster)
            ElseIf jlh_c = 14 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), min, cluster)
            ElseIf jlh_c = 15 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), min, cluster)
            ElseIf jlh_c = 16 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), min, cluster)
            ElseIf jlh_c = 17 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), min, cluster)
            ElseIf jlh_c = 18 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), min, cluster)
            ElseIf jlh_c = 19 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), min, cluster)
            ElseIf jlh_c = 20 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), min, cluster)
            ElseIf jlh_c = 21 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), min, cluster)
            ElseIf jlh_c = 22 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), min, cluster)
            ElseIf jlh_c = 23 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), min, cluster)
            ElseIf jlh_c = 24 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), min, cluster)
            ElseIf jlh_c = 25 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), min, cluster)
            ElseIf jlh_c = 26 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), min, cluster)
            ElseIf jlh_c = 27 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), min, cluster)
            ElseIf jlh_c = 28 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), min, cluster)
            ElseIf jlh_c = 29 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), min, cluster)
            ElseIf jlh_c = 30 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), min, cluster)
            ElseIf jlh_c = 31 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), min, cluster)
            ElseIf jlh_c = 32 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), min, cluster)
            ElseIf jlh_c = 33 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), min, cluster)
            ElseIf jlh_c = 34 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), d(33), min, cluster)
            ElseIf jlh_c = 35 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), d(33), d(34), min, cluster)
            ElseIf jlh_c = 36 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), d(33), d(34), d(35), min, cluster)
            ElseIf jlh_c = 37 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), d(33), d(34), d(35), d(36), min, cluster)
            ElseIf jlh_c = 38 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), d(33), d(34), d(35), d(36), d(37), min, cluster)
            ElseIf jlh_c = 39 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), d(33), d(34), d(35), d(36), d(37), d(38), min, cluster)
            ElseIf jlh_c = 40 Then
                dt3.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), d(33), d(34), d(35), d(36), d(37), d(38), d(39), min, cluster)
            End If
        Next
        DataGridView3.DataSource = dt3
        Dim total As Double
        total = 0
        For t As Integer = 0 To DataGridView3.RowCount - 1
            total = total + (DataGridView3.Rows(t).Cells("Min").Value ^ 2)
        Next
        For k As Integer = 1 To DataGridView2.RowCount - 1
            Dim cen(k) As String
            cen(k) = "C" & k

            Dim tcen As Integer = 0
            Dim ttmenu As Double = 0
            Dim ttsales As Double = 0
            Dim ttmenu1 As Double
            Dim ttsales1 As Double
            For dta3 As Integer = 0 To DataGridView3.RowCount - 1
                If cen(k) = DataGridView3.Rows(dta3).Cells("Cluster").Value Then
                    tcen = tcen + 1
                    Dim kodedt As String = DataGridView3.Rows(dta3).Cells("Kode").Value
                    For dta1 As Integer = 0 To DataGridView1.RowCount - 1
                        If kodedt = DataGridView1.Rows(dta1).Cells("Kode").Value Then
                            ttmenu = ttmenu + DataGridView1.Rows(dta1).Cells("MenuMix").Value
                            ttsales = ttsales + DataGridView1.Rows(dta1).Cells("SalesMix").Value
                            Dim b As String = cen(k)
                            If cluster_1 = "" Then
                                cluster_1 = b & "," & DataGridView1.Rows(dta1).Cells("Kode").Value
                            Else
                                cluster_1 = b & "," & cluster_1 & "," & DataGridView1.Rows(dta1).Cells("Kode").Value
                            End If
                        End If
                    Next
                End If
            Next
            ttmenu1 = Round(Val(ttmenu / tcen), 3)
            ttsales1 = Round(Val(ttsales / tcen), 3)
            dt4.Rows.Add(cen(k), ttmenu1, ttsales1)
            DataGridView2.DataSource = dt4
        Next
        dt2.Clear()
        If Not (cluster_1 = "" Or cluster_2 = "") Then
            If cluster_1 = cluster_2 Then
                MsgBox("Proses Selesai", MsgBoxStyle.Information)
                btnlanjutproses.Enabled = False
                btntampilkan.Enabled = True
                Exit Sub
            Else
                MsgBox("Centroid Belum Sama Dengan Centroid Sebelumnya, Lanjutkan Proses", MsgBoxStyle.Exclamation)
                btnlanjutproses.Enabled = True
                btntampilkan.Enabled = False
            End If
        End If
    End Sub

    Sub cluster_next()
        cluster_2 = ""
        dt5.Columns.Clear()
        dt5.Clear()
        Try
            dt2.Columns.Add("Kode")
            dt2.Columns.Add("MenuMix")
            dt2.Columns.Add("SalesMix")
        Catch ex As Exception

        End Try
        Try
            dt5.Columns.Add("Kode")
            dt5.Columns.Add("NamaMenu")
            For a As Integer = 1 To DataGridView2.RowCount - 1
                Dim kolom As String = "C" & a
                dt5.Columns.Add(kolom)
            Next
            dt5.Columns.Add("Min")
            dt5.Columns.Add("Cluster")
        Catch ex As Exception

        End Try
        For Each x As DataRow In dt.Rows
            Dim d(100) As Double
            Dim i As Integer = 0
            Dim min As Double = 100
            Dim cluster As String = ""
            Dim code As String = ""
            Dim namamenu As String = ""
            For Each r As DataRow In dt4.Rows
                d(i) = Round(Val(Math.Sqrt((x("MenuMix") - r("MenuMix")) ^ 2 + (x("SalesMix") - r("SalesMix")) ^ 2)), 3)
                If min > d(i) Then
                    cluster = "C" & (i + 1)
                End If
                min = Math.Min(min, d(i))
                i = i + 1
            Next
            code = x("Kode")
            namamenu = x("NamaMenu")
            Dim jlh_c As Integer = DataGridView2.RowCount - 1
            If jlh_c = 1 Then
                dt5.Rows.Add(code, namamenu, d(0), min, cluster)
            ElseIf jlh_c = 2 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), min, cluster)
            ElseIf jlh_c = 3 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), min, cluster)
            ElseIf jlh_c = 4 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), min, cluster)
            ElseIf jlh_c = 5 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), min, cluster)
            ElseIf jlh_c = 6 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), min, cluster)
            ElseIf jlh_c = 7 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), min, cluster)
            ElseIf jlh_c = 8 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), min, cluster)
            ElseIf jlh_c = 9 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), min, cluster)
            ElseIf jlh_c = 10 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), min, cluster)
            ElseIf jlh_c = 11 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), min, cluster)
            ElseIf jlh_c = 12 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), min, cluster)
            ElseIf jlh_c = 13 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), min, cluster)
            ElseIf jlh_c = 14 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), min, cluster)
            ElseIf jlh_c = 15 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), min, cluster)
            ElseIf jlh_c = 16 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), min, cluster)
            ElseIf jlh_c = 17 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), min, cluster)
            ElseIf jlh_c = 18 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), min, cluster)
            ElseIf jlh_c = 19 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), min, cluster)
            ElseIf jlh_c = 20 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), min, cluster)
            ElseIf jlh_c = 21 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), min, cluster)
            ElseIf jlh_c = 22 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), min, cluster)
            ElseIf jlh_c = 23 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), min, cluster)
            ElseIf jlh_c = 24 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), min, cluster)
            ElseIf jlh_c = 25 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), min, cluster)
            ElseIf jlh_c = 26 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), min, cluster)
            ElseIf jlh_c = 27 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), min, cluster)
            ElseIf jlh_c = 28 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), min, cluster)
            ElseIf jlh_c = 29 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), min, cluster)
            ElseIf jlh_c = 30 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), min, cluster)
            ElseIf jlh_c = 31 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), min, cluster)
            ElseIf jlh_c = 32 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), min, cluster)
            ElseIf jlh_c = 33 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), min, cluster)
            ElseIf jlh_c = 34 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), d(33), min, cluster)
            ElseIf jlh_c = 35 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), d(33), d(34), min, cluster)
            ElseIf jlh_c = 36 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), d(33), d(34), d(35), min, cluster)
            ElseIf jlh_c = 37 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), d(33), d(34), d(35), d(36), min, cluster)
            ElseIf jlh_c = 38 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), d(33), d(34), d(35), d(36), d(37), min, cluster)
            ElseIf jlh_c = 39 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), d(33), d(34), d(35), d(36), d(37), d(38), min, cluster)
            ElseIf jlh_c = 40 Then
                dt5.Rows.Add(code, namamenu, d(0), d(1), d(2), d(3), d(4), d(5), d(6), d(7), d(8), d(9), d(10), d(11), d(12), d(13), d(14), d(15), d(16), d(17), d(18), d(19), d(20), d(21), d(22), d(23), d(24), d(25), d(26), d(27), d(28), d(29), d(30), d(31), d(32), d(33), d(34), d(35), d(36), d(37), d(38), d(39), min, cluster)
            End If
        Next

        DataGridView3.DataSource = dt5
        Dim total As Double
        total = 0
        For t As Integer = 0 To DataGridView3.RowCount - 1
            total = total + (DataGridView3.Rows(t).Cells("Min").Value ^ 2)
        Next
        For k As Integer = 1 To DataGridView2.RowCount - 1
            Dim cen(k) As String
            Dim cen2(k) As String
            cen(k) = "C" & k
            cen2(k) = cen(k)
            Dim tcen As Integer = 0
            Dim ttmenu As Double = 0
            Dim ttsales As Double = 0
            Dim ttmenu1 As Double
            Dim ttsales1 As Double
            For dta5 As Integer = 0 To DataGridView3.RowCount - 1
                If cen(k) = DataGridView3.Rows(dta5).Cells("Cluster").Value Then
                    tcen = tcen + 1
                    Dim kodedt As String = DataGridView3.Rows(dta5).Cells("Kode").Value
                    For dta1 As Integer = 0 To DataGridView1.RowCount - 1
                        If kodedt = DataGridView1.Rows(dta1).Cells("Kode").Value Then
                            ttmenu = ttmenu + DataGridView1.Rows(dta1).Cells("MenuMix").Value
                            ttsales = ttsales + DataGridView1.Rows(dta1).Cells("SalesMix").Value
                            Dim b As String = cen(k)
                            If cluster_2 = "" Then
                                cluster_2 = b & "," & DataGridView1.Rows(dta1).Cells("Kode").Value
                            Else
                                cluster_2 = b & "," & cluster_2 & "," & DataGridView1.Rows(dta1).Cells("Kode").Value
                            End If
                        End If
                    Next
                End If
            Next
            ttmenu1 = Round(Val(ttmenu / tcen), 3)
            ttsales1 = Round(Val(ttsales / tcen), 3)
            dt2.Rows.Add(cen(k), ttmenu1, ttsales1)
            DataGridView2.DataSource = dt2
        Next
        dt4.Clear()
        If Not (cluster_1 = "" Or cluster_2 = "") Then
            If cluster_1 = cluster_2 Then
                MsgBox("Proses Selesai", MsgBoxStyle.Information)
                btnlanjutproses.Enabled = False
                btntampilkan.Enabled = True
                Exit Sub
            Else
                MsgBox("Centroid Belum Sama Dengan Centroid Sebelumnya, Lanjutkan Proses", MsgBoxStyle.Exclamation)
                btnlanjutproses.Enabled = True
                btntampilkan.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnlanjutproses_Click(sender As Object, e As EventArgs) Handles btnlanjutproses.Click
        If DataGridView2.RowCount - 1 <= 0 Then
            MsgBox("Pilih Centroid Awal", MsgBoxStyle.Critical)
            Exit Sub
        End If

        txtIterasi.Text = Val(txtIterasi.Text) + 1

        If Val(txtIterasi.Text) Mod 2 = 1 Then
            Call cluster()
        Else
            dt2.Clear()
            Call cluster_next()
        End If
        If txtIterasi.Text = 1 Then
            MsgBox("Lanjutkan Proses", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        dt.Clear()
        Dim periode As Date
        periode = Format(DateTimePicker1.Value.Date, "MMM yyyy")
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM TbDataMix WHERE Periode LIKE '%" & periode & "%'", database)
        da.Fill(dt)
        Dim tabel As OleDb.OleDbDataAdapter
        Dim data As DataSet
        Dim record As New BindingSource
        tabel = New Data.OleDb.OleDbDataAdapter("SELECT * FROM TbDataMix WHERE Periode LIKE '%" & periode & "%'", database)
        data = New DataSet
        tabel.Fill(data)
        record.DataSource = data
        record.DataMember = data.Tables(0).ToString()
        DataGridView1.DataSource = record
        If DataGridView1.RowCount > 1 Then
            Try
                dt2.Columns.Add("Kode")
                dt2.Columns.Add("MenuMix")
                dt2.Columns.Add("SalesMix")
                DataGridView2.DataSource = dt2
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btntampilkan_Click(sender As Object, e As EventArgs) Handles btntampilkan.Click
        Dim dttable As New DataTable
        Dim jlhkolom As Integer
        jlhkolom = DataGridView3.Columns.Count
        With dttable
            .Columns.Add("Kode")
            .Columns.Add("NamaMenu")
            .Columns.Add("Cluster")
        End With
        For Each row As DataGridViewRow In DataGridView3.Rows
            dttable.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(jlhkolom - 1).Value)
        Next
        FormReportCluster.ReportViewer1.LocalReport.DataSources.Item(0).Value = dttable
        FormReportCluster.ShowDialog()
        FormReportCluster.Dispose()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        For a As Integer = 0 To DataGridView2.RowCount - 1
            If DataGridView1.CurrentRow.Cells("Kode").Value = DataGridView2.Rows(a).Cells("Kode").Value Then
                MsgBox("Centroid Sudah ada", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If DataGridView2.RowCount - 1 = txtjumlahcluster.Text Then
                MsgBox("Centroid Sudah Sebanyak Jumlah Cluster", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Next
        dt2.Rows.Add(DataGridView1.CurrentRow.Cells("Kode").Value, DataGridView1.CurrentRow.Cells("MenuMix").Value, DataGridView1.CurrentRow.Cells("SalesMix").Value)
        DataGridView2.DataSource = dt2
        If DataGridView2.RowCount - 1 = txtjumlahcluster.Text Then
            btnlanjutproses.Enabled = True
            Exit Sub
        End If
    End Sub

    Private Sub DataGridView2_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView2.DoubleClick
        DataGridView2.Rows.RemoveAt(DataGridView2.CurrentRow.Index)
        btnlanjutproses.Enabled = False
    End Sub

End Class