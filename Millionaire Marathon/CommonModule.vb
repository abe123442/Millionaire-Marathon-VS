Module CommonModule
    Sub SwitchPanel(frm As Form)
        MainForm.PanelMain.Controls.Clear()
        frm.TopLevel = False
        MainForm.PanelMain.Controls.Add(frm)
        frm.Show()
        MainForm.PanelMain.BringToFront()
    End Sub
End Module
