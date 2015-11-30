Imports System.Data
Imports System.Data.SqlClient
''' <summary>
''' This class is designed specifically for the Manifest Management system.
''' </summary>
Public Class RxTransaction

    Private Connection As SqlConnection
    ''' <summary>
    ''' This is the SqlConnection required by all the data adapters in the class.
    ''' </summary>
    ''' <returns>Active SqlConnection passed by the code calling this class.</returns>
    Public Property SqlConnection As SqlConnection
        Get
            Return Connection
        End Get
        Set(value As SqlConnection)
            Connection = value
        End Set
    End Property

    ''' <summary>
    ''' New instance of the class requires an SqlConnection be specified to simplify later code.
    ''' </summary>
    ''' <param name="SQLConnection">The required SqlConnection.</param>
    ''' <param name="FilePath">The location of the current file being worked.</param>
    Public Sub New(ByVal SQLConnection As SqlConnection, ByVal FilePath As String)
        Connection = SQLConnection
        FileLocation = FilePath
    End Sub


    ''' <summary>
    ''' New instance of the class requires an SqlConnection be specified to simplify later code.
    ''' </summary>
    ''' <param name="SQLConnection">The required SqlConnection.</param>
    ''' <param name="RowID">The ID corresponding to the file being worked.</param>
    Public Sub New(ByVal SQLConnection As SqlConnection, ByVal RowID As Integer)
        Connection = SQLConnection

    End Sub

    Private FileLocation As String
    ''' <summary>
    ''' Location of File being worked by this transaction.
    ''' </summary>
    ''' <returns>Filepath as string.</returns>
    Public Property File As String
        Get
            Return FileLocation
        End Get
        Set(value As String)
            FileLocation = value
            RowID = GetRowIDFromFilePath(value)
        End Set
    End Property

    Private RowID As Integer
    ''' <summary>
    ''' Database ID from the active row.
    ''' </summary>
    ''' <returns>Integer value from the row.</returns>
    Public Property FileID As Integer
        Get
            Return RowID
        End Get
        Set(value As Integer)
            RowID = value
        End Set
    End Property


    Private Function GetRowIDFromFilePath(ByVal FilePath As String) As Integer

        Dim da As New SqlDataAdapter
        Dim slct As New SqlCommand("SELECT ID FROM ManifestData WHERE FileLocation = @FilePath;", Connection)
        da.SelectCommand = slct
        slct.Parameters.Add("@FilePath", SqlDbType.VarChar)
        slct.Parameters("@FilePath").Value = FilePath
        Dim ds As New DataSet
        da.Fill(ds, "ManifestData")
        Return ds.Tables(0).Rows(0).Item(0)

    End Function

    Public Function UpdateRecord(ByVal Facility As Integer, ByVal Controls As Boolean, ByVal FillDate As String, ByVal Cycle As Boolean, ByVal Routing As Integer, ByVal KeyWords As String) As Boolean
        Dim da As New SqlDataAdapter
        Dim update As New SqlCommand("UPDATE ManifestData SET Facility = @facility, Controls = @controls, DeliveryDate = @filldate, Cycle = @cycle, Routing = @routing, AssociatedKeywords = @keywords, Verified = @verified, VerifyingUser = @verifyinguser WHERE ID = @ID;", Connection)
        With update.Parameters
            .Add("@facility", SqlDbType.Int)
            .Add("@controls", SqlDbType.Bit)
            .Add("@filldate", SqlDbType.VarChar)
            .Add("@cycle", SqlDbType.Bit)
            .Add("@routing", SqlDbType.Int)
            .Add("@keywords", SqlDbType.VarChar)
            .Add("@verified", SqlDbType.Bit)
            .Add("@verifyinguser", SqlDbType.VarChar)
            .Add("@ID", SqlDbType.Int)
        End With
        With update
            .Parameters("@facility").Value = Facility
            .Parameters("@controls").Value = Controls
            .Parameters("@filldate").Value = FillDate
            .Parameters("@cycle").Value = Cycle
            .Parameters("@routing").Value = Routing
            .Parameters("@keywords").Value = KeyWords
            .Parameters("@verified").Value = True
            .Parameters("@verifyinguser").Value = Environment.UserName
            .Parameters("@ID").Value = RowID
        End With

        Try
            update.ExecuteNonQuery()

        Catch ex As Exception
            Return False
            Exit Function
        End Try

        Return True
    End Function

End Class
