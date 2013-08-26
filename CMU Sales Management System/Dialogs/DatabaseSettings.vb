Imports System.Windows.Forms

Public Class DatabaseSettings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK


        If modDatabase.checkSqlConnection() Then
            Dim startApp As New frmMain
            startApp.Show()
            Me.Close()

        Else

        End If




    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        
        Me.Close()
    End Sub

    Private Sub DatabaseSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If modDatabase.checkSqlConnection() Then
            Dim startApp As New frmMain
            startApp.Show()
            Me.Close()

        End If
    End Sub
End Class
