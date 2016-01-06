<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.board_detect = New System.Windows.Forms.Button()
        Me.CommControlGroup = New System.Windows.Forms.GroupBox()
        Me.lbl_serial = New System.Windows.Forms.Label()
        Me.btn_test_2 = New System.Windows.Forms.Button()
        Me.btn_Dev_Test = New System.Windows.Forms.Button()
        Me.Serial_Text_Test = New System.Windows.Forms.RichTextBox()
        Me.btn_Send_Config = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Board_2 = New System.Windows.Forms.TabPage()
        Me.lbl_board_2 = New System.Windows.Forms.Label()
        Me.lbl_board_2_status = New System.Windows.Forms.Label()
        Me.board_2_Circuit_Control = New System.Windows.Forms.GroupBox()
        Me.board_2_ch2 = New System.Windows.Forms.GroupBox()
        Me.board_2_lbl6 = New System.Windows.Forms.Label()
        Me.board_2_scope_ch_2_gain = New System.Windows.Forms.ComboBox()
        Me.board_2_lbl5 = New System.Windows.Forms.Label()
        Me.board_2_lbl4 = New System.Windows.Forms.Label()
        Me.board_2_Ch_1 = New System.Windows.Forms.GroupBox()
        Me.board_2_lbl3 = New System.Windows.Forms.Label()
        Me.board_2_scope_ch_1_gain = New System.Windows.Forms.ComboBox()
        Me.board_2_lbl_2 = New System.Windows.Forms.Label()
        Me.board_2_lbl1 = New System.Windows.Forms.Label()
        Me.board_2_lbl_C1 = New System.Windows.Forms.Label()
        Me.board_2_C1 = New System.Windows.Forms.ComboBox()
        Me.board_4_R4 = New System.Windows.Forms.ComboBox()
        Me.board_2_lbl_C2 = New System.Windows.Forms.Label()
        Me.board_2_R4 = New System.Windows.Forms.Label()
        Me.board_2_C2 = New System.Windows.Forms.ComboBox()
        Me.board_4_R3 = New System.Windows.Forms.ComboBox()
        Me.board_2_lbl_R2 = New System.Windows.Forms.Label()
        Me.board_2_lbl_R3 = New System.Windows.Forms.Label()
        Me.board_4_R2 = New System.Windows.Forms.ComboBox()
        Me.board_4_R1 = New System.Windows.Forms.ComboBox()
        Me.board_2_lbl_R1 = New System.Windows.Forms.Label()
        Me.board_2_chematic = New System.Windows.Forms.PictureBox()
        Me.Board_1 = New System.Windows.Forms.TabPage()
        Me.lbl_board_1_status = New System.Windows.Forms.Label()
        Me.Circuit_Controls = New System.Windows.Forms.GroupBox()
        Me.brd_1_ch2 = New System.Windows.Forms.GroupBox()
        Me.board_1_lbl_2 = New System.Windows.Forms.Label()
        Me.brd_1_ch_2_gain = New System.Windows.Forms.ComboBox()
        Me.lbl_gain_2 = New System.Windows.Forms.Label()
        Me.Brd_1_Scope_Ch2 = New System.Windows.Forms.ComboBox()
        Me.lbl_Scope_1 = New System.Windows.Forms.Label()
        Me.brd_1_ch1 = New System.Windows.Forms.GroupBox()
        Me.board_1_lbl_1 = New System.Windows.Forms.Label()
        Me.brd_1_ch1_gain = New System.Windows.Forms.ComboBox()
        Me.lbl_gain_1 = New System.Windows.Forms.Label()
        Me.lbl_scope = New System.Windows.Forms.Label()
        Me.Brd_1_Scope = New System.Windows.Forms.ComboBox()
        Me.lbl5k_1 = New System.Windows.Forms.Label()
        Me.lbl_board_1 = New System.Windows.Forms.Label()
        Me.lbl_5k = New System.Windows.Forms.Label()
        Me.lbl_1k = New System.Windows.Forms.Label()
        Me.Brd_1_Res_Select = New System.Windows.Forms.ComboBox()
        Me.Lbl_19k = New System.Windows.Forms.Label()
        Me.lbl_A = New System.Windows.Forms.Label()
        Me.board_1_R3_enable = New System.Windows.Forms.ComboBox()
        Me.lbl_B = New System.Windows.Forms.Label()
        Me.lbl_D = New System.Windows.Forms.Label()
        Me.lbl_C = New System.Windows.Forms.Label()
        Me.Board_1_Image = New System.Windows.Forms.PictureBox()
        Me.Main_Tab_1 = New System.Windows.Forms.TabControl()
        Me.CommControlGroup.SuspendLayout()
        Me.Board_2.SuspendLayout()
        Me.board_2_Circuit_Control.SuspendLayout()
        Me.board_2_ch2.SuspendLayout()
        Me.board_2_Ch_1.SuspendLayout()
        CType(Me.board_2_chematic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Board_1.SuspendLayout()
        Me.Circuit_Controls.SuspendLayout()
        Me.brd_1_ch2.SuspendLayout()
        Me.brd_1_ch1.SuspendLayout()
        CType(Me.Board_1_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Main_Tab_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'board_detect
        '
        Me.board_detect.BackColor = System.Drawing.Color.LightBlue
        Me.board_detect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_detect.Location = New System.Drawing.Point(15, 19)
        Me.board_detect.Name = "board_detect"
        Me.board_detect.Size = New System.Drawing.Size(96, 23)
        Me.board_detect.TabIndex = 0
        Me.board_detect.Text = "Check Board "
        Me.board_detect.UseVisualStyleBackColor = False
        '
        'CommControlGroup
        '
        Me.CommControlGroup.Controls.Add(Me.lbl_serial)
        Me.CommControlGroup.Controls.Add(Me.btn_test_2)
        Me.CommControlGroup.Controls.Add(Me.btn_Dev_Test)
        Me.CommControlGroup.Controls.Add(Me.Serial_Text_Test)
        Me.CommControlGroup.Controls.Add(Me.btn_Send_Config)
        Me.CommControlGroup.Controls.Add(Me.board_detect)
        Me.CommControlGroup.Location = New System.Drawing.Point(21, 12)
        Me.CommControlGroup.Name = "CommControlGroup"
        Me.CommControlGroup.Size = New System.Drawing.Size(859, 65)
        Me.CommControlGroup.TabIndex = 1
        Me.CommControlGroup.TabStop = False
        Me.CommControlGroup.Text = "Communication Control"
        '
        'lbl_serial
        '
        Me.lbl_serial.AutoSize = True
        Me.lbl_serial.Location = New System.Drawing.Point(284, 24)
        Me.lbl_serial.Name = "lbl_serial"
        Me.lbl_serial.Size = New System.Drawing.Size(96, 13)
        Me.lbl_serial.TabIndex = 5
        Me.lbl_serial.Text = "Serial Port Monitor:"
        '
        'btn_test_2
        '
        Me.btn_test_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_test_2.Location = New System.Drawing.Point(740, 19)
        Me.btn_test_2.Name = "btn_test_2"
        Me.btn_test_2.Size = New System.Drawing.Size(87, 23)
        Me.btn_test_2.TabIndex = 4
        Me.btn_test_2.Text = "Logic Analyzer"
        Me.btn_test_2.UseVisualStyleBackColor = True
        '
        'btn_Dev_Test
        '
        Me.btn_Dev_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Dev_Test.Location = New System.Drawing.Point(659, 19)
        Me.btn_Dev_Test.Name = "btn_Dev_Test"
        Me.btn_Dev_Test.Size = New System.Drawing.Size(75, 23)
        Me.btn_Dev_Test.TabIndex = 3
        Me.btn_Dev_Test.Text = "Vellman"
        Me.btn_Dev_Test.UseVisualStyleBackColor = True
        '
        'Serial_Text_Test
        '
        Me.Serial_Text_Test.Location = New System.Drawing.Point(386, 19)
        Me.Serial_Text_Test.Name = "Serial_Text_Test"
        Me.Serial_Text_Test.Size = New System.Drawing.Size(255, 23)
        Me.Serial_Text_Test.TabIndex = 2
        Me.Serial_Text_Test.Text = ""
        '
        'btn_Send_Config
        '
        Me.btn_Send_Config.BackColor = System.Drawing.Color.LightBlue
        Me.btn_Send_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Send_Config.Location = New System.Drawing.Point(117, 19)
        Me.btn_Send_Config.Name = "btn_Send_Config"
        Me.btn_Send_Config.Size = New System.Drawing.Size(105, 23)
        Me.btn_Send_Config.TabIndex = 1
        Me.btn_Send_Config.Text = "Send Data"
        Me.btn_Send_Config.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Board_2
        '
        Me.Board_2.Controls.Add(Me.lbl_board_2)
        Me.Board_2.Controls.Add(Me.lbl_board_2_status)
        Me.Board_2.Controls.Add(Me.board_2_Circuit_Control)
        Me.Board_2.Controls.Add(Me.board_2_lbl_C1)
        Me.Board_2.Controls.Add(Me.board_2_C1)
        Me.Board_2.Controls.Add(Me.board_4_R4)
        Me.Board_2.Controls.Add(Me.board_2_lbl_C2)
        Me.Board_2.Controls.Add(Me.board_2_R4)
        Me.Board_2.Controls.Add(Me.board_2_C2)
        Me.Board_2.Controls.Add(Me.board_4_R3)
        Me.Board_2.Controls.Add(Me.board_2_lbl_R2)
        Me.Board_2.Controls.Add(Me.board_2_lbl_R3)
        Me.Board_2.Controls.Add(Me.board_4_R2)
        Me.Board_2.Controls.Add(Me.board_4_R1)
        Me.Board_2.Controls.Add(Me.board_2_lbl_R1)
        Me.Board_2.Controls.Add(Me.board_2_chematic)
        Me.Board_2.Location = New System.Drawing.Point(4, 22)
        Me.Board_2.Name = "Board_2"
        Me.Board_2.Padding = New System.Windows.Forms.Padding(3)
        Me.Board_2.Size = New System.Drawing.Size(851, 418)
        Me.Board_2.TabIndex = 1
        Me.Board_2.Text = "EE 233 Lab 2"
        Me.Board_2.UseVisualStyleBackColor = True
        '
        'lbl_board_2
        '
        Me.lbl_board_2.AutoSize = True
        Me.lbl_board_2.Location = New System.Drawing.Point(271, 17)
        Me.lbl_board_2.Name = "lbl_board_2"
        Me.lbl_board_2.Size = New System.Drawing.Size(94, 13)
        Me.lbl_board_2.TabIndex = 17
        Me.lbl_board_2.Text = "[ Sallen Key Filter ]"
        '
        'lbl_board_2_status
        '
        Me.lbl_board_2_status.AutoSize = True
        Me.lbl_board_2_status.BackColor = System.Drawing.Color.Red
        Me.lbl_board_2_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_board_2_status.ForeColor = System.Drawing.Color.White
        Me.lbl_board_2_status.Location = New System.Drawing.Point(6, 26)
        Me.lbl_board_2_status.Name = "lbl_board_2_status"
        Me.lbl_board_2_status.Size = New System.Drawing.Size(47, 15)
        Me.lbl_board_2_status.TabIndex = 16
        Me.lbl_board_2_status.Text = "Inactive"
        '
        'board_2_Circuit_Control
        '
        Me.board_2_Circuit_Control.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.board_2_Circuit_Control.Controls.Add(Me.board_2_ch2)
        Me.board_2_Circuit_Control.Controls.Add(Me.board_2_Ch_1)
        Me.board_2_Circuit_Control.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_2_Circuit_Control.Location = New System.Drawing.Point(540, 44)
        Me.board_2_Circuit_Control.Name = "board_2_Circuit_Control"
        Me.board_2_Circuit_Control.Size = New System.Drawing.Size(200, 340)
        Me.board_2_Circuit_Control.TabIndex = 2
        Me.board_2_Circuit_Control.TabStop = False
        Me.board_2_Circuit_Control.Text = "Circuit Controls"
        '
        'board_2_ch2
        '
        Me.board_2_ch2.Controls.Add(Me.board_2_lbl6)
        Me.board_2_ch2.Controls.Add(Me.board_2_scope_ch_2_gain)
        Me.board_2_ch2.Controls.Add(Me.board_2_lbl5)
        Me.board_2_ch2.Controls.Add(Me.board_2_lbl4)
        Me.board_2_ch2.Location = New System.Drawing.Point(19, 205)
        Me.board_2_ch2.Name = "board_2_ch2"
        Me.board_2_ch2.Size = New System.Drawing.Size(162, 124)
        Me.board_2_ch2.TabIndex = 5
        Me.board_2_ch2.TabStop = False
        Me.board_2_ch2.Text = "Scope Channel 2"
        '
        'board_2_lbl6
        '
        Me.board_2_lbl6.AutoSize = True
        Me.board_2_lbl6.Location = New System.Drawing.Point(6, 98)
        Me.board_2_lbl6.Name = "board_2_lbl6"
        Me.board_2_lbl6.Size = New System.Drawing.Size(119, 13)
        Me.board_2_lbl6.TabIndex = 6
        Me.board_2_lbl6.Text = "Match Gain in Vellemen"
        '
        'board_2_scope_ch_2_gain
        '
        Me.board_2_scope_ch_2_gain.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.board_2_scope_ch_2_gain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_2_scope_ch_2_gain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_2_scope_ch_2_gain.FormattingEnabled = True
        Me.board_2_scope_ch_2_gain.Items.AddRange(New Object() {"1X", "10X"})
        Me.board_2_scope_ch_2_gain.Location = New System.Drawing.Point(8, 69)
        Me.board_2_scope_ch_2_gain.Name = "board_2_scope_ch_2_gain"
        Me.board_2_scope_ch_2_gain.Size = New System.Drawing.Size(104, 21)
        Me.board_2_scope_ch_2_gain.TabIndex = 5
        '
        'board_2_lbl5
        '
        Me.board_2_lbl5.AutoSize = True
        Me.board_2_lbl5.Location = New System.Drawing.Point(6, 53)
        Me.board_2_lbl5.Name = "board_2_lbl5"
        Me.board_2_lbl5.Size = New System.Drawing.Size(51, 13)
        Me.board_2_lbl5.TabIndex = 4
        Me.board_2_lbl5.Text = "Ch2 Gain"
        '
        'board_2_lbl4
        '
        Me.board_2_lbl4.AutoSize = True
        Me.board_2_lbl4.Location = New System.Drawing.Point(3, 27)
        Me.board_2_lbl4.Name = "board_2_lbl4"
        Me.board_2_lbl4.Size = New System.Drawing.Size(142, 13)
        Me.board_2_lbl4.TabIndex = 3
        Me.board_2_lbl4.Text = "Oscilloscope Position: (OUT)"
        '
        'board_2_Ch_1
        '
        Me.board_2_Ch_1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.board_2_Ch_1.Controls.Add(Me.board_2_lbl3)
        Me.board_2_Ch_1.Controls.Add(Me.board_2_scope_ch_1_gain)
        Me.board_2_Ch_1.Controls.Add(Me.board_2_lbl_2)
        Me.board_2_Ch_1.Controls.Add(Me.board_2_lbl1)
        Me.board_2_Ch_1.Location = New System.Drawing.Point(19, 36)
        Me.board_2_Ch_1.Name = "board_2_Ch_1"
        Me.board_2_Ch_1.Size = New System.Drawing.Size(162, 123)
        Me.board_2_Ch_1.TabIndex = 4
        Me.board_2_Ch_1.TabStop = False
        Me.board_2_Ch_1.Text = "Scope Channel 1"
        '
        'board_2_lbl3
        '
        Me.board_2_lbl3.AutoSize = True
        Me.board_2_lbl3.Location = New System.Drawing.Point(5, 97)
        Me.board_2_lbl3.Name = "board_2_lbl3"
        Me.board_2_lbl3.Size = New System.Drawing.Size(119, 13)
        Me.board_2_lbl3.TabIndex = 4
        Me.board_2_lbl3.Text = "Match Gain in Vellemen"
        '
        'board_2_scope_ch_1_gain
        '
        Me.board_2_scope_ch_1_gain.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.board_2_scope_ch_1_gain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_2_scope_ch_1_gain.FormattingEnabled = True
        Me.board_2_scope_ch_1_gain.Items.AddRange(New Object() {"1X", "10X"})
        Me.board_2_scope_ch_1_gain.Location = New System.Drawing.Point(8, 71)
        Me.board_2_scope_ch_1_gain.Name = "board_2_scope_ch_1_gain"
        Me.board_2_scope_ch_1_gain.Size = New System.Drawing.Size(104, 21)
        Me.board_2_scope_ch_1_gain.TabIndex = 3
        '
        'board_2_lbl_2
        '
        Me.board_2_lbl_2.AutoSize = True
        Me.board_2_lbl_2.Location = New System.Drawing.Point(6, 54)
        Me.board_2_lbl_2.Name = "board_2_lbl_2"
        Me.board_2_lbl_2.Size = New System.Drawing.Size(51, 13)
        Me.board_2_lbl_2.TabIndex = 2
        Me.board_2_lbl_2.Text = "Ch1 Gain"
        '
        'board_2_lbl1
        '
        Me.board_2_lbl1.AutoSize = True
        Me.board_2_lbl1.Location = New System.Drawing.Point(6, 27)
        Me.board_2_lbl1.Name = "board_2_lbl1"
        Me.board_2_lbl1.Size = New System.Drawing.Size(130, 13)
        Me.board_2_lbl1.TabIndex = 0
        Me.board_2_lbl1.Text = "Oscilloscope Position: (IN)"
        '
        'board_2_lbl_C1
        '
        Me.board_2_lbl_C1.AutoSize = True
        Me.board_2_lbl_C1.Location = New System.Drawing.Point(177, 155)
        Me.board_2_lbl_C1.Name = "board_2_lbl_C1"
        Me.board_2_lbl_C1.Size = New System.Drawing.Size(20, 13)
        Me.board_2_lbl_C1.TabIndex = 15
        Me.board_2_lbl_C1.Text = "C1"
        '
        'board_2_C1
        '
        Me.board_2_C1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_2_C1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_2_C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_2_C1.FormattingEnabled = True
        Me.board_2_C1.Items.AddRange(New Object() {"0.01 uF", "0.1   uF", "0.22 uF"})
        Me.board_2_C1.Location = New System.Drawing.Point(139, 171)
        Me.board_2_C1.Name = "board_2_C1"
        Me.board_2_C1.Size = New System.Drawing.Size(58, 21)
        Me.board_2_C1.TabIndex = 14
        '
        'board_4_R4
        '
        Me.board_4_R4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_4_R4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_4_R4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_4_R4.FormattingEnabled = True
        Me.board_4_R4.Items.AddRange(New Object() {"1 K", "5.1 K", "10 K", "20 K", "27 K"})
        Me.board_4_R4.Location = New System.Drawing.Point(349, 196)
        Me.board_4_R4.Name = "board_4_R4"
        Me.board_4_R4.Size = New System.Drawing.Size(54, 21)
        Me.board_4_R4.TabIndex = 4
        '
        'board_2_lbl_C2
        '
        Me.board_2_lbl_C2.AutoSize = True
        Me.board_2_lbl_C2.Location = New System.Drawing.Point(205, 73)
        Me.board_2_lbl_C2.Name = "board_2_lbl_C2"
        Me.board_2_lbl_C2.Size = New System.Drawing.Size(20, 13)
        Me.board_2_lbl_C2.TabIndex = 13
        Me.board_2_lbl_C2.Text = "C2"
        '
        'board_2_R4
        '
        Me.board_2_R4.AutoSize = True
        Me.board_2_R4.Location = New System.Drawing.Point(363, 179)
        Me.board_2_R4.Name = "board_2_R4"
        Me.board_2_R4.Size = New System.Drawing.Size(21, 13)
        Me.board_2_R4.TabIndex = 5
        Me.board_2_R4.Text = "R4"
        '
        'board_2_C2
        '
        Me.board_2_C2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_2_C2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_2_C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_2_C2.FormattingEnabled = True
        Me.board_2_C2.Items.AddRange(New Object() {"0.01 uF", "0.1   uF", "0.22 uF"})
        Me.board_2_C2.Location = New System.Drawing.Point(229, 58)
        Me.board_2_C2.Name = "board_2_C2"
        Me.board_2_C2.Size = New System.Drawing.Size(65, 21)
        Me.board_2_C2.TabIndex = 12
        '
        'board_4_R3
        '
        Me.board_4_R3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_4_R3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_4_R3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_4_R3.FormattingEnabled = True
        Me.board_4_R3.Items.AddRange(New Object() {"1 K", "5.1 K", "10 K", "20 K", "27 K"})
        Me.board_4_R3.Location = New System.Drawing.Point(258, 196)
        Me.board_4_R3.Name = "board_4_R3"
        Me.board_4_R3.Size = New System.Drawing.Size(54, 21)
        Me.board_4_R3.TabIndex = 6
        '
        'board_2_lbl_R2
        '
        Me.board_2_lbl_R2.AutoSize = True
        Me.board_2_lbl_R2.Location = New System.Drawing.Point(124, 106)
        Me.board_2_lbl_R2.Name = "board_2_lbl_R2"
        Me.board_2_lbl_R2.Size = New System.Drawing.Size(21, 13)
        Me.board_2_lbl_R2.TabIndex = 11
        Me.board_2_lbl_R2.Text = "R2"
        '
        'board_2_lbl_R3
        '
        Me.board_2_lbl_R3.AutoSize = True
        Me.board_2_lbl_R3.Location = New System.Drawing.Point(273, 181)
        Me.board_2_lbl_R3.Name = "board_2_lbl_R3"
        Me.board_2_lbl_R3.Size = New System.Drawing.Size(21, 13)
        Me.board_2_lbl_R3.TabIndex = 7
        Me.board_2_lbl_R3.Text = "R3"
        '
        'board_4_R2
        '
        Me.board_4_R2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_4_R2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_4_R2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_4_R2.FormattingEnabled = True
        Me.board_4_R2.Items.AddRange(New Object() {"1 K", "5.1 K", "10 K", "20 K", "27 K"})
        Me.board_4_R2.Location = New System.Drawing.Point(108, 122)
        Me.board_4_R2.Name = "board_4_R2"
        Me.board_4_R2.Size = New System.Drawing.Size(54, 21)
        Me.board_4_R2.TabIndex = 10
        '
        'board_4_R1
        '
        Me.board_4_R1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_4_R1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_4_R1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_4_R1.FormattingEnabled = True
        Me.board_4_R1.Items.AddRange(New Object() {"1 K", "5.1 K", "10 K", "20 K", "27 K"})
        Me.board_4_R1.Location = New System.Drawing.Point(26, 122)
        Me.board_4_R1.Name = "board_4_R1"
        Me.board_4_R1.Size = New System.Drawing.Size(54, 21)
        Me.board_4_R1.TabIndex = 8
        '
        'board_2_lbl_R1
        '
        Me.board_2_lbl_R1.AutoSize = True
        Me.board_2_lbl_R1.Location = New System.Drawing.Point(42, 106)
        Me.board_2_lbl_R1.Name = "board_2_lbl_R1"
        Me.board_2_lbl_R1.Size = New System.Drawing.Size(21, 13)
        Me.board_2_lbl_R1.TabIndex = 9
        Me.board_2_lbl_R1.Text = "R1"
        '
        'board_2_chematic
        '
        Me.board_2_chematic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.board_2_chematic.Image = CType(resources.GetObject("board_2_chematic.Image"), System.Drawing.Image)
        Me.board_2_chematic.Location = New System.Drawing.Point(3, 44)
        Me.board_2_chematic.Name = "board_2_chematic"
        Me.board_2_chematic.Size = New System.Drawing.Size(462, 340)
        Me.board_2_chematic.TabIndex = 3
        Me.board_2_chematic.TabStop = False
        '
        'Board_1
        '
        Me.Board_1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Board_1.Controls.Add(Me.lbl_board_1_status)
        Me.Board_1.Controls.Add(Me.Circuit_Controls)
        Me.Board_1.Controls.Add(Me.lbl5k_1)
        Me.Board_1.Controls.Add(Me.lbl_board_1)
        Me.Board_1.Controls.Add(Me.lbl_5k)
        Me.Board_1.Controls.Add(Me.lbl_1k)
        Me.Board_1.Controls.Add(Me.Brd_1_Res_Select)
        Me.Board_1.Controls.Add(Me.Lbl_19k)
        Me.Board_1.Controls.Add(Me.lbl_A)
        Me.Board_1.Controls.Add(Me.board_1_R3_enable)
        Me.Board_1.Controls.Add(Me.lbl_B)
        Me.Board_1.Controls.Add(Me.lbl_D)
        Me.Board_1.Controls.Add(Me.lbl_C)
        Me.Board_1.Controls.Add(Me.Board_1_Image)
        Me.Board_1.Location = New System.Drawing.Point(4, 22)
        Me.Board_1.Name = "Board_1"
        Me.Board_1.Padding = New System.Windows.Forms.Padding(3)
        Me.Board_1.Size = New System.Drawing.Size(851, 418)
        Me.Board_1.TabIndex = 0
        Me.Board_1.Text = "EE 233 Lab 1"
        '
        'lbl_board_1_status
        '
        Me.lbl_board_1_status.AutoSize = True
        Me.lbl_board_1_status.BackColor = System.Drawing.Color.Red
        Me.lbl_board_1_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_board_1_status.ForeColor = System.Drawing.Color.White
        Me.lbl_board_1_status.Location = New System.Drawing.Point(11, 22)
        Me.lbl_board_1_status.Name = "lbl_board_1_status"
        Me.lbl_board_1_status.Size = New System.Drawing.Size(47, 15)
        Me.lbl_board_1_status.TabIndex = 12
        Me.lbl_board_1_status.Text = "Inactive"
        '
        'Circuit_Controls
        '
        Me.Circuit_Controls.Controls.Add(Me.brd_1_ch2)
        Me.Circuit_Controls.Controls.Add(Me.brd_1_ch1)
        Me.Circuit_Controls.Location = New System.Drawing.Point(540, 40)
        Me.Circuit_Controls.Name = "Circuit_Controls"
        Me.Circuit_Controls.Size = New System.Drawing.Size(200, 359)
        Me.Circuit_Controls.TabIndex = 2
        Me.Circuit_Controls.TabStop = False
        Me.Circuit_Controls.Text = "Circuit Controls"
        '
        'brd_1_ch2
        '
        Me.brd_1_ch2.Controls.Add(Me.board_1_lbl_2)
        Me.brd_1_ch2.Controls.Add(Me.brd_1_ch_2_gain)
        Me.brd_1_ch2.Controls.Add(Me.lbl_gain_2)
        Me.brd_1_ch2.Controls.Add(Me.Brd_1_Scope_Ch2)
        Me.brd_1_ch2.Controls.Add(Me.lbl_Scope_1)
        Me.brd_1_ch2.Location = New System.Drawing.Point(19, 205)
        Me.brd_1_ch2.Name = "brd_1_ch2"
        Me.brd_1_ch2.Size = New System.Drawing.Size(162, 139)
        Me.brd_1_ch2.TabIndex = 5
        Me.brd_1_ch2.TabStop = False
        Me.brd_1_ch2.Text = "Scope Channel 2"
        '
        'board_1_lbl_2
        '
        Me.board_1_lbl_2.AutoSize = True
        Me.board_1_lbl_2.Location = New System.Drawing.Point(6, 109)
        Me.board_1_lbl_2.Name = "board_1_lbl_2"
        Me.board_1_lbl_2.Size = New System.Drawing.Size(119, 13)
        Me.board_1_lbl_2.TabIndex = 6
        Me.board_1_lbl_2.Text = "Match Gain in Vellemen"
        '
        'brd_1_ch_2_gain
        '
        Me.brd_1_ch_2_gain.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.brd_1_ch_2_gain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.brd_1_ch_2_gain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brd_1_ch_2_gain.FormattingEnabled = True
        Me.brd_1_ch_2_gain.Items.AddRange(New Object() {"1X", "10X"})
        Me.brd_1_ch_2_gain.Location = New System.Drawing.Point(6, 85)
        Me.brd_1_ch_2_gain.Name = "brd_1_ch_2_gain"
        Me.brd_1_ch_2_gain.Size = New System.Drawing.Size(104, 21)
        Me.brd_1_ch_2_gain.TabIndex = 5
        '
        'lbl_gain_2
        '
        Me.lbl_gain_2.AutoSize = True
        Me.lbl_gain_2.Location = New System.Drawing.Point(6, 67)
        Me.lbl_gain_2.Name = "lbl_gain_2"
        Me.lbl_gain_2.Size = New System.Drawing.Size(51, 13)
        Me.lbl_gain_2.TabIndex = 4
        Me.lbl_gain_2.Text = "Ch2 Gain"
        '
        'Brd_1_Scope_Ch2
        '
        Me.Brd_1_Scope_Ch2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Brd_1_Scope_Ch2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Brd_1_Scope_Ch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Brd_1_Scope_Ch2.FormattingEnabled = True
        Me.Brd_1_Scope_Ch2.Items.AddRange(New Object() {"(A)", "(B)", "(C)", "(D)"})
        Me.Brd_1_Scope_Ch2.Location = New System.Drawing.Point(6, 43)
        Me.Brd_1_Scope_Ch2.Name = "Brd_1_Scope_Ch2"
        Me.Brd_1_Scope_Ch2.Size = New System.Drawing.Size(104, 21)
        Me.Brd_1_Scope_Ch2.TabIndex = 2
        '
        'lbl_Scope_1
        '
        Me.lbl_Scope_1.AutoSize = True
        Me.lbl_Scope_1.Location = New System.Drawing.Point(3, 27)
        Me.lbl_Scope_1.Name = "lbl_Scope_1"
        Me.lbl_Scope_1.Size = New System.Drawing.Size(107, 13)
        Me.lbl_Scope_1.TabIndex = 3
        Me.lbl_Scope_1.Text = "Oscilloscope Position"
        '
        'brd_1_ch1
        '
        Me.brd_1_ch1.Controls.Add(Me.board_1_lbl_1)
        Me.brd_1_ch1.Controls.Add(Me.brd_1_ch1_gain)
        Me.brd_1_ch1.Controls.Add(Me.lbl_gain_1)
        Me.brd_1_ch1.Controls.Add(Me.lbl_scope)
        Me.brd_1_ch1.Controls.Add(Me.Brd_1_Scope)
        Me.brd_1_ch1.Location = New System.Drawing.Point(19, 36)
        Me.brd_1_ch1.Name = "brd_1_ch1"
        Me.brd_1_ch1.Size = New System.Drawing.Size(162, 135)
        Me.brd_1_ch1.TabIndex = 4
        Me.brd_1_ch1.TabStop = False
        Me.brd_1_ch1.Text = "Scope Channel 1"
        '
        'board_1_lbl_1
        '
        Me.board_1_lbl_1.AutoSize = True
        Me.board_1_lbl_1.Location = New System.Drawing.Point(6, 108)
        Me.board_1_lbl_1.Name = "board_1_lbl_1"
        Me.board_1_lbl_1.Size = New System.Drawing.Size(119, 13)
        Me.board_1_lbl_1.TabIndex = 4
        Me.board_1_lbl_1.Text = "Match Gain in Vellemen"
        '
        'brd_1_ch1_gain
        '
        Me.brd_1_ch1_gain.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.brd_1_ch1_gain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.brd_1_ch1_gain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brd_1_ch1_gain.FormattingEnabled = True
        Me.brd_1_ch1_gain.Items.AddRange(New Object() {"1X", "10X"})
        Me.brd_1_ch1_gain.Location = New System.Drawing.Point(9, 84)
        Me.brd_1_ch1_gain.Name = "brd_1_ch1_gain"
        Me.brd_1_ch1_gain.Size = New System.Drawing.Size(104, 21)
        Me.brd_1_ch1_gain.TabIndex = 3
        '
        'lbl_gain_1
        '
        Me.lbl_gain_1.AutoSize = True
        Me.lbl_gain_1.Location = New System.Drawing.Point(6, 68)
        Me.lbl_gain_1.Name = "lbl_gain_1"
        Me.lbl_gain_1.Size = New System.Drawing.Size(51, 13)
        Me.lbl_gain_1.TabIndex = 2
        Me.lbl_gain_1.Text = "Ch1 Gain"
        '
        'lbl_scope
        '
        Me.lbl_scope.AutoSize = True
        Me.lbl_scope.Location = New System.Drawing.Point(6, 27)
        Me.lbl_scope.Name = "lbl_scope"
        Me.lbl_scope.Size = New System.Drawing.Size(107, 13)
        Me.lbl_scope.TabIndex = 0
        Me.lbl_scope.Text = "Oscilloscope Position"
        '
        'Brd_1_Scope
        '
        Me.Brd_1_Scope.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Brd_1_Scope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Brd_1_Scope.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Brd_1_Scope.FormattingEnabled = True
        Me.Brd_1_Scope.Items.AddRange(New Object() {"(A)", "(B)", "(C)", "(D)"})
        Me.Brd_1_Scope.Location = New System.Drawing.Point(9, 43)
        Me.Brd_1_Scope.Name = "Brd_1_Scope"
        Me.Brd_1_Scope.Size = New System.Drawing.Size(104, 21)
        Me.Brd_1_Scope.TabIndex = 1
        '
        'lbl5k_1
        '
        Me.lbl5k_1.AutoSize = True
        Me.lbl5k_1.Location = New System.Drawing.Point(288, 181)
        Me.lbl5k_1.Name = "lbl5k_1"
        Me.lbl5k_1.Size = New System.Drawing.Size(22, 13)
        Me.lbl5k_1.TabIndex = 11
        Me.lbl5k_1.Text = "5 k"
        '
        'lbl_board_1
        '
        Me.lbl_board_1.AutoSize = True
        Me.lbl_board_1.Location = New System.Drawing.Point(275, 14)
        Me.lbl_board_1.Name = "lbl_board_1"
        Me.lbl_board_1.Size = New System.Drawing.Size(113, 13)
        Me.lbl_board_1.TabIndex = 0
        Me.lbl_board_1.Text = "[ Two Stage Amplifier ]"
        '
        'lbl_5k
        '
        Me.lbl_5k.AutoSize = True
        Me.lbl_5k.Location = New System.Drawing.Point(237, 109)
        Me.lbl_5k.Name = "lbl_5k"
        Me.lbl_5k.Size = New System.Drawing.Size(22, 13)
        Me.lbl_5k.TabIndex = 10
        Me.lbl_5k.Text = "5 k"
        '
        'lbl_1k
        '
        Me.lbl_1k.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_1k.AutoSize = True
        Me.lbl_1k.Location = New System.Drawing.Point(54, 195)
        Me.lbl_1k.Name = "lbl_1k"
        Me.lbl_1k.Size = New System.Drawing.Size(22, 13)
        Me.lbl_1k.TabIndex = 9
        Me.lbl_1k.Text = "1 k"
        '
        'Brd_1_Res_Select
        '
        Me.Brd_1_Res_Select.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Brd_1_Res_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Brd_1_Res_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Brd_1_Res_Select.FormattingEnabled = True
        Me.Brd_1_Res_Select.Items.AddRange(New Object() {"1 K", "2 K", "3 K", "4 K", "5 K", "6 K", "7 K", "8 K", "9 K", "10 K", "short"})
        Me.Brd_1_Res_Select.Location = New System.Drawing.Point(287, 76)
        Me.Brd_1_Res_Select.Name = "Brd_1_Res_Select"
        Me.Brd_1_Res_Select.Size = New System.Drawing.Size(64, 21)
        Me.Brd_1_Res_Select.TabIndex = 1
        '
        'Lbl_19k
        '
        Me.Lbl_19k.AutoSize = True
        Me.Lbl_19k.Location = New System.Drawing.Point(108, 184)
        Me.Lbl_19k.Name = "Lbl_19k"
        Me.Lbl_19k.Size = New System.Drawing.Size(28, 13)
        Me.Lbl_19k.TabIndex = 8
        Me.Lbl_19k.Text = "19 k"
        '
        'lbl_A
        '
        Me.lbl_A.AutoSize = True
        Me.lbl_A.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_A.Location = New System.Drawing.Point(63, 109)
        Me.lbl_A.Name = "lbl_A"
        Me.lbl_A.Size = New System.Drawing.Size(20, 13)
        Me.lbl_A.TabIndex = 3
        Me.lbl_A.Text = "(A)"
        '
        'board_1_R3_enable
        '
        Me.board_1_R3_enable.BackColor = System.Drawing.SystemColors.ControlLight
        Me.board_1_R3_enable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.board_1_R3_enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.board_1_R3_enable.FormattingEnabled = True
        Me.board_1_R3_enable.Items.AddRange(New Object() {"5 k", "Open"})
        Me.board_1_R3_enable.Location = New System.Drawing.Point(219, 135)
        Me.board_1_R3_enable.Name = "board_1_R3_enable"
        Me.board_1_R3_enable.Size = New System.Drawing.Size(52, 21)
        Me.board_1_R3_enable.TabIndex = 7
        '
        'lbl_B
        '
        Me.lbl_B.AutoSize = True
        Me.lbl_B.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_B.Location = New System.Drawing.Point(171, 119)
        Me.lbl_B.Name = "lbl_B"
        Me.lbl_B.Size = New System.Drawing.Size(20, 13)
        Me.lbl_B.TabIndex = 4
        Me.lbl_B.Text = "(B)"
        '
        'lbl_D
        '
        Me.lbl_D.AutoSize = True
        Me.lbl_D.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_D.Location = New System.Drawing.Point(402, 143)
        Me.lbl_D.Name = "lbl_D"
        Me.lbl_D.Size = New System.Drawing.Size(21, 13)
        Me.lbl_D.TabIndex = 6
        Me.lbl_D.Text = "(D)"
        '
        'lbl_C
        '
        Me.lbl_C.AutoSize = True
        Me.lbl_C.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_C.Location = New System.Drawing.Point(284, 160)
        Me.lbl_C.Name = "lbl_C"
        Me.lbl_C.Size = New System.Drawing.Size(20, 13)
        Me.lbl_C.TabIndex = 5
        Me.lbl_C.Text = "(C)"
        '
        'Board_1_Image
        '
        Me.Board_1_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Board_1_Image.Image = CType(resources.GetObject("Board_1_Image.Image"), System.Drawing.Image)
        Me.Board_1_Image.Location = New System.Drawing.Point(11, 40)
        Me.Board_1_Image.Name = "Board_1_Image"
        Me.Board_1_Image.Size = New System.Drawing.Size(450, 359)
        Me.Board_1_Image.TabIndex = 0
        Me.Board_1_Image.TabStop = False
        '
        'Main_Tab_1
        '
        Me.Main_Tab_1.Controls.Add(Me.Board_1)
        Me.Main_Tab_1.Controls.Add(Me.Board_2)
        Me.Main_Tab_1.Location = New System.Drawing.Point(21, 83)
        Me.Main_Tab_1.Name = "Main_Tab_1"
        Me.Main_Tab_1.SelectedIndex = 0
        Me.Main_Tab_1.Size = New System.Drawing.Size(859, 444)
        Me.Main_Tab_1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(900, 540)
        Me.Controls.Add(Me.Main_Tab_1)
        Me.Controls.Add(Me.CommControlGroup)
        Me.Name = "Form1"
        Me.Text = "Remote EE Lab"
        Me.CommControlGroup.ResumeLayout(False)
        Me.CommControlGroup.PerformLayout()
        Me.Board_2.ResumeLayout(False)
        Me.Board_2.PerformLayout()
        Me.board_2_Circuit_Control.ResumeLayout(False)
        Me.board_2_ch2.ResumeLayout(False)
        Me.board_2_ch2.PerformLayout()
        Me.board_2_Ch_1.ResumeLayout(False)
        Me.board_2_Ch_1.PerformLayout()
        CType(Me.board_2_chematic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Board_1.ResumeLayout(False)
        Me.Board_1.PerformLayout()
        Me.Circuit_Controls.ResumeLayout(False)
        Me.brd_1_ch2.ResumeLayout(False)
        Me.brd_1_ch2.PerformLayout()
        Me.brd_1_ch1.ResumeLayout(False)
        Me.brd_1_ch1.PerformLayout()
        CType(Me.Board_1_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Main_Tab_1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents board_detect As System.Windows.Forms.Button
    Friend WithEvents CommControlGroup As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Send_Config As System.Windows.Forms.Button
    Friend WithEvents Serial_Text_Test As System.Windows.Forms.RichTextBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents btn_Dev_Test As System.Windows.Forms.Button
    Friend WithEvents btn_test_2 As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Board_2 As System.Windows.Forms.TabPage
    Friend WithEvents lbl_board_2 As System.Windows.Forms.Label
    Friend WithEvents lbl_board_2_status As System.Windows.Forms.Label
    Friend WithEvents board_2_Circuit_Control As System.Windows.Forms.GroupBox
    Friend WithEvents board_2_ch2 As System.Windows.Forms.GroupBox
    Friend WithEvents board_2_lbl6 As System.Windows.Forms.Label
    Friend WithEvents board_2_scope_ch_2_gain As System.Windows.Forms.ComboBox
    Friend WithEvents board_2_lbl5 As System.Windows.Forms.Label
    Friend WithEvents board_2_lbl4 As System.Windows.Forms.Label
    Friend WithEvents board_2_Ch_1 As System.Windows.Forms.GroupBox
    Friend WithEvents board_2_lbl3 As System.Windows.Forms.Label
    Friend WithEvents board_2_scope_ch_1_gain As System.Windows.Forms.ComboBox
    Friend WithEvents board_2_lbl_2 As System.Windows.Forms.Label
    Friend WithEvents board_2_lbl1 As System.Windows.Forms.Label
    Friend WithEvents board_2_lbl_C1 As System.Windows.Forms.Label
    Friend WithEvents board_2_C1 As System.Windows.Forms.ComboBox
    Friend WithEvents board_4_R4 As System.Windows.Forms.ComboBox
    Friend WithEvents board_2_lbl_C2 As System.Windows.Forms.Label
    Friend WithEvents board_2_R4 As System.Windows.Forms.Label
    Friend WithEvents board_2_C2 As System.Windows.Forms.ComboBox
    Friend WithEvents board_4_R3 As System.Windows.Forms.ComboBox
    Friend WithEvents board_2_lbl_R2 As System.Windows.Forms.Label
    Friend WithEvents board_2_lbl_R3 As System.Windows.Forms.Label
    Friend WithEvents board_4_R2 As System.Windows.Forms.ComboBox
    Friend WithEvents board_4_R1 As System.Windows.Forms.ComboBox
    Friend WithEvents board_2_lbl_R1 As System.Windows.Forms.Label
    Friend WithEvents board_2_chematic As System.Windows.Forms.PictureBox
    Friend WithEvents Board_1 As System.Windows.Forms.TabPage
    Friend WithEvents lbl_board_1_status As System.Windows.Forms.Label
    Friend WithEvents Circuit_Controls As System.Windows.Forms.GroupBox
    Friend WithEvents brd_1_ch2 As System.Windows.Forms.GroupBox
    Friend WithEvents board_1_lbl_2 As System.Windows.Forms.Label
    Friend WithEvents brd_1_ch_2_gain As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_gain_2 As System.Windows.Forms.Label
    Friend WithEvents Brd_1_Scope_Ch2 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Scope_1 As System.Windows.Forms.Label
    Friend WithEvents brd_1_ch1 As System.Windows.Forms.GroupBox
    Friend WithEvents board_1_lbl_1 As System.Windows.Forms.Label
    Friend WithEvents brd_1_ch1_gain As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_gain_1 As System.Windows.Forms.Label
    Friend WithEvents lbl_scope As System.Windows.Forms.Label
    Friend WithEvents Brd_1_Scope As System.Windows.Forms.ComboBox
    Friend WithEvents lbl5k_1 As System.Windows.Forms.Label
    Friend WithEvents lbl_board_1 As System.Windows.Forms.Label
    Friend WithEvents lbl_5k As System.Windows.Forms.Label
    Friend WithEvents lbl_1k As System.Windows.Forms.Label
    Friend WithEvents Brd_1_Res_Select As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_19k As System.Windows.Forms.Label
    Friend WithEvents lbl_A As System.Windows.Forms.Label
    Friend WithEvents board_1_R3_enable As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_B As System.Windows.Forms.Label
    Friend WithEvents lbl_D As System.Windows.Forms.Label
    Friend WithEvents lbl_C As System.Windows.Forms.Label
    Friend WithEvents Board_1_Image As System.Windows.Forms.PictureBox
    Friend WithEvents Main_Tab_1 As System.Windows.Forms.TabControl
    Friend WithEvents lbl_serial As System.Windows.Forms.Label

End Class
