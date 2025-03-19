<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        txtName = New TextBox()
        lblName = New Label()
        lblAge = New Label()
        txtAge = New TextBox()
        lblAddress = New Label()
        txtAddress = New TextBox()
        lblContact = New Label()
        txtContact = New TextBox()
        rdbMale = New RadioButton()
        rdbFemale = New RadioButton()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Harlow Solid Italic", 20.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(37, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 68)
        Label1.TabIndex = 0
        Label1.Text = "Anime Costume" & vbCrLf & "Cosplay Rental"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(49, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 30)
        Label2.TabIndex = 1
        Label2.Text = "Welcome!, Input a customer-" & vbCrLf & "information"
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(49, 159)
        txtName.Name = "txtName"
        txtName.Size = New Size(175, 27)
        txtName.TabIndex = 0
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.Transparent
        lblName.ForeColor = SystemColors.Control
        lblName.Location = New Point(49, 141)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 1
        lblName.Text = "Name"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.BackColor = Color.Transparent
        lblAge.ForeColor = SystemColors.Control
        lblAge.Location = New Point(49, 191)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(28, 15)
        lblAge.TabIndex = 1
        lblAge.Text = "Age"
        ' 
        ' txtAge
        ' 
        txtAge.BorderStyle = BorderStyle.FixedSingle
        txtAge.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAge.Location = New Point(49, 209)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(175, 27)
        txtAge.TabIndex = 1
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.BackColor = Color.Transparent
        lblAddress.ForeColor = SystemColors.Control
        lblAddress.Location = New Point(49, 241)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(49, 15)
        lblAddress.TabIndex = 1
        lblAddress.Text = "Address"
        ' 
        ' txtAddress
        ' 
        txtAddress.BorderStyle = BorderStyle.FixedSingle
        txtAddress.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAddress.Location = New Point(49, 259)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(175, 27)
        txtAddress.TabIndex = 2
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.BackColor = Color.Transparent
        lblContact.ForeColor = SystemColors.Control
        lblContact.Location = New Point(49, 292)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(49, 15)
        lblContact.TabIndex = 1
        lblContact.Text = "Contact"
        ' 
        ' txtContact
        ' 
        txtContact.BorderStyle = BorderStyle.FixedSingle
        txtContact.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContact.Location = New Point(49, 310)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(175, 27)
        txtContact.TabIndex = 3
        ' 
        ' rdbMale
        ' 
        rdbMale.AutoSize = True
        rdbMale.BackColor = Color.Transparent
        rdbMale.ForeColor = SystemColors.Control
        rdbMale.Location = New Point(49, 352)
        rdbMale.Name = "rdbMale"
        rdbMale.Size = New Size(51, 19)
        rdbMale.TabIndex = 11
        rdbMale.TabStop = True
        rdbMale.Text = "Male"
        rdbMale.UseVisualStyleBackColor = False
        ' 
        ' rdbFemale
        ' 
        rdbFemale.AutoSize = True
        rdbFemale.BackColor = Color.Transparent
        rdbFemale.ForeColor = SystemColors.Control
        rdbFemale.Location = New Point(161, 352)
        rdbFemale.Name = "rdbFemale"
        rdbFemale.Size = New Size(63, 19)
        rdbFemale.TabIndex = 11
        rdbFemale.TabStop = True
        rdbFemale.Text = "Female"
        rdbFemale.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlDark
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(49, 386)
        Button1.Name = "Button1"
        Button1.Size = New Size(175, 42)
        Button1.TabIndex = 4
        Button1.Text = "Proceed"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bg1
        ClientSize = New Size(266, 460)
        Controls.Add(Button1)
        Controls.Add(rdbFemale)
        Controls.Add(rdbMale)
        Controls.Add(txtContact)
        Controls.Add(lblContact)
        Controls.Add(txtAddress)
        Controls.Add(lblAddress)
        Controls.Add(txtAge)
        Controls.Add(lblAge)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Costume Rental System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblContact As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents Button1 As Button

End Class
