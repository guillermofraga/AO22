Public Class TecladoEventos
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TecladoEventos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Label1.Text += e.KeyChar.ToString
        Label2.Text += Convert.ToInt32(e.KeyChar).ToString

    End Sub
End Class