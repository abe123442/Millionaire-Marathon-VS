<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSetup
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
        Me.txtPlayer1 = New System.Windows.Forms.TextBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.txtPlayer2 = New System.Windows.Forms.TextBox()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.txtPlayer3 = New System.Windows.Forms.TextBox()
        Me.lblPlayer3 = New System.Windows.Forms.Label()
        Me.txtPlayer4 = New System.Windows.Forms.TextBox()
        Me.lblPlayer4 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPlayer1
        '
        Me.txtPlayer1.BackColor = System.Drawing.Color.AliceBlue
        Me.txtPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPlayer1.Location = New System.Drawing.Point(12, 214)
        Me.txtPlayer1.MaxLength = 15
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.ShortcutsEnabled = False
        Me.txtPlayer1.Size = New System.Drawing.Size(175, 31)
        Me.txtPlayer1.TabIndex = 0
        Me.txtPlayer1.Text = "Player 1"
        Me.txtPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.Location = New System.Drawing.Point(186, 42)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(403, 40)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Player Naming [Optional]"
        '
        'lblPlayer1
        '
        Me.lblPlayer1.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblPlayer1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPlayer1.Location = New System.Drawing.Point(12, 179)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(175, 32)
        Me.lblPlayer1.TabIndex = 2
        Me.lblPlayer1.Text = "P1"
        Me.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtPlayer2
        '
        Me.txtPlayer2.BackColor = System.Drawing.Color.AliceBlue
        Me.txtPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayer2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPlayer2.Location = New System.Drawing.Point(204, 214)
        Me.txtPlayer2.MaxLength = 15
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.ShortcutsEnabled = False
        Me.txtPlayer2.Size = New System.Drawing.Size(175, 31)
        Me.txtPlayer2.TabIndex = 0
        Me.txtPlayer2.Text = "Player 2"
        Me.txtPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPlayer2
        '
        Me.lblPlayer2.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblPlayer2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPlayer2.Location = New System.Drawing.Point(204, 179)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(175, 32)
        Me.lblPlayer2.TabIndex = 2
        Me.lblPlayer2.Text = "P2"
        Me.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtPlayer3
        '
        Me.txtPlayer3.BackColor = System.Drawing.Color.AliceBlue
        Me.txtPlayer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayer3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPlayer3.Location = New System.Drawing.Point(396, 214)
        Me.txtPlayer3.MaxLength = 15
        Me.txtPlayer3.Name = "txtPlayer3"
        Me.txtPlayer3.ShortcutsEnabled = False
        Me.txtPlayer3.Size = New System.Drawing.Size(175, 31)
        Me.txtPlayer3.TabIndex = 0
        Me.txtPlayer3.Text = "Player 3"
        Me.txtPlayer3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPlayer3
        '
        Me.lblPlayer3.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblPlayer3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPlayer3.Location = New System.Drawing.Point(396, 179)
        Me.lblPlayer3.Name = "lblPlayer3"
        Me.lblPlayer3.Size = New System.Drawing.Size(175, 32)
        Me.lblPlayer3.TabIndex = 2
        Me.lblPlayer3.Text = "P3"
        Me.lblPlayer3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtPlayer4
        '
        Me.txtPlayer4.BackColor = System.Drawing.Color.AliceBlue
        Me.txtPlayer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayer4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPlayer4.Location = New System.Drawing.Point(588, 214)
        Me.txtPlayer4.MaxLength = 15
        Me.txtPlayer4.Name = "txtPlayer4"
        Me.txtPlayer4.ShortcutsEnabled = False
        Me.txtPlayer4.Size = New System.Drawing.Size(175, 31)
        Me.txtPlayer4.TabIndex = 0
        Me.txtPlayer4.Text = "Player 4"
        Me.txtPlayer4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPlayer4
        '
        Me.lblPlayer4.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblPlayer4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPlayer4.Location = New System.Drawing.Point(588, 179)
        Me.lblPlayer4.Name = "lblPlayer4"
        Me.lblPlayer4.Size = New System.Drawing.Size(175, 32)
        Me.lblPlayer4.TabIndex = 2
        Me.lblPlayer4.Text = "P4"
        Me.lblPlayer4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(286, 362)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(202, 85)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'FrmSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 500)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblPlayer4)
        Me.Controls.Add(Me.lblPlayer3)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.txtPlayer4)
        Me.Controls.Add(Me.txtPlayer3)
        Me.Controls.Add(Me.txtPlayer2)
        Me.Controls.Add(Me.txtPlayer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSetup"
        Me.Text = "Setup"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPlayer1 As TextBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblPlayer1 As Label
    Friend WithEvents txtPlayer2 As TextBox
    Friend WithEvents lblPlayer2 As Label
    Friend WithEvents txtPlayer3 As TextBox
    Friend WithEvents lblPlayer3 As Label
    Friend WithEvents txtPlayer4 As TextBox
    Friend WithEvents lblPlayer4 As Label
    Friend WithEvents btnNext As Button
End Class
