Imports System.Data.SqlClient
Imports System.Data

Public Class frmMain

    Dim currentUser As String = "Anonymous"
    Dim dbErrorState As Boolean = True



    Private Sub btnPurchasing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchasing.Click
        Dim purchasingModule As New PurchasingModule.frmPurchasing(currentUser)

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
End Class
