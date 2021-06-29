Imports System.Data.OleDb
Module Module1
    Public database As OleDb.OleDbConnection
    Public Sub koneksi()
        Try
            database = New OleDb.OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0; Data Source=" & Application.StartupPath & "\dbvariasimenu.mdb")
            database.Open()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Module
