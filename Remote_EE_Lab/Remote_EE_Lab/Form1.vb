Public Class Form1
    Dim Serial_Message As String = "test_message"
    Dim boardID As String = "null"
    Dim temp_read As String = "null"
    Dim USB_port As String = "COM4"

    'Declare the variables for Board_1
    Dim Board_1_Serial_Message As String = "board_1,01,1,4,4,01,01" 'default message
    Dim Board_1_R1_State As String = "01"
    Dim Board_1_R3_State As String = "1"
    Dim Board_1_Scope_Placement_Ch1 As String = "4"
    Dim Board_1_Scope_Placement_Ch2 As String = "4"
    Dim Board_1_Scope_Ch1_gain As String = "01"
    Dim Board_1_Scope_Ch2_gain As String = "01"


    'Declare the variables for Board_2
    Dim Board_2_Serial_Message As String = "board_2,1,1,1,1,1,1,01,01" 'default message
    Dim Board_2_R1_State As String = "1"
    Dim Board_2_R2_State As String = "1"
    Dim Board_2_R3_State As String = "1"
    Dim Board_2_R4_State As String = "1"
    Dim Board_2_C1_State As String = "1"
    Dim Board_2_C2_State As String = "1"
    Dim Board_2_Scope_Ch1_gain As String = "01"
    Dim Board_2_Scope_Ch2_gain As String = "01"

    'Declare the variables for Board_5
    Dim Board_5_Serial_Message As String = "board_5,1,1,1" 'default message
    Dim Board_5_R2_State As String = "1"
    Dim Board_5_R3_State As String = "1"
    Dim Board_5_C1_State As String = "1"


    Private Sub btn_Dev_Test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Dev_Test.Click
        Shell("C:\Program Files (x86)\Velleman\PcLab2000LT\PcLab2000LT.exe")

    End Sub



    Private Sub btn_test_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_test_2.Click
        Shell("C:\Program Files (x86)\LogicPort\LogicPort.exe")
    End Sub


    'Board ID Check
    Private Sub board_detect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_detect.Click
        Try
            Dim SendCode As String = "boardID" 'request message to retreive the board ID from Arduino
            boardID = "null"
            SerialPort1.PortName = USB_port
            SerialPort1.Open()
            SerialPort1.Write(SendCode)
            boardID = SerialPort1.ReadLine()
            SerialPort1.Close()
            Serial_Text_Test.Text = boardID
            Panel_Enable(boardID)
        Catch ex As Exception
        End Try

    End Sub

    Sub Panel_Enable(ByVal board As String)
        Try
            Dim Board_IDNFR As String = board.Substring(19, 8)
            Select Case Board_IDNFR
                Case "00000000"
                    'do something
                    Deactivate()
                    Serial_Text_Test.Text = "No board is present: " + Board_IDNFR
                Case "00000001"
                    'do something
                    Board1.SelectTab(0)
                    Deactivate()
                    lbl_board_1_status.BackColor = Color.Green
                    lbl_board_1_status.Text = "Active"
                    Serial_Text_Test.Text = Board_IDNFR
                Case "00000010"
                    'do something
                    Board1.SelectTab(1)
                    Deactivate()
                    lbl_board_2_status.BackColor = Color.Green
                    lbl_board_2_status.Text = "Active"
                    Serial_Text_Test.Text = Board_IDNFR
                Case "00000101" 'Daughterboard 5: Integrator/Low-Pass Filter
                    'do something
                    Board1.SelectTab(5)
                    Deactivate()
                    lbl_board_5_status.BackColor = Color.Green
                    lbl_board_5_status.Text = "Active"
                    Serial_Text_Test.Text = Board_IDNFR
                Case Else
                    'don't do anything
                    Deactivate()
                    Serial_Text_Test.Text = Board_IDNFR
            End Select
        Catch ex As Exception
            Serial_Text_Test.Text = "WARNING: Recheck Board ID"
        End Try
    End Sub

    Private Sub Deactivate()
        lbl_board_1_status.BackColor = Color.Red
        lbl_board_1_status.Text = "Inactive"
        lbl_board_2_status.BackColor = Color.Red
        lbl_board_2_status.Text = "Inactive"
        lbl_board_3a_status.BackColor = Color.Red
        lbl_board_3a_status.Text = "Inactive"
        lbl_board_3b_status.BackColor = Color.Red
        lbl_board_3b_status.Text = "Inactive"
        lbl_board_4_status.BackColor = Color.Red
        lbl_board_4_status.Text = "Inactive"
        lbl_board_5_status.BackColor = Color.Red
        lbl_board_5_status.Text = "Inactive"
        lbl_board_6_status.BackColor = Color.Red
        lbl_board_6_status.Text = "Inactive"
        lbl_board_7_status.BackColor = Color.Red
        lbl_board_7_status.Text = "Inactive"
    End Sub



    'Send Serial Message
    Private Sub btn_Send_Config_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Send_Config.Click

        'Check if the correct board is connected
        Try
            Dim SendCode As String = "boardID" 'request message to retreive the board ID from Arduino
            boardID = "null"
            SerialPort1.PortName = USB_port
            SerialPort1.Open()
            SerialPort1.Write(SendCode)
            boardID = SerialPort1.ReadLine()
            SerialPort1.Close()
            Serial_Text_Test.Text = boardID
            Panel_Enable(boardID)
        Catch ex As Exception
        End Try

        Try
            Select Case boardID.Substring(19, 8)
                Case "00000000"
                    lbl_board_1_status.BackColor = Color.Red
                    lbl_board_1_status.Text = "Inactive"
                    lbl_board_2_status.BackColor = Color.Red
                    lbl_board_2_status.Text = "Inactive"
                    Serial_Text_Test.Text = "WARNING: No board is present"
                Case "00000001"
                    Serial_Message = Board_1_Serial_Message
                Case "00000010"
                    Serial_Message = Board_2_Serial_Message
                Case "00000101"
                    Serial_Message = Board_5_Serial_Message
                Case Else
                    'don't do anything
                    Serial_Text_Test.Text = "WARNING: No board is present"
            End Select
        Catch ex As Exception
            Serial_Text_Test.Text = "WARNING: Resend the message"
        End Try

        Try
            SerialPort1.PortName = USB_port
            SerialPort1.Open()
            SerialPort1.WriteLine(Serial_Message)
            SerialPort1.Close()
        Catch ex As Exception
        End Try

        'Change the Button color back to blue, to indicate
        'that the configuration changes have been noted
        btn_Send_Config.BackColor = Color.LightBlue
    End Sub







    'Board 2 Subroutines 

    'Board_3: Serial Message Compiler
    'This subroutine takes the individual board_2 variables and
    'combines them into one string.
    Sub Board_1_Compile_Serial_Message()
        Board_1_Serial_Message = "board_1," + Board_1_R1_State + "," +
                                 Board_1_R3_State + "," +
                                 Board_1_Scope_Placement_Ch1 + "," +
                                 Board_1_Scope_Placement_Ch2 + "," +
                                 Board_1_Scope_Ch1_gain + "," +
                                 Board_1_Scope_Ch2_gain
        'this statement exists exclusively for debuginng purposes
        Serial_Text_Test.Text = Board_1_Serial_Message
        'Change the 'Send Data' button collor to orange, to indicate that
        'a change in the board configuration has occured.
        btn_Send_Config.BackColor = Color.Orange
    End Sub


    'Board_1: Scope CH1 placement
    Private Sub Brd_1_Scope_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Brd_1_Scope.SelectedIndexChanged
        If Brd_1_Scope.SelectedIndex = 0 Then
            Board_1_Scope_Placement_Ch1 = "1"
        ElseIf Brd_1_Scope.SelectedIndex = 1 Then
            Board_1_Scope_Placement_Ch1 = "2"
        ElseIf Brd_1_Scope.SelectedIndex = 2 Then
            Board_1_Scope_Placement_Ch1 = "3"
        Else
            Board_1_Scope_Placement_Ch1 = "4"
        End If
        'Call the message compiler
        Board_1_Compile_Serial_Message()

    End Sub

    'Board_1: Scope CH2 placement
    Private Sub Brd_1_Scope_Ch2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Brd_1_Scope_Ch2.SelectedIndexChanged
        If Brd_1_Scope_Ch2.SelectedIndex = 0 Then
            Board_1_Scope_Placement_Ch2 = "1"
        ElseIf Brd_1_Scope_Ch2.SelectedIndex = 1 Then
            Board_1_Scope_Placement_Ch2 = "2"
        ElseIf Brd_1_Scope_Ch2.SelectedIndex = 2 Then
            Board_1_Scope_Placement_Ch2 = "3"
        Else
            Board_1_Scope_Placement_Ch2 = "4"
        End If
        'Call the message compiler
        Board_1_Compile_Serial_Message()
    End Sub


    Private Sub board_1_R3_enable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_1_R3_enable.SelectedIndexChanged
        If board_1_R3_enable.SelectedIndex = 0 Then
            Board_1_R3_State = "1"
        Else
            Board_1_R3_State = "0"
        End If
        'Call the message compiler
        Board_1_Compile_Serial_Message()
    End Sub


    Private Sub Brd_1_Res_Select_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Brd_1_Res_Select.SelectedIndexChanged
        If Brd_1_Res_Select.SelectedIndex = 0 Then
            Board_1_R1_State = "01"
        ElseIf Brd_1_Res_Select.SelectedIndex = 1 Then
            Board_1_R1_State = "02"
        ElseIf Brd_1_Res_Select.SelectedIndex = 2 Then
            Board_1_R1_State = "03"
        ElseIf Brd_1_Res_Select.SelectedIndex = 3 Then
            Board_1_R1_State = "04"
        ElseIf Brd_1_Res_Select.SelectedIndex = 4 Then
            Board_1_R1_State = "05"
        ElseIf Brd_1_Res_Select.SelectedIndex = 5 Then
            Board_1_R1_State = "06"
        ElseIf Brd_1_Res_Select.SelectedIndex = 6 Then
            Board_1_R1_State = "07"
        ElseIf Brd_1_Res_Select.SelectedIndex = 7 Then
            Board_1_R1_State = "08"
        ElseIf Brd_1_Res_Select.SelectedIndex = 8 Then
            Board_1_R1_State = "09"
        ElseIf Brd_1_Res_Select.SelectedIndex = 9 Then
            Board_1_R1_State = "10"
        ElseIf Brd_1_Res_Select.SelectedIndex = 10 Then
            Board_1_R1_State = "11"
        Else
            Board_1_R1_State = "10"
        End If
        'Call the message compiler
        Board_1_Compile_Serial_Message()
    End Sub

    Private Sub brd_1_ch1_gain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brd_1_ch1_gain.SelectedIndexChanged
        If brd_1_ch1_gain.SelectedIndex = 0 Then
            Board_1_Scope_Ch1_gain = "01"
        Else
            Board_1_Scope_Ch1_gain = "10"
        End If
        'Call the message compiler
        Board_1_Compile_Serial_Message()
    End Sub

    Private Sub brd_1_ch_2_gain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brd_1_ch_2_gain.SelectedIndexChanged
        If brd_1_ch_2_gain.SelectedIndex = 0 Then
            Board_1_Scope_Ch2_gain = "01"
        Else
            Board_1_Scope_Ch2_gain = "10"
        End If
        'Call the message compiler
        Board_1_Compile_Serial_Message()
    End Sub













    'Board 2 Subroutines 

    'Board_3: Serial Message Compiler
    'This subroutine takes the individual board_2 variables and
    'combines them into one string.
    Sub Board_2_Compile_Serial_Message()
        Board_2_Serial_Message = "board_2," + Board_2_R1_State + "," +
                         Board_2_R2_State + "," +
                         Board_2_R3_State + "," +
                         Board_2_R4_State + "," +
                         Board_2_C1_State + "," +
                         Board_2_C2_State + "," +
                         Board_2_Scope_Ch1_gain + "," +
                         Board_2_Scope_Ch2_gain
        'this statement exists exclusively for debuginng purposes
        Serial_Text_Test.Text = Board_2_Serial_Message
        'Change the 'Send Data' button collor to orange, to indicate that
        'a change in the board configuration has occured.
        btn_Send_Config.BackColor = Color.Orange
    End Sub

    'Board_2: R1 control
    Private Sub board_4_R1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_4_R1.SelectedIndexChanged
        If board_4_R1.SelectedIndex = 0 Then
            Board_2_R1_State = "1"
        ElseIf board_4_R1.SelectedIndex = 1 Then
            Board_2_R1_State = "2"
        ElseIf board_4_R1.SelectedIndex = 2 Then
            Board_2_R1_State = "3"
        ElseIf board_4_R1.SelectedIndex = 3 Then
            Board_2_R1_State = "4"
        Else
            Board_2_R1_State = "5"
        End If

        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub

    'Board_2: R2 control
    Private Sub board_4_R2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_4_R2.SelectedIndexChanged
        If board_4_R2.SelectedIndex = 0 Then
            Board_2_R2_State = "1"
        ElseIf board_4_R2.SelectedIndex = 1 Then
            Board_2_R2_State = "2"
        ElseIf board_4_R2.SelectedIndex = 2 Then
            Board_2_R2_State = "3"
        ElseIf board_4_R2.SelectedIndex = 3 Then
            Board_2_R2_State = "4"
        Else
            Board_2_R2_State = "5"
        End If

        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub

    'Board_2: R3 control
    Private Sub board_4_R3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_4_R3.SelectedIndexChanged
        If board_4_R3.SelectedIndex = 0 Then
            Board_2_R3_State = "1"
        ElseIf board_4_R3.SelectedIndex = 1 Then
            Board_2_R3_State = "2"
        ElseIf board_4_R3.SelectedIndex = 2 Then
            Board_2_R3_State = "3"
        ElseIf board_4_R3.SelectedIndex = 3 Then
            Board_2_R3_State = "4"
        Else
            Board_2_R3_State = "5"
        End If
        
        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub

    'Board_2: R4 control
    Private Sub board_4_R4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_4_R4.SelectedIndexChanged
        If board_4_R4.SelectedIndex = 0 Then
            Board_2_R4_State = "1"
        ElseIf board_4_R4.SelectedIndex = 1 Then
            Board_2_R4_State = "2"
        ElseIf board_4_R4.SelectedIndex = 2 Then
            Board_2_R4_State = "3"
        ElseIf board_4_R4.SelectedIndex = 3 Then
            Board_2_R4_State = "4"
        Else
            Board_2_R4_State = "5"
        End If
        
        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub

    'Board_2: C1 control
    Private Sub board_2_C1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_2_C1.SelectedIndexChanged
        If board_2_C1.SelectedIndex = 0 Then
            Board_2_C1_State = "1"
        ElseIf board_2_C1.SelectedIndex = 1 Then
            Board_2_C1_State = "2"
        Else
            Board_2_C1_State = "3"
        End If
        
        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub

    'Board_2: C2 control
    Private Sub board_2_C2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_2_C2.SelectedIndexChanged
        If board_2_C2.SelectedIndex = 0 Then
            Board_2_C2_State = "1"
        ElseIf board_2_C2.SelectedIndex = 1 Then
            Board_2_C2_State = "2"
        Else
            Board_2_C2_State = "3"
        End If
        
        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub

    'Board_2: Ch1 gain control
    Private Sub board_2_scope_ch_1_gain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_2_scope_ch_1_gain.SelectedIndexChanged
        If board_2_scope_ch_1_gain.SelectedIndex = 0 Then
            Board_2_Scope_Ch1_gain = "01"
        Else
            Board_2_Scope_Ch1_gain = "10"
        End If
        
        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub

    Private Sub board_2_scope_ch_2_gain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_2_scope_ch_2_gain.SelectedIndexChanged
        If board_2_scope_ch_2_gain.SelectedIndex = 0 Then
            Board_2_Scope_Ch2_gain = "01"
        Else
            Board_2_Scope_Ch2_gain = "10"
        End If

        'Call the message compiler
        Board_2_Compile_Serial_Message()
    End Sub








    'Board 5 Subroutines 

    'Board_5: Serial Message Compiler
    'This subroutine takes the individual board_5 variables and
    'combines them into one string.
    Sub Board_5_Compile_Serial_Message()
        Board_5_Serial_Message = "board_5," +
                         Board_5_R2_State + "," +
                         Board_5_R3_State + "," +
                         Board_5_C1_State
        'this statement exists exclusively for debuginng purposes
        Serial_Text_Test.Text = Board_5_Serial_Message
        'Change the 'Send Data' button collor to orange, to indicate that
        'a change in the board configuration has occured.
        btn_Send_Config.BackColor = Color.Orange
    End Sub

    'Board 5: R2 control
    Private Sub board_5_R2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_5_R2.SelectedIndexChanged
        If board_5_R2.SelectedIndex = 0 Then
            Board_5_R2_State = "1"
        Else
            Board_5_R2_State = "0"
        End If
        'Call the message compiler
        Board_5_Compile_Serial_Message()
    End Sub

    'Board 5: R2 control
    Private Sub board_5_R3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_5_R3.SelectedIndexChanged
        If board_5_R3.SelectedIndex = 0 Then
            Board_5_R3_State = "1"
        Else
            Board_5_R3_State = "0"
        End If
        'Call the message compiler
        Board_5_Compile_Serial_Message()
    End Sub

    'Board 5: C1 control
    Private Sub board_5_C1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles board_5_C1.SelectedIndexChanged
        If board_5_C1.SelectedIndex = 0 Then
            Board_5_C1_State = "1"
        Else
            Board_5_C1_State = "0"
        End If
        'Call the message compiler
        Board_5_Compile_Serial_Message()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles SelectProgram.Enter

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
