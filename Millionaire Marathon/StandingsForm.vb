Public Class FrmStandings
    Private Sub FrmStandings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.FromArgb(0, Color.Black)


        Dim sortedPlayers = GetStandings()
        lblWinner.Text = $"{sortedPlayers(0).Value.Name} wins!"
        LblRankFirst.Text = $"{sortedPlayers(0).Value.Name} has won ${sortedPlayers(0).Value.Money}"
        LblRankSecond.Text = $"{sortedPlayers(1).Value.Name} has won ${sortedPlayers(1).Value.Money}"
        LblRankThird.Text = $"{sortedPlayers(2).Value.Name} has won ${sortedPlayers(2).Value.Money}"
        LblRankFourth.Text = $"{sortedPlayers(3).Value.Name} has won ${sortedPlayers(3).Value.Money}"
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        FrmGame = Nothing
        SwitchPanel(FrmMenu)
    End Sub

    Function GetStandings() As Array
        Dim sortedPlayers = From Player In Players Order By Player.Value.Money Descending
        Return sortedPlayers.ToArray()
    End Function

End Class