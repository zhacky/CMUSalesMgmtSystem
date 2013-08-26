Module modInteractivity

    Function confirmClosing() As Boolean
        Dim confirmation As Boolean = False

        If DialogResult.Yes = MessageBox.Show("Are you sure you want to logout?", "Confirm logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) Then
            confirmation = True
        End If



        Return confirmation
    End Function

End Module
