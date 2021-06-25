<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_play = New System.Windows.Forms.Button()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Millionaire Marathon"
        '
        'btn_play
        '
        Me.btn_play.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_play.Location = New System.Drawing.Point(298, 201)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(202, 85)
        Me.btn_play.TabIndex = 1
        Me.btn_play.Text = "Play"
        Me.btn_play.UseVisualStyleBackColor = True
        '
        'btn_help
        '
        Me.btn_help.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_help.Location = New System.Drawing.Point(298, 326)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(202, 85)
        Me.btn_help.TabIndex = 1
        Me.btn_help.Text = "Help"
        Me.btn_help.UseVisualStyleBackColor = True
        '
        'pnl
        '
        Me.pnl.Location = New System.Drawing.Point(-8, -18)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(816, 477)
        Me.pnl.TabIndex = 2
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_help)
        Me.Controls.Add(Me.btn_play)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnl)
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.Name = "FrmMenu"
        Me.Text = "Main_Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_play As Button
    Friend WithEvents btn_help As Button
    Friend WithEvents pnl As Panel
End Class
