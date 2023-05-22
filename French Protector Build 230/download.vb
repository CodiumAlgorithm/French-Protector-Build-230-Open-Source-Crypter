Public Class download
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Hide()
    End Sub

    Private Sub Guna2CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox2.CheckedChanged
        If Guna2CheckBox2.Checked = True Then
        Else
            Guna2CheckBox2.Checked = False
        End If
    End Sub
End Class