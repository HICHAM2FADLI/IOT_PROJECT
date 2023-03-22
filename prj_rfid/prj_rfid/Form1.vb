Imports System
Imports System.IO.Ports
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim comPORT As String
    Dim receivedData As String = ""
    Dim conn As New MySqlConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comPort_ComboBox.Items.Add(sp)
        Next

        connect()
        Try
            conn.Open()
        Catch ex As Exception
            End
        End Try

    End Sub

    Public Sub connect()
        Dim DatabaseName As String = "db_paks"
        Dim server As String = "localhost"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false;SslMode=none", server, userName, password, DatabaseName)
        Try
            conn.Open()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub comPort_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPort_ComboBox.SelectedIndexChanged
        If (comPort_ComboBox.SelectedItem <> "") Then
            comPORT = comPort_ComboBox.SelectedItem
        End If
    End Sub

    Private Sub connect_BTN_Click(sender As Object, e As EventArgs) Handles connect_BTN.Click
        If (connect_BTN.Text = "Connect") Then
            If (comPORT <> "") Then
                SerialPort1.Close()
                SerialPort1.PortName = comPORT
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.ReadTimeout = 10000

                SerialPort1.Open()
                connect_BTN.Text = "Dis-connect"
                Timer1.Enabled = True
                Timer_LBL.Text = "Device: ON"
            Else
                MsgBox("Select a COM port first")
            End If
        Else
            SerialPort1.Close()
            connect_BTN.Text = "Connect"
            Timer1.Enabled = False
            Timer_LBL.Text = "Device: OFF"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        receivedData = ReceiveSerialData()
        Me.Timer2.Enabled = True
        If (receivedData.ToString <> "") Then
            Try
                If Not conn Is Nothing Then conn.Close()
                conn.Open()
                Dim dr As MySqlDataReader
                Dim query As String = "select * from  student_info where id='" & receivedData.ToString & "' limit 1"
                Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
                dr = cmd.ExecuteReader
                If dr.Read Then
                    lblName.Text = dr.GetString(1)
                    lblCourse.Text = dr.GetString(2)
                    lblID.Text = receivedData
                    dr.Close()


                    query = "select name from  tbl_time where name='" & lblName.Text & "' and `date`=curdate() and time_out='' "
                    cmd = New MySqlCommand(query, conn)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        Dim Tout = dr.GetString(0)
                        dr.Close()
                        Dim ins As New MySqlCommand("update tbl_time set time_out=curtime() where name='" & Tout & "'", conn)
                        ins.ExecuteNonQuery()
                        timeLog.Text = "TIME OUT " & Now.ToString

                    Else
                        dr.Close()
                        Dim ins As New MySqlCommand("Insert into tbl_time values('','" & lblName.Text & "','" & lblCourse.Text & "',curdate(),curtime(),'')", conn)
                        ins.ExecuteNonQuery()
                        timeLog.Text = "TIME IN " & Now.ToString

                    End If

                Else
                    lblName.Text = "PLEASE TRY AGAIN"
                    timeLog.Text = "No Record Found"
                End If

                dr.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            Me.Timer2.Enabled = False




        End If
    End Sub


    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.lblID.Text = ""
        receivedData = ""
        Me.lblName.Text = ""
        timeLog.Text = ""
        lblCourse.Text = ""
    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub
End Class

