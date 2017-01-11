Public Class AdminFormMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NotifyIcon1.Visible = False
        Logado = False
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If WindowState = FormWindowState.Minimized Then
            Me.Show()
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub AdminFormMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If WindowState = FormWindowState.Minimized Then
            Me.Hide()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TestForm.Show()
        'System.Security.Cryptography.
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DiaryHex.Show()
    End Sub

    Private Sub AdminFormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Games.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        'Microsoft.Xna.Framework.Input.GamePadButtons
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Console.Show()
    End Sub
End Class