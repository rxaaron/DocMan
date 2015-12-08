Imports System.IO
Public Class NetworkMonitor
    Public Declare Function WNetAddConnection2 Lib "mpr.dll" Alias "WNetAddConnection2A" (ByRef lpNetResource As NETRESOURCE, ByVal lpPassword As String, ByVal lpUserName As String, ByVal dwFlags As Integer) As Integer
    Public Declare Function WNetCancelConnection2 Lib "mpr" Alias "WNetCancelConnection2A" (ByVal lpName As String, ByVal dwFlags As Integer, ByVal fForce As Integer) As Integer
    Public Const ForceDisconnect As Integer = 1
    Public Const RESOURCETYPE_DISK As Long = &H1
    Private Const ERROR_BAD_NETPATH = 53&
    Private Const ERROR_NETWORK_ACCESS_DENIED = 65&
    Private Const ERROR_INVALID_PASSWORD = 86&
    Private Const ERROR_NETWORK_BUSY = 54&

    Public Structure NETRESOURCE
        Public dwScope As Integer
        Public dwType As Integer
        Public dwDisplayType As Integer
        Public dwUsage As Integer
        Public lpLocalName As String
        Public lpRemoteName As String
        Public lpComment As String
        Public lpProvider As String
    End Structure
    Public Function MapDrive(ByVal DriveLetter As String, ByVal UNCPath As String, ByVal strUsername As String, ByVal strPassword As String) As Boolean


        Dim nr As NETRESOURCE

        nr = New NETRESOURCE
        nr.lpRemoteName = UNCPath
        nr.lpLocalName = DriveLetter & ":"
        nr.lpProvider = Nothing
        nr.dwType = RESOURCETYPE_DISK

        Dim result As Integer
        result = WNetAddConnection2(nr, strPassword, strUsername, 0)

        If result = 0 Then
            Return True
        Else
            Select Case result
                Case ERROR_BAD_NETPATH
                    MsgBox("Bad path could not connect to Star Directory")
                Case ERROR_INVALID_PASSWORD
                    MsgBox("Invalid password could not connect to Star Directory")
                Case ERROR_NETWORK_ACCESS_DENIED
                    MsgBox("Network access denied could not connect to Star Directory")
                Case ERROR_NETWORK_BUSY
                    MsgBox("Network busy could not connect to Star Directory")
            End Select
            Return False
        End If

    End Function

    Public Function ManifestReady() As Boolean
        If Directory.Exists("M:\") = True Then
            Return True
        ElseIf MapDrive("M", "\\GMAP-SERVER\Encore_Manifest_Software", Nothing, Nothing) = True
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ScannedReady() As Boolean
        If Directory.Exists("O:\") = True Then
            Return True
        ElseIf MapDrive("O", "\\EncoreLaptop\ScanSnap", "encorelaptop\gmapuser", "Password1") = True
            Return True
        Else
            Return False
        End If
    End Function

End Class
