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
        Dim Facility As String = "20"
        Dim Routing As String = "3"
        Dim IsControls As String = "False"
        Dim Failed As String = "Failed"

        If String.IsNullOrEmpty(Keys) = False Then
            Dim Words() As String = Keys.Split(CType(";", Char()))
            For Each word As String In Words
                Dim SomeQuotes As String = word.Replace(" ", String.Empty)
                Dim NoQuotes As String = SomeQuotes.Replace(ControlChars.Quote, String.Empty)
                Dim SeparateWords() As String = NoQuotes.Split(CType(",", Char()))
                For Each IndividualWord As String In SeparateWords
                    If Failed.Equals(FindFacility(IndividualWord), StringComparison.OrdinalIgnoreCase) = False Then
                        Facility = FindFacility(IndividualWord)
                    End If
                    If Failed.Equals(FindRouting(IndividualWord), StringComparison.OrdinalIgnoreCase) = False Then
                        Routing = FindRouting(IndividualWord)
                    End If
                    If Failed.Equals(FindControls(IndividualWord), StringComparison.OrdinalIgnoreCase) = False Then
                        IsControls = FindControls(IndividualWord)
                    End If

                Next
            Next

            Storage.Add("Routing", Routing)
            Storage.Add("Controls", IsControls)
            Storage.Add("Facility", Facility)
            Storage.Add("FillDate", File.GetCreationTime(FileLocation).ToShortDateString)
            Storage.Add("Keywords", Keys)
        End If
        Return Storage

    End Function

    Private Function GetKeywords(ByVal FileLocation As String) As String
        Dim KeyWords As String = vbNullString

        Dim reader As New PdfReader(FileLocation)
        Dim index As Boolean = reader.Info.TryGetValue("Keywords", KeyWords)

        Return KeyWords
    End Function

    Private Function FindFacility(ByVal Word As String) As String
        Dim Facility As String = "Failed"

        Dim SQL As New RxConnect("gmap-server", "ENCORE", "1776", "ManifestManager", "gmapuser", "Password1")
        Dim da As New SqlDataAdapter
        Dim slct As New SqlCommand("SELECT Text, AssociatedFacility FROM FacilityPossibility;", SQL.RxConnection)
        da.SelectCommand = slct
        Dim Facilities As New DataSet
        da.Fill(Facilities, "FacilityPossibility")

        For Each drow As DataRow In Facilities.Tables(0).Rows
            If Word.Equals(drow.Item(0).ToString, StringComparison.OrdinalIgnoreCase) = True Then
                Facility = drow.Item(1).ToString
            End If
        Next

        SQL.CloseConnection()
        Return Facility
    End Function

    Private Function FindRouting(ByVal Word As String) As String
        Dim Routing As String = "Failed"

        If Word.Equals("sent", StringComparison.OrdinalIgnoreCase) = True Then
            Routing = "2"
        ElseIf Word.Equals("received", StringComparison.OrdinalIgnoreCase) = True
            Routing = "1"
        End If

        Return Routing
    End Function

    Private Function FindControls(ByVal Word As String) As String
        Dim IsControls As String = "Failed"

        Dim SQL As New RxConnect("gmap-server", "ENCORE", "1776", "ManifestManager", "gmapuser", "Password1")
        Dim da As New SqlDataAdapter
        Dim slct As New SqlCommand("SELECT Text FROM ControlsPossibility", SQL.RxConnection)
        da.SelectCommand = slct
        Dim Controls As New DataSet
        da.Fill(Controls, "ControlsPossibility")

        For Each drow As DataRow In Controls.Tables(0).Rows
            If Word.Equals(drow.Item(0).ToString, StringComparison.OrdinalIgnoreCase) = True Then
                IsControls = "True"
            End If
        Next

        SQL.CloseConnection()
        Return IsControls
    End Function

End Class
