<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.TabControls = New System.Windows.Forms.TabControl()
        Me.tabVerify = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtVerifyFilePath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblVerifyID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.rtbVerifyKeywords = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVerifySaveManifest = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbVerifyRouting = New System.Windows.Forms.ComboBox()
        Me.chkVerifyCycle = New System.Windows.Forms.CheckBox()
        Me.chkVerifyControls = New System.Windows.Forms.CheckBox()
        Me.dtpVerifyDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.cbVerifyFacility = New System.Windows.Forms.ComboBox()
        Me.VerifyBrowser = New System.Windows.Forms.WebBrowser()
        Me.btnRefreshUnverified = New System.Windows.Forms.Button()
        Me.listUnverified = New System.Windows.Forms.ListView()
        Me.tabSearch = New System.Windows.Forms.TabPage()
        Me.EditPanel = New System.Windows.Forms.Panel()
        Me.rtbSearchKeywords = New System.Windows.Forms.RichTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSearchFilePath = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblSearchID = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lnkEdit = New System.Windows.Forms.LinkLabel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SearchBrowser = New System.Windows.Forms.WebBrowser()
        Me.listSearch = New System.Windows.Forms.ListView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dtpSearchTo = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpSearchFrom = New System.Windows.Forms.DateTimePicker()
        Me.chkAllFacilities = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbSearchFacility = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapNetworkDrivesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabControls.SuspendLayout()
        Me.tabVerify.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tabSearch.SuspendLayout()
        Me.EditPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'tabVerify
        '
        Me.tabVerify.AutoScroll = True
        Me.tabVerify.Controls.Add(Me.Panel2)
        Me.tabVerify.Controls.Add(Me.Panel1)
        Me.tabVerify.Controls.Add(Me.VerifyBrowser)
        Me.tabVerify.Controls.Add(Me.btnRefreshUnverified)
        Me.tabVerify.Controls.Add(Me.listUnverified)
        Me.tabVerify.Location = New System.Drawing.Point(4, 22)
        Me.tabVerify.Name = "tabVerify"
        Me.tabVerify.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVerify.Size = New System.Drawing.Size(1176, 637)
        Me.tabVerify.TabIndex = 0
        Me.tabVerify.Text = "Verify New Manifests"
        Me.tabVerify.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.txtVerifyFilePath)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblVerifyID)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label0)
        Me.Panel2.Controls.Add(Me.rtbVerifyKeywords)
        Me.Panel2.Location = New System.Drawing.Point(8, 502)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(241, 129)
        Me.Panel2.TabIndex = 5
        '
        'txtVerifyFilePath
        '
        Me.txtVerifyFilePath.Location = New System.Drawing.Point(61, 37)
        Me.txtVerifyFilePath.Name = "txtVerifyFilePath"
        Me.txtVerifyFilePath.ReadOnly = True
        Me.txtVerifyFilePath.Size = New System.Drawing.Size(177, 20)
        Me.txtVerifyFilePath.TabIndex = 7
        Me.txtVerifyFilePath.TabStop = False
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "File Path:"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Database ID:"
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
        'rtbVerifyKeywords
        '
        Me.rtbVerifyKeywords.Location = New System.Drawing.Point(3, 72)
        Me.rtbVerifyKeywords.Name = "rtbVerifyKeywords"
        Me.rtbVerifyKeywords.ReadOnly = True
        Me.rtbVerifyKeywords.Size = New System.Drawing.Size(235, 50)
        Me.rtbVerifyKeywords.TabIndex = 0
        Me.rtbVerifyKeywords.TabStop = False
        Me.rtbVerifyKeywords.Text = ""
        '
        'Panel1
        '
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
        Me.Panel1.Location = New System.Drawing.Point(8, 283)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(241, 213)
        Me.Panel1.TabIndex = 4
        '
        'btnVerifySaveManifest
        '
        Me.btnVerifySaveManifest.Location = New System.Drawing.Point(3, 152)
        Me.btnVerifySaveManifest.Name = "btnVerifySaveManifest"
        Me.btnVerifySaveManifest.Size = New System.Drawing.Size(235, 58)
        Me.btnVerifySaveManifest.TabIndex = 12
        Me.btnVerifySaveManifest.Text = "Save Manifest"
        Me.btnVerifySaveManifest.UseVisualStyleBackColor = True
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date of Service:"
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
        'cbVerifyRouting
        '
        Me.cbVerifyRouting.FormattingEnabled = True
        Me.cbVerifyRouting.Location = New System.Drawing.Point(96, 120)
        Me.cbVerifyRouting.Name = "cbVerifyRouting"
        Me.cbVerifyRouting.Size = New System.Drawing.Size(142, 21)
        Me.cbVerifyRouting.TabIndex = 5
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
        'dtpVerifyDeliveryDate
        '
        Me.dtpVerifyDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVerifyDeliveryDate.Location = New System.Drawing.Point(97, 48)
        Me.dtpVerifyDeliveryDate.Name = "dtpVerifyDeliveryDate"
        Me.dtpVerifyDeliveryDate.Size = New System.Drawing.Size(141, 20)
        Me.dtpVerifyDeliveryDate.TabIndex = 2
        Me.dtpVerifyDeliveryDate.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'cbVerifyFacility
        '
        Me.cbVerifyFacility.FormattingEnabled = True
        Me.cbVerifyFacility.Location = New System.Drawing.Point(55, 21)
        Me.cbVerifyFacility.Name = "cbVerifyFacility"
        Me.cbVerifyFacility.Size = New System.Drawing.Size(183, 21)
        Me.cbVerifyFacility.TabIndex = 1
        '
        'VerifyBrowser
        '
        Me.VerifyBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VerifyBrowser.Location = New System.Drawing.Point(255, 6)
        Me.VerifyBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.VerifyBrowser.Name = "VerifyBrowser"
        Me.VerifyBrowser.Size = New System.Drawing.Size(913, 623)
        Me.VerifyBrowser.TabIndex = 2
        Me.VerifyBrowser.WebBrowserShortcutsEnabled = False
        '
        'btnRefreshUnverified
        '
        Me.btnRefreshUnverified.Location = New System.Drawing.Point(8, 6)
        Me.btnRefreshUnverified.Name = "btnRefreshUnverified"
        Me.btnRefreshUnverified.Size = New System.Drawing.Size(241, 23)
        Me.btnRefreshUnverified.TabIndex = 1
        Me.btnRefreshUnverified.Text = "Refresh List"
        Me.btnRefreshUnverified.UseVisualStyleBackColor = True
        '
        'listUnverified
        '
        Me.listUnverified.Location = New System.Drawing.Point(8, 35)
        Me.listUnverified.MultiSelect = False
        Me.listUnverified.Name = "listUnverified"
        Me.listUnverified.Size = New System.Drawing.Size(241, 242)
        Me.listUnverified.TabIndex = 0
        Me.listUnverified.UseCompatibleStateImageBehavior = False
        Me.listUnverified.View = System.Windows.Forms.View.Details
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.EditPanel)
        Me.tabSearch.Controls.Add(Me.SearchBrowser)
        Me.tabSearch.Controls.Add(Me.listSearch)
        Me.tabSearch.Controls.Add(Me.Panel3)
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
        Me.EditPanel.Controls.Add(Me.ComboBox1)
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Keywords:"
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "File Path:"
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Database ID: "
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
        'SearchBrowser
        '
        Me.SearchBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBrowser.Location = New System.Drawing.Point(224, 33)
        Me.SearchBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.SearchBrowser.Name = "SearchBrowser"
        Me.SearchBrowser.Size = New System.Drawing.Size(732, 596)
        Me.SearchBrowser.TabIndex = 2
        '
        'listSearch
        '
        Me.listSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.listSearch.Location = New System.Drawing.Point(8, 243)
        Me.listSearch.MultiSelect = False
        Me.listSearch.Name = "listSearch"
        Me.listSearch.Size = New System.Drawing.Size(210, 386)
        Me.listSearch.TabIndex = 1
        Me.listSearch.UseCompatibleStateImageBehavior = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Controls.Add(Me.dtpSearchTo)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.dtpSearchFrom)
        Me.Panel3.Controls.Add(Me.chkAllFacilities)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.cbSearchFacility)
        Me.Panel3.Location = New System.Drawing.Point(8, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 231)
        Me.Panel3.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(3, 190)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(204, 38)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search Manifests"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dtpSearchTo
        '
        Me.dtpSearchTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSearchTo.Location = New System.Drawing.Point(7, 149)
        Me.dtpSearchTo.Name = "dtpSearchTo"
        Me.dtpSearchTo.Size = New System.Drawing.Size(200, 20)
        Me.dtpSearchTo.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 17)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "To"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "From"
        '
        'dtpSearchFrom
        '
        Me.dtpSearchFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSearchFrom.Location = New System.Drawing.Point(7, 106)
        Me.dtpSearchFrom.Name = "dtpSearchFrom"
        Me.dtpSearchFrom.Size = New System.Drawing.Size(200, 20)
        Me.dtpSearchFrom.TabIndex = 4
        '
        'chkAllFacilities
        '
        Me.chkAllFacilities.AutoSize = True
        Me.chkAllFacilities.Location = New System.Drawing.Point(6, 54)
        Me.chkAllFacilities.Name = "chkAllFacilities"
        Me.chkAllFacilities.Size = New System.Drawing.Size(80, 17)
        Me.chkAllFacilities.TabIndex = 3
        Me.chkAllFacilities.Text = "All Facilities"
        Me.chkAllFacilities.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "OR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Choose Facility:"
        '
        'cbSearchFacility
        '
        Me.cbSearchFacility.FormattingEnabled = True
        Me.cbSearchFacility.Location = New System.Drawing.Point(90, 3)
        Me.cbSearchFacility.Name = "cbSearchFacility"
        Me.cbSearchFacility.Size = New System.Drawing.Size(117, 21)
        Me.cbSearchFacility.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem})
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
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Settings"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Facility:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(52, 135)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 687)
        Me.Controls.Add(Me.TabControls)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Manifest Manager"
        Me.TabControls.ResumeLayout(False)
        Me.tabVerify.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabSearch.ResumeLayout(False)
        Me.EditPanel.ResumeLayout(False)
        Me.EditPanel.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControls As TabControl
    Friend WithEvents tabVerify As TabPage
    Friend WithEvents tabSearch As TabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnRefreshUnverified As Button
    Friend WithEvents listUnverified As ListView
    Friend WithEvents MapNetworkDrivesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerifyBrowser As WebBrowser
    Friend WithEvents cbVerifyFacility As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpVerifyDeliveryDate As DateTimePicker
    Friend WithEvents chkVerifyControls As CheckBox
    Friend WithEvents chkVerifyCycle As CheckBox
    Friend WithEvents cbVerifyRouting As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rtbVerifyKeywords As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblVerifyID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label0 As Label
    Friend WithEvents txtVerifyFilePath As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnVerifySaveManifest As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents cbSearchFacility As ComboBox
    Friend WithEvents listSearch As ListView
    Friend WithEvents btnSearch As Button
    Friend WithEvents dtpSearchTo As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpSearchFrom As DateTimePicker
    Friend WithEvents chkAllFacilities As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SearchBrowser As WebBrowser
    Friend WithEvents EditPanel As Panel
    Friend WithEvents lnkEdit As LinkLabel
    Friend WithEvents Label12 As Label
    Friend WithEvents rtbSearchKeywords As RichTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSearchFilePath As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblSearchID As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label16 As Label
End Class
