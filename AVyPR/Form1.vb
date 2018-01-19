
Imports System.IO
Imports System.Text.RegularExpressions
Imports AVyPR.listManager
Imports System.Threading

Public Class frmMain
    Const FIELDNAME As String = "fieldName"
    Const VALUESTRING As String = "value"
    Const VIRTUAL As String = "virtual"
    Const VIRTUAL_MSG As String = "<Virtual-No Port Assigned>"
    Const NOT_FOUND As String = "<Not Found in Switch>"

#Region "props"
    Private Property m_listManagerGroup As New Hashtable
    Private Property m_resultsFrmObj As ResultsForm
    Private prog As Object

    Private Property m_filePath As String
    Public Property GetFilePath As String
        Get
            Return m_filePath
        End Get
        Set(value As String)
            value = m_filePath
        End Set
    End Property

    Dim m_CurrentField As String
    Private Property currentField As String
        Get
            Return m_CurrentField
        End Get
        Set(value As String)
            m_CurrentField = value
        End Set
    End Property

    Dim m_FieldLastRecord As Boolean
    Private Property FieldLastRecord As Boolean
        Get
            Return m_FieldLastRecord
        End Get
        Set(value As Boolean)
            m_FieldLastRecord = value
        End Set
    End Property

    Dim m_AddingSetType As Boolean
    Private Property AddingSetType As Boolean
        Get
            Return m_AddingSetType
        End Get
        Set(value As Boolean)
            m_AddingSetType = value
        End Set
    End Property

    Dim m_AddingExtension As Boolean
    Private Property AddingExtension As Boolean
        Get
            Return m_AddingExtension
        End Get
        Set(value As Boolean)
            m_AddingExtension = value
        End Set
    End Property

    Dim m_AddingPort As Boolean
    Private Property AddingPort As Boolean
        Get
            Return m_AddingPort
        End Get
        Set(value As Boolean)
            m_AddingPort = value
        End Set
    End Property

    Dim m_AddingCor As Boolean
    Private Property AddingCor As Boolean
        Get
            Return m_AddingCor
        End Get
        Set(value As Boolean)
            m_AddingCor = value
        End Set
    End Property

    Dim m_AddingCos As Boolean
    Private Property AddingCos As Boolean
        Get
            Return m_AddingCos
        End Get
        Set(value As Boolean)
            m_AddingCos = value
        End Set
    End Property

    Private m_currentLineNum As Integer
    Public Property GetLineNum As Integer
        Get
            Return m_currentLineNum
        End Get
        Set(value As Integer)
            m_currentLineNum = value
        End Set
    End Property

    Private Property m_Finished As Boolean
    Public Property IsFinished As Boolean
        Get
            Return m_Finished
        End Get
        Set(value As Boolean)
            value = m_Finished
        End Set
    End Property

#End Region

