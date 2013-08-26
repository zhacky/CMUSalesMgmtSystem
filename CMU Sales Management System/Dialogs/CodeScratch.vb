
'                Select Case conn.State
'                    Case ConnectionState.Connecting
'                        Console.WriteLine("Connecting...")
'                    Case ConnectionState.Executing
'                        Console.WriteLine("executing...")
'                    Case ConnectionState.Fetching
'                        Console.WriteLine("fetching...")
'                    Case ConnectionState.Broken
'                        Console.WriteLine("broken")
'                    Case ConnectionState.Open
'                        Console.WriteLine("open")
'                    Case ConnectionState.Closed
'                        Console.WriteLine("closed")

'                End Select

'                Select Case conn.State
'                    Case ConnectionState.Connecting
'                        Console.WriteLine("Connecting...")
'                    Case ConnectionState.Executing
'                        Console.WriteLine("executing...")
'                    Case ConnectionState.Fetching
'                        Console.WriteLine("fetching...")
'                    Case ConnectionState.Broken
'                        Console.WriteLine("broken")
'                    Case ConnectionState.Open
'                        Console.WriteLine("open")
'                    Case ConnectionState.Closed
'                        Console.WriteLine("closed")

'                End Select
'                Console.WriteLine("Successfully connected...")
'                Console.WriteLine(conn.State.ToString)

'Dim sqlcommand As New SqlCommand("SELECT * FROM [TestPOS].[dbo].[users]", conn)
'Dim data As SqlDataReader
'                Try
'                    data = sqlcommand.ExecuteReader
'                    While data.Read
'                        For i As Integer = 0 To (data.FieldCount - 1)
'                            Console.WriteLine(data(i).ToString)
'                        Next
'                    End While
'            Catch ex As Exception
'                Console.WriteLine("Error executing SQL command" & vbCrLf & ex.Message)
'            End Try

