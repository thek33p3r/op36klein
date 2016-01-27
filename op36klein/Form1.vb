Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As New login
        login.MdiParent = Me
        login.Show()
    End Sub
End Class
