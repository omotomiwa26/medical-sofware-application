Public Class splash_screen

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("Are you sure you want to quit?", vbYesNo + MsgBoxStyle.Information) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub
End Class
