Imports AVyPR
Imports System.IO
Imports System.Linq

Public Class ResultsForm
    Private Property mGroupHash As Hashtable

    Private mCurrentlyDist As Boolean
    Private Property currentlyDist As Boolean
        Get
            Return mCurrentlyDist
        End Get
        Set(value As Boolean)
            If value = True Then
                mCurrentlyDist = True
            Else
                If cbxCorDist.Checked OrElse cbxCosDist.Checked OrElse cbxExtensionDist.Checked _
                    OrElse cbxPortsDist.Checked OrElse cbxSetTypesDist.Checked Then
                    mCurrentlyDist = True
                Else
                    mCurrentlyDist = False
                End If
            End If
        End Set
    End Property


    Sub New(ByRef groupHash As Hashtable)
        ' This call is required by the designer.
        InitializeComponent()
        mGroupHash = groupHash
        currentlyDist = False
    End Sub

    Private Sub ResultsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        mGroupHash = Nothing
        AVyPR.frmMain.cleanUp()
        AVyPR.frmMain.Close()
    End Sub

    Private Sub ResultsForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Not Me.Visible Then
            lstCor.Items.Clear()
            lstCos.Items.Clear()
            lstExtensions.Items.Clear()
            lstSetTypes.Items.Clear()
            lstPorts.Items.Clear()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Dim SaveFileDialog1 As SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Try
            With SaveFileDialog1
                .DefaultExt = ".csv"
                .Filter = "Comma Delimited|*.csv"
                SaveFileDialog1.ShowDialog()
            End With
            If SaveFileDialog1.FileName = Nothing Then
                Exit Sub
            End If
            SaveToExcel(SaveFileDialog1.FileName.ToString())
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SaveToExcel(ByVal SavePath As String)
        Dim i As Integer
        Try
            Using sw As New System.IO.StreamWriter(SavePath)
                sw.WriteLine("SET TYPES, Extension, PORTS, COR, COS")
                For i = 0 To lstExtensions.Items.Count - 1
                    sw.Write(lstSetTypes.Items(i) & "," & lstExtensions.Items(i) & "," & lstPorts.Items(i) & "," & lstCor.Items(i) & "," & lstCos.Items(i))
                    sw.Write(sw.NewLine)
                Next
            End Using
            MsgBox("File Saved Successfully to: " & vbCrLf & SavePath)
            Process.Start("explorer.exe", SavePath)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnOpenParsed_Click(sender As Object, e As EventArgs)
        Process.Start("Explorer.exe", Application.StartupPath)
    End Sub

    Private Sub lstExtensions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstExtensions.SelectedIndexChanged, lstPorts.SelectedIndexChanged, lstSetTypes.SelectedIndexChanged, _
        lstCor.SelectedIndexChanged, lstCos.SelectedIndexChanged

        If Not AVyPR.frmMain.cbxSortResults.Checked AndAlso Not currentlyDist Then
            Dim lstBox As ListBox = sender
            Dim si As Integer

            If lstBox.Name = lstExtensions.Name Then
                si = lstExtensions.SelectedIndex
            ElseIf lstBox.Name = lstPorts.Name Then
                si = lstPorts.SelectedIndex
            ElseIf lstBox.Name = lstSetTypes.Name Then
                si = lstSetTypes.SelectedIndex
            ElseIf lstBox.Name = lstCos.Name Then
                si = lstCos.SelectedIndex
            ElseIf lstBox.Name = lstCor.Name Then
                si = lstCor.SelectedIndex
            End If

            lstExtensions.SelectedIndex = si
            lstSetTypes.SelectedIndex = si
            lstPorts.SelectedIndex = si
            lstCos.SelectedIndex = si
            lstCor.SelectedIndex = si
        End If
    End Sub

    Private Sub NewParsingFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewParsingFileToolStripMenuItem.Click
        Process.Start("Explorer.exe", Application.StartupPath)
    End Sub

    Private Sub SaveListToCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveListToCSVToolStripMenuItem.Click
        Dim SaveFileDialog1 As SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Try
            With SaveFileDialog1
                .DefaultExt = ".csv"
                .Filter = "Comma Delimited|*.csv"
                SaveFileDialog1.ShowDialog()
            End With
            If SaveFileDialog1.FileName = Nothing Then
                Exit Sub
            End If
            SaveToExcel(SaveFileDialog1.FileName.ToString())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

