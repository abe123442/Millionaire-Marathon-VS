Public Class FrmMenu

    Sub SwitchPanel(ByVal panel As Form)
        pnl.Controls.Clear()
        panel.TopLevel = False
        pnl.Controls.Add(panel)
        panel.Show()
        pnl.BringToFront()
    End Sub

    Private Sub Play_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        SwitchPanel(FrmSetup)
    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        SwitchPanel(FrmHelp)
    End Sub

End Class
