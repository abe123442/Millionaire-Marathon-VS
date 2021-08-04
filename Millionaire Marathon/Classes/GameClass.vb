Class GameClass
    ' The main game class that is instantiated to run the game in "FrmGame"
    Property Buttons As List(Of Button)
    Property Labels As List(Of Label)
    Property ResponseEvent As Threading.ManualResetEvent
    Property NextEvent As Threading.ManualResetEvent
    Property MillionEvent As Threading.ManualResetEvent
    Property Players As Hashtable
    Property Rounds As List(Of ArrayList) ' Contains 4 rounds, each round containing 20/21 questions

    ' Class constructor - used for initialising a class instance
    Sub New(
           response_event As Threading.ManualResetEvent,
           nextevent As Threading.ManualResetEvent,
           millionevent As Threading.ManualResetEvent,
           players As Hashtable,
           rounds As List(Of ArrayList),
           buttons As List(Of Button),
           labels As List(Of Label))
        Me.ResponseEvent = response_event
        Me.NextEvent = nextevent
        Me.MillionEvent = millionevent
        Me.Players = players
        Me.Rounds = rounds
        Me.Buttons = buttons
        Me.Labels = labels
    End Sub

    Private Enum DataAttr
        Question
        Option1
        Option2
        Option3
        Option4
        CorrectAns
    End Enum

    Private GameVars As New GameVariablesClass With {
            .CurrentPlayerInfo = New GameVariablesClass.CurrentPlayerInfoClass
        }


    ' The main game function of this class
    ' (Note: this function is asynchronuous and is only run once for every game played)
    Async Sub MainGame(nextForm As Form)
        ' Getting the labels which will be updated by game logic
        Dim lblMoney As Label = GetControlByName(Me.Labels, "lblMoney")
        Dim lblReponse As Label = GetControlByName(Me.Labels, "lblReponse")
        Dim lblChallenge As Label = GetControlByName(Me.Labels, "lblChallenge")
        Dim btnPass As Button = GetControlByName(Me.Buttons, "btnPass")
        Dim btnNext As Button = GetControlByName(Me.Buttons, "btnNext")

        Dim PlayerID As String

        For Each Round In Rounds ' Iterates over the 4 rounds of the game that each contain upto 21 questions

            GameVars.CurrentRound = Rounds.IndexOf(Round) + 1 ' Assignment to "CurrentRound" in "GameVars"
            For QuestionNo = 0 To Round.Count - 1

                GameVars.CurrentQuestionInfo = GetCurrentQuestionInfo(Round, QuestionNo)
                PlayerID = GameVars.CurrentPlayerInfo.CurrentPlayerID ' Assigns to "CurrentPlayerID" in the subclass "CurrentPlayerInfo" 

                CheckMillion(PlayerID, lblChallenge) ' Executes only if a player is 1 correct question away from $1M

                ' Updates the visual information of the game; e.g in "FrmGame"
                PopulateButtons(Me.Buttons, GameVars.CurrentQuestionInfo.OptionsAnswersArray)
                PopulateLabels(Me.Labels, GameVars)

                ' Checks if a player can pass or not, and displays an appropriate message
                DisplayPassCheck(PlayerID, btnPass)

                ' Waits for a player to select an option guess the answer
                Await Task.Run(
                    Sub()
                        ResponseEvent.WaitOne()
                    End Sub)

                ' This code block determines if a player was correct, incorrect or passed
                DisplayEvaluation(Response, lblReponse, btnPass, btnNext, nextForm)

                btnNext.Enabled = True
                btnNext.Text = "Next"
                lblMoney.Text = $"Money: ${(Players(GameVars.CurrentPlayerInfo.CurrentPlayerID).Money)}"

                Await Task.Run(
                    Sub()
                        NextEvent.WaitOne()
                    End Sub)


                GameVars.CurrentPlayerInfo.ChangeCurrentPlayer() ' Changes the player every question

                ' Resets the events so that it can be triggered again
                NextEvent.Reset()
                ResponseEvent.Reset()
            Next
        Next
        PlayMusic(Update:=True) ' Plays podium music
        PanelSwitchForm(nextForm) ' Switches to the next form once the game is over
    End Sub

    Private Async Sub CheckMillion(PlayerID As String, lblChallenge As Label)
        ' Executes only if a player is 1 correct question away from $1M
        If Players(PlayerID).Money = 2 ^ 19 Then
            PanelSwitchForm(FrmMillion) ' Switches to the challenge offer form
            lblChallenge.Text = $"{Players(PlayerID).Name}, do you want to risk losing all your earnings to have a chance at winning $1048576 ?"

            ' Async functions can wait for certain tasks to be completed before running any more code
            ' Here, it waits for the player to give their input on whether they want to play for $1M or not
            Await Task.Run(
                Sub()
                    MillionEvent.WaitOne()
                End Sub)
            ' Changing the player if they decline the challenge offer
            If AcceptMillion = False Then
                GameVars.CurrentPlayerInfo.ChangeCurrentPlayer()
            End If
            PanelSwitchForm(FrmGame) ' Switches back to the game form
            MillionEvent.Reset() ' Resets the event so that it can get triggered again
        End If
    End Sub

    Private Function GetCurrentQuestionInfo(Round As ArrayList, QuestionNo As Integer) _
        As GameVariablesClass.CurrentQuestionInfoClass
        Return New GameVariablesClass.CurrentQuestionInfoClass With {
            .CurrentQuestionNo = QuestionNo,
            .CurrentQuestion = Round(QuestionNo)(DataAttr.Question),
            .OptionsAnswersArray = RandomiseOptions(Round(.CurrentQuestionNo)),
            .CorrectAnswer = .OptionsAnswersArray(DataAttr.CorrectAns)
        }
    End Function

    Private Enum Evaluation
        Incorrect
        Correct
        Pass
    End Enum

    Private Sub DisplayEvaluation(response As String, lblReponse As Label, btnPass As Button, btnNext As Button, nextForm As Form)
        Dim PlayerID As String = GameVars.CurrentPlayerInfo.CurrentPlayerID
        Select Case EvaluateResponse(response)
            Case Evaluation.Correct
                ' Updates the "Money" and questions answered ("Qansd") properties of a player (PlayerClass instance)
                Players(PlayerID).Money = 2 ^ (Players(PlayerID).Qansd)
                Players(PlayerID).Qansd += 1
                lblReponse.Text = $"{Players(PlayerID).Name} is correct!"
            Case Evaluation.Pass
                ' Decrements "Passes" property of a player (PlayerClass instance) and "Question" by 1
                ' "Question" is decremented so that the same question displays when "Question" increments in the loop
                Players(PlayerID).Passes -= 1
                btnPass.Text = $"Passes: {Players(PlayerID).Passes} left"
                lblReponse.Text = $"{Players(PlayerID).Name} passes with {Players(PlayerID).Passes}/5 passes left."
                GameVars.CurrentQuestionInfo.CurrentQuestionNo -= 1
            Case Evaluation.Incorrect
                lblReponse.Text = $"{Players(PlayerID).Name} is wrong!"
                ' Unfortunately the player loses all their earnings here :(
                If AcceptMillion Then
                    Players(PlayerID).Money = 0
                    AcceptMillion = False
                    PanelSwitchForm(nextForm)
                End If
        End Select
        btnNext.Show()
    End Sub
    Private Function EvaluateResponse(response As String)
        Dim PlayerID As String = GameVars.CurrentPlayerInfo.CurrentPlayerID
        If response = GameVars.CurrentQuestionInfo.CorrectAnswer Then ' If the player is correct
            Return Evaluation.Correct

        ElseIf response.StartsWith("Pass") Then ' If the player passes
            Return Evaluation.Pass

        Else
            Return Evaluation.Incorrect
        End If
    End Function

    Private Sub DisplayPassCheck(PlayerID As String, btnPass As Button)
        ' This code block determines if a player can pass or not, and displays an appropriate message
        If CanPass(PlayerID) = False Then
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
    End Sub

    Private Function CanPass(PlayerID As String)
        ' This code block determines if a player can pass or not, and displays an appropriate message
        If (Players(PlayerID).Passes = 0) Then
            Return False
        Else
            Return True
        End If
    End Function

End Class
