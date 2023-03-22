<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.timeLog = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 165)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COM PORT:"
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.BackColor = System.Drawing.Color.White
        Me.comPort_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPort_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(119, 166)
        Me.comPort_ComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(78, 32)
        Me.comPort_ComboBox.TabIndex = 1
        '
        'Timer1
        '
        '
        'connect_BTN
        '
        Me.connect_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_BTN.Location = New System.Drawing.Point(199, 165)
        Me.connect_BTN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(74, 33)
        Me.connect_BTN.TabIndex = 2
        Me.connect_BTN.Text = "OPEN"
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_LBL.Location = New System.Drawing.Point(277, 168)
        Me.Timer_LBL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(128, 24)
        Me.Timer_LBL.TabIndex = 3
        Me.Timer_LBL.Text = "Device: OFF"
        '
        'lblID
        '
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblID.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(68, 6)
        Me.lblID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(312, 36)
        Me.lblID.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(-2, 159)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(391, 1)
        Me.Label2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 33)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Card No :"
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(2, 43)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(376, 35)
        Me.lblName.TabIndex = 7
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(-3, 81)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(391, 1)
        Me.Label5.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(146, 86)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Name"
        '
        'Timer2
        '
        Me.Timer2.Interval = 2500
        '
        'timeLog
        '
        Me.timeLog.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLog.ForeColor = System.Drawing.Color.Red
        Me.timeLog.Location = New System.Drawing.Point(1, 126)
        Me.timeLog.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.timeLog.Name = "timeLog"
        Me.timeLog.Size = New System.Drawing.Size(376, 32)
        Me.timeLog.TabIndex = 10
        Me.timeLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourse
        '
        Me.lblCourse.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(4, 99)
        Me.lblCourse.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(376, 27)
        Me.lblCourse.TabIndex = 11
        Me.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(416, 202)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.timeLog)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Timer_LBL)
        Me.Controls.Add(Me.connect_BTN)
        Me.Controls.Add(Me.comPort_ComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time_LOG"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label1 As Label
    Friend WithEvents comPort_ComboBox As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents connect_BTN As Button
    Friend WithEvents Timer_LBL As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents timeLog As Label
    Friend WithEvents lblCourse As Label
End Class
