<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResultsForm))
        Me.lstSetTypes = New System.Windows.Forms.ListBox()
        Me.lstExtensions = New System.Windows.Forms.ListBox()
        Me.lstCor = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstCos = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.lstPorts = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cbxSetTypesDist = New System.Windows.Forms.CheckBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.cbxExtensionDist = New System.Windows.Forms.CheckBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.cbxPortsDist = New System.Windows.Forms.CheckBox()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.cbxCorDist = New System.Windows.Forms.CheckBox()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.cbxCosDist = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewParsingFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveListToCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstSetTypes
        '
        Me.lstSetTypes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstSetTypes.Font = New System.Drawing.Font("HelveticaNeueLT Std", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSetTypes.FormattingEnabled = True
        Me.lstSetTypes.ItemHeight = 19
        Me.lstSetTypes.Location = New System.Drawing.Point(0, 3)
        Me.lstSetTypes.Name = "lstSetTypes"
        Me.lstSetTypes.Size = New System.Drawing.Size(219, 650)
        Me.lstSetTypes.TabIndex = 3
        '
        'lstExtensions
        '
        Me.lstExtensions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstExtensions.Font = New System.Drawing.Font("HelveticaNeueLT Std", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstExtensions.FormattingEnabled = True
        Me.lstExtensions.ItemHeight = 19
        Me.lstExtensions.Location = New System.Drawing.Point(0, 3)
        Me.lstExtensions.Name = "lstExtensions"
        Me.lstExtensions.Size = New System.Drawing.Size(219, 650)
        Me.lstExtensions.TabIndex = 3
        '
        'lstCor
        '
        Me.lstCor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstCor.Font = New System.Drawing.Font("HelveticaNeueLT Std", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCor.FormattingEnabled = True
        Me.lstCor.ItemHeight = 19
        Me.lstCor.Location = New System.Drawing.Point(0, 3)
        Me.lstCor.Name = "lstCor"
        Me.lstCor.Size = New System.Drawing.Size(219, 650)
        Me.lstCor.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HelveticaNeueLT Std", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Set Types"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("HelveticaNeueLT Std", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Extensions"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("HelveticaNeueLT Std", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "COR"
        '
        'lstCos
        '
        Me.lstCos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstCos.Font = New System.Drawing.Font("HelveticaNeueLT Std", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCos.FormattingEnabled = True
        Me.lstCos.ItemHeight = 19
        Me.lstCos.Location = New System.Drawing.Point(0, 3)
        Me.lstCos.Name = "lstCos"
        Me.lstCos.Size = New System.Drawing.Size(219, 650)
        Me.lstCos.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("HelveticaNeueLT Std", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "COS"
        '
        'lstPorts
        '
        Me.lstPorts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPorts.Font = New System.Drawing.Font("HelveticaNeueLT Std", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPorts.FormattingEnabled = True
        Me.lstPorts.ItemHeight = 19
        Me.lstPorts.Location = New System.Drawing.Point(0, 3)
        Me.lstPorts.Name = "lstPorts"
        Me.lstPorts.Size = New System.Drawing.Size(219, 650)
        Me.lstPorts.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("HelveticaNeueLT Std", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(71, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ports"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbxSetTypesDist)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lstSetTypes)
        Me.SplitContainer1.Size = New System.Drawing.Size(233, 700)
        Me.SplitContainer1.SplitterDistance = 40
        Me.SplitContainer1.TabIndex = 5
        '
        'cbxSetTypesDist
        '
        Me.cbxSetTypesDist.AutoSize = True
        Me.cbxSetTypesDist.Location = New System.Drawing.Point(146, 13)
        Me.cbxSetTypesDist.Name = "cbxSetTypesDist"
        Me.cbxSetTypesDist.Size = New System.Drawing.Size(62, 17)
        Me.cbxSetTypesDist.TabIndex = 5
        Me.cbxSetTypesDist.Text = "Distinct"
        Me.cbxSetTypesDist.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(233, 24)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbxExtensionDist)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lstExtensions)
        Me.SplitContainer2.Size = New System.Drawing.Size(233, 700)
        Me.SplitContainer2.SplitterDistance = 40
        Me.SplitContainer2.TabIndex = 6
        '
        'cbxExtensionDist
        '
        Me.cbxExtensionDist.AutoSize = True
        Me.cbxExtensionDist.Location = New System.Drawing.Point(165, 14)
        Me.cbxExtensionDist.Name = "cbxExtensionDist"
        Me.cbxExtensionDist.Size = New System.Drawing.Size(62, 17)
        Me.cbxExtensionDist.TabIndex = 5
        Me.cbxExtensionDist.Text = "Distinct"
        Me.cbxExtensionDist.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer3.Location = New System.Drawing.Point(466, 24)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.cbxPortsDist)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label5)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.lstPorts)
        Me.SplitContainer3.Size = New System.Drawing.Size(233, 700)
        Me.SplitContainer3.SplitterDistance = 40
        Me.SplitContainer3.TabIndex = 6
        '
        'cbxPortsDist
        '
        Me.cbxPortsDist.AutoSize = True
        Me.cbxPortsDist.Location = New System.Drawing.Point(150, 14)
        Me.cbxPortsDist.Name = "cbxPortsDist"
        Me.cbxPortsDist.Size = New System.Drawing.Size(62, 17)
        Me.cbxPortsDist.TabIndex = 5
        Me.cbxPortsDist.Text = "Distinct"
        Me.cbxPortsDist.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer4.Location = New System.Drawing.Point(699, 24)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.cbxCorDist)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.lstCor)
        Me.SplitContainer4.Size = New System.Drawing.Size(233, 700)
        Me.SplitContainer4.SplitterDistance = 40
        Me.SplitContainer4.TabIndex = 6
        '
        'cbxCorDist
        '
        Me.cbxCorDist.AutoSize = True
        Me.cbxCorDist.Location = New System.Drawing.Point(147, 14)
        Me.cbxCorDist.Name = "cbxCorDist"
        Me.cbxCorDist.Size = New System.Drawing.Size(62, 17)
        Me.cbxCorDist.TabIndex = 5
        Me.cbxCorDist.Text = "Distinct"
        Me.cbxCorDist.UseVisualStyleBackColor = True
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer5.Location = New System.Drawing.Point(932, 24)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.cbxCosDist)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.lstCos)
        Me.SplitContainer5.Size = New System.Drawing.Size(233, 700)
        Me.SplitContainer5.SplitterDistance = 40
        Me.SplitContainer5.TabIndex = 6
        '
        'cbxCosDist
        '
        Me.cbxCosDist.AutoSize = True
        Me.cbxCosDist.Location = New System.Drawing.Point(148, 13)
        Me.cbxCosDist.Name = "cbxCosDist"
        Me.cbxCosDist.Size = New System.Drawing.Size(62, 17)
        Me.cbxCosDist.TabIndex = 5
        Me.cbxCosDist.Text = "Distinct"
        Me.cbxCosDist.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("HelveticaNeueLT Std", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1252, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewParsingFileToolStripMenuItem, Me.SaveListToCSVToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewParsingFileToolStripMenuItem
        '
        Me.NewParsingFileToolStripMenuItem.Name = "NewParsingFileToolStripMenuItem"
        Me.NewParsingFileToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.NewParsingFileToolStripMenuItem.Text = "&Open Parsed File Location"
        '
        'SaveListToCSVToolStripMenuItem
        '
        Me.SaveListToCSVToolStripMenuItem.Name = "SaveListToCSVToolStripMenuItem"
        Me.SaveListToCSVToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.SaveListToCSVToolStripMenuItem.Text = "&Save List To .CSV"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'ResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 724)
        Me.Controls.Add(Me.SplitContainer5)
        Me.Controls.Add(Me.SplitContainer4)
        Me.Controls.Add(Me.SplitContainer3)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("HelveticaNeueLT Std", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1184, 39)
        Me.Name = "ResultsForm"
        Me.Text = "Results"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.PerformLayout()
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstSetTypes As System.Windows.Forms.ListBox
    Friend WithEvents lstExtensions As System.Windows.Forms.ListBox
    Friend WithEvents lstCor As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstCos As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lstPorts As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewParsingFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveListToCSVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbxSetTypesDist As System.Windows.Forms.CheckBox
    Friend WithEvents cbxExtensionDist As System.Windows.Forms.CheckBox
    Friend WithEvents cbxPortsDist As System.Windows.Forms.CheckBox
    Friend WithEvents cbxCorDist As System.Windows.Forms.CheckBox
    Friend WithEvents cbxCosDist As System.Windows.Forms.CheckBox
End Class
