Imports System
Imports System.IO
Imports System.Collections

Public Class frmSortNew
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        listFiles.Items.Clear()
        listFiles.View = View.Details
        listFiles.Columns.Clear()
        listFiles.Columns.Add("FileNAME")
        listFiles.Columns.Item(0).Width = listFiles.Width - 4
        listFiles.HeaderStyle = ColumnHeaderStyle.None
        Dim filez() As String
        filez = Directory.GetFiles("O:\")
        Dim filename As String
        For Each filename In filez
            Dim LVI As New ListViewItem
            LVI.Text = filename
            listFiles.Items.Add(LVI)
        Next
    End Sub

    Private Sub listFiles_ItemActivate(sender As Object, e As EventArgs) Handles listFiles.ItemActivate
        pdfViewer.Navigate(sender.SelectedItems.Item(0).Text)
    End Sub

End Class