Public Class FrmMenu
    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.FromArgb(0, Color.Black)
    End Sub

    Private Sub Btn_Click(sender As Button, e As EventArgs) Handles btnPlay.Click, btnHelp.Click, btnExit.Click
        Select Case sender.Name
            Case "btnPlay"
                FrmStandings = Nothing
                SwitchPanel(FrmSetup)
            Case "btnHelp"
                SwitchPanel(FrmHelp)
            Case "btnExit"
                ParentForm.Close()
        End Select
    End Sub
End Class