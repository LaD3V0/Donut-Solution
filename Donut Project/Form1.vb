Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub SubCalc(ByRef beforCalc As Decimal)
        If radSugar.Checked Or radGlazed.Checked = True Then
            beforCalc = 1.05D
        ElseIf radChocolate.Checked = True Then
            beforCalc = 1.25D
        ElseIf radFilled.Checked = True Then
            beforCalc = 1.5D
        End If

        If radRegular.Checked = True Then
            beforCalc += 1.5D
        ElseIf radCapp.Checked = True Then
            beforCalc += 2.75D
        End If
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decSubTotal As Decimal
        Dim decSalesTaxes As Decimal
        Dim decTotal As Decimal

        SubCalc(decSubTotal)

        decSalesTaxes =
        decTotal = 

    End Sub
    Private Sub ClearOutput(sender As Object, e As EventArgs) Handles radChocolate.CheckedChanged, radFilled.CheckedChanged,
            radGlazed.CheckedChanged, radSugar.CheckedChanged, radNone.CheckedChanged, radRegular.CheckedChanged, radSugar.CheckedChanged
        Label2.Text = String.Empty
        Label3.Text = String.Empty
        Label5.Text = String.Empty
    End Sub
End Class
