Public Class FrmGame
    Dim gameOver = False
    Dim playerNames = FrmSetup.playerNames

    Dim currentPlayer = 1
    Dim currentPlayerStr = playerNames(String.Format("Player {0}", currentPlayer))


    ReadOnly filePath = "Questions.csv"
    Dim questionBank = GetQuestions(filePath)
    Dim currentQuestionInfo = UpdateQuestions()

    Dim currentRound = 1
    ReadOnly noQuestions = 82
    Dim currentQuestion = 0

    'Variable Declarations

    Dim players As New Hashtable From {
            {playerNames("Player 1"), New Player With {.Money = 0, .Qansd = 0, .Streak = 0}},
            {playerNames("Player 2"), New Player With {.Money = 0, .Qansd = 0, .Streak = 0}},
            {playerNames("Player 3"), New Player With {.Money = 0, .Qansd = 0, .Streak = 0}},
            {playerNames("Player 4"), New Player With {.Money = 0, .Qansd = 0, .Streak = 0}}
        }

    Private Sub FrmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FeedButtons(currentQuestionInfo)
    End Sub

    Private Sub MainGame(userInput As String, correctAnswer As String)
        If userInput = correctAnswer Then
            ' the money of the current player
            players(currentPlayerStr).Money = 2 ^ (players(currentPlayerStr).Qansd)
            ' the number of questions the currentt player has correctly answered
            players(currentPlayerStr).Qansd += 1
            players(currentPlayerStr).Streak += 1

            lblFeedback.Text = String.Format("{0} is correct!", currentPlayerStr)
            'MsgBox(String.Format("Player {0} is correct!", currentPlayer))

            'Checks if the current player is on a 5 answer streak
            Call CheckPlayerStreak()
        Else
            If userInput = "pass" Then
                lblFeedback.Text = currentPlayerStr & " passes the question and exits the hotseat!"
            Else
                lblFeedback.Text = currentPlayerStr & " is incorrect and exits the hotseat!"
            End If
            Call ChangePlayer()
            lblFeedback.Text = currentPlayerStr & " enters the hotseat"
        End If
        currentQuestion += 1
        currentQuestionInfo = UpdateQuestions()
        Call FeedButtons(currentQuestionInfo)
    End Sub

    Private Sub BtnOption1_Click(sender As Object, e As EventArgs) Handles btnOption1.Click
        Call MainGame(btnOption1.Text, currentQuestionInfo(5))
    End Sub

    Private Sub BtnOption2_Click(sender As Object, e As EventArgs) Handles btnOption2.Click
        Call MainGame(btnOption2.Text, currentQuestionInfo(5))
    End Sub

    Private Sub BtnOption3_Click(sender As Object, e As EventArgs) Handles btnOption3.Click
        Call MainGame(btnOption3.Text, currentQuestionInfo(5))
    End Sub

    Private Sub BtnOption4_Click(sender As Object, e As EventArgs) Handles btnOption4.Click
        Call MainGame(btnOption4.Text, currentQuestionInfo(5))
    End Sub

    Function GetQuestions(path As String) As ArrayList
        Dim questions As ArrayList = New ArrayList()
        Using MyReader As New FileIO.TextFieldParser(path)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            While Not MyReader.EndOfData
                questions.Add(MyReader.ReadFields())
            End While
        End Using
        Return questions
    End Function

    Sub FeedButtons(info As Array)
        lblRound.Text = "Round: " & currentRound
        lblCurrentPlayer.Text = "Current Player: " & playerNames(String.Format("Player {0}", currentPlayer))
        lblQuestion.Text = String.Format("Question {0}: {1}", (currentQuestion + 1), info(0))

        btnOption1.Text = info(1)
        btnOption2.Text = info(2)
        btnOption3.Text = info(3)
        btnOption4.Text = info(4)
    End Sub

    Function UpdateQuestions()
        Dim options As ArrayList = New ArrayList()
        For j = 1 To 4
            options.Add(questionBank(currentQuestion)(j))
        Next

        Call ShuffleArray(options)
        options.Add(questionBank(currentQuestion)(5))

        For j = 1 To 4
            questionBank(currentQuestion)(j) = options(j - 1)
        Next

        Return questionBank(currentQuestion)
    End Function

    Sub ShuffleArray(arr As ArrayList)
        Dim last_index = arr.Count - 1
        While last_index > 0
            Randomize()
            Dim rand_index = New Random().Next(0, arr.Count)
            Dim temp = arr(last_index)
            arr(last_index) = arr(rand_index)
            arr(rand_index) = temp
            last_index -= 1
        End While
    End Sub

    Function CheckNewRound(qNo)
        Return (qNo Mod 20 = 0) And (qNo <> 0)
    End Function


    Sub ChangePlayer()
        If currentPlayer = 4 Then
            currentPlayer = 1
        Else
            currentPlayer += 1
            currentPlayerStr = playerNames(String.Format("Player {0}", currentPlayer))
        End If
    End Sub

    Sub CheckPlayerStreak()
        If players(currentPlayerStr).Streak = 5 Then
            lblFeedback.Text = currentPlayerStr & " exits the hotseat!"
            Call ChangePlayer()
            lblFeedback.Text = currentPlayerStr & " enters the hotseat!"
            players(currentPlayerStr).Streak = 0
        End If
    End Sub

End Class

Public Class Player
    Property Money As Integer
    Property Qansd As Integer
    Property Streak As Integer
End Class