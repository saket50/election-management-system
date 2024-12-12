Imports System.Data.SqlClient

Public Class voting_poll
    Public Property connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=election_management_system;Integrated Security=True"
    Dim voteStartEnd As String
    Private Function GetVoteStartEnd() As String
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT vote_start_end FROM admin where id = 1001"
                Using command As New SqlCommand(query, connection)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        voteStartEnd = result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching vote_start_end: " & ex.Message)
        End Try
        If voteStartEnd = "NO" Then
            Button1.Text = "Start"
            Button1.BackColor = Color.FromArgb(144, 238, 144)
        Else
            Button1.Text = "End"
            Button1.BackColor = Color.FromArgb(255, 204, 204)
        End If
        Return voteStartEnd
    End Function

    Private Sub voting_poll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        voteStartEnd = GetVoteStartEnd()
        Dim partyNameVoteData As New List(Of (String, String, Integer))()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT party, name, vote_count FROM candidate"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim party As String = reader.GetString(0)
                            Dim name As String = reader.GetString(1)
                            Dim voteCount As Integer = reader.GetInt32(2)
                            partyNameVoteData.Add((party, name, voteCount))
                            DataGridView1.Rows.Add(party, name, voteCount)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching party, name, and vote_count: " & ex.Message)
        End Try

        ' Find candidate with maximum vote_count and calculate total vote_count
        Dim maxVotes As Integer = Integer.MinValue
        Dim totalVotes As Integer = 0
        Dim candidateWithMaxVotes As String = ""
        Dim candidatesWithMaxVotes As New List(Of String)()

        ' Loop through each tuple in the partyNameVoteData collection
        For Each data As (String, String, Integer) In partyNameVoteData
            Try
                ' Add the vote count to the totalVotes
                totalVotes += data.Item3

                ' Check if the current vote count is greater than the current maxVotes
                If data.Item3 > maxVotes Then
                    ' Update maxVotes with the current vote count
                    maxVotes = data.Item3
                    ' Clear the list and add the new candidate with the maximum votes
                    candidatesWithMaxVotes.Clear()
                    candidatesWithMaxVotes.Add(data.Item2)
                ElseIf data.Item3 = maxVotes Then
                    ' If the current vote count equals the maxVotes, add the candidate to the list
                    candidatesWithMaxVotes.Add(data.Item2)
                End If

                ' Update the label for total votes
                Label2.Text = $"Total Votes: {totalVotes}"

                ' Update the label for the winner or indicate a tie
                If candidatesWithMaxVotes.Count = 1 Then
                    candidateWithMaxVotes = candidatesWithMaxVotes(0)
                    Label3.Text = $"Winner: {candidateWithMaxVotes}" & vbCrLf & $"With {maxVotes} votes"
                Else
                    Dim tiedCandidates As String = String.Join(", ", candidatesWithMaxVotes)
                    Label3.Text = $"Tie between: {tiedCandidates}" & vbCrLf & $"Each with {maxVotes} votes"
                End If

            Catch ex As Exception
                ' Display an error message if there's an issue processing the data
                MessageBox.Show($"Error processing data: {ex.Message}")
            End Try
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        voteStartEnd = GetVoteStartEnd()
        If voteStartEnd = "START" Then
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    Dim query As String = "UPDATE admin SET vote_start_end = @voteStartEnd WHERE id = @id"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@voteStartEnd", "NO")
                        command.Parameters.AddWithValue("@id", 1001)
                        command.ExecuteNonQuery()
                    End Using
                End Using
                Button1.Text = "Start"
                Button1.BackColor = Color.FromArgb(144, 238, 144)
            Catch ex As Exception
                MessageBox.Show("Error updating vote start and end: " & ex.Message)
            End Try
        Else
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    Dim query As String = "UPDATE admin SET vote_start_end = @voteStartEnd WHERE id = @id"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@voteStartEnd", "START")
                        command.Parameters.AddWithValue("@id", 1001)
                        command.ExecuteNonQuery()
                    End Using
                End Using
                Button1.Text = "End"
                Button1.BackColor = Color.FromArgb(255, 204, 204)
            Catch ex As Exception
                MessageBox.Show("Error updating vote start and end: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        admin_home.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Update voted attribute in voters table
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim updateQuery As String = "UPDATE voter SET voted = 'No'"
                Using updateCommand As New SqlCommand(updateQuery, connection)
                    updateCommand.ExecuteNonQuery()
                End Using
            End Using

            ' Delete all data from candidate table
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim deleteQuery As String = "DELETE FROM candidate"
                Using deleteCommand As New SqlCommand(deleteQuery, connection)
                    deleteCommand.ExecuteNonQuery()
                End Using
            End Using

            Label2.Text = $"Total Votes: NA"
            Label3.Text = $"Winner: NA"

            MessageBox.Show("Ready for next Election")
            DataGridView1.Rows.Clear()
        Catch ex As Exception
            MessageBox.Show("Error resetting voters and candidates: " & ex.Message)
        End Try
    End Sub
End Class