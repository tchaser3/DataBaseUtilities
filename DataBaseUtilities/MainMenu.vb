'Title:         Main Menu
'Date:          6-26-15
'Author:        Terry Holmes

'Description:   This form is the main menu

Option Strict On

Public Class MainMenu

    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the program
        CloseProgram.ShowDialog()

    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Logon.mstrLastTransactionSummary = "LOADED DATABASE UTILITIES PROGRAM"

    End Sub

    Private Sub btnCheckLastTransactionTable_Click(sender As Object, e As EventArgs) Handles btnCheckLastTransactionTable.Click

        LastTransaction.Show()
        TheModuleUnderDevelopment.UnderDevelopment()

    End Sub

    Private Sub btnEditInventoryTables_Click(sender As Object, e As EventArgs) Handles btnEditInventoryTables.Click
        LastTransaction.Show()
        EditInventoryTables.Show()
        Me.Close()

    End Sub

    Private Sub btnCheckInventoryTables_Click(sender As Object, e As EventArgs) Handles btnCheckInventoryTables.Click
        LastTransaction.Show()
        CheckInventoryTables.Show()
        Me.Close()
    End Sub

    Private Sub btnViewLastTransaction_Click(sender As Object, e As EventArgs) Handles btnViewLastTransaction.Click

        LastTransaction.Show()
        TheModuleUnderDevelopment.UnderDevelopment()

    End Sub

    Private Sub btnInsertWarehouseID_Click(sender As Object, e As EventArgs) Handles btnInsertWarehouseID.Click

        MessageBox.Show("This Sub Routine Will Place All the Transactions to the Same Warehouse ID, Proceed with Caution", "Are You Sure You Want To Do This", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LastTransaction.Show()
        InsertWarehouseID.Show()
        Me.Close()

    End Sub
End Class