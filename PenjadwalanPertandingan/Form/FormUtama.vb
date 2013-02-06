Imports clMainLib.General.clsGeneral
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports clMainLib.General
Imports System.Net

Public Class FormUtama
    Private ItemKodeMenu As New ToolStripMenuItem
    Dim sql As String
    Dim myread As SqlDataReader = Nothing
    Private strtext As String
    Private IP As Net.IPHostEntry = Dns.GetHostByName(Dns.GetHostName)
    Private ObjConnection As SqlConnection
    Private Sub futama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = Application.ProductName & " oleh " & Application.CompanyName
        MainModule.init()
        SetDb()
    End Sub
    Private Function SetDb() As Boolean
        Dim blnReturn As Boolean = False
        mdlMain.ReadValuesINIFiles()
        clMain.clUtama.NamaServer = clMain.cNamaServer
        clMain.clUtama.NamaDatabase = clMain.cNamaDatabase
        clMain.clUtama.NamaUser = clMain.cNamaUser
        clMain.clUtama.PassUser = clMain.cPassUser

        ' panggil tanggal
        clMain.clTanggal.NamaServer = clMain.cNamaServer
        clMain.clTanggal.NamaDatabase = clMain.cNamaDatabase
        clMain.clTanggal.NamaUser = clMain.cNamaUser
        clMain.clTanggal.PassUser = clMain.cPassUser

        If clMain.clUtama.DBOpenConnection() = 0 Then
            blnReturn = True
            ObjConnection = clMain.clUtama.objConnection
        Else
            MsgBox("Terjadi kesalahan koneksi ke server !" & Chr(10) & Chr(13) & _
                   "Hubungi administrator Anda !", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Db Connection !")
        End If
        SetDb = blnReturn
        If SetDb Then
            blnReturn = False
            If clMain.clTanggal.DBOpenConnection() = 0 Then
                blnReturn = True
            Else
                MsgBox("Terjadi kesalahan koneksi ke server !" & Chr(10) & Chr(13) & _
                       "Hubungi administrator Anda !", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Db Connection !")
            End If
            SetDb = blnReturn
        End If

    End Function

    Private Sub mnu010501010000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        FormPengaturanJadwal.ShowDialog()
    End Sub

    Private Sub InputRegistriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputRegistriToolStripMenuItem.Click
        DialogTim.ShowDialog()
    End Sub

   

    Private Sub MasterLaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EditRegistriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditRegistriToolStripMenuItem.Click
        DialogWasit.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
        Me.Close()
    End Sub

   

    Private Sub mnuNewSession_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewSession.Click
        SetupNewSession.ShowDialog()
    End Sub

    Private Sub DaftarSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarSessionToolStripMenuItem.Click
        Lookup.sql = "select vc_id_liga as ID,vc_nama_liga as [Nama Liga],vc_th_kompetisi as [Tahun Kompetisi], vc_bulan_kompetisi as [Bulan Kompetisi] from liga order by vc_th_kompetisi,vc_bulan_kompetisi,vc_nama_liga"
        Lookup.DoShow()

        If Lookup.dipilih Then
            FormPengaturanJadwal.idliga = Lookup.idfield
            'SetupNewSession.txtJumlahTim.Text = Lookup.gridData.SelectedRows(0).Cells(3).Value
            'Me.gridTimTerseleksi.Rows.Add(Trim(gridDaftarTim.Rows(gridDaftarTim.CurrentCell.RowIndex).Cells(0).Value.ToString), Trim(gridDaftarTim.Rows(gridDaftarTim.CurrentCell.RowIndex).Cells(1).Value.ToString), yy)
            FormPengaturanJadwal.DoShow()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub CariDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariDataToolStripMenuItem.Click
        DialogCariData.ShowDialog()
    End Sub
End Class
