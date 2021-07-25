Public Class GameVariables
    Property CurrentRound As Integer
    Property CurrentPlayerInfo As CurrentPlayerInfoClass
    Property CurrentQuestionInfo As CurrentQuestionInfoClass

    Public Class CurrentPlayerInfoClass
        Public CurrentPlayerNo As Integer = 1
        Public CurrentPlayerID As String = "Player 1"

        Public Sub ChangeCurrentPlayer()
            If CurrentPlayerNo = 4 Then
                CurrentPlayerNo = 1
            Else
                CurrentPlayerNo += 1
            End If
            CurrentPlayerID = $"Player {CurrentPlayerNo}"
        End Sub
    End Class

    Public Class CurrentQuestionInfoClass
        Public Property OptionsAnswersArray As Array
        Public Property CurrentQuestion As String
        Public Property CurrentQuestionNo As Integer
        Public Property CorrectAnswer As String
    End Class
End Class