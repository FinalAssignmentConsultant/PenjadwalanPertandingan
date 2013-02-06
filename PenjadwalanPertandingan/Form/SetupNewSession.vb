Imports System.Windows.Forms

Public Class SetupNewSession
    Private Function valid() As Boolean
        Return True
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim sql As String
        If valid() Then
           
            sql = " insert into liga(vc_nama_liga,vc_th_kompetisi, vc_bulan_kompetisi) " & _
                     " values ('" & txtNamaLiga.Text & "'," & _
                     " '" & txtTahun.Value & "','" & cboBulan.SelectedIndex + 1 & "'); select vc_id_liga from liga where vc_id_liga=@@IDENTITY"
            Dim cmd As New SqlClient.SqlCommand(sql, clMain.clUtama.objConnection)
            FormPengaturanJadwal.idliga = CInt(cmd.ExecuteScalar())
            MessageBox.Show("Silahkan mulai mengatur jadwal pertandingan pada form selanjutnya", "Pengaturan Jadwal[" & FormPengaturanJadwal.idliga & "]", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Hide()
            FormPengaturanJadwal.DoShow()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SetupNewSession_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNamaLiga.Text = ""
        txtTahun.Value = 2010
        cboBulan.SelectedIndex = Now.Month - 1
    End Sub

    Private Sub SetupNewSession_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtNamaLiga.Focus()
    End Sub
End Class
