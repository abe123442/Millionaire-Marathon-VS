Module CommonModule
    Sub SwitchPanel(panel As Form)
        MainForm.PanelMain.Controls.Clear()
        panel.TopLevel = False
        MainForm.PanelMain.Controls.Add(panel)
        panel.Show()
        MainForm.PanelMain.BringToFront()
    End Sub
End Module
