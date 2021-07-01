Public Class FrmSetup
    Public playerNames As Hashtable
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim pNames As New Hashtable From {
        {"Player 1", txtPlayer1.Text},
        {"Player 2", txtPlayer2.Text},
        {"Player 3", txtPlayer3.Text},
        {"Player 4", txtPlayer4.Text}
        }
        playerNames = pNames
        FrmMenu.SwitchPanel(FrmGame)
    End Sub
End Class