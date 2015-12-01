Imports System.IO
Public Class MainForm
    Dim SQLConnection As New RxConnect(My.Settings.SQLServer, My.Settings.SQLInstance, My.Settings.SQLPort, My.Settings.DatabaseName, My.Settings.DatabaseUser, My.Settings.DatabasePassword)

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = My.Settings.StartFormWidth
        Me.Height = My.Settings.StartFormHeight



    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.StartFormWidth = Me.Width
        My.Settings.StartFormHeight = Me.Height
    End Sub

    Private Sub RefreshNewManifests()
        If SQLConnection.OpenConnection = True Then
            Dim FileList() As String = Directory.GetFiles(My.Settings.NewManifestLocation, "*.pdf")

            For Each filepath As String In FileList

                Dim ThisFile As New RxTransaction(SQLConnection.RxConnection, filepath)
                Dim NewFilePath As String = My.Settings.PermanentManifestLocation & Path.GetFileName(filepath)
                Dim KeywordParser As New KeywordReader
                Dim ThisFilesProperties As Dictionary(Of String, String) = KeywordParser.ParseKeywords(ThisFile.FilePath)
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
                        ThisFile.InsertRecord(CInt(Facility), CBool(Controls), FillDate, False, CInt(Routing), Keywords)

                    Catch ex As Exception
                        MsgBox(ex.Message)
                        ThisFile.LogErrors(ex.Message)
                        SQLConnection.CloseConnection()
                    End Try

                End If
            Next
        End If
        SQLConnection.CloseConnection()
    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDataToolStripMenuItem.Click
        RefreshNewManifests()
    End Sub

End Class