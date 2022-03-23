Module LOG

    Public FicherioLog As String = ""

    Public Sub GravarLog(Tipo As String, Msg As String, Modd As String)
        Try
            FicherioLog = "C:\MIS\MISCommunicator\Log\MISLog_" & DateTime.Now.ToString("dd.MM.yyy") & ".txt"
            Dim escrever As System.IO.StreamWriter
            escrever = My.Computer.FileSystem.OpenTextFileWriter(FicherioLog, True)
            escrever.WriteLine("[" & DateTime.Now & "]" & " -> " & Tipo & " [" & Modd & "] -> " & Msg)
            escrever.Close()
        Catch ex As Exception
        End Try
    End Sub

End Module
