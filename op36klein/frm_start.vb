Public Class frm_start
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As New frm_login
        login.MdiParent = Me
        login.Show()
    End Sub
End Class
