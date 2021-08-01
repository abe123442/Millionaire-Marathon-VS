Public Class FrmStandings
    Private Sub FrmStandings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.FromArgb(0, Color.Black)
        CustomiseButtons(btns:=GetControls(Of Button)(frm:=Me)) ' Gets a list of buttons and designs each button

        Dim sortedPlayers As Array = GetStandings()
        lblWinner.Text = $"{sortedPlayers(0).Value.Name} wins!"
        LblRankFirst.Text = $"{sortedPlayers(0).Value.Name}'s earnings: ${sortedPlayers(0).Value.Money}"
        LblRankSecond.Text = $"{sortedPlayers(1).Value.Name}'s earnings: ${sortedPlayers(1).Value.Money}"
        LblRankThird.Text = $"{sortedPlayers(2).Value.Name}'s earnings: ${sortedPlayers(2).Value.Money}"
        LblRankFourth.Text = $"{sortedPlayers(3).Value.Name}'s earnings: ${sortedPlayers(3).Value.Money}"
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ResetLastFrm(frm:=Me) ' Resets the previous form
        PlayMusic(Update:=True)
        SwitchPanel(frm:=FrmMenu) ' Displays FrmMenu in the panel
    End Sub

    Private Function GetStandings() As Array
        ' A function that returns a "Players" array ordered in descending order by a player's earnings
        Dim sortedPlayers = From Player In Players Order By Player.Value.Money Descending
        Return sortedPlayers.ToArray()
    End Function

End Class