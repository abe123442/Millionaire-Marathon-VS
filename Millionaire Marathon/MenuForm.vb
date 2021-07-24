Public Class FrmMenu
    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        SwitchPanel(FrmSetup)
    End Sub

    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        SwitchPanel(FrmHelp)
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.FromArgb(0, Color.Black)
    End Sub
End Class