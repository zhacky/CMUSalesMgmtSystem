Imports System.Data.SqlClient

Module modDatabase

    Public Function checkSqlConnection(ByVal servername As String, ByVal username As String, _
                                       ByVal userpassword As String, ByVal database As String)
        Dim connected As Boolean = False
        Try
            Dim connectionString As String = _
                "Data Source=" & servername & ";Initial Catalog=" & database & _
                ";Persist Security Info=True;User ID=" & username & ";Password=" & userpassword & ""
            Console.WriteLine("Running Database Test...")
            Dim conn As New SqlConnection(connectionString)
            conn.Open()
            connected = True
            Console.WriteLine("Connection State: " & conn.State.ToString)
            Console.WriteLine("Attempting to get values from a database table...")
            Dim sqlcommand As New SqlCommand("SELECT * FROM [TestPOS].[dbo].[users]", conn)
            Dim data As SqlDataReader
            Try
                data = sqlcommand.ExecuteReader
                While data.Read
                    For i As Integer = 0 To (data.FieldCount - 1)
                        Console.WriteLine(data(i).ToString)
                    Next
                End While
            Catch ex As Exception
                Console.WriteLine("Error executing SQL command" & vbCrLf & ex.Message)
            End Try
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error connecting to the database..." & vbCrLf & ex.Message)



        End Try




        Return connected
    End Function
    Public Function checkSqlConnection()
        Dim connected As Boolean = False
        Dim server As String = My.Settings.ServerName
        Dim username As String = My.Settings.UserName
        Dim userpass As String = My.Settings.UserPassword
        Dim database As String = My.Settings.DatabaseName

        Try


            Dim connectionString As String = "Data Source=" & _
                server & ";Initial Catalog=" & _
                database & ";Persist Security Info=True;User ID=" & username & ";Password=" & userpass & ""
            Console.WriteLine("Running Database Test...")
            Dim conn As New SqlConnection(connectionString)
            conn.Open()
            connected = True
            Console.WriteLine("Connection State: " & conn.State.ToString)

            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error connecting to the database..." & vbCrLf & ex.Message)



        End Try




        Return connected
    End Function
End Module
