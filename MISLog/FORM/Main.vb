Imports System.Reflection
Imports System.Data.SQLite

Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkSendDB()
        send_telegram.Checked = My.Settings.send_telegram
        chat_id.Text = My.Settings.chat_id
    End Sub

    Private Sub test_Click(sender As Object, e As EventArgs) Handles test.Click
        Telegram.sendMessage(terminal:="0", type:="TESTE", message:="TESTE", data:="00000000", time:="000000000", sessionID:="0")
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        My.Settings.bot_token = bot_token.Text
        My.Settings.send_telegram = send_telegram.CheckState
        MessageBox.Show("Data saved!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        GravarLog(Tipo:="INFO", Modd:=MethodBase.GetCurrentMethod.ToString, Msg:="bot_token updated")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.chat_id = chat_id.Text
        My.Settings.send_telegram = send_telegram.CheckState
        MessageBox.Show("Data saved!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        GravarLog(Tipo:="INFO", Modd:=MethodBase.GetCurrentMethod.ToString, Msg:="chat_id updated")
    End Sub

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        If (My.Settings.bot_token <> "" And My.Settings.chat_id <> "") Then
            If TimerTelegram.Enabled = True Then
                TimerTelegram.Stop()
                start.Text = "START"
                lbl_state.Text = "STOPPED"
                lbl_state.ForeColor = Color.Red
                GravarLog(Tipo:="INFO", Modd:=MethodBase.GetCurrentMethod.ToString, Msg:="Stop Process")
            Else
                TimerTelegram.Start()
                lbl_state.Text = "WORKING"
                start.Text = "STOP"
                lbl_state.ForeColor = Color.Green
                GravarLog(Tipo:="INFO", Modd:=MethodBase.GetCurrentMethod.ToString, Msg:="Start Process")
                hidden.ShowBalloonTip(2000, "It's still running!", "MISLog", ToolTipIcon.Info)
                Me.WindowState = FormWindowState.Minimized
            End If
        Else
            MessageBox.Show("Param [bot_token, chat_id] not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TimerTelegram_Tick(sender As Object, e As EventArgs) Handles TimerTelegram.Tick
        Try
            Using con As SQLiteConnection = GetConnectionLOG()
                con.Open()
                Dim sql As String = "select SessionID, Terminal, Date, Time, Description, AdditionalErrorDescription FROM Log WHERE Description like '%Error%' and send = 0"
                Dim cmd As New SQLiteCommand(sql, con)
                Dim read As SQLiteDataReader = cmd.ExecuteReader()
                While read.Read() = True
                    Telegram.sendMessage(sessionID:=read.Item("SessionID"), terminal:=read.Item("Terminal"), type:=read.Item("Description"), message:=read.Item("AdditionalErrorDescription"), data:=read.Item("Date"), time:=read.Item("Time"))
                    DataBase.UpdateRecord(terminal:=read.Item("Terminal"), data:=read.Item("Date"), time:=read.Item("Time"))
                End While
                con.Close()
            End Using
        Catch ex As Exception
            GravarLog(Tipo:="ERROR", Modd:=MethodBase.GetCurrentMethod.ToString, Msg:=ex.Message)
        End Try
    End Sub

    Private Sub hidden_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles hidden.MouseDoubleClick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            hidden.ShowBalloonTip(2000, "It's still running!", "MISLog", ToolTipIcon.Info)
        End If
    End Sub


End Class