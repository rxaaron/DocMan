Imports System.IO
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
    ''' <param name="CurrentFilePath">The location of the current file being worked.</param>
    Public Sub New(ByVal SQLConnection As SqlConnection, ByVal CurrentFilePath As String)
        Connection = SQLConnection
        FileLocation = CurrentFilePath
    End Sub


    ''' <summary>
    ''' New instance of the class requires an SqlConnection be specified to simplify later code.
    ''' </summary>
    ''' <param name="SQLConnection">The required SqlConnection.</param>
    ''' <param name="RowIdentifier">The ID corresponding to the file being worked.</param>
    Public Sub New(ByVal SQLConnection As SqlConnection, ByVal RowIdentifier As Integer)
        Connection = SQLConnection
        RowID = RowIdentifier
    End Sub

    Private FileLocation As String
    ''' <summary>
    ''' Location of File being worked by this transaction.
    ''' </summary>
    ''' <returns>Filepath as string.</returns>
    Public Property FilePath As String
        Get
            Return FileLocation
        End Get
        Set(value As String)
            FileLocation = value
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
            SetInfoFromRowID(value)
        End Set
    End Property

    Private FacilityInteger As Integer
    ''' <summary>
    ''' Database integer for facility.
    ''' </summary>
    ''' <returns>Integer.</returns>
    Public Property FacilityID As Integer
        Get
            Return FacilityInteger
        End Get
        Set(value As Integer)
            FacilityInteger = value
        End Set
    End Property

    Private ControlsBool As Boolean
    Public Property IsControls As Boolean
        Get
            Return ControlsBool
        End Get
        Set(value As Boolean)
            ControlsBool = value
        End Set
    End Property

    Private FillDateShort As String
    Public Property FillDateString As String
        Get
            Return FillDateShort
        End Get
        Set(value As String)
            FillDateShort = value
        End Set
    End Property

    Private CycleBool As Boolean
    Public Property IsCycle As Boolean
        Get
            Return CycleBool
        End Get
        Set(value As Boolean)
            CycleBool = value
        End Set
    End Property

    Private RoutingInteger As Integer
    Public Property RoutingID As Integer
        Get
            Return RoutingInteger
        End Get
        Set(value As Integer)
            RoutingInteger = value
        End Set
    End Property

    Private KeyWordsString As String
    Public Property KeyWordList As String
        Get
            Return KeyWordsString
        End Get
        Set(value As String)
            KeyWordsString = value
        End Set
    End Property

    Private VerifiedBool As Boolean
    Public Property IsVerified As Boolean
        Get
            Return VerifiedBool
        End Get
        Set(value As Boolean)
            VerifiedBool = value
        End Set
    End Property

    Private VUserName As String
    Public Property VerifyingUserName As String
        Get
            Return VUserName
        End Get
        Set(value As String)
            VUserName = value
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
        Return CInt(ds.Tables("ManifestData").Rows(0).Item("ID"))

    End Function

    Private Sub SetInfoFromRowID(ByVal RowID As Integer)

        Dim da As New SqlDataAdapter
        Dim slct As New SqlCommand("SELECT FileLocation, Facility, Controls, DeliveryDate, Cycle, Routing, Verified, AssociatedKeywords, VerifyingUser FROM ManifestData WHERE ID = @rowid;", Connection)
        da.SelectCommand = slct
        slct.Parameters.Add("@rowid", SqlDbType.Int)
        slct.Parameters("@rowid").Value = RowID
        Dim ds As New DataSet
        da.Fill(ds, "ManifestData")

        FileLocation = ds.Tables("ManifestData").Rows(0).Item("FileLocation").ToString
        FacilityInteger = CInt(ds.Tables("ManifestData").Rows(0).Item("Facility"))
        ControlsBool = CBool(ds.Tables("ManifestData").Rows(0).Item("Controls"))
        FillDateShort = ds.Tables("ManifestData").Rows(0).Item("DeliveryDate").ToString
        CycleBool = CBool(ds.Tables("ManifestData").Rows(0).Item("Cycle"))
        RoutingInteger = CInt(ds.Tables("ManifestData").Rows(0).Item("Routing"))
        VerifiedBool = CBool(ds.Tables("ManifestData").Rows(0).Item("Verified"))
        KeyWordsString = ds.Tables("ManifestData").Rows(0).Item("AssociatedKeywords").ToString
        VUserName = ds.Tables("ManifestData").Rows(0).Item("VerifyingUser").ToString

    End Sub

    Private Sub UpdateInformation(ByVal FilePath As String, ByVal Facility As Integer, ByVal Controls As Boolean, ByVal FillDate As String, ByVal Cycle As Boolean, ByVal Routing As Integer, ByVal Verified As Boolean, ByVal Keywords As String, ByVal VerifyingUser As String)

        FileLocation = FilePath
        FacilityInteger = Facility
        ControlsBool = Controls
        FillDateShort = FillDate
        CycleBool = Cycle
        RoutingInteger = Routing
        VerifiedBool = Verified
        KeyWordsString = Keywords
        VUserName = VerifyingUser

    End Sub

    Public Function UpdateRecord(ByVal Facility As Integer, ByVal Controls As Boolean, ByVal FillDate As String, ByVal Cycle As Boolean, ByVal Routing As Integer, ByVal KeyWords As String) As Boolean
        Dim da As New SqlDataAdapter
        Dim update As New SqlCommand("UPDATE ManifestData SET Facility = @facility, Controls = @controls, DeliveryDate = @filldate, Cycle = @cycle, Routing = @routing, AssociatedKeywords = @keywords, Verified = @verified, VerifyingUser = @verifyinguser WHERE ID = @ID;", Connection)
        With update.Parameters
            .Add("@facility", SqlDbType.Int)
            .Add("@controls", SqlDbType.Bit)
            .Add("@filldate", SqlDbType.Date)
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
        da.UpdateCommand = update

        Try
            update.ExecuteNonQuery()
            UpdateInformation(FileLocation, Facility, Controls, FillDate, Cycle, Routing, True, KeyWords, Environment.UserName)
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

    Public Function InsertRecord(ByVal Facility As Integer, ByVal Controls As Boolean, ByVal FillDate As String, ByVal Cycle As Boolean, ByVal Routing As Integer, ByVal KeyWords As String) As Boolean
        Dim da As New SqlDataAdapter
        Dim insert As New SqlCommand("INSERT INTO ManifestData (FileLocation,Facility,Controls,DeliveryDate,Cycle,Routing,AssociatedKeywords,Verified) VALUES (@filelocation,@facility,@controls,@filldate,@cycle,@routing,@keywords,@verified);", Connection)
        With insert.Parameters
            .Add("@filelocation", SqlDbType.VarChar)
            .Add("@facility", SqlDbType.Int)
            .Add("@controls", SqlDbType.Bit)
            .Add("@filldate", SqlDbType.Date)
            .Add("@cycle", SqlDbType.Bit)
            .Add("@routing", SqlDbType.Int)
            .Add("@keywords", SqlDbType.VarChar)
            .Add("@verified", SqlDbType.Bit)
        End With
        With insert
            .Parameters("@filelocation").Value = FileLocation
            .Parameters("@facility").Value = Facility
            .Parameters("@controls").Value = Controls
            .Parameters("@filldate").Value = FillDate
            .Parameters("@cycle").Value = Cycle
            .Parameters("@routing").Value = Routing
            .Parameters("@keywords").Value = KeyWords
            .Parameters("@verified").Value = False
        End With
        da.InsertCommand = insert

        Try
            insert.ExecuteNonQuery()
            RowID = GetRowIDFromFilePath(FileLocation)
            SetInfoFromRowID(RowID)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Public Function MoveFiles(ByVal MoveToFilePath As String) As Boolean

        Try
            File.Move(FileLocation, MoveToFilePath)
            FileLocation = MoveToFilePath
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Public Sub LogErrors(ByVal ErrorMessage As String)
        Dim da As New SqlDataAdapter
        Dim insert As New SqlCommand("INSERT INTO FileErrors (FilePath, ErrorText) VALUES (@file, @error);", Connection)
        da.InsertCommand = insert
        insert.Parameters.Add("@file", SqlDbType.VarChar)
        insert.Parameters.Add("@error", SqlDbType.VarChar)
        insert.Parameters("@file").Value = FileLocation
        insert.Parameters("@error").Value = ErrorMessage
        insert.ExecuteNonQuery()
    End Sub

End Class
