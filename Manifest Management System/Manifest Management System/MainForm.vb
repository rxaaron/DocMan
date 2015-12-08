﻿Imports System.IO
Imports System.Data.SqlClient
Public Class MainForm
    Dim SQLConnection As New RxConnect(My.Settings.SQLServer, My.Settings.SQLInstance, My.Settings.SQLPort, My.Settings.DatabaseName, My.Settings.DatabaseUser, My.Settings.DatabasePassword)

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = My.Settings.StartFormWidth
        Me.Height = My.Settings.StartFormHeight


        If CheckMappedDrives() = True Then
            RefreshNewManifests()
        End If


        FillRoutingBox(cbVerifyRouting)
        FillFacilityBox(cbVerifyFacility)
        FillFacilityBox(cbSearchFacility)
        FillFacilityBox(cbSearchResultFacility)
        FillRoutingBox(cbSearchRouting)

        VerifyEntryStatus(False)

    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.StartFormWidth = Me.Width
        My.Settings.StartFormHeight = Me.Height
    End Sub

    Private Sub RefreshNewManifests()
        If SQLConnection.OpenConnection = True Then
            ProcessingDialog.Show()
            ProcessingDialog.pbrUpdate.Value = 0
            Dim FileList() As String = Directory.GetFiles(My.Settings.NewManifestLocation, "*.pdf")
            ProcessingDialog.pbrUpdate.Maximum = FileList.Count

            For Each filepath As String In FileList

                Dim ThisFile As New RxTransaction(SQLConnection.RxConnection, filepath)
                Dim NewFilePath As String = My.Settings.PermanentManifestLocation & Path.GetFileName(filepath)
                Dim KeywordParser As New KeywordReader
                Dim ThisFilesProperties As New Dictionary(Of String, String)
                ThisFilesProperties = KeywordParser.ParseKeywords(ThisFile.FilePath)
                If ThisFile.MoveFiles(NewFilePath) = True Then



                    Try
                        Dim Facility As String = "20"
                        Dim Routing As String = "3"
                        Dim Controls As String = "False"
                        Dim FillDate As String = "01-01-1900"
                        Dim Keywords As String = ""
                        ThisFilesProperties.TryGetValue("Facility", Facility)
                        ThisFilesProperties.TryGetValue("Routing", Routing)
                        ThisFilesProperties.TryGetValue("Controls", Controls)
                        ThisFilesProperties.TryGetValue("FillDate", FillDate)
                        ThisFilesProperties.TryGetValue("Keywords", Keywords)
                        If String.IsNullOrEmpty(Controls) = True Then
                            Controls = "False"
                        End If
                        If String.IsNullOrEmpty(FillDate) = True Then
                            FillDate = "01-01-1900"
                        End If
                        If String.IsNullOrEmpty(Facility) = True Then
                            Facility = "20"
                        End If
                        If String.IsNullOrEmpty(Routing) = True Then
                            Routing = "3"
                        End If
                        Try
                            ThisFile.InsertRecord(CInt(Facility), CBool(Controls), FillDate, False, CInt(Routing), Keywords)
                        Catch ex As Exception
                            MsgBox("3  " & ex.Message)
                        End Try


                    Catch ex As Exception
                        MsgBox("2   " & ex.Message)
                        ThisFile.LogErrors(ex.Message)
                    End Try

                End If
                ThisFile = Nothing
                ThisFilesProperties = Nothing
                ProcessingDialog.pbrUpdate.PerformStep()
            Next
        End If
        SQLConnection.CloseConnection()
        RefreshUnverifiedList()
        ProcessingDialog.Close()

    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDataToolStripMenuItem.Click
        RefreshNewManifests()
    End Sub

    Private Sub btnRefreshUnverified_Click(sender As Object, e As EventArgs) Handles btnRefreshUnverified.Click
        RefreshUnverifiedList()
    End Sub

    Private Sub RefreshUnverifiedList()
        Dim commandText As String = "SELECT A.ID, A.FileLocation, B.ID AS FacilityID, B.FacilityName, A.Controls, A.DeliveryDate, A.Cycle, C.ID AS RoutingID," _
                                    & " C.Text AS RoutingText, A.AssociatedKeywords FROM ManifestData AS A INNER JOIN Facilities AS B ON A.Facility = B.ID " _
                                    & "INNER JOIN Routing AS C ON A.Routing = C.ID WHERE A.Verified = @verified AND A.Active = @active ORDER BY A.DeliveryDate;"
        Dim da As New SqlDataAdapter
        Dim slct As New SqlCommand(commandText, SQLConnection.RxConnection)
        slct.Parameters.Add("@verified", SqlDbType.Bit)
        slct.Parameters.Add("@active", SqlDbType.Bit)
        slct.Parameters("@verified").Value = False
        slct.Parameters("@active").Value = True
        da.SelectCommand = slct
        Dim ds As New DataSet
        da.Fill(ds, "ManifestData")

        listUnverified.Items.Clear()
        listUnverified.View = View.Details
        listUnverified.Columns.Clear()
        listUnverified.Columns.Add("Manifest Name")
        listUnverified.Columns.Item(0).Width = listUnverified.Width - 4
        listUnverified.HeaderStyle = ColumnHeaderStyle.None

        For Each drow As DataRow In ds.Tables("ManifestData").Rows
            Dim lvi As New ListViewItem
            Dim ShownName As String = drow.Item("FacilityName").ToString & " " & Date.Parse(drow.Item("DeliveryDate").ToString).ToShortDateString & " " & drow.Item("RoutingText").ToString
            lvi.Text = ShownName
            Dim lvisub1 As New ListViewItem.ListViewSubItem
            lvisub1.Name = "RowID"
            lvisub1.Text = drow.Item("ID").ToString
            Dim lvisub2 As New ListViewItem.ListViewSubItem
            lvisub2.Name = "FilePath"
            lvisub2.Text = drow.Item("FileLocation").ToString
            Dim lvisub3 As New ListViewItem.ListViewSubItem
            lvisub3.Name = "FacilityID"
            lvisub3.Text = drow.Item("FacilityID").ToString
            Dim lvisub4 As New ListViewItem.ListViewSubItem
            lvisub4.Name = "Controls"
            lvisub4.Text = drow.Item("Controls").ToString
            Dim lvisub5 As New ListViewItem.ListViewSubItem
            lvisub5.Name = "DeliveryDate"
            lvisub5.Text = Date.Parse(drow.Item("DeliveryDate").ToString).ToShortDateString
            Dim lvisub6 As New ListViewItem.ListViewSubItem
            lvisub6.Name = "Cycle"
            lvisub6.Text = drow.Item("Cycle").ToString
            Dim lvisub7 As New ListViewItem.ListViewSubItem
            lvisub7.Name = "RoutingID"
            lvisub7.Text = drow.Item("RoutingID").ToString
            Dim lvisub8 As New ListViewItem.ListViewSubItem
            lvisub8.Name = "AssociatedKeywords"
            lvisub8.Text = drow.Item("AssociatedKeywords").ToString
            lvi.SubItems.Add(lvisub1)
            lvi.SubItems.Add(lvisub2)
            lvi.SubItems.Add(lvisub3)
            lvi.SubItems.Add(lvisub4)
            lvi.SubItems.Add(lvisub5)
            lvi.SubItems.Add(lvisub6)
            lvi.SubItems.Add(lvisub7)
            lvi.SubItems.Add(lvisub8)
            listUnverified.Items.Add(lvi)
        Next

        VerifyBrowser.Navigate("about:blank")

    End Sub

    Private Sub ItemSelected(ByVal LV As ListView)
        VerifyBrowser.Navigate(LV.SelectedItems().Item(0).SubItems.Item("FilePath").Text.ToString)
        cbVerifyFacility.SelectedValue = CInt(LV.SelectedItems().Item(0).SubItems.Item("FacilityID").Text)
        If Date.Compare(Date.Parse(LV.SelectedItems().Item(0).SubItems.Item("DeliveryDate").Text), Date.Parse("01/01/1900")) = 0 Then
            dtpVerifyDeliveryDate.Value = Today
        Else
            dtpVerifyDeliveryDate.Value = Date.Parse(LV.SelectedItems().Item(0).SubItems.Item("DeliveryDate").Text)
        End If

        chkVerifyControls.Checked = CBool(LV.SelectedItems().Item(0).SubItems.Item("Controls").Text)
        chkVerifyCycle.Checked = CBool(LV.SelectedItems().Item(0).SubItems.Item("Cycle").Text)
        cbVerifyRouting.SelectedValue = CInt(LV.SelectedItems().Item(0).SubItems.Item("RoutingID").Text)
        rtbVerifyKeywords.Clear()
        rtbVerifyKeywords.Text = LV.SelectedItems().Item(0).SubItems.Item("AssociatedKeywords").Text
        lblVerifyID.Text = LV.SelectedItems().Item(0).SubItems.Item("RowID").Text
        txtVerifyFilePath.Text = LV.SelectedItems().Item(0).SubItems.Item("FilePath").Text
    End Sub

    Private Sub listUnverified_ItemActivate(sender As Object, e As EventArgs) Handles listUnverified.ItemActivate

        Dim LV As ListView = CType(sender, ListView)
        ItemSelected(LV)
        VerifyEntryStatus(True)
    End Sub

    Private Sub MapNetworkDrivesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapNetworkDrivesToolStripMenuItem.Click
        CheckMappedDrives()
    End Sub

    Private Function CheckMappedDrives() As Boolean
        Dim NM As New NetworkMonitor
        If NM.ManifestReady = False Then
            MsgBox("Manifest network drive is missing or unavailable." & Chr(13) & Chr(13) & "Please go to File->Map Network Drives to fix this problem", MsgBoxStyle.Critical, "Manifest Folder")
            Return False
        End If
        If NM.ScannedReady = False Then
            MsgBox("Scanned Files network drive is missing or unavailable." & Chr(13) & Chr(13) & "Please go to File->Map Network Drives to fix this problem", MsgBoxStyle.Critical, "Scanned Files Folder")
            Return False
        End If
        Return True
    End Function

    Public Sub FillFacilityBox(ByVal FacilityComboBox As ComboBox)

        FacilityComboBox.Items.Clear()
        Dim da As New SqlDataAdapter
        Dim slct As New SqlCommand("SELECT ID, FacilityName FROM Facilities ORDER BY FacilityName;", SQLConnection.RxConnection)
        da.SelectCommand = slct
        Dim ds As New DataSet
        da.Fill(ds, "Facilities")
        Dim dv As DataView
        dv = ds.Tables("Facilities").DefaultView
        FacilityComboBox.DataSource = dv
        FacilityComboBox.DisplayMember = "FacilityName"
        FacilityComboBox.ValueMember = "ID"
        FacilityComboBox.DropDownHeight = ((FacilityComboBox.Items.Count * 13) + 2)

    End Sub

    Public Sub FillRoutingBox(ByVal RoutingComboBox As ComboBox)

        RoutingComboBox.Items.Clear()
        Dim da As New SqlDataAdapter
        Dim slct As New SqlCommand("SELECT ID, Text AS RoutingText FROM Routing;", SQLConnection.RxConnection)
        da.SelectCommand = slct
        Dim ds As New DataSet
        da.Fill(ds, "Routing")
        Dim dv As DataView
        dv = ds.Tables("Routing").DefaultView
        RoutingComboBox.DataSource = dv
        RoutingComboBox.DisplayMember = "RoutingText"
        RoutingComboBox.ValueMember = "ID"
        RoutingComboBox.DropDownHeight = ((RoutingComboBox.Items.Count * 13) + 2)

    End Sub

    Private Sub btnVerifySaveManifest_Click(sender As Object, e As EventArgs) Handles btnVerifySaveManifest.Click
        SQLConnection.OpenConnection()

        If CInt(cbVerifyRouting.SelectedValue) = 3 Or CInt(cbVerifyFacility.SelectedValue) = 20 Then
            MsgBox("You cannot verify a manifest as an Unknown Facility or Send/Receive status.", MsgBoxStyle.Exclamation, "Entry Error")
        Else
            Dim VerifyManifest As New RxTransaction(SQLConnection.RxConnection, CInt(listUnverified.SelectedItems().Item(0).SubItems.Item("RowID").Text))
            If VerifyManifest.UpdateRecord(CInt(cbVerifyFacility.SelectedValue), chkVerifyControls.Checked, dtpVerifyDeliveryDate.Value.ToShortDateString, chkVerifyCycle.Checked, CInt(cbVerifyRouting.SelectedValue), rtbVerifyKeywords.Text) = True Then
                RefreshUnverifiedList()
                VerifyEntryStatus(False)
            End If
        End If
        SQLConnection.CloseConnection()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        listSearch.Items.Clear()
        listSearch.View = View.Details
        listSearch.Columns.Clear()
        listSearch.Columns.Add("Manifest Name")
        listSearch.Columns.Item(0).Width = listUnverified.Width - 4
        listSearch.HeaderStyle = ColumnHeaderStyle.None

        Dim commandText As String

        If chkAllFacilities.Checked = True Then
            commandText = "SELECT A.ID, A.FileLocation, B.ID AS FacilityID, B.FacilityName, A.Controls, A.DeliveryDate, A.Cycle, C.ID AS RoutingID," _
                                & " C.Text AS RoutingText, A.AssociatedKeywords, A.Verified, A.VerifyingUser FROM ManifestData AS A INNER JOIN Facilities AS B ON A.Facility = B.ID " _
                                & "INNER JOIN Routing AS C ON A.Routing = C.ID WHERE A.Active = @active AND A.DeliveryDate BETWEEN @fromdate AND @todate ORDER BY B.FacilityName, A.DeliveryDate;"
        Else
            commandText = "SELECT A.ID, A.FileLocation, B.ID AS FacilityID, B.FacilityName, A.Controls, A.DeliveryDate, A.Cycle, C.ID AS RoutingID," _
                                & " C.Text AS RoutingText, A.AssociatedKeywords, A.Verified, A.VerifyingUser FROM ManifestData AS A INNER JOIN Facilities AS B ON A.Facility = B.ID " _
                                & "INNER JOIN Routing AS C ON A.Routing = C.ID WHERE A.Active = @active AND A.DeliveryDate BETWEEN @fromdate AND @todate AND A.Facility = @facility ORDER BY A.DeliveryDate;"
        End If

        Dim da As New SqlDataAdapter
        Dim slct As New SqlCommand(commandText, SQLConnection.RxConnection)
        slct.Parameters.Add("@fromdate", SqlDbType.Date)
        slct.Parameters.Add("@todate", SqlDbType.Date)
        slct.Parameters.Add("@active", SqlDbType.Bit)
        slct.Parameters("@fromdate").Value = dtpSearchFrom.Value
        slct.Parameters("@todate").Value = dtpSearchTo.Value
        slct.Parameters("@active").Value = True

        If chkAllFacilities.Checked = False Then
            slct.Parameters.Add("@facility", SqlDbType.Int)
            slct.Parameters("@facility").Value = CInt(cbSearchFacility.SelectedValue)
        End If

        da.SelectCommand = slct
        Dim ds As New DataSet
        da.Fill(ds, "ManifestData")

        For Each drow As DataRow In ds.Tables("ManifestData").Rows
            Dim lvi As New ListViewItem
            Dim ShownName As String = drow.Item("FacilityName").ToString & " " & Date.Parse(drow.Item("DeliveryDate").ToString).ToShortDateString & " " & drow.Item("RoutingText").ToString
            If CBool(drow.Item("Controls").ToString) = True Then
                ShownName = ShownName & " Controls"
            End If
            If CBool(drow.Item("Cycle").ToString) = True Then
                ShownName = ShownName & " Cycle"
            End If
            If CBool(drow.Item("Verified").ToString) = False Then
                ShownName = "*" & ShownName
            End If
            lvi.Text = ShownName
            Dim lvisub1 As New ListViewItem.ListViewSubItem
            lvisub1.Name = "RowID"
            lvisub1.Text = drow.Item("ID").ToString
            Dim lvisub2 As New ListViewItem.ListViewSubItem
            lvisub2.Name = "FilePath"
            lvisub2.Text = drow.Item("FileLocation").ToString
            Dim lvisub3 As New ListViewItem.ListViewSubItem
            lvisub3.Name = "FacilityID"
            lvisub3.Text = drow.Item("FacilityID").ToString
            Dim lvisub4 As New ListViewItem.ListViewSubItem
            lvisub4.Name = "Controls"
            lvisub4.Text = drow.Item("Controls").ToString
            Dim lvisub5 As New ListViewItem.ListViewSubItem
            lvisub5.Name = "DeliveryDate"
            lvisub5.Text = Date.Parse(drow.Item("DeliveryDate").ToString).ToShortDateString
            Dim lvisub6 As New ListViewItem.ListViewSubItem
            lvisub6.Name = "Cycle"
            lvisub6.Text = drow.Item("Cycle").ToString
            Dim lvisub7 As New ListViewItem.ListViewSubItem
            lvisub7.Name = "RoutingID"
            lvisub7.Text = drow.Item("RoutingID").ToString
            Dim lvisub8 As New ListViewItem.ListViewSubItem
            lvisub8.Name = "AssociatedKeywords"
            lvisub8.Text = drow.Item("AssociatedKeywords").ToString
            Dim lvisub9 As New ListViewItem.ListViewSubItem
            lvisub9.Name = "Verified"
            lvisub9.Text = drow.Item("Verified").ToString
            Dim lvisub10 As New ListViewItem.ListViewSubItem
            lvisub10.Name = "VerifyingUser"
            lvisub10.Text = drow.Item("VerifyingUser").ToString
            lvi.SubItems.Add(lvisub1)
            lvi.SubItems.Add(lvisub2)
            lvi.SubItems.Add(lvisub3)
            lvi.SubItems.Add(lvisub4)
            lvi.SubItems.Add(lvisub5)
            lvi.SubItems.Add(lvisub6)
            lvi.SubItems.Add(lvisub7)
            lvi.SubItems.Add(lvisub8)
            lvi.SubItems.Add(lvisub9)
            lvi.SubItems.Add(lvisub10)
            listSearch.Items.Add(lvi)
        Next

        EditPanelState(False)
        SearchBrowser.Navigate("about:blank")

    End Sub

    Private Sub listSearch_ItemActivate(sender As Object, e As EventArgs) Handles listSearch.ItemActivate

        Dim LV As ListView = CType(sender, ListView)
        SearchBrowser.Navigate(LV.SelectedItems.Item(0).SubItems.Item("FilePath").Text.ToString)
        EditPanelState(False)
        lblSearchID.Text = LV.SelectedItems.Item(0).SubItems.Item("RowId").Text.ToString
        txtSearchFilePath.Text = LV.SelectedItems.Item(0).SubItems.Item("FilePath").Text.ToString
        rtbSearchKeywords.Clear()
        rtbSearchKeywords.Text = LV.SelectedItems.Item(0).SubItems.Item("AssociatedKeywords").Text.ToString
        cbSearchResultFacility.SelectedValue = CInt(LV.SelectedItems.Item(0).SubItems.Item("FacilityID").Text)
        dtpSearchDateOfService.Value = Date.Parse(LV.SelectedItems.Item(0).SubItems.Item("DeliveryDate").Text)
        chkSearchControls.Checked = CBool(LV.SelectedItems.Item(0).SubItems.Item("Controls").Text)
        chkSearchCycle.Checked = CBool(LV.SelectedItems.Item(0).SubItems.Item("Cycle").Text)
        cbSearchRouting.SelectedValue = CInt(LV.SelectedItems.Item(0).SubItems.Item("RoutingID").Text)
        lblSearchVerifyingUser.Text = LV.SelectedItems.Item(0).SubItems.Item("VerifyingUser").Text
    End Sub

    Private Sub EditPanelState(ByVal IsEnabled As Boolean)

        If IsEnabled = True Then
            EditPanel.BackColor = Color.LightGray
        Else
            EditPanel.BackColor = Color.DarkGray
        End If
        cbSearchResultFacility.Enabled = IsEnabled
        dtpSearchDateOfService.Enabled = IsEnabled
        chkSearchControls.Enabled = IsEnabled
        chkSearchCycle.Enabled = IsEnabled
        cbSearchRouting.Enabled = IsEnabled
        btnUpdateManifest.Enabled = IsEnabled

    End Sub

    Private Sub lnkEdit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEdit.LinkClicked
        EditPanelState(True)
    End Sub

    Private Sub btnUpdateManifest_Click(sender As Object, e As EventArgs) Handles btnUpdateManifest.Click
        SQLConnection.OpenConnection()

        If CInt(cbSearchRouting.SelectedValue) = 3 Or CInt(cbSearchResultFacility.SelectedValue) = 20 Then
            MsgBox("You cannot verify a manifest as an Unknown Facility or Send/Receive status.", MsgBoxStyle.Exclamation, "Entry Error")
        Else
            Dim UpdateManifest As New RxTransaction(SQLConnection.RxConnection, CInt(listSearch.SelectedItems().Item(0).SubItems.Item("RowID").Text))
            If UpdateManifest.UpdateRecord(CInt(cbSearchResultFacility.SelectedValue), chkSearchControls.Checked, dtpSearchDateOfService.Value.ToShortDateString, chkSearchCycle.Checked, CInt(cbSearchRouting.SelectedValue), rtbSearchKeywords.Text) = True Then
                EditPanelState(False)
            End If
        End If

        SQLConnection.CloseConnection()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        Dim tsmi As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        If tsmi.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub VerifyEntryStatus(ByVal IsEnabled As Boolean)
        cbVerifyFacility.Enabled = IsEnabled
        cbVerifyRouting.Enabled = IsEnabled
        btnVerifySaveManifest.Enabled = IsEnabled
    End Sub

    Private Sub SplitManifestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SplitManifestToolStripMenuItem.Click
        If listUnverified.SelectedItems.Count < 1 Then
            MsgBox("There is no manifest selected.", MsgBoxStyle.Question, "Error Found")
        Else
            SQLConnection.OpenConnection()
            Dim SplitFile As New RxTransaction(SQLConnection.RxConnection, listUnverified.SelectedItems.Item(0).SubItems.Item("FilePath").Text)
            If SplitFile.InsertRecord(CInt(listUnverified.SelectedItems.Item(0).SubItems.Item("FacilityID").Text), CBool(listUnverified.SelectedItems.Item(0).SubItems.Item("Controls").Text), listUnverified.SelectedItems.Item(0).SubItems.Item("DeliveryDate").Text, CBool(listUnverified.SelectedItems.Item(0).SubItems.Item("Cycle").Text), CInt(listUnverified.SelectedItems.Item(0).SubItems.Item("RoutingID").Text), listUnverified.SelectedItems.Item(0).SubItems.Item("AssociatedKeywords").Text) = True Then
                MsgBox("Manifest Split.")
            End If
            SQLConnection.CloseConnection()
            RefreshUnverifiedList()
        End If
    End Sub

    Private Sub DeleteManifestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteManifestToolStripMenuItem.Click
        If listUnverified.SelectedItems.Count < 1 Then
            MsgBox("There is no manifest selected.", MsgBoxStyle.Question, "Error")
        Else
            Dim dr As MsgBoxResult = MsgBox("Are you sure you want to permanently remove this manifest?", MsgBoxStyle.YesNo, "Are You Sure?")
            If dr = MsgBoxResult.Yes Then
                SQLConnection.OpenConnection()

                Dim da As New SqlDataAdapter
                Dim update As New SqlCommand("UPDATE ManifestData SET Active=@active WHERE ID=@rid;", SQLConnection.RxConnection)
                da.UpdateCommand = update
                update.Parameters.Add("@active", SqlDbType.Bit)
                update.Parameters.Add("@rid", SqlDbType.Int)
                update.Parameters("@active").Value = False
                update.Parameters("@rid").Value = CInt(listUnverified.SelectedItems.Item(0).SubItems.Item("RowID").Text)
                update.ExecuteNonQuery()
                SQLConnection.CloseConnection()
                MsgBox("Manifest Deleted.")
                RefreshUnverifiedList()
            End If

        End If
    End Sub

End Class