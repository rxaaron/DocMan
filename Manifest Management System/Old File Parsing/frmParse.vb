Imports System
Imports System.IO
Imports System.Collections
Imports Old_File_Parsing.ParseAndPaste

Public Class frmParse

    Private Sub btnFileBrowse_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnParseNames_Click(sender As Object, e As EventArgs) Handles btnParseNames.Click, btnFileBrowse.Click
        Dim jim As New ParseAndPaste
        txtErrors.AppendText(jim.ParseFile("Q:\Manifests\Received", 1))
        txtErrors.AppendText(jim.ParseFile("Q:\Manifests\Sent", 2))
    End Sub

    'Private Sub ParseFiles(filename As String)
    '    Dim LVI As New ListViewItem
    '    LVI.Text = filename
    '    Dim LVISub1 As New ListViewItem.ListViewSubItem
    '    LVISub1.Text = "Unknown"
    '    Dim LVISub2 As New ListViewItem.ListViewSubItem
    '    LVISub2.Text = "0"
    '    Dim LVISub3 As New ListViewItem.ListViewSubItem
    '    LVISub3.Text = "No Date"
    '    Dim splitters() As String = {" ", "_"}
    '    Dim words() As String = filename.Split(splitters, StringSplitOptions.RemoveEmptyEntries)

    '    Dim word As String
    '    Dim isManor As Boolean = False
    '    For Each word In words
    '        Dim facility As String
    '        For Each facility In Brier
    '            If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True Then
    '                LVISub1.Text = "Brier"
    '            End If
    '        Next
    '        For Each facility In Springfield
    '            If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True Then
    '                LVISub1.Text = "Springfield"
    '            End If
    '        Next
    '        For Each facility In MainStreet
    '            If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True Then
    '                LVISub1.Text = "Main Street Care"
    '            End If
    '        Next
    '        For Each facility In Seasons
    '            If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True Then
    '                LVISub1.Text = "Seasons"
    '            End If
    '        Next
    '        For Each facility In MeadowGarden
    '            If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True Then
    '                LVISub1.Text = "Meadow Garden"
    '            End If
    '        Next
    '        For Each facility In AutumnWay
    '            If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True Then
    '                LVISub1.Text = "Autumn Way"
    '            End If
    '        Next

    '        For Each facility In Manor
    '            If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True Then
    '                isManor = True
    '            End If
    '        Next
    '        For Each facility In Manor1stFloor
    '            If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True And isManor = True Then
    '                LVISub1.Text = "Greenbrier Manor 1st"
    '            End If
    '        Next
    '        For Each facility In Manor2ndFloor
    '            If word.Equals(facility, StringComparison.OrdinalIgnoreCase) = True And isManor = True Then
    '                LVISub1.Text = "Greenbrier Manor 2nd"
    '            End If
    '        Next
    '        If word.Equals("controls", StringComparison.OrdinalIgnoreCase) = True Then
    '            LVISub2.Text = "1"
    '        End If
    '        Dim datevalue As Date
    '        If Date.TryParse(word, datevalue) Then
    '            LVISub3.Text = datevalue.ToShortDateString
    '        End If
    '    Next
    '    LVI.SubItems.Add(LVISub1)
    '    LVI.SubItems.Add(LVISub2)
    '    LVI.SubItems.Add(LVISub3)
    '    listFileNames.Items.Add(LVI)
    'End Sub

End Class
