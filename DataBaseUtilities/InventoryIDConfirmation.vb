'Title:         InventoryIDConfirmation
'Date:          7-1-15
'Author:        Terry Holmes

'Description:   This form is used as a confirmation that you want to continue

Option Strict On

Public Class InventoryIDConfirmation

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click

        Me.Close()

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

        'This will return you to the main menu
        Logon.mstrLastTransactionSummary = "UPDATING WAREHOUSE ID WAS CANCELLED"
        LastTransaction.Show()
        InsertWarehouseID.Close()
        MainMenu.Show()
        Me.Close()

    End Sub
End Class