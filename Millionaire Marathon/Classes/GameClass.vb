Class GameClass
    ' The main game class that is instantiated to run the game in "FrmGame"
    Property Buttons As List(Of Button)
    Property Labels As List(Of Label)
    Property ButtonClick As Threading.ManualResetEvent
    Property MillionEvent As Threading.ManualResetEvent
    Property Players As Hashtable
    Property Rounds As List(Of ArrayList) ' Contains 4 rounds, each round containing 20/21 questions

    ' Class constructor - used for initialising a class instance
    Sub New(
           buttonclick As Threading.ManualResetEvent,
           millionevent As Threading.ManualResetEvent,
           players As Hashtable,
           rounds As List(Of ArrayList),
           buttons As List(Of Button),
           labels As List(Of Label))
        Me.ButtonClick = buttonclick
        Me.MillionEvent = millionevent
        Me.Players = players
        Me.Rounds = rounds
        Me.Buttons = buttons
        Me.Labels = labels
    End Sub

    ' The main game function of this class
    ' (Note: this function is asynchronuous and is only run once for every game played)
    Async Sub MainGame(nextForm As Form)
        ' Getting the labels which will be updated by game logic
        Dim lblReponse As Label = GetControlByName(ctrls:=Me.Labels, name:="lblReponse")
        Dim btnPass As Button = GetControlByName(ctrls:=Me.Buttons, name:="btnPass")
        Dim lblChallenge As Label = GetControlByName(ctrls:=Me.Labels, name:="lblChallenge")

        ' Creates an instance of "GameVariablesClass" and sets a property as an instance of subclass "CurrentPlayerInfoClass"
        Dim Vars As New GameVariablesClass With {
            .CurrentPlayerInfo = New GameVariablesClass.CurrentPlayerInfoClass
        }
        Dim PlayerID As String
        ' Iterates over each of the 4 rounds of the game (each round will contain upto 21 questions)
        For Each Round In Rounds
            ' Assigns "CurrentRound" property of Class instance "Vars"
            Vars.CurrentRound = Rounds.IndexOf(Round) + 1
            For Question = 0 To Round.Count - 1
                ' Updates the "CurrentQuestionInfo" property of "Vars" every iteration of "Question"
                Vars.CurrentQuestionInfo = New GameVariablesClass.CurrentQuestionInfoClass With {
                    .CurrentQuestionNo = Question,
                    .CurrentQuestion = Round(Question)(0),
                    .OptionsAnswersArray = RandomiseOptions(Round(.CurrentQuestionNo)),
                    .CorrectAnswer = .OptionsAnswersArray(5)
                    }
                ' Assigns the value of property "CurrentPlayerID" in the subclass "CurrentPlayerInfo" 
                PlayerID = Vars.CurrentPlayerInfo.CurrentPlayerID

                ' Executes only if a player is 1 correct question away from $1M
                If Players(PlayerID).Money = 2 ^ 19 Then
                    SwitchPanel(frm:=FrmMillion) ' Switches to the challenge offer form
                    lblChallenge.Text = $"{Players(PlayerID).Name}, do you want to risk losing all your earnings to have a chance at winning $1048576 ?"

                    ' Async functions can wait for certain tasks to be completed before running any more code
                    ' Here, it waits for the player to give their input on whether they want to play for $1M or not
                    Await Task.Run(
                        Sub()
                            MillionEvent.WaitOne()
                        End Sub)
                    ' Changing the player if they decline the challenge offer
                    If AcceptMillion = False Then
                        Vars.CurrentPlayerInfo.ChangeCurrentPlayer()
                    End If
                    SwitchPanel(frm:=FrmGame) ' Switches back to the game form
                    MillionEvent.Reset() ' Resets the event so that it can get triggered again
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
                        ButtonClick.WaitOne()
                    End Sub)

                ' This code block determines if a player was correct, incorrect or passed
                If Response = Vars.CurrentQuestionInfo.CorrectAnswer Then ' If the player is correct
                    ' Updates the "Money" and questions answered ("Qansd") properties of a player (PlayerClass instance)
                    Players(PlayerID).Money = 2 ^ (Players(PlayerID).Qansd)
                    Players(PlayerID).Qansd += 1
                    lblReponse.Text = $"{Players(PlayerID).Name} is correct!"

                ElseIf Response.StartsWith("Pass") Then
                    ' Decrements "Passes" property of a player (PlayerClass instance) and "Question" by 1
                    ' "Question" is decremented so that the same question displays when "Question" increments in the loop
                    Players(PlayerID).Passes -= 1
                    lblReponse.Text = $"{Players(PlayerID).Name} passes with {Players(PlayerID).Passes}/5 passes left."
                    Question -= 1

                Else
                    lblReponse.Text = $"{Players(PlayerID).Name} is wrong!"
                    ' Unfortunately the player loses all their earnings here :(
                    If AcceptMillion Then
                        Players(PlayerID).Money = 0
                        AcceptMillion = False
                        SwitchPanel(nextForm)
                    End If
                End If

                Vars.CurrentPlayerInfo.ChangeCurrentPlayer() ' Changes the player every question
                ButtonClick.Reset() ' Resets the option event so that it can be triggered again for another player
            Next
        Next
        PlayMusic(Update:=True) ' Plays podium music
        SwitchPanel(nextForm) ' Switches to the next form once the game is over
    End Sub
End Class
