Public Class FrmStandings
    Private Sub FrmStandings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.FromArgb(0, Color.Black)

        Dim sortedPlayers = From Player In FrmGame.Players Order By Player.Value.Money Descending
        LblRankFirst.Text = $"{sortedPlayers(0).Key} has won ${sortedPlayers(0).Value.Money}"
        LblRankSecond.Text = $"{sortedPlayers(1).Key} has won ${sortedPlayers(1).Value.Money}"
        LblRankThird.Text = $"{sortedPlayers(2).Key} has won ${sortedPlayers(2).Value.Money}"
        LblRankFourth.Text = $"{sortedPlayers(3).Key} has won ${sortedPlayers(3).Value.Money}"
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        SwitchPanel(FrmMenu)
    End Sub
End Class