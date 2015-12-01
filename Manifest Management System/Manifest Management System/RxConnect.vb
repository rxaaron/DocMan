Imports System.Data
Imports System.Data.SqlClient
''' <summary>
''' Generic class that generates a functioning SqlConnection.
''' </summary>
Public Class RxConnect

    Private serverip As String
    ''' <summary>
    ''' This is the IP Address of the SQL Server.
    ''' </summary>
    ''' <returns>IP Address as String</returns>
    Public Property ServerAddress As String
        Get
            Return serverip
        End Get
        Set(value As String)
            serverip = value
        End Set
    End Property

    Private instancenm As String
    ''' <summary>
    ''' This is the Name of a Named Instance of the server.
    ''' </summary>
    ''' <returns>Instance Name as String</returns>
    Public Property ServerInstance As String
        Get
            Return instancenm
        End Get
        Set(value As String)
            instancenm = value
        End Set
    End Property

    Private portnumber As String
    ''' <summary>
    ''' This is the TCP Port for the server.
    ''' </summary>
    ''' <returns>Port as String</returns>
    Public Property Port As String
        Get
            Return portnumber
        End Get
        Set(value As String)
            portnumber = value
        End Set
    End Property

    Private dbname As String
    ''' <summary>
    ''' This is the name of the Database on the server.
    ''' </summary>
    ''' <returns>Database Name as String</returns>
    Public Property Database As String
        Get
            Return dbname
        End Get
        Set(value As String)
            dbname = value
        End Set
    End Property

    Private uname As String
    ''' <summary>
    ''' This is the sql authentication username for the database.
    ''' </summary>
    ''' <returns>Username as String</returns>
    Public Property UserName As String
        Get
            Return uname
        End Get
        Set(value As String)
            uname = value
        End Set
    End Property

    Private pwd As String
    ''' <summary>
    ''' This is the sql authentication password (in clear text) of the specific user for the database.
    ''' </summary>
    ''' <returns>Password in clear text as String</returns>
    Public Property Password As String
        Get
            Return pwd
        End Get
        Set(value As String)
            pwd = value
        End Set
    End Property

    Private connected As Boolean
    ''' <summary>
    ''' This is the indicator for the status of the connection.
    ''' </summary>
    ''' <returns>Connection Status as Boolean</returns>
    Public ReadOnly Property Status As Boolean
        Get
            Return connected
        End Get
    End Property

    Public RxConnection As New SqlConnection
    ''' <summary>
    ''' Begins a new instance of the RxConnect class.  Has several required parameters to start an Sql Connection.
    ''' </summary>
    ''' <param name="ServerAddress">IP Address</param>
    ''' <param name="ServerInstance">Name of Server Instance</param>
    ''' <param name="Port">TCP Port</param>
    ''' <param name="Database">Name of Database</param>
    ''' <param name="UserName">Username for database</param>
    ''' <param name="Password">Password for specified user</param>
    Public Sub New(ByVal ServerAddress As String, ByVal ServerInstance As String, ByVal Port As String, ByVal Database As String, ByVal UserName As String, ByVal Password As String)
        RxConnection.ConnectionString = "Data Source=" & ServerAddress & "\" & ServerInstance & "," & Port & ";Network Library=DBMSSOCN;Database=" & Database & ";UID=" & UserName & ";PWD=" & Password & ";"
        serverip = ServerAddress
        instancenm = ServerInstance
        portnumber = Port
        dbname = Database
        uname = UserName
        pwd = Password
    End Sub
    ''' <summary>
    ''' Closes Sql Connection.
    ''' </summary>
    Public Sub CloseConnection()
        RxConnection.Close()
        connected = False
    End Sub

    ''' <summary>
    ''' Attempts to Open connection.
    ''' </summary>
    Public Function OpenConnection() As Boolean
        Try
            RxConnection.Open()
            connected = True
        Catch ex As Exception
            MsgBox(ex.Message)
            connected = False
            Return False
        End Try
        Return True
    End Function

End Class
