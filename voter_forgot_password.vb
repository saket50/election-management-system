Imports System.Data.SqlClient

Public Class voter_forgot_password
    Private connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=election_management_system;Integrated Security=True"


    Private Sub voter_forgot_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim isMatch As Boolean = IsDOBMatch(DateTimePicker1.Value, TextBox1.Text)
        If isMatch Then
            If TextBox2.Text = TextBox3.Text Then
                UpdatePassword(TextBox1.Text, TextBox2.Text)
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                DateTimePicker1.Value = Date.Today
            Else
                MessageBox.Show("Both the entered password is not matching")
            End If
        Else
            MessageBox.Show("DOB and Aadhar No. does not match.")
        End If
    End Sub

    Private Function IsDOBMatch(ByVal dob As Date, ByVal aadhar As String) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT dob FROM voter WHERE aadhar = @aadhar"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@aadhar", aadhar)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Dim voterDOB As Date = Convert.ToDateTime(result).Date
                        Return voterDOB = DateTimePicker1.Value.Date
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching date of birth: " & ex.Message)
        End Try

        Return False
    End Function
    Private Sub UpdatePassword(ByVal aadhar As String, ByVal newPassword As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE voter SET password = @newPassword WHERE aadhar = @aadhar"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@newPassword", newPassword)
                    command.Parameters.AddWithValue("@aadhar", aadhar)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Password updated successfully.")
            Me.Hide()
            V_login.Show()
        Catch ex As Exception
            MessageBox.Show("Error updating password: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        DateTimePicker1.Value = Date.Today
    End Sub
End Class