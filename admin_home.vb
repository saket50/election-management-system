Public Class admin_home
    Private Sub admin_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        add_mang_candidate.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        voting_poll.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MessageBox.Show("Are you sure you want to log out?", "Confirm log out", MessageBoxButtons.OKCancel)
        If DialogResult.OK Then
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        voter_management.Show()
    End Sub
End Class