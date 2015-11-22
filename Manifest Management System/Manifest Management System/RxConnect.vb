Imports System.Data
Imports System.Data.SqlClient

Public Class RxConnect

    Private serverip As String
    Public Property ServerAddress As String
        Get
            Return serverip
        End Get
        Set(value As String)
            serverip = value
        End Set
    End Property

    Private instancenm As String
    Public Property ServerInstance As String
        Get
            Return instancenm
        End Get
        Set(value As String)
            instancenm = value
        End Set
    End Property

    Private portnumber As String
    Public Property Port As String
        Get
            Return portnumber
        End Get
        Set(value As String)
            portnumber = value
        End Set
    End Property

    Private dbname As String
    Public Property Database As String
        Get
            Return dbname
        End Get
        Set(value As String)
            dbname = value
        End Set
    End Property

    Private uname As String
    Public Property UserName As String
        Get
            Return uname
        End Get
        Set(value As String)
            uname = value
        End Set
    End Property

    Private pwd As String
    Public Property Password As String
        Get
            Return pwd
        End Get
        Set(value As String)
            pwd = value
        End Set
    End Property

    Private connected As Boolean
    Public ReadOnly Property Status As Boolean
        Get
            Return connected
        End Get
    End Property

    Public RxConnection As New SqlConnection

    Public Sub New(ByVal ServerAddress As String, ByVal ServerInstance As String, ByVal Port As String, ByVal Database As String, ByVal UserName As String, ByVal Password As String)
        RxConnection.ConnectionString = "Data Source=" & ServerAddress & "\" & ServerInstance & "," & Port & ";Network Library=DBMSSOCN;Database=" & Database & ";UID=" & UserName & ";PWD=" & Password & ";"
        Try
            RxConnection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            connected = False
            Exit Sub
        End Try
        serverip = ServerAddress
        instancenm = ServerInstance
        portnumber = Port
        dbname = Database
        uname = UserName
        pwd = Password
        connected = True
    End Sub

End Class
