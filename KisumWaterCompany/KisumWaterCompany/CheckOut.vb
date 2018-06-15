Public Class CheckOut

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNotification.Click
        lblNotification.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

    End Sub

    Private Sub btnReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceipt.Click

    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        Dim Amount As Double
        Amount = txtAmount.Text
        If (Amount < 500) Then


        End If



    End Sub

    Private Sub CheckOutLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class