Imports System.Windows.Forms

Public Class DialogUbahJadwal
    Public idpertandingan As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim tanggal As String = dtTanggal.Value.Year & "-" & dtTanggal.Value.Month & "-" & dtTanggal.Value.Day
        Dim sql As String = "update pertandingan set tanggal='" & tanggal & "', alasan='" & txtAlasan.Text & "' where idpertandingan=" & idpertandingan
        runCommand(sql)
        DialogCariData.reload()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Public Sub DoShow()
        Dim dr As SqlClient.SqlDataReader = runQuery("select tanggal from pertandingan where idpertandingan=" & idpertandingan)
        If dr.Read Then
            dtTanggal.Value = dr(0)
        End If
        dr.Close()
        ShowDialog()
    End Sub

   
End Class
