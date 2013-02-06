Imports System.Windows.Forms

Public Class DialogCariData
    Private bindingSourceBukuYangBisaDipinjam As New BindingSource
    Public Sub reload()
        btnCari_Click(Nothing, Nothing)
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DialogCariData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fillComboBox(cboNamaTim, "select vc_nama_tim from tim order by vc_nama_tim")
        fillComboBox(cboWasit, "select vc_nama_wasit from wasit order by vc_nama_wasit")
        fillComboBox(cboLiga, "select vc_nama_liga from liga order by vc_nama_liga")
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim sql As String = ""
        If optTim.Checked Then
            sql = "SELECT DISTINCT " & _
                    " pertandingan.idpertandingan, pertandingan.tanggal, Tim.vc_nama_tim AS [Tim 1], Tim_1.vc_nama_tim AS [Tim 2], Wasit.vc_nama_wasit AS Wasit, " & _
                    " pertandingan.alasan AS [Alasan Perubahan] " & _
                    " FROM         Tim AS Tim_1 INNER JOIN " & _
                    " undi_tim ON Tim_1.vc_id_tim = undi_tim.vc_kd_tim INNER JOIN " & _
                    " Tim INNER JOIN " & _
                    " undi_tim AS undi_tim_1 ON Tim.vc_id_tim = undi_tim_1.vc_kd_tim INNER JOIN " & _
                    " pertandingan ON undi_tim_1.vc_id_tim = pertandingan.vc_tim2 AND undi_tim_1.vc_kd_tanding = pertandingan.vc_kd_tanding ON  " & _
                    " undi_tim.vc_id_tim = pertandingan.vc_tim1 AND undi_tim.vc_kd_tanding = pertandingan.vc_kd_tanding INNER JOIN " & _
                    " Liga ON pertandingan.vc_kd_tanding = Liga.vc_id_liga INNER JOIN " & _
                    " Wasit ON pertandingan.vc_id_wasit = Wasit.vc_id_wasit " & _
                    " WHERE     (Tim.vc_nama_tim = '" & cboNamaTim.Text & "') AND (Liga.vc_nama_liga = '" & cboLiga.Text & "') OR " & _
                    " (Tim_1.vc_nama_tim = '" & cboNamaTim.Text & "') " & _
                    " ORDER BY [Tim 1], [Tim 2]"

        ElseIf optWasit.Checked Then
            sql = "SELECT DISTINCT " & _
                " pertandingan.idpertandingan, pertandingan.tanggal, Tim.vc_nama_tim AS [Tim 1], Tim_1.vc_nama_tim AS [Tim 2], Wasit.vc_nama_wasit,  " & _
                " pertandingan.alasan AS [Alasan Perubahan] " & _
                " FROM         Tim AS Tim_1 INNER JOIN " & _
                " undi_tim ON Tim_1.vc_id_tim = undi_tim.vc_kd_tim INNER JOIN " & _
                " Tim INNER JOIN " & _
                " undi_tim AS undi_tim_1 ON Tim.vc_id_tim = undi_tim_1.vc_kd_tim INNER JOIN " & _
                " pertandingan ON undi_tim_1.vc_id_tim = pertandingan.vc_tim2 AND undi_tim_1.vc_kd_tanding = pertandingan.vc_kd_tanding ON  " & _
                " undi_tim.vc_id_tim = pertandingan.vc_tim1 AND undi_tim.vc_kd_tanding = pertandingan.vc_kd_tanding INNER JOIN " & _
                " Wasit ON pertandingan.vc_id_wasit = Wasit.vc_id_wasit INNER JOIN " & _
                " Liga ON pertandingan.vc_kd_tanding = Liga.vc_id_liga " & _
                " WHERE     (Wasit.vc_nama_wasit = '" & cboWasit.Text & "') AND (Liga.vc_nama_liga = '" & cboLiga.Text & "') " & _
                " ORDER BY [Tim 1], [Tim 2] "

        ElseIf optWaktu.Checked Then
            sql = "SELECT DISTINCT " & _
                      " pertandingan.idpertandingan, pertandingan.tanggal, Tim.vc_nama_tim AS [Tim 1], Tim_1.vc_nama_tim AS [Tim 2], Wasit.vc_nama_wasit,  " & _
                      " pertandingan.alasan AS [Alasan Perubahan], Liga.vc_nama_liga " & _
