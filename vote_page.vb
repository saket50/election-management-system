Imports System.Data.SqlClient

Public Class vote_page
    Private connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=election_management_system;Integrated Security=True"
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
                            DataGridView1.Rows.Add(party, name)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading candidate data: " & ex.Message)
        End Try
    End Sub
    Private Sub vote_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCandidateData()
        ' Fetch party data from the database
        Dim parties As New List(Of String)()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT DISTINCT party FROM candidate"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            parties.Add(reader.GetString(0)) ' Add party name to the list
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching party data: " & ex.Message)
        End Try

        ' Create buttons dynamically for each party
        For Each party In parties
            Dim btn As New Button()
            btn.Text = party
            btn.Width = 100
            btn.Height = 30
            btn.Margin = New Padding(10)
            AddHandler btn.Click, AddressOf PartyButtonClick ' Add click event handler
            FlowLayoutPanel1.Controls.Add(btn) ' Add button to the flow layout panel
        Next
    End Sub

    Private Sub PartyButtonClick(sender As Object, e As EventArgs)
        ' Get the party name from the button text
        Dim partyName As String = DirectCast(sender, Button).Text

        ' Increase the vote count for the selected party
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE voter SET voted = @votedStatus WHERE aadhar = @voterId"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@votedStatus", "Yes")
                    command.Parameters.AddWithValue("@voterId", V_login.aadharno)
                    command.ExecuteNonQuery()
                End Using
            End Using
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE candidate SET vote_count = vote_count + 1 WHERE party = @party"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@party", partyName)
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Thank You for voting," & vbCrLf & "Your vote has been registered successfully!", "Vote Successfull", MessageBoxButtons.OK)
            Me.Hide()
            voters_home.Show()
        Catch ex As Exception
            MessageBox.Show("Error updating vote count: " & ex.Message)
        End Try

    End Sub
End Class