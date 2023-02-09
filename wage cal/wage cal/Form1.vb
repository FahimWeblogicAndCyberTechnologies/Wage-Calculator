Public Class Form1
    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        'Variables
        Dim decHours As Decimal
        Dim decHourlyWage As Decimal
        Dim decGrossPay As Decimal

        'Process
        decHours = CDec(txtHours.Text)
        decHourlyWage = CDec(txtHourlyWage.Text)
        decGrossPay = decHours * decHourlyWage

        'Output
        IbIGrossPay.Text = decGrossPay.ToString("c")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
