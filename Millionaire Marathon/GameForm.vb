Public Class FrmGame
    Dim OptionEvent As New Threading.ManualResetEvent(False) ' An event that gets triggered
    Private ReadOnly Rounds As List(Of ArrayList) = GetRounds(GetQuestions(FilePath))

    Private Sub FrmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LastFrm = Me ' Sets the last active form to "Me" - allowing the game to be reset later on
        SetStyle(ControlStyles.SupportsTransparentBackColor, True) ' Allows transparent background
        BackColor = Color.FromArgb(0, Color.Black) ' Sets a transparent background

        ' Defines lists of different control types that get assigned via "GetControls" 
        Dim ButtonList As List(Of Button) = GetControls(Of Button)(frm:=Me)
        Dim LabelList As List(Of Label) = GetControls(Of Label)(frm:=Me)

        ' Initialises an instance of the class "GameClass" with several parameters 
        Dim Game As New GameClass(
            buttonclick:=OptionEvent,
            millionevent:=MillionEvent,
            players:=Players,
            rounds:=Rounds,
            buttons:=ButtonList,
            labels:=LabelList)

        CustomiseButtons(ButtonList) ' Takes a list of buttons and designs each button in that list
        Game.MainGame(nextForm:=FrmStandings) ' Calls the MainGame subroutine 
    End Sub

    Sub BtnOptions_Click(sender As Button, e As EventArgs) _
        Handles btnOption1.Click, btnOption2.Click, btnOption3.Click, btnOption4.Click, btnPass.Click
        Response = sender.Text ' Assigns the player's response for a question
        OptionEvent.Set() ' Triggers the event when an option is be selected
    End Sub
End Class