Public Class FrmGame
    ReadOnly filePath As String = "Questions.csv"
    ReadOnly questionBank As ArrayList = GetQuestions(filePath)
    Dim currentQuestionInfo As Array

    Dim currentRound As Integer = 1
    Dim currentQuestion As Integer = 70

    ReadOnly PlayerNames As Hashtable = FrmSetup.playerNames

    Dim Players As New Hashtable From {
        {PlayerNames("Player 1"), New Player},
        {PlayerNames("Player 2"), New Player},
        {PlayerNames("Player 3"), New Player},
        {PlayerNames("Player 4"), New Player}
    }

    Dim currentPlayerInt = 1
    Dim currentPlayerStr = PlayerNames("Player " + currentPlayerInt)

    Private Sub FrmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call UpdateQuestions()
        Call FeedInformation(currentQuestionInfo)
    End Sub

    Private Sub BtnOptions_Click(sender As Object, e As EventArgs) _
        Handles btnOption1.Click, btnOption2.Click, btnOption3.Click, btnOption4.Click

        Dim btnOption As Button = sender
        Call MainGame(btnOption.Text)
    End Sub

    Private Sub MainGame(userInput As String)
        Dim correctAnswer As String = currentQuestionInfo(5)

        If currentQuestion > 80 Then
            Return
        End If

        Select Case userInput
            Case correctAnswer
                Players(currentPlayerStr).Money = 2 ^ (Players(currentPlayerStr).Qansd)
                Players(currentPlayerStr).Qansd += 1
                lblReponse.Text = currentPlayerStr & " is correct!"
            Case "pass"
                lblReponse.Text = currentPlayerStr & " passes!"
            Case Else
                lblReponse.Text = currentPlayerStr & " is wrong!"
        End Select

        currentQuestion += 1
        'lblMoney.Text = "Money: $" & Players(currentPlayerStr).Money
        If currentQuestion <> 81 Then
            Call ChangePlayer()
            Call UpdateQuestions()
            Call FeedInformation(currentQuestionInfo)
        End If
    End Sub


    Sub FeedInformation(info As Array)
        If CheckNewRound() Then
            currentRound += 1
        End If
        lblRound.Text = "Round: " & currentRound
        lblCurrentPlayer.Text = "Current Player: " & currentPlayerStr
        lblMoney.Text = "Money: $" & Players(currentPlayerStr).Money
        lblQuestion.Text = String.Format("Question {0}: {1}", (currentQuestion + 1), info(0))

        btnOption1.Text = info(1)
        btnOption2.Text = info(2)
        btnOption3.Text = info(3)
        btnOption4.Text = info(4)
    End Sub

    Function ChangePlayerAndText()
        Call ChangePlayer()
        Dim message As String = currentPlayerStr & " enters the hotseat!"
        Return message
    End Function

    Sub ChangePlayer()
        If currentPlayerInt = 4 Then
            currentPlayerInt = 1
        Else
            currentPlayerInt += 1
        End If
        currentPlayerStr = PlayerNames("Player " + currentPlayerInt)
    End Sub

    Function CheckNewRound() As Boolean
        Return (currentQuestion Mod 20 = 0) And (currentQuestion <> 0)
    End Function


    Sub UpdateQuestions()
        If currentQuestion < 81 Then
            Dim options As ArrayList = New ArrayList()
            For j = 1 To 4
                options.Add(questionBank(currentQuestion)(j))
            Next

            Call ShuffleArray(options)
            options.Add(questionBank(currentQuestion)(5))

            For j = 1 To 4
                questionBank(currentQuestion)(j) = options(j - 1)
            Next

            currentQuestionInfo = questionBank(currentQuestion)
        End If
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
        Call ShuffleArray(questions)
        Return questions
    End Function

    Sub ShuffleArray(arr As ArrayList)
        Dim lastIndex As Integer = arr.Count - 1
        Dim randIndex As Integer
        Dim randGen As Random = New Random

        While lastIndex > 0
            randIndex = randGen.Next(0, arr.Count)
            Dim temp = arr(lastIndex)
            arr(lastIndex) = arr(randIndex)
            arr(randIndex) = temp
            lastIndex -= 1
        End While
    End Sub
End Class
