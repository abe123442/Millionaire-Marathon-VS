Public Class FrmMenu

    Sub SwitchPanel(ByVal panel As Form)
        pnl.Controls.Clear()
        panel.TopLevel = False
        pnl.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Play_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        pnl.BringToFront()
        SwitchPanel(FrmSetup)
    End Sub

End Class