" FROM         Tim AS Tim_1 INNER JOIN " & _
                      " undi_tim ON Tim_1.vc_id_tim = undi_tim.vc_kd_tim INNER JOIN " & _
                      " Tim INNER JOIN " & _
                      " undi_tim AS undi_tim_1 ON Tim.vc_id_tim = undi_tim_1.vc_kd_tim INNER JOIN " & _
                      " pertandingan ON undi_tim_1.vc_id_tim = pertandingan.vc_tim2 AND undi_tim_1.vc_kd_tanding = pertandingan.vc_kd_tanding ON  " & _
                      " undi_tim.vc_id_tim = pertandingan.vc_tim1 AND undi_tim.vc_kd_tanding = pertandingan.vc_kd_tanding INNER JOIN " & _
                      " Liga ON pertandingan.vc_kd_tanding = Liga.vc_id_liga INNER JOIN " & _
                      " Wasit ON pertandingan.vc_id_wasit = Wasit.vc_id_wasit " & _
" WHERE     (pertandingan.tanggal >= '" & dtStart.Text & "') AND (pertandingan.tanggal <= '" & dtEnd.Text & "') AND (Liga.vc_nama_liga = '" & cboLiga.Text & "') " & _
" ORDER BY [Tim 1], [Tim 2]"


        ElseIf optAll.Checked Then
            sql = "SELECT DISTINCT " & _
    " pertandingan.idpertandingan, pertandingan.tanggal, Tim.vc_nama_tim AS [Tim 1], Tim_1.vc_nama_tim AS [Tim 2], Wasit.vc_nama_wasit, " & _
    " pertandingan.alasan AS [Alasan Perubahan], Liga.vc_nama_liga " & _
    " FROM Tim AS Tim_1 INNER JOIN " & _
    " undi_tim ON Tim_1.vc_id_tim = undi_tim.vc_kd_tim INNER JOIN " & _
    " Tim INNER JOIN " & _
    " undi_tim AS undi_tim_1 ON Tim.vc_id_tim = undi_tim_1.vc_kd_tim INNER JOIN " & _
    " pertandingan ON undi_tim_1.vc_id_tim = pertandingan.vc_tim2 AND undi_tim_1.vc_kd_tanding = pertandingan.vc_kd_tanding ON  " & _
    " undi_tim.vc_id_tim = pertandingan.vc_tim1 AND undi_tim.vc_kd_tanding = pertandingan.vc_kd_tanding INNER JOIN " & _
    " Liga ON pertandingan.vc_kd_tanding = Liga.vc_id_liga INNER JOIN " & _
    " Wasit ON pertandingan.vc_id_wasit = Wasit.vc_id_wasit " & _
    " WHERE     (Liga.vc_nama_liga = '" & cboLiga.Text & "') " & _
    " ORDER BY [Tim 1], [Tim 2]"
        End If

        IsiDataGrid(Me.gridHasil, sql, bindingSourceBukuYangBisaDipinjam, False)
    End Sub
    Private Sub fillControl()
        cboNamaTim.Enabled = False
        cboWasit.Enabled = False
        dtEnd.Enabled = False
        dtStart.Enabled = False
        If optTim.Checked Then
            cboNamaTim.Enabled = True
        ElseIf optWaktu.Checked Then
            dtEnd.Enabled = True
            dtStart.Enabled = True
        ElseIf optWasit.Checked Then
            cboWasit.Enabled = True
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        fillControl()
    End Sub

    Private Sub optTim_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTim.CheckedChanged
        fillControl()
    End Sub

    Private Sub optWasit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optWasit.CheckedChanged
        fillControl()
    End Sub

    Private Sub optWaktu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optWaktu.CheckedChanged
        fillControl()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        DialogUbahJadwal.idpertandingan = gridHasil.CurrentRow.Cells(0).Value
        DialogUbahJadwal.DoShow()
    End Sub

  
End Class
