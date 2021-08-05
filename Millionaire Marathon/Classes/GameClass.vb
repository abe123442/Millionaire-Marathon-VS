Class GameClass
    ' The main game class that is instantiated to run the game in "FrmGame"
    Property Buttons As List(Of Button)
    Property Labels As List(Of Label)
    Property PlayerResponse As Threading.ManualResetEvent  'Triggers when a player responds to a question
    Property MillionEvent As Threading.ManualResetEvent ' Triggers when a player can attempt the million dollar challenge
    Property Players As Hashtable ' Contains all the players ("PlayerClass") of the game
    Property Rounds As List(Of ArrayList) ' Contains 4 rounds, each round containing 21/22 questions

    ' Constructor method used to instantiate this class
    Sub New(
           buttonclick As Threading.ManualResetEvent,
           millionevent As Threading.ManualResetEvent,
           players As Hashtable,
           rounds As List(Of ArrayList),
           buttons As List(Of Button),
           labels As List(Of Label))
        Me.PlayerResponse = buttonclick
        Me.MillionEvent = millionevent
        Me.Players = players
        Me.Rounds = rounds
        Me.Buttons = buttons
        Me.Labels = labels
    End Sub



    REM: Async Sub MainGame(nextForm)
    '
    'Summary:
    '   The MainGame subroutine is able to run the entire game when called only once.
    '   It's asynchronous functionality means that it can wait for certain snippets of code to execute.
    '
    'Parameters:
    '   [Form] "nextForm" -> the panel "PanelMain" in MainForm displays this Form when the game is over
    '
    'Local Variables:
    '   [Label] "lblResponse" -> displays a message if a player is right or not
    '   [Label] "lblChallenge" -> displays a message when a player has reached the last stage of the game
    '   [Button] "btnPass" -> players pass with this button if they have passes or are not attempting the final question
    '   [Class: GameVariablesClass] "Vars" -> class instance that contains variables used for logic, calculations and/or visuals
    '   [String] "PlayerID" -> abbreviation for Vars.CurrentPlayerInfo.CurrentPlayerID
    '   [Arraylist] "Round" -> accessible when iterating over the "Rounds" property; contains a set of information for 21/22 questions
    '   [Integer] "QuestionNo" -> accessible when iterating over "Round"; used to assign to properties and update visuals

    'Description:
    '   This subroutine uses the local variables above, and the properties of this class
    '   to iterate over each question in each "Round" in "Rounds" and "awaits" for a response
    '   It then checks and returns visual feedback for the response of each player. A special
    '   Form appears if a player has earned enough money and gives them a choice to accept or
    '   decline the challenge (Million Dollars)
    REM

    Async Sub MainGame(nextForm As Form)
        ' Getting the labels which will be updated by game logic
        Dim lblReponse As Label = GetControlByName(ctrls:=Me.Labels, name:="lblReponse")
        Dim btnPass As Button = GetControlByName(ctrls:=Me.Buttons, name:="btnPass")
        Dim lblChallenge As Label = GetControlByName(ctrls:=Me.Labels, name:="lblChallenge")

        ' Instantiates "GameVariablesClass" and assigns a property to a subclass instance
        Dim Vars As New GameVariablesClass With {
            .CurrentPlayerInfo = New GameVariablesClass.CurrentPlayerInfoClass
        }
        Dim PlayerID As String
        For Each Round As ArrayList In Rounds
            Vars.CurrentRound = Rounds.IndexOf(Round) + 1
            For QuestionNo = 0 To Round.Count - 1

                ' Updates the "CurrentQuestionInfo" property of "Vars" every iteration of "QuestionNo"
                Vars.CurrentQuestionInfo = New GameVariablesClass.CurrentQuestionInfoClass With {
                    .CurrentQuestionNo = QuestionNo,
                    .CurrentQuestion = Round(QuestionNo)(0),
                    .OptionsAnswersArray = RandomiseOptions(Round(.CurrentQuestionNo)),
                    .CorrectAnswer = .OptionsAnswersArray(5)
                    }

                PlayerID = Vars.CurrentPlayerInfo.CurrentPlayerID

                ' Checks if a player is 1 correct question away from $1M
                If Players(PlayerID).Money = 2 ^ 19 Then
                    SwitchForm(frm:=FrmMillion)
                    lblChallenge.Text = $"{Players(PlayerID).Name}, do you want to risk losing all your earnings to have a chance at winning $1048576 ?"

                    ' The subroutine waits until the MillionEvent is triggered
                    Await Task.Run(
                        Sub()
                            MillionEvent.WaitOne()
                        End Sub)

                    ' Changes the player if they decline the challenge
                    If AcceptMillion = False Then
                        Vars.CurrentPlayerInfo.ChangeCurrentPlayer()
                    End If
                    MillionEvent.Reset() ' Resets the event so that it can get triggered again
                    SwitchForm(frm:=FrmGame) ' Switches back to the game form
                    PlayerID = Vars.CurrentPlayerInfo.CurrentPlayerID
                End If

                ' Updates the visual information of the game; e.g in "FrmGame"
                PopulateButtons(btns:=Me.Buttons, info:=Vars.CurrentQuestionInfo.OptionsAnswersArray)
                PopulateLabels(lbls:=Me.Labels, vars:=Vars)

                ' This code block determines if a player can pass or not, and displays an appropriate message
                If (Players(PlayerID).Passes = 0) Then
                    btnPass.Text = $"{Players(PlayerID).Name} has no more passes!"
                    btnPass.Enabled = False
                Else
                    If AcceptMillion Then
                        btnPass.Text = $"{Players(PlayerID).Name} cannot pass!"
                        btnPass.Enabled = False
                    Else
                        btnPass.Text = $"Passes: {Players(PlayerID).Passes} left"
                        btnPass.Enabled = True
                    End If
                End If

                ' This time, the function waits for a player to select an option guess the answer
                Await Task.Run(
                    Sub()
                        PlayerResponse.WaitOne()
                    End Sub)

                ' This code block determines if a player was correct, incorrect or passed
                If Response = Vars.CurrentQuestionInfo.CorrectAnswer Then ' Correct
                    ' Updates the "Money" and questions answered ("Qansd") properties of a player (PlayerClass instance)
                    Players(PlayerID).Money = 2 ^ (Players(PlayerID).Qansd)
                    Players(PlayerID).Qansd += 1
                    lblReponse.Text = $"{Players(PlayerID).Name} is correct!"

                ElseIf Response.StartsWith("Pass") Then ' Passes
                    ' Decrements "Passes" property of a player (PlayerClass instance) and "QuestionNo" by 1
                    ' "QuestionNo" is decremented so that the same question displays when "QuestionNo" increments in the loop
                    Players(PlayerID).Passes -= 1
                    lblReponse.Text = $"{Players(PlayerID).Name} passes with {Players(PlayerID).Passes}/5 passes left."
                    QuestionNo -= 1

                Else 'Incorrect
                    lblReponse.Text = $"{Players(PlayerID).Name} is wrong!"
                    ' Unfortunately the player loses all their earnings here :(
                    If AcceptMillion Then
                        Players(PlayerID).Money = 0
                        AcceptMillion = False
                        SwitchForm(nextForm)
                    End If
                End If

                Vars.CurrentPlayerInfo.ChangeCurrentPlayer() ' Changes the player every question
                PlayerResponse.Reset() ' Resets the option event for the next player response
            Next
        Next
        PlayMusic(Update:=True) ' Plays podium music
        SwitchForm(nextForm) ' Switches to the next form once the game is over
    End Sub
End Class
