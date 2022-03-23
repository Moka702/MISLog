Imports System.Data.SQLite
Imports System.Reflection

Module Telegram
    Public Sub sendMessage(terminal As Integer, type As String, message As String, data As String, time As String, sessionID As String)
        Try
            Dim api_url = "https://api.telegram.org/bot{0}/sendMessage"

            Using client As New Net.WebClient
                Dim reqparm As New Specialized.NameValueCollection
                reqparm.Add("chat_id", My.Settings.chat_id)
                reqparm.Add("parse_mode", "html")
                reqparm.Add("text",
                            "TERMINAL: <b>" & terminal & "</b>" & vbNewLine &
                            "SESSIONID: <b>" & sessionID & "</b>" & vbNewLine &
                            "DATE: <b>" & Mid(data, 7, 2) & "-" & Mid(data, 5, 2) & "-" & Mid(data, 1, 4) & "</b>" & vbNewLine &
                            "TIME: <b>" & Mid(time, 1, 2) & ":" & Mid(time, 3, 2) & ":" & Mid(time, 5, 2) & "." & Mid(time, 7, 3) & "</b>" & vbNewLine &
                            "TYPE: <b>" & type & "</b>" & vbNewLine &
                            "ERROR: <b>" & message & "</b>")
                Dim responsebytes = client.UploadValues(String.Format(api_url, My.Settings.bot_token), "POST", reqparm)
                Dim responsebody = (New Text.UTF8Encoding).GetString(responsebytes)
                '...
            End Using
        Catch ex As Exception
            GravarLog(Tipo:="ERROR", Modd:=MethodBase.GetCurrentMethod.ToString, Msg:=ex.Message)
        End Try
    End Sub
End Module

