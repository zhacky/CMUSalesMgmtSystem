Imports System.Data.SqlClient
Imports System.Data

Public Class frmMain

    Dim currentUser As String = "Anonymous"
    Dim dbErrorState As Boolean = True
    Dim serverName As String
    Dim userName As String
    Dim userPass As String
    Dim databaseName As String



    Private Sub btnPurchasing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchasing.Click
        serverName = My.Settings.ServerName
        userName = My.Settings.UserName
        userPass = My.Settings.UserPassword
        databaseName = My.Settings.DatabaseName
        Dim purchasingModule As New PurchasingModule.frmPurchasing(currentUser, serverName, userName, userPass, databaseName)

        purchasingModule.ShowDialog()
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If modInteractivity.confirmClosing() Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystem.Click
        diaSystem.ShowDialog()
    End Sub

    Private Sub testDatabase()
        If modDatabase.checkSqlConnection Then
        Else
            DatabaseSettings.ShowDialog()
        End If
    End Sub

    
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        testDatabase()
    End Sub

    Private Sub btnPOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPOS.Click
        serverName = My.Settings.ServerName
        userName = My.Settings.UserName
        userPass = My.Settings.UserPassword
        databaseName = My.Settings.DatabaseName
        Dim frmPoS As New PointOfSaleModule.frmPOS(currentUser, serverName, userName, userPass, databaseName)
        frmPoS.ShowDialog()

    End Sub
End Class
