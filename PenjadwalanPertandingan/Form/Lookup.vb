Public Class Lookup
    Private bindingSourceBukuYangBisaDipinjam As New BindingSource
    Public sql As String
    Public dipilih As Boolean
    Public idfield As Object

    Private Sub Lookup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub DoShow()
        'Me.MdiParent = MainForm
        IsiDataGrid(Me.gridData, sql, bindingSourceBukuYangBisaDipinjam, True)
        Me.ShowDialog()
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        dipilih = True
        idfield = gridData.SelectedRows(0).Cells(0).Value
        Hide()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        dipilih = False
        Hide()
    End Sub


    Private Sub gridData_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridData.CellClick
        OK_Button_Click(Nothing, Nothing)
    End Sub
End Class