#Region "Parsing"



    Private Sub btnParse_Click(sender As Object, e As EventArgs) Handles btnParse.Click
        m_filePath = txtPath.Text

        If Not m_filePath = "" Then
            Dim readFile As New StreamReader(m_filePath)
            Dim line As String
            Dim fieldNamePattern As String = "^\[(?<row>\d{1,2})[^;]*;\d{1,2}H\s*(?<fieldName>[\040-\071\073-\176]+)[?:]\s$"
            Dim valuePattern As String = "^\[(?<row>\d{1,2})[^;]*;\d{1,2}H\s*(?<value>[\040-\176]+)"
            Dim fieldValuePattern As String = "^\[(?<row>\d{1,2})[^;]*;\d{1,2}H\s*(?<fieldName>[\040-\071\073-\176]+)[?:]\s(?<value>[\040-\176]+)$"
            Dim writeFile As New StreamWriter("Parsed_Avaya_Set_Sync.txt")
            Dim parts() As String
            Dim m As Match
            Dim field As String
            Dim value As String
            Dim setTypeObj As New listManager
            Dim extensionObj As New listManager
            Dim portObj As New listManager
            Dim corObj As New listManager
            Dim cosObj As New listManager

            m_listManagerGroup.Add("extensions", extensionObj)
            m_listManagerGroup.Add("setTypes", setTypeObj)
            m_listManagerGroup.Add("ports", portObj)
            m_listManagerGroup.Add("cor", corObj)
            m_listManagerGroup.Add("cos", cosObj)

            'Cursor = Cursors.WaitCursor

            Me.Hide()
            'Dim prog As New progress(m_filePath)
            Try
                Do Until readFile.EndOfStream
                    line = readFile.ReadLine
                    m_currentLineNum = m_currentLineNum + 1
                    parts = Regex.Split(line, Chr(27))
                    For Each p In parts
                        If Regex.IsMatch(p, fieldValuePattern) Then
                            'FIELD/VALUE
                            m = Regex.Match(p, fieldValuePattern)
                            field = m.Groups(FIELDNAME).ToString
                            value = m.Groups(VALUESTRING).ToString
                            addRecord(writeFile, field & ": " & value, True, m_listManagerGroup)
                            FieldLastRecord = False
                        ElseIf Regex.IsMatch(p, fieldNamePattern) Then
                            'FIELD NAME
                            m = Regex.Match(p, fieldNamePattern)
                            field = m.Groups(FIELDNAME).ToString
                            addRecord(writeFile, field, False, m_listManagerGroup)
                            FieldLastRecord = True
                        ElseIf Regex.IsMatch(p, valuePattern) Then
                            'VALUE
                            m = Regex.Match(p, valuePattern)
                            value = m.Groups(VALUESTRING).ToString
                            addRecord(writeFile, value, True, m_listManagerGroup)
                            FieldLastRecord = False
                        Else
                            FieldLastRecord = False
                            'clear out before starting over
                            AddingExtension = False
                            AddingSetType = False
                            AddingCor = False
                            AddingCos = False
                            AddingPort = False
                        End If
                    Next
                Loop
            Catch ex As Exception
                MsgBox("Error: " & ex.ToString)
            Finally
                Cursor = Cursors.Arrow
                writeFile.Close()
                readFile.Close()
                m_resultsFrmObj.Visible = True
                m_Finished = True
                Me.Hide()

            End Try

        Else
            MsgBox("Please select a WOPR created Avaya File.")
        End If
    End Sub
#End Region

