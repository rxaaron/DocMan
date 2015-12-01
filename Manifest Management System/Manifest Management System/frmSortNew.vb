
Imports System.IO
Imports System.Data.SqlClient

Public Class frmSortNew
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim searcher As New RxConnect("gmap-server", "ENCORE", "1776", "ManifestManager", "gmapuser", "Password1")

        Dim da As New SqlDataAdapter
        Dim slct As New SqlCommand("SELECT FileLocation FROM ManifestData;", searcher.RxConnection)
        da.SelectCommand = slct
        Dim ds As New DataSet
        da.Fill(ds, "ManifestData")


        listFiles.Items.Clear()
        listFiles.View = View.Details
        listFiles.Columns.Clear()
        listFiles.Columns.Add("FileNAME")
        listFiles.Columns.Item(0).Width = listFiles.Width - 4
        listFiles.HeaderStyle = ColumnHeaderStyle.None

        For Each drow As DataRow In ds.Tables(0).Rows
            Dim LVI As New ListViewItem
            LVI.Text = drow.Item(0).ToString
            listFiles.Items.Add(LVI)
        Next

        'Dim filez() As String
        'filez = Directory.GetFiles("m:\", "*.pdf", SearchOption.AllDirectories)
        'Dim filename As String
        'For Each filename In filez
        '    Dim LVI As New ListViewItem
        '    LVI.Text = filename
        '    listFiles.Items.Add(LVI)
        'Next
    End Sub

    Private Sub listFiles_ItemActivate(sender As Object, e As EventArgs) Handles listFiles.ItemActivate
        Dim lv As ListView = CType(sender, ListView)

        pdfViewer.Navigate(lv.SelectedItems.Item(0).Text)
    End Sub

    Private Sub test()
        'Dim bob As New RxConnect(1, 2, 3, 4, 5, 6)
        ' Dim jim As New SqlCommand
        'jim.Connection = bob.RxConnection


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        File.Move(TextBox1.Text, TextBox2.Text)
    End Sub
End Class