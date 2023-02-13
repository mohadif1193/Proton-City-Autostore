Public Class frmconfig
    Private Sub pbInvoice_Click(sender As Object, e As EventArgs) Handles pbInvoice.Click

    End Sub

    Private Sub pbClient_Click(sender As Object, e As EventArgs) Handles pbClient.Click
        MsgBox("Hello Dear Client")
    End Sub

    Private Sub pbClient_MouseUp(sender As Object, e As MouseEventArgs) Handles pbClient.MouseUp

    End Sub

    Private Sub pbClient_MouseHover(sender As Object, e As EventArgs) Handles pbClient.MouseHover
        pbClient.Image = Protonautostore.My.Resources.clients2
    End Sub

    Private Sub pbClient_MouseLeave(sender As Object, e As EventArgs) Handles pbClient.MouseLeave
        pbClient.Image = Protonautostore.My.Resources.clients
    End Sub
End Class