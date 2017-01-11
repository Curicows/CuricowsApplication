Imports System.DateTime
Public Class Console
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim Location
        Dim Com As String = Comandotxt.Text
        Dim Inf As String = Infortxt.Text

        'Comands
        If Comandotxt.Text = "Login" Then
            If Infortxt.Text = "Logout" Then
                If Logado = True Then
                    Consolelbl12.Text = Consolelbl11.Text
                    Consolelbl11.Text = Consolelbl10.Text
                    Consolelbl10.Text = Consolelbl9.Text
                    Consolelbl9.Text = Consolelbl8.Text
                    Consolelbl8.Text = Consolelbl7.Text
                    Consolelbl7.Text = Consolelbl6.Text
                    Consolelbl6.Text = Consolelbl5.Text
                    Consolelbl5.Text = Consolelbl4.Text
                    Consolelbl4.Text = Consolelbl3.Text
                    Consolelbl3.Text = Consolelbl2.Text
                    Consolelbl2.Text = Consolelbl1.Text
                    Consolelbl1.Text = "Logouted with success"
                    Comandotxt.Text = ""
                    Infortxt.Text = ""
                    Logado = False
                    Form1.Show()
                    AdminFormMain.Hide()
                    Games.Hide()
                Else
                    Consolelbl12.Text = Consolelbl11.Text
                    Consolelbl11.Text = Consolelbl10.Text
                    Consolelbl10.Text = Consolelbl9.Text
                    Consolelbl9.Text = Consolelbl8.Text
                    Consolelbl8.Text = Consolelbl7.Text
                    Consolelbl7.Text = Consolelbl6.Text
                    Consolelbl6.Text = Consolelbl5.Text
                    Consolelbl5.Text = Consolelbl4.Text
                    Consolelbl4.Text = Consolelbl3.Text
                    Consolelbl3.Text = Consolelbl2.Text
                    Consolelbl2.Text = Consolelbl1.Text
                    Consolelbl1.Text = "Not logged"
                    Comandotxt.Text = ""
                    Infortxt.Text = ""
                End If
            ElseIf Infortxt.Text = "Admin" Then
                If Logado = False Then
                    AdminFormMain.Show()
                    Form1.Hide()
                    Consolelbl12.Text = Consolelbl11.Text
                    Consolelbl11.Text = Consolelbl10.Text
                    Consolelbl10.Text = Consolelbl9.Text
                    Consolelbl9.Text = Consolelbl8.Text
                    Consolelbl8.Text = Consolelbl7.Text
                    Consolelbl7.Text = Consolelbl6.Text
                    Consolelbl6.Text = Consolelbl5.Text
                    Consolelbl5.Text = Consolelbl4.Text
                    Consolelbl4.Text = Consolelbl3.Text
                    Consolelbl3.Text = Consolelbl2.Text
                    Consolelbl2.Text = Consolelbl1.Text
                    Consolelbl1.Text = "Login Success"
                    Comandotxt.Text = ""
                    Infortxt.Text = ""
                    Logado = True
                    My.Settings.VezesLogadas += 1
                Else
                    Consolelbl12.Text = Consolelbl11.Text
                    Consolelbl11.Text = Consolelbl10.Text
                    Consolelbl10.Text = Consolelbl9.Text
                    Consolelbl9.Text = Consolelbl8.Text
                    Consolelbl8.Text = Consolelbl7.Text
                    Consolelbl7.Text = Consolelbl6.Text
                    Consolelbl6.Text = Consolelbl5.Text
                    Consolelbl5.Text = Consolelbl4.Text
                    Consolelbl4.Text = Consolelbl3.Text
                    Consolelbl3.Text = Consolelbl2.Text
                    Consolelbl2.Text = Consolelbl1.Text
                    Consolelbl1.Text = "Already logged"
                    Comandotxt.Text = ""
                    Infortxt.Text = ""
                End If
            End If
        ElseIf Comandotxt.Text = "Program" Then
            If Infortxt.Text = "Exit" Then
                Application.Exit()
            End If
        ElseIf Comandotxt.Text = "System" Then
            If Infortxt.Text = "Date" Then
                Consolelbl12.Text = Consolelbl11.Text
                Consolelbl11.Text = Consolelbl10.Text
                Consolelbl10.Text = Consolelbl9.Text
                Consolelbl9.Text = Consolelbl8.Text
                Consolelbl8.Text = Consolelbl7.Text
                Consolelbl7.Text = Consolelbl6.Text
                Consolelbl6.Text = Consolelbl5.Text
                Consolelbl5.Text = Consolelbl4.Text
                Consolelbl4.Text = Consolelbl3.Text
                Consolelbl3.Text = Consolelbl2.Text
                Consolelbl2.Text = Consolelbl1.Text
                Consolelbl1.Text = Date.Now
                Comandotxt.Text = ""
                Infortxt.Text = ""
            End If
        ElseIf Comandotxt.Text = "Console" Then
            If Infortxt.Text = "Clear" Then
                Consolelbl1.Text = ""
                Consolelbl2.Text = ""
                Consolelbl3.Text = ""
                Consolelbl4.Text = ""
                Consolelbl5.Text = ""
                Consolelbl6.Text = ""
                Consolelbl7.Text = ""
                Consolelbl8.Text = ""
                Consolelbl9.Text = ""
                Consolelbl10.Text = ""
                Consolelbl11.Text = ""
                Consolelbl12.Text = ""
                Comandotxt.Text = ""
                Infortxt.Text = ""
            ElseIf Inf = "Close" Then
                Me.Hide()
            End If
        ElseIf Com = "Form" Then
            If Infortxt.Text = "Admin" Then
                AdminFormMain.Show()
            ElseIf Inf = "TestForm" Then
                TestForm.Show()


            End If
        ElseIf Com = "Computer" Then
            If Inf = "Shutdown" Then
                Consolelbl12.Text = Consolelbl11.Text
                Consolelbl11.Text = Consolelbl10.Text
                Consolelbl10.Text = Consolelbl9.Text
                Consolelbl9.Text = Consolelbl8.Text
                Consolelbl8.Text = Consolelbl7.Text
                Consolelbl7.Text = Consolelbl6.Text
                Consolelbl6.Text = Consolelbl5.Text
                Consolelbl5.Text = Consolelbl4.Text
                Consolelbl4.Text = Consolelbl3.Text
                Consolelbl3.Text = Consolelbl2.Text
                Consolelbl2.Text = Consolelbl1.Text
                Consolelbl1.Text = "Command inexistent"
                Comandotxt.Text = ""
                Infortxt.Text = ""
                Shell("shutdown -s -t 1 -f")
            End If
        Else
            Consolelbl12.Text = Consolelbl11.Text
            Consolelbl11.Text = Consolelbl10.Text
            Consolelbl10.Text = Consolelbl9.Text
            Consolelbl9.Text = Consolelbl8.Text
            Consolelbl8.Text = Consolelbl7.Text
            Consolelbl7.Text = Consolelbl6.Text
            Consolelbl6.Text = Consolelbl5.Text
            Consolelbl5.Text = Consolelbl4.Text
            Consolelbl4.Text = Consolelbl3.Text
            Consolelbl3.Text = Consolelbl2.Text
            Consolelbl2.Text = Consolelbl1.Text
            Consolelbl1.Text = "Command inexistent"
            Comandotxt.Text = ""
            Infortxt.Text = ""
        End If


    End Sub

    Private Sub Console_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ConsoleOpen = False
    End Sub
    Private Sub Console_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsoleOpen = True
    End Sub
End Class