Public Class body_mass_index
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim height, weight, bmi As Single
        height = Val(TextBox2.Text)
        weight = Val(TextBox1.Text)
        bmi = (weight) / ((height ^ 2) / 10000)

        If bmi < 18.5 Then
            MsgBox("YOUR BODY MASS INDEX IS" & bmi & "YOU ARE UNDER-WEIGTH")
        Else
            If bmi >= 18.5 And bmi <= 24.9 Then
                MsgBox("YOUR BODY MASS INDEX IS" & bmi & "YOU HAVE NORMAL-WEIGHT")
            Else
                If bmi >= 25 And bmi <= 29.9 Then
                    MsgBox("YOUR BODY MASS INDEX IS" & bmi & "YOU ARE OVER-WEIGHT")
                Else
                    If bmi >= 30 Then
                        MsgBox("YOUR BODY MASS INDEX IS" & bmi & "YOU ARE OBESE")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub body_mass_index_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class