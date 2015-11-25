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
    ''' <param name="SQLConnection">The required SqlConnection</param>
    Public Sub New(ByVal SQLConnection As SqlConnection)
        Connection = SQLConnection
    End Sub





End Class
