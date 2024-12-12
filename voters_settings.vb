Imports System.Data.SqlClient
Public Class voters_settings
    Public Property connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=election_management_system;Integrated Security=True"
    Dim aadhar As String = V_login.aadharno
    Private Function IsPasswordMatch(ByVal aadhar As String, ByVal enteredPassword As String) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT password FROM voter WHERE aadhar = @aadhar"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@aadhar", aadhar)

                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Dim passwordFromDB As String = Convert.ToString(result)
                        Return passwordFromDB = enteredPassword
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching password: " & ex.Message)
        End Try

        Return False
    End Function

    Private Sub voters_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name As String

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT v_name FROM voter WHERE aadhar = @aadhar"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@aadhar", aadhar)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            name = reader("v_name").ToString()
                            Label4.Text = name
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching name: " & ex.Message)
        End Try
    End Sub
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim isMatch As Boolean = IsPasswordMatch(aadhar, TextBox1.Text)
        If isMatch Then
            If TextBox2.Text = TextBox3.Text Then
                UpdatePassword(aadhar, TextBox2.Text)
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
            Else
                MessageBox.Show("Both the entered new password is not matching")
            End If
        Else
            MessageBox.Show("Old Password does not match.")
        End If
    End Sub
End Class