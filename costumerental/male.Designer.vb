<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class male
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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        txtRentDays = New TextBox()
        lblRentDays = New Label()
        txtLongerRentDiscount = New TextBox()
        Label21 = New Label()
        txtMultiCostumeDiscount = New TextBox()
        Label20 = New Label()
        txtTotalCost = New TextBox()
        Label19 = New Label()
        Label18 = New Label()
        txtName = New Label()
        PictureBox2 = New PictureBox()
        GroupBox2 = New GroupBox()
        btnGoku = New Button()
        lblPrice = New Label()
        lblCName = New Label()
        Panel1 = New Panel()
        GroupBox3 = New GroupBox()
        btnUchiha = New Button()
        Label3 = New Label()
        Label5 = New Label()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        GroupBox4 = New GroupBox()
        btnLuffy = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Panel3 = New Panel()
        PictureBox4 = New PictureBox()
        GroupBox5 = New GroupBox()
        btnRoshi = New Button()
        Label10 = New Label()
        Label11 = New Label()
        Panel4 = New Panel()
        PictureBox1 = New PictureBox()
        GroupBox6 = New GroupBox()
        btnIguro = New Button()
        Label13 = New Label()
        Label14 = New Label()
        Panel5 = New Panel()
        PictureBox5 = New PictureBox()
        GroupBox7 = New GroupBox()
        btnMoon = New Button()
        Label16 = New Label()
        Label17 = New Label()
        Panel6 = New Panel()
        PictureBox6 = New PictureBox()
        btnClear = New Button()
        btnTotal = New Button()
        lblReturn = New Label()
        txtReturn = New TextBox()
        lblLate = New Label()
        txtLate = New TextBox()
        btnReturn = New Button()
        btnAgain = New Button()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox6.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox7.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Harlow Solid Italic", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(9, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 60)
        Label1.TabIndex = 2
        Label1.Text = "Anime Costume" & vbCrLf & "Cosplay Rental"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtRentDays)
        GroupBox1.Controls.Add(lblRentDays)
        GroupBox1.Controls.Add(txtLongerRentDiscount)
        GroupBox1.Controls.Add(Label21)
        GroupBox1.Controls.Add(txtMultiCostumeDiscount)
        GroupBox1.Controls.Add(Label20)
        GroupBox1.Controls.Add(txtTotalCost)
        GroupBox1.Controls.Add(Label19)
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(630, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(184, 447)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Details"
        ' 
        ' txtRentDays
        ' 
        txtRentDays.Location = New Point(15, 296)
        txtRentDays.Name = "txtRentDays"
        txtRentDays.Size = New Size(159, 23)
        txtRentDays.TabIndex = 7
        ' 
        ' lblRentDays
        ' 
        lblRentDays.AutoSize = True
        lblRentDays.Location = New Point(12, 276)
        lblRentDays.Name = "lblRentDays"
        lblRentDays.Size = New Size(85, 15)
        lblRentDays.TabIndex = 6
        lblRentDays.Text = "Enter rent days"
        ' 
        ' txtLongerRentDiscount
        ' 
        txtLongerRentDiscount.Location = New Point(14, 340)
        txtLongerRentDiscount.Name = "txtLongerRentDiscount"
        txtLongerRentDiscount.ReadOnly = True
        txtLongerRentDiscount.Size = New Size(160, 23)
        txtLongerRentDiscount.TabIndex = 5
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(11, 322)
        Label21.Name = "Label21"
        Label21.Size = New Size(149, 15)
        Label21.TabIndex = 4
        Label21.Text = "Longer Rent Days Discount"
        ' 
        ' txtMultiCostumeDiscount
        ' 
        txtMultiCostumeDiscount.Location = New Point(14, 384)
        txtMultiCostumeDiscount.Name = "txtMultiCostumeDiscount"
        txtMultiCostumeDiscount.ReadOnly = True
        txtMultiCostumeDiscount.Size = New Size(160, 23)
        txtMultiCostumeDiscount.TabIndex = 5
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(11, 366)
        Label20.Name = "Label20"
        Label20.Size = New Size(152, 15)
        Label20.TabIndex = 4
        Label20.Text = "Multiple Costume Discount"
        ' 
        ' txtTotalCost
        ' 
        txtTotalCost.Location = New Point(74, 413)
        txtTotalCost.Name = "txtTotalCost"
        txtTotalCost.ReadOnly = True
        txtTotalCost.Size = New Size(100, 23)
        txtTotalCost.TabIndex = 5
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(9, 417)
        Label19.Name = "Label19"
        Label19.Size = New Size(59, 15)
        Label19.TabIndex = 4
        Label19.Text = "Total Cost"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(14, 90)
        Label18.Name = "Label18"
        Label18.Size = New Size(63, 15)
        Label18.TabIndex = 4
        Label18.Text = "Your rents:"
        ' 
        ' txtName
        ' 
        txtName.AutoSize = True
        txtName.Location = New Point(13, 115)
        txtName.Name = "txtName"
        txtName.Size = New Size(0, 15)
        txtName.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Image = My.Resources.Resources.pic2
        PictureBox2.Location = New Point(13, 20)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(132, 177)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnGoku)
        GroupBox2.Controls.Add(lblPrice)
        GroupBox2.Controls.Add(lblCName)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Controls.Add(PictureBox2)
        GroupBox2.Location = New Point(30, 20)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(158, 318)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        ' 
        ' btnGoku
        ' 
        btnGoku.BackColor = SystemColors.AppWorkspace
        btnGoku.FlatAppearance.BorderSize = 0
        btnGoku.FlatStyle = FlatStyle.Flat
        btnGoku.ForeColor = Color.Black
        btnGoku.Location = New Point(13, 265)
        btnGoku.Name = "btnGoku"
        btnGoku.Size = New Size(132, 38)
        btnGoku.TabIndex = 9
        btnGoku.Text = "Add to rent"
        btnGoku.UseVisualStyleBackColor = False
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPrice.ForeColor = Color.SeaGreen
        lblPrice.Location = New Point(46, 238)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(48, 17)
        lblPrice.TabIndex = 7
        lblPrice.Text = "₱ 2600"
        ' 
        ' lblCName
        ' 
        lblCName.AutoSize = True
        lblCName.Font = New Font("Georgia", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblCName.Location = New Point(25, 215)
        lblCName.Name = "lblCName"
        lblCName.Size = New Size(106, 15)
        lblCName.TabIndex = 6
        lblCName.Text = "Adult Son Goku"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(0, 204)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(158, 5)
        Panel1.TabIndex = 5
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnUchiha)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Panel2)
        GroupBox3.Controls.Add(PictureBox3)
        GroupBox3.Location = New Point(247, 20)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(158, 318)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        ' 
        ' btnUchiha
        ' 
        btnUchiha.BackColor = SystemColors.AppWorkspace
        btnUchiha.FlatAppearance.BorderSize = 0
        btnUchiha.FlatStyle = FlatStyle.Flat
        btnUchiha.ForeColor = Color.Black
        btnUchiha.Location = New Point(13, 265)
        btnUchiha.Name = "btnUchiha"
        btnUchiha.Size = New Size(132, 38)
        btnUchiha.TabIndex = 9
        btnUchiha.Text = "Add to rent"
        btnUchiha.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SeaGreen
        Label3.Location = New Point(51, 238)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 17)
        Label3.TabIndex = 7
        Label3.Text = "₱ 2100"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Georgia", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(30, 215)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 15)
        Label5.TabIndex = 6
        Label5.Text = "Uchiha Sasuke"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Location = New Point(0, 204)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(158, 5)
        Panel2.TabIndex = 5
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImageLayout = ImageLayout.None
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.Image = My.Resources.Resources.pic3
        PictureBox3.Location = New Point(13, 20)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(132, 177)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(btnLuffy)
        GroupBox4.Controls.Add(Label7)
        GroupBox4.Controls.Add(Label8)
        GroupBox4.Controls.Add(Panel3)
        GroupBox4.Controls.Add(PictureBox4)
        GroupBox4.Location = New Point(452, 20)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(158, 318)
        GroupBox4.TabIndex = 5
        GroupBox4.TabStop = False
        ' 
        ' btnLuffy
        ' 
        btnLuffy.BackColor = SystemColors.AppWorkspace
        btnLuffy.FlatAppearance.BorderSize = 0
        btnLuffy.FlatStyle = FlatStyle.Flat
        btnLuffy.ForeColor = Color.Black
        btnLuffy.Location = New Point(13, 265)
        btnLuffy.Name = "btnLuffy"
        btnLuffy.Size = New Size(132, 38)
        btnLuffy.TabIndex = 9
        btnLuffy.Text = "Add to rent"
        btnLuffy.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.SeaGreen
        Label7.Location = New Point(51, 238)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 17)
        Label7.TabIndex = 7
        Label7.Text = "₱ 1500"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Georgia", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(25, 215)
        Label8.Name = "Label8"
        Label8.Size = New Size(105, 15)
        Label8.TabIndex = 6
        Label8.Text = "One Piece Luffy"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaptionText
        Panel3.Location = New Point(0, 204)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(158, 5)
        Panel3.TabIndex = 5
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImageLayout = ImageLayout.None
        PictureBox4.BorderStyle = BorderStyle.FixedSingle
        PictureBox4.Image = My.Resources.Resources.pic4
        PictureBox4.Location = New Point(13, 20)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(132, 177)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(btnRoshi)
        GroupBox5.Controls.Add(Label10)
        GroupBox5.Controls.Add(Label11)
        GroupBox5.Controls.Add(Panel4)
        GroupBox5.Controls.Add(PictureBox1)
        GroupBox5.Location = New Point(30, 357)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(158, 318)
        GroupBox5.TabIndex = 5
        GroupBox5.TabStop = False
        ' 
        ' btnRoshi
        ' 
        btnRoshi.BackColor = SystemColors.AppWorkspace
        btnRoshi.FlatAppearance.BorderSize = 0
        btnRoshi.FlatStyle = FlatStyle.Flat
        btnRoshi.ForeColor = Color.Black
        btnRoshi.Location = New Point(13, 265)
        btnRoshi.Name = "btnRoshi"
        btnRoshi.Size = New Size(132, 38)
        btnRoshi.TabIndex = 9
        btnRoshi.Text = "Add to rent"
        btnRoshi.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.SeaGreen
        Label10.Location = New Point(44, 237)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 17)
        Label10.TabIndex = 7
        Label10.Text = "₱ 1800"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Georgia", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(31, 215)
        Label11.Name = "Label11"
        Label11.Size = New Size(92, 15)
        Label11.TabIndex = 6
        Label11.Text = "Master Roshi"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaptionText
        Panel4.Location = New Point(0, 204)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(158, 5)
        Panel4.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = My.Resources.Resources.pic5
        PictureBox1.Location = New Point(13, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(132, 177)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(btnIguro)
        GroupBox6.Controls.Add(Label13)
        GroupBox6.Controls.Add(Label14)
        GroupBox6.Controls.Add(Panel5)
        GroupBox6.Controls.Add(PictureBox5)
        GroupBox6.Location = New Point(247, 357)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(158, 318)
        GroupBox6.TabIndex = 5
        GroupBox6.TabStop = False
        ' 
        ' btnIguro
        ' 
        btnIguro.BackColor = SystemColors.AppWorkspace
        btnIguro.FlatAppearance.BorderSize = 0
        btnIguro.FlatStyle = FlatStyle.Flat
        btnIguro.ForeColor = Color.Black
        btnIguro.Location = New Point(13, 265)
        btnIguro.Name = "btnIguro"
        btnIguro.Size = New Size(132, 38)
        btnIguro.TabIndex = 9
        btnIguro.Text = "Add to rent"
        btnIguro.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.SeaGreen
        Label13.Location = New Point(51, 238)
        Label13.Name = "Label13"
        Label13.Size = New Size(48, 17)
        Label13.TabIndex = 7
        Label13.Text = "₱ 2200"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Georgia", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(13, 215)
        Label14.Name = "Label14"
        Label14.Size = New Size(134, 15)
        Label14.TabIndex = 6
        Label14.Text = "Iguro Demon Slayer"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveCaptionText
        Panel5.Location = New Point(0, 204)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(158, 5)
        Panel5.TabIndex = 5
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImageLayout = ImageLayout.None
        PictureBox5.BorderStyle = BorderStyle.FixedSingle
        PictureBox5.Image = My.Resources.Resources.pic61
        PictureBox5.Location = New Point(13, 20)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(132, 177)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(btnMoon)
        GroupBox7.Controls.Add(Label16)
        GroupBox7.Controls.Add(Label17)
        GroupBox7.Controls.Add(Panel6)
        GroupBox7.Controls.Add(PictureBox6)
        GroupBox7.Location = New Point(452, 357)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(158, 318)
        GroupBox7.TabIndex = 5
        GroupBox7.TabStop = False
        ' 
        ' btnMoon
        ' 
        btnMoon.BackColor = SystemColors.AppWorkspace
        btnMoon.FlatAppearance.BorderSize = 0
        btnMoon.FlatStyle = FlatStyle.Flat
        btnMoon.ForeColor = Color.Black
        btnMoon.Location = New Point(13, 265)
        btnMoon.Name = "btnMoon"
        btnMoon.Size = New Size(132, 38)
        btnMoon.TabIndex = 9
        btnMoon.Text = "Add to rent"
        btnMoon.UseVisualStyleBackColor = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.SeaGreen
        Label16.Location = New Point(52, 238)
        Label16.Name = "Label16"
        Label16.Size = New Size(48, 17)
        Label16.TabIndex = 7
        Label16.Text = "₱ 2700"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Georgia", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(23, 215)
        Label17.Name = "Label17"
        Label17.Size = New Size(114, 15)
        Label17.TabIndex = 6
        Label17.Text = "Kid Moon Knight"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ActiveCaptionText
        Panel6.Location = New Point(0, 204)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(158, 5)
        Panel6.TabIndex = 5
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImageLayout = ImageLayout.None
        PictureBox6.BorderStyle = BorderStyle.FixedSingle
        PictureBox6.Image = My.Resources.Resources.pic7
        PictureBox6.Location = New Point(13, 20)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(132, 177)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 4
        PictureBox6.TabStop = False
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(630, 465)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(83, 41)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnTotal
        ' 
        btnTotal.Location = New Point(731, 465)
        btnTotal.Name = "btnTotal"
        btnTotal.Size = New Size(83, 41)
        btnTotal.TabIndex = 6
        btnTotal.Text = "Total"
        btnTotal.UseVisualStyleBackColor = True
        ' 
        ' lblReturn
        ' 
        lblReturn.AutoSize = True
        lblReturn.Location = New Point(630, 513)
        lblReturn.Name = "lblReturn"
        lblReturn.Size = New Size(99, 15)
        lblReturn.TabIndex = 7
        lblReturn.Text = "Enter Return Date"
        lblReturn.Visible = False
        ' 
        ' txtReturn
        ' 
        txtReturn.Location = New Point(633, 535)
        txtReturn.Name = "txtReturn"
        txtReturn.Size = New Size(95, 23)
        txtReturn.TabIndex = 8
        txtReturn.Visible = False
        ' 
        ' lblLate
        ' 
        lblLate.AutoSize = True
        lblLate.Location = New Point(742, 513)
        lblLate.Name = "lblLate"
        lblLate.Size = New Size(48, 15)
        lblLate.TabIndex = 7
        lblLate.Text = "Late fee"
        lblLate.Visible = False
        ' 
        ' txtLate
        ' 
        txtLate.Location = New Point(744, 535)
        txtLate.Name = "txtLate"
        txtLate.ReadOnly = True
        txtLate.Size = New Size(70, 23)
        txtLate.TabIndex = 8
        txtLate.Visible = False
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(633, 572)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(181, 39)
        btnReturn.TabIndex = 9
        btnReturn.Text = "Return"
        btnReturn.UseVisualStyleBackColor = True
        btnReturn.Visible = False
        ' 
        ' btnAgain
        ' 
        btnAgain.Location = New Point(704, 637)
        btnAgain.Name = "btnAgain"
        btnAgain.Size = New Size(110, 38)
        btnAgain.TabIndex = 10
        btnAgain.Text = "Again?"
        btnAgain.UseVisualStyleBackColor = True
        btnAgain.Visible = False
        ' 
        ' male
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(832, 692)
        Controls.Add(btnAgain)
        Controls.Add(btnReturn)
        Controls.Add(txtLate)
        Controls.Add(lblLate)
        Controls.Add(txtReturn)
        Controls.Add(lblReturn)
        Controls.Add(btnTotal)
        Controls.Add(btnClear)
        Controls.Add(GroupBox7)
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "male"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Anime Costume Cosplay Rental (Male)"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        GroupBox7.ResumeLayout(False)
        GroupBox7.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblCName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnGoku As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnUchiha As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnLuffy As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnRoshi As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnIguro As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btnMoon As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents txtName As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtMultiCostumeDiscount As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtLongerRentDiscount As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btnTotal As Button
    Friend WithEvents lblReturn As Label
    Friend WithEvents txtReturn As TextBox
    Friend WithEvents lblLate As Label
    Friend WithEvents txtLate As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnAgain As Button
    Friend WithEvents txtRentDays As TextBox
    Friend WithEvents lblRentDays As Label
End Class
