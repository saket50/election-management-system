Imports System.Data.SqlClient

Public Class voters_home
    Dim voteStartEnd As String
    Private Sub GetVotedStatus(ByVal aadhar As String)
        Dim votedStatus As String = ""

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT voted FROM voter WHERE aadhar = @aadhar"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@aadhar", aadhar)

                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        votedStatus = result.ToString()
                    End If
                End Using
            End Using

            If votedStatus = "No" Then
                Me.Hide()
                vote_page.Show()
            Else
                MessageBox.Show("You have already voted")
            End If
        Catch ex As Exception
            MessageBox.Show("Error fetching voted status: " & ex.Message)
        End Try
    End Sub


    Private Sub GetVoteStartEnd()
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
            MessageBox.Show("Election has not starter yet!", "Voting yet to start", MessageBoxButtons.OK)

        Else
            GetVotedStatus(aadhar)
        End If
    End Sub
    Public Property connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=election_management_system;Integrated Security=True"
    Dim aadhar As String = V_login.aadharno
    Private Sub voters_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                            Label1.Text = "Welcome, " & name
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching name: " & ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        GetVoteStartEnd()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("Are you sure you want to logout?", "Confirm logout", MessageBoxButtons.OKCancel)
        If DialogResult.OK Then
            Me.Close()
            V_login.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        voters_settings.Show()
    End Sub
End Class