Imports System.Runtime.InteropServices

Public Class frmTrainer

    Dim config As String = IO.Path.Combine(My.Application.Info.DirectoryPath, "dtrainer.cfg")
    Dim game_exe As String = ReadCfgValue("game_exe", config).Replace(".exe", "")
    Dim auto_patch As Boolean = CBool(ReadCfgValue("auto_patch", config))

    <DllImport("user32.dll")>
    Public Shared Function GetAsyncKeyState(ByVal vKey As Int32) As Short
    End Function

    Private Declare Function IsWindowVisible Lib "user32" Alias "IsWindowVisible" (ByVal hwnd As IntPtr) As Boolean

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim id8 As Process() = Process.GetProcessesByName(game_exe)

        If id8.Length = 0 Then
            lblStatus.Text = "Game not found, trainer is waiting."
            If Timer2.Enabled Then Timer2.Stop()
            opt1.ForeColor = Color.White
            opt2.ForeColor = Color.White
        Else
            lblStatus.Text = "Game found, trainer is activated."
            If auto_patch Then
                lblStatus.Text = "Game found, waiting for game to start."
                If IsWindowVisible(FindWindow(Nothing, id8(0).MainWindowTitle)) Then
                    Threading.Thread.Sleep(3000)
                    AutoPatch()
                End If
            Else
                Timer2.Start()
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If GetAsyncKeyState(Keys.Menu) And GetAsyncKeyState(Keys.D1) Then
            If Not opt1.ForeColor = Color.Red Then
                My.Computer.Audio.Play(My.Resources.play, AudioPlayMode.Background)
                opt1.ForeColor = Color.Red
                WriteInteger(game_exe, &H13D3782, 0, 1)
            End If
        End If
        If GetAsyncKeyState(Keys.Menu) And GetAsyncKeyState(Keys.D2) Then
            If Not opt2.ForeColor = Color.Red Then
                opt2.ForeColor = Color.Red
                My.Computer.Audio.Play(My.Resources.play, AudioPlayMode.Background)
                WriteInteger(game_exe, &H13D37B0, 99)
            End If
        End If
    End Sub

    Private Sub AutoPatch()
        Timer1.Stop()
        My.Computer.Audio.Play(My.Resources.play, AudioPlayMode.Background)
        opt1.ForeColor = Color.Red
        opt2.ForeColor = Color.Red
        WriteInteger(game_exe, &H13D3782, 0, 1)
        WriteInteger(game_exe, &H13D37B0, 99)
        Me.Close()
    End Sub

    Private Sub cbAutoPatch_CheckedChanged(sender As Object, e As EventArgs) Handles cbAutoPatch.CheckedChanged
        WriteCfgValue("auto_patch", Convert.ToInt32(cbAutoPatch.Checked), config)
    End Sub

    Private Sub frmTrainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbAutoPatch.Checked = CBool(ReadCfgValue("auto_patch", config))
    End Sub
End Class
