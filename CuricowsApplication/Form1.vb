Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Public Admindb As Integer = False
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=E:\Curicows.mdb"
        Try
            Dim sqlAdmin As String = "SELECT Admin FROM Logins WHERE Login = '" + txtUsername.Text + "'"
            'Dim sql As String = "SELECT * FROM Logins"
            Dim sql As String = "SELECT * FROM Logins WHERE Login='" & txtUsername.Text & "' AND Password = '" & txtPassword.Text & "'"
            Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)
            'Abrir a conexão com o banco de dados
            sqlCom.Connection = cn
            cn.Open()

            Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()
            'MsgBox(sqlRead.GetString(1))
            'Dim Testedsdsad As String = sqlRead.R
            Dim Testeas As String
            ' If sqlRead.HasRows Then
            '     sqlRead.Read()
            '     Testeas = sqlRead.GetValue(0)
            'End If

            Dim result As Boolean = False
            If sqlRead.HasRows Then
                sqlRead.Read()
                result = sqlRead.GetBoolean(3)
            End If

            If result = True Then
                txtUsername.Text = ""
                txtPassword.Text = ""

                Logado = True
                AdminFormMain.NotifyIcon1.Visible = True
                My.Settings.VezesLogadas += 1
                '  Iniciar a abertura do AdminFormMain ou GuestFormMain
                If result = True Then
                    AdminFormMain.Show()
                Else

                End If
                Me.Hide()
            Else
                '   Se digitar a senha ou o login errado
                ' Aparecera uma mensagem de erro

                'Limpar todos os campos
                txtPassword.Text = ""
                txtUsername.Text = ""

                'Focus no campo txtUsername
                txtUsername.Focus()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        txtPassword.Text = ""
        txtUsername.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = "Vezes logadas : " + My.Settings.VezesLogadas
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Console.Show()
    End Sub
End Class
