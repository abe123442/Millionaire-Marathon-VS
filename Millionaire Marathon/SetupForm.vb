Public Class FrmSetup
    Private Sub FrmSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.FromArgb(0, Color.Black)
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Players = New Hashtable From {
        {"Player 1", New PlayerClass(txtPlayer1.Text)},
        {"Player 2", New PlayerClass(txtPlayer2.Text)},
        {"Player 3", New PlayerClass(txtPlayer3.Text)},
        {"Player 4", New PlayerClass(txtPlayer4.Text)}
        }

        SwitchPanel(FrmGame)
    End Sub

End Class