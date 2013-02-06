Imports Microsoft.VisualBasic.ApplicationServices.AssemblyInfo
Imports clMainLib.General.clsGeneral
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection
Module mdlMain

    Public Function GetLastNo(ByVal cKdTrans As String, _
                               ByVal nThn As Integer, _
                               Optional ByRef cmd As SqlCommand = Nothing, _
                               Optional ByRef myTrans As SqlTransaction = Nothing) As String
        ' fungsi ini akan mengambil nomor terakhir dari nomor transaksi yang ada
        ' di semua tabel transaksi berdasarkan cIDTrans dan nThn input.
        ' cIDTrans : jenis transaksi
        ' nThn : tahun transaksi

        Dim strSQL As String
        Dim intNo As Long = 0
        Dim bAda As Boolean = False
        Dim objReader As SqlDataReader

        If IsNothing(cmd) Then cmd = New SqlCommand
        GetLastNo = ""
        Try
            strSQL = "select max(bgn_Number) as lastNo " & _
                     "from fakdres where " & _
                     "((vc_kd_trans = '" & Trim(cKdTrans) & "') and " & _
                     "(int_Thn = " & nThn & "))"
            objReader = clMain.clUtama.GeneralQuery(strSQL)

            While objReader.Read()
                If Not IsDBNull(objReader("lastNo")) Then
                    intNo = objReader("lastNo")
                    bAda = True
                End If
            End While
            'MsgBox(bAda)
            intNo += 1
            objReader.Close()

            'GetLastNo = Trim(cKdTrans) & "" & clMain.clUtama.strPad(Trim(CStr(nThn)), 2) & "" & clMain.clUtama.strPad(Trim(CStr(nBln)), 2) & "" & clMain.clUtama.strPad(CStr(intNo), 6)
            GetLastNo = Trim(cKdTrans) & "" & clMain.clUtama.strPad(Trim(CStr(nThn)), 2) & "" & clMain.clUtama.strPad(CStr(intNo), 4)
            ' MsgBox(GetLastNo)
            If bAda = True Then
                ' update dengan nomor yang baru jika data ada
                strSQL = "update fakdres set bgn_Number = " & intNo & " where " & _
                         "((vc_Kd_trans = '" & Trim(cKdTrans) & "') and " & _
                         "(int_Thn = " & nThn & "))"
                clMain.clUtama.GeneralCommand(strSQL, cmd)
            Else
                ' tambah data dengan nomor baru jika data tidak ada
                strSQL = "insert into fakdres values('" & Trim(cKdTrans) & "', " & nThn & "," & intNo & ")"
                clMain.clUtama.GeneralCommand(strSQL, cmd)
            End If
        Catch e As Exception    'MySqlException
        End Try
    End Function
    Public Sub ReadValuesINIFiles()
        Dim cINIFileName As String = Application.StartupPath & "\" & "Application.ini"

        clMain.cNamaServer = clMain.clUtama.ConvertPass(clMain.clUtama.ReadValueINIFile("Connection", "ServerName_", cINIFileName), "D")
        clMain.cNamaDatabase = clMain.clUtama.ConvertPass(clMain.clUtama.ReadValueINIFile("Connection", "DBName_", cINIFileName), "D")
        clMain.cNamaUser = clMain.clUtama.ConvertPass(clMain.clUtama.ReadValueINIFile("Connection", "UN_", cINIFileName), "D")
        clMain.cPassUser = clMain.clUtama.ConvertPass(clMain.clUtama.ReadValueINIFile("Connection", "Pwd_", cINIFileName), "D")

        clMain.cRegistryLoc = clMain.clUtama.ConvertPass(clMain.clUtama.ReadValueINIFile("Connection", "RegistryLoc_", cINIFileName), "D")
        clMain.cRegKeyGroups = clMain.clUtama.ConvertPass(clMain.clUtama.ReadValueINIFile("Connection", "Regkeygroups_", cINIFileName), "D")
        clMain.ckd_unit = clMain.clUtama.ConvertPass(clMain.clUtama.ReadValueINIFile("variabel", "ckd_unit", cINIFileName), "D")
        clMain.cwh = clMain.clUtama.ConvertPass(clMain.clUtama.ReadValueINIFile("variabel", "cwh", cINIFileName), "D")

        clMain.cAppsName = clMain.clUtama.ReadValueINIFile("Application", "Name", cINIFileName)
        clMain.cRSName = clMain.clUtama.ReadValueINIFile("Application", "RSName", cINIFileName)
        clMain.cCopyRight = clMain.clUtama.ReadValueINIFile("Application", "Copyright", cINIFileName)

        'LOKAL
        'clMain.cGustu = clMain.clUtama.ReadValueINIFile("Modul", "Gustu", cINIFileName)
        'clMain.cIDApps = clMain.clUtama.ReadValueINIFile("Modul", "IDApps", cINIFileName)
        'clMain.cIDModul = clMain.clUtama.ReadValueINIFile("Modul", "IDModul", cINIFileName)

        clMain.cModulName = clMain.clUtama.ReadValueINIFile("Modul", "Name", cINIFileName)
        clMain.cSubModulName = clMain.clUtama.ReadValueINIFile("Modul", "SubName", cINIFileName)
        clMain.cHeaderMsg = clMain.cModulName

    End Sub
    Public Sub SetDataTableRightOnMenu(ByVal cUser As String, _
                                    ByVal cAppsID As String, _
                                    ByVal cOwner As String)
        Dim objComm As New SqlCommand
        Dim objDS As New DataSet
        Dim objDT As New DataTable
        Dim objDA As New SqlDataAdapter

        Try
            objComm.Connection = clMain.clUtama.objConnection
            objDS = clMain.clUtama.SetDataTableRightOnMenu(cUser, cAppsID, cOwner, objComm)
            objDA.SelectCommand = objComm
            objDA.Fill(objDS)
            objDT = objDS.Tables(0)
            clMain.dtAccess = objDT
        Catch ex As Exception
        Finally
            objComm.Dispose()
            objDS.Dispose()
            objDA.Dispose()
            objDT.Dispose()
        End Try
    End Sub
    Public Function Bulat(ByVal Nilai As Double) As Double
        Dim pBulat As Double = 0
        Try
            If Double.Parse(Nilai) = 0 Then
                pBulat = Nilai
            ElseIf Double.Parse(Nilai.ToString.Substring(Nilai.ToString.Length - 2)) > 0 And Double.Parse(Nilai.ToString.Substring(Nilai.ToString.Length - 2)) <= 50 Then
                pBulat = Nilai - Double.Parse(Nilai.ToString.Substring(Nilai.ToString.Length - 2)) + 50
            ElseIf Double.Parse(Nilai.ToString.Substring(Nilai.ToString.Length - 2)) > 50 And Double.Parse(Nilai.ToString.Substring(Nilai.ToString.Length - 2)) <= 100 Then
                pBulat = Nilai - Double.Parse(Nilai.ToString.Substring(Nilai.ToString.Length - 2)) + 100
            Else
                pBulat = Nilai
            End If
        Catch ex As Exception
            ex.Message.ToString()
        End Try
        Return pBulat
    End Function
    Public Function GetMenuRight(ByVal cKode As String, ByVal nType As Byte) As Boolean
        GetMenuRight = False
        Dim foundRows() As DataRow
        foundRows = clMain.dtAccess.Select("vc_codemenu = '" & Trim(cKode) & "'")
        Select Case nType
            Case 0 ' cek status enable
                If foundRows.Length > 0 Then GetMenuRight = foundRows(0)("bt_enable")
            Case 1 ' cek status visible
                If foundRows.Length > 0 Then GetMenuRight = foundRows(0)("bt_visible")
            Case 2 ' cek status access
                If foundRows.Length > 0 Then GetMenuRight = foundRows(0)("bt_access")
        End Select
    End Function
    Public Function GetLastNoBukti(ByVal cPrefix As String, _
                                  ByVal dtTgl As Date, _
                                  Optional ByRef cmd As SqlCommand = Nothing, _
                                  Optional ByRef myTrans As SqlTransaction = Nothing, _
                                  Optional ByVal cGugus As String = "") As String
        Dim strSQL As String
        Dim intNo As Long = 0
        Dim bAda As Boolean = False
        Dim objReader As SqlDataReader
        Dim cThn As String = dtTgl.ToString("yy")
        Dim cBln As String = dtTgl.ToString("MM")
        Dim cTgl As String = dtTgl.ToString("dd")


        If IsNothing(cmd) Then cmd = New SqlCommand
        GetLastNoBukti = ""
        Try
            strSQL = "select * from counter " & _
                     "where vc_Thn = '" & cThn & "' " & _
                     "and vc_Bln = '" & cBln & "' " & _
                     "and vc_Tgl = '" & cTgl & "' " & _
                     "and vc_prefix = '" & cPrefix & "' "
            If cGugus.Trim.Length > 0 Then strSQL += "and vc_k_gugus = '" & cGugus & "';"
            objReader = clMain.clUtama.GeneralQuery(strSQL)
            If objReader.HasRows Then
                While objReader.Read()
                    If Not IsDBNull(objReader("vc_prefix")) Then
                        If Not IsDBNull(objReader("bg_counter")) Then
                            intNo = objReader("bg_counter")
                            bAda = True
                        End If
                    End If
                End While
            End If
            intNo += 1
            objReader.Close()
            GetLastNoBukti = Trim(cPrefix) & dtTgl.ToString("yyMMdd") & "" & clMain.clUtama.strPad(CStr(intNo), 3)
            If bAda = True Then
                ' update dengan nomor yang baru jika data ada
                strSQL = "update counter set " & _
                         "bg_counter = " & intNo & " where " & _
                         "(vc_prefix = '" & Trim(cPrefix) & "') and " & _
                         "(vc_thn = '" & cThn & "') and " & _
                         "(vc_bln = '" & cBln & "') and " & _
                         "(vc_tgl = '" & cTgl & "') "
                If cGugus.Trim.Length > 0 Then strSQL += "and (vc_k_gugus = '" & cGugus & "');"
                clMain.clUtama.GeneralCommand(strSQL, cmd)
            Else
                ' tambah data dengan nomor baru jika data tidak ada
                strSQL = "insert into counter values('" & cPrefix.Trim & "', '" & cThn.Trim & _
                         "', '" & cBln.Trim & "', '" & cTgl.Trim & "', '" & _
                         cGugus.Trim & "', " & intNo & ")"
                clMain.clUtama.GeneralCommand(strSQL, cmd)
            End If
        Catch e As Exception    'MySqlException
        End Try
    End Function
    Function ShowData(ByVal cField1 As String, ByVal cField2 As String, _
   ByVal cTable As String, ByVal cKode As String, ByVal cCaption As String) As String
        Dim strsql As String
        Dim lAda As Boolean
        ShowData = ""
        lAda = False
        If clMain.clUtama.StatusKoneksi = True Then
            strsql = "select " & cField1 & ", " & cField2 & " from " & cTable & " where " & cField1 & "='" & Trim(cKode) & "'"
            Dim objcommand As New SqlCommand(strsql, clMain.clUtama.objConnection)
            Dim objdatareader As SqlDataReader
            objdatareader = objcommand.ExecuteReader
            ShowData = ""
            While objdatareader.Read
                lAda = True
                ShowData = Trim(objdatareader(1))
            End While
            objdatareader.Close()
        End If
        If Not lAda Then
            If cCaption <> "" Then
                MsgBox("Kode " & cCaption & " belum terdaftar!...", MsgBoxStyle.Critical, "Pesan")
            End If
        End If
    End Function
    Public Function HitTotkoreksi(ByVal cNoBukti As String, ByVal cKodeObat As String) As Integer
        Dim strsql As String = ""
        Dim nJumlah As Integer = 0

        HitTotkoreksi = 0

        strsql = "SELECT dbo.FA_ibs_hKtrans.vc_no_trans, dbo.FA_ibs_dKtrans.vc_kd_obat, SUM(dbo.FA_ibs_dKtrans.fl_jml_koreksi) AS TOTRETUR " & _
                 "FROM dbo.FA_ibs_hKtrans LEFT OUTER JOIN " & _
                 "dbo.FA_ibs_dKtrans ON dbo.FA_ibs_hKtrans.vc_no_koreksi = dbo.FA_ibs_dKtrans.vc_no_koreksi " & _
                 "where vc_no_trans = '" & cNoBukti & "' and vc_kd_obat = '" & cKodeObat & "' " & _
                 "GROUP BY dbo.FA_ibs_dktrans.vc_kd_obat, dbo.FA_ibs_hktrans.vc_no_trans "

        Dim objdatareader1 As SqlDataReader = Nothing
        objdatareader1 = clMain.clTanggal.GeneralQuery(strsql)
        While objdatareader1.Read
            nJumlah = Trim(objdatareader1("TOTRETUR"))
        End While
        objdatareader1.Close()
        HitTotkoreksi = nJumlah
    End Function
    Public Function HitTotRet(ByVal cNoBukti As String, ByVal cKodeObat As String) As Integer
        Dim strsql As String = ""
        Dim nJumlah As Integer = 0

        HitTotRet = 0

        strsql = "SELECT dbo.fa_resep_in_retur.vc_kd_resep, dbo.fa_resep_in_retur.vc_kd_obat," & _
                 "SUM(dbo.fa_resep_in_retur.fl_jumlah_retur) AS TOTRETUR " & _
                 "FROM dbo.fa_resep_in_retur " & _
                 "where vc_KD_resep = '" & cNoBukti & "' and vc_kd_obat = '" & cKodeObat & "' " & _
                 "GROUP BY vc_kd_obat, vc_kd_resep "
        Dim objdatareader1 As SqlDataReader = Nothing
        objdatareader1 = clMain.clTanggal.GeneralQuery(strsql)
        While objdatareader1.Read
            nJumlah = Trim(objdatareader1("TOTRETUR"))
        End While
        objdatareader1.Close()
        HitTotRet = nJumlah
    End Function
    'Public Function GetLastNo(ByVal cKdTrans As String, _
    '                          ByVal nThn As Integer, _
    '                          Optional ByRef cmd As SqlCommand = Nothing, _
    '                          Optional ByRef myTrans As SqlTransaction = Nothing) As String
    '    ' fungsi ini akan mengambil nomor terakhir dari nomor transaksi yang ada
    '    ' di semua tabel transaksi berdasarkan cIDTrans dan nThn input.
    '    ' cIDTrans : jenis transaksi
    '    ' nThn : tahun transaksi

    '    Dim strSQL As String
    '    Dim intNo As Long = 0
    '    Dim bAda As Boolean = False
    '    Dim objReader As SqlDataReader

    '    If IsNothing(cmd) Then cmd = New SqlCommand
    '    GetLastNo = ""
    '    Try
    '        strSQL = "select max(bgn_Number) as lastNo " & _
    '                 "from fakdres where " & _
    '                 "((vc_kd_trans = '" & Trim(cKdTrans) & "') and " & _
    '                 "(int_Thn = " & nThn & "))"
    '        objReader = clMain.clUtama.GeneralQuery(strSQL)

    '        While objReader.Read()
    '            If Not IsDBNull(objReader("lastNo")) Then
    '                intNo = objReader("lastNo")
    '                bAda = True
    '            End If
    '        End While
    '        'MsgBox(bAda)
    '        intNo += 1
    '        objReader.Close()

    '        'GetLastNo = Trim(cKdTrans) & "" & clMain.clUtama.strPad(Trim(CStr(nThn)), 2) & "" & clMain.clUtama.strPad(Trim(CStr(nBln)), 2) & "" & clMain.clUtama.strPad(CStr(intNo), 6)
    '        GetLastNo = Trim(cKdTrans) & "" & clMain.clUtama.strPad(Trim(CStr(nThn)), 2) & "" & clMain.clUtama.strPad(CStr(intNo), 5)
    '        ' MsgBox(GetLastNo)
    '        If bAda = True Then
    '            ' update dengan nomor yang baru jika data ada
    '            strSQL = "update fakdres set bgn_Number = " & intNo & " where " & _
    '                     "((vc_Kd_trans = '" & Trim(cKdTrans) & "') and " & _
    '                     "(int_Thn = " & nThn & "))"
    '            clMain.clUtama.GeneralCommand(strSQL, cmd)
    '        Else
    '            ' tambah data dengan nomor baru jika data tidak ada
    '            strSQL = "insert into fakdres values('" & Trim(cKdTrans) & "', " & nThn & "," & intNo & ")"
    '            clMain.clUtama.GeneralCommand(strSQL, cmd)
    '        End If
    '    Catch e As Exception    'MySqlException
    '    End Try
    'End Function

    Public dgvbon_rutin As String
    Public user_id As String
End Module
