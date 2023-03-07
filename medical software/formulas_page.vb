Public Class formulas_page

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        body_mass_index.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ideal_body_weight.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        body_surface_area.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        splash_screen.Show()
    End Sub

    Private Sub formulas_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class