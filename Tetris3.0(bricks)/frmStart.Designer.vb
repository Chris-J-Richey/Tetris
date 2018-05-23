<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Start = New System.Windows.Forms.Label()
        Me.leveldown = New System.Windows.Forms.Label()
        Me.levelup = New System.Windows.Forms.Label()
        Me.level = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.Transparent
        Me.Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Start.Location = New System.Drawing.Point(163, 209)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(102, 71)
        Me.Start.TabIndex = 7
        Me.Start.Text = "Start"
        Me.Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'leveldown
        '
        Me.leveldown.BackColor = System.Drawing.Color.Transparent
        Me.leveldown.Enabled = False
        Me.leveldown.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leveldown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.leveldown.Location = New System.Drawing.Point(161, 169)
        Me.leveldown.Name = "leveldown"
        Me.leveldown.Size = New System.Drawing.Size(39, 40)
        Me.leveldown.TabIndex = 6
        Me.leveldown.Text = "<"
        Me.leveldown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'levelup
        '
        Me.levelup.BackColor = System.Drawing.Color.Transparent
        Me.levelup.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.levelup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.levelup.Location = New System.Drawing.Point(233, 169)
        Me.levelup.Name = "levelup"
        Me.levelup.Size = New System.Drawing.Size(39, 40)
        Me.levelup.TabIndex = 5
        Me.levelup.Text = ">"
        Me.levelup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'level
        '
        Me.level.BackColor = System.Drawing.Color.Transparent
        Me.level.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.level.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.level.Location = New System.Drawing.Point(161, 169)
        Me.level.Name = "level"
        Me.level.Size = New System.Drawing.Size(106, 40)
        Me.level.TabIndex = 4
        Me.level.Text = "1"
        Me.level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(346, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "copyright tetris"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(273, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 40)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tetris3._0_bricks_.My.Resources.Resources.tetris_screen
        Me.ClientSize = New System.Drawing.Size(433, 320)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.leveldown)
        Me.Controls.Add(Me.levelup)
        Me.Controls.Add(Me.level)
        Me.Name = "frmStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Start As System.Windows.Forms.Label
    Friend WithEvents leveldown As System.Windows.Forms.Label
    Friend WithEvents levelup As System.Windows.Forms.Label
    Friend WithEvents level As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
