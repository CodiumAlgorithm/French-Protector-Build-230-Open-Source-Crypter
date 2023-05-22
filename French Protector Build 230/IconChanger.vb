Public Class IconChanger

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim Open As New OpenFileDialog
        Open.Filter = "Icon Files (*.ico)|*.ico"
        If Open.ShowDialog = vbOK Then
            Guna2TextBox1.Text = Open.FileName
            PictureBox2.Image = Drawing.Icon.ExtractAssociatedIcon(Guna2TextBox1.Text).ToBitmap
        End If
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.Hide()
    End Sub
End Class