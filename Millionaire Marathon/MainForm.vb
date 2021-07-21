Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelMain.BackColor = Color.FromArgb(0, Color.Black)
        Call SwitchPanel(FrmMenu)
    End Sub
End Class
