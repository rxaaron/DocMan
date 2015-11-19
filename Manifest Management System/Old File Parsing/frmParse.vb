Imports System
Imports System.IO
Imports System.Collections

Public Class frmParse

    Private Sub btnFileBrowse_Click(sender As Object, e As EventArgs) Handles btnFileBrowse.Click
        Dim response As DialogResult
        fbdOldFiles.SelectedPath = "Q:\Manifests\Received"
        response = fbdOldFiles.ShowDialog
        If response = DialogResult.OK Then
            txtFilePath.Text = fbdOldFiles.SelectedPath.ToString
        End If
    End Sub

    Private Sub btnParseNames_Click(sender As Object, e As EventArgs) Handles btnParseNames.Click
        listFileNames.Items.Clear()
        listFileNames.Columns.Clear()
        listFileNames.Columns.Add("File Name")
        listFileNames.Columns.Add("Facility")
        listFileNames.Columns.Add("Controls")
        listFileNames.Columns.Add("Date")
        listFileNames.HeaderStyle = ColumnHeaderStyle.Clickable
        Dim filez() As String
        filez = Directory.GetFiles(txtFilePath.Text)
        Dim filename As String
        For Each filename In filez
            filename = filename.Remove(0, txtFilePath.Text.Length + 1)
            filename = filename.Remove(filename.Length - 4)
            ParseFiles(filename)
        Next
        listFileNames.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Private Sub ParseFiles(filename As String)
        Dim LVI As New ListViewItem
        LVI.Text = filename
        Dim LVISub1 As New ListViewItem.ListViewSubItem
        LVISub1.Text = "Unknown"
        Dim LVISub2 As New ListViewItem.ListViewSubItem
        LVISub2.Text = "0"
        Dim LVISub3 As New ListViewItem.ListViewSubItem
        LVISub3.Text = "No Date"
        Dim splitters() As String = {" ", "_"}
        Dim words() As String = filename.Split(splitters, StringSplitOptions.RemoveEmptyEntries)
        Dim Brier() As String = {"brier", "brs", "br1", "br2", "breir"}
        Dim Springfield() As String = {"springfield", "sfc", "spf", "springfeild"}
        Dim MainStreet() As String = {"main", "street", "msc", "mscp", "mainstreet"}
        Dim Manor() As String = {"manor", "gbr", "gl1", "gl2", "gs1", "gs2"}
        Dim Manor1stFloor() As String = {"1st", "first", "1"}
        Dim Manor2ndFloor() As String = {"2nd", "second", "2"}
        Dim Seasons() As String = {"seasons", "ts", "t2"}
        Dim MeadowGarden() As String = {"rainelle", "meadow", "garden", "rci", "rcip"}
        Dim AutumnWay() As String = {"autumn", "way", "autw"}
        Dim word As String
        Dim isManor As Boolean = False
        For Each word In words
            Dim facility As String
            For Each facility In Brier
                If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True Then
                    LVISub1.Text = "Brier"
                End If
            Next
            For Each facility In Springfield
                If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True Then
                    LVISub1.Text = "Springfield"
                End If
            Next
            For Each facility In MainStreet
                If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True Then
                    LVISub1.Text = "Main Street Care"
                End If
            Next
            For Each facility In Seasons
                If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True Then
                    LVISub1.Text = "Seasons"
                End If
            Next
            For Each facility In MeadowGarden
                If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True Then
                    LVISub1.Text = "Meadow Garden"
                End If
            Next
            For Each facility In AutumnWay
                If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True Then
                    LVISub1.Text = "Autumn Way"
                End If
            Next

            For Each facility In Manor
                If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True Then
                    isManor = True
                End If
            Next
            For Each facility In Manor1stFloor
                If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True And isManor = True Then
                    LVISub1.Text = "Greenbrier Manor 1st"
                End If
            Next
            For Each facility In Manor2ndFloor
                If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True And isManor = True Then
                    LVISub1.Text = "Greenbrier Manor 2nd"
                End If
            Next
            If word.Equals("controls", StringComparison.OrdinalIgnoreCase) = True Then
                LVISub2.Text = "1"
            End If
            Dim datevalue As Date
            If Date.TryParse(word, datevalue) Then
                LVISub3.Text = datevalue.ToShortDateString
            End If
        Next
        LVI.SubItems.Add(LVISub1)
        LVI.SubItems.Add(LVISub2)
        LVI.SubItems.Add(LVISub3)
        listFileNames.Items.Add(LVI)
    End Sub

End Class
