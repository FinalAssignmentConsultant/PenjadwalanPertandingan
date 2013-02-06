Partial Class DataSet
    Partial Class WasitDataTable
        Private Sub WasitDataTable_TableNewRow(ByVal sender As Object, ByVal e As System.Data.DataTableNewRowEventArgs) Handles Me.TableNewRow
            Dim tgl As Date = Now
            Dim thn As Integer = tgl.Year
            Dim bln As Integer = tgl.Month
            Dim hari As Integer = tgl.Day
            Dim dr As Odbc.OdbcDataReader

            Dim kode As String = "WS" & thn & bln & hari
            Dim newKode As String = kode
            Dim sql As String
            sql = "select vc_id_wasit from wasit where vc_id_wasit='" & newKode & "'"

            Dim cmd As New Odbc.OdbcCommand(sql, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                Dim i As Integer = 1
                Do
                    newKode = kode & i
                    sql = "select vc_id_wasit from wasit where vc_id_wasit='" & newKode & "'"
                    i = i + 1
                    dr.Close()
                    cmd.Dispose()
                    cmd = New Odbc.OdbcCommand(sql, con)
                    dr = cmd.ExecuteReader

                Loop Until Not dr.Read
            End If
            e.Row.Item("vc_id_wasit") = newKode
        End Sub
    End Class

    Partial Class TimDataTable



        Private Sub TimDataTable_TableNewRow(ByVal sender As Object, ByVal e As System.Data.DataTableNewRowEventArgs) Handles Me.TableNewRow
            Dim tgl As Date = Now
            Dim thn As Integer = tgl.Year
            Dim bln As Integer = tgl.Month
            Dim hari As Integer = tgl.Day
            Dim dr As Odbc.OdbcDataReader

            Dim kode As String = "TM" & thn & bln & hari
            Dim newKode As String = kode
            Dim sql As String
            sql = "select vc_id_tim from tim where vc_id_tim='" & newKode & "'"

            Dim cmd As New Odbc.OdbcCommand(sql, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                Dim i As Integer = 1
                Do
                    newKode = kode & i
                    sql = "select vc_id_tim from tim where vc_id_tim='" & newKode & "'"
                    i = i + 1
                    dr.Close()
                    cmd.Dispose()
                    cmd = New Odbc.OdbcCommand(sql, con)
                    dr = cmd.ExecuteReader

                Loop Until Not dr.Read
            End If
            e.Row.Item("vc_id_tim") = newKode
        End Sub
    End Class

End Class
