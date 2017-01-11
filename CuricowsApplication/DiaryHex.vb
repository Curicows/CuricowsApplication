Public Class DiaryHex
    Dim datasavedim As String
    Dim dataloaddim As String
    Dim loadeddim As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim SW As New StreamWriter("teste\MeuArquivoDeTexto.txt") ' Cria o arquivo de texto

        'SW.WriteLine("Gravando uma linha de texto no arquivo.") ' Grava uma linha no arquivo de texto

        'SW.Close() 'Fecha o arquivo de texto

        'SW.Dispose() 'Libera a memória utilizada
        If loadeddim = True Then
            datasavedim = dataloaddim
            RichTextBox1.SaveFile("Diary\" + datasavedim + ".rtf")
        Else
            datasavedim = Today
            datasavedim = datasavedim.Replace("/", "_")
            RichTextBox1.SaveFile("Diary\" + datasavedim + ".rtf")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dataloaddim = MonthCalendar1.SelectionStart
        dataloaddim = dataloaddim.Replace("/", "_")
        loadeddim = True
        RichTextBox1.LoadFile("Diary\" + dataloaddim + ".rtf")
    End Sub

    Private Sub DiaryHex_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ASCIIorHEX.Show()
    End Sub
End Class