Imports System.Windows.Forms

Public Class diaSystem

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnDBSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDBSettings.Click
        DatabaseSettings.ShowDialog()
    End Sub
End Class
