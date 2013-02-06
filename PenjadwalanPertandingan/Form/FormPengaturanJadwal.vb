Imports System.Data.SqlClient
Imports clMainLib.General
Imports System.Data
Imports clMainLib.General.clsGeneral
Public Class FormPengaturanJadwal
    Dim iterasi As Integer = 0
    Public idliga As Integer = -1
    Dim iterasiWasit As String
    Dim timerStart As Date
    Dim timerEnd As Date
    Private Sub fsetup_tim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboHariDipilih.SelectedIndex = 0
        tampilDaftarWasit()
        tampilDaftarTim()
    End Sub
    Private Sub tampilDaftarTim()
        Dim dr As SqlDataReader
        Dim sql As String
        If clMain.clUtama.StatusKoneksi = True Then
            sql = " select vc_id_tim, vc_nama_tim from tim order by vc_id_tim "
            dr = runQuery(sql)
            gridDaftarTim.Rows.Clear()
            While dr.Read
                gridDaftarTim.Rows.Add()
                gridDaftarTim.Rows(gridDaftarTim.RowCount - 1).Cells(0).Value = dr(0)
                gridDaftarTim.Rows(gridDaftarTim.RowCount - 1).Cells(1).Value = dr(1)
            End While
            dr.Close()
        End If
    End Sub
    Private Sub tampilDaftarWasit()
        If clMain.clUtama.StatusKoneksi = True Then
            Dim Sql As String = " select vc_id_wasit, vc_nama_wasit from wasit order by vc_id_wasit"
            Dim dr As SqlDataReader = runQuery(Sql)
            gridDaftarWasit.Rows.Clear()
            While dr.Read
                gridDaftarWasit.Rows.Add()
                gridDaftarWasit.Rows(gridDaftarWasit.RowCount - 1).Cells("idWasit").Value = dr(0)
                gridDaftarWasit.Rows(gridDaftarWasit.RowCount - 1).Cells("namaWasit").Value = dr(1)
            End While
            dr.Close()
        End If
    End Sub
    Private Sub tampilTanggal()
        Dim objcommand As New SqlCommand
        Dim objdataset As New DataSet
        Dim myReader As SqlDataReader = Nothing
        Dim SQLText As String
        Dim objdataadapter As New SqlDataAdapter
        If clMain.clUtama.StatusKoneksi = True Then
            SQLText = "select vc_id_wasit,vc_nama_wasit from wasit where bt_status =1 " & _
                      "order by vc_id_wasit "
            clMain.clUtama.GeneralCommand(SQLText, objcommand)
            objdataadapter.SelectCommand = objcommand
            objdataadapter.Fill(objdataset)
            gridDaftarWasit.DataSource = objdataset.Tables(0).DefaultView
            gridDaftarWasit.Columns(0).HeaderText = "Id Wasit"
            gridDaftarWasit.Columns(0).Width = 100
            gridDaftarWasit.Columns(0).Visible = False
            gridDaftarWasit.Columns(1).HeaderText = "Nama Wasit"
            gridDaftarWasit.Columns(1).Width = 100
            gridDaftarWasit.Refresh()
        End If
        objcommand.Dispose()
        objdataadapter.Dispose()
        objdataset.Dispose()
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolRancangJadwal.Click
        If gridTimTerseleksi.RowCount Mod 2 = 0 And gridTimTerseleksi.RowCount <= 18 Then
            doGreedy()
            doPenjadwalan()
            doTampilkanJadwal()
        Else
            MessageBox.Show("Maaf, Jumlah tim harus genap dan tidak boleh lebih besar dari 18", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        coba()
    End Sub
    Private Sub coba()
        Dim mytrans As SqlTransaction = Nothing
        Dim objcommand As New SqlCommand
        Try
            mytrans = clMain.clUtama.objConnection.BeginTransaction
            objcommand.Connection = clMain.clUtama.objConnection
            objcommand.Transaction = mytrans

            'Me.txtid.Text = GetLastNoBukti("ST", (clMain.clTanggal.GetCurrentDate.Date), objcommand, mytrans, "")
            objcommand.ExecuteNonQuery()

        Catch ex As SqlException
            mytrans.Rollback()
            MsgBox(ex.ErrorCode)
        End Try
        'kosong()
        objcommand.Dispose()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ActiveControl = gridDaftarTim
        Dim i As Integer
        Dim xx, yy As Single
        For i = 0 To Me.gridTimTerseleksi.RowCount - 1
            If (Me.gridTimTerseleksi.Item(0, i).Value) = (gridDaftarTim.Rows(gridDaftarTim.CurrentCell.RowIndex).Cells(0).Value.ToString) Then
                MsgBox("Data sudah ada", MsgBoxStyle.Information, "Perhatian")
                Exit Sub
            End If
        Next
        xx = Me.gridTimTerseleksi.RowCount
        yy = Me.gridTimTerseleksi.RowCount
        'If xx >= Val(SetupNewSession.txtJumlahTim.Text) Then
        'MsgBox("Jumlah Tim adalah : '" & SetupNewSession.txtJumlahTim.Text & "'")
        'SetupNewSession.txtJumlahTim.Text = xx
        'End If

        Me.gridTimTerseleksi.Rows.Add(Trim(gridDaftarTim.Rows(gridDaftarTim.CurrentCell.RowIndex).Cells(0).Value.ToString), _
                                      Trim(gridDaftarTim.Rows(gridDaftarTim.CurrentCell.RowIndex).Cells(1).Value.ToString), _
                                      yy)

    End Sub

    Private Sub JMLTIM()
        Dim xx As Single
        xx = Me.gridTimTerseleksi.RowCount
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        batalitem()
    End Sub
    Private Sub batalitem()
        If gridTimTerseleksi.RowCount > 0 Then
            gridTimTerseleksi.Rows.Remove(gridTimTerseleksi.CurrentRow)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.ActiveControl = gridDaftarWasit
        pilihwasit()
    End Sub
    Private Sub pilihwasit()
        Dim i As Integer
        For i = 0 To Me.gridWasitTerseleksi.RowCount - 1
            If (Me.gridWasitTerseleksi.Item(0, i).Value) = (gridDaftarWasit.Rows(gridDaftarWasit.CurrentCell.RowIndex).Cells(0).Value.ToString) Then
                MsgBox("Data sudah ada", MsgBoxStyle.Information, "Perhatian")
                Exit Sub
            End If
        Next
        Me.gridWasitTerseleksi.Rows.Add(Trim(gridDaftarWasit.Rows(gridDaftarWasit.CurrentCell.RowIndex).Cells(0).Value.ToString), Trim(gridDaftarWasit.Rows(gridDaftarWasit.CurrentCell.RowIndex).Cells(1).Value.ToString))
    End Sub

    'ini greedy
    Private Sub doGreedy()
        Dim i, j As Integer
        dg1.Rows.Clear()
        For i = 0 To gridTimTerseleksi.RowCount - 1
            For j = i To gridTimTerseleksi.RowCount - 1
                If i <> j Then
                    dg1.Rows.Add(i, j)
                End If
            Next
        Next
    End Sub
    Private Function cekTidakBermainDalamSatuHariYangSama(ByVal idliga As String, ByVal tim As String, ByRef tanggalPertandingan As Date) As Boolean
        Dim sql As String = "select tanggal from pertandingan where vc_kd_tanding=" & idliga & " and (vc_tim1=" & tim & " or vc_tim2=" & tim & ")"
        Dim dr As SqlClient.SqlDataReader = runQuery(sql)
        Dim tanggalDiDB As Date
        While dr.Read
            tanggalDiDB = dr("tanggal")
            If tanggalDiDB.Equals(tanggal) Then
                dr.Close()
                Return False
            End If

        End While
        dr.Close()
        Return True
    End Function
    Private Function cekTidakBermainDalamSatuMingguYangSama(ByVal idliga As String, ByVal tim As String, ByVal tanggalPertandingan As Date)
        Dim sql As String = "select tanggal from pertandingan where (vc_kd_tanding=" & idliga & " and (vc_tim1=" & tim & " or vc_tim2=" & tim & " ))"
        Dim dr As SqlClient.SqlDataReader = runQuery(sql)
        Dim tanggalDiDB As Date
        While dr.Read
            tanggalDiDB = dr("tanggal")
            If Math.Abs(tanggalDiDB.DayOfYear - tanggalPertandingan.DayOfYear) <= 7 Then
                dr.Close()
                Return False
            End If

        End While
        dr.Close()
        Return True
    End Function
    'Private Function cekTidakKandang2xBerturutan(ByVal idliga As String, ByVal tim As String, ByVal tanggalPertandingan As Date)
    '    Dim sql As String = "select tanggal,vc_tim1,vc_tim2 from pertandingan where vc_kd_tanding=" & idliga & " order by tanggalPertandingan ASC"
    '    Dim dr As SqlClient.SqlDataReader = runQuery(sql)
    '    ' Dim tanggalDiDB As Date
    '    Dim i As Integer = 0
    '    'While dr.Read
    '    'tanggalDiDB = dr("tanggal")
    '    'End While
    '    'dr.Close()
    '    Return True
    'End Function
    Private Sub aturTanggal(ByRef dtPertandingan As Date, ByVal urutanTim1 As Integer, ByVal urutanTim2 As Integer)
        Dim beres As Boolean = False
        While Not beres
            iterasi = iterasi + 1
            beres = cekTidakBermainDalamSatuHariYangSama(idliga, urutanTim1, dtPertandingan)
            If Not beres Then
                dtPertandingan = dtPertandingan.AddDays(7) 'dulunya (1)
            End If
        End While

        beres = False
        While Not beres
            iterasi = iterasi + 1
            beres = cekTidakBermainDalamSatuHariYangSama(idliga, urutanTim2, dtPertandingan)
            If Not beres Then
                dtPertandingan = dtPertandingan.AddDays(7) 'dulunya (1)
            End If
        End While

        beres = False
        While Not beres
            iterasi = iterasi + 1
            beres = cekTidakBermainDalamSatuMingguYangSama(idliga, urutanTim1, dtPertandingan)
            If Not beres Then
                dtPertandingan = dtPertandingan.AddDays(7)
            End If
        End While

        beres = False
        While Not beres
            iterasi = iterasi + 1
            beres = cekTidakBermainDalamSatuMingguYangSama(idliga, urutanTim2, dtPertandingan)
            If Not beres Then
                dtPertandingan = dtPertandingan.AddDays(7)
            End If
        End While


        'tindakan pencegahan
        beres = False
        While Not beres
            iterasi = iterasi + 1
            beres = cekTidakBermainDalamSatuMingguYangSama(idliga, urutanTim1, dtPertandingan)
            If Not beres Then
                dtPertandingan = dtPertandingan.AddDays(7)
            End If
        End While

        beres = False
        While Not beres
            iterasi = iterasi + 1
            beres = cekTidakBermainDalamSatuMingguYangSama(idliga, urutanTim2, dtPertandingan)
            If Not beres Then
                dtPertandingan = dtPertandingan.AddDays(7)
            End If
        End While
        'tindakan pencegahan

        beres = False
        While Not beres
            iterasi = iterasi + 1
            beres = cekTidakPadaHariDihindari(idliga, dtPertandingan)
            If Not beres Then
                dtPertandingan = dtPertandingan.AddDays(7) 'dulunya (1)
            End If
        End While
        beres = False
    End Sub
    Private Function cekTidakPadaHariDihindari(ByVal idliga As Integer, ByVal dtPertandingan As Date) As Boolean
        Dim b As Boolean = True
        For i As Integer = 0 To gridHindariTanggal.RowCount - 1
            If FormatDateTime(dtPertandingan, DateFormat.LongDate) = FormatDateTime(gridHindariTanggal.Rows(i).Cells("hindaritanggal").Value, DateFormat.LongDate) Then
                b = False
            End If
        Next

        Return b
    End Function
    Private Sub doPenjadwalan()
        Dim i As Integer
        runCommand("delete from pertandingan where vc_kd_tanding=" & idliga)
        runCommand("delete from undi_tim where vc_kd_tanding=" & idliga)
        runCommand("delete from undi_wasit where id_liga=" & idliga)
        runCommand("delete from hindari_tanggal where id_liga=" & idliga)

        For i = 0 To gridTimTerseleksi.RowCount - 1
            runCommand(" insert into undi_tim (vc_kd_tim, vc_id_tim, vc_kd_tanding) " & _
                      " values ('" & Me.gridTimTerseleksi.Item(0, i).Value & "','" & Me.gridTimTerseleksi.Item(2, i).Value & "'," & idliga & ")")
        Next

        For i = 0 To gridWasitTerseleksi.RowCount - 1
            runCommand(" insert into undi_wasit(id_wasit, id_liga) " & _
                      " values ('" & Me.gridWasitTerseleksi.Item(0, i).Value & "'," & idliga & ")")
        Next
        For i = 0 To gridHindariTanggal.RowCount - 1
            runCommand(" insert into hindari_tanggal(hindari_tanggal,hindari_alasan, id_liga) " & _
                      " values ('" & Me.gridHindariTanggal.Item(0, i).Value & "','" & Me.gridHindariTanggal.Item(1, i).Value & "'," & idliga & ")")
        Next



        Dim dtPertandingan As Date = dtStartBulan.Value
        Dim dtStartDate As Date
        Dim prevTanggalPertandingan As Date = Nothing
        Dim urutanTim1 As String
        Dim urutanTim2 As String
        Dim beres As Boolean = False
        iterasiWasit = 0
        Dim hariDipilih As Integer = cboHariDipilih.SelectedIndex() + 1
        If CInt(dtPertandingan.DayOfWeek) = hariDipilih Then
            dtStartDate = dtStartBulan.Value
        ElseIf CInt(dtPertandingan.DayOfWeek) < hariDipilih Then
            dtStartDate = dtStartBulan.Value.AddDays(hariDipilih - CInt(dtStartBulan.Value.DayOfWeek))
        Else
            dtStartDate = dtStartBulan.Value.AddDays(7 - CInt(dtStartBulan.Value.DayOfWeek) + hariDipilih)
        End If
        dtPertandingan = dtStartDate

        iterasi = 0
        timerStart = Now
        For i = 0 To dg1.RowCount - 2
            iterasi = iterasi + 1
            urutanTim1 = Me.dg1.Item(0, i).Value
            urutanTim2 = Me.dg1.Item(1, i).Value
            aturTanggal(dtPertandingan, urutanTim1, urutanTim2)
            beres = False
            While Not beres
                iterasi = iterasi + 1
                beres = cekTidakPadaHariDihindari(idliga, dtPertandingan)
                If Not beres Then
                    dtPertandingan = dtPertandingan.AddDays(7) 'dulunya (1)
                End If
            End While
            aturTanggal(dtPertandingan, urutanTim1, urutanTim2)
            Dim id_wasit As String
            Dim wasitYgSudahDipakai As Hashtable = New Hashtable
            id_wasit = cariWasitYangBisa(idliga, dtPertandingan)
            beres = False
            While Not beres
                beres = cekWasitTidakBolehBermainDalamMingguYangSama(idliga, id_wasit, dtPertandingan)
                If Not beres Then
                    dtPertandingan = dtPertandingan.AddDays(7)
                End If
            End While
            runCommand(" insert into pertandingan (vc_kd_tanding, vc_tim1, vc_tim2,tanggal,vc_id_wasit) " & _
                      " values (" & idliga & ",'" & urutanTim1 & "','" & urutanTim2 & "','" & dtPertandingan.Year & "-" & dtPertandingan.Month & "-" & dtPertandingan.Day & "','" & id_wasit & "')")
            dtPertandingan = dtStartDate
        Next
        timerEnd = Now
        Dim span As TimeSpan = timerEnd - timerStart
        Text = "Pengaturan Jadwal [Iterasi = " & iterasi & ", waktu =" & span.TotalMilliseconds & "ms ]"
        iterasi = 0
    End Sub
    Private Function cekWasitTidakBolehBermainDalamMingguYangSama(ByVal idliga As Integer, ByVal id_wasit As String, ByVal tanggalPertandingan As Date)
        Dim sql As String = "select tanggal from pertandingan where vc_kd_tanding=" & idliga & " and vc_id_wasit='" & id_wasit & "'"
        Dim dr As SqlClient.SqlDataReader = runQuery(sql)
        Dim tanggalDiDB As Date
        While dr.Read
            tanggalDiDB = dr("tanggal")
            If Math.Abs(tanggalDiDB.DayOfYear - tanggalPertandingan.DayOfYear) <= 7 Then
                dr.Close()
                Return False
            End If
        End While
        dr.Close()
        Return True
    End Function
    Private Function cariWasitYangBisa(ByVal idliga As Integer, ByVal tanggalPertandingan As Date) As String
        On Error GoTo Hell
        Dim sql As String
        Dim id_wasit As String = Nothing
        Dim drwasit As SqlDataReader

start:
        id_wasit = gridWasitTerseleksi.Rows(iterasiWasit).Cells("wasitTerseleksiIdWasit").Value
        iterasiWasit = iterasiWasit + 1
        Return id_wasit
Hell:
        iterasiWasit = 0
        GoTo start
    End Function

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'jadwalNews()
        '        DialogPilihTanggal.ShowDialog()
    End Sub
    'Private Sub tampilJADWAL()
    '    Dim objcommand As New SqlCommand
    '    Dim objdataset As New DataSet
    '    Dim myReader As SqlDataReader = Nothing
    '    Dim SQLText As String
    '    Dim objdataadapter As New SqlDataAdapter
    '    If clMain.clUtama.StatusKoneksi = True Then
    '        SQLText = " SELECT distinct dbo.Pertandingan.vc_kd_tanding, dbo.Tim.vc_nama_tim, Tim_1.vc_nama_tim AS Expr2 " & _
    '                  " FROM dbo.Tim AS Tim_1 INNER JOIN " & _
    '                  " dbo.undi_tim ON Tim_1.vc_id_tim = dbo.undi_tim.vc_kd_tim INNER JOIN " & _
    '                  " dbo.Tim INNER JOIN " & _
    '                  " dbo.undi_tim AS undi_tim_1 ON dbo.Tim.vc_id_tim = undi_tim_1.vc_kd_tim INNER JOIN " & _
    '                  " dbo.Pertandingan ON undi_tim_1.vc_id_tim = dbo.Pertandingan.vc_tim2 ON " & _
    '                  " dbo.undi_tim.vc_id_tim = dbo.Pertandingan.vc_tim1 " & _
    '                  " WHERE (dbo.Pertandingan.vc_kd_tanding = " & idliga & ")"
    '        clMain.clUtama.GeneralCommand(SQLText, objcommand)
    '        objdataadapter.SelectCommand = objcommand
    '        objdataadapter.Fill(objdataset)
    '        gridHasil.DataSource = objdataset.Tables(0).DefaultView
    '        gridHasil.Columns(0).HeaderText = "Id Wasit"
    '        gridHasil.Columns(0).Width = 100
    '        gridHasil.Columns(0).Visible = False
    '        gridHasil.Columns(1).HeaderText = "Nama Wasit"
    '        gridHasil.Columns(1).Width = 100
    '        gridHasil.Columns(2).HeaderText = "Nama Wasit"
    '        gridHasil.Columns(2).Width = 100
    '        gridHasil.Refresh()
    '    End If
    '    objcommand.Dispose()
    '    objdataadapter.Dispose()
    '    objdataset.Dispose()
    'End Sub
    Private Sub doTampilkanJadwal()
        gridHasil.Rows.Clear()
        Dim myread As SqlDataReader = Nothing
        Dim sql As String
        sql = "SELECT DISTINCT pertandingan.vc_kd_tanding, Tim.vc_nama_tim, Tim_1.vc_nama_tim AS Expr2, pertandingan.tanggal, Wasit.vc_nama_wasit " & _
            " FROM Tim AS Tim_1 INNER JOIN " & _
            " undi_tim ON Tim_1.vc_id_tim = undi_tim.vc_kd_tim INNER JOIN " & _
            " Tim INNER JOIN " & _
            " undi_tim AS undi_tim_1 ON Tim.vc_id_tim = undi_tim_1.vc_kd_tim INNER JOIN " & _
            " pertandingan ON undi_tim_1.vc_id_tim = pertandingan.vc_tim2 ON undi_tim.vc_id_tim = pertandingan.vc_tim1 INNER JOIN " & _
            " Wasit ON pertandingan.vc_id_wasit = Wasit.vc_id_wasit " & _
            " WHERE     (pertandingan.vc_kd_tanding = " & idliga & ") AND (undi_tim.vc_kd_tanding = " & idliga & ") AND (undi_tim_1.vc_kd_tanding = " & idliga & ") " & _
            " ORDER BY Tim.vc_nama_tim, Expr2"
        myread = clMain.clUtama.GeneralQuery(sql)
        If myread.HasRows Then
            Dim i As Integer = 1
            While myread.Read
                'dgv1.Rows.Add(myread.GetString(1), myread.GetString(2), myread.GetValue(3), myread.GetString(4))
                Me.gridHasil.Rows.Add(i, myread("vc_nama_tim"), myread("Expr2"), FormatDateTime(myread("tanggal"), DateFormat.LongDate), myread("vc_nama_wasit"))
                i = i + 1
            End While
        End If
        myread.Close()
        gridHasil.Sort(gridHasil.Columns("tanggal"), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        batalWasit()
    End Sub
    Private Sub batalWasit()
        If gridWasitTerseleksi.RowCount > 0 Then
            gridWasitTerseleksi.Rows.Remove(gridWasitTerseleksi.CurrentRow)
        End If
    End Sub
    Public Sub DoShow()
        If idliga <> -1 Then
            Dim sql As String

            'isi dengan data tim terseleksi
            sql = "select vc_kd_tim, vc_nama_tim from undi_tim,tim where undi_tim.vc_kd_tim= Tim.vc_id_tim and  vc_kd_tanding=" & idliga
            Dim drTimTerseleksi As SqlDataReader = runQuery(sql)
            Me.gridTimTerseleksi.Rows.Clear()
            Dim i As Integer = 0
            While drTimTerseleksi.Read
                Me.gridTimTerseleksi.Rows.Add(drTimTerseleksi(0), drTimTerseleksi(1), i)
                i = i + 1
            End While
            drTimTerseleksi.Close()

            'isi dengan data wasit yg dipilih
            sql = "select dbo.Wasit.vc_id_wasit,dbo.Wasit.vc_nama_wasit from Wasit,dbo.undi_wasit where dbo.undi_wasit.id_wasit = Wasit.vc_id_wasit and undi_wasit.id_liga=" & idliga
            Dim drWasitTerseleksi As SqlDataReader = runQuery(sql)
            Me.gridWasitTerseleksi.Rows.Clear()

            While drWasitTerseleksi.Read
                Me.gridWasitTerseleksi.Rows.Add(drWasitTerseleksi(0), drWasitTerseleksi(1))
            End While
            drWasitTerseleksi.Close()

            'isi dengan tanggal yg dihindari
            sql = "select hindari_tanggal,hindari_alasan from hindari_tanggal where hindari_tanggal.id_liga=" & idliga
            Dim drTanggalDihindari As SqlDataReader = runQuery(sql)
            Me.gridHindariTanggal.Rows.Clear()

            While drTanggalDihindari.Read
                Me.gridHindariTanggal.Rows.Add(FormatDateTime(drTanggalDihindari(0), DateFormat.LongDate), drTanggalDihindari(1))
            End While
            drTanggalDihindari.Close()


            doGreedy()
            'doPenjadwalan()
            doPenjadwalan()
            doTampilkanJadwal()
        End If
        ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        'DialogReport.CrystalReportViewer1.RefreshReport()
        DialogReport.ShowDialog()
    End Sub

    Private Sub btnHindari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHindari.Click
        If txtAlasan.Text = "" Then
            MessageBox.Show("Isikan alasan terlebih dahulu", "Penjadwalan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim b As Boolean = True

        Dim iRow As Integer = 0
        If gridHindariTanggal.RowCount <> 0 Then
            For i As Integer = 0 To gridHindariTanggal.RowCount - 1
                If gridHindariTanggal.Rows(i).Cells("hindariTanggal").Value = FormatDateTime(dtHindariTanggal.Value, DateFormat.LongDate) Then
                    b = False
                    iRow = i
                End If
            Next
        Else
            b = True
        End If

        If b Then
            gridHindariTanggal.Rows.Add(FormatDateTime(dtHindariTanggal.Value, DateFormat.LongDate), txtAlasan.Text)
        Else
            If MessageBox.Show("Timpa tanggal yang sudah ada?", "Penjadwalan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                gridHindariTanggal.Rows(iRow).Cells("hindariTanggal").Value = FormatDateTime(dtHindariTanggal.Value, DateFormat.LongDate)
                gridHindariTanggal.Rows(iRow).Cells("hindariAlasan").Value = txtAlasan.Text
            End If
        End If
    End Sub

    Private Sub gridHindariTanggal_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridHindariTanggal.CellClick
        txtAlasan.Text = gridHindariTanggal.SelectedRows(0).Cells("hindariAlasan").Value
        dtHindariTanggal.Value = gridHindariTanggal.SelectedRows(0).Cells("hindariTanggal").Value
    End Sub

    Private Sub btnBatalkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatalkan.Click
        On Error Resume Next
        gridHindariTanggal.Rows.Remove(gridHindariTanggal.SelectedRows(0))
    End Sub
End Class