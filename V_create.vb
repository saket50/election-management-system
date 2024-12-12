Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class V_create
    Public Property connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=election_management_system;Integrated Security=True"

    Private Sub V_create_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the form
        ClearForm()
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the pressed key is a letter or a control key (like backspace)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the key is not a letter and not a control key, ignore it
            e.Handled = True
        End If
    End Sub


    Private Sub ClearForm()
        ' Clear all input fields
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.SelectedIndex = -1
        DateTimePicker1.Value = DateTime.Today
    End Sub

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

    Private Sub InsertData(ByVal aadhar As String, ByVal v_name As String, ByVal dob As Date, ByVal phoneno As String, ByVal state As String, ByVal voted As String, ByVal password As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO voter (aadhar, v_name, dob, phoneno, state, voted, password) VALUES (@aadhar, @v_name, @dob, @phoneno, @state, @voted, @password)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@aadhar", aadhar)
                    command.Parameters.AddWithValue("@v_name", v_name)
                    command.Parameters.AddWithValue("@dob", dob)
                    command.Parameters.AddWithValue("@phoneno", phoneno)
                    command.Parameters.AddWithValue("@state", state)
                    command.Parameters.AddWithValue("@voted", voted)
                    command.Parameters.AddWithValue("@password", password)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Data inserted successfully.")
            ClearForm() ' Clear the form after successful insertion
            Me.Hide()
            V_login.Show()
        Catch ex As Exception
            MessageBox.Show("Error inserting data: " & ex.Message)
        End Try
    End Sub

    Private Function AreAllFieldsFilled() As Boolean
        ' Check if all input fields are filled
        If TextBox1.Text.Trim() = "" OrElse TextBox2.Text.Trim() = "" OrElse TextBox3.Text.Trim() = "" OrElse TextBox4.Text.Trim() = "" OrElse ComboBox1.SelectedIndex = -1 Then
            Return False
        End If
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if all fields are filled
        If Not AreAllFieldsFilled() Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If

        ' Get input values from user
        Dim aadhar As String = TextBox2.Text
        Dim v_name As String = TextBox1.Text
        Dim dob As Date = DateTimePicker1.Value
        Dim phoneno As String = TextBox3.Text
        Dim state As String = ComboBox1.SelectedItem.ToString()
        Dim voted As String = "No"
        Dim password As String = TextBox4.Text

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

        ' Insert data into the database
        InsertData(aadhar, v_name, dob, phoneno, state, voted, password)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Clear the form and show the login form
        ClearForm()
        Me.Hide()
        V_login.Show()
    End Sub
End Class
