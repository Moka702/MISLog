Imports System.Data.SQLite

Module SQL
    Public Function GetConnectionLOG() As SQLiteConnection
        Dim conn As String = "Data Source=C:\MIS\MISCommunicator\Log\LogDB.sdf; Integrated Security=true"
        Return New SQLiteConnection(conn)
    End Function

End Module