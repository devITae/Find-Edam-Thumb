Public Class Form1
    Dim i As Int32 = 0
    Dim url As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Call doing()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub doing()
        Label1.Text = i.ToString()
        Debug.Print(i.ToString())
        Try
            url = "http://madeedam.com/data/goods/20/07/31/1000000029/1000000029_magnify_" & i.ToString("000") & ".jpg"
            PictureBox1.Load(url)
            Application.DoEvents()
        Catch ex As System.Net.WebException
            i = i + 1
            MsgBox(i.ToString("000"))
            Debug.Print(i.ToString())
            Call doing()
            Application.DoEvents()
        Finally
            PictureBox1.Load(url)
            TextBox1.Text = url
            Application.DoEvents()
        End Try
    End Sub
End Class
