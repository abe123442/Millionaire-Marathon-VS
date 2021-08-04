Public Class FrmGame
    Dim ResponseEvent As New Threading.ManualResetEvent(False) ' An event that gets triggered
    Dim NextEvent As New Threading.ManualResetEvent(False) ' An event that gets triggered
    Private ReadOnly Rounds As List(Of ArrayList) = GetRounds(GetQuestions(QuestionsFilePath))

    Private Sub FrmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LastFrm = Me ' Sets the last active form to "Me" - allowing the game to be reset later on
        SetStyle(ControlStyles.SupportsTransparentBackColor, True) ' Allows transparent background
        BackColor = Color.FromArgb(0, Color.Black) ' Sets a transparent background


        ' Defines lists of different control types that get assigned via "GetControls" 
        Dim ButtonList As List(Of Button) = GetControls(Of Button)(Me)
        Dim LabelList As List(Of Label) = GetControls(Of Label)(Me)
        Dim OptionList As New List(Of Button) From {btnOption1, btnOption2, btnOption3, btnOption4}

        ' Initialises an instance of the class "GameClass" with several parameters 
        Dim Game As New GameClass(
            ResponseEvent,
            NextEvent,
            MillionEvent,
            Players,
            Rounds,
            ButtonList,
            LabelList)

        CustomiseButtons(ButtonList, Color.Azure) ' Takes a list of buttons and designs each button in that list
        CustomiseButtons(OptionList, Color.AntiqueWhite) ' Takes a list of buttons and designs each button in that list
        Game.MainGame(FrmStandings) ' Calls the MainGame subroutine 
    End Sub

    Sub BtnOptions_Click(sender As Button, e As EventArgs) _
        Handles btnOption1.Click, btnOption2.Click, btnOption3.Click, btnOption4.Click, btnPass.Click
        Response = sender.Text ' Assigns the player's response for a question
        ResponseEvent.Set() ' Triggers the event when an option is be selected
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        lblReponse.Text = ""
        NextEvent.Set()
    End Sub
End Class