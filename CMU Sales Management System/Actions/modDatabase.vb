Imports System.Data.SqlClient

Module modDatabase

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
