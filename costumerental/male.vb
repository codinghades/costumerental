Public Class male
    Private rentalCount As Integer = 0
    Private totalRentalCost As Integer = 0
    Private totalDiscount As Integer = 0

    Private Sub btnGoku_Click(sender As Object, e As EventArgs) Handles btnGoku.Click, btnIguro.Click, btnUchiha.Click, btnRoshi.Click, btnLuffy.Click, btnMoon.Click
        Dim btn = CType(sender, Button)
        Dim costumeName As String = ""
        Dim dailyPrice As Integer = 0
        Dim rentalDays As Integer = 0

        If Not Integer.TryParse(txtRentDays.Text, rentalDays) OrElse rentalDays <= 0 Then
            MessageBox.Show("Please enter a valid number of rental days.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Select Case btn.Name
            Case "btnGoku"
                costumeName = "Adult Son Goku"
                dailyPrice = 2600
            Case "btnUchiha"
                costumeName = "Uchiha Sasuke"
                dailyPrice = 2100
            Case "btnLuffy"
                costumeName = "One Piece Luffy"
                dailyPrice = 1500
            Case "btnRoshi"
                costumeName = "Master Roshi"
                dailyPrice = 1800
            Case "btnIguro"
                costumeName = "Iguro Demon Slayer"
                dailyPrice = 2200
            Case "btnMoon"
                costumeName = "Kid Moon Knight"
                dailyPrice = 2700
        End Select

        Dim discountAmount As Double = 0
        Dim rentalCost As Double = CalculateTotalCost(dailyPrice, rentalDays, discountAmount)
        rentalCount += 1
        totalRentalCost += rentalCost
        totalDiscount += discountAmount

        txtLongerRentDiscount.Text = totalDiscount.ToString("0.00")
        txtMultiCostumeDiscount.Text = If(rentalCount >= 3, "5% Applied", "No Discount")

        txtName.Text &= costumeName & " | " & rentalDays & " days " & vbNewLine
    End Sub

    Private Function CalculateTotalCost(dailyPrice As Integer, rentalDays As Integer, ByRef discountAmount As Double) As Double
        Dim total As Double = dailyPrice * rentalDays

        If rentalDays >= 10 Then
            discountAmount = total * 0.2
        ElseIf rentalDays >= 5 Then
            discountAmount = total * 0.1
        End If

        total -= discountAmount

        Return total
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtLongerRentDiscount.Clear()
        txtMultiCostumeDiscount.Clear()
        txtTotalCost.Clear()
        txtReturn.Clear()
        txtLate.Clear()
        txtRentDays.Clear()

        rentalCount = 0
        totalRentalCost = 0
        totalDiscount = 0

        btnTotal.Enabled = True
        lblLate.Visible = False
        lblReturn.Visible = False
        txtReturn.Visible = False
        txtLate.Visible = False
        btnReturn.Visible = False
        btnAgain.Visible = False

        lblRentDays.Text = "Enter Rent Days"
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim finalCost As Double = totalRentalCost

        If rentalCount >= 3 Then
            Dim multiDiscount As Double = finalCost * 0.05
            finalCost -= multiDiscount
        End If

        txtTotalCost.Text = "₱" & finalCost.ToString("0.00")

        lblLate.Visible = True
        lblReturn.Visible = True
        txtReturn.Visible = True
        txtLate.Visible = True
        btnTotal.Enabled = False
        btnReturn.Visible = True

        lblRentDays.Text = "Rent Days"
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim rentDays As Integer
        Dim returnDays As Integer

        If Not Integer.TryParse(txtRentDays.Text, rentDays) OrElse rentDays <= 0 Then
            MessageBox.Show("Please enter a valid rental days.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not Integer.TryParse(txtReturn.Text, returnDays) OrElse returnDays <= 0 Then
            MessageBox.Show("Please enter a valid return date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim lateDays As Integer = returnDays - rentDays
        Dim lateFee As Double = 0

        Dim dailyPrices As New List(Of Integer)
        Dim rentalsList As String() = txtName.Text.Split(New String() {vbNewLine}, StringSplitOptions.RemoveEmptyEntries)

        For Each rental In rentalsList
            If rental.Contains("Adult Son Goku") Then
                dailyPrices.Add(2600)
            ElseIf rental.Contains("Uchiha Sasuke") Then
                dailyPrices.Add(2100)
            ElseIf rental.Contains("One Piece Luffy") Then
                dailyPrices.Add(1500)
            ElseIf rental.Contains("Master Roshi") Then
                dailyPrices.Add(1800)
            ElseIf rental.Contains("Iguro Demon Slayer") Then
                dailyPrices.Add(2200)
            ElseIf rental.Contains("Kid Moon Knight") Then
                dailyPrices.Add(2700)
            End If
        Next

        If lateDays > 0 Then
            For Each dailyPrice In dailyPrices
                lateFee += (dailyPrice * 0.05) * lateDays
            Next
            txtLate.Text = "₱" & lateFee.ToString("0.00")
        Else
            txtLate.Text = "No Late Fee"
        End If

        Dim finalCost As Double = totalRentalCost

        If rentalCount >= 3 Then
            finalCost -= finalCost * 0.05
        End If

        finalCost += lateFee
        txtTotalCost.Text = "₱" & finalCost.ToString("0.00")
        btnAgain.Visible = True
    End Sub

    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        txtName.Text = ""
        txtLongerRentDiscount.Clear()
        txtMultiCostumeDiscount.Clear()
        txtTotalCost.Clear()
        txtReturn.Clear()
        txtLate.Clear()
        txtRentDays.Clear()

        rentalCount = 0
        totalRentalCost = 0
        totalDiscount = 0
        btnTotal.Enabled = True

        btnTotal.Enabled = True
        lblLate.Visible = False
        lblReturn.Visible = False
        txtReturn.Visible = False
        txtLate.Visible = False
        btnReturn.Visible = False
        btnAgain.Visible = False
        lblRentDays.Text = "Enter Rent Days"
    End Sub
End Class