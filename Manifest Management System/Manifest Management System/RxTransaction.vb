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

End Class
