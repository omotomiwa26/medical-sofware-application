Public Class body_surface_area

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim h, w, bsa As Single
        h = Val(TextBox2.Text)
        w = Val(TextBox1.Text)

        bsa = (((h / 100) * w) / 3600) * 0.5

        MsgBox("YOUR BODY SURFAECE AREA IS" & bsa)
    End Sub

    Private Sub body_surface_area_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class