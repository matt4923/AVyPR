Imports System.IO
Imports System.Text.RegularExpressions
Imports AVyPR.listManager
Imports System.Threading

Public Class HandJammer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If btnLogin.Text = "Login" Then
            ' Dim tunnelier1 As String = Application.StartupPath & "\Tunnel\Tunnel.exe -menu=small  -profile=Tunnel\ssh1.bscp -host=" + txtHost.Text + " -Port=" + txtPort.Text + " -username=" + txtUser.Text + " -password=" + txtPass.Text + " -loginOnStartup -disableSftplocation -Title=server1 -proxy=y" + " -proxyType=HTTP -proxyServer=127.0.0.1" + " -proxyPort=" + txtProxy.Text + " """
            'Dim tunnelier2 As String = Application.StartupPath & "\Tunnel\Tunnel.exe -menu=small  -profile=Tunnel\ssh2.bscp -host=" + txtHost.Text + " -Port=" + txtPort.Text + " -username=" + txtUser.Text + " -password=" + txtPass.Text + " -loginOnStartup -disableSftplocation -Title=server2 -proxy=y" + " -proxyType=HTTP -proxyServer=127.0.0.1" + " -proxyPort=" + txtProxy.Text + " """
            Dim tunnelier1 As String = Application.StartupPath & "\Tunnel\Tunnel.exe -menu=small  -profile=Tunnel\ssh1.bscp -host=" + txtHost.Text + " -Port=" + txtPort.Text + " -username=" + txtUser.Text + " -password=" + txtPass.Text + " -loginOnStartup -disableSftplocation -Title=server1  -proxy=n"""
            'Dim tunnelier2 As String = Application.StartupPath & "\Tunnel\Tunnel.exe -menu=small  -profile=Tunnel\ssh2.bscp -host=" + txtHost.Text + " -Port=" + txtPort.Text + " -username=" + txtUser.Text + " -password=" + txtPass.Text + " -loginOnStartup -disableSftplocation -Title=server2 """
            'Jika pakai proxy -proxy=y jika tanpa proxy -proxy=n
            Try
                Shell(tunnelier1, AppWinStyle.NormalFocus)
                Application.DoEvents()
            Catch ex As Exception
            End Try
            btnLogin.Text = "Logout"
        Else
            btnLogin.Text = "Login"
            tunnel_close()
        End If
    End Sub
    Sub tunnel_close()
        Dim tunnel() As Process = System.Diagnostics.Process.GetProcessesByName("Tunnel")
        Try
            For Each p As Process In tunnel
                p.Kill()
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        tunnel_close()
    End Sub

    Private Sub btnSendSwitchCmd_Click(sender As Object, e As EventArgs) Handles btnSendSwitchCmd.Click
        Shell("list config stat", AppWinStyle.MaximizedFocus)
        Application.DoEvents()
    End Sub
End Class