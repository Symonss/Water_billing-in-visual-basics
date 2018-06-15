Public Class Form1
    Dim account_type As String

    Private Property units As String

    'Dim Name As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblTop_Header_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTop_Header.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbAc_Type.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtIdNumber.Clear()
        txtUnits.Clear()
        lstbData.Items.Clear()



    End Sub

    Private Sub rbtnUnMetered_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnUnMetered.CheckedChanged
        account_type = "Un-metered"
        lbltest.Text = account_type






    End Sub

    Private Sub rbtnMetered_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnMetered.CheckedChanged
        account_type = "Metered"
        lbltest.Text = account_type
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Name = txtIdNumber.Text
        units = txtUnits.Text
        lstbData.Items.Add("Your Id is:" + Name)
        lstbData.Items.Add("You used " + units + " s")
        lstbData.Items.Add("You are a" + account_type + " Client")
    End Sub

    Private Sub lstbData_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstbData.SelectedIndexChanged

    End Sub

    'This sub is for Exiting the application

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnTo_Pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTo_Pay.Click
        CheckOut.Show()
        'Me.Close()
    End Sub
End Class
