Public Class FrmSetup
    Private Sub FrmSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True) ' Allows transparent background
        BackColor = Color.FromArgb(0, Color.Black) ' Sets a transparent background
        CustomiseButtons(GetControls(Of Button)(Me), Color.AntiqueWhite) ' Gets a list of buttons and designs each button
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Creates a hashtable of 4 players, each player is a "PlayerClass" instance
        Players = New Hashtable From {
        {"Player 1", New PlayerClass(txtPlayer1.Text)},
        {"Player 2", New PlayerClass(txtPlayer2.Text)},
        {"Player 3", New PlayerClass(txtPlayer3.Text)},
        {"Player 4", New PlayerClass(txtPlayer4.Text)}
        }

        PlayMusic(Update:=True)
        PanelSwitchForm(FrmGame) ' Switches to the "FrmGame" Form
    End Sub

    ' These two subroutines below just add functionality for the players to change their names
    Private Sub PlayerNameHover(sender As Object, e As EventArgs) _
        Handles txtPlayer1.MouseEnter, txtPlayer2.MouseEnter, txtPlayer3.MouseEnter, txtPlayer4.MouseEnter
        If sender.Text.StartsWith("Player") Then
            sender.Text = ""
            sender.ForeColor = Color.Black
        End If
    End Sub

    Private Sub PlayerNameUnhover(sender As Object, e As EventArgs) _
        Handles txtPlayer1.MouseLeave, txtPlayer2.MouseLeave, txtPlayer3.MouseLeave, txtPlayer4.MouseLeave
        If sender.Text = "" Then
            sender.Text = sender.Name.Substring(3) ' Takes the text starting (and including) index 3 of sender's name
        End If
    End Sub
End Class