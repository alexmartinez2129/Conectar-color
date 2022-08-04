Public Class Form1
    Private Sub Textcolores_TextChanged(sender As Object, e As EventArgs) Handles Textcolores.TextChanged

    End Sub

    Private Sub btnRojo_Click(sender As Object, e As EventArgs) Handles btnRojo.Click
        Textcolores.BackColor = Color.Red
    End Sub

    Private Sub BtnAzul_Click(sender As Object, e As EventArgs) Handles BtnAzul.Click
        Textcolores.BackColor = Color.SkyBlue
    End Sub

    Private Sub BtnRosado_Click(sender As Object, e As EventArgs) Handles BtnRosado.Click
        Textcolores.BackColor = Color.HotPink
    End Sub

    Private Sub BtnVerde_Click(sender As Object, e As EventArgs) Handles BtnVerde.Click
        Textcolores.BackColor = Color.Lime
    End Sub

    Private Sub BtnNaranja_Click(sender As Object, e As EventArgs) Handles BtnNaranja.Click
        Textcolores.BackColor = Color.DarkOrange
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Textcolores.BackColor = Color.Yellow
    End Sub
End Class
