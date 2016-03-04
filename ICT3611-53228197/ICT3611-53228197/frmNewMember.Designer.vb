<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewMember
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioFemale = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtMemberNr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboDay = New System.Windows.Forms.ComboBox()
        Me.ComboMonth = New System.Windows.Forms.ComboBox()
        Me.ComboYear = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DatePickJoin = New System.Windows.Forms.DateTimePicker()
        Me.TxtSurname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioMale = New System.Windows.Forms.RadioButton()
        Me.grpBoxGender = New System.Windows.Forms.GroupBox()
        Me.TxtGender = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.grpBoxGender.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grpBoxGender)
        Me.Panel1.Controls.Add(Me.TxtGender)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.TxtMemberNr)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ComboDay)
        Me.Panel1.Controls.Add(Me.ComboMonth)
        Me.Panel1.Controls.Add(Me.ComboYear)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DatePickJoin)
        Me.Panel1.Controls.Add(Me.TxtSurname)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(5, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 326)
        Me.Panel1.TabIndex = 29
        '
        'RadioFemale
        '
        Me.RadioFemale.AutoSize = True
        Me.RadioFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.RadioFemale.Location = New System.Drawing.Point(221, 11)
        Me.RadioFemale.Name = "RadioFemale"
        Me.RadioFemale.Size = New System.Drawing.Size(82, 24)
        Me.RadioFemale.TabIndex = 23
        Me.RadioFemale.TabStop = True
        Me.RadioFemale.Text = "Female"
        Me.RadioFemale.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(6, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 24)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Gender"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnCancel.Location = New System.Drawing.Point(202, 259)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(180, 54)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.BtnSave.Location = New System.Drawing.Point(16, 259)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(180, 56)
        Me.BtnSave.TabIndex = 30
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtMemberNr
        '
        Me.TxtMemberNr.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMemberNr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TxtMemberNr.Location = New System.Drawing.Point(107, 16)
        Me.TxtMemberNr.Name = "TxtMemberNr"
        Me.TxtMemberNr.ReadOnly = True
        Me.TxtMemberNr.Size = New System.Drawing.Size(281, 26)
        Me.TxtMemberNr.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(5, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 24)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Member #"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(15, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 24)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Join date"
        '
        'ComboDay
        '
        Me.ComboDay.DropDownHeight = 100
        Me.ComboDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboDay.FormattingEnabled = True
        Me.ComboDay.IntegralHeight = False
        Me.ComboDay.Location = New System.Drawing.Point(332, 119)
        Me.ComboDay.Name = "ComboDay"
        Me.ComboDay.Size = New System.Drawing.Size(57, 28)
        Me.ComboDay.TabIndex = 20
        '
        'ComboMonth
        '
        Me.ComboMonth.DropDownHeight = 100
        Me.ComboMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboMonth.FormattingEnabled = True
        Me.ComboMonth.IntegralHeight = False
        Me.ComboMonth.Location = New System.Drawing.Point(192, 119)
        Me.ComboMonth.Name = "ComboMonth"
        Me.ComboMonth.Size = New System.Drawing.Size(134, 28)
        Me.ComboMonth.TabIndex = 19
        '
        'ComboYear
        '
        Me.ComboYear.DropDownHeight = 100
        Me.ComboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboYear.FormattingEnabled = True
        Me.ComboYear.IntegralHeight = False
        Me.ComboYear.Location = New System.Drawing.Point(107, 119)
        Me.ComboYear.MaxDropDownItems = 4
        Me.ComboYear.MaxLength = 4
        Me.ComboYear.Name = "ComboYear"
        Me.ComboYear.Size = New System.Drawing.Size(79, 28)
        Me.ComboYear.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Birth date"
        '
        'DatePickJoin
        '
        Me.DatePickJoin.CustomFormat = ""
        Me.DatePickJoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.DatePickJoin.Location = New System.Drawing.Point(107, 217)
        Me.DatePickJoin.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DatePickJoin.Name = "DatePickJoin"
        Me.DatePickJoin.Size = New System.Drawing.Size(282, 26)
        Me.DatePickJoin.TabIndex = 11
        '
        'TxtSurname
        '
        Me.TxtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSurname.Location = New System.Drawing.Point(107, 84)
        Me.TxtSurname.Name = "TxtSurname"
        Me.TxtSurname.Size = New System.Drawing.Size(282, 26)
        Me.TxtSurname.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Surname"
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(107, 50)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(282, 26)
        Me.TxtName.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        '
        'RadioMale
        '
        Me.RadioMale.AutoSize = True
        Me.RadioMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.RadioMale.Location = New System.Drawing.Point(140, 11)
        Me.RadioMale.Name = "RadioMale"
        Me.RadioMale.Size = New System.Drawing.Size(63, 24)
        Me.RadioMale.TabIndex = 21
        Me.RadioMale.TabStop = True
        Me.RadioMale.Text = "Male"
        Me.RadioMale.UseVisualStyleBackColor = True
        '
        'grpBoxGender
        '
        Me.grpBoxGender.Controls.Add(Me.RadioMale)
        Me.grpBoxGender.Controls.Add(Me.Label4)
        Me.grpBoxGender.Controls.Add(Me.RadioFemale)
        Me.grpBoxGender.Location = New System.Drawing.Point(35, 160)
        Me.grpBoxGender.Name = "grpBoxGender"
        Me.grpBoxGender.Size = New System.Drawing.Size(339, 41)
        Me.grpBoxGender.TabIndex = 32
        Me.grpBoxGender.TabStop = False
        '
        'TxtGender
        '
        Me.TxtGender.Location = New System.Drawing.Point(263, 178)
        Me.TxtGender.Name = "TxtGender"
        Me.TxtGender.Size = New System.Drawing.Size(100, 20)
        Me.TxtGender.TabIndex = 33
        Me.TxtGender.Visible = False
        '
        'frmNewMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 332)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmNewMember"
        Me.Text = "frmNewMember"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpBoxGender.ResumeLayout(False)
        Me.grpBoxGender.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadioFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TxtMemberNr As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboDay As System.Windows.Forms.ComboBox
    Friend WithEvents ComboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents ComboYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DatePickJoin As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpBoxGender As System.Windows.Forms.GroupBox
    Friend WithEvents RadioMale As System.Windows.Forms.RadioButton
    Friend WithEvents TxtGender As System.Windows.Forms.TextBox
End Class
