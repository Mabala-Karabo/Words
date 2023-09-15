Public Class Form1
    Private Sub txtAddButton_Click(sender As Object, e As EventArgs) Handles txtAddButton.Click
        Dim textToAdd As String = txtText.Text.Trim()
        If Not String.IsNullOrEmpty(textToAdd) AndAlso Not txtListBox1.Items.Contains(textToAdd) Then
            txtListBox1.Items.Add(textToAdd)
            txtText.Clear()
        End If
    End Sub

    Private Sub txtListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtListBox1.SelectedIndexChanged
        If txtListBox1.SelectedIndex >= 0 Then
            txtLabel2.Text = txtListBox1.SelectedItem.ToString()
            txtLabel2.BackColor = Color.White
        End If
    End Sub

    Private Sub txtToUpper_CheckedChanged(sender As Object, e As EventArgs) Handles txtToUpper.CheckedChanged
        If txtListBox1.SelectedIndex >= 0 Then
            txtLabel2.Text = txtLabel2.Text.ToUpper()
        End If
    End Sub

    Private Sub txtToLower_CheckedChanged(sender As Object, e As EventArgs) Handles txtToLower.CheckedChanged
        If txtListBox1.SelectedIndex >= 0 Then
            txtLabel2.Text = txtLabel2.Text.ToLower()
        End If
    End Sub

    Private Sub txtToPurple_CheckedChanged(sender As Object, e As EventArgs) Handles txtToPurple.CheckedChanged
        If txtListBox1.SelectedIndex >= 0 Then
            txtLabel2.ForeColor = Color.Purple
        End If
    End Sub

    Private Sub txtToBlue_CheckedChanged(sender As Object, e As EventArgs) Handles txtToBlue.CheckedChanged
        If txtListBox1.SelectedIndex >= 0 Then
            txtLabel2.ForeColor = Color.Blue
        End If
    End Sub
End Class
