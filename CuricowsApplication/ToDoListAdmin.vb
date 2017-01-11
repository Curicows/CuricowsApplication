Public Class ToDoListAdmin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)


    End Sub

    Private Sub ToDoListAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Command3_Click()
        Dim i As Integer

        For i = 0 To ListBox1.SelectedValue
            ' If ListBox1.Items.Selected(i) = True Then
            'ListBox1.RemoveItem(i)
            ListBox1.Items.Remove(i)
            ' End If
        Next i
    End Sub
End Class