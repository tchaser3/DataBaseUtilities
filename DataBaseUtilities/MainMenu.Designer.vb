<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCheckLastTransactionTable = New System.Windows.Forms.Button()
        Me.btnEditInventoryTables = New System.Windows.Forms.Button()
        Me.btnCheckInventoryTables = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnViewLastTransaction = New System.Windows.Forms.Button()
        Me.btnInsertWarehouseID = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(177, 165)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(143, 42)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCheckLastTransactionTable
        '
        Me.btnCheckLastTransactionTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckLastTransactionTable.Location = New System.Drawing.Point(18, 119)
        Me.btnCheckLastTransactionTable.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckLastTransactionTable.Name = "btnCheckLastTransactionTable"
        Me.btnCheckLastTransactionTable.Size = New System.Drawing.Size(143, 42)
        Me.btnCheckLastTransactionTable.TabIndex = 2
        Me.btnCheckLastTransactionTable.Text = "Check Last Transaction Table"
        Me.btnCheckLastTransactionTable.UseVisualStyleBackColor = True
        '
        'btnEditInventoryTables
        '
        Me.btnEditInventoryTables.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditInventoryTables.Location = New System.Drawing.Point(177, 73)
        Me.btnEditInventoryTables.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditInventoryTables.Name = "btnEditInventoryTables"
        Me.btnEditInventoryTables.Size = New System.Drawing.Size(143, 42)
        Me.btnEditInventoryTables.TabIndex = 1
        Me.btnEditInventoryTables.Text = "Edit Inventory Tables"
        Me.btnEditInventoryTables.UseVisualStyleBackColor = True
        '
        'btnCheckInventoryTables
        '
        Me.btnCheckInventoryTables.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckInventoryTables.Location = New System.Drawing.Point(18, 73)
        Me.btnCheckInventoryTables.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckInventoryTables.Name = "btnCheckInventoryTables"
        Me.btnCheckInventoryTables.Size = New System.Drawing.Size(143, 42)
        Me.btnCheckInventoryTables.TabIndex = 0
        Me.btnCheckInventoryTables.Text = "Check Inventory Tables"
        Me.btnCheckInventoryTables.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 31)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Database Utilities"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnViewLastTransaction
        '
        Me.btnViewLastTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewLastTransaction.Location = New System.Drawing.Point(18, 165)
        Me.btnViewLastTransaction.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewLastTransaction.Name = "btnViewLastTransaction"
        Me.btnViewLastTransaction.Size = New System.Drawing.Size(143, 42)
        Me.btnViewLastTransaction.TabIndex = 4
        Me.btnViewLastTransaction.Text = "View Last Transactions"
        Me.btnViewLastTransaction.UseVisualStyleBackColor = True
        '
        'btnInsertWarehouseID
        '
        Me.btnInsertWarehouseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertWarehouseID.Location = New System.Drawing.Point(177, 119)
        Me.btnInsertWarehouseID.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInsertWarehouseID.Name = "btnInsertWarehouseID"
        Me.btnInsertWarehouseID.Size = New System.Drawing.Size(143, 42)
        Me.btnInsertWarehouseID.TabIndex = 3
        Me.btnInsertWarehouseID.Text = "Insert Warehouse ID"
        Me.btnInsertWarehouseID.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 234)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnViewLastTransaction)
        Me.Controls.Add(Me.btnInsertWarehouseID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCheckInventoryTables)
        Me.Controls.Add(Me.btnEditInventoryTables)
        Me.Controls.Add(Me.btnCheckLastTransactionTable)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCheckLastTransactionTable As System.Windows.Forms.Button
    Friend WithEvents btnEditInventoryTables As System.Windows.Forms.Button
    Friend WithEvents btnCheckInventoryTables As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnViewLastTransaction As System.Windows.Forms.Button
    Friend WithEvents btnInsertWarehouseID As System.Windows.Forms.Button
End Class
