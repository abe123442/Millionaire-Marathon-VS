Public Class FrmSetup
    Private Sub FrmSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True) ' Allows transparent background
        BackColor = Color.FromArgb(0, Color.Black) ' Sets a transparent background
        CustomiseButtons(btns:=GetControls(Of Button)(frm:=Me)) ' Gets a list of buttons and designs each button
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Creates a hashtable of 4 players, each player is a "PlayerClass" instance
        Players = New Hashtable From {
        {"Player 1", New PlayerClass(txtPlayer1.Text)},
        {"Player 2", New PlayerClass(txtPlayer2.Text)},
        {"Player 3", New PlayerClass(txtPlayer3.Text)},
        {"Player 4", New PlayerClass(txtPlayer4.Text)}
        }

        SwitchPanel(FrmGame) ' Switches to the "FrmGame" Form
    End Sub

End Class