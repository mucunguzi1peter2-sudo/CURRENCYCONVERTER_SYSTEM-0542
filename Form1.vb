Public Class Form1
    Const UGX_TO_YUAN_RATE As Decimal = 540D
    Const UGX_TO_DIRHAM_RATE As Decimal = 110D
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear all text boxes when the application starts
        txtUGXToYuan.Clear()
        txtYuan.Clear()
        txtYuanToUGX.Clear()
        txtUGXFromYuan.Clear()

        txtUGXToDirham.Clear()
        txtDirham.Clear()
        txtDirhamToUGX.Clear()
        txtUGXFromDirham.Clear()

        'Make output fields read-only
        txtYuan.ReadOnly = True
        txtUGXFromYuan.ReadOnly = True
        txtDirham.ReadOnly = True
        txtUGXFromDirham.ReadOnly = True

        'Set the cursor to the first input field
        txtUGXToYuan.Focus()

    End Sub

    Private Sub btnConvertToYuan_Click(sender As Object, e As EventArgs) Handles btnConvertToYuan.Click
        Dim UGXAmount As Decimal
        Dim YuanAmount As Decimal

        'Check whether the user entered an amount
        If txtUGXToYuan.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter the amount in UGX.",
                "Input Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtUGXToYuan.Focus()
            Exit Sub

        End If


        'Check whether the entered value is a valid number
        If Not Decimal.TryParse(txtUGXToYuan.Text, UGXAmount) Then

            MessageBox.Show(
                "Please enter a valid numeric amount.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            txtUGXToYuan.SelectAll()
            txtUGXToYuan.Focus()
            Exit Sub

        End If


        'Check for negative amount
        If UGXAmount < 0 Then

            MessageBox.Show(
                "Amount cannot be negative.",
                "Invalid Amount",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtUGXToYuan.SelectAll()
            txtUGXToYuan.Focus()
            Exit Sub

        End If


        'Perform conversion
        YuanAmount = UGXAmount / UGX_TO_YUAN_RATE


        'Display result
        txtYuan.Text = YuanAmount.ToString("N2")

    End Sub

    Private Sub btnConvertToUGXYuan_Click(sender As Object, e As EventArgs) Handles btnConvertToUGXYuan.Click
        Dim yuanAmount As Decimal
        Dim ugxAmount As Decimal

        'Check whether amount has been entered
        If txtUGXToYuan.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter the amount in Chinese Yuan.",
                "Input Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtUGXToYuan.Focus()
            Exit Sub

        End If


        'Validate input
        If Not Decimal.TryParse(txtUGXToYuan.Text, yuanAmount) Then

            MessageBox.Show(
                "Please enter a valid numeric amount.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            txtUGXToYuan.SelectAll()
            txtUGXToYuan.Focus()
            Exit Sub

        End If


        'Check for negative value
        If yuanAmount < 0 Then

            MessageBox.Show(
                "Amount cannot be negative.",
                "Invalid Amount",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtUGXToYuan.SelectAll()
            txtUGXToYuan.Focus()
            Exit Sub

        End If


        'Perform conversion
        ugxAmount = yuanAmount * UGX_TO_YUAN_RATE


        'Display result
        txtUGXFromYuan.Text = ugxAmount.ToString("N2")

    End Sub

    Private Sub btnConvertToDirham_Click(sender As Object, e As EventArgs) Handles btnConvertToDirham.Click
        Dim UGXAmount As Decimal
        Dim DirhamAmount As Decimal

        'Check whether amount has been entered
        If txtUGXToDirham.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter the amount in UGX.",
                "Input Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtUGXToDirham.Focus()
            Exit Sub

        End If


        'Validate input
        If Not Decimal.TryParse(txtUGXToDirham.Text, ugxAmount) Then

            MessageBox.Show(
                "Please enter a valid numeric amount.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            txtUGXToDirham.SelectAll()
            txtUGXToDirham.Focus()
            Exit Sub

        End If


        'Check for negative amount
        If ugxAmount < 0 Then

            MessageBox.Show(
                "Amount cannot be negative.",
                "Invalid Amount",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtUGXToDirham.SelectAll()
            txtUGXToDirham.Focus()
            Exit Sub

        End If


        'Perform conversion
        DirhamAmount = UGXAmount / UGX_TO_DIRHAM_RATE


        'Display result
        txtDirham.Text = DirhamAmount.ToString("N2")

    End Sub

    Private Sub btnConvertToUGXDirham_Click(sender As Object, e As EventArgs) Handles btnConvertToUGXDirham.Click
        Dim dirhamAmount As Decimal
        Dim ugxAmount As Decimal

        'Check whether amount has been entered
        If txtDirhamToUGX.Text.Trim() = "" Then

            MessageBox.Show(
                "Please enter the amount in UAE Dirham.",
                "Input Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtDirhamToUGX.Focus()
            Exit Sub

        End If


        'Validate input
        If Not Decimal.TryParse(txtDirhamToUGX.Text, dirhamAmount) Then

            MessageBox.Show(
                "Please enter a valid numeric amount.",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            txtDirhamToUGX.SelectAll()
            txtDirhamToUGX.Focus()
            Exit Sub

        End If


        'Check for negative value
        If dirhamAmount < 0 Then

            MessageBox.Show(
                "Amount cannot be negative.",
                "Invalid Amount",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            txtDirhamToUGX.SelectAll()
            txtDirhamToUGX.Focus()
            Exit Sub

        End If


        'Perform conversion
        ugxAmount = dirhamAmount * UGX_TO_DIRHAM_RATE


        'Display result
        txtUGXFromDirham.Text = ugxAmount.ToString("N2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear UGX/Yuan conversion
        txtUGXToYuan.Clear()
        txtYuan.Clear()

        'Clear Yuan/UGX conversion
        txtYuanToUGX.Clear()
        txtUGXFromYuan.Clear()

        'Clear UGX/Dirham conversion
        txtUGXToDirham.Clear()
        txtDirham.Clear()

        'Clear Dirham/UGX conversion
        txtDirhamToUGX.Clear()
        txtUGXFromDirham.Clear()

        'Return cursor to first field
        txtUGXToYuan.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim answer As DialogResult

        answer = MessageBox.Show(
            "Are you sure you want to exit Kabbya Forex Bureau?",
            "Exit Application",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If answer = DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub
End Class
