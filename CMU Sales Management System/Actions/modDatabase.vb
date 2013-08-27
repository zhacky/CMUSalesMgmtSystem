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

            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error connecting to the database..." & vbCrLf & ex.Message)



        End Try




        Return connected
    End Function
    Public Function checkSqlConnection()
        Dim connected As Boolean = False
        Try
            Dim connectionString As String = My.Settings.connectionString.ToString
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
