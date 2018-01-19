Imports System.IO

Public Class progress
    Private m_filePath As String
    Public Sub New(filePath As String)
        InitializeComponent()
        m_filePath = filePath
    End Sub


    Private Sub updateProgress()

    End Sub

    Private Sub progress_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        updateProgress()
    End Sub
End Class