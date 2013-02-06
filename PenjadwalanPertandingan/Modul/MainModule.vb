Imports System.Data.Odbc
Imports System.Data.SqlClient

Module MainModule
    Public password As String
    Public Pemakai As String
    Public IdPemakai As Integer
    Public Peran As String
    Public NIP_test As String
    Public PUBLIC_Folder As String
    Public usiaPeserta As Integer
    Public con As Odbc.OdbcConnection = New Odbc.OdbcConnection("dsn=fembri")
    Public Sub init()
        If con.State = ConnectionState.Closed Then con.Open()
    End Sub
    Public Sub log(ByVal s As String)
        'MainForm.lstAktivitas.Items.Insert(0, s)
    End Sub

    Public Function GetData(ByVal sqlCommand As String) As DataTable
        Dim command As New OdbcCommand(sqlCommand, con)
        Dim adapter As OdbcDataAdapter = New OdbcDataAdapter()
        adapter.SelectCommand = command

        Dim table As New DataTable
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        Return table

    End Function
    Public Sub IsiDataGrid(ByVal DataGridView1 As DataGridView, ByVal Sql As String, ByRef BindingSource1 As BindingSource, ByVal firsColumnVisible As Boolean)
        With DataGridView1
            ' Automatically generate the DataGridView columns.
            .AutoGenerateColumns = True

            ' Set up the data source.
            BindingSource1.DataSource = GetData(Sql)
            .DataSource = BindingSource1

            ' Automatically resize the visible rows.
            .AutoSizeRowsMode = _
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersVisible = True

            ' Set the DataGridView control's border.
            .BorderStyle = BorderStyle.Fixed3D

            ' Put the cells in edit mode when user enters them.
            .EditMode = DataGridViewEditMode.EditOnEnter

            .Columns(.ColumnCount - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(0).Visible = firsColumnVisible
        End With
    End Sub

    Public Function findid(ByVal KolomKode As String, ByVal TableName As String, ByVal Where As String) As String
        Dim sql As String = "select " & KolomKode & " from " & TableName & " where " & Where
        Dim cmd As New OdbcCommand(sql, con)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        Dim hasil As Integer
        If dr.Read Then
            hasil = dr(0)
        Else
            hasil = 0
        End If

        dr.Close()
        cmd.Dispose()
        Return hasil
    End Function
    Public Sub explain(ByVal value As String, ByVal lbl As Label, ByVal kolomId As String, ByVal kolomLabel As String, ByVal tabel As String, ByVal where As String)
        Dim cmd As Odbc.OdbcCommand
        Dim dr As Odbc.OdbcDataReader
        Dim sql As String

        lbl.Text = ""
        sql = "select " & kolomId & "," & kolomLabel & " from " & tabel & "  where " & where & ""
        cmd = New Odbc.OdbcCommand(sql, con)
        dr = cmd.ExecuteReader
        If dr.Read Then lbl.Text = dr.GetString(1)
        dr.Close()
        cmd.Dispose()
    End Sub
    Public Sub runCommand(ByVal sql As String)
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, clMain.clUtama.objConnection)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Function runQuery(ByVal sql As String, ByVal mytrans As SqlClient.SqlTransaction) As SqlDataReader
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        cmd = New SqlCommand(sql, clMain.clUtama.objConnection, mytrans)
        dr = cmd.ExecuteReader()
        cmd.Dispose()
        Return dr
    End Function

    Public Function runQuery(ByVal sql As String) As SqlDataReader
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        cmd = New SqlCommand(sql, clMain.clUtama.objConnection)
        dr = cmd.ExecuteReader()
        cmd.Dispose()
        Return dr
    End Function

    Public Sub fillComboBox(ByVal cbo As ComboBox, ByVal sql As String)
        cbo.Items.Clear()
        Dim dr As SqlDataReader = runQuery(sql)

        While dr.Read
            cbo.Items.Add(dr(0))
        End While
        If cbo.Items.Count > 0 Then
            cbo.SelectedIndex = 0
        End If
        dr.Close()

    End Sub
End Module
