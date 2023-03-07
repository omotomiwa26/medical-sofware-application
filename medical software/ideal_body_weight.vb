Public Class ideal_body_weight
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim h, idl1, idl2 As Single
        H = Val(TextBox2.Text)
       

        idl1 = 50 + 2.3 * (h / 100) - 60
        idl2 = 45.5 + 2.3 * (h / 100) - 60

        If cbsex.SelectedItem = "MALE" Then
            MsgBox("YOUR IDEAL BODY WEIGHT IS" & idl1)
        Else
            If cbsex.SelectedItem = "FEMALE" Then
                MsgBox("YOUR IDEAL BODY WEIGHT IS" & idl2)
            End If
        End If
    End Sub

    Private Sub ideal_body_weight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbsex.Items.Add("MALE")
        cbsex.Items.Add("FEMALE")
    End Sub
End Class