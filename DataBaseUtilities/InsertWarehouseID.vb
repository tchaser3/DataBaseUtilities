'Title:         Insert Warehouse ID
'Date:          7-1-15
'Author:        Terry Holmes

'Description:   This form will place a transaction ID in all the transaction tables

Option Strict On

Public Class InsertWarehouseID

    'Setting up the data componentes
    Private TheBOMPartsDataSet As BOMPartsDataSet
    Private TheBOMPartsDataTier As BOMPartsDataTier
    Private WithEvents TheBOMPartsBindingSource As BindingSource

    Private TheReceivePartsDataSet As ReceivePartsDataSet
    Private TheReceivePartsDataTier As ReceivePartsDataTier
    Private WithEvents TheReceivePartsBindingSource As BindingSource

    Private TheIssuedPartsDataSet As IssuedPartsDataSet
    Private TheIssuedPartsDataTier As IssuedPartsDataTier
    Private WithEvents TheIssuedPartsBindingSource As BindingSource

    Private TheEmployeeDataSet As EmployeeDataSet
    Private TheEmployeeDataTier As EmployeeDataTier
    Private WithEvents TheEmployeeBindingSource As BindingSource

    Dim mintSelectedIndex() As Integer
    Dim mintCounter As Integer
    Dim mintUpperLimit As Integer
    Dim mstrTableType As String
    Dim mintWarehouseID As Integer

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click

        LastTransaction.Show()
        MainMenu.Show()
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        CloseProgram.ShowDialog()

    End Sub

    Private Sub InsertWarehouseID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will set up the navication controls
        'Setting Local Variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim strLastNameFromTable As String
        Dim strLastNameForSearch As String = "PARTS"

        'try catch for exceptions
        Try

            'Setting up the data variables
            TheEmployeeDataTier = New EmployeeDataTier
            TheEmployeeDataSet = TheEmployeeDataTier.GetEmployeeInformation
            TheEmployeeBindingSource = New BindingSource

            'Setting up the binding source
            With TheEmployeeBindingSource
                .DataSource = TheEmployeeDataSet
                .DataMember = "employees"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboEmployeeID
                .DataSource = TheEmployeeBindingSource
                .DisplayMember = "EmployeeID"
                .DataBindings.Add("text", TheEmployeeBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting the rest of the controls
            txtFirstName.DataBindings.Add("text", TheEmployeeBindingSource, "FirstName")
            txtLastName.DataBindings.Add("Text", TheEmployeeBindingSource, "LastName")

            'Setting up for the loop
            intNumberOfRecords = cboEmployeeID.Items.Count - 1
            ReDim mintSelectedIndex(intNumberOfRecords)
            mintCounter = 0

            'beginning Loop
            For intCounter = 0 To intNumberOfRecords

                'incrementing the combo box
                cboEmployeeID.SelectedIndex = intCounter

                'Getting the last name
                strLastNameFromTable = txtLastName.Text

                'If statements to see if it matches
                If strLastNameForSearch = strLastNameFromTable Then

                    'Setting the array
                    mintSelectedIndex(mintCounter) = intCounter
                    mintCounter += 1

                End If
            Next

            mintUpperLimit = mintCounter - 1
            mintCounter = 0
            If mintUpperLimit > 0 Then
                btnNext.Enabled = True
            End If
            cboEmployeeID.SelectedIndex = mintSelectedIndex(0)
            SetControlsVisible(False)
            btnProcess.Enabled = False
           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        'This will increment the combo box
        mintCounter += 1
        cboEmployeeID.SelectedIndex = mintSelectedIndex(mintCounter)

        btnBack.Enabled = True

        If mintUpperLimit = mintCounter Then
            btnNext.Enabled = False
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'this will decrement the counter
        mintCounter -= 1
        cboEmployeeID.SelectedIndex = mintSelectedIndex(mintCounter)

        btnNext.Enabled = True

        If mintCounter = 0 Then
            btnBack.Enabled = False
        End If

    End Sub

    Private Sub ClearDataBindings()

        'this will clear the data bindings
        cboTransactionID.DataBindings.Clear()
        txtMSRNumber.DataBindings.Clear()
        txtDate.DataBindings.Clear()
        txtPartNumber.DataBindings.Clear()
        txtProjectID.DataBindings.Clear()
        txtQuantity.DataBindings.Clear()
        txtWarehouseID.DataBindings.Clear()

    End Sub
    Private Sub SetReceivedDataBindings()

        'This will bind the received bindings
        Try
            TheReceivePartsDataTier = New ReceivePartsDataTier
            TheReceivePartsDataSet = TheReceivePartsDataTier.GetReceivePartsInformation
            TheReceivePartsBindingSource = New BindingSource

            'Setting up the binding source
            With TheReceivePartsBindingSource
                .DataSource = TheReceivePartsDataSet
                .DataMember = "ReceivedParts"
                .MoveFirst()
                .MoveLast()
            End With

            'setting up the combo box
            With cboTransactionID
                .DataSource = TheReceivePartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheReceivePartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtDate.DataBindings.Add("text", TheReceivePartsBindingSource, "Date")
            txtMSRNumber.DataBindings.Add("text", TheReceivePartsBindingSource, "MSRNumber")
            txtPartNumber.DataBindings.Add("text", TheReceivePartsBindingSource, "PartNumber")
            txtProjectID.DataBindings.Add("Text", TheReceivePartsBindingSource, "ProjectID")
            txtQuantity.DataBindings.Add("Text", TheReceivePartsBindingSource, "QTY")
            txtWarehouseID.DataBindings.Add("text", TheReceivePartsBindingSource, "WarehouseID")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub SetIssuedDataBindings()

        Try
            TheIssuedPartsDataTier = New IssuedPartsDataTier
            TheIssuedPartsDataSet = TheIssuedPartsDataTier.GetIssuedPartsInformation
            TheIssuedPartsBindingSource = New BindingSource

            'Setting up the binding source
            With TheIssuedPartsBindingSource
                .DataSource = TheIssuedPartsDataSet
                .DataMember = "IssuedParts"
                .MoveFirst()
                .MoveLast()
            End With

            'setting up the combo box
            With cboTransactionID
                .DataSource = TheIssuedPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheIssuedPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtDate.DataBindings.Add("text", TheIssuedPartsBindingSource, "Date")
            txtPartNumber.DataBindings.Add("text", TheIssuedPartsBindingSource, "PartNumber")
            txtProjectID.DataBindings.Add("Text", TheIssuedPartsBindingSource, "ProjectID")
            txtQuantity.DataBindings.Add("Text", TheIssuedPartsBindingSource, "QTY")
            txtWarehouseID.DataBindings.Add("text", TheIssuedPartsBindingSource, "WarehouseID")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SetBOMDataBindings()

        Try
            TheBOMPartsDataTier = New BOMPartsDataTier
            TheBOMPartsDataSet = TheBOMPartsDataTier.GetBOMPartsInformation
            TheBOMPartsBindingSource = New BindingSource

            'Setting up the binding source
            With TheBOMPartsBindingSource
                .DataSource = TheBOMPartsDataSet
                .DataMember = "BOMParts"
                .MoveFirst()
                .MoveLast()
            End With

            'setting up the combo box
            With cboTransactionID
                .DataSource = TheBOMPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheBOMPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'setting up the rest of the controls
            txtDate.DataBindings.Add("text", TheBOMPartsBindingSource, "Date")
            txtPartNumber.DataBindings.Add("text", TheBOMPartsBindingSource, "PartNumber")
            txtProjectID.DataBindings.Add("Text", TheBOMPartsBindingSource, "ProjectID")
            txtQuantity.DataBindings.Add("Text", TheBOMPartsBindingSource, "QTY")
            txtWarehouseID.DataBindings.Add("text", TheBOMPartsBindingSource, "WarehouseID")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SetControlsVisible(ByVal valueBoolean As Boolean)

        txtMSRNumber.Visible = valueBoolean
        txtDate.Visible = valueBoolean
        txtPartNumber.Visible = valueBoolean
        txtProjectID.Visible = valueBoolean
        txtQuantity.Visible = valueBoolean
        txtWarehouseID.Visible = valueBoolean

    End Sub

    Private Sub btnSelectWarehouse_Click(sender As Object, e As EventArgs) Handles btnSelectWarehouse.Click

        'This will set the warehouse ID
        mintWarehouseID = CInt(cboEmployeeID.Text)
        btnProcess.Enabled = True
        btnSelectWarehouse.Enabled = False
        InventoryIDConfirmation.ShowDialog()

    End Sub
    Private Sub EditRecords(ByVal strTableType As String)

        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer

        'Getting ready for the loop
        intNumberOfRecords = cboTransactionID.Items.Count - 1

        'Performing loop
        For intCounter = 0 To intNumberOfRecords

            'incrementing the combo box
            cboTransactionID.SelectedIndex = intCounter

            'setting up the control
            txtWarehouseID.Text = CStr(mintWarehouseID)

            Try

                If strTableType = "RECEIVE" Then
                    TheReceivePartsBindingSource.EndEdit()
                    TheReceivePartsDataTier.UpdateReceivePartsDB(TheReceivePartsDataSet)
                ElseIf strTableType = "ISSUED" Then
                    TheIssuedPartsBindingSource.EndEdit()
                    TheIssuedPartsDataTier.UpdateIssuedPartsDB(TheIssuedPartsDataSet)
                ElseIf strTableType = "BOM" Then
                    TheBOMPartsBindingSource.EndEdit()
                    TheBOMPartsDataTier.UpdateBOMPartsDB(TheBOMPartsDataSet)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

           
        Next

    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        'this will process the transaction
        PleaseWait.Show()
        SetControlsVisible(True)
        cboTransactionID.Visible = True
        ClearDataBindings()
        SetReceivedDataBindings()
        mstrTableType = "RECEIVE"
        EditRecords(mstrTableType)
        ClearDataBindings()
        SetIssuedDataBindings()
        mstrTableType = "ISSUED"
        EditRecords(mstrTableType)
        ClearDataBindings()
        SetBOMDataBindings()
        mstrTableType = "BOM"
        EditRecords(mstrTableType)
        PleaseWait.Close()

        MessageBox.Show("Process Complete, The Form Will Now Close", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MainMenu.Show()
        Me.Close()

    End Sub
End Class