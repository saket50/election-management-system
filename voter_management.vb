Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Text.RegularExpressions

Public Class voter_management
    Public Property connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=election_management_system;Integrated Security=True"
    Private Function IsValidIndianPhoneNumber(ByVal phoneNumber As String) As Boolean
        ' Regular expression pattern for Indian phone numbers
        Dim pattern As String = "^[6-9]\d{9}$"

        ' Check if the phone number matches the pattern
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(phoneNumber)
    End Function

    Private Function IsValidAadhar(ByVal aadharNumber As String) As Boolean
        ' Check if Aadhar number has exactly 12 digits
        Return aadharNumber.Length = 12 AndAlso IsNumeric(aadharNumber)
    End Function

    Private Function IsAbove18Years(ByVal dob As Date) As Boolean
        ' Calculate the difference in years between the DOB and the current date
        Dim age As Integer = DateDiff(DateInterval.Year, dob, Date.Today)

        ' Check if the calculated age is greater than or equal to 18
        Return age >= 18
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        admin_home.Show()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        ' Check if the pressed key is a letter
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the key is not a letter and not a control key (like backspace), ignore it
            e.Handled = True
        End If
    End Sub

    Private Sub voter_management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Clear existing rows in DataGridView1
            DataGridView1.Rows.Clear()

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT aadhar, v_name, phoneno, voted FROM voter"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Retrieve data from the reader
                            Dim aadhar As Int64 = reader.GetInt64(0)
                            Dim v_name As String = reader.GetString(1)
                            Dim phoneno As Int64 = reader.GetInt64(2)
                            Dim voted As String = reader.GetString(3)

                            ' Add a new row to DataGridView1 with the retrieved data
                            DataGridView1.Rows.Add(aadhar, v_name, phoneno, voted)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading voter data: " & ex.Message)
        End Try

    End Sub
    Private Function AreAllFieldsFilled() As Boolean
        ' Check if all input fields are filled
        If TextBox2.Text.Trim() = "" OrElse TextBox3.Text.Trim() = "" OrElse TextBox4.Text.Trim() = "" OrElse TextBox5.Text.Trim() = "" Then
            Return False
        End If
        Return True
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not AreAllFieldsFilled() Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If

        Dim aadhar As String = TextBox2.Text
        Dim v_name As String = TextBox3.Text
        Dim dob As Date = DateTimePicker1.Value
        Dim phoneno As String = TextBox4.Text
        Dim state As String = TextBox5.Text

        ' Validate input data
        If Not IsValidIndianPhoneNumber(phoneno) Then
            MessageBox.Show("Invalid phone number.")
            Exit Sub
        End If

        If Not IsValidAadhar(aadhar) Then
            MessageBox.Show("Invalid Aadhar number.")
            Exit Sub
        End If

        If Not IsAbove18Years(dob) Then
            MessageBox.Show("Person is below 18 years old.")
            Exit Sub
        End If
        ' Get input values from user

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE voter SET v_name = @v_name, dob = @dob, phoneno = @phoneno, state = @state WHERE aadhar = @aadhar"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@v_name", v_name)
                    command.Parameters.AddWithValue("@dob", dob)
                    command.Parameters.AddWithValue("@phoneno", phoneno)
                    command.Parameters.AddWithValue("@state", state)
                    command.Parameters.AddWithValue("@aadhar", aadhar)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    MessageBox.Show(rowsAffected & " voter record(s) updated successfully.")
                    Try
                        ' Clear existing rows in DataGridView1
                        DataGridView1.Rows.Clear()

                        Using connection1 As New SqlConnection(connectionString)
                            connection1.Open()

                            Dim query1 As String = "SELECT aadhar, v_name, phoneno, voted FROM voter"
                            Using command1 As New SqlCommand(query1, connection1)
                                Using reader As SqlDataReader = command1.ExecuteReader()
                                    While reader.Read()
                                        ' Retrieve data from the reader
                                        Dim aadhar1 As Int64 = reader.GetInt64(0)
                                        Dim v_name1 As String = reader.GetString(1)
                                        Dim phoneno1 As Int64 = reader.GetInt64(2)
                                        Dim voted As String = reader.GetString(3)

                                        ' Add a new row to DataGridView1 with the retrieved data
                                        DataGridView1.Rows.Add(aadhar1, v_name1, phoneno1, voted)
                                    End While
                                End Using
                            End Using
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error loading voter data: " & ex.Message)
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating voter details: " & ex.Message)
        End Try
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        DateTimePicker1.Value = Date.Today
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aadhar = TextBox1.Text
        If Not IsValidAadhar(aadhar) Then
            MessageBox.Show("Invalid Aadhar number.")
            Exit Sub
        End If
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT aadhar, v_name, dob, phoneno, state, voted FROM voter WHERE aadhar = @aadhar"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@aadhar", aadhar)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Retrieve data from the reader
                            TextBox2.Text = reader.GetInt64(0)
                            TextBox3.Text = reader.GetString(1)
                            DateTimePicker1.Value = reader.GetDateTime(2)
                            TextBox4.Text = reader.GetInt64(3)
                            TextBox5.Text = reader.GetString(4)
                            Dim voted As String = reader.GetString(5)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading voter details: " & ex.Message)
        End Try
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        DateTimePicker1.Value = Date.Today
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then
            ' Retrieve the value of the clicked cell in the first column
            Dim value As Object = DataGridView1.Rows(e.RowIndex).Cells(0).Value

            ' Do something with the value
            If value IsNot Nothing Then
                Dim column1Value As String = value.ToString()
                ' Now you have the value of the first column of the clicked row
                ' You can use this value as needed
                TextBox1.Text = column1Value

            End If
        End If
    End Sub
End Class