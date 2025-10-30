Public Class Form1
    Private Sub frmAjoutPatient(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Today.ToLongDateString()
    End Sub
End Class
