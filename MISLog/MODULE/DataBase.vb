Imports System.Data.SQLite
Imports System.Reflection

Module DataBase
    Public Sub checkSendDB()
        Try
            Using con As SQLiteConnection = GetConnectionLOG()
                con.Open()
                Dim sql As String = "SELECT COUNT(*) AS CNTREC FROM pragma_table_info('Log') WHERE name='send'"
                Dim cmd As New SQLiteCommand(sql, con)
                Dim read As SQLiteDataReader = cmd.ExecuteReader()
                read.Read()
                If read.Item(0) = 0 Then
                    addSendDB()
                    updateSendDB()
                End If
                con.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            GravarLog(Tipo:="ERROR", Modd:=MethodBase.GetCurrentMethod.ToString, Msg:=ex.Message)
        End Try
    End Sub

    Public Sub addSendDB()
        Try
            Using con As SQLiteConnection = GetConnectionLOG()
                con.Open()
                Dim sql As String = "ALTER TABLE Log ADD send BLOB default 0"
                Dim cmd As New SQLiteCommand(sql, con)
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            GravarLog(Tipo:="ERROR", Modd:=MethodBase.GetCurrentMethod.ToString, Msg:=ex.Message)
        End Try
    End Sub

    Public Sub updateSendDB()
        Try
            Using con As SQLiteConnection = GetConnectionLOG()
                con.Open()
                Dim sql As String = "UPDATE Log SET send = 1 WHERE 1 = 1"
                Dim cmd As New SQLiteCommand(sql, con)
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            GravarLog(Tipo:="ERROR", Modd:=MethodBase.GetCurrentMethod.ToString, Msg:=ex.Message)
        End Try
    End Sub

    Public Sub UpdateRecord(terminal As Integer, data As String, time As String)
        Try
            Using con As SQLiteConnection = GetConnectionLOG()
                con.Open()
                Dim sql As String = "update Log set send = 1 where Terminal = '" & terminal & "' and Date = '" & data & "' and time = '" & time & "'"
                Dim cmd As New SQLiteCommand(sql, con)
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        Catch ex As Exception
            GravarLog(Tipo:="ERROR", Modd:=MethodBase.GetCurrentMethod.ToString, Msg:=ex.Message)
        End Try
    End Sub
End Module
