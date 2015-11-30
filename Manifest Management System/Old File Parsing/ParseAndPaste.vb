Imports System.Data
Imports System.Data.SqlClient
Imports Old_File_Parsing.RxConnect
Imports System.IO
Imports iTextSharp.text.pdf

Public Class ParseAndPaste
    Dim MyConnection As New RxConnect("10.10.50.179", "ENCORE", "1776", "ManifestManager", "gmapuser", "Password1")

    Public Function ParseFile(ByVal StartDirectory As String, ByVal Routing As Integer) As String
        Dim totalstring As String = ""
        Try

            Dim Splitters() As String = {" ", "_"}
            Dim facilitypossibility As New SqlDataAdapter
            Dim selectfacpos As New SqlCommand
            facilitypossibility.SelectCommand = selectfacpos
            selectfacpos.Connection = MyConnection.RxConnection
            selectfacpos.CommandText = "SELECT Text, AssociatedFacility FROM FacilityPossibility;"
            Dim facpos As New DataSet
            facilitypossibility.Fill(facpos, "FacilityPossibility")
            Dim manorpossibility As New SqlDataAdapter
            Dim selectmanor As New SqlCommand
            manorpossibility.SelectCommand = selectmanor
            selectmanor.Connection = MyConnection.RxConnection
            selectmanor.CommandText = "SELECT Text, AssociatedFacility FROM ManorFloors;"
            Dim manor As New DataSet
            manorpossibility.Fill(manor, "ManorFloors")
            Dim controlspossibility As New SqlDataAdapter
            Dim selectcontrols As New SqlCommand
            controlspossibility.SelectCommand = selectcontrols
            selectcontrols.Connection = MyConnection.RxConnection
            selectcontrols.CommandText = "SELECT Text FROM ControlsPossibility;"
            Dim controls As New DataSet
            controlspossibility.Fill(controls, "ControlsPossibility")

            Dim insertDA As New SqlDataAdapter
            Dim insert As New SqlCommand
            insert.Connection = MyConnection.RxConnection
            insertDA.InsertCommand = insert
            insert.CommandText = "INSERT INTO ManifestData (FileLocation, Facility, Controls, DeliveryDate, Cycle, Routing, AssociatedKeywords) VALUES (@filelocation, @facility, @controls, @ddate, @cycle, @routing, @keys);"
            insert.Parameters.Add("@filelocation", SqlDbType.VarChar)
            insert.Parameters.Add("@facility", SqlDbType.Int)
            insert.Parameters.Add("@controls", SqlDbType.Bit)
            insert.Parameters.Add("@ddate", SqlDbType.VarChar)
            insert.Parameters.Add("@cycle", SqlDbType.Bit)
            insert.Parameters.Add("@routing", SqlDbType.Int)
            insert.Parameters.Add("@keys", SqlDbType.VarChar)
            'Add sent received parameters due to data changes.
            insert.Parameters("@routing").Value = Routing

            For Each fullfilename As String In Directory.GetFiles(StartDirectory, "*.pdf")

                Dim Facility As Integer = 20
                Dim IsControls As Boolean = False
                Dim IsCycle As Boolean = False
                Dim FillDate As String = "01/01/1900"
                Dim Keywords As String = ""
                Dim SentReceived As Integer = 2
                Dim filename As String = Path.GetFileNameWithoutExtension(fullfilename)
                Dim words() As String = filename.Split(Splitters, StringSplitOptions.RemoveEmptyEntries)
                For Each word As String In words
                    For Each drow As DataRow In facpos.Tables(0).Rows
                        If word.Equals(drow.Item(0).ToString, StringComparison.OrdinalIgnoreCase) = True Then
                            Facility = drow.Item(1)
                        End If
                    Next
                    If Facility = 14 Or Facility = 15 Then
                        For Each mrow As DataRow In manor.Tables(0).Rows
                            If word.Equals(mrow.Item(0).ToString, StringComparison.OrdinalIgnoreCase) = True Then
                                Facility = mrow.Item(1)
                            End If
                        Next
                    End If
                    For Each crow As DataRow In controls.Tables(0).Rows
                        If word.Equals(crow.Item(0).ToString, StringComparison.OrdinalIgnoreCase) = True Then
                            IsControls = True
                        End If
                    Next
                    If word.Equals("cycle", StringComparison.OrdinalIgnoreCase) = True Then
                        IsCycle = True
                    End If
                    Dim datevalue As Date
                    If Date.TryParse(word, datevalue) = True Then
                        FillDate = datevalue.ToShortDateString
                    End If
                Next
                Dim reader As New PdfReader(fullfilename)
                Dim index As Boolean = reader.Info.TryGetValue("Keywords", Keywords)
                insert.Parameters("@keys").Value = Keywords
                If index = False Then
                    insert.Parameters("@keys").Value = vbNull
                End If
                insert.Parameters("@filelocation").Value = fullfilename
                insert.Parameters("@facility").Value = Facility
                insert.Parameters("@controls").Value = IsControls
                insert.Parameters("@ddate").Value = FillDate
                insert.Parameters("@cycle").Value = IsCycle
                Try
                    insert.ExecuteNonQuery()
                Catch ex1 As Exception
                    totalstring = totalstring & Facility.ToString & " " & IsControls & " " & IsCycle & " " & FillDate & " " & fullfilename & ex1.Message & Chr(13)
                End Try

            Next

            Return totalstring
        Catch ex2 As Exception
            Return totalstring & ex2.Message
        End Try

        MyConnection.CloseConnection()
    End Function


End Class
