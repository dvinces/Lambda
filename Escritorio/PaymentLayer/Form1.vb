Public Class Form1
    Private Sub FacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaToolStripMenuItem.Click
        Dim f As New Factura
        f.MdiParent = Me
        f.Show()

    End Sub
End Class
