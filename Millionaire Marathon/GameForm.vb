Public Class FrmGame
    Dim MRE As New Threading.ManualResetEvent(False)

    ReadOnly FilePath As String = "assets\Questions.csv"
    ReadOnly Rounds = GetRounds(GetQuestions(FilePath))

    Private Sub FrmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.FromArgb(0, Color.Black)
        Dim ButtonList As New List(Of Button) From {btnOption1, btnOption2, btnOption3, btnOption4}
        Dim LabelList As New List(Of Label) From {lblCurrentPlayer, lblMoney, lblQuestion, lblReponse, lblRound}

        Dim Game As New GameClass(
            mre:=MRE,
            players:=Players,
            rounds:=Rounds,
            buttons:=ButtonList,
            labels:=LabelList)

        Game.MainGame(lblReponse:=lblReponse, btnPass:=btnPass, nextForm:=FrmStandings)
    End Sub

    Sub BtnOptions_Click(sender As Button, e As EventArgs) _
        Handles btnOption1.Click, btnOption2.Click, btnOption3.Click, btnOption4.Click, btnPass.Click
        Response = sender.Text
        MRE.Set()
    End Sub
End Class