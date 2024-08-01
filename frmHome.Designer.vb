<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHome = New Label()
        btnProductManager = New Button()
        btnUpdateCategory = New Button()
        btnGenerateInvoice = New Button()
        btnCustomerInfo = New Button()
        pnlHome = New Panel()
        pnlHome.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblHome
        ' 
        lblHome.AutoSize = True
        lblHome.Location = New Point(558, 24)
        lblHome.Name = "lblHome"
        lblHome.Size = New Size(52, 20)
        lblHome.TabIndex = 0
        lblHome.Text = "HOME"
        ' 
        ' btnProductManager
        ' 
        btnProductManager.Location = New Point(51, 78)
        btnProductManager.Name = "btnProductManager"
        btnProductManager.Size = New Size(184, 84)
        btnProductManager.TabIndex = 1
        btnProductManager.Text = "Product Manager"
        btnProductManager.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateCategory
        ' 
        btnUpdateCategory.Location = New Point(366, 78)
        btnUpdateCategory.Name = "btnUpdateCategory"
        btnUpdateCategory.Size = New Size(184, 84)
        btnUpdateCategory.TabIndex = 2
        btnUpdateCategory.Text = "Update Category"
        btnUpdateCategory.UseVisualStyleBackColor = True
        ' 
        ' btnGenerateInvoice
        ' 
        btnGenerateInvoice.Location = New Point(366, 261)
        btnGenerateInvoice.Name = "btnGenerateInvoice"
        btnGenerateInvoice.Size = New Size(184, 84)
        btnGenerateInvoice.TabIndex = 4
        btnGenerateInvoice.Text = "Generate Invoice"
        btnGenerateInvoice.UseVisualStyleBackColor = True
        ' 
        ' btnCustomerInfo
        ' 
        btnCustomerInfo.Location = New Point(51, 261)
        btnCustomerInfo.Name = "btnCustomerInfo"
        btnCustomerInfo.Size = New Size(184, 84)
        btnCustomerInfo.TabIndex = 3
        btnCustomerInfo.Text = "Customer Info"
        btnCustomerInfo.UseVisualStyleBackColor = True
        ' 
        ' pnlHome
        ' 
        pnlHome.Controls.Add(btnProductManager)
        pnlHome.Controls.Add(btnCustomerInfo)
        pnlHome.Controls.Add(btnGenerateInvoice)
        pnlHome.Controls.Add(btnUpdateCategory)
        pnlHome.Location = New Point(281, 143)
        pnlHome.Name = "pnlHome"
        pnlHome.Size = New Size(604, 420)
        pnlHome.TabIndex = 5
        ' 
        ' frmHome
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1161, 741)
        Controls.Add(pnlHome)
        Controls.Add(lblHome)
        Name = "frmHome"
        Text = "Store Manager"
        pnlHome.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHome As Label
    Friend WithEvents btnProductManager As Button
    Friend WithEvents btnUpdateCategory As Button
    Friend WithEvents btnGenerateInvoice As Button
    Friend WithEvents btnCustomerInfo As Button
    Friend WithEvents pnlHome As Panel

End Class
