Public Class Form1
    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles showButton.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub





    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Close()
    End Sub

    Private Sub BackgroundButton_Click(sender As Object, e As EventArgs) Handles backgroundButton.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        PictureBox1.Image = Nothing
        PictureBox1.BackColor = Nothing



    End Sub
End Class
