<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameEngine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameEngine))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DisplayPos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DisplayKey = New System.Windows.Forms.Label()
        Me.InfoBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DisplayHealth = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCursor3 = New System.Windows.Forms.Label()
        Me.lblCursor2 = New System.Windows.Forms.Label()
        Me.lblCursor1 = New System.Windows.Forms.Label()
        Me.lblCursorTitle = New System.Windows.Forms.Label()
        Me.PicCursor = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DisplayID = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DisplayArea = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DisplayLevel = New System.Windows.Forms.Label()
        Me.bgplayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsciiToKeyCharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeleportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportCustomMapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InitialiseMapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplashMapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavingExperimentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayNotification = New System.Windows.Forms.Label()
        Me.btnMute = New System.Windows.Forms.Button()
        Me.btnShop = New System.Windows.Forms.Button()
        Me.X10Y10 = New System.Windows.Forms.PictureBox()
        Me.X10Y9 = New System.Windows.Forms.PictureBox()
        Me.X10Y8 = New System.Windows.Forms.PictureBox()
        Me.X10Y7 = New System.Windows.Forms.PictureBox()
        Me.X10Y5 = New System.Windows.Forms.PictureBox()
        Me.X10Y4 = New System.Windows.Forms.PictureBox()
        Me.X10Y3 = New System.Windows.Forms.PictureBox()
        Me.X10Y2 = New System.Windows.Forms.PictureBox()
        Me.X10Y1 = New System.Windows.Forms.PictureBox()
        Me.X10Y6 = New System.Windows.Forms.PictureBox()
        Me.X9Y10 = New System.Windows.Forms.PictureBox()
        Me.X9Y9 = New System.Windows.Forms.PictureBox()
        Me.X9Y8 = New System.Windows.Forms.PictureBox()
        Me.X9Y7 = New System.Windows.Forms.PictureBox()
        Me.X9Y5 = New System.Windows.Forms.PictureBox()
        Me.X9Y4 = New System.Windows.Forms.PictureBox()
        Me.X9Y3 = New System.Windows.Forms.PictureBox()
        Me.X9Y2 = New System.Windows.Forms.PictureBox()
        Me.X9Y1 = New System.Windows.Forms.PictureBox()
        Me.X9Y6 = New System.Windows.Forms.PictureBox()
        Me.X8Y10 = New System.Windows.Forms.PictureBox()
        Me.X8Y9 = New System.Windows.Forms.PictureBox()
        Me.X8Y8 = New System.Windows.Forms.PictureBox()
        Me.X8Y7 = New System.Windows.Forms.PictureBox()
        Me.X8Y5 = New System.Windows.Forms.PictureBox()
        Me.X8Y4 = New System.Windows.Forms.PictureBox()
        Me.X8Y3 = New System.Windows.Forms.PictureBox()
        Me.X8Y2 = New System.Windows.Forms.PictureBox()
        Me.X8Y1 = New System.Windows.Forms.PictureBox()
        Me.X8Y6 = New System.Windows.Forms.PictureBox()
        Me.X7Y10 = New System.Windows.Forms.PictureBox()
        Me.X7Y9 = New System.Windows.Forms.PictureBox()
        Me.X7Y8 = New System.Windows.Forms.PictureBox()
        Me.X7Y7 = New System.Windows.Forms.PictureBox()
        Me.X7Y5 = New System.Windows.Forms.PictureBox()
        Me.X7Y4 = New System.Windows.Forms.PictureBox()
        Me.X7Y3 = New System.Windows.Forms.PictureBox()
        Me.X7Y2 = New System.Windows.Forms.PictureBox()
        Me.X7Y1 = New System.Windows.Forms.PictureBox()
        Me.X7Y6 = New System.Windows.Forms.PictureBox()
        Me.X6Y10 = New System.Windows.Forms.PictureBox()
        Me.X6Y9 = New System.Windows.Forms.PictureBox()
        Me.X6Y8 = New System.Windows.Forms.PictureBox()
        Me.X6Y7 = New System.Windows.Forms.PictureBox()
        Me.X6Y5 = New System.Windows.Forms.PictureBox()
        Me.X6Y4 = New System.Windows.Forms.PictureBox()
        Me.X6Y3 = New System.Windows.Forms.PictureBox()
        Me.X6Y2 = New System.Windows.Forms.PictureBox()
        Me.X6Y1 = New System.Windows.Forms.PictureBox()
        Me.X6Y6 = New System.Windows.Forms.PictureBox()
        Me.X5Y10 = New System.Windows.Forms.PictureBox()
        Me.X5Y9 = New System.Windows.Forms.PictureBox()
        Me.X5Y8 = New System.Windows.Forms.PictureBox()
        Me.X5Y7 = New System.Windows.Forms.PictureBox()
        Me.X5Y5 = New System.Windows.Forms.PictureBox()
        Me.X5Y4 = New System.Windows.Forms.PictureBox()
        Me.X5Y3 = New System.Windows.Forms.PictureBox()
        Me.X5Y2 = New System.Windows.Forms.PictureBox()
        Me.X5Y1 = New System.Windows.Forms.PictureBox()
        Me.X5Y6 = New System.Windows.Forms.PictureBox()
        Me.X4Y10 = New System.Windows.Forms.PictureBox()
        Me.X4Y9 = New System.Windows.Forms.PictureBox()
        Me.X4Y8 = New System.Windows.Forms.PictureBox()
        Me.X4Y7 = New System.Windows.Forms.PictureBox()
        Me.X4Y6 = New System.Windows.Forms.PictureBox()
        Me.X4Y5 = New System.Windows.Forms.PictureBox()
        Me.X4Y4 = New System.Windows.Forms.PictureBox()
        Me.X4Y3 = New System.Windows.Forms.PictureBox()
        Me.X4Y2 = New System.Windows.Forms.PictureBox()
        Me.X4Y1 = New System.Windows.Forms.PictureBox()
        Me.X3Y10 = New System.Windows.Forms.PictureBox()
        Me.X3Y9 = New System.Windows.Forms.PictureBox()
        Me.X3Y8 = New System.Windows.Forms.PictureBox()
        Me.X3Y7 = New System.Windows.Forms.PictureBox()
        Me.X3Y5 = New System.Windows.Forms.PictureBox()
        Me.X3Y4 = New System.Windows.Forms.PictureBox()
        Me.X3Y3 = New System.Windows.Forms.PictureBox()
        Me.X3Y2 = New System.Windows.Forms.PictureBox()
        Me.X3Y1 = New System.Windows.Forms.PictureBox()
        Me.X3Y6 = New System.Windows.Forms.PictureBox()
        Me.X2Y10 = New System.Windows.Forms.PictureBox()
        Me.X2Y9 = New System.Windows.Forms.PictureBox()
        Me.X2Y8 = New System.Windows.Forms.PictureBox()
        Me.X2Y7 = New System.Windows.Forms.PictureBox()
        Me.X2Y6 = New System.Windows.Forms.PictureBox()
        Me.X2Y5 = New System.Windows.Forms.PictureBox()
        Me.X2Y4 = New System.Windows.Forms.PictureBox()
        Me.X2Y3 = New System.Windows.Forms.PictureBox()
        Me.X2Y2 = New System.Windows.Forms.PictureBox()
        Me.X2Y1 = New System.Windows.Forms.PictureBox()
        Me.X1Y10 = New System.Windows.Forms.PictureBox()
        Me.X1Y9 = New System.Windows.Forms.PictureBox()
        Me.X1Y8 = New System.Windows.Forms.PictureBox()
        Me.X1Y7 = New System.Windows.Forms.PictureBox()
        Me.X1Y6 = New System.Windows.Forms.PictureBox()
        Me.X1Y5 = New System.Windows.Forms.PictureBox()
        Me.X1Y4 = New System.Windows.Forms.PictureBox()
        Me.X1Y3 = New System.Windows.Forms.PictureBox()
        Me.X1Y2 = New System.Windows.Forms.PictureBox()
        Me.X1Y1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.InfoBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.bgplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.X10Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Keystroke:"
        '
        'DisplayPos
        '
        Me.DisplayPos.AutoSize = True
        Me.DisplayPos.Location = New System.Drawing.Point(93, 16)
        Me.DisplayPos.Name = "DisplayPos"
        Me.DisplayPos.Size = New System.Drawing.Size(33, 13)
        Me.DisplayPos.TabIndex = 0
        Me.DisplayPos.Text = "X1Y1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Co-ordinates:"
        '
        'DisplayKey
        '
        Me.DisplayKey.AutoSize = True
        Me.DisplayKey.Location = New System.Drawing.Point(92, 33)
        Me.DisplayKey.Name = "DisplayKey"
        Me.DisplayKey.Size = New System.Drawing.Size(14, 13)
        Me.DisplayKey.TabIndex = 3
        Me.DisplayKey.Text = "S"
        '
        'InfoBox
        '
        Me.InfoBox.BackColor = System.Drawing.Color.Black
        Me.InfoBox.Controls.Add(Me.DisplayKey)
        Me.InfoBox.Controls.Add(Me.Label2)
        Me.InfoBox.Controls.Add(Me.Label1)
        Me.InfoBox.Controls.Add(Me.DisplayPos)
        Me.InfoBox.ForeColor = System.Drawing.Color.White
        Me.InfoBox.Location = New System.Drawing.Point(170, 27)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.Size = New System.Drawing.Size(179, 71)
        Me.InfoBox.TabIndex = 55
        Me.InfoBox.TabStop = False
        Me.InfoBox.Text = "Information"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DisplayHealth)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(4, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 71)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Player"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "None"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Transport"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Health"
        '
        'DisplayHealth
        '
        Me.DisplayHealth.AutoSize = True
        Me.DisplayHealth.Location = New System.Drawing.Point(93, 16)
        Me.DisplayHealth.Name = "DisplayHealth"
        Me.DisplayHealth.Size = New System.Drawing.Size(42, 13)
        Me.DisplayHealth.TabIndex = 0
        Me.DisplayHealth.Text = "10 / 10"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.lblCursor3)
        Me.GroupBox2.Controls.Add(Me.lblCursor2)
        Me.GroupBox2.Controls.Add(Me.lblCursor1)
        Me.GroupBox2.Controls.Add(Me.lblCursorTitle)
        Me.GroupBox2.Controls.Add(Me.PicCursor)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(170, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(179, 73)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cursor"
        '
        'lblCursor3
        '
        Me.lblCursor3.AutoSize = True
        Me.lblCursor3.Font = New System.Drawing.Font("MicrogrammaDMedExt", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursor3.Location = New System.Drawing.Point(70, 56)
        Me.lblCursor3.Name = "lblCursor3"
        Me.lblCursor3.Size = New System.Drawing.Size(39, 13)
        Me.lblCursor3.TabIndex = 141
        Me.lblCursor3.Text = "Line3"
        '
        'lblCursor2
        '
        Me.lblCursor2.AutoSize = True
        Me.lblCursor2.Font = New System.Drawing.Font("MicrogrammaDMedExt", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursor2.Location = New System.Drawing.Point(70, 43)
        Me.lblCursor2.Name = "lblCursor2"
        Me.lblCursor2.Size = New System.Drawing.Size(39, 13)
        Me.lblCursor2.TabIndex = 140
        Me.lblCursor2.Text = "Line2"
        '
        'lblCursor1
        '
        Me.lblCursor1.AutoSize = True
        Me.lblCursor1.Font = New System.Drawing.Font("MicrogrammaDMedExt", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursor1.Location = New System.Drawing.Point(70, 30)
        Me.lblCursor1.Name = "lblCursor1"
        Me.lblCursor1.Size = New System.Drawing.Size(39, 13)
        Me.lblCursor1.TabIndex = 139
        Me.lblCursor1.Text = "Line1"
        '
        'lblCursorTitle
        '
        Me.lblCursorTitle.AutoSize = True
        Me.lblCursorTitle.Font = New System.Drawing.Font("MicrogrammaDEEBolExt", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursorTitle.Location = New System.Drawing.Point(69, 12)
        Me.lblCursorTitle.Name = "lblCursorTitle"
        Me.lblCursorTitle.Size = New System.Drawing.Size(36, 15)
        Me.lblCursorTitle.TabIndex = 138
        Me.lblCursorTitle.Text = "Title"
        '
        'PicCursor
        '
        Me.PicCursor.Location = New System.Drawing.Point(9, 19)
        Me.PicCursor.Name = "PicCursor"
        Me.PicCursor.Size = New System.Drawing.Size(55, 48)
        Me.PicCursor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicCursor.TabIndex = 138
        Me.PicCursor.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Black
        Me.GroupBox3.Controls.Add(Me.DisplayID)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.DisplayArea)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.DisplayLevel)
        Me.GroupBox3.Controls.Add(Me.bgplayer)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(170, 183)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(179, 71)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "World"
        '
        'DisplayID
        '
        Me.DisplayID.AutoSize = True
        Me.DisplayID.Location = New System.Drawing.Point(92, 50)
        Me.DisplayID.Name = "DisplayID"
        Me.DisplayID.Size = New System.Drawing.Size(39, 13)
        Me.DisplayID.TabIndex = 5
        Me.DisplayID.Text = "Splash"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Section #:"
        '
        'DisplayArea
        '
        Me.DisplayArea.AutoSize = True
        Me.DisplayArea.Location = New System.Drawing.Point(92, 33)
        Me.DisplayArea.Name = "DisplayArea"
        Me.DisplayArea.Size = New System.Drawing.Size(39, 13)
        Me.DisplayArea.TabIndex = 3
        Me.DisplayArea.Text = "Splash"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Area:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Level:"
        '
        'DisplayLevel
        '
        Me.DisplayLevel.AutoSize = True
        Me.DisplayLevel.Location = New System.Drawing.Point(93, 16)
        Me.DisplayLevel.Name = "DisplayLevel"
        Me.DisplayLevel.Size = New System.Drawing.Size(13, 13)
        Me.DisplayLevel.TabIndex = 0
        Me.DisplayLevel.Text = "1"
        '
        'bgplayer
        '
        Me.bgplayer.Enabled = True
        Me.bgplayer.Location = New System.Drawing.Point(0, 23)
        Me.bgplayer.Name = "bgplayer"
        Me.bgplayer.OcxState = CType(resources.GetObject("bgplayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.bgplayer.Size = New System.Drawing.Size(75, 23)
        Me.bgplayer.TabIndex = 6
        Me.bgplayer.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(354, 24)
        Me.MenuStrip1.TabIndex = 136
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsciiToKeyCharToolStripMenuItem, Me.TeleportToolStripMenuItem, Me.ImportCustomMapToolStripMenuItem, Me.InitialiseMapToolStripMenuItem, Me.SavingExperimentToolStripMenuItem, Me.ReloadToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'AsciiToKeyCharToolStripMenuItem
        '
        Me.AsciiToKeyCharToolStripMenuItem.Name = "AsciiToKeyCharToolStripMenuItem"
        Me.AsciiToKeyCharToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AsciiToKeyCharToolStripMenuItem.Text = "Ascii to KeyChar"
        '
        'TeleportToolStripMenuItem
        '
        Me.TeleportToolStripMenuItem.Name = "TeleportToolStripMenuItem"
        Me.TeleportToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.TeleportToolStripMenuItem.Text = "Teleport"
        '
        'ImportCustomMapToolStripMenuItem
        '
        Me.ImportCustomMapToolStripMenuItem.Name = "ImportCustomMapToolStripMenuItem"
        Me.ImportCustomMapToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ImportCustomMapToolStripMenuItem.Text = "Import Custom Map"
        '
        'InitialiseMapToolStripMenuItem
        '
        Me.InitialiseMapToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SplashMapToolStripMenuItem})
        Me.InitialiseMapToolStripMenuItem.Name = "InitialiseMapToolStripMenuItem"
        Me.InitialiseMapToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.InitialiseMapToolStripMenuItem.Text = "Initialise Map"
        '
        'SplashMapToolStripMenuItem
        '
        Me.SplashMapToolStripMenuItem.Name = "SplashMapToolStripMenuItem"
        Me.SplashMapToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SplashMapToolStripMenuItem.Text = "SplashMap"
        '
        'SavingExperimentToolStripMenuItem
        '
        Me.SavingExperimentToolStripMenuItem.Name = "SavingExperimentToolStripMenuItem"
        Me.SavingExperimentToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SavingExperimentToolStripMenuItem.Text = "View Save Data"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ReloadToolStripMenuItem.Text = "Reload"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'DisplayNotification
        '
        Me.DisplayNotification.AutoSize = True
        Me.DisplayNotification.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DisplayNotification.Location = New System.Drawing.Point(163, 7)
        Me.DisplayNotification.Name = "DisplayNotification"
        Me.DisplayNotification.Size = New System.Drawing.Size(39, 13)
        Me.DisplayNotification.TabIndex = 138
        Me.DisplayNotification.Text = "Label6"
        Me.DisplayNotification.Visible = False
        '
        'btnMute
        '
        Me.btnMute.Image = Global.ContDisplay.My.Resources.Resources.music_off_button
        Me.btnMute.Location = New System.Drawing.Point(325, 1)
        Me.btnMute.Name = "btnMute"
        Me.btnMute.Size = New System.Drawing.Size(29, 23)
        Me.btnMute.TabIndex = 139
        Me.btnMute.UseVisualStyleBackColor = True
        '
        'btnShop
        '
        Me.btnShop.FlatAppearance.BorderSize = 0
        Me.btnShop.Image = CType(resources.GetObject("btnShop.Image"), System.Drawing.Image)
        Me.btnShop.Location = New System.Drawing.Point(298, 1)
        Me.btnShop.Name = "btnShop"
        Me.btnShop.Size = New System.Drawing.Size(27, 23)
        Me.btnShop.TabIndex = 137
        Me.btnShop.UseVisualStyleBackColor = True
        '
        'X10Y10
        '
        Me.X10Y10.BackColor = System.Drawing.Color.Black
        Me.X10Y10.BackgroundImage = CType(resources.GetObject("X10Y10.BackgroundImage"), System.Drawing.Image)
        Me.X10Y10.Image = CType(resources.GetObject("X10Y10.Image"), System.Drawing.Image)
        Me.X10Y10.Location = New System.Drawing.Point(148, 162)
        Me.X10Y10.Name = "X10Y10"
        Me.X10Y10.Size = New System.Drawing.Size(16, 16)
        Me.X10Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y10.TabIndex = 135
        Me.X10Y10.TabStop = False
        '
        'X10Y9
        '
        Me.X10Y9.BackColor = System.Drawing.Color.Black
        Me.X10Y9.BackgroundImage = CType(resources.GetObject("X10Y9.BackgroundImage"), System.Drawing.Image)
        Me.X10Y9.Image = CType(resources.GetObject("X10Y9.Image"), System.Drawing.Image)
        Me.X10Y9.Location = New System.Drawing.Point(132, 162)
        Me.X10Y9.Name = "X10Y9"
        Me.X10Y9.Size = New System.Drawing.Size(16, 16)
        Me.X10Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y9.TabIndex = 134
        Me.X10Y9.TabStop = False
        '
        'X10Y8
        '
        Me.X10Y8.BackColor = System.Drawing.Color.Black
        Me.X10Y8.BackgroundImage = CType(resources.GetObject("X10Y8.BackgroundImage"), System.Drawing.Image)
        Me.X10Y8.Image = CType(resources.GetObject("X10Y8.Image"), System.Drawing.Image)
        Me.X10Y8.Location = New System.Drawing.Point(116, 162)
        Me.X10Y8.Name = "X10Y8"
        Me.X10Y8.Size = New System.Drawing.Size(16, 16)
        Me.X10Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y8.TabIndex = 133
        Me.X10Y8.TabStop = False
        '
        'X10Y7
        '
        Me.X10Y7.BackColor = System.Drawing.Color.Black
        Me.X10Y7.BackgroundImage = CType(resources.GetObject("X10Y7.BackgroundImage"), System.Drawing.Image)
        Me.X10Y7.Image = CType(resources.GetObject("X10Y7.Image"), System.Drawing.Image)
        Me.X10Y7.Location = New System.Drawing.Point(100, 162)
        Me.X10Y7.Name = "X10Y7"
        Me.X10Y7.Size = New System.Drawing.Size(16, 16)
        Me.X10Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y7.TabIndex = 132
        Me.X10Y7.TabStop = False
        '
        'X10Y5
        '
        Me.X10Y5.BackColor = System.Drawing.Color.Black
        Me.X10Y5.BackgroundImage = CType(resources.GetObject("X10Y5.BackgroundImage"), System.Drawing.Image)
        Me.X10Y5.Image = CType(resources.GetObject("X10Y5.Image"), System.Drawing.Image)
        Me.X10Y5.Location = New System.Drawing.Point(68, 162)
        Me.X10Y5.Name = "X10Y5"
        Me.X10Y5.Size = New System.Drawing.Size(16, 16)
        Me.X10Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y5.TabIndex = 130
        Me.X10Y5.TabStop = False
        '
        'X10Y4
        '
        Me.X10Y4.BackColor = System.Drawing.Color.Black
        Me.X10Y4.BackgroundImage = CType(resources.GetObject("X10Y4.BackgroundImage"), System.Drawing.Image)
        Me.X10Y4.Image = CType(resources.GetObject("X10Y4.Image"), System.Drawing.Image)
        Me.X10Y4.Location = New System.Drawing.Point(52, 162)
        Me.X10Y4.Name = "X10Y4"
        Me.X10Y4.Size = New System.Drawing.Size(16, 16)
        Me.X10Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y4.TabIndex = 129
        Me.X10Y4.TabStop = False
        '
        'X10Y3
        '
        Me.X10Y3.BackColor = System.Drawing.Color.Black
        Me.X10Y3.BackgroundImage = CType(resources.GetObject("X10Y3.BackgroundImage"), System.Drawing.Image)
        Me.X10Y3.Image = CType(resources.GetObject("X10Y3.Image"), System.Drawing.Image)
        Me.X10Y3.Location = New System.Drawing.Point(36, 162)
        Me.X10Y3.Name = "X10Y3"
        Me.X10Y3.Size = New System.Drawing.Size(16, 16)
        Me.X10Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y3.TabIndex = 128
        Me.X10Y3.TabStop = False
        '
        'X10Y2
        '
        Me.X10Y2.BackColor = System.Drawing.Color.Black
        Me.X10Y2.BackgroundImage = CType(resources.GetObject("X10Y2.BackgroundImage"), System.Drawing.Image)
        Me.X10Y2.Image = CType(resources.GetObject("X10Y2.Image"), System.Drawing.Image)
        Me.X10Y2.Location = New System.Drawing.Point(20, 162)
        Me.X10Y2.Name = "X10Y2"
        Me.X10Y2.Size = New System.Drawing.Size(16, 16)
        Me.X10Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y2.TabIndex = 127
        Me.X10Y2.TabStop = False
        '
        'X10Y1
        '
        Me.X10Y1.BackColor = System.Drawing.Color.Black
        Me.X10Y1.BackgroundImage = CType(resources.GetObject("X10Y1.BackgroundImage"), System.Drawing.Image)
        Me.X10Y1.Image = CType(resources.GetObject("X10Y1.Image"), System.Drawing.Image)
        Me.X10Y1.Location = New System.Drawing.Point(4, 162)
        Me.X10Y1.Name = "X10Y1"
        Me.X10Y1.Size = New System.Drawing.Size(16, 16)
        Me.X10Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y1.TabIndex = 126
        Me.X10Y1.TabStop = False
        '
        'X10Y6
        '
        Me.X10Y6.BackColor = System.Drawing.Color.Black
        Me.X10Y6.BackgroundImage = CType(resources.GetObject("X10Y6.BackgroundImage"), System.Drawing.Image)
        Me.X10Y6.Image = CType(resources.GetObject("X10Y6.Image"), System.Drawing.Image)
        Me.X10Y6.Location = New System.Drawing.Point(84, 162)
        Me.X10Y6.Name = "X10Y6"
        Me.X10Y6.Size = New System.Drawing.Size(16, 16)
        Me.X10Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y6.TabIndex = 131
        Me.X10Y6.TabStop = False
        '
        'X9Y10
        '
        Me.X9Y10.BackColor = System.Drawing.Color.Black
        Me.X9Y10.BackgroundImage = CType(resources.GetObject("X9Y10.BackgroundImage"), System.Drawing.Image)
        Me.X9Y10.Image = CType(resources.GetObject("X9Y10.Image"), System.Drawing.Image)
        Me.X9Y10.Location = New System.Drawing.Point(148, 147)
        Me.X9Y10.Name = "X9Y10"
        Me.X9Y10.Size = New System.Drawing.Size(16, 16)
        Me.X9Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y10.TabIndex = 125
        Me.X9Y10.TabStop = False
        '
        'X9Y9
        '
        Me.X9Y9.BackColor = System.Drawing.Color.Black
        Me.X9Y9.BackgroundImage = CType(resources.GetObject("X9Y9.BackgroundImage"), System.Drawing.Image)
        Me.X9Y9.Image = CType(resources.GetObject("X9Y9.Image"), System.Drawing.Image)
        Me.X9Y9.Location = New System.Drawing.Point(132, 147)
        Me.X9Y9.Name = "X9Y9"
        Me.X9Y9.Size = New System.Drawing.Size(16, 16)
        Me.X9Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y9.TabIndex = 124
        Me.X9Y9.TabStop = False
        '
        'X9Y8
        '
        Me.X9Y8.BackColor = System.Drawing.Color.Black
        Me.X9Y8.BackgroundImage = CType(resources.GetObject("X9Y8.BackgroundImage"), System.Drawing.Image)
        Me.X9Y8.Image = CType(resources.GetObject("X9Y8.Image"), System.Drawing.Image)
        Me.X9Y8.Location = New System.Drawing.Point(116, 147)
        Me.X9Y8.Name = "X9Y8"
        Me.X9Y8.Size = New System.Drawing.Size(16, 16)
        Me.X9Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y8.TabIndex = 123
        Me.X9Y8.TabStop = False
        '
        'X9Y7
        '
        Me.X9Y7.BackColor = System.Drawing.Color.Black
        Me.X9Y7.BackgroundImage = CType(resources.GetObject("X9Y7.BackgroundImage"), System.Drawing.Image)
        Me.X9Y7.Image = CType(resources.GetObject("X9Y7.Image"), System.Drawing.Image)
        Me.X9Y7.Location = New System.Drawing.Point(100, 147)
        Me.X9Y7.Name = "X9Y7"
        Me.X9Y7.Size = New System.Drawing.Size(16, 16)
        Me.X9Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y7.TabIndex = 122
        Me.X9Y7.TabStop = False
        '
        'X9Y5
        '
        Me.X9Y5.BackColor = System.Drawing.Color.Black
        Me.X9Y5.BackgroundImage = CType(resources.GetObject("X9Y5.BackgroundImage"), System.Drawing.Image)
        Me.X9Y5.Image = CType(resources.GetObject("X9Y5.Image"), System.Drawing.Image)
        Me.X9Y5.Location = New System.Drawing.Point(68, 147)
        Me.X9Y5.Name = "X9Y5"
        Me.X9Y5.Size = New System.Drawing.Size(16, 16)
        Me.X9Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y5.TabIndex = 120
        Me.X9Y5.TabStop = False
        '
        'X9Y4
        '
        Me.X9Y4.BackColor = System.Drawing.Color.Black
        Me.X9Y4.BackgroundImage = CType(resources.GetObject("X9Y4.BackgroundImage"), System.Drawing.Image)
        Me.X9Y4.Image = CType(resources.GetObject("X9Y4.Image"), System.Drawing.Image)
        Me.X9Y4.Location = New System.Drawing.Point(52, 147)
        Me.X9Y4.Name = "X9Y4"
        Me.X9Y4.Size = New System.Drawing.Size(16, 16)
        Me.X9Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y4.TabIndex = 119
        Me.X9Y4.TabStop = False
        '
        'X9Y3
        '
        Me.X9Y3.BackColor = System.Drawing.Color.Black
        Me.X9Y3.BackgroundImage = CType(resources.GetObject("X9Y3.BackgroundImage"), System.Drawing.Image)
        Me.X9Y3.Image = CType(resources.GetObject("X9Y3.Image"), System.Drawing.Image)
        Me.X9Y3.Location = New System.Drawing.Point(36, 147)
        Me.X9Y3.Name = "X9Y3"
        Me.X9Y3.Size = New System.Drawing.Size(16, 16)
        Me.X9Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y3.TabIndex = 118
        Me.X9Y3.TabStop = False
        '
        'X9Y2
        '
        Me.X9Y2.BackColor = System.Drawing.Color.Black
        Me.X9Y2.BackgroundImage = CType(resources.GetObject("X9Y2.BackgroundImage"), System.Drawing.Image)
        Me.X9Y2.Image = CType(resources.GetObject("X9Y2.Image"), System.Drawing.Image)
        Me.X9Y2.Location = New System.Drawing.Point(20, 147)
        Me.X9Y2.Name = "X9Y2"
        Me.X9Y2.Size = New System.Drawing.Size(16, 16)
        Me.X9Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y2.TabIndex = 117
        Me.X9Y2.TabStop = False
        '
        'X9Y1
        '
        Me.X9Y1.BackColor = System.Drawing.Color.Black
        Me.X9Y1.BackgroundImage = CType(resources.GetObject("X9Y1.BackgroundImage"), System.Drawing.Image)
        Me.X9Y1.Image = CType(resources.GetObject("X9Y1.Image"), System.Drawing.Image)
        Me.X9Y1.Location = New System.Drawing.Point(4, 147)
        Me.X9Y1.Name = "X9Y1"
        Me.X9Y1.Size = New System.Drawing.Size(16, 16)
        Me.X9Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y1.TabIndex = 116
        Me.X9Y1.TabStop = False
        '
        'X9Y6
        '
        Me.X9Y6.BackColor = System.Drawing.Color.Black
        Me.X9Y6.BackgroundImage = CType(resources.GetObject("X9Y6.BackgroundImage"), System.Drawing.Image)
        Me.X9Y6.Image = CType(resources.GetObject("X9Y6.Image"), System.Drawing.Image)
        Me.X9Y6.Location = New System.Drawing.Point(84, 147)
        Me.X9Y6.Name = "X9Y6"
        Me.X9Y6.Size = New System.Drawing.Size(16, 16)
        Me.X9Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y6.TabIndex = 121
        Me.X9Y6.TabStop = False
        '
        'X8Y10
        '
        Me.X8Y10.BackColor = System.Drawing.Color.Black
        Me.X8Y10.BackgroundImage = CType(resources.GetObject("X8Y10.BackgroundImage"), System.Drawing.Image)
        Me.X8Y10.Image = CType(resources.GetObject("X8Y10.Image"), System.Drawing.Image)
        Me.X8Y10.Location = New System.Drawing.Point(148, 132)
        Me.X8Y10.Name = "X8Y10"
        Me.X8Y10.Size = New System.Drawing.Size(16, 16)
        Me.X8Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y10.TabIndex = 115
        Me.X8Y10.TabStop = False
        '
        'X8Y9
        '
        Me.X8Y9.BackColor = System.Drawing.Color.Black
        Me.X8Y9.BackgroundImage = CType(resources.GetObject("X8Y9.BackgroundImage"), System.Drawing.Image)
        Me.X8Y9.Image = CType(resources.GetObject("X8Y9.Image"), System.Drawing.Image)
        Me.X8Y9.Location = New System.Drawing.Point(132, 132)
        Me.X8Y9.Name = "X8Y9"
        Me.X8Y9.Size = New System.Drawing.Size(16, 16)
        Me.X8Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y9.TabIndex = 114
        Me.X8Y9.TabStop = False
        '
        'X8Y8
        '
        Me.X8Y8.BackColor = System.Drawing.Color.Black
        Me.X8Y8.BackgroundImage = CType(resources.GetObject("X8Y8.BackgroundImage"), System.Drawing.Image)
        Me.X8Y8.Image = CType(resources.GetObject("X8Y8.Image"), System.Drawing.Image)
        Me.X8Y8.Location = New System.Drawing.Point(116, 132)
        Me.X8Y8.Name = "X8Y8"
        Me.X8Y8.Size = New System.Drawing.Size(16, 16)
        Me.X8Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y8.TabIndex = 113
        Me.X8Y8.TabStop = False
        '
        'X8Y7
        '
        Me.X8Y7.BackColor = System.Drawing.Color.Black
        Me.X8Y7.BackgroundImage = CType(resources.GetObject("X8Y7.BackgroundImage"), System.Drawing.Image)
        Me.X8Y7.Image = CType(resources.GetObject("X8Y7.Image"), System.Drawing.Image)
        Me.X8Y7.Location = New System.Drawing.Point(100, 132)
        Me.X8Y7.Name = "X8Y7"
        Me.X8Y7.Size = New System.Drawing.Size(16, 16)
        Me.X8Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y7.TabIndex = 112
        Me.X8Y7.TabStop = False
        '
        'X8Y5
        '
        Me.X8Y5.BackColor = System.Drawing.Color.Black
        Me.X8Y5.BackgroundImage = CType(resources.GetObject("X8Y5.BackgroundImage"), System.Drawing.Image)
        Me.X8Y5.Image = CType(resources.GetObject("X8Y5.Image"), System.Drawing.Image)
        Me.X8Y5.Location = New System.Drawing.Point(68, 132)
        Me.X8Y5.Name = "X8Y5"
        Me.X8Y5.Size = New System.Drawing.Size(16, 16)
        Me.X8Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y5.TabIndex = 110
        Me.X8Y5.TabStop = False
        '
        'X8Y4
        '
        Me.X8Y4.BackColor = System.Drawing.Color.Black
        Me.X8Y4.BackgroundImage = CType(resources.GetObject("X8Y4.BackgroundImage"), System.Drawing.Image)
        Me.X8Y4.Image = CType(resources.GetObject("X8Y4.Image"), System.Drawing.Image)
        Me.X8Y4.Location = New System.Drawing.Point(52, 132)
        Me.X8Y4.Name = "X8Y4"
        Me.X8Y4.Size = New System.Drawing.Size(16, 16)
        Me.X8Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y4.TabIndex = 109
        Me.X8Y4.TabStop = False
        '
        'X8Y3
        '
        Me.X8Y3.BackColor = System.Drawing.Color.Black
        Me.X8Y3.BackgroundImage = CType(resources.GetObject("X8Y3.BackgroundImage"), System.Drawing.Image)
        Me.X8Y3.Image = CType(resources.GetObject("X8Y3.Image"), System.Drawing.Image)
        Me.X8Y3.Location = New System.Drawing.Point(36, 132)
        Me.X8Y3.Name = "X8Y3"
        Me.X8Y3.Size = New System.Drawing.Size(16, 16)
        Me.X8Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y3.TabIndex = 108
        Me.X8Y3.TabStop = False
        '
        'X8Y2
        '
        Me.X8Y2.BackColor = System.Drawing.Color.Black
        Me.X8Y2.BackgroundImage = CType(resources.GetObject("X8Y2.BackgroundImage"), System.Drawing.Image)
        Me.X8Y2.Image = CType(resources.GetObject("X8Y2.Image"), System.Drawing.Image)
        Me.X8Y2.Location = New System.Drawing.Point(20, 132)
        Me.X8Y2.Name = "X8Y2"
        Me.X8Y2.Size = New System.Drawing.Size(16, 16)
        Me.X8Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y2.TabIndex = 107
        Me.X8Y2.TabStop = False
        '
        'X8Y1
        '
        Me.X8Y1.BackColor = System.Drawing.Color.Black
        Me.X8Y1.BackgroundImage = CType(resources.GetObject("X8Y1.BackgroundImage"), System.Drawing.Image)
        Me.X8Y1.Image = CType(resources.GetObject("X8Y1.Image"), System.Drawing.Image)
        Me.X8Y1.Location = New System.Drawing.Point(4, 132)
        Me.X8Y1.Name = "X8Y1"
        Me.X8Y1.Size = New System.Drawing.Size(16, 16)
        Me.X8Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y1.TabIndex = 106
        Me.X8Y1.TabStop = False
        '
        'X8Y6
        '
        Me.X8Y6.BackColor = System.Drawing.Color.Black
        Me.X8Y6.BackgroundImage = CType(resources.GetObject("X8Y6.BackgroundImage"), System.Drawing.Image)
        Me.X8Y6.Image = CType(resources.GetObject("X8Y6.Image"), System.Drawing.Image)
        Me.X8Y6.Location = New System.Drawing.Point(84, 132)
        Me.X8Y6.Name = "X8Y6"
        Me.X8Y6.Size = New System.Drawing.Size(16, 16)
        Me.X8Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y6.TabIndex = 111
        Me.X8Y6.TabStop = False
        '
        'X7Y10
        '
        Me.X7Y10.BackColor = System.Drawing.Color.Black
        Me.X7Y10.BackgroundImage = CType(resources.GetObject("X7Y10.BackgroundImage"), System.Drawing.Image)
        Me.X7Y10.Image = CType(resources.GetObject("X7Y10.Image"), System.Drawing.Image)
        Me.X7Y10.Location = New System.Drawing.Point(148, 117)
        Me.X7Y10.Name = "X7Y10"
        Me.X7Y10.Size = New System.Drawing.Size(16, 16)
        Me.X7Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y10.TabIndex = 105
        Me.X7Y10.TabStop = False
        '
        'X7Y9
        '
        Me.X7Y9.BackColor = System.Drawing.Color.Black
        Me.X7Y9.BackgroundImage = CType(resources.GetObject("X7Y9.BackgroundImage"), System.Drawing.Image)
        Me.X7Y9.Image = CType(resources.GetObject("X7Y9.Image"), System.Drawing.Image)
        Me.X7Y9.Location = New System.Drawing.Point(132, 117)
        Me.X7Y9.Name = "X7Y9"
        Me.X7Y9.Size = New System.Drawing.Size(16, 16)
        Me.X7Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y9.TabIndex = 104
        Me.X7Y9.TabStop = False
        '
        'X7Y8
        '
        Me.X7Y8.BackColor = System.Drawing.Color.Black
        Me.X7Y8.BackgroundImage = CType(resources.GetObject("X7Y8.BackgroundImage"), System.Drawing.Image)
        Me.X7Y8.Image = CType(resources.GetObject("X7Y8.Image"), System.Drawing.Image)
        Me.X7Y8.Location = New System.Drawing.Point(116, 117)
        Me.X7Y8.Name = "X7Y8"
        Me.X7Y8.Size = New System.Drawing.Size(16, 16)
        Me.X7Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y8.TabIndex = 103
        Me.X7Y8.TabStop = False
        '
        'X7Y7
        '
        Me.X7Y7.BackColor = System.Drawing.Color.Black
        Me.X7Y7.BackgroundImage = CType(resources.GetObject("X7Y7.BackgroundImage"), System.Drawing.Image)
        Me.X7Y7.Image = CType(resources.GetObject("X7Y7.Image"), System.Drawing.Image)
        Me.X7Y7.Location = New System.Drawing.Point(100, 117)
        Me.X7Y7.Name = "X7Y7"
        Me.X7Y7.Size = New System.Drawing.Size(16, 16)
        Me.X7Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y7.TabIndex = 102
        Me.X7Y7.TabStop = False
        '
        'X7Y5
        '
        Me.X7Y5.BackColor = System.Drawing.Color.Black
        Me.X7Y5.BackgroundImage = CType(resources.GetObject("X7Y5.BackgroundImage"), System.Drawing.Image)
        Me.X7Y5.Image = CType(resources.GetObject("X7Y5.Image"), System.Drawing.Image)
        Me.X7Y5.Location = New System.Drawing.Point(68, 117)
        Me.X7Y5.Name = "X7Y5"
        Me.X7Y5.Size = New System.Drawing.Size(16, 16)
        Me.X7Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y5.TabIndex = 100
        Me.X7Y5.TabStop = False
        '
        'X7Y4
        '
        Me.X7Y4.BackColor = System.Drawing.Color.Black
        Me.X7Y4.BackgroundImage = CType(resources.GetObject("X7Y4.BackgroundImage"), System.Drawing.Image)
        Me.X7Y4.Image = CType(resources.GetObject("X7Y4.Image"), System.Drawing.Image)
        Me.X7Y4.Location = New System.Drawing.Point(52, 117)
        Me.X7Y4.Name = "X7Y4"
        Me.X7Y4.Size = New System.Drawing.Size(16, 16)
        Me.X7Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y4.TabIndex = 99
        Me.X7Y4.TabStop = False
        '
        'X7Y3
        '
        Me.X7Y3.BackColor = System.Drawing.Color.Black
        Me.X7Y3.BackgroundImage = CType(resources.GetObject("X7Y3.BackgroundImage"), System.Drawing.Image)
        Me.X7Y3.Image = CType(resources.GetObject("X7Y3.Image"), System.Drawing.Image)
        Me.X7Y3.Location = New System.Drawing.Point(36, 117)
        Me.X7Y3.Name = "X7Y3"
        Me.X7Y3.Size = New System.Drawing.Size(16, 16)
        Me.X7Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y3.TabIndex = 98
        Me.X7Y3.TabStop = False
        '
        'X7Y2
        '
        Me.X7Y2.BackColor = System.Drawing.Color.Black
        Me.X7Y2.BackgroundImage = CType(resources.GetObject("X7Y2.BackgroundImage"), System.Drawing.Image)
        Me.X7Y2.Image = CType(resources.GetObject("X7Y2.Image"), System.Drawing.Image)
        Me.X7Y2.Location = New System.Drawing.Point(20, 117)
        Me.X7Y2.Name = "X7Y2"
        Me.X7Y2.Size = New System.Drawing.Size(16, 16)
        Me.X7Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y2.TabIndex = 97
        Me.X7Y2.TabStop = False
        '
        'X7Y1
        '
        Me.X7Y1.BackColor = System.Drawing.Color.Black
        Me.X7Y1.BackgroundImage = CType(resources.GetObject("X7Y1.BackgroundImage"), System.Drawing.Image)
        Me.X7Y1.Image = CType(resources.GetObject("X7Y1.Image"), System.Drawing.Image)
        Me.X7Y1.Location = New System.Drawing.Point(4, 117)
        Me.X7Y1.Name = "X7Y1"
        Me.X7Y1.Size = New System.Drawing.Size(16, 16)
        Me.X7Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y1.TabIndex = 96
        Me.X7Y1.TabStop = False
        '
        'X7Y6
        '
        Me.X7Y6.BackColor = System.Drawing.Color.Black
        Me.X7Y6.BackgroundImage = CType(resources.GetObject("X7Y6.BackgroundImage"), System.Drawing.Image)
        Me.X7Y6.Image = CType(resources.GetObject("X7Y6.Image"), System.Drawing.Image)
        Me.X7Y6.Location = New System.Drawing.Point(84, 117)
        Me.X7Y6.Name = "X7Y6"
        Me.X7Y6.Size = New System.Drawing.Size(16, 16)
        Me.X7Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y6.TabIndex = 101
        Me.X7Y6.TabStop = False
        '
        'X6Y10
        '
        Me.X6Y10.BackColor = System.Drawing.Color.Black
        Me.X6Y10.BackgroundImage = CType(resources.GetObject("X6Y10.BackgroundImage"), System.Drawing.Image)
        Me.X6Y10.Image = CType(resources.GetObject("X6Y10.Image"), System.Drawing.Image)
        Me.X6Y10.Location = New System.Drawing.Point(148, 102)
        Me.X6Y10.Name = "X6Y10"
        Me.X6Y10.Size = New System.Drawing.Size(16, 16)
        Me.X6Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y10.TabIndex = 95
        Me.X6Y10.TabStop = False
        '
        'X6Y9
        '
        Me.X6Y9.BackColor = System.Drawing.Color.Black
        Me.X6Y9.BackgroundImage = CType(resources.GetObject("X6Y9.BackgroundImage"), System.Drawing.Image)
        Me.X6Y9.Image = CType(resources.GetObject("X6Y9.Image"), System.Drawing.Image)
        Me.X6Y9.Location = New System.Drawing.Point(132, 102)
        Me.X6Y9.Name = "X6Y9"
        Me.X6Y9.Size = New System.Drawing.Size(16, 16)
        Me.X6Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y9.TabIndex = 94
        Me.X6Y9.TabStop = False
        '
        'X6Y8
        '
        Me.X6Y8.BackColor = System.Drawing.Color.Black
        Me.X6Y8.BackgroundImage = CType(resources.GetObject("X6Y8.BackgroundImage"), System.Drawing.Image)
        Me.X6Y8.Image = CType(resources.GetObject("X6Y8.Image"), System.Drawing.Image)
        Me.X6Y8.Location = New System.Drawing.Point(116, 102)
        Me.X6Y8.Name = "X6Y8"
        Me.X6Y8.Size = New System.Drawing.Size(16, 16)
        Me.X6Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y8.TabIndex = 93
        Me.X6Y8.TabStop = False
        '
        'X6Y7
        '
        Me.X6Y7.BackColor = System.Drawing.Color.Black
        Me.X6Y7.BackgroundImage = CType(resources.GetObject("X6Y7.BackgroundImage"), System.Drawing.Image)
        Me.X6Y7.Image = CType(resources.GetObject("X6Y7.Image"), System.Drawing.Image)
        Me.X6Y7.Location = New System.Drawing.Point(100, 102)
        Me.X6Y7.Name = "X6Y7"
        Me.X6Y7.Size = New System.Drawing.Size(16, 16)
        Me.X6Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y7.TabIndex = 92
        Me.X6Y7.TabStop = False
        '
        'X6Y5
        '
        Me.X6Y5.BackColor = System.Drawing.Color.Black
        Me.X6Y5.BackgroundImage = CType(resources.GetObject("X6Y5.BackgroundImage"), System.Drawing.Image)
        Me.X6Y5.Image = CType(resources.GetObject("X6Y5.Image"), System.Drawing.Image)
        Me.X6Y5.Location = New System.Drawing.Point(68, 102)
        Me.X6Y5.Name = "X6Y5"
        Me.X6Y5.Size = New System.Drawing.Size(16, 16)
        Me.X6Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y5.TabIndex = 90
        Me.X6Y5.TabStop = False
        '
        'X6Y4
        '
        Me.X6Y4.BackColor = System.Drawing.Color.Black
        Me.X6Y4.BackgroundImage = CType(resources.GetObject("X6Y4.BackgroundImage"), System.Drawing.Image)
        Me.X6Y4.Image = CType(resources.GetObject("X6Y4.Image"), System.Drawing.Image)
        Me.X6Y4.Location = New System.Drawing.Point(52, 102)
        Me.X6Y4.Name = "X6Y4"
        Me.X6Y4.Size = New System.Drawing.Size(16, 16)
        Me.X6Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y4.TabIndex = 89
        Me.X6Y4.TabStop = False
        '
        'X6Y3
        '
        Me.X6Y3.BackColor = System.Drawing.Color.Black
        Me.X6Y3.BackgroundImage = CType(resources.GetObject("X6Y3.BackgroundImage"), System.Drawing.Image)
        Me.X6Y3.Image = CType(resources.GetObject("X6Y3.Image"), System.Drawing.Image)
        Me.X6Y3.Location = New System.Drawing.Point(36, 102)
        Me.X6Y3.Name = "X6Y3"
        Me.X6Y3.Size = New System.Drawing.Size(16, 16)
        Me.X6Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y3.TabIndex = 88
        Me.X6Y3.TabStop = False
        '
        'X6Y2
        '
        Me.X6Y2.BackColor = System.Drawing.Color.Black
        Me.X6Y2.BackgroundImage = CType(resources.GetObject("X6Y2.BackgroundImage"), System.Drawing.Image)
        Me.X6Y2.Image = CType(resources.GetObject("X6Y2.Image"), System.Drawing.Image)
        Me.X6Y2.Location = New System.Drawing.Point(20, 102)
        Me.X6Y2.Name = "X6Y2"
        Me.X6Y2.Size = New System.Drawing.Size(16, 16)
        Me.X6Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y2.TabIndex = 87
        Me.X6Y2.TabStop = False
        '
        'X6Y1
        '
        Me.X6Y1.BackColor = System.Drawing.Color.Black
        Me.X6Y1.BackgroundImage = CType(resources.GetObject("X6Y1.BackgroundImage"), System.Drawing.Image)
        Me.X6Y1.Image = CType(resources.GetObject("X6Y1.Image"), System.Drawing.Image)
        Me.X6Y1.Location = New System.Drawing.Point(4, 102)
        Me.X6Y1.Name = "X6Y1"
        Me.X6Y1.Size = New System.Drawing.Size(16, 16)
        Me.X6Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y1.TabIndex = 86
        Me.X6Y1.TabStop = False
        '
        'X6Y6
        '
        Me.X6Y6.BackColor = System.Drawing.Color.Black
        Me.X6Y6.BackgroundImage = CType(resources.GetObject("X6Y6.BackgroundImage"), System.Drawing.Image)
        Me.X6Y6.Image = CType(resources.GetObject("X6Y6.Image"), System.Drawing.Image)
        Me.X6Y6.Location = New System.Drawing.Point(84, 102)
        Me.X6Y6.Name = "X6Y6"
        Me.X6Y6.Size = New System.Drawing.Size(16, 16)
        Me.X6Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y6.TabIndex = 91
        Me.X6Y6.TabStop = False
        '
        'X5Y10
        '
        Me.X5Y10.BackColor = System.Drawing.Color.Black
        Me.X5Y10.BackgroundImage = CType(resources.GetObject("X5Y10.BackgroundImage"), System.Drawing.Image)
        Me.X5Y10.Image = CType(resources.GetObject("X5Y10.Image"), System.Drawing.Image)
        Me.X5Y10.Location = New System.Drawing.Point(148, 87)
        Me.X5Y10.Name = "X5Y10"
        Me.X5Y10.Size = New System.Drawing.Size(16, 16)
        Me.X5Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y10.TabIndex = 85
        Me.X5Y10.TabStop = False
        '
        'X5Y9
        '
        Me.X5Y9.BackColor = System.Drawing.Color.Black
        Me.X5Y9.BackgroundImage = CType(resources.GetObject("X5Y9.BackgroundImage"), System.Drawing.Image)
        Me.X5Y9.Image = CType(resources.GetObject("X5Y9.Image"), System.Drawing.Image)
        Me.X5Y9.Location = New System.Drawing.Point(132, 87)
        Me.X5Y9.Name = "X5Y9"
        Me.X5Y9.Size = New System.Drawing.Size(16, 16)
        Me.X5Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y9.TabIndex = 84
        Me.X5Y9.TabStop = False
        '
        'X5Y8
        '
        Me.X5Y8.BackColor = System.Drawing.Color.Black
        Me.X5Y8.BackgroundImage = CType(resources.GetObject("X5Y8.BackgroundImage"), System.Drawing.Image)
        Me.X5Y8.Image = CType(resources.GetObject("X5Y8.Image"), System.Drawing.Image)
        Me.X5Y8.Location = New System.Drawing.Point(116, 87)
        Me.X5Y8.Name = "X5Y8"
        Me.X5Y8.Size = New System.Drawing.Size(16, 16)
        Me.X5Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y8.TabIndex = 83
        Me.X5Y8.TabStop = False
        '
        'X5Y7
        '
        Me.X5Y7.BackColor = System.Drawing.Color.Black
        Me.X5Y7.BackgroundImage = CType(resources.GetObject("X5Y7.BackgroundImage"), System.Drawing.Image)
        Me.X5Y7.Image = CType(resources.GetObject("X5Y7.Image"), System.Drawing.Image)
        Me.X5Y7.Location = New System.Drawing.Point(100, 87)
        Me.X5Y7.Name = "X5Y7"
        Me.X5Y7.Size = New System.Drawing.Size(16, 16)
        Me.X5Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y7.TabIndex = 82
        Me.X5Y7.TabStop = False
        '
        'X5Y5
        '
        Me.X5Y5.BackColor = System.Drawing.Color.Black
        Me.X5Y5.BackgroundImage = CType(resources.GetObject("X5Y5.BackgroundImage"), System.Drawing.Image)
        Me.X5Y5.Image = CType(resources.GetObject("X5Y5.Image"), System.Drawing.Image)
        Me.X5Y5.Location = New System.Drawing.Point(68, 87)
        Me.X5Y5.Name = "X5Y5"
        Me.X5Y5.Size = New System.Drawing.Size(16, 16)
        Me.X5Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y5.TabIndex = 80
        Me.X5Y5.TabStop = False
        '
        'X5Y4
        '
        Me.X5Y4.BackColor = System.Drawing.Color.Black
        Me.X5Y4.BackgroundImage = CType(resources.GetObject("X5Y4.BackgroundImage"), System.Drawing.Image)
        Me.X5Y4.Image = CType(resources.GetObject("X5Y4.Image"), System.Drawing.Image)
        Me.X5Y4.Location = New System.Drawing.Point(52, 87)
        Me.X5Y4.Name = "X5Y4"
        Me.X5Y4.Size = New System.Drawing.Size(16, 16)
        Me.X5Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y4.TabIndex = 79
        Me.X5Y4.TabStop = False
        '
        'X5Y3
        '
        Me.X5Y3.BackColor = System.Drawing.Color.Black
        Me.X5Y3.BackgroundImage = CType(resources.GetObject("X5Y3.BackgroundImage"), System.Drawing.Image)
        Me.X5Y3.Image = CType(resources.GetObject("X5Y3.Image"), System.Drawing.Image)
        Me.X5Y3.Location = New System.Drawing.Point(36, 87)
        Me.X5Y3.Name = "X5Y3"
        Me.X5Y3.Size = New System.Drawing.Size(16, 16)
        Me.X5Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y3.TabIndex = 78
        Me.X5Y3.TabStop = False
        '
        'X5Y2
        '
        Me.X5Y2.BackColor = System.Drawing.Color.Black
        Me.X5Y2.BackgroundImage = CType(resources.GetObject("X5Y2.BackgroundImage"), System.Drawing.Image)
        Me.X5Y2.Image = CType(resources.GetObject("X5Y2.Image"), System.Drawing.Image)
        Me.X5Y2.Location = New System.Drawing.Point(20, 87)
        Me.X5Y2.Name = "X5Y2"
        Me.X5Y2.Size = New System.Drawing.Size(16, 16)
        Me.X5Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y2.TabIndex = 77
        Me.X5Y2.TabStop = False
        '
        'X5Y1
        '
        Me.X5Y1.BackColor = System.Drawing.Color.Black
        Me.X5Y1.BackgroundImage = CType(resources.GetObject("X5Y1.BackgroundImage"), System.Drawing.Image)
        Me.X5Y1.Image = CType(resources.GetObject("X5Y1.Image"), System.Drawing.Image)
        Me.X5Y1.Location = New System.Drawing.Point(4, 87)
        Me.X5Y1.Name = "X5Y1"
        Me.X5Y1.Size = New System.Drawing.Size(16, 16)
        Me.X5Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y1.TabIndex = 76
        Me.X5Y1.TabStop = False
        '
        'X5Y6
        '
        Me.X5Y6.BackColor = System.Drawing.Color.Black
        Me.X5Y6.BackgroundImage = CType(resources.GetObject("X5Y6.BackgroundImage"), System.Drawing.Image)
        Me.X5Y6.Image = CType(resources.GetObject("X5Y6.Image"), System.Drawing.Image)
        Me.X5Y6.Location = New System.Drawing.Point(84, 87)
        Me.X5Y6.Name = "X5Y6"
        Me.X5Y6.Size = New System.Drawing.Size(16, 16)
        Me.X5Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y6.TabIndex = 81
        Me.X5Y6.TabStop = False
        '
        'X4Y10
        '
        Me.X4Y10.BackColor = System.Drawing.Color.Black
        Me.X4Y10.BackgroundImage = CType(resources.GetObject("X4Y10.BackgroundImage"), System.Drawing.Image)
        Me.X4Y10.Image = CType(resources.GetObject("X4Y10.Image"), System.Drawing.Image)
        Me.X4Y10.Location = New System.Drawing.Point(148, 72)
        Me.X4Y10.Name = "X4Y10"
        Me.X4Y10.Size = New System.Drawing.Size(16, 16)
        Me.X4Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y10.TabIndex = 75
        Me.X4Y10.TabStop = False
        '
        'X4Y9
        '
        Me.X4Y9.BackColor = System.Drawing.Color.Black
        Me.X4Y9.BackgroundImage = CType(resources.GetObject("X4Y9.BackgroundImage"), System.Drawing.Image)
        Me.X4Y9.Image = CType(resources.GetObject("X4Y9.Image"), System.Drawing.Image)
        Me.X4Y9.Location = New System.Drawing.Point(132, 72)
        Me.X4Y9.Name = "X4Y9"
        Me.X4Y9.Size = New System.Drawing.Size(16, 16)
        Me.X4Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y9.TabIndex = 74
        Me.X4Y9.TabStop = False
        '
        'X4Y8
        '
        Me.X4Y8.BackColor = System.Drawing.Color.Black
        Me.X4Y8.BackgroundImage = CType(resources.GetObject("X4Y8.BackgroundImage"), System.Drawing.Image)
        Me.X4Y8.Image = CType(resources.GetObject("X4Y8.Image"), System.Drawing.Image)
        Me.X4Y8.Location = New System.Drawing.Point(116, 72)
        Me.X4Y8.Name = "X4Y8"
        Me.X4Y8.Size = New System.Drawing.Size(16, 16)
        Me.X4Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y8.TabIndex = 73
        Me.X4Y8.TabStop = False
        '
        'X4Y7
        '
        Me.X4Y7.BackColor = System.Drawing.Color.Black
        Me.X4Y7.BackgroundImage = CType(resources.GetObject("X4Y7.BackgroundImage"), System.Drawing.Image)
        Me.X4Y7.Image = CType(resources.GetObject("X4Y7.Image"), System.Drawing.Image)
        Me.X4Y7.Location = New System.Drawing.Point(100, 72)
        Me.X4Y7.Name = "X4Y7"
        Me.X4Y7.Size = New System.Drawing.Size(16, 16)
        Me.X4Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y7.TabIndex = 72
        Me.X4Y7.TabStop = False
        '
        'X4Y6
        '
        Me.X4Y6.BackColor = System.Drawing.Color.Black
        Me.X4Y6.BackgroundImage = CType(resources.GetObject("X4Y6.BackgroundImage"), System.Drawing.Image)
        Me.X4Y6.Image = CType(resources.GetObject("X4Y6.Image"), System.Drawing.Image)
        Me.X4Y6.Location = New System.Drawing.Point(84, 72)
        Me.X4Y6.Name = "X4Y6"
        Me.X4Y6.Size = New System.Drawing.Size(16, 16)
        Me.X4Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y6.TabIndex = 71
        Me.X4Y6.TabStop = False
        '
        'X4Y5
        '
        Me.X4Y5.BackColor = System.Drawing.Color.Black
        Me.X4Y5.BackgroundImage = CType(resources.GetObject("X4Y5.BackgroundImage"), System.Drawing.Image)
        Me.X4Y5.Image = CType(resources.GetObject("X4Y5.Image"), System.Drawing.Image)
        Me.X4Y5.Location = New System.Drawing.Point(68, 72)
        Me.X4Y5.Name = "X4Y5"
        Me.X4Y5.Size = New System.Drawing.Size(16, 16)
        Me.X4Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y5.TabIndex = 70
        Me.X4Y5.TabStop = False
        '
        'X4Y4
        '
        Me.X4Y4.BackColor = System.Drawing.Color.Black
        Me.X4Y4.BackgroundImage = CType(resources.GetObject("X4Y4.BackgroundImage"), System.Drawing.Image)
        Me.X4Y4.Image = CType(resources.GetObject("X4Y4.Image"), System.Drawing.Image)
        Me.X4Y4.Location = New System.Drawing.Point(52, 72)
        Me.X4Y4.Name = "X4Y4"
        Me.X4Y4.Size = New System.Drawing.Size(16, 16)
        Me.X4Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y4.TabIndex = 69
        Me.X4Y4.TabStop = False
        '
        'X4Y3
        '
        Me.X4Y3.BackColor = System.Drawing.Color.Black
        Me.X4Y3.BackgroundImage = CType(resources.GetObject("X4Y3.BackgroundImage"), System.Drawing.Image)
        Me.X4Y3.Image = CType(resources.GetObject("X4Y3.Image"), System.Drawing.Image)
        Me.X4Y3.Location = New System.Drawing.Point(36, 72)
        Me.X4Y3.Name = "X4Y3"
        Me.X4Y3.Size = New System.Drawing.Size(16, 16)
        Me.X4Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y3.TabIndex = 68
        Me.X4Y3.TabStop = False
        '
        'X4Y2
        '
        Me.X4Y2.BackColor = System.Drawing.Color.Black
        Me.X4Y2.BackgroundImage = CType(resources.GetObject("X4Y2.BackgroundImage"), System.Drawing.Image)
        Me.X4Y2.Image = CType(resources.GetObject("X4Y2.Image"), System.Drawing.Image)
        Me.X4Y2.Location = New System.Drawing.Point(20, 72)
        Me.X4Y2.Name = "X4Y2"
        Me.X4Y2.Size = New System.Drawing.Size(16, 16)
        Me.X4Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y2.TabIndex = 67
        Me.X4Y2.TabStop = False
        '
        'X4Y1
        '
        Me.X4Y1.BackColor = System.Drawing.Color.Black
        Me.X4Y1.BackgroundImage = CType(resources.GetObject("X4Y1.BackgroundImage"), System.Drawing.Image)
        Me.X4Y1.Image = CType(resources.GetObject("X4Y1.Image"), System.Drawing.Image)
        Me.X4Y1.Location = New System.Drawing.Point(4, 72)
        Me.X4Y1.Name = "X4Y1"
        Me.X4Y1.Size = New System.Drawing.Size(16, 16)
        Me.X4Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y1.TabIndex = 66
        Me.X4Y1.TabStop = False
        '
        'X3Y10
        '
        Me.X3Y10.BackColor = System.Drawing.Color.Black
        Me.X3Y10.BackgroundImage = CType(resources.GetObject("X3Y10.BackgroundImage"), System.Drawing.Image)
        Me.X3Y10.Image = CType(resources.GetObject("X3Y10.Image"), System.Drawing.Image)
        Me.X3Y10.Location = New System.Drawing.Point(148, 57)
        Me.X3Y10.Name = "X3Y10"
        Me.X3Y10.Size = New System.Drawing.Size(16, 16)
        Me.X3Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y10.TabIndex = 65
        Me.X3Y10.TabStop = False
        '
        'X3Y9
        '
        Me.X3Y9.BackColor = System.Drawing.Color.Black
        Me.X3Y9.BackgroundImage = CType(resources.GetObject("X3Y9.BackgroundImage"), System.Drawing.Image)
        Me.X3Y9.Image = CType(resources.GetObject("X3Y9.Image"), System.Drawing.Image)
        Me.X3Y9.Location = New System.Drawing.Point(132, 57)
        Me.X3Y9.Name = "X3Y9"
        Me.X3Y9.Size = New System.Drawing.Size(16, 16)
        Me.X3Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y9.TabIndex = 64
        Me.X3Y9.TabStop = False
        '
        'X3Y8
        '
        Me.X3Y8.BackColor = System.Drawing.Color.Black
        Me.X3Y8.BackgroundImage = CType(resources.GetObject("X3Y8.BackgroundImage"), System.Drawing.Image)
        Me.X3Y8.Image = CType(resources.GetObject("X3Y8.Image"), System.Drawing.Image)
        Me.X3Y8.Location = New System.Drawing.Point(116, 57)
        Me.X3Y8.Name = "X3Y8"
        Me.X3Y8.Size = New System.Drawing.Size(16, 16)
        Me.X3Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y8.TabIndex = 63
        Me.X3Y8.TabStop = False
        '
        'X3Y7
        '
        Me.X3Y7.BackColor = System.Drawing.Color.Black
        Me.X3Y7.BackgroundImage = CType(resources.GetObject("X3Y7.BackgroundImage"), System.Drawing.Image)
        Me.X3Y7.Image = CType(resources.GetObject("X3Y7.Image"), System.Drawing.Image)
        Me.X3Y7.Location = New System.Drawing.Point(100, 57)
        Me.X3Y7.Name = "X3Y7"
        Me.X3Y7.Size = New System.Drawing.Size(16, 16)
        Me.X3Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y7.TabIndex = 62
        Me.X3Y7.TabStop = False
        '
        'X3Y5
        '
        Me.X3Y5.BackColor = System.Drawing.Color.Black
        Me.X3Y5.BackgroundImage = CType(resources.GetObject("X3Y5.BackgroundImage"), System.Drawing.Image)
        Me.X3Y5.Image = CType(resources.GetObject("X3Y5.Image"), System.Drawing.Image)
        Me.X3Y5.Location = New System.Drawing.Point(68, 57)
        Me.X3Y5.Name = "X3Y5"
        Me.X3Y5.Size = New System.Drawing.Size(16, 16)
        Me.X3Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y5.TabIndex = 60
        Me.X3Y5.TabStop = False
        '
        'X3Y4
        '
        Me.X3Y4.BackColor = System.Drawing.Color.Black
        Me.X3Y4.BackgroundImage = CType(resources.GetObject("X3Y4.BackgroundImage"), System.Drawing.Image)
        Me.X3Y4.Image = CType(resources.GetObject("X3Y4.Image"), System.Drawing.Image)
        Me.X3Y4.Location = New System.Drawing.Point(52, 57)
        Me.X3Y4.Name = "X3Y4"
        Me.X3Y4.Size = New System.Drawing.Size(16, 16)
        Me.X3Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y4.TabIndex = 59
        Me.X3Y4.TabStop = False
        '
        'X3Y3
        '
        Me.X3Y3.BackColor = System.Drawing.Color.Black
        Me.X3Y3.BackgroundImage = CType(resources.GetObject("X3Y3.BackgroundImage"), System.Drawing.Image)
        Me.X3Y3.Image = CType(resources.GetObject("X3Y3.Image"), System.Drawing.Image)
        Me.X3Y3.Location = New System.Drawing.Point(36, 57)
        Me.X3Y3.Name = "X3Y3"
        Me.X3Y3.Size = New System.Drawing.Size(16, 16)
        Me.X3Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y3.TabIndex = 58
        Me.X3Y3.TabStop = False
        '
        'X3Y2
        '
        Me.X3Y2.BackColor = System.Drawing.Color.Black
        Me.X3Y2.BackgroundImage = CType(resources.GetObject("X3Y2.BackgroundImage"), System.Drawing.Image)
        Me.X3Y2.Image = CType(resources.GetObject("X3Y2.Image"), System.Drawing.Image)
        Me.X3Y2.Location = New System.Drawing.Point(20, 57)
        Me.X3Y2.Name = "X3Y2"
        Me.X3Y2.Size = New System.Drawing.Size(16, 16)
        Me.X3Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y2.TabIndex = 57
        Me.X3Y2.TabStop = False
        '
        'X3Y1
        '
        Me.X3Y1.BackColor = System.Drawing.Color.Black
        Me.X3Y1.BackgroundImage = CType(resources.GetObject("X3Y1.BackgroundImage"), System.Drawing.Image)
        Me.X3Y1.Image = CType(resources.GetObject("X3Y1.Image"), System.Drawing.Image)
        Me.X3Y1.Location = New System.Drawing.Point(4, 57)
        Me.X3Y1.Name = "X3Y1"
        Me.X3Y1.Size = New System.Drawing.Size(16, 16)
        Me.X3Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y1.TabIndex = 56
        Me.X3Y1.TabStop = False
        '
        'X3Y6
        '
        Me.X3Y6.BackColor = System.Drawing.Color.Black
        Me.X3Y6.BackgroundImage = CType(resources.GetObject("X3Y6.BackgroundImage"), System.Drawing.Image)
        Me.X3Y6.Image = CType(resources.GetObject("X3Y6.Image"), System.Drawing.Image)
        Me.X3Y6.Location = New System.Drawing.Point(84, 57)
        Me.X3Y6.Name = "X3Y6"
        Me.X3Y6.Size = New System.Drawing.Size(16, 16)
        Me.X3Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y6.TabIndex = 61
        Me.X3Y6.TabStop = False
        '
        'X2Y10
        '
        Me.X2Y10.BackColor = System.Drawing.Color.Black
        Me.X2Y10.BackgroundImage = CType(resources.GetObject("X2Y10.BackgroundImage"), System.Drawing.Image)
        Me.X2Y10.Image = CType(resources.GetObject("X2Y10.Image"), System.Drawing.Image)
        Me.X2Y10.Location = New System.Drawing.Point(148, 42)
        Me.X2Y10.Name = "X2Y10"
        Me.X2Y10.Size = New System.Drawing.Size(16, 16)
        Me.X2Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y10.TabIndex = 19
        Me.X2Y10.TabStop = False
        '
        'X2Y9
        '
        Me.X2Y9.BackColor = System.Drawing.Color.Black
        Me.X2Y9.BackgroundImage = CType(resources.GetObject("X2Y9.BackgroundImage"), System.Drawing.Image)
        Me.X2Y9.Image = CType(resources.GetObject("X2Y9.Image"), System.Drawing.Image)
        Me.X2Y9.Location = New System.Drawing.Point(132, 42)
        Me.X2Y9.Name = "X2Y9"
        Me.X2Y9.Size = New System.Drawing.Size(16, 16)
        Me.X2Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y9.TabIndex = 18
        Me.X2Y9.TabStop = False
        '
        'X2Y8
        '
        Me.X2Y8.BackColor = System.Drawing.Color.Black
        Me.X2Y8.BackgroundImage = CType(resources.GetObject("X2Y8.BackgroundImage"), System.Drawing.Image)
        Me.X2Y8.Image = CType(resources.GetObject("X2Y8.Image"), System.Drawing.Image)
        Me.X2Y8.Location = New System.Drawing.Point(116, 42)
        Me.X2Y8.Name = "X2Y8"
        Me.X2Y8.Size = New System.Drawing.Size(16, 16)
        Me.X2Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y8.TabIndex = 17
        Me.X2Y8.TabStop = False
        '
        'X2Y7
        '
        Me.X2Y7.BackColor = System.Drawing.Color.Black
        Me.X2Y7.BackgroundImage = CType(resources.GetObject("X2Y7.BackgroundImage"), System.Drawing.Image)
        Me.X2Y7.Image = CType(resources.GetObject("X2Y7.Image"), System.Drawing.Image)
        Me.X2Y7.Location = New System.Drawing.Point(100, 42)
        Me.X2Y7.Name = "X2Y7"
        Me.X2Y7.Size = New System.Drawing.Size(16, 16)
        Me.X2Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y7.TabIndex = 16
        Me.X2Y7.TabStop = False
        '
        'X2Y6
        '
        Me.X2Y6.BackColor = System.Drawing.Color.Black
        Me.X2Y6.BackgroundImage = CType(resources.GetObject("X2Y6.BackgroundImage"), System.Drawing.Image)
        Me.X2Y6.Image = CType(resources.GetObject("X2Y6.Image"), System.Drawing.Image)
        Me.X2Y6.Location = New System.Drawing.Point(84, 42)
        Me.X2Y6.Name = "X2Y6"
        Me.X2Y6.Size = New System.Drawing.Size(16, 16)
        Me.X2Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y6.TabIndex = 15
        Me.X2Y6.TabStop = False
        '
        'X2Y5
        '
        Me.X2Y5.BackColor = System.Drawing.Color.Black
        Me.X2Y5.BackgroundImage = CType(resources.GetObject("X2Y5.BackgroundImage"), System.Drawing.Image)
        Me.X2Y5.Image = CType(resources.GetObject("X2Y5.Image"), System.Drawing.Image)
        Me.X2Y5.Location = New System.Drawing.Point(68, 42)
        Me.X2Y5.Name = "X2Y5"
        Me.X2Y5.Size = New System.Drawing.Size(16, 16)
        Me.X2Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y5.TabIndex = 14
        Me.X2Y5.TabStop = False
        '
        'X2Y4
        '
        Me.X2Y4.BackColor = System.Drawing.Color.Black
        Me.X2Y4.BackgroundImage = CType(resources.GetObject("X2Y4.BackgroundImage"), System.Drawing.Image)
        Me.X2Y4.Image = CType(resources.GetObject("X2Y4.Image"), System.Drawing.Image)
        Me.X2Y4.Location = New System.Drawing.Point(52, 42)
        Me.X2Y4.Name = "X2Y4"
        Me.X2Y4.Size = New System.Drawing.Size(16, 16)
        Me.X2Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y4.TabIndex = 13
        Me.X2Y4.TabStop = False
        '
        'X2Y3
        '
        Me.X2Y3.BackColor = System.Drawing.Color.Black
        Me.X2Y3.BackgroundImage = CType(resources.GetObject("X2Y3.BackgroundImage"), System.Drawing.Image)
        Me.X2Y3.Image = CType(resources.GetObject("X2Y3.Image"), System.Drawing.Image)
        Me.X2Y3.Location = New System.Drawing.Point(36, 42)
        Me.X2Y3.Name = "X2Y3"
        Me.X2Y3.Size = New System.Drawing.Size(16, 16)
        Me.X2Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y3.TabIndex = 12
        Me.X2Y3.TabStop = False
        '
        'X2Y2
        '
        Me.X2Y2.BackColor = System.Drawing.Color.Black
        Me.X2Y2.BackgroundImage = CType(resources.GetObject("X2Y2.BackgroundImage"), System.Drawing.Image)
        Me.X2Y2.Image = CType(resources.GetObject("X2Y2.Image"), System.Drawing.Image)
        Me.X2Y2.Location = New System.Drawing.Point(20, 42)
        Me.X2Y2.Name = "X2Y2"
        Me.X2Y2.Size = New System.Drawing.Size(16, 16)
        Me.X2Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y2.TabIndex = 11
        Me.X2Y2.TabStop = False
        '
        'X2Y1
        '
        Me.X2Y1.BackColor = System.Drawing.Color.Black
        Me.X2Y1.BackgroundImage = CType(resources.GetObject("X2Y1.BackgroundImage"), System.Drawing.Image)
        Me.X2Y1.Image = CType(resources.GetObject("X2Y1.Image"), System.Drawing.Image)
        Me.X2Y1.Location = New System.Drawing.Point(4, 42)
        Me.X2Y1.Name = "X2Y1"
        Me.X2Y1.Size = New System.Drawing.Size(16, 16)
        Me.X2Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y1.TabIndex = 10
        Me.X2Y1.TabStop = False
        '
        'X1Y10
        '
        Me.X1Y10.BackColor = System.Drawing.Color.Black
        Me.X1Y10.BackgroundImage = CType(resources.GetObject("X1Y10.BackgroundImage"), System.Drawing.Image)
        Me.X1Y10.Image = CType(resources.GetObject("X1Y10.Image"), System.Drawing.Image)
        Me.X1Y10.Location = New System.Drawing.Point(148, 27)
        Me.X1Y10.Name = "X1Y10"
        Me.X1Y10.Size = New System.Drawing.Size(16, 16)
        Me.X1Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y10.TabIndex = 9
        Me.X1Y10.TabStop = False
        '
        'X1Y9
        '
        Me.X1Y9.BackColor = System.Drawing.Color.Black
        Me.X1Y9.BackgroundImage = CType(resources.GetObject("X1Y9.BackgroundImage"), System.Drawing.Image)
        Me.X1Y9.Image = CType(resources.GetObject("X1Y9.Image"), System.Drawing.Image)
        Me.X1Y9.Location = New System.Drawing.Point(132, 27)
        Me.X1Y9.Name = "X1Y9"
        Me.X1Y9.Size = New System.Drawing.Size(16, 16)
        Me.X1Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y9.TabIndex = 8
        Me.X1Y9.TabStop = False
        '
        'X1Y8
        '
        Me.X1Y8.BackColor = System.Drawing.Color.Black
        Me.X1Y8.BackgroundImage = CType(resources.GetObject("X1Y8.BackgroundImage"), System.Drawing.Image)
        Me.X1Y8.Image = CType(resources.GetObject("X1Y8.Image"), System.Drawing.Image)
        Me.X1Y8.Location = New System.Drawing.Point(116, 27)
        Me.X1Y8.Name = "X1Y8"
        Me.X1Y8.Size = New System.Drawing.Size(16, 16)
        Me.X1Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y8.TabIndex = 7
        Me.X1Y8.TabStop = False
        '
        'X1Y7
        '
        Me.X1Y7.BackColor = System.Drawing.Color.Black
        Me.X1Y7.BackgroundImage = CType(resources.GetObject("X1Y7.BackgroundImage"), System.Drawing.Image)
        Me.X1Y7.Image = CType(resources.GetObject("X1Y7.Image"), System.Drawing.Image)
        Me.X1Y7.Location = New System.Drawing.Point(100, 27)
        Me.X1Y7.Name = "X1Y7"
        Me.X1Y7.Size = New System.Drawing.Size(16, 16)
        Me.X1Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y7.TabIndex = 6
        Me.X1Y7.TabStop = False
        '
        'X1Y6
        '
        Me.X1Y6.BackColor = System.Drawing.Color.Black
        Me.X1Y6.BackgroundImage = CType(resources.GetObject("X1Y6.BackgroundImage"), System.Drawing.Image)
        Me.X1Y6.Image = CType(resources.GetObject("X1Y6.Image"), System.Drawing.Image)
        Me.X1Y6.Location = New System.Drawing.Point(84, 27)
        Me.X1Y6.Name = "X1Y6"
        Me.X1Y6.Size = New System.Drawing.Size(16, 16)
        Me.X1Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y6.TabIndex = 5
        Me.X1Y6.TabStop = False
        '
        'X1Y5
        '
        Me.X1Y5.BackColor = System.Drawing.Color.Black
        Me.X1Y5.BackgroundImage = CType(resources.GetObject("X1Y5.BackgroundImage"), System.Drawing.Image)
        Me.X1Y5.Image = CType(resources.GetObject("X1Y5.Image"), System.Drawing.Image)
        Me.X1Y5.Location = New System.Drawing.Point(68, 27)
        Me.X1Y5.Name = "X1Y5"
        Me.X1Y5.Size = New System.Drawing.Size(16, 16)
        Me.X1Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y5.TabIndex = 4
        Me.X1Y5.TabStop = False
        '
        'X1Y4
        '
        Me.X1Y4.BackColor = System.Drawing.Color.Black
        Me.X1Y4.BackgroundImage = CType(resources.GetObject("X1Y4.BackgroundImage"), System.Drawing.Image)
        Me.X1Y4.Image = CType(resources.GetObject("X1Y4.Image"), System.Drawing.Image)
        Me.X1Y4.Location = New System.Drawing.Point(52, 27)
        Me.X1Y4.Name = "X1Y4"
        Me.X1Y4.Size = New System.Drawing.Size(16, 16)
        Me.X1Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y4.TabIndex = 3
        Me.X1Y4.TabStop = False
        '
        'X1Y3
        '
        Me.X1Y3.BackColor = System.Drawing.Color.Black
        Me.X1Y3.BackgroundImage = CType(resources.GetObject("X1Y3.BackgroundImage"), System.Drawing.Image)
        Me.X1Y3.Image = CType(resources.GetObject("X1Y3.Image"), System.Drawing.Image)
        Me.X1Y3.Location = New System.Drawing.Point(36, 27)
        Me.X1Y3.Name = "X1Y3"
        Me.X1Y3.Size = New System.Drawing.Size(16, 16)
        Me.X1Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y3.TabIndex = 2
        Me.X1Y3.TabStop = False
        '
        'X1Y2
        '
        Me.X1Y2.BackColor = System.Drawing.Color.Black
        Me.X1Y2.BackgroundImage = CType(resources.GetObject("X1Y2.BackgroundImage"), System.Drawing.Image)
        Me.X1Y2.Image = CType(resources.GetObject("X1Y2.Image"), System.Drawing.Image)
        Me.X1Y2.Location = New System.Drawing.Point(20, 27)
        Me.X1Y2.Name = "X1Y2"
        Me.X1Y2.Size = New System.Drawing.Size(16, 16)
        Me.X1Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y2.TabIndex = 1
        Me.X1Y2.TabStop = False
        '
        'X1Y1
        '
        Me.X1Y1.BackColor = System.Drawing.Color.Black
        Me.X1Y1.BackgroundImage = CType(resources.GetObject("X1Y1.BackgroundImage"), System.Drawing.Image)
        Me.X1Y1.Image = CType(resources.GetObject("X1Y1.Image"), System.Drawing.Image)
        Me.X1Y1.Location = New System.Drawing.Point(4, 27)
        Me.X1Y1.Name = "X1Y1"
        Me.X1Y1.Size = New System.Drawing.Size(16, 16)
        Me.X1Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y1.TabIndex = 0
        Me.X1Y1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DisplayNotification)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(345, 21)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Splash - Pre-release V5"
        '
        'GameEngine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(354, 261)
        Me.Controls.Add(Me.btnMute)
        Me.Controls.Add(Me.btnShop)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.X10Y10)
        Me.Controls.Add(Me.X10Y9)
        Me.Controls.Add(Me.X10Y8)
        Me.Controls.Add(Me.X10Y7)
        Me.Controls.Add(Me.X10Y5)
        Me.Controls.Add(Me.X10Y4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.X10Y3)
        Me.Controls.Add(Me.X10Y2)
        Me.Controls.Add(Me.X10Y1)
        Me.Controls.Add(Me.X10Y6)
        Me.Controls.Add(Me.X9Y10)
        Me.Controls.Add(Me.X9Y9)
        Me.Controls.Add(Me.X9Y8)
        Me.Controls.Add(Me.X9Y7)
        Me.Controls.Add(Me.X9Y5)
        Me.Controls.Add(Me.X9Y4)
        Me.Controls.Add(Me.X9Y3)
        Me.Controls.Add(Me.X9Y2)
        Me.Controls.Add(Me.X9Y1)
        Me.Controls.Add(Me.X9Y6)
        Me.Controls.Add(Me.X8Y10)
        Me.Controls.Add(Me.X8Y9)
        Me.Controls.Add(Me.X8Y8)
        Me.Controls.Add(Me.X8Y7)
        Me.Controls.Add(Me.X8Y5)
        Me.Controls.Add(Me.X8Y4)
        Me.Controls.Add(Me.X8Y3)
        Me.Controls.Add(Me.X8Y2)
        Me.Controls.Add(Me.X8Y1)
        Me.Controls.Add(Me.X8Y6)
        Me.Controls.Add(Me.X7Y10)
        Me.Controls.Add(Me.X7Y9)
        Me.Controls.Add(Me.X7Y8)
        Me.Controls.Add(Me.X7Y7)
        Me.Controls.Add(Me.X7Y5)
        Me.Controls.Add(Me.X7Y4)
        Me.Controls.Add(Me.X7Y3)
        Me.Controls.Add(Me.X7Y2)
        Me.Controls.Add(Me.X7Y1)
        Me.Controls.Add(Me.X7Y6)
        Me.Controls.Add(Me.X6Y10)
        Me.Controls.Add(Me.X6Y9)
        Me.Controls.Add(Me.X6Y8)
        Me.Controls.Add(Me.X6Y7)
        Me.Controls.Add(Me.X6Y5)
        Me.Controls.Add(Me.X6Y4)
        Me.Controls.Add(Me.X6Y3)
        Me.Controls.Add(Me.X6Y2)
        Me.Controls.Add(Me.X6Y1)
        Me.Controls.Add(Me.X6Y6)
        Me.Controls.Add(Me.X5Y10)
        Me.Controls.Add(Me.X5Y9)
        Me.Controls.Add(Me.X5Y8)
        Me.Controls.Add(Me.X5Y7)
        Me.Controls.Add(Me.X5Y5)
        Me.Controls.Add(Me.X5Y4)
        Me.Controls.Add(Me.X5Y3)
        Me.Controls.Add(Me.X5Y2)
        Me.Controls.Add(Me.X5Y1)
        Me.Controls.Add(Me.X5Y6)
        Me.Controls.Add(Me.X4Y10)
        Me.Controls.Add(Me.X4Y9)
        Me.Controls.Add(Me.X4Y8)
        Me.Controls.Add(Me.X4Y7)
        Me.Controls.Add(Me.X4Y6)
        Me.Controls.Add(Me.X4Y5)
        Me.Controls.Add(Me.X4Y4)
        Me.Controls.Add(Me.X4Y3)
        Me.Controls.Add(Me.X4Y2)
        Me.Controls.Add(Me.X4Y1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.X3Y10)
        Me.Controls.Add(Me.X3Y9)
        Me.Controls.Add(Me.X3Y8)
        Me.Controls.Add(Me.X3Y7)
        Me.Controls.Add(Me.X3Y5)
        Me.Controls.Add(Me.X3Y4)
        Me.Controls.Add(Me.X3Y3)
        Me.Controls.Add(Me.X3Y2)
        Me.Controls.Add(Me.X3Y1)
        Me.Controls.Add(Me.X3Y6)
        Me.Controls.Add(Me.InfoBox)
        Me.Controls.Add(Me.X2Y10)
        Me.Controls.Add(Me.X2Y9)
        Me.Controls.Add(Me.X2Y8)
        Me.Controls.Add(Me.X2Y7)
        Me.Controls.Add(Me.X2Y6)
        Me.Controls.Add(Me.X2Y5)
        Me.Controls.Add(Me.X2Y4)
        Me.Controls.Add(Me.X2Y3)
        Me.Controls.Add(Me.X2Y2)
        Me.Controls.Add(Me.X2Y1)
        Me.Controls.Add(Me.X1Y10)
        Me.Controls.Add(Me.X1Y9)
        Me.Controls.Add(Me.X1Y8)
        Me.Controls.Add(Me.X1Y7)
        Me.Controls.Add(Me.X1Y6)
        Me.Controls.Add(Me.X1Y5)
        Me.Controls.Add(Me.X1Y4)
        Me.Controls.Add(Me.X1Y3)
        Me.Controls.Add(Me.X1Y2)
        Me.Controls.Add(Me.X1Y1)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GameEngine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash"
        Me.TopMost = True
        Me.InfoBox.ResumeLayout(False)
        Me.InfoBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PicCursor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.bgplayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.X10Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents X1Y1 As PictureBox
    Friend WithEvents X1Y2 As PictureBox
    Friend WithEvents X1Y4 As PictureBox
    Friend WithEvents X1Y3 As PictureBox
    Friend WithEvents X1Y8 As PictureBox
    Friend WithEvents X1Y7 As PictureBox
    Friend WithEvents X1Y6 As PictureBox
    Friend WithEvents X1Y5 As PictureBox
    Friend WithEvents X1Y10 As PictureBox
    Friend WithEvents X1Y9 As PictureBox
    Friend WithEvents X2Y10 As PictureBox
    Friend WithEvents X2Y9 As PictureBox
    Friend WithEvents X2Y8 As PictureBox
    Friend WithEvents X2Y7 As PictureBox
    Friend WithEvents X2Y6 As PictureBox
    Friend WithEvents X2Y5 As PictureBox
    Friend WithEvents X2Y4 As PictureBox
    Friend WithEvents X2Y3 As PictureBox
    Friend WithEvents X2Y2 As PictureBox
    Friend WithEvents X2Y1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DisplayPos As Label
    Friend WithEvents X3Y10 As PictureBox
    Friend WithEvents X3Y9 As PictureBox
    Friend WithEvents X3Y8 As PictureBox
    Friend WithEvents X3Y7 As PictureBox
    Friend WithEvents X3Y5 As PictureBox
    Friend WithEvents X3Y4 As PictureBox
    Friend WithEvents X3Y3 As PictureBox
    Friend WithEvents X3Y2 As PictureBox
    Friend WithEvents X3Y1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents X3Y6 As PictureBox
    Friend WithEvents DisplayKey As Label
    Friend WithEvents InfoBox As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DisplayHealth As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents X5Y10 As PictureBox
    Friend WithEvents X5Y9 As PictureBox
    Friend WithEvents X5Y8 As PictureBox
    Friend WithEvents X5Y7 As PictureBox
    Friend WithEvents X5Y5 As PictureBox
    Friend WithEvents X5Y4 As PictureBox
    Friend WithEvents X5Y3 As PictureBox
    Friend WithEvents X5Y2 As PictureBox
    Friend WithEvents X5Y1 As PictureBox
    Friend WithEvents X5Y6 As PictureBox
    Friend WithEvents X4Y10 As PictureBox
    Friend WithEvents X4Y9 As PictureBox
    Friend WithEvents X4Y8 As PictureBox
    Friend WithEvents X4Y7 As PictureBox
    Friend WithEvents X4Y6 As PictureBox
    Friend WithEvents X4Y5 As PictureBox
    Friend WithEvents X4Y4 As PictureBox
    Friend WithEvents X4Y3 As PictureBox
    Friend WithEvents X4Y2 As PictureBox
    Friend WithEvents X4Y1 As PictureBox
    Friend WithEvents X6Y10 As PictureBox
    Friend WithEvents X6Y9 As PictureBox
    Friend WithEvents X6Y8 As PictureBox
    Friend WithEvents X6Y7 As PictureBox
    Friend WithEvents X6Y5 As PictureBox
    Friend WithEvents X6Y4 As PictureBox
    Friend WithEvents X6Y3 As PictureBox
    Friend WithEvents X6Y2 As PictureBox
    Friend WithEvents X6Y1 As PictureBox
    Friend WithEvents X6Y6 As PictureBox
    Friend WithEvents X7Y10 As PictureBox
    Friend WithEvents X7Y9 As PictureBox
    Friend WithEvents X7Y8 As PictureBox
    Friend WithEvents X7Y7 As PictureBox
    Friend WithEvents X7Y5 As PictureBox
    Friend WithEvents X7Y4 As PictureBox
    Friend WithEvents X7Y3 As PictureBox
    Friend WithEvents X7Y2 As PictureBox
    Friend WithEvents X7Y1 As PictureBox
    Friend WithEvents X7Y6 As PictureBox
    Friend WithEvents X8Y10 As PictureBox
    Friend WithEvents X8Y9 As PictureBox
    Friend WithEvents X8Y8 As PictureBox
    Friend WithEvents X8Y7 As PictureBox
    Friend WithEvents X8Y5 As PictureBox
    Friend WithEvents X8Y4 As PictureBox
    Friend WithEvents X8Y3 As PictureBox
    Friend WithEvents X8Y2 As PictureBox
    Friend WithEvents X8Y1 As PictureBox
    Friend WithEvents X8Y6 As PictureBox
    Friend WithEvents X9Y10 As PictureBox
    Friend WithEvents X9Y9 As PictureBox
    Friend WithEvents X9Y8 As PictureBox
    Friend WithEvents X9Y7 As PictureBox
    Friend WithEvents X9Y5 As PictureBox
    Friend WithEvents X9Y4 As PictureBox
    Friend WithEvents X9Y3 As PictureBox
    Friend WithEvents X9Y2 As PictureBox
    Friend WithEvents X9Y1 As PictureBox
    Friend WithEvents X9Y6 As PictureBox
    Friend WithEvents X10Y10 As PictureBox
    Friend WithEvents X10Y9 As PictureBox
    Friend WithEvents X10Y8 As PictureBox
    Friend WithEvents X10Y7 As PictureBox
    Friend WithEvents X10Y5 As PictureBox
    Friend WithEvents X10Y4 As PictureBox
    Friend WithEvents X10Y3 As PictureBox
    Friend WithEvents X10Y2 As PictureBox
    Friend WithEvents X10Y1 As PictureBox
    Friend WithEvents X10Y6 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DisplayArea As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DisplayLevel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsciiToKeyCharToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeleportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportCustomMapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InitialiseMapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplashMapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnShop As Button
    Friend WithEvents PicCursor As PictureBox
    Friend WithEvents lblCursor3 As Label
    Friend WithEvents lblCursor2 As Label
    Friend WithEvents lblCursor1 As Label
    Friend WithEvents lblCursorTitle As Label
    Friend WithEvents DisplayID As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents SavingExperimentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayNotification As Label
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bgplayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnMute As Button
    Friend WithEvents GroupBox4 As GroupBox
End Class
