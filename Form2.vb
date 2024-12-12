Imports System.Data.SqlClient
Public Class Form2
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the pressed key is not a digit or a control key
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancel the key press event
            e.Handled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub


    Private connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=election_management_system;Integrated Security=True"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        CheckBox1.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
        TextBox1.Clear()
        TextBox2.Clear()
        CheckBox1.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputId As String = TextBox1.Text
        Dim inputPassword As String = TextBox2.Text

        If VerifyCredentials(inputId, inputPassword) Then
            MessageBox.Show("Credentials verified. Access granted.")
            ' Proceed with login logic
            TextBox1.Clear()
            TextBox2.Clear()
            Me.Hide()
            admin_home.Show()
        Else
            MessageBox.Show("Invalid credentials. Access denied.")
        End If
    End Sub

    Private Function VerifyCredentials(inputId As String, inputPassword As String) As Boolean
        Dim query As String = "SELECT id, password FROM admin WHERE id=@Id"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", inputId)

                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    Dim passwordFromDb As String = reader("password").ToString()
                    If inputPassword = passwordFromDb Then
                        Return True ' Passwords match, credentials are verified
                    End If
                End If

                reader.Close()
            End Using
        End Using

        Return False ' No admin record found with the given ID or passwords don't match
    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class