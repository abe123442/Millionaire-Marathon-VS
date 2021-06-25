<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main_menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_display = New System.Windows.Forms.Label()
        Me.btn_play = New System.Windows.Forms.Button()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_display
        '
        Me.lbl_display.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_display.Font = New System.Drawing.Font("Lucida Console", 48.0!)
        Me.lbl_display.Location = New System.Drawing.Point(0, 13)
        Me.lbl_display.Name = "lbl_display"
        Me.lbl_display.Size = New System.Drawing.Size(1008, 67)
        Me.lbl_display.TabIndex = 0
        Me.lbl_display.Text = "MILLIONAIRE MARATHON"
        Me.lbl_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_play
        '
        Me.btn_play.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_play.Location = New System.Drawing.Point(408, 230)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(213, 70)
        Me.btn_play.TabIndex = 5
        Me.btn_play.Text = "Play"
        Me.btn_play.UseVisualStyleBackColor = True
        '
        'btn_help
        '
        Me.btn_help.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_help.Location = New System.Drawing.Point(408, 339)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(213, 70)
        Me.btn_help.TabIndex = 5
        Me.btn_help.Text = "Help"
        Me.btn_help.UseVisualStyleBackColor = True
        '
        'frm_main_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 537)
        Me.Controls.Add(Me.btn_help)
        Me.Controls.Add(Me.btn_play)
        Me.Controls.Add(Me.lbl_display)
        Me.Name = "frm_main_menu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_display As Label
    Friend WithEvents btn_play As Button
    Friend WithEvents btn_help As Button
End Class