#Region "distinct checkboxes"
    Private Sub cbxSetTypesDist_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSetTypesDist.CheckedChanged
        lstSetTypes.DataSource = Nothing
        lstSetTypes.Items.Clear()
        If cbxSetTypesDist.Checked Then
            currentlyDist = True
            For Each st In mGroupHash("setTypes").getHashSetTypes
                lstSetTypes.Items.Add(st)
            Next
        Else
            currentlyDist = False
            lstSetTypes.DataSource = mGroupHash("setTypes").getOriginalSetTypes
        End If
    End Sub

    Private Sub cbxExtensionDist_CheckedChanged(sender As Object, e As EventArgs) Handles cbxExtensionDist.CheckedChanged
        lstExtensions.DataSource = Nothing
        lstExtensions.Items.Clear()
        If cbxExtensionDist.Checked Then
            currentlyDist = True
            For Each st In mGroupHash("extensions").getHashExtensions
                lstExtensions.Items.Add(st)
            Next
        Else
            currentlyDist = False
            lstExtensions.DataSource = mGroupHash("extensions").getOriginalExtensions
        End If
    End Sub

    Private Sub cbxPortsDist_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPortsDist.CheckedChanged
        lstPorts.DataSource = Nothing
        lstPorts.Items.Clear()
        If cbxPortsDist.Checked Then
            currentlyDist = True
            For Each st In mGroupHash("ports").getHashPorts
                lstPorts.Items.Add(st)
            Next
        Else
            currentlyDist = False
            lstPorts.DataSource = mGroupHash("ports").getOriginalPorts
        End If
    End Sub

    Private Sub cbxCorDist_CheckedChanged(sender As Object, e As EventArgs) Handles cbxCorDist.CheckedChanged
        lstCor.DataSource = Nothing
        lstCor.Items.Clear()
        If cbxCorDist.Checked Then
            currentlyDist = True
            For Each st In mGroupHash("cor").getHashCor
                lstCor.Items.Add(st)
            Next
        Else
            currentlyDist = False
            lstCor.DataSource = mGroupHash("cor").getOriginalCor
        End If
    End Sub

    Private Sub cbxCosDist_CheckedChanged(sender As Object, e As EventArgs) Handles cbxCosDist.CheckedChanged
        lstCos.DataSource = Nothing
        lstCos.Items.Clear()
        If cbxCosDist.Checked Then
            currentlyDist = True
            For Each st In mGroupHash("cos").getHashCos
                lstCos.Items.Add(st)
            Next
        Else
            currentlyDist = False
            lstCos.DataSource = mGroupHash("cos").getOriginalCos
        End If
    End Sub
#End Region

End Class

Class listManager
    Private Property distinctDataSetTypes As New HashSet(Of String)
    Private Property distinctDataExtensions As New HashSet(Of String)
    Private Property distinctDataPorts As New HashSet(Of String)
    Private Property distinctDataCor As New HashSet(Of String)
    Private Property distinctDataCos As New HashSet(Of String)
    Private Property previousDataSetTypes As New List(Of String)
    Private Property previousDataExtensions As New List(Of String)
    Private Property previousDataPorts As New List(Of String)
    Private Property previousDataCor As New List(Of String)
    Private Property previousDataCos As New List(Of String)
    'set types
#Region "Functions"
    Public Sub setOriginalSetTypes(ByVal s As String)
        previousDataSetTypes.Add(s)
    End Sub

    Function getOriginalSetTypes()
        Return previousDataSetTypes
    End Function

    Public Sub setHashSetTypes(ByVal s As String)
        distinctDataSetTypes.Add(s)
    End Sub

    Function getHashSetTypes()
        Return distinctDataSetTypes
    End Function
    'extensions
    Public Sub setOriginalExtensions(ByVal s As String)
        previousDataExtensions.Add(s)
    End Sub

    Function getOriginalExtensions()
        Return previousDataExtensions
    End Function

    Public Sub setHashExtensions(ByVal s As String)
        distinctDataExtensions.Add(s)
    End Sub

    Function getHashExtensions()
        Return distinctDataExtensions
    End Function
    'Ports
    Public Sub setOriginalPorts(ByVal s As String)
        previousDataPorts.Add(s)
    End Sub

    Function getOriginalPorts()
        Return previousDataPorts
    End Function

    Public Sub setHashPorts(ByVal s As String)
        distinctDataPorts.Add(s)
    End Sub

    Function getHashPorts()
        Return distinctDataPorts
    End Function
    'cor
    Public Sub setOriginalCor(ByVal s As String)
        previousDataCor.Add(s)
    End Sub

    Function getOriginalCor()
        Return previousDataCor
    End Function

    Public Sub setHashCor(ByVal s As String)
        distinctDataCor.Add(s)
    End Sub

    Function getHashCor()
        Return distinctDataCor
    End Function
    'Cos
    Public Sub setOriginalCos(ByVal s As String)
        previousDataCos.Add(s)
    End Sub

    Function getOriginalCos()
        Return previousDataCos
    End Function

    Public Sub setHashCos(ByVal s As String)
        distinctDataCos.Add(s)
    End Sub

    Function getHashCos()
        Return distinctDataCos
    End Function
#End Region
End Class