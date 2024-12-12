Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class add_mang_candidate
    Private connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=election_management_system;Integrated Security=True"

    Private Function IsPartyUnique(ByVal party As String) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM candidate WHERE party = @party"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@party", party)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' If count is 0, it means the party is unique
                    Return count = 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking party uniqueness: " & ex.Message)
            Return False ' Assume party is not unique if an error occurs
        End Try
    End Function
    Private Function IsIdUnique(ByVal c_id As Integer) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM candidate WHERE c_id = @c_id"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@c_id", c_id)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' If count is 0, it means the c_id is unique
                    Return count = 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking c_id uniqueness: " & ex.Message)
            Return False ' Assume c_id is not unique if an error occurs
        End Try
    End Function
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the pressed key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the pressed key is not a digit or a control key, suppress it
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox4.KeyPress
        ' Check if the pressed key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the pressed key is not a digit or a control key, suppress it
            e.Handled = True
        End If
    End Sub
    Private Sub LoadCandidateData()
        DataGridView1.Rows.Clear()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT c_id, name, age, party FROM candidate"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Read data from the SqlDataReader and store in variables
                            Dim c_id As Integer = Convert.ToInt32(reader("c_id"))
                            Dim name As String = reader("name").ToString()
                            Dim age As Integer = Convert.ToInt32(reader("age"))
                            Dim party As String = reader("party").ToString()

                            ' Add a new row to the DataGridView
                            DataGridView1.Rows.Add(c_id, name, age, party)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading candidate data: " & ex.Message)
        End Try
    End Sub
    Private Sub AddCandidate(ByVal c_id As Integer, ByVal name As String, ByVal age As Integer, ByVal party As String)
        Try
            If Not IsIdUnique(c_id) Then
                MessageBox.Show("Candidate with same ID already exists. Please choose a different one.")
                Return
            End If
            If Not IsPartyUnique(party) Then
                MessageBox.Show("A Candidate from the same party is already registered")
                Return
            End If
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO candidate (c_id, name, age, party, vote_count) VALUES (@c_id, @name, @age, @party, @count)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@c_id", c_id)
                    command.Parameters.AddWithValue("@name", name)
                    command.Parameters.AddWithValue("@age", age)
                    command.Parameters.AddWithValue("@party", party)
                    command.Parameters.AddWithValue("@count", 0)

                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Candiate successfully registered.")


            ' Reload data into the DataGridView after adding a candidate
            LoadCandidateData()
        Catch ex As Exception
            MessageBox.Show("Error adding candidate: " & ex.Message)
        End Try
    End Sub
    Private Sub DeleteCandidate(ByVal c_id As Integer)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "DELETE FROM candidate WHERE c_id = @c_id"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@c_id", c_id)
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Reload data into the DataGridView after deleting the candidate
            LoadCandidateData()
        Catch ex As Exception
            MessageBox.Show("Error deleting candidate: " & ex.Message)
        End Try
    End Sub

    Private Function ValidateTextBoxes() As Boolean
        Dim age As Integer
        If Not Integer.TryParse(TextBox4.Text, age) Then
            MessageBox.Show("Please enter a valid age in TextBox4.")
            Return False
        End If

        If age <= 25 Then
            MessageBox.Show("Age must be above 25.")
            Return False
        End If
        Return Not {TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text}.Any(Function(text) String.IsNullOrWhiteSpace(text))
    End Function

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Check if the pressed key is a letter
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the key is not a letter and not a control key (like backspace), ignore it
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        ' Check if the pressed key is a letter
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the key is not a letter and not a control key (like backspace), ignore it
            e.Handled = True
        End If
    End Sub


    Private Sub add_mang_candidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCandidateData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidateTextBoxes() Then
            Dim c_id, age As Integer
            Integer.TryParse(TextBox1.Text, c_id)
            Integer.TryParse(TextBox4.Text, age)
            AddCandidate(c_id, TextBox2.Text, age, TextBox3.Text)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()

        Else
            ' If any of the textboxes are empty, display a message to the user
            MessageBox.Show("Please enter values in all textboxes.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Are you sure you want to delete candidate?", "Confirmation", MessageBoxButtons.OKCancel)
        If DialogResult.Yes Then
            Dim in_c_id As Integer
            Integer.TryParse(TextBox5.Text, in_c_id)
            DeleteCandidate(in_c_id)
            TextBox5.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox5.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        admin_home.Show()
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
                TextBox5.Text = column1Value
            End If
        End If
    End Sub
End Class