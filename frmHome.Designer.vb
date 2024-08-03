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
        btnProductManager = New Button()
        btnUpdateCategory = New Button()
        btnGenerateInvoice = New Button()
        btnCustomerInfo = New Button()
        pnlHome = New Panel()
        btnHome = New Button()
        pnlInvoice = New Panel()
        grpTotal = New GroupBox()
        lblGrndTotal = New Label()
        lblGrndTotalVal = New Label()
        lblTaxVal = New Label()
        lblFlatDiscVal = New Label()
        txtFlatDisc = New TextBox()
        txtTax = New TextBox()
        lblTotalAmount = New Label()
        lblTotalAmountVal = New Label()
        lblTax = New Label()
        lblFlatDiscount = New Label()
        btnViewCart = New Button()
        grpCart = New GroupBox()
        lblInvProducts = New Label()
        cmbInvProducts = New ComboBox()
        btnClearCart = New Button()
        lblQtyAvailable = New Label()
        lblInvDiscountVal = New Label()
        lblAvailableQtyVal = New Label()
        lblInvDiscount = New Label()
        lblInvQty = New Label()
        lblInvAmountVal = New Label()
        txtInvQty = New TextBox()
        lblInvAmount = New Label()
        btnAddCart = New Button()
        lblInvPriceVal = New Label()
        lblInvPrice = New Label()
        lblPaymentMethod = New Label()
        lstboxPayment = New CheckedListBox()
        lblInvCust = New Label()
        cmbInvCust = New ComboBox()
        btnGenInvoice = New Button()
        pnlProcess = New Panel()
        pnlSub = New Panel()
        txtDiscount = New TextBox()
        lblDiscount = New Label()
        txtQtyContact = New TextBox()
        lblQtyContact = New Label()
        btnDeleteProduct = New Button()
        btnAdd = New Button()
        txtPriceAddress = New TextBox()
        lblPriceAddress = New Label()
        txtDescEmail = New TextBox()
        lblDescription = New Label()
        lblCategory = New Label()
        txtProdName = New TextBox()
        lblProductName = New Label()
        cmbProdCategory = New ComboBox()
        cmbMain = New ComboBox()
        rdbtnNew = New RadioButton()
        rdbtnView = New RadioButton()
        rdbtnUpdate = New RadioButton()
        lblProcess = New Label()
        grdView = New DataGridView()
        btnHelp = New Button()
        pnlHome.SuspendLayout()
        pnlInvoice.SuspendLayout()
        grpTotal.SuspendLayout()
        grpCart.SuspendLayout()
        pnlProcess.SuspendLayout()
        pnlSub.SuspendLayout()
        CType(grdView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnProductManager
        ' 
        btnProductManager.Location = New Point(61, 76)
        btnProductManager.Name = "btnProductManager"
        btnProductManager.Size = New Size(296, 137)
        btnProductManager.TabIndex = 1
        btnProductManager.Text = "Manage Products"
        btnProductManager.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateCategory
        ' 
        btnUpdateCategory.Location = New Point(593, 76)
        btnUpdateCategory.Name = "btnUpdateCategory"
        btnUpdateCategory.Size = New Size(296, 137)
        btnUpdateCategory.TabIndex = 2
        btnUpdateCategory.Text = "Update Category"
        btnUpdateCategory.UseVisualStyleBackColor = True
        ' 
        ' btnGenerateInvoice
        ' 
        btnGenerateInvoice.Location = New Point(593, 404)
        btnGenerateInvoice.Name = "btnGenerateInvoice"
        btnGenerateInvoice.Size = New Size(296, 137)
        btnGenerateInvoice.TabIndex = 4
        btnGenerateInvoice.Text = "Generate Invoice"
        btnGenerateInvoice.UseVisualStyleBackColor = True
        ' 
        ' btnCustomerInfo
        ' 
        btnCustomerInfo.Location = New Point(61, 405)
        btnCustomerInfo.Name = "btnCustomerInfo"
        btnCustomerInfo.Size = New Size(296, 137)
        btnCustomerInfo.TabIndex = 3
        btnCustomerInfo.Text = "Customer Info"
        btnCustomerInfo.UseVisualStyleBackColor = True
        ' 
        ' pnlHome
        ' 
        pnlHome.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHome.Controls.Add(btnGenerateInvoice)
        pnlHome.Controls.Add(btnProductManager)
        pnlHome.Controls.Add(btnCustomerInfo)
        pnlHome.Controls.Add(btnUpdateCategory)
        pnlHome.Location = New Point(207, 101)
        pnlHome.Name = "pnlHome"
        pnlHome.Size = New Size(951, 624)
        pnlHome.TabIndex = 5
        ' 
        ' btnHome
        ' 
        btnHome.Anchor = AnchorStyles.Top
        btnHome.Enabled = False
        btnHome.Location = New Point(640, 16)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(94, 29)
        btnHome.TabIndex = 6
        btnHome.Text = "HOME"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' pnlInvoice
        ' 
        pnlInvoice.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlInvoice.Controls.Add(grpTotal)
        pnlInvoice.Controls.Add(btnViewCart)
        pnlInvoice.Controls.Add(grpCart)
        pnlInvoice.Controls.Add(lblPaymentMethod)
        pnlInvoice.Controls.Add(lstboxPayment)
        pnlInvoice.Controls.Add(lblInvCust)
        pnlInvoice.Controls.Add(cmbInvCust)
        pnlInvoice.Controls.Add(btnGenInvoice)
        pnlInvoice.Location = New Point(12, 175)
        pnlInvoice.Name = "pnlInvoice"
        pnlInvoice.Size = New Size(1279, 559)
        pnlInvoice.TabIndex = 7
        pnlInvoice.Visible = False
        ' 
        ' grpTotal
        ' 
        grpTotal.Controls.Add(lblGrndTotal)
        grpTotal.Controls.Add(lblGrndTotalVal)
        grpTotal.Controls.Add(lblTaxVal)
        grpTotal.Controls.Add(lblFlatDiscVal)
        grpTotal.Controls.Add(txtFlatDisc)
        grpTotal.Controls.Add(txtTax)
        grpTotal.Controls.Add(lblTotalAmount)
        grpTotal.Controls.Add(lblTotalAmountVal)
        grpTotal.Controls.Add(lblTax)
        grpTotal.Controls.Add(lblFlatDiscount)
        grpTotal.FlatStyle = FlatStyle.Popup
        grpTotal.Location = New Point(102, 341)
        grpTotal.Name = "grpTotal"
        grpTotal.Size = New Size(533, 190)
        grpTotal.TabIndex = 38
        grpTotal.TabStop = False
        grpTotal.Text = "Total"
        ' 
        ' lblGrndTotal
        ' 
        lblGrndTotal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblGrndTotal.AutoSize = True
        lblGrndTotal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblGrndTotal.Location = New Point(98, 152)
        lblGrndTotal.Name = "lblGrndTotal"
        lblGrndTotal.Size = New Size(124, 20)
        lblGrndTotal.TabIndex = 42
        lblGrndTotal.Text = "Grand Total (Rs)"
        ' 
        ' lblGrndTotalVal
        ' 
        lblGrndTotalVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblGrndTotalVal.AutoSize = True
        lblGrndTotalVal.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblGrndTotalVal.Location = New Point(367, 147)
        lblGrndTotalVal.Name = "lblGrndTotalVal"
        lblGrndTotalVal.Size = New Size(24, 28)
        lblGrndTotalVal.TabIndex = 43
        lblGrndTotalVal.Text = "0"
        ' 
        ' lblTaxVal
        ' 
        lblTaxVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTaxVal.AutoSize = True
        lblTaxVal.Location = New Point(370, 63)
        lblTaxVal.Name = "lblTaxVal"
        lblTaxVal.Size = New Size(17, 20)
        lblTaxVal.TabIndex = 41
        lblTaxVal.Text = "0"
        ' 
        ' lblFlatDiscVal
        ' 
        lblFlatDiscVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblFlatDiscVal.AutoSize = True
        lblFlatDiscVal.Location = New Point(370, 93)
        lblFlatDiscVal.Name = "lblFlatDiscVal"
        lblFlatDiscVal.Size = New Size(17, 20)
        lblFlatDiscVal.TabIndex = 40
        lblFlatDiscVal.Text = "0"
        ' 
        ' txtFlatDisc
        ' 
        txtFlatDisc.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFlatDisc.Location = New Point(266, 90)
        txtFlatDisc.Name = "txtFlatDisc"
        txtFlatDisc.Size = New Size(34, 27)
        txtFlatDisc.TabIndex = 39
        txtFlatDisc.Text = "0"
        ' 
        ' txtTax
        ' 
        txtTax.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtTax.Location = New Point(266, 56)
        txtTax.Name = "txtTax"
        txtTax.Size = New Size(34, 27)
        txtTax.TabIndex = 38
        txtTax.Text = "18"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Location = New Point(98, 32)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(128, 20)
        lblTotalAmount.TabIndex = 36
        lblTotalAmount.Text = "Total Amount (Rs)"
        ' 
        ' lblTotalAmountVal
        ' 
        lblTotalAmountVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTotalAmountVal.AutoSize = True
        lblTotalAmountVal.Location = New Point(370, 32)
        lblTotalAmountVal.Name = "lblTotalAmountVal"
        lblTotalAmountVal.Size = New Size(17, 20)
        lblTotalAmountVal.TabIndex = 37
        lblTotalAmountVal.Text = "0"
        ' 
        ' lblTax
        ' 
        lblTax.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTax.AutoSize = True
        lblTax.Location = New Point(98, 63)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(56, 20)
        lblTax.TabIndex = 32
        lblTax.Text = "Tax (%)"
        ' 
        ' lblFlatDiscount
        ' 
        lblFlatDiscount.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblFlatDiscount.AutoSize = True
        lblFlatDiscount.Location = New Point(98, 94)
        lblFlatDiscount.Name = "lblFlatDiscount"
        lblFlatDiscount.Size = New Size(121, 20)
        lblFlatDiscount.TabIndex = 34
        lblFlatDiscount.Text = "Flat Discount (%)"
        ' 
        ' btnViewCart
        ' 
        btnViewCart.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnViewCart.Location = New Point(1138, 150)
        btnViewCart.Name = "btnViewCart"
        btnViewCart.Size = New Size(111, 47)
        btnViewCart.TabIndex = 30
        btnViewCart.Text = "View Cart"
        btnViewCart.UseVisualStyleBackColor = True
        ' 
        ' grpCart
        ' 
        grpCart.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpCart.Controls.Add(lblInvProducts)
        grpCart.Controls.Add(cmbInvProducts)
        grpCart.Controls.Add(btnClearCart)
        grpCart.Controls.Add(lblQtyAvailable)
        grpCart.Controls.Add(lblInvDiscountVal)
        grpCart.Controls.Add(lblAvailableQtyVal)
        grpCart.Controls.Add(lblInvDiscount)
        grpCart.Controls.Add(lblInvQty)
        grpCart.Controls.Add(lblInvAmountVal)
        grpCart.Controls.Add(txtInvQty)
        grpCart.Controls.Add(lblInvAmount)
        grpCart.Controls.Add(btnAddCart)
        grpCart.Controls.Add(lblInvPriceVal)
        grpCart.Controls.Add(lblInvPrice)
        grpCart.FlatStyle = FlatStyle.Popup
        grpCart.Location = New Point(6, 11)
        grpCart.Name = "grpCart"
        grpCart.Size = New Size(1070, 306)
        grpCart.TabIndex = 31
        grpCart.TabStop = False
        grpCart.Text = "Add Items"
        ' 
        ' lblInvProducts
        ' 
        lblInvProducts.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblInvProducts.AutoSize = True
        lblInvProducts.Location = New Point(177, 95)
        lblInvProducts.Name = "lblInvProducts"
        lblInvProducts.Size = New Size(104, 20)
        lblInvProducts.TabIndex = 16
        lblInvProducts.Text = "Select Product"
        ' 
        ' cmbInvProducts
        ' 
        cmbInvProducts.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbInvProducts.FormattingEnabled = True
        cmbInvProducts.Location = New Point(96, 135)
        cmbInvProducts.Name = "cmbInvProducts"
        cmbInvProducts.Size = New Size(285, 28)
        cmbInvProducts.TabIndex = 15
        ' 
        ' btnClearCart
        ' 
        btnClearCart.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnClearCart.Location = New Point(710, 232)
        btnClearCart.Name = "btnClearCart"
        btnClearCart.Size = New Size(111, 47)
        btnClearCart.TabIndex = 29
        btnClearCart.Text = "Clear Cart"
        btnClearCart.UseVisualStyleBackColor = True
        ' 
        ' lblQtyAvailable
        ' 
        lblQtyAvailable.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblQtyAvailable.AutoSize = True
        lblQtyAvailable.Location = New Point(416, 95)
        lblQtyAvailable.Name = "lblQtyAvailable"
        lblQtyAvailable.Size = New Size(98, 20)
        lblQtyAvailable.TabIndex = 17
        lblQtyAvailable.Text = "Available Qty"
        ' 
        ' lblInvDiscountVal
        ' 
        lblInvDiscountVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblInvDiscountVal.AutoSize = True
        lblInvDiscountVal.Location = New Point(753, 139)
        lblInvDiscountVal.Name = "lblInvDiscountVal"
        lblInvDiscountVal.Size = New Size(17, 20)
        lblInvDiscountVal.TabIndex = 28
        lblInvDiscountVal.Text = "0"
        ' 
        ' lblAvailableQtyVal
        ' 
        lblAvailableQtyVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblAvailableQtyVal.AutoSize = True
        lblAvailableQtyVal.Location = New Point(454, 138)
        lblAvailableQtyVal.Name = "lblAvailableQtyVal"
        lblAvailableQtyVal.Size = New Size(17, 20)
        lblAvailableQtyVal.TabIndex = 18
        lblAvailableQtyVal.Text = "0"
        ' 
        ' lblInvDiscount
        ' 
        lblInvDiscount.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblInvDiscount.AutoSize = True
        lblInvDiscount.Location = New Point(728, 94)
        lblInvDiscount.Name = "lblInvDiscount"
        lblInvDiscount.Size = New Size(93, 20)
        lblInvDiscount.TabIndex = 27
        lblInvDiscount.Text = "Discount (%)"
        ' 
        ' lblInvQty
        ' 
        lblInvQty.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblInvQty.AutoSize = True
        lblInvQty.Location = New Point(638, 95)
        lblInvQty.Name = "lblInvQty"
        lblInvQty.Size = New Size(32, 20)
        lblInvQty.TabIndex = 19
        lblInvQty.Text = "Qty"
        ' 
        ' lblInvAmountVal
        ' 
        lblInvAmountVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblInvAmountVal.AutoSize = True
        lblInvAmountVal.Location = New Point(892, 139)
        lblInvAmountVal.Name = "lblInvAmountVal"
        lblInvAmountVal.Size = New Size(17, 20)
        lblInvAmountVal.TabIndex = 26
        lblInvAmountVal.Text = "0"
        ' 
        ' txtInvQty
        ' 
        txtInvQty.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtInvQty.Location = New Point(629, 135)
        txtInvQty.Name = "txtInvQty"
        txtInvQty.Size = New Size(59, 27)
        txtInvQty.TabIndex = 20
        ' 
        ' lblInvAmount
        ' 
        lblInvAmount.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblInvAmount.AutoSize = True
        lblInvAmount.Location = New Point(867, 95)
        lblInvAmount.Name = "lblInvAmount"
        lblInvAmount.Size = New Size(62, 20)
        lblInvAmount.TabIndex = 24
        lblInvAmount.Text = "Amount"
        ' 
        ' btnAddCart
        ' 
        btnAddCart.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnAddCart.Location = New Point(381, 232)
        btnAddCart.Name = "btnAddCart"
        btnAddCart.Size = New Size(111, 47)
        btnAddCart.TabIndex = 21
        btnAddCart.Text = "Add to Cart"
        btnAddCart.UseVisualStyleBackColor = True
        ' 
        ' lblInvPriceVal
        ' 
        lblInvPriceVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblInvPriceVal.AutoSize = True
        lblInvPriceVal.Location = New Point(553, 138)
        lblInvPriceVal.Name = "lblInvPriceVal"
        lblInvPriceVal.Size = New Size(17, 20)
        lblInvPriceVal.TabIndex = 23
        lblInvPriceVal.Text = "0"
        ' 
        ' lblInvPrice
        ' 
        lblInvPrice.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblInvPrice.AutoSize = True
        lblInvPrice.Location = New Point(542, 95)
        lblInvPrice.Name = "lblInvPrice"
        lblInvPrice.Size = New Size(41, 20)
        lblInvPrice.TabIndex = 22
        lblInvPrice.Text = "Price"
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Location = New Point(1109, 329)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(121, 20)
        lblPaymentMethod.TabIndex = 14
        lblPaymentMethod.Text = "Payment Method"
        ' 
        ' lstboxPayment
        ' 
        lstboxPayment.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lstboxPayment.CheckOnClick = True
        lstboxPayment.FormattingEnabled = True
        lstboxPayment.Items.AddRange(New Object() {"Cash", "Debit Card", "Credit Card", "PayPal", "UPI", "NetBanking", "Other"})
        lstboxPayment.Location = New Point(1096, 355)
        lstboxPayment.Name = "lstboxPayment"
        lstboxPayment.Size = New Size(153, 180)
        lstboxPayment.TabIndex = 13
        lstboxPayment.ThreeDCheckBoxes = True
        ' 
        ' lblInvCust
        ' 
        lblInvCust.AutoSize = True
        lblInvCust.Location = New Point(873, 338)
        lblInvCust.Name = "lblInvCust"
        lblInvCust.Size = New Size(116, 20)
        lblInvCust.TabIndex = 12
        lblInvCust.Text = "Select Customer"
        ' 
        ' cmbInvCust
        ' 
        cmbInvCust.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbInvCust.FormattingEnabled = True
        cmbInvCust.Location = New Point(790, 377)
        cmbInvCust.Name = "cmbInvCust"
        cmbInvCust.Size = New Size(275, 28)
        cmbInvCust.TabIndex = 11
        ' 
        ' btnGenInvoice
        ' 
        btnGenInvoice.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnGenInvoice.Location = New Point(830, 466)
        btnGenInvoice.Name = "btnGenInvoice"
        btnGenInvoice.Size = New Size(205, 52)
        btnGenInvoice.TabIndex = 10
        btnGenInvoice.Text = "Generate Invoice"
        btnGenInvoice.UseVisualStyleBackColor = True
        ' 
        ' pnlProcess
        ' 
        pnlProcess.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlProcess.Controls.Add(rdbtnNew)
        pnlProcess.Controls.Add(rdbtnView)
        pnlProcess.Controls.Add(rdbtnUpdate)
        pnlProcess.Controls.Add(lblProcess)
        pnlProcess.Controls.Add(pnlInvoice)
        pnlProcess.Controls.Add(pnlSub)
        pnlProcess.Location = New Point(8, 8)
        pnlProcess.Name = "pnlProcess"
        pnlProcess.Size = New Size(1303, 797)
        pnlProcess.TabIndex = 8
        pnlProcess.Visible = False
        ' 
        ' pnlSub
        ' 
        pnlSub.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSub.AutoSize = True
        pnlSub.Controls.Add(txtDiscount)
        pnlSub.Controls.Add(lblDiscount)
        pnlSub.Controls.Add(txtQtyContact)
        pnlSub.Controls.Add(lblQtyContact)
        pnlSub.Controls.Add(btnDeleteProduct)
        pnlSub.Controls.Add(btnAdd)
        pnlSub.Controls.Add(txtPriceAddress)
        pnlSub.Controls.Add(lblPriceAddress)
        pnlSub.Controls.Add(txtDescEmail)
        pnlSub.Controls.Add(lblDescription)
        pnlSub.Controls.Add(lblCategory)
        pnlSub.Controls.Add(txtProdName)
        pnlSub.Controls.Add(lblProductName)
        pnlSub.Controls.Add(cmbProdCategory)
        pnlSub.Controls.Add(cmbMain)
        pnlSub.Location = New Point(12, 163)
        pnlSub.Name = "pnlSub"
        pnlSub.Size = New Size(1285, 554)
        pnlSub.TabIndex = 3
        pnlSub.Visible = False
        ' 
        ' txtDiscount
        ' 
        txtDiscount.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDiscount.Location = New Point(572, 378)
        txtDiscount.Name = "txtDiscount"
        txtDiscount.Size = New Size(400, 27)
        txtDiscount.TabIndex = 15
        ' 
        ' lblDiscount
        ' 
        lblDiscount.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDiscount.AutoSize = True
        lblDiscount.Location = New Point(295, 381)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(93, 20)
        lblDiscount.TabIndex = 14
        lblDiscount.Text = "Discount (%)"
        ' 
        ' txtQtyContact
        ' 
        txtQtyContact.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtQtyContact.Location = New Point(572, 320)
        txtQtyContact.Name = "txtQtyContact"
        txtQtyContact.Size = New Size(400, 27)
        txtQtyContact.TabIndex = 13
        ' 
        ' lblQtyContact
        ' 
        lblQtyContact.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblQtyContact.AutoSize = True
        lblQtyContact.Location = New Point(295, 323)
        lblQtyContact.Name = "lblQtyContact"
        lblQtyContact.Size = New Size(65, 20)
        lblQtyContact.TabIndex = 12
        lblQtyContact.Text = "Quantity"
        ' 
        ' btnDeleteProduct
        ' 
        btnDeleteProduct.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnDeleteProduct.Location = New Point(799, 453)
        btnDeleteProduct.Name = "btnDeleteProduct"
        btnDeleteProduct.Size = New Size(164, 72)
        btnDeleteProduct.TabIndex = 11
        btnDeleteProduct.Text = "Delete Product"
        btnDeleteProduct.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnAdd.Location = New Point(581, 453)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(172, 72)
        btnAdd.TabIndex = 9
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' txtPriceAddress
        ' 
        txtPriceAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtPriceAddress.Location = New Point(572, 265)
        txtPriceAddress.Name = "txtPriceAddress"
        txtPriceAddress.Size = New Size(400, 27)
        txtPriceAddress.TabIndex = 7
        ' 
        ' lblPriceAddress
        ' 
        lblPriceAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblPriceAddress.AutoSize = True
        lblPriceAddress.Location = New Point(295, 268)
        lblPriceAddress.Name = "lblPriceAddress"
        lblPriceAddress.Size = New Size(86, 20)
        lblPriceAddress.TabIndex = 6
        lblPriceAddress.Text = "Price (In Rs)"
        ' 
        ' txtDescEmail
        ' 
        txtDescEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDescEmail.Location = New Point(572, 204)
        txtDescEmail.Name = "txtDescEmail"
        txtDescEmail.Size = New Size(400, 27)
        txtDescEmail.TabIndex = 5
        ' 
        ' lblDescription
        ' 
        lblDescription.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDescription.AutoSize = True
        lblDescription.Location = New Point(295, 207)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(85, 20)
        lblDescription.TabIndex = 4
        lblDescription.Text = "Description"
        ' 
        ' lblCategory
        ' 
        lblCategory.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(295, 142)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(69, 20)
        lblCategory.TabIndex = 3
        lblCategory.Text = "Category"
        ' 
        ' txtProdName
        ' 
        txtProdName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtProdName.Location = New Point(572, 85)
        txtProdName.Name = "txtProdName"
        txtProdName.Size = New Size(400, 27)
        txtProdName.TabIndex = 2
        ' 
        ' lblProductName
        ' 
        lblProductName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblProductName.AutoSize = True
        lblProductName.Location = New Point(295, 88)
        lblProductName.Name = "lblProductName"
        lblProductName.Size = New Size(104, 20)
        lblProductName.TabIndex = 1
        lblProductName.Text = "Product Name"
        ' 
        ' cmbProdCategory
        ' 
        cmbProdCategory.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbProdCategory.FormattingEnabled = True
        cmbProdCategory.Location = New Point(572, 139)
        cmbProdCategory.Name = "cmbProdCategory"
        cmbProdCategory.Size = New Size(400, 28)
        cmbProdCategory.TabIndex = 0
        ' 
        ' cmbMain
        ' 
        cmbMain.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbMain.FormattingEnabled = True
        cmbMain.Location = New Point(572, 85)
        cmbMain.Name = "cmbMain"
        cmbMain.Size = New Size(400, 28)
        cmbMain.TabIndex = 10
        ' 
        ' rdbtnNew
        ' 
        rdbtnNew.Anchor = AnchorStyles.Top
        rdbtnNew.AutoSize = True
        rdbtnNew.Location = New Point(380, 96)
        rdbtnNew.Name = "rdbtnNew"
        rdbtnNew.Size = New Size(147, 24)
        rdbtnNew.TabIndex = 4
        rdbtnNew.Text = "Add New Product"
        rdbtnNew.UseVisualStyleBackColor = True
        ' 
        ' rdbtnView
        ' 
        rdbtnView.Anchor = AnchorStyles.Top
        rdbtnView.AutoSize = True
        rdbtnView.Location = New Point(845, 96)
        rdbtnView.Name = "rdbtnView"
        rdbtnView.Size = New Size(102, 24)
        rdbtnView.TabIndex = 2
        rdbtnView.Text = "View Items"
        rdbtnView.UseVisualStyleBackColor = True
        ' 
        ' rdbtnUpdate
        ' 
        rdbtnUpdate.Anchor = AnchorStyles.Top
        rdbtnUpdate.AutoSize = True
        rdbtnUpdate.Location = New Point(626, 96)
        rdbtnUpdate.Name = "rdbtnUpdate"
        rdbtnUpdate.Size = New Size(119, 24)
        rdbtnUpdate.TabIndex = 1
        rdbtnUpdate.Text = "Update Items"
        rdbtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' lblProcess
        ' 
        lblProcess.AutoSize = True
        lblProcess.Location = New Point(18, 17)
        lblProcess.Name = "lblProcess"
        lblProcess.Size = New Size(123, 20)
        lblProcess.TabIndex = 0
        lblProcess.Text = "Product Manager"
        ' 
        ' grdView
        ' 
        grdView.AllowUserToAddRows = False
        grdView.AllowUserToDeleteRows = False
        grdView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdView.EditMode = DataGridViewEditMode.EditProgrammatically
        grdView.GridColor = SystemColors.Info
        grdView.Location = New Point(1206, 16)
        grdView.Name = "grdView"
        grdView.RowHeadersWidth = 51
        grdView.Size = New Size(99, 50)
        grdView.TabIndex = 9
        grdView.Visible = False
        ' 
        ' btnHelp
        ' 
        btnHelp.Location = New Point(1251, 9)
        btnHelp.Name = "btnHelp"
        btnHelp.Size = New Size(54, 29)
        btnHelp.TabIndex = 10
        btnHelp.Text = "Help"
        btnHelp.UseVisualStyleBackColor = True
        ' 
        ' frmHome
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1314, 797)
        Controls.Add(pnlProcess)
        Controls.Add(btnHelp)
        Controls.Add(pnlHome)
        Controls.Add(btnHome)
        Controls.Add(grdView)
        MaximizeBox = False
        Name = "frmHome"
        Text = "Store Manager"
        pnlHome.ResumeLayout(False)
        pnlInvoice.ResumeLayout(False)
        pnlInvoice.PerformLayout()
        grpTotal.ResumeLayout(False)
        grpTotal.PerformLayout()
        grpCart.ResumeLayout(False)
        grpCart.PerformLayout()
        pnlProcess.ResumeLayout(False)
        pnlProcess.PerformLayout()
        pnlSub.ResumeLayout(False)
        pnlSub.PerformLayout()
        CType(grdView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnProductManager As Button
    Friend WithEvents btnUpdateCategory As Button
    Friend WithEvents btnGenerateInvoice As Button
    Friend WithEvents btnCustomerInfo As Button
    Friend WithEvents pnlHome As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents pnlInvoice As Panel
    Friend WithEvents pnlProcess As Panel
    Friend WithEvents rdbtnUpdate As RadioButton
    Friend WithEvents lblProcess As Label
    Friend WithEvents rdbtnView As RadioButton
    Friend WithEvents rdbtnNew As RadioButton
    Friend WithEvents pnlSub As Panel
    Friend WithEvents lblProductName As Label
    Friend WithEvents cmbProdCategory As ComboBox
    Friend WithEvents txtPriceAddress As TextBox
    Friend WithEvents lblPriceAddress As Label
    Friend WithEvents txtDescEmail As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmbMain As ComboBox
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents grdView As DataGridView
    Friend WithEvents txtQtyContact As TextBox
    Friend WithEvents lblQtyContact As Label
    Friend WithEvents btnGenInvoice As Button
    Friend WithEvents lblInvCust As Label
    Friend WithEvents cmbInvCust As ComboBox
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents lstboxPayment As CheckedListBox
    Friend WithEvents lblInvProducts As Label
    Friend WithEvents cmbInvProducts As ComboBox
    Friend WithEvents txtInvQty As TextBox
    Friend WithEvents lblInvQty As Label
    Friend WithEvents lblAvailableQtyVal As Label
    Friend WithEvents lblQtyAvailable As Label
    Friend WithEvents btnAddCart As Button
    Friend WithEvents lblInvPriceVal As Label
    Friend WithEvents lblInvPrice As Label
    Friend WithEvents lblInvAmountVal As Label
    Friend WithEvents lblInvAmount As Label
    Friend WithEvents lblInvDiscountVal As Label
    Friend WithEvents lblInvDiscount As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents btnViewCart As Button
    Friend WithEvents btnClearCart As Button
    Friend WithEvents grpCart As GroupBox
    Friend WithEvents lblTotalAmountVal As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblFlatDiscount As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents grpTotal As GroupBox
    Friend WithEvents txtFlatDisc As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents lblTaxVal As Label
    Friend WithEvents lblFlatDiscVal As Label
    Friend WithEvents lblGrndTotal As Label
    Friend WithEvents lblGrndTotalVal As Label
    Friend WithEvents btnHelp As Button

End Class
