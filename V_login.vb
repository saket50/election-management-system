Imports System.Data.SqlClient

Public Class V_login
    Public Property aadharno As String
    Public Property connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=election_management_system;Integrated Security=True"

    Private Function IsValidAadhar(ByVal aadharNumber As String) As Boolean
        ' Check if Aadhar number has exactly 12 digits
        Return aadharNumber.Length = 12 AndAlso IsNumeric(aadharNumber)
    End Function

    Private Function FetchNameAndPassword(ByVal aadhar As String) As Tuple(Of String, String)
        Dim name As String = ""
        Dim password As String = ""

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT v_name, [password] FROM voter WHERE aadhar = @aadhar"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@aadhar", aadhar)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            name = reader("v_name").ToString()
                            password = reader("password").ToString()
                        Else
                            MessageBox.Show("No record found for the given Aadhar number.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching data: " & ex.Message)
        End Try

        Return Tuple.Create(name, password)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsValidAadhar(TextBox1.Text) Then
            MessageBox.Show("Invalid Aadhar number.")
            Exit Sub
        End If
        ' Get Aadhar number and password from the user
        Dim aadhar As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text

        ' Fetch name and password for the provided Aadhar number
        Dim fetchedData As Tuple(Of String, String) = FetchNameAndPassword(aadhar)

        ' Check if the provided password matches the fetched password
        If fetchedData.Item1 <> "" AndAlso fetchedData.Item2 <> "" Then
            If password = fetchedData.Item2 Then
                MessageBox.Show("Login successful. Welcome, " & fetchedData.Item1 & "!")
                aadharno = TextBox1.Text
                TextBox1.Clear()
                TextBox2.Clear()
                Me.Hide()
                voters_home.Show()
            Else
                MessageBox.Show("Incorrect password. Please try again.")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        V_create.Show()
    End Sub

    Private Sub V_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        voter_forgot_password.Show()
    End Sub
End Class