<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageEngine
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
        Me.Line1 = New System.Windows.Forms.Label()
        Me.Line2 = New System.Windows.Forms.Label()
        Me.Line3 = New System.Windows.Forms.Label()
        Me.LineList = New System.Windows.Forms.ListBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Line1
        '
        Me.Line1.AutoSize = True
        Me.Line1.BackColor = System.Drawing.Color.Black
        Me.Line1.Font = New System.Drawing.Font("MicrogrammaDMedExt", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Line1.ForeColor = System.Drawing.Color.White
        Me.Line1.Location = New System.Drawing.Point(14, 204)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(11, 16)
        Me.Line1.TabIndex = 1
        Me.Line1.Text = " "
        '
        'Line2
        '
        Me.Line2.AutoSize = True
        Me.Line2.BackColor = System.Drawing.Color.Black
        Me.Line2.Font = New System.Drawing.Font("MicrogrammaDMedExt", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Line2.ForeColor = System.Drawing.Color.White
        Me.Line2.Location = New System.Drawing.Point(14, 231)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(11, 16)
        Me.Line2.TabIndex = 2
        Me.Line2.Text = " "
        '
        'Line3
        '
        Me.Line3.AutoSize = True
        Me.Line3.BackColor = System.Drawing.Color.Black
        Me.Line3.Font = New System.Drawing.Font("MicrogrammaDMedExt", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Line3.ForeColor = System.Drawing.Color.White
        Me.Line3.Location = New System.Drawing.Point(14, 258)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(11, 16)
        Me.Line3.TabIndex = 3
        Me.Line3.Text = " "
        '
        'LineList
        '
        Me.LineList.FormattingEnabled = True
        Me.LineList.Location = New System.Drawing.Point(12, 12)
        Me.LineList.Name = "LineList"
        Me.LineList.Size = New System.Drawing.Size(120, 95)
        Me.LineList.TabIndex = 4
        Me.LineList.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(302, 167)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ContDisplay.My.Resources.Resources.Message
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 191)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(354, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 141
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(252, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "1: Next"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ContDisplay.My.Resources.Resources.MessagePrompt
        Me.PictureBox3.Location = New System.Drawing.Point(231, 159)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(113, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 143
        Me.PictureBox3.TabStop = False
        '
        'MessageEngine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(350, 284)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LineList)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MessageEngine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MessageEngine"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Purple
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Line1 As Label
    Friend WithEvents Line2 As Label
    Friend WithEvents Line3 As Label
    Friend WithEvents LineList As ListBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
