Public Class FrmMain
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelMain.BackColor = Color.FromArgb(0, Color.Black) ' Enables the panel to have a transparent background
        SwitchForm(frm:=FrmMenu) ' Displays form "FrmMenu"
        PlayMusic(Update:=False) ' Plays the intro music
    End Sub
End Class
