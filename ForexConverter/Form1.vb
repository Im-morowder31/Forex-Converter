Public Class Form1

    Dim exchangeRates As New Dictionary(Of String, Decimal)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = "From"
        ComboBox2.SelectedItem = "To"
        TextBoxResult.Font = New Font("Microsoft Sans Serif", 20, FontStyle.Regular)
        TextBoxAmount.Font = New Font("Microsoft Sans Serif", 20, FontStyle.Regular)
        'US Dollar
        exchangeRates.Add("US Dollar to US Dollar", 1.0)
        exchangeRates.Add("US Dollar to Hong Kong Dollar", 7.82)
        exchangeRates.Add("US Dollar to Canadian Dollar", 1.37)
        exchangeRates.Add("US Dollar to Philippine Peso", 56.81)
        exchangeRates.Add("US Dollar to Indian Rupee", 83.28)
        exchangeRates.Add("US Dollar to Sri Lankan Rupee", 324.15)
        exchangeRates.Add("US Dollar to UAE Dinar", 3.67)
        exchangeRates.Add("US Dollar to UK Pound", 0.82)
        exchangeRates.Add("US Dollar to Japan Yen", 149.56)
        exchangeRates.Add("US Dollar to Euro", 0.95)
        'Hong Kong Dollar
        exchangeRates.Add("Hong Kong Dollar to US Dollar", 0.13)
        exchangeRates.Add("Hong Kong Dollar to Hong Kong Dollar", 1.0)
        exchangeRates.Add("Hong Kong Dollar to Canadian Dollar", 0.17)
        exchangeRates.Add("Hong Kong Dollar to Philippine Peso", 7.26)
        exchangeRates.Add("Hong Kong Dollar to Indian Rupee", 10.64)
        exchangeRates.Add("Hong Kong Dollar to Sri Lankan Rupee", 41.43)
        exchangeRates.Add("Hong Kong Dollar to UAE Dinar", 0.47)
        exchangeRates.Add("Hong Kong Dollar to UK Pound", 0.11)
        exchangeRates.Add("Hong Kong Dollar to Japan Yen", 19.12)
        exchangeRates.Add("Hong Kong Dollar to Euro", 0.12)
        'Canadian Dollar
        exchangeRates.Add("Canadian Dollar to US Dollar", 0.73)
        exchangeRates.Add("Canadian Dollar to Hong Kong Dollar", 5.72)
        exchangeRates.Add("Canadian Dollar to Canadian Dollar", 1.0)
        exchangeRates.Add("Canadian Dollar to Philippine Peso", 41.56)
        exchangeRates.Add("Canadian Dollar to Indian Rupee", 60.93)
        exchangeRates.Add("Canadian Dollar to Sri Lankan Rupee", 237.15)
        exchangeRates.Add("Canadian Dollar to UAE Dinar", 2.69)
        exchangeRates.Add("Canadian Dollar to UK Pound", 0.6)
        exchangeRates.Add("Canadian Dollar to Japan Yen", 109.42)
        exchangeRates.Add("Canadian Dollar to Euro", 0.7)
        'Indian Rupee
        exchangeRates.Add("Indian Rupee to US Dollar", 0.012)
        exchangeRates.Add("Indian Rupee to Hong Kong Dollar", 0.094)
        exchangeRates.Add("Indian Rupee to Canadian Dollar", 0.016)
        exchangeRates.Add("Indian Rupee to Philippine Peso", 0.68)
        exchangeRates.Add("Indian Rupee to Indian Rupee", 1.0)
        exchangeRates.Add("Indian Rupee to Sri Lankan Rupee", 3.89)
        exchangeRates.Add("Indian Rupee to UAE Dinar", 0.044)
        exchangeRates.Add("Indian Rupee to UK Pound", 0.0099)
        exchangeRates.Add("Indian Rupee to Japan Yen", 1.8)
        exchangeRates.Add("Indian Rupee to Euro", 0.011)
        'Sri Lankan Rupee
        exchangeRates.Add("Sri Lankan Rupee to US Dollar", 0.0031)
        exchangeRates.Add("Sri Lankan Rupee to Hong Kong Dollar", 0.024)
        exchangeRates.Add("Sri Lankan Rupee to Canadian Dollar", 0.0042)
        exchangeRates.Add("Sri Lankan Rupee to Philippine Peso", 0.18)
        exchangeRates.Add("Sri Lankan Rupee to Indian Rupee", 0.26)
        exchangeRates.Add("Sri Lankan Rupee to Sri Lankan Rupee", 1.0)
        exchangeRates.Add("Sri Lankan Rupee to UAE Dinar", 0.011)
        exchangeRates.Add("Sri Lankan Rupee to UK Pound", 0.0025)
        exchangeRates.Add("Sri Lankan Rupee to Japan Yen", 0.46)
        exchangeRates.Add("Sri Lankan Rupee to Euro", 0.0029)
        'UAE Dinar
        exchangeRates.Add("UAE Dinar to US Dollar", 0.27)
        exchangeRates.Add("UAE Dinar to Hong Kong Dollar", 2.13)
        exchangeRates.Add("UAE Dinar to Canadian Dollar", 0.37)
        exchangeRates.Add("UAE Dinar to Philippine Peso", 15.47)
        exchangeRates.Add("UAE Dinar to Indian Rupee", 22.67)
        exchangeRates.Add("UAE Dinar to Sri Lankan Rupee", 88.25)
        exchangeRates.Add("UAE Dinar to UAE Dinar", 1.0)
        exchangeRates.Add("UAE Dinar to UK Pound", 0.22)
        exchangeRates.Add("UAE Dinar to Japan Yen", 40.72)
        exchangeRates.Add("UAE Dinar to Euro", 0.26)
        'Philippine Peso
        exchangeRates.Add("Philippine Peso to US Dollar", 0.018)
        exchangeRates.Add("Philippine Peso to Hong Kong Dollar", 0.14)
        exchangeRates.Add("Philippine Peso to Canadian Dollar", 0.024)
        exchangeRates.Add("Philippine Peso to Philippine Peso", 1.0)
        exchangeRates.Add("Philippine Peso to Indian Rupee", 1.47)
        exchangeRates.Add("Philippine Peso to Sri Lankan Rupee", 5.71)
        exchangeRates.Add("Philippine Peso to UAE Dinar", 0.065)
        exchangeRates.Add("Philippine Peso to UK Pound", 0.015)
        exchangeRates.Add("Philippine Peso to Japan Yen", 2.63)
        exchangeRates.Add("Philippine Peso to Euro", 0.017)
        'UK Pound
        exchangeRates.Add("UK Pound to US Dollar", 1.21)
        exchangeRates.Add("UK Pound to Hong Kong Dollar", 9.49)
        exchangeRates.Add("UK Pound to Canadian Dollar", 1.65)
        exchangeRates.Add("UK Pound to Philippine Peso", 68.88)
        exchangeRates.Add("UK Pound to Indian Rupee", 100.97)
        exchangeRates.Add("UK Pound to Sri Lankan Rupee", 393.0)
        exchangeRates.Add("UK Pound to UAE Dinar", 4.45)
        exchangeRates.Add("UK Pound to UK Pound", 1.0)
        exchangeRates.Add("UK Pound to Japan Yen", 181.25)
        exchangeRates.Add("UK Pound to Euro", 1.15)
        'Japan Yen
        exchangeRates.Add("Japan Yen to US Dollar", 0.0067)
        exchangeRates.Add("Japan Yen to Hong Kong Dollar", 0.052)
        exchangeRates.Add("Japan Yen to Canadian Dollar", 0.0091)
        exchangeRates.Add("Japan Yen to Philippine Peso", 0.38)
        exchangeRates.Add("Japan Yen to Indian Rupee", 0.56)
        exchangeRates.Add("Japan Yen to Sri Lankan Rupee", 2.17)
        exchangeRates.Add("Japan Yen to UAE Dinar", 0.025)
        exchangeRates.Add("Japan Yen to UK Pound", 0.0055)
        exchangeRates.Add("Japan Yen to Japan Yen", 1.0)
        exchangeRates.Add("Japan Yen to Euro", 0.0064)
        'Euro
        exchangeRates.Add("Euro to US Dollar", 1.05)
        exchangeRates.Add("Euro to Hong Kong Dollar", 8.22)
        exchangeRates.Add("Euro to Canadian Dollar", 1.44)
        exchangeRates.Add("Euro to Philippine Peso", 59.76)
        exchangeRates.Add("Euro to Indian Rupee", 87.56)
        exchangeRates.Add("Euro to Sri Lankan Rupee", 340.77)
        exchangeRates.Add("Euro to UAE Dinar", 3.86)
        exchangeRates.Add("Euro to UK Pound", 0.87)
        exchangeRates.Add("Euro to Japan Yen", 157.24)
        exchangeRates.Add("Euro to Euro", 1.0)





    End Sub
    Function ConvertCurrency(amount As Decimal, sourceCurrency As String, targetCurrency As String) As Decimal

        Dim rateKey As String = sourceCurrency & " to " & targetCurrency
        If exchangeRates.ContainsKey(rateKey) Then
            Return amount * exchangeRates(rateKey)
        Else

            Return 0
        End If
    End Function

    Private Sub btnConvert_MouseDown(sender As Object, e As MouseEventArgs) Handles btnConvert.MouseDown
        btnConvert.Image = My.Resources.Frame_7
    End Sub

    Private Sub btnConvert_MouseUp(sender As Object, e As MouseEventArgs) Handles btnConvert.MouseUp
        btnConvert.Image = My.Resources.Frame_4
    End Sub



    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim sourceCurrency As String = ComboBox1.SelectedItem.ToString()
        Dim targetCurrency As String = ComboBox2.SelectedItem.ToString()
        Dim amount As Decimal

        If ComboBox1.SelectedItem = "From" Or ComboBox2.SelectedItem = "To" Or TextBoxAmount.Text = "" Then
            MessageBox.Show("Please choose currency or amount to convert!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Decimal.TryParse(TextBoxAmount.Text, amount) Then
            Dim result As Decimal = ConvertCurrency(amount, sourceCurrency, targetCurrency)

            If targetCurrency = "Philippine Peso" Then
                TextBoxResult.Text = "₱" & result.ToString("N2")
            ElseIf targetCurrency = "Hong Kong Dollar" Then
                TextBoxResult.Text = "HK" & result.ToString("C2")
            ElseIf targetCurrency = "Indian Rupee" Then
                TextBoxResult.Text = "₹" & result.ToString("N2")
            ElseIf targetCurrency = "Sri Lankan Rupee" Then
                TextBoxResult.Text = "Rs." & result.ToString("N2")
            ElseIf targetCurrency = "UAE Dinar" Then
                TextBoxResult.Text = "AED " & result.ToString("N2")
            ElseIf targetCurrency = "UK Pound" Then
                TextBoxResult.Text = "£" & result.ToString("N2")
            ElseIf targetCurrency = "Japan Yen" Then
                TextBoxResult.Text = "¥" & result.ToString("N2")
            ElseIf targetCurrency = "Euro" Then
                TextBoxResult.Text = "€" & result.ToString("N2")
            Else
                TextBoxResult.Text = result.ToString("C2")
            End If
        Else

            If Not String.IsNullOrEmpty(TextBoxAmount.Text) Then
                TextBoxResult.Text = "Invalid Amount"
            End If
        End If


    End Sub

    Private Sub TextBoxAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAmount.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("Input only numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnClear_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClear.MouseDown
        btnClear.Image = My.Resources.Frame_10
    End Sub

    Private Sub btnClear_MouseUp(sender As Object, e As MouseEventArgs) Handles btnClear.MouseUp
        btnClear.Image = My.Resources.Frame_11
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ComboBox1.SelectedItem = "From"
        ComboBox2.SelectedItem = "To"
        TextBoxAmount.Text = ""
        TextBoxResult.Text = ""
    End Sub

    Private Sub btnSwitch_Click(sender As Object, e As EventArgs) Handles btnSwitch.Click
        Dim isComboBox1FromOrTo = ComboBox1.SelectedItem.ToString() = "From" Or ComboBox1.SelectedItem.ToString() = "To"
        Dim isComboBox2FromOrTo = ComboBox2.SelectedItem.ToString() = "From" Or ComboBox2.SelectedItem.ToString() = "To"


        If isComboBox1FromOrTo Or isComboBox2FromOrTo Then
            Exit Sub
        End If


        Dim selectedItem1 As Object = ComboBox1.SelectedItem
        Dim selectedItem2 As Object = ComboBox2.SelectedItem
        ComboBox1.SelectedItem = selectedItem2
        ComboBox2.SelectedItem = selectedItem1
    End Sub
End Class