#Region "add record"
    Public Sub addRecord(ByVal newFile As StreamWriter, ByVal recordToAdd As String, ByVal newLine As Boolean, ByRef listManagerGroup As Hashtable)
        'add data to file
        If newLine Then
            newFile.WriteLine(recordToAdd)
        ElseIf FieldLastRecord AndAlso newLine = False Then
            newFile.WriteLine("...")
            newFile.WriteLine(recordToAdd)
        Else
            newFile.Write(recordToAdd & ": ")
        End If

        'add value to distinct list
        If AddingExtension Then
            If Trim(recordToAdd) = "" Then : recordToAdd = NOT_FOUND
            End If
            m_resultsFrmObj.lstExtensions.Items.Add(recordToAdd)
            listManagerGroup("extensions").setOriginalExtensions(recordToAdd)
            listManagerGroup("extensions").setHashExtensions(recordToAdd)
        ElseIf AddingSetType Then
            If Trim(recordToAdd) = "" Then : recordToAdd = NOT_FOUND
            End If
            m_resultsFrmObj.lstSetTypes.Items.Add(recordToAdd)
            If Trim(recordToAdd) = VIRTUAL Then
                'virtual dn do not have a port
                m_resultsFrmObj.lstPorts.Items.Add(VIRTUAL_MSG)
                listManagerGroup("ports").setOriginalPorts(VIRTUAL_MSG)
                listManagerGroup("ports").setHashPorts(VIRTUAL_MSG)
            End If
            listManagerGroup("setTypes").setOriginalSetTypes(recordToAdd)
            listManagerGroup("setTypes").setHashSetTypes(recordToAdd)
        ElseIf AddingPort Then
            If Trim(recordToAdd) = "" Then : recordToAdd = NOT_FOUND
            End If
            m_resultsFrmObj.lstPorts.Items.Add(recordToAdd)
            listManagerGroup("ports").setOriginalPorts(recordToAdd)
            listManagerGroup("ports").setHashPorts(recordToAdd)
        ElseIf AddingCor Then
            If Trim(recordToAdd) = "" Then : recordToAdd = NOT_FOUND
            End If
            m_resultsFrmObj.lstCor.Items.Add(recordToAdd)
            listManagerGroup("cor").setOriginalCor(recordToAdd)
            listManagerGroup("cor").setHashCor(recordToAdd)
        ElseIf AddingCos Then
            If Trim(recordToAdd) = "" Then : recordToAdd = NOT_FOUND
            End If
            m_resultsFrmObj.lstCos.Items.Add(recordToAdd)
            listManagerGroup("cos").setOriginalCos(recordToAdd)
            listManagerGroup("cos").setHashCos(recordToAdd)
        End If

        'clear out before starting over
        AddingExtension = False
        AddingSetType = False
        AddingCor = False
        AddingCos = False
        AddingPort = False

        'check for distinct properties
        Select Case recordToAdd
            Case "Extension"
                AddingExtension = True
            Case "Type"
                AddingSetType = True
            Case "COR"
                AddingCor = True
            Case "COS"
                AddingCos = True
            Case "Port"
                AddingPort = True
        End Select
    End Sub
#End Region

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.ShowDialog()
        txtPath.Text = OpenFileDialog1.FileName
    End Sub

    Public Sub cleanUp()
        m_resultsFrmObj.lstCor.DataSource = Nothing
        m_resultsFrmObj.lstCos.DataSource = Nothing
        m_resultsFrmObj.lstExtensions.DataSource = Nothing
        m_resultsFrmObj.lstPorts.DataSource = Nothing
        m_resultsFrmObj.lstSetTypes.DataSource = Nothing
        m_listManagerGroup.Clear()
    End Sub
    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'ResultsForm.Visible = False
        Dim results As New ResultsForm(m_listManagerGroup)
        m_resultsFrmObj = results
    End Sub

    Private Sub cbxSortResults_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSortResults.CheckedChanged
        If cbxSortResults.Checked Then
            m_resultsFrmObj.lstSetTypes.Sorted = True
            m_resultsFrmObj.lstExtensions.Sorted = True
            m_resultsFrmObj.lstCor.Sorted = True
            m_resultsFrmObj.lstCos.Sorted = True
            m_resultsFrmObj.lstPorts.Sorted = True
        Else
            m_resultsFrmObj.lstSetTypes.Sorted = False
            m_resultsFrmObj.lstExtensions.Sorted = False
            m_resultsFrmObj.lstCor.Sorted = False
            m_resultsFrmObj.lstCos.Sorted = False
            m_resultsFrmObj.lstPorts.Sorted = False
        End If
    End Sub

    Private Sub setupProgress()
        'Dim lineCount As Integer = File.ReadAllLines(m_filePath).Length

        ''prog.lblLocation.Text = m_currentLineNum
        'prog.ProgressBar1.Maximum = lineCount
        'Timer1.Enabled = True
        'Timer1.Start()
        'prog.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        prog.ProgressBar1.Value = m_currentLineNum
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        setupProgress()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)
        Timer1.Stop()
        Timer1.Enabled = False
        m_currentLineNum = 0
        prog.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub GetFormattedFileFromSwitchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetFormattedFileFromSwitchToolStripMenuItem.Click
        Dim hj As New HandJammer()
        hj.Show()
    End Sub
End Class
