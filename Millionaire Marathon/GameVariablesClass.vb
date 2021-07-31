Public Class GameVariablesClass
    ' A class that is used to store game information that constantly updates
    Property CurrentRound As Integer
    Property CurrentPlayerInfo As CurrentPlayerInfoClass
    Property CurrentQuestionInfo As CurrentQuestionInfoClass

    Public Class CurrentPlayerInfoClass
        ' A subclass that contains all the "current" player information
        Public Property CurrentPlayerNo As Integer = 1
        Public Property CurrentPlayerID As String = "Player 1"

        Public Sub ChangeCurrentPlayer()
            ' A subroutine that change the player no.
            If CurrentPlayerNo = 4 Then
                CurrentPlayerNo = 1
            Else
                CurrentPlayerNo += 1
            End If
            CurrentPlayerID = $"Player {CurrentPlayerNo}"
        End Sub
    End Class

    Public Class CurrentQuestionInfoClass
        ' A subclass that contains all the "current" question information
        Public Property OptionsAnswersArray As Array
        Public Property CurrentQuestion As String
        Public Property CurrentQuestionNo As Integer
        Public Property CorrectAnswer As String
    End Class
End Class