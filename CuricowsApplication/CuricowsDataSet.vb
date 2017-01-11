Partial Class CuricowsDataSet
    Partial Public Class LoginsDataTable
        Private Sub LoginsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CódigoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
