Public Class Form1
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click

        limparLista()

        Dim i As Integer

        Do While i <= 5
            lstLista.Items.Add("Número " & i & " adicionado!")
            i += 1
        Loop

    End Sub

    Private Sub limparLista()
        lstLista.Items.Clear()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        limparLista()
    End Sub
End Class
