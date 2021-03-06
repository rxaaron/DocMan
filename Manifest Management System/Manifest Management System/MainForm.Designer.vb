﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapNetworkDrivesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecialFunctionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitManifestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteManifestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFacilityPossibilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddControlsPossibilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFacilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorkerRefresh = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorkerOCR = New System.ComponentModel.BackgroundWorker()
        Me.tabSearch = New System.Windows.Forms.TabPage()
        Me.EditPanel = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lnkEdit = New System.Windows.Forms.LinkLabel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSearchID = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSearchFilePath = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.rtbSearchKeywords = New System.Windows.Forms.RichTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbSearchResultFacility = New System.Windows.Forms.ComboBox()
        Me.dtpSearchDateOfService = New System.Windows.Forms.DateTimePicker()
        Me.chkSearchControls = New System.Windows.Forms.CheckBox()
        Me.chkSearchCycle = New System.Windows.Forms.CheckBox()
        Me.cbSearchRouting = New System.Windows.Forms.ComboBox()
        Me.lblSearchVerifyingUser = New System.Windows.Forms.Label()
        Me.btnUpdateManifest = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SearchBrowser = New System.Windows.Forms.WebBrowser()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbSearchFacility = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpSearchFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpSearchTo = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.listSearch = New System.Windows.Forms.ListView()
        Me.tabVerify = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.VerifyBrowser = New System.Windows.Forms.WebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbVerifyFacility = New System.Windows.Forms.ComboBox()
        Me.dtpVerifyDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.chkVerifyControls = New System.Windows.Forms.CheckBox()
        Me.chkVerifyCycle = New System.Windows.Forms.CheckBox()
        Me.cbVerifyRouting = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnVerifySaveManifest = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rtbVerifyKeywords = New System.Windows.Forms.RichTextBox()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVerifyID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVerifyFilePath = New System.Windows.Forms.TextBox()
        Me.listUnverified = New System.Windows.Forms.ListView()
        Me.lblunverified = New System.Windows.Forms.Label()
        Me.btnRefreshUnverified = New System.Windows.Forms.Button()
        Me.TabControls = New System.Windows.Forms.TabControl()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFullTextSearch = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.tabSearch.SuspendLayout()
        Me.EditPanel.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tabVerify.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.SpecialFunctionsToolStripMenuItem, Me.DatabaseManagementToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshDataToolStripMenuItem, Me.MapNetworkDrivesToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RefreshDataToolStripMenuItem
        '
        Me.RefreshDataToolStripMenuItem.Name = "RefreshDataToolStripMenuItem"
        Me.RefreshDataToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.RefreshDataToolStripMenuItem.Text = "Get New Scanned Manifests"
        '
        'MapNetworkDrivesToolStripMenuItem
        '
        Me.MapNetworkDrivesToolStripMenuItem.Name = "MapNetworkDrivesToolStripMenuItem"
        Me.MapNetworkDrivesToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.MapNetworkDrivesToolStripMenuItem.Text = "Map Network Drives"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(218, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlwaysOnTopToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Settings"
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.CheckOnClick = True
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.AlwaysOnTopToolStripMenuItem.Text = "Always On Top"
        '
        'SpecialFunctionsToolStripMenuItem
        '
        Me.SpecialFunctionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SplitManifestToolStripMenuItem, Me.DeleteManifestToolStripMenuItem})
        Me.SpecialFunctionsToolStripMenuItem.Name = "SpecialFunctionsToolStripMenuItem"
        Me.SpecialFunctionsToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.SpecialFunctionsToolStripMenuItem.Text = "Special Functions"
        '
        'SplitManifestToolStripMenuItem
        '
        Me.SplitManifestToolStripMenuItem.Name = "SplitManifestToolStripMenuItem"
        Me.SplitManifestToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SplitManifestToolStripMenuItem.Text = "Split Manifest"
        '
        'DeleteManifestToolStripMenuItem
        '
        Me.DeleteManifestToolStripMenuItem.Name = "DeleteManifestToolStripMenuItem"
        Me.DeleteManifestToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.DeleteManifestToolStripMenuItem.Text = "Delete Manifest"
        '
        'DatabaseManagementToolStripMenuItem
        '
        Me.DatabaseManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFacilityPossibilityToolStripMenuItem, Me.AddControlsPossibilityToolStripMenuItem, Me.AddFacilityToolStripMenuItem, Me.TextTestToolStripMenuItem})
        Me.DatabaseManagementToolStripMenuItem.Enabled = False
        Me.DatabaseManagementToolStripMenuItem.Name = "DatabaseManagementToolStripMenuItem"
        Me.DatabaseManagementToolStripMenuItem.Size = New System.Drawing.Size(141, 20)
        Me.DatabaseManagementToolStripMenuItem.Text = "Database Management"
        '
        'AddFacilityPossibilityToolStripMenuItem
        '
        Me.AddFacilityPossibilityToolStripMenuItem.Name = "AddFacilityPossibilityToolStripMenuItem"
        Me.AddFacilityPossibilityToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AddFacilityPossibilityToolStripMenuItem.Text = "Add Facility Possibility"
        '
        'AddControlsPossibilityToolStripMenuItem
        '
        Me.AddControlsPossibilityToolStripMenuItem.Name = "AddControlsPossibilityToolStripMenuItem"
        Me.AddControlsPossibilityToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AddControlsPossibilityToolStripMenuItem.Text = "Add Controls Possibility"
        '
        'AddFacilityToolStripMenuItem
        '
        Me.AddFacilityToolStripMenuItem.Name = "AddFacilityToolStripMenuItem"
        Me.AddFacilityToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AddFacilityToolStripMenuItem.Text = "Add Facility"
        '
        'TextTestToolStripMenuItem
        '
        Me.TextTestToolStripMenuItem.Name = "TextTestToolStripMenuItem"
        Me.TextTestToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.TextTestToolStripMenuItem.Text = "OCR Text"
        '
        'BackgroundWorkerRefresh
        '
        Me.BackgroundWorkerRefresh.WorkerReportsProgress = True
        '
        'BackgroundWorkerOCR
        '
        Me.BackgroundWorkerOCR.WorkerReportsProgress = True
        '
        'tabSearch
        '
        Me.tabSearch.AutoScroll = True
        Me.tabSearch.Controls.Add(Me.SplitContainer2)
        Me.tabSearch.Controls.Add(Me.EditPanel)
        Me.tabSearch.Location = New System.Drawing.Point(4, 22)
        Me.tabSearch.Name = "tabSearch"
        Me.tabSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSearch.Size = New System.Drawing.Size(1176, 637)
        Me.tabSearch.TabIndex = 1
        Me.tabSearch.Text = "Search Manifests"
        Me.tabSearch.UseVisualStyleBackColor = True
        '
        'EditPanel
        '
        Me.EditPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditPanel.BackColor = System.Drawing.Color.DarkGray
        Me.EditPanel.Controls.Add(Me.btnUpdateManifest)
        Me.EditPanel.Controls.Add(Me.lblSearchVerifyingUser)
        Me.EditPanel.Controls.Add(Me.cbSearchRouting)
        Me.EditPanel.Controls.Add(Me.chkSearchCycle)
        Me.EditPanel.Controls.Add(Me.chkSearchControls)
        Me.EditPanel.Controls.Add(Me.dtpSearchDateOfService)
        Me.EditPanel.Controls.Add(Me.cbSearchResultFacility)
        Me.EditPanel.Controls.Add(Me.Label20)
        Me.EditPanel.Controls.Add(Me.Label18)
        Me.EditPanel.Controls.Add(Me.Label17)
        Me.EditPanel.Controls.Add(Me.Label16)
        Me.EditPanel.Controls.Add(Me.rtbSearchKeywords)
        Me.EditPanel.Controls.Add(Me.Label15)
        Me.EditPanel.Controls.Add(Me.txtSearchFilePath)
        Me.EditPanel.Controls.Add(Me.Label14)
        Me.EditPanel.Controls.Add(Me.lblSearchID)
        Me.EditPanel.Controls.Add(Me.Label13)
        Me.EditPanel.Controls.Add(Me.lnkEdit)
        Me.EditPanel.Controls.Add(Me.Label12)
        Me.EditPanel.Location = New System.Drawing.Point(962, 3)
        Me.EditPanel.Name = "EditPanel"
        Me.EditPanel.Size = New System.Drawing.Size(209, 626)
        Me.EditPanel.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 2)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "File Statistics"
        '
        'lnkEdit
        '
        Me.lnkEdit.AutoSize = True
        Me.lnkEdit.LinkColor = System.Drawing.Color.Blue
        Me.lnkEdit.Location = New System.Drawing.Point(127, 6)
        Me.lnkEdit.Name = "lnkEdit"
        Me.lnkEdit.Size = New System.Drawing.Size(24, 13)
        Me.lnkEdit.TabIndex = 3
        Me.lnkEdit.TabStop = True
        Me.lnkEdit.Text = "edit"
        Me.lnkEdit.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Database ID: "
        '
        'lblSearchID
        '
        Me.lblSearchID.AutoSize = True
        Me.lblSearchID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchID.Location = New System.Drawing.Point(83, 30)
        Me.lblSearchID.Name = "lblSearchID"
        Me.lblSearchID.Size = New System.Drawing.Size(15, 13)
        Me.lblSearchID.TabIndex = 5
        Me.lblSearchID.Text = "--"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "File Path:"
        '
        'txtSearchFilePath
        '
        Me.txtSearchFilePath.Location = New System.Drawing.Point(61, 46)
        Me.txtSearchFilePath.Name = "txtSearchFilePath"
        Me.txtSearchFilePath.ReadOnly = True
        Me.txtSearchFilePath.Size = New System.Drawing.Size(145, 20)
        Me.txtSearchFilePath.TabIndex = 7
        Me.txtSearchFilePath.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Keywords:"
        '
        'rtbSearchKeywords
        '
        Me.rtbSearchKeywords.Location = New System.Drawing.Point(7, 90)
        Me.rtbSearchKeywords.Name = "rtbSearchKeywords"
        Me.rtbSearchKeywords.ReadOnly = True
        Me.rtbSearchKeywords.Size = New System.Drawing.Size(199, 39)
        Me.rtbSearchKeywords.TabIndex = 9
        Me.rtbSearchKeywords.TabStop = False
        Me.rtbSearchKeywords.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(58, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Facility:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(19, 168)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Date of Service:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(17, 237)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 13)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Sent/Received:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(23, 261)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Verfiying User:"
        '
        'cbSearchResultFacility
        '
        Me.cbSearchResultFacility.Enabled = False
        Me.cbSearchResultFacility.FormattingEnabled = True
        Me.cbSearchResultFacility.Location = New System.Drawing.Point(109, 135)
        Me.cbSearchResultFacility.Name = "cbSearchResultFacility"
        Me.cbSearchResultFacility.Size = New System.Drawing.Size(97, 21)
        Me.cbSearchResultFacility.TabIndex = 11
        '
        'dtpSearchDateOfService
        '
        Me.dtpSearchDateOfService.Enabled = False
        Me.dtpSearchDateOfService.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSearchDateOfService.Location = New System.Drawing.Point(109, 162)
        Me.dtpSearchDateOfService.Name = "dtpSearchDateOfService"
        Me.dtpSearchDateOfService.Size = New System.Drawing.Size(97, 20)
        Me.dtpSearchDateOfService.TabIndex = 12
        '
        'chkSearchControls
        '
        Me.chkSearchControls.AutoSize = True
        Me.chkSearchControls.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSearchControls.Enabled = False
        Me.chkSearchControls.Location = New System.Drawing.Point(3, 188)
        Me.chkSearchControls.Name = "chkSearchControls"
        Me.chkSearchControls.Size = New System.Drawing.Size(119, 17)
        Me.chkSearchControls.TabIndex = 13
        Me.chkSearchControls.Text = "Controlled Manifest:"
        Me.chkSearchControls.UseVisualStyleBackColor = True
        '
        'chkSearchCycle
        '
        Me.chkSearchCycle.AutoSize = True
        Me.chkSearchCycle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSearchCycle.Enabled = False
        Me.chkSearchCycle.Location = New System.Drawing.Point(24, 211)
        Me.chkSearchCycle.Name = "chkSearchCycle"
        Me.chkSearchCycle.Size = New System.Drawing.Size(98, 17)
        Me.chkSearchCycle.TabIndex = 13
        Me.chkSearchCycle.Text = "Cycle Manifest:"
        Me.chkSearchCycle.UseVisualStyleBackColor = True
        '
        'cbSearchRouting
        '
        Me.cbSearchRouting.Enabled = False
        Me.cbSearchRouting.FormattingEnabled = True
        Me.cbSearchRouting.Location = New System.Drawing.Point(109, 234)
        Me.cbSearchRouting.Name = "cbSearchRouting"
        Me.cbSearchRouting.Size = New System.Drawing.Size(97, 21)
        Me.cbSearchRouting.TabIndex = 14
        '
        'lblSearchVerifyingUser
        '
        Me.lblSearchVerifyingUser.AutoSize = True
        Me.lblSearchVerifyingUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchVerifyingUser.Location = New System.Drawing.Point(107, 261)
        Me.lblSearchVerifyingUser.Name = "lblSearchVerifyingUser"
        Me.lblSearchVerifyingUser.Size = New System.Drawing.Size(15, 13)
        Me.lblSearchVerifyingUser.TabIndex = 15
        Me.lblSearchVerifyingUser.Text = "--"
        '
        'btnUpdateManifest
        '
        Me.btnUpdateManifest.Enabled = False
        Me.btnUpdateManifest.Location = New System.Drawing.Point(7, 287)
        Me.btnUpdateManifest.Name = "btnUpdateManifest"
        Me.btnUpdateManifest.Size = New System.Drawing.Size(198, 46)
        Me.btnUpdateManifest.TabIndex = 16
        Me.btnUpdateManifest.Text = "Update Manifest"
        Me.btnUpdateManifest.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.SplitContainer2.Panel1.Controls.Add(Me.listSearch)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label19)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SearchBrowser)
        Me.SplitContainer2.Size = New System.Drawing.Size(959, 634)
        Me.SplitContainer2.SplitterDistance = 284
        Me.SplitContainer2.TabIndex = 5
        '
        'SearchBrowser
        '
        Me.SearchBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchBrowser.Location = New System.Drawing.Point(0, 0)
        Me.SearchBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.SearchBrowser.Name = "SearchBrowser"
        Me.SearchBrowser.Size = New System.Drawing.Size(671, 634)
        Me.SearchBrowser.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txtFullTextSearch)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Controls.Add(Me.dtpSearchTo)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.dtpSearchFrom)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.cbSearchFacility)
        Me.Panel3.Location = New System.Drawing.Point(6, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(275, 203)
        Me.Panel3.TabIndex = 0
        '
        'cbSearchFacility
        '
        Me.cbSearchFacility.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSearchFacility.FormattingEnabled = True
        Me.cbSearchFacility.Location = New System.Drawing.Point(106, 3)
        Me.cbSearchFacility.Name = "cbSearchFacility"
        Me.cbSearchFacility.Size = New System.Drawing.Size(166, 21)
        Me.cbSearchFacility.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Choose Facility:"
        '
        'dtpSearchFrom
        '
        Me.dtpSearchFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpSearchFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSearchFrom.Location = New System.Drawing.Point(7, 46)
        Me.dtpSearchFrom.Name = "dtpSearchFrom"
        Me.dtpSearchFrom.Size = New System.Drawing.Size(265, 20)
        Me.dtpSearchFrom.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "From"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 17)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "To"
        '
        'dtpSearchTo
        '
        Me.dtpSearchTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpSearchTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSearchTo.Location = New System.Drawing.Point(7, 89)
        Me.dtpSearchTo.Name = "dtpSearchTo"
        Me.dtpSearchTo.Size = New System.Drawing.Size(265, 20)
        Me.dtpSearchTo.TabIndex = 7
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(6, 160)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(266, 38)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search Manifests"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 214)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(197, 13)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "* unverified manifest, please look closely"
        '
        'listSearch
        '
        Me.listSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listSearch.HideSelection = False
        Me.listSearch.Location = New System.Drawing.Point(6, 230)
        Me.listSearch.MultiSelect = False
        Me.listSearch.Name = "listSearch"
        Me.listSearch.Size = New System.Drawing.Size(275, 401)
        Me.listSearch.TabIndex = 1
        Me.listSearch.UseCompatibleStateImageBehavior = False
        '
        'tabVerify
        '
        Me.tabVerify.AutoScroll = True
        Me.tabVerify.Controls.Add(Me.SplitContainer1)
        Me.tabVerify.Location = New System.Drawing.Point(4, 22)
        Me.tabVerify.Name = "tabVerify"
        Me.tabVerify.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVerify.Size = New System.Drawing.Size(1176, 637)
        Me.tabVerify.TabIndex = 0
        Me.tabVerify.Text = "Verify New Manifests"
        Me.tabVerify.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRefreshUnverified)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblunverified)
        Me.SplitContainer1.Panel1.Controls.Add(Me.listUnverified)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.VerifyBrowser)
        Me.SplitContainer1.Size = New System.Drawing.Size(1170, 631)
        Me.SplitContainer1.SplitterDistance = 298
        Me.SplitContainer1.TabIndex = 7
        '
        'VerifyBrowser
        '
        Me.VerifyBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VerifyBrowser.Location = New System.Drawing.Point(0, 0)
        Me.VerifyBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.VerifyBrowser.Name = "VerifyBrowser"
        Me.VerifyBrowser.Size = New System.Drawing.Size(868, 631)
        Me.VerifyBrowser.TabIndex = 2
        Me.VerifyBrowser.WebBrowserShortcutsEnabled = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnVerifySaveManifest)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cbVerifyRouting)
        Me.Panel1.Controls.Add(Me.chkVerifyCycle)
        Me.Panel1.Controls.Add(Me.chkVerifyControls)
        Me.Panel1.Controls.Add(Me.dtpVerifyDeliveryDate)
        Me.Panel1.Controls.Add(Me.cbVerifyFacility)
        Me.Panel1.Location = New System.Drawing.Point(5, 280)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 213)
        Me.Panel1.TabIndex = 4
        '
        'cbVerifyFacility
        '
        Me.cbVerifyFacility.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbVerifyFacility.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbVerifyFacility.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbVerifyFacility.FormattingEnabled = True
        Me.cbVerifyFacility.Location = New System.Drawing.Point(55, 21)
        Me.cbVerifyFacility.Name = "cbVerifyFacility"
        Me.cbVerifyFacility.Size = New System.Drawing.Size(231, 21)
        Me.cbVerifyFacility.TabIndex = 1
        '
        'dtpVerifyDeliveryDate
        '
        Me.dtpVerifyDeliveryDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpVerifyDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVerifyDeliveryDate.Location = New System.Drawing.Point(97, 48)
        Me.dtpVerifyDeliveryDate.Name = "dtpVerifyDeliveryDate"
        Me.dtpVerifyDeliveryDate.Size = New System.Drawing.Size(189, 20)
        Me.dtpVerifyDeliveryDate.TabIndex = 2
        Me.dtpVerifyDeliveryDate.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'chkVerifyControls
        '
        Me.chkVerifyControls.AutoSize = True
        Me.chkVerifyControls.Location = New System.Drawing.Point(10, 74)
        Me.chkVerifyControls.Name = "chkVerifyControls"
        Me.chkVerifyControls.Size = New System.Drawing.Size(116, 17)
        Me.chkVerifyControls.TabIndex = 3
        Me.chkVerifyControls.Text = "Controlled Manifest"
        Me.chkVerifyControls.UseVisualStyleBackColor = True
        '
        'chkVerifyCycle
        '
        Me.chkVerifyCycle.AutoSize = True
        Me.chkVerifyCycle.Location = New System.Drawing.Point(10, 97)
        Me.chkVerifyCycle.Name = "chkVerifyCycle"
        Me.chkVerifyCycle.Size = New System.Drawing.Size(95, 17)
        Me.chkVerifyCycle.TabIndex = 4
        Me.chkVerifyCycle.Text = "Cycle Manifest"
        Me.chkVerifyCycle.UseVisualStyleBackColor = True
        '
        'cbVerifyRouting
        '
        Me.cbVerifyRouting.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbVerifyRouting.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbVerifyRouting.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbVerifyRouting.FormattingEnabled = True
        Me.cbVerifyRouting.Location = New System.Drawing.Point(96, 120)
        Me.cbVerifyRouting.Name = "cbVerifyRouting"
        Me.cbVerifyRouting.Size = New System.Drawing.Size(190, 21)
        Me.cbVerifyRouting.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Manifest Data"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Facility:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date of Service:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Sent/Received:"
        '
        'btnVerifySaveManifest
        '
        Me.btnVerifySaveManifest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVerifySaveManifest.Location = New System.Drawing.Point(3, 152)
        Me.btnVerifySaveManifest.Name = "btnVerifySaveManifest"
        Me.btnVerifySaveManifest.Size = New System.Drawing.Size(283, 58)
        Me.btnVerifySaveManifest.TabIndex = 12
        Me.btnVerifySaveManifest.Text = "Save Manifest"
        Me.btnVerifySaveManifest.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.txtVerifyFilePath)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblVerifyID)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label0)
        Me.Panel2.Controls.Add(Me.rtbVerifyKeywords)
        Me.Panel2.Location = New System.Drawing.Point(5, 499)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(286, 129)
        Me.Panel2.TabIndex = 5
        '
        'rtbVerifyKeywords
        '
        Me.rtbVerifyKeywords.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbVerifyKeywords.Location = New System.Drawing.Point(3, 72)
        Me.rtbVerifyKeywords.Name = "rtbVerifyKeywords"
        Me.rtbVerifyKeywords.ReadOnly = True
        Me.rtbVerifyKeywords.Size = New System.Drawing.Size(280, 50)
        Me.rtbVerifyKeywords.TabIndex = 0
        Me.rtbVerifyKeywords.TabStop = False
        Me.rtbVerifyKeywords.Text = ""
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label0.Location = New System.Drawing.Point(-1, 0)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(118, 20)
        Me.Label0.TabIndex = 1
        Me.Label0.Text = "File Statistics"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Database ID:"
        '
        'lblVerifyID
        '
        Me.lblVerifyID.AutoSize = True
        Me.lblVerifyID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerifyID.Location = New System.Drawing.Point(79, 20)
        Me.lblVerifyID.Name = "lblVerifyID"
        Me.lblVerifyID.Size = New System.Drawing.Size(15, 13)
        Me.lblVerifyID.TabIndex = 3
        Me.lblVerifyID.Text = "--"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "File Path:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Keywords:"
        '
        'txtVerifyFilePath
        '
        Me.txtVerifyFilePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVerifyFilePath.Location = New System.Drawing.Point(61, 37)
        Me.txtVerifyFilePath.Name = "txtVerifyFilePath"
        Me.txtVerifyFilePath.ReadOnly = True
        Me.txtVerifyFilePath.Size = New System.Drawing.Size(222, 20)
        Me.txtVerifyFilePath.TabIndex = 7
        Me.txtVerifyFilePath.TabStop = False
        '
        'listUnverified
        '
        Me.listUnverified.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listUnverified.HideSelection = False
        Me.listUnverified.Location = New System.Drawing.Point(5, 32)
        Me.listUnverified.MultiSelect = False
        Me.listUnverified.Name = "listUnverified"
        Me.listUnverified.Size = New System.Drawing.Size(289, 242)
        Me.listUnverified.TabIndex = 0
        Me.listUnverified.UseCompatibleStateImageBehavior = False
        Me.listUnverified.View = System.Windows.Forms.View.Details
        '
        'lblunverified
        '
        Me.lblunverified.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblunverified.Location = New System.Drawing.Point(260, 3)
        Me.lblunverified.Name = "lblunverified"
        Me.lblunverified.Size = New System.Drawing.Size(34, 23)
        Me.lblunverified.TabIndex = 6
        Me.lblunverified.Text = "----"
        Me.lblunverified.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRefreshUnverified
        '
        Me.btnRefreshUnverified.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshUnverified.Location = New System.Drawing.Point(5, 3)
        Me.btnRefreshUnverified.Name = "btnRefreshUnverified"
        Me.btnRefreshUnverified.Size = New System.Drawing.Size(249, 23)
        Me.btnRefreshUnverified.TabIndex = 1
        Me.btnRefreshUnverified.Text = "Refresh List"
        Me.btnRefreshUnverified.UseVisualStyleBackColor = True
        '
        'TabControls
        '
        Me.TabControls.Controls.Add(Me.tabVerify)
        Me.TabControls.Controls.Add(Me.tabSearch)
        Me.TabControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControls.Location = New System.Drawing.Point(0, 24)
        Me.TabControls.Name = "TabControls"
        Me.TabControls.SelectedIndex = 0
        Me.TabControls.Size = New System.Drawing.Size(1184, 663)
        Me.TabControls.TabIndex = 0
        Me.TabControls.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Search Text:"
        '
        'txtFullTextSearch
        '
        Me.txtFullTextSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFullTextSearch.Location = New System.Drawing.Point(6, 133)
        Me.txtFullTextSearch.Name = "txtFullTextSearch"
        Me.txtFullTextSearch.Size = New System.Drawing.Size(266, 20)
        Me.txtFullTextSearch.TabIndex = 10
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 687)
        Me.Controls.Add(Me.TabControls)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Manifest Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabSearch.ResumeLayout(False)
        Me.EditPanel.ResumeLayout(False)
        Me.EditPanel.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tabVerify.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControls.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MapNetworkDrivesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlwaysOnTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpecialFunctionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitManifestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteManifestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddFacilityPossibilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddControlsPossibilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddFacilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorkerRefresh As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextTestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorkerOCR As System.ComponentModel.BackgroundWorker
    Friend WithEvents tabSearch As TabPage
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents listSearch As ListView
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents dtpSearchTo As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpSearchFrom As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents cbSearchFacility As ComboBox
    Friend WithEvents SearchBrowser As WebBrowser
    Friend WithEvents EditPanel As Panel
    Friend WithEvents btnUpdateManifest As Button
    Friend WithEvents lblSearchVerifyingUser As Label
    Friend WithEvents cbSearchRouting As ComboBox
    Friend WithEvents chkSearchCycle As CheckBox
    Friend WithEvents chkSearchControls As CheckBox
    Friend WithEvents dtpSearchDateOfService As DateTimePicker
    Friend WithEvents cbSearchResultFacility As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents rtbSearchKeywords As RichTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSearchFilePath As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblSearchID As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lnkEdit As LinkLabel
    Friend WithEvents Label12 As Label
    Friend WithEvents tabVerify As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnRefreshUnverified As Button
    Friend WithEvents lblunverified As Label
    Friend WithEvents listUnverified As ListView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtVerifyFilePath As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblVerifyID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label0 As Label
    Friend WithEvents rtbVerifyKeywords As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVerifySaveManifest As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbVerifyRouting As ComboBox
    Friend WithEvents chkVerifyCycle As CheckBox
    Friend WithEvents chkVerifyControls As CheckBox
    Friend WithEvents dtpVerifyDeliveryDate As DateTimePicker
    Friend WithEvents cbVerifyFacility As ComboBox
    Friend WithEvents VerifyBrowser As WebBrowser
    Friend WithEvents TabControls As TabControl
    Friend WithEvents txtFullTextSearch As TextBox
    Friend WithEvents Label9 As Label
End Class
