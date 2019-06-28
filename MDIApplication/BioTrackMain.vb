Imports System.Data
Imports System.Data.SqlClient
Imports system.IO
Imports MDIApplication.ClsUtil

Module BioTrackMain

    Public Structure stWorkOrders
        Public sWorkOrderNo As String
        'Public sWorkOrderNo As String
        Public dWorkOrderDate As Date
        Public sItemCode As String
        Public sItemDescription As String
        Public sBatchNo As String
        Public nActualQty As Double
        Public nActiveStentsCount As Double
        Public nInActiveStentsCount As Double
        Public nStentLength As Double
        Public sFormulationBatch As String
        Public sSerialPrefix As String
        Public sSerialSuffix As String
        Public sItemClass As String
        Public nFormConcentration As Double
        Public nActualAverageDose As Double
        Public nDummyAverageDose As Double
        Public nFormDrugRatioPostWt As Double
        Public nFormDrugRatioFifteenWt As Double
        Public nNormDose As Double
        Public nNomPLAPostWt As Double
        Public nNomPLAFifteenWt As Double
        Public nNomTotalPostWt As Double
        Public nNomTotalFifteenWt As Double
        Public nMaximumPostWt As Double
        Public nMaximumFifteenWt As Double
        Public nMinimumPostWt As Double
        Public nMinimumFifteenWt As Double
        Public nTotalGood As Double
        Public nTotalBad As Double
        Public nTotalStentsWeighedPostWt As Double
        Public nTotalStentsWeighedFifteenWt As Double
        Public nMedianCoatingPostWt As Double
        Public nMedianCoatingFifteenWt As Double
        Public nRelativeStdDeviationPostWt As Double
        Public nRelativeStdDeviationFifteenWt As Double
    End Structure

    Public db As New Class1
    Public clspm As New clsPublic_Methods
    Public sMainWorkOrderNO As String
    Public sMainOperation As Integer
    Public sLogonUser As String
    Public sUpdateMode As String
    Public sStentDS As DataSet
    Public sMainStatus As String
    Public sMainReasonCodes As String
    Public frmParent As MDIForm
    Public frmLogin As LogIn
    Public domainUser As String
    Public Username As String
    Public nUserPos As Integer
    Public UserFullName As String
    Public sDBServer As String
    Public sServerName As String
    Public sDBName As String
    Public sConnectionServer As String
    Public sFldColumnsName As String
    Public INIFilePath As String
    Public version As String
    Public Sql As String
    Public ds As DataSet
    Public sUserID As String
    Public sRoleid As String
    Public dsDimension As DataSet
    Public sDimSerialNo As String
    Public sNodeFormType As String
    Public conn As New SqlConnection(sConnectionServer)
    Public strQuery As String
    Public strMenuText As String
    Public sLoginCancel As Boolean = False
    Public sVersion As String
    Public sShipmentWorkOrderNO As String
    Public DdlAMPCValue As String
    Public sRptFileName As String
    Public stWODetails As stWorkOrders
    Public sLogFilePath As String
    Public sLogFileFolder As String

    Public Function getConnectionString(ByVal sConfigServer As String, ByVal Version As String)
        Dim connectionString As String
        'Dim sFileName As String
        'Dim ds As DataSet
        INIFilePath = sGetIniFilePath()
        If Not INIFilePath = "" Then
            sDBServer = INIRead(INIFilePath, sConfigServer, "ServerName")
            sDBName = INIRead(INIFilePath, sConfigServer, "DBName")
            connectionString = "SERVER=" & sDBServer & ";Database=" & sDBName & ";UId=exact;Trusted_Connection=Yes"
            ' Version = INIRead(INIFilePath, Version)
            Return connectionString
        Else
            MsgBox("Configuration File Could not be loaded...")
            Return ""
        End If
    End Function

    Public Function sGetIniFilePath() As String
        Dim sFileName As String
        Dim ds As DataSet

        sFileName = Path.Combine(Directory.GetCurrentDirectory, "config.xml")
        ds = New DataSet
        ds.ReadXml(sFileName)

        INIFilePath = MNS(ds.Tables(0).Rows(0)("INIFilePath")).ToString().Trim()
        'sVersion = MNS(ds.Tables(0).Rows(0)("version")).ToString().Trim()
        'sVersion = FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion.ToString
        sVersion = Application.ProductVersion.ToString()

        INIFilePath = LTrim(RTrim(INIFilePath))
        sVersion = LTrim(RTrim(sVersion))
        INIFilePath = INIFilePath & "\BioTrack.ini"    'LTrim(RTrim(INIFilePath))
        sGetIniFilePath = INIFilePath
    End Function

    Public Function getUserAuthentication() As Boolean

        Dim Success As Boolean = False
        Try
            Sql = "Select * from Users where userid = '" & sLogonUser & "'"

            ds = db.selectQuery(Sql)

            If (ds.Tables(0).Rows.Count > 0) Then
                If (ds.Tables(0).Rows(0).Item("stat") = 1) Then
                    Success = True
                    UserFullName = ds.Tables(0).Rows(0).Item("uname")
                Else
                    Success = False
                    MsgBox("User does not exist", MsgBoxStyle.Critical)

                End If
            Else
                UserFullName = ""
                Success = False
            End If
        Catch ex As System.Exception

            'MsgBox("database connection failed", MsgBoxStyle.Critical)
            'MsgBox(Err.Description)

        End Try
        Return (Success)

    End Function

End Module
