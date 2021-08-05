<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHelp))
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblTutorial = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(284, 427)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(202, 46)
        Me.btnHome.TabIndex = 8
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.Location = New System.Drawing.Point(267, 54)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(237, 40)
        Me.lblHeading.TabIndex = 9
        Me.lblHeading.Text = "Help [Tutorial]"
        '
        'lblTutorial
        '
        Me.lblTutorial.Font = New System.Drawing.Font("Montserrat", 10.5!)
        Me.lblTutorial.ForeColor = System.Drawing.Color.White
        Me.lblTutorial.Location = New System.Drawing.Point(41, 125)
        Me.lblTutorial.Name = "lblTutorial"
        Me.lblTutorial.Size = New System.Drawing.Size(688, 272)
        Me.lblTutorial.TabIndex = 10
        Me.lblTutorial.Text = resources.GetString("lblTutorial.Text")
        '
        'FrmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(770, 500)
        Me.Controls.Add(Me.lblTutorial)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmHelp"
        Me.Text = "Help"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblTutorial As Label
End Class
