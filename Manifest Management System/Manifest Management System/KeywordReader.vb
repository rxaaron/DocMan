Imports iTextSharp.text.pdf
Imports System.Data.SqlClient
Imports System.IO

''' <summary>
''' Wrapper for iTextSharp and keyword parsing methods
''' </summary>
Public Class KeywordReader

    Public Function ParseKeywords(ByVal FileLocation As String) As Dictionary(Of String, String)
        Dim Storage As New Dictionary(Of String, String)
        Dim Keys As String = GetKeywords(FileLocation)

        Dim Words() As String = Keys.Split(";")
        For Each word As String In Words
            Dim NoQuotes As String = word.Remove(0, 1)
            NoQuotes = NoQuotes.Remove(NoQuotes.Length - 1, 1)
            Dim SeparateWords() As String = NoQuotes.Split(",")
            For Each IndividualWord As String In SeparateWords
                Storage.Add("Facility", FindFacility(IndividualWord))
                Storage.Add("Routing", FindRouting(IndividualWord))
                Storage.Add("Controls", FindControls(IndividualWord))
            Next
        Next

        Storage.Add("FillDate", File.GetCreationTime(FileLocation).ToShortDateString)

        Return Storage
    End Function

    Private Function GetKeywords(ByVal FileLocation As String) As String
        Dim KeyWords As String = vbNullString

        Dim reader As New PdfReader(FileLocation)
        Dim index As Boolean = reader.Info.TryGetValue("Keywords", KeyWords)

        Return KeyWords
    End Function

    Private Function FindFacility(ByVal Word As String) As Integer
        Dim Facility As Integer = 20

        Dim SQL As New RxConnect("gmap-server", "ENCORE", "1776", "ManifestManager", "gmapuser", "Password1")
        Dim da As New SqlDataAdapter
        Dim slct As New SqlCommand("SELECT Text, AssociatedFacility FROM FacilityPossibility;", SQL.RxConnection)
        da.SelectCommand = slct
        Dim Facilities As New DataSet
        da.Fill(Facilities, "FacilityPossibility")

        For Each drow As DataRow In Facilities.Tables(0).Rows
            If Word.Equals(drow.Item(0).ToString, StringComparison.OrdinalIgnoreCase) = True Then
                Facilities = drow.Item(1)
            End If
        Next

        SQL.CloseConnection()
        Return Facility
    End Function

    Private Function FindRouting(ByVal Word As String) As Integer
        Dim Routing As Integer = 3

        If Word.Equals("sent", StringComparison.OrdinalIgnoreCase) = True Then
            Routing = 2
        ElseIf Word.Equals("received", StringComparison.OrdinalIgnoreCase) = True
            Routing = 1
        End If

        Return Routing
    End Function

    Private Function FindControls(ByVal Word As String) As Boolean
        Dim IsControls As Boolean = False

        Dim SQL As New RxConnect("gmap-server", "ENCORE", "1776", "ManifestManager", "gmapuser", "Password1")
        Dim da As New SqlDataAdapter
        Dim slct As New SqlCommand("SELECT Text FROM ControlsPossibility", SQL.RxConnection)
        da.SelectCommand = slct
        Dim Controls As New DataSet
        da.Fill(Controls, "ControlsPossibility")

        For Each drow As DataRow In Controls.Tables(0).Rows
            If Word.Equals(drow.Item(0).ToString, StringComparison.OrdinalIgnoreCase) = True Then
                IsControls = True
            End If
        Next

        SQL.CloseConnection()
        Return IsControls
    End Function

End Class
