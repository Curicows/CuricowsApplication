Public Class TestForm
    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CuricowsDataSet.Logins' table. You can move, or remove it, as needed.
        Me.LoginsTableAdapter1.Fill(Me.CuricowsDataSet.Logins)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=D:\Curicows.mdb"
        Try
            Dim sql As String = "Select Case Código, Login, [Password], Admin From Logins Where (Código = 1)"
            Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)
            'Abrir a conexão com o banco de dados
            sqlCom.Connection = cn
            cn.Open()

            Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

            If sqlRead.Read() Then

            Else
                ' Se digitar a senha ou o login errado
                ' Aparecera uma mensagem de erro
                MsgBox("Login ou/e Senha ou/e AdminCheckBox não batem..", "Falha de autenticação")


            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ' Dim cna As New OleDb.OleDbConnection
        'cna.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=D:\Curicows.mdb"
        ' Try
        'Dim sql As String = "SELECT Login FROM Logins WHERE (Código = 1);"
        'Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)
        'Abrir a conexão com o banco de dados
        'sqlCom.Connection = cna
        'cna.Open()

        'Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

        'If sqlRead.Read() Then

        'Else
        ' Se digitar a senha ou o login errado
        ' Aparecera uma mensagem de erro
        'MessageBox.Show("Login ou/e Senha ou/e AdminCheckBox não batem..", "Falha de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        'System.Data.OleDb.OleDbDataReader = Logintxt.Text

        'End If
        'Catch ex As Exception

        ' End Try

        Logintxt.Text = QueriesTableAdapter1.LoginQuery()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'Dim selectedRowCount As Integer = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)
        'If selectedRowCount > 0 Then
        'Dim i As Integer
        'For i = 0 To selectedRowCount - 1
        '  CodigoLUTemp = DataGridView1.SelectedRows(i).Index.ToString()
        '   NumTemp = CodigoLUTemp + 1
        '    CodigoLUTemp = NumTemp
        '     CodigoLU = CodigoLUTemp
        '      CodigoLUTemp = 0
        '       NumTemp = 0
        '    Next i
        'End If

        '        Dim cna As New OleDb.OleDbConnection
        '       cna.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=D:\Curicows.mdb"
        '      Try
        '     Dim sql As String = "SELECT Login FROM Logins WHERE (Código = 1);"
        '    Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)
        ' Abrir a conexão com o banco de dados
        '   sqlCom.Connection = cna
        '  cna.Open()

        'Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

        ' If sqlRead.Read() Then

        'Else
        'Se digitar a senha ou o login errado
        ' Aparecera uma mensagem de erro
        ' MessageBox.Show("Login ou/e Senha ou/e AdminCheckBox não batem..", "Falha de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        '  Logintxt.Text = sqlRead.


        'End If
        'Catch ex As Exception

        'End Try

        ' Me.LoginsTableAdapter.GetData.CreateDataReader.Read()
        DataGridView1.CurrentRow.Cells.ToString()





    End Sub

    Private Sub Pegar_Informacao()
        CodNUD.Value = CodigoLU
        Logintxt.Text = LoginLU
        Senhatxt.Text = PassLU
        AdminCB.Checked = AdminLU
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.LoginsTableAdapter1.Fill(Me.CuricowsDataSet.Logins)


    End Sub
End Class