Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class DatabaseSettings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK


        If modDatabase.checkSqlConnection() Then
            frmMain.Show()
            Me.Close()


        End If




    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub DatabaseSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If modDatabase.checkSqlConnection() Then
        '    Dim startApp As New frmMain
        '    startApp.Show()
        '    Me.Close()

        'End If
        loadDatabaseSettings()
    End Sub

    Private Sub btnTestConn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestConn.Click


        If modDatabase.checkSqlConnection(cboServerName.Text, txtUsername.Text, txtPassword.Text, cboDatabase.Text) Then
            saveInfoToSettings()
            MessageBox.Show("Test Succeeded")

        Else
            Console.WriteLine("Test Unsuccessful")
        End If
    End Sub

   
   

    Private Sub cboDatabase_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cboDatabase.MouseDown
        cboDatabase.Items.Clear()
        listDatabases()
    End Sub

    Private Sub listDatabases()
        Dim server As String = cboServerName.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim testString As String = "Data Source=" & server & ";Initial Catalog=;Persist Security Info=True;User ID=" & username & ";Password=" & password & ""
        Dim sqlString As String = "SELECT * FROM [master].[dbo].[sysdatabases] WHERE name NOT IN ('tempbd', 'master', 'model', 'msdb')"
        'Dim sqlString As String = "SHOW databases;"

        Dim conn As SqlConnection
        Try
            conn = New SqlConnection(testString)
            conn.Open()
            Dim sqlComm As New SqlCommand(sqlString, conn)
            Dim data As SqlDataReader
            data = sqlComm.ExecuteReader()
            While data.Read
                'For i As Integer = 0 To data.FieldCount - 1
                cboDatabase.Items.Add(data("name").ToString)
                'Next
            End While





            conn.Close()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub saveInfoToSettings()
        Dim server As String = cboServerName.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim database As String = cboDatabase.Text
        My.Settings.DatabaseName = database

        Dim testString As String = "Data Source=" & server & ";Initial Catalog=" & database & ";Persist Security Info=True;User ID=" & username & ";Password=" & password & ""
        My.Settings.dummyString = testString
        My.Settings.Save()
        MessageBox.Show(My.Settings.DatabaseName.ToString)

    End Sub

   

    Private Sub loadDatabaseSettings()
        cboServerName.Text = My.Settings.ServerName
        txtUsername.Text = My.Settings.UserName
        txtPassword.Text = My.Settings.UserPassword
    End Sub

End Class
