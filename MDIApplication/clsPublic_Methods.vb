Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Configuration
Imports System.DirectoryServices
Imports System.Text
Imports System.Text.StringBuilder
Imports System.Reflection
Imports System.IO
Imports System.IO.StreamWriter

Public Class clsPublic_Methods

    Public dsL As New DataSet
    Dim datRow As DataRow
    Public db As New Class1
    Public sMainWorkOrderNO As String
    Public sMainOperation As Integer
    Public sLogonUser As String
    Public sUpdateMode As String

    Public adPath As String = ConfigurationManager.AppSettings("loginURL")
    Public strQuery As String
    Private oFile As System.IO.File
    Private oWrite As System.IO.StreamWriter
    Private strNewRecord As String

    Public Function ValidateActiveDirectoryLogin(ByVal Username As String, ByVal Password As String) As Boolean
        Dim Success As Boolean = False
        Dim Entry As New System.DirectoryServices.DirectoryEntry("LDAP://" & adPath, Username, Password)

        Dim Searcher As New System.DirectoryServices.DirectorySearcher(Entry)
        Searcher.SearchScope = DirectoryServices.SearchScope.OneLevel
        Try
            Dim Results As System.DirectoryServices.SearchResult = Searcher.FindOne
            Success = Not (Results Is Nothing)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Success = False
        End Try
        Return (Success)
    End Function

    Public Function GetMenuData(ByVal LgnUser As String) As DataSet
        Dim strSQL As String
        Try
            '//Populate DataTable
            strSQL = ""
            strSQL = strSQL & "SELECT distinct bm.*,  br.menuid AS Expr1 FROM Biomenus bm "
            'strSQL = strSQL & " inner join "
            strSQL = strSQL & " join "
            strSQL = strSQL & " biorights br on br.menuid = bm.menuid "
            If LgnUser = "*" Then
                strSQL = strSQL & " and br.roleid = 'NONE' "
            Else
                strSQL = strSQL & " and br.roleid in ( select roleid from BioUserRights where userid = '" & LgnUser & "') "
            End If
            strSQL = strSQL & " where type not in (2,3) and isactive = 1 order by MainMenuId, seqNo"
            dsL = db.selectQuery(strSQL)
            Return dsL

        Catch ex As System.Exception
        End Try

    End Function

    Public Function CreateMenuItem(ByVal strText As String, ByVal MnuID As Double) As MenuItem
        Try
            '//Create new menu item
            Dim menuItem As New MenuItem()

            '//Set properties of the menu item
            With menuItem
                .Text = strText
                .Tag = MnuID
            End With
            Return menuItem

        Catch ex As System.Exception
        End Try

    End Function

    Public Function DynamicallyLoadedObject(ByVal objectName As String, Optional ByVal args() As Object = Nothing) As Form

        Dim returnObj As Object = Nothing
        Dim Type As Type = Assembly.GetExecutingAssembly().GetType("MDIApplication." & objectName)

        If Type IsNot Nothing Then
            returnObj = Activator.CreateInstance(Type, args)
            'returnObj.mdiparent = MDIForm
        End If

        Return returnObj

    End Function

    Public Property GetQueryString()
        Get
            Return strQuery
        End Get
        Set(ByVal value)
            strQuery = value
        End Set
    End Property

    Public Function GetSecurityRightsMenus(ByVal sRoleID As String) As DataSet
        Dim strSQL As String
        Try
            '//Populate DataTable
            If sRoleID <> "" Then
                strSQL = ""
                strSQL = strSQL & "SELECT bm.*, CASE WHEN br.roleid IS NULL THEN 0 ELSE 1 END AS HasAccess  FROM Biomenus bm "
                strSQL = strSQL & " Left Outer join biorights br on br.menuid = bm.menuid and bm.menuid >= 0  "
                strSQL = strSQL & " and br.roleid = '" & sRoleID & "' "
                strSQL = strSQL & " order by MainMenuId, seqNo"
            Else
                strSQL = ""
                strSQL = strSQL & "SELECT bm.* FROM Biomenus bm order by MainMenuId, seqNo "
            End If
            dsL = db.selectQuery(strSQL)
            Return dsL

        Catch ex As System.Exception
        End Try
    End Function

    Public Function GetUserRoles(ByVal sUserID As String) As DataSet
        Dim strSQL As String
        Try

            strSQL = ""
            strSQL = strSQL & "SELECT DISTINCT br.roleid, br.rolename, bur.userid, CASE WHEN bur.roleid IS NULL THEN 0 ELSE 1 END AS HasAccess"
            strSQL = strSQL & " FROM BioRoles AS br LEFT OUTER JOIN"
            strSQL = strSQL & " Biouserrights AS bur ON bur.userid = '" & sUserID & "' AND br.roleid = bur.roleid"
            '//Populate DataTable
            'strSQL = ""
            'strSQL = strSQL & "Select distinct bm.*, CASE WHEN br.roleid IS NULL THEN 0 ELSE 1 END AS HasAccess FROM BioMenus AS bm "
            'strSQL = strSQL & " LEFT OUTER JOIN  BioRights AS br ON br.menuid = bm.MenuID LEFT OUTER JOIN"
            'strSQL = strSQL & " Biouserrights AS bur ON bur.roleid = br.roleid AND bur.userid = '" & sUserID & "'"
            '' strSQL = strSQL & " where bur.roleid is not null"
            'strSQL = strSQL & " order by MainMenuId, seqNo"
            'strSQL = ""
            'strSQL = strSQL & "SELECT br.roleid, CASE WHEN br.roleid IS NULL THEN 0 ELSE 1 END AS HasAccess"
            'strSQL = strSQL & " from BioRoles AS br LEFT OUTER JOIN Biouserrights AS bur ON bur.userid = '" & sUserID & "'"
            'Dim datMenu As OleDbDataAdapter = New OleDbDataAdapter(strSQL, conn)
            dsL = db.selectQuery(strSQL)
            Return dsL

        Catch ex As System.Exception
        End Try

    End Function

    Public Function GetWorkOrderDetails(ByVal strWorkOrderNo As String) As Boolean

        'Sql = "SELECT project as WorkOrderNo, ItemCode as ItemCode, ItemDesc as ItemDescription, facode as BatchNo, QtyActual as Quantity, TotalCount as ActiveStentsCount, ItemStntLength as ItemStntLength, FormlnBatch as FormulationBatch, SerialPrefix, SerialSuffix, ItemClass as ItemClass FROM ZWOList WHERE project = '" & strWorkOrderNo & "' or facode = '" & strWorkOrderNo & "'"
        Sql = "SELECT project as WorkOrderNo, StartDate as WoDate, ItemCode as ItemCode, ItemDesc as ItemDescription, facode as BatchNo, QtyActual as Quantity, TotalCount as ActiveStentsCount, isnull(StntLength,0) as StntLength, FormlnBatch as FormulationBatch, SerialPrefix, SerialSuffix, ItemClass as ItemClass, FConcentration as 'FormConcentration', Actual_AvgDose as 'ActualAverageDose', Dummy_AvgDose as 'DummyAverageDose', FrmDrugRatioPostWt as 'FormDrugRatioPostWt', FrmDrugRatioFifteenWt as 'FormDrugRatioFifteenWt', isnull(NormDose,0) as 'NormDose' , case FrmDrugRatioPostWt when 0 then 0 else (NormDose * (1 - FrmDrugRatioPostWt)/ FrmDrugRatioPostWt) end as 'NomPLAPostWt', case FrmDrugRatioFifteenWt when 0 then 0 else (NormDose * (1 - FrmDrugRatioFifteenWt)/ FrmDrugRatioFifteenWt) end as 'NomPLAFifteenWt', case FrmDrugRatioPostWt when 0 then 0 else (NormDose + (NormDose * (1 - FrmDrugRatioPostWt)/ FrmDrugRatioPostWt)) end as 'NomTotalPostWt', case FrmDrugRatioFifteenWt when 0 then 0 else (NormDose + (NormDose * (1 - FrmDrugRatioFifteenWt)/ FrmDrugRatioFifteenWt)) end as 'NomTotalFifteenWt', MaximumPostWt as 'MaximumPostWt', MaximumFifteenWt as 'MaximumFifteenWt', MinimumPostWt as 'MinimumPostWt', MinimumFifteenWt as 'MinimumFifteenWt', TotalGood, TotalBad, TotalWeightedPostWt, TotalWeightedFifteenWt, MedianPostWt, MedianFifteenWt, RelStdDevPostWt as 'RelativeStdDeviationPostWt', RelStdDevFifteenWt as 'RelativeStdDeviationFifteenWt' FROM ZWOList WHERE project = '" & strWorkOrderNo & "' or facode = '" & strWorkOrderNo & "'"
        ' Sql = "EXEC dbo.GerWordOrderDetails '" & strWorkOrderNo & "'"
        ds = db.selectQuery(Sql)

        If ds.Tables(0).Rows.Count > 0 Then
            GetWorkOrderDetails = True
            stWODetails.sWorkOrderNo = Trim(ds.Tables(0).Rows(0).Item("WorkOrderNo"))
            stWODetails.dWorkOrderDate = Trim(ds.Tables(0).Rows(0).Item("WODate"))
            stWODetails.sItemCode = Trim(ds.Tables(0).Rows(0).Item("ItemCode"))
            stWODetails.sItemDescription = Trim(ds.Tables(0).Rows(0).Item("ItemDescription"))
            stWODetails.sBatchNo = Trim(ds.Tables(0).Rows(0).Item("BatchNo"))
            stWODetails.nActualQty = Trim(ds.Tables(0).Rows(0).Item("Quantity"))
            stWODetails.nActiveStentsCount = Trim(ds.Tables(0).Rows(0).Item("ActiveStentsCount"))
            stWODetails.nInActiveStentsCount = Trim(ds.Tables(0).Rows(0).Item("Quantity")) - Trim(ds.Tables(0).Rows(0).Item("ActiveStentsCount"))
            stWODetails.nStentLength = Trim(ds.Tables(0).Rows(0).Item("StntLength"))
            stWODetails.sFormulationBatch = Trim(ds.Tables(0).Rows(0).Item("FormulationBatch"))
            stWODetails.sSerialPrefix = Trim(ds.Tables(0).Rows(0).Item("SerialPrefix"))
            stWODetails.sSerialSuffix = Trim(ds.Tables(0).Rows(0).Item("SerialSuffix"))
            stWODetails.sItemClass = Trim(ds.Tables(0).Rows(0).Item("ItemClass"))
            stWODetails.nFormConcentration = Trim(ds.Tables(0).Rows(0).Item("FormConcentration"))
            stWODetails.nActualAverageDose = Trim(ds.Tables(0).Rows(0).Item("ActualAverageDose"))
            stWODetails.nDummyAverageDose = Trim(ds.Tables(0).Rows(0).Item("DummyAverageDose"))
            stWODetails.nFormDrugRatioPostWt = Trim(ds.Tables(0).Rows(0).Item("FormDrugRatioPostWt"))
            stWODetails.nFormDrugRatioFifteenWt = Trim(ds.Tables(0).Rows(0).Item("FormDrugRatioFifteenWt"))
            stWODetails.nNormDose = Trim(ds.Tables(0).Rows(0).Item("NormDose"))
            stWODetails.nNomPLAPostWt = Trim(ds.Tables(0).Rows(0).Item("NomPLAPostWt"))
            stWODetails.nNomPLAFifteenWt = Trim(ds.Tables(0).Rows(0).Item("NomPLAFifteenWt"))
            stWODetails.nNomTotalPostWt = Trim(ds.Tables(0).Rows(0).Item("NomTotalPostWt"))
            stWODetails.nNomTotalFifteenWt = Trim(ds.Tables(0).Rows(0).Item("NomTotalFifteenWt"))
            stWODetails.nMaximumPostWt = Trim(ds.Tables(0).Rows(0).Item("MaximumPostWt"))
            stWODetails.nMaximumFifteenWt = Trim(ds.Tables(0).Rows(0).Item("MaximumFifteenWt"))
            stWODetails.nMinimumPostWt = Trim(ds.Tables(0).Rows(0).Item("MinimumPostWt"))
            stWODetails.nMinimumFifteenWt = Trim(ds.Tables(0).Rows(0).Item("MinimumFifteenWt"))
            stWODetails.nTotalGood = Trim(ds.Tables(0).Rows(0).Item("TotalGood"))
            stWODetails.nTotalBad = Trim(ds.Tables(0).Rows(0).Item("TotalBad"))
            stWODetails.nTotalStentsWeighedPostWt = Trim(ds.Tables(0).Rows(0).Item("TotalWeightedPostWt"))
            stWODetails.nTotalStentsWeighedFifteenWt = Trim(ds.Tables(0).Rows(0).Item("TotalWeightedFifteenWt"))
            stWODetails.nMedianCoatingPostWt = Trim(ds.Tables(0).Rows(0).Item("MedianPostWt"))
            stWODetails.nMedianCoatingFifteenWt = Trim(ds.Tables(0).Rows(0).Item("MedianFifteenWt"))
            stWODetails.nRelativeStdDeviationPostWt = Trim(ds.Tables(0).Rows(0).Item("RelativeStdDeviationPostWt"))
            stWODetails.nRelativeStdDeviationFifteenWt = Trim(ds.Tables(0).Rows(0).Item("RelativeStdDeviationFifteenWt"))
        Else
            GetWorkOrderDetails = False
            stWODetails.sWorkOrderNo = ""
            stWODetails.dWorkOrderDate = Date.Today
            stWODetails.sItemCode = ""
            stWODetails.sItemDescription = ""
            stWODetails.sBatchNo = ""
            stWODetails.nActualQty = 0
            stWODetails.nActiveStentsCount = 0
            stWODetails.nInActiveStentsCount = 0
            stWODetails.nStentLength = 0
            stWODetails.sFormulationBatch = ""
            stWODetails.sSerialPrefix = ""
            stWODetails.sSerialSuffix = ""
            stWODetails.sItemClass = ""
            stWODetails.nFormConcentration = 0
            stWODetails.nActualAverageDose = 0
            stWODetails.nDummyAverageDose = 0
            stWODetails.nFormDrugRatioPostWt = 0
            stWODetails.nFormDrugRatioFifteenWt = 0
            stWODetails.nNormDose = 0
            stWODetails.nNomPLAPostWt = 0
            stWODetails.nNomPLAFifteenWt = 0
            stWODetails.nNomTotalPostWt = 0
            stWODetails.nNomTotalFifteenWt = 0
            stWODetails.nMaximumPostWt = 0
            stWODetails.nMaximumFifteenWt = 0
            stWODetails.nMinimumPostWt = 0
            stWODetails.nMinimumFifteenWt = 0
            stWODetails.nTotalGood = 0
            stWODetails.nTotalBad = 0
            stWODetails.nTotalStentsWeighedPostWt = 0
            stWODetails.nTotalStentsWeighedFifteenWt = 0
            stWODetails.nMedianCoatingPostWt = 0
            stWODetails.nMedianCoatingFifteenWt = 0
            stWODetails.nRelativeStdDeviationPostWt = 0
            stWODetails.nRelativeStdDeviationFifteenWt = 0
        End If
    End Function

    Public Function GetAvaialbleSerialNos(ByVal WoNo As String)

        Sql = "select count(stntserial) as TotalCount from stentserials where stwono = '" & WoNo & "' and status = 1 and stenttype=1"
        ds = db.selectQuery(Sql)

        Return ds.Tables(0).Rows(0).Item("TotalCount")

    End Function

    Public Sub WriteStentSerials(ByVal WONo As String, ByVal StentType As String)

        ' To check if directory and file exist and then create new ones

        Dim count, DmyCount As Integer
        Dim StentSerial As String
        Dim iStentType As Integer
        Dim nTotalSerials As Integer
        Dim bWriteDataFlag As Boolean

        'sLogFileFolder = "\\bit\Public\IT\Abbas\StentSerials"
        sLogFileFolder = INIRead(INIFilePath, sServerName, "Label_DataPath")
        sLogFilePath = sLogFileFolder & "\" & WONo & StentType & ".DAT"

        'If folder doesn't exist, create folder and file
        If Not Directory.Exists(sLogFileFolder) Then
            Directory.CreateDirectory(sLogFileFolder)
            oWrite = New StreamWriter(sLogFilePath)
            oWrite.Close()
        Else
            'If file doesn't exist, create file
            If Not File.Exists(sLogFilePath) Then
                oWrite = New StreamWriter(sLogFilePath)
                oWrite.Close()
            Else
                'If file exists, delete old file and create new file
                File.Delete(sLogFilePath)
                oWrite = New StreamWriter(sLogFilePath)
                oWrite.Close()
            End If
        End If

        If StentType = "N" Then
            iStentType = 1
        Else
            iStentType = 2
        End If

        Sql = "select stntserial from stentserials where stwono='" & WONo & "' and status=1 and stenttype=" & iStentType
        ds = db.selectQuery(Sql)

        ' Insert serials into file
        If oFile.Exists(sLogFilePath) = True Then

            oWrite = oFile.AppendText(sLogFilePath)
            DmyCount = 0
            nTotalSerials = ds.Tables(0).Rows.Count - 1
            StentSerial = ""
            For count = 0 To nTotalSerials         'ds.Tables(0).Rows.Count - 1

                ' bWriteDataFlag = False
                If iStentType = 1 Then   ' Normal Stent
                    StentSerial = ds.Tables(0).Rows(count).Item("stntserial")
                    oWrite.WriteLine(StentSerial)
                Else   ' Dummy Stent
                    If DmyCount < 3 Then
                        If Len(Trim(StentSerial)) > 0 Then
                            StentSerial = StentSerial & "," & ds.Tables(0).Rows(count).Item("stntserial")
                        Else
                            StentSerial = ds.Tables(0).Rows(count).Item("stntserial")
                        End If
                        DmyCount = DmyCount + 1
                        ' bWriteDataFlag = False
                    ElseIf DmyCount >= 3 Or count >= nTotalSerials Then
                        oWrite.WriteLine(StentSerial)
                        StentSerial = ""
                        StentSerial = ds.Tables(0).Rows(count).Item("stntserial")
                        DmyCount = 1
                    End If

                    End If
                'oWrite.WriteLine(StentSerial)
            Next
            If Len(Trim(StentSerial)) > 0 Then
                oWrite.WriteLine(StentSerial)
            End If
            oWrite.Flush()
            oWrite.Close()
            oWrite = Nothing
        End If

    End Sub

End Class
