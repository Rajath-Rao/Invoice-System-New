Imports System.Reflection.Metadata.Ecma335
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.IO
Public Class frmHome
    Const defaultcategory As String = "General"
    Private categories As List(Of Category)
    Private products As List(Of Product)
    Private customers As List(Of Customer)
    Private invoices As List(Of Invoice)
    Private cartitems As List(Of Cart)
    Private Enum appWindow
        Home = 0
        Product = 1
        Category = 2
        Customer = 3
        Invoice = 4
    End Enum
    Private currentwindow As appWindow = appWindow.Home
    '**********************************************************Control Events*********************************************************
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Initialize lists and load data from CSV files
            LoadDataFromFiles()
        Catch ex As Exception
            WriteErrLog(ex.Message, "frmHome_Load")
        End Try
    End Sub
    Private Sub btn_ClickHomePage(sender As Object, e As EventArgs) Handles btnProductManager.Click, btnGenerateInvoice.Click, btnCustomerInfo.Click, btnUpdateCategory.Click
        Try
            pnlHome.Hide()
            If sender Is btnProductManager Then
                currentwindow = appWindow.Product
            ElseIf sender Is btnUpdateCategory Then
                currentwindow = appWindow.Category
            ElseIf sender Is btnCustomerInfo Then
                currentwindow = appWindow.Customer
            ElseIf sender Is btnGenerateInvoice Then
                currentwindow = appWindow.Invoice
            End If
            SetControlTexts()
            pnlProcess.Show()
            btnHome.BringToFront()
            btnHelp.BringToFront()
            btnHome.Enabled = True
        Catch ex As Exception
            WriteErrLog(ex.Message, "btn_ClickHomePage")
        End Try
    End Sub
    Private Sub SetControlTexts()
        Try
            Select Case currentwindow
                Case appWindow.Product
                    lblProcess.Text = "Product"
                    rdbtnNew.Text = "Add New Product"
                    rdbtnUpdate.Show()
                    rdbtnUpdate.Text = "Update Items"
                    rdbtnView.Text = "View Items"
                Case appWindow.Category
                    lblProcess.Text = "Category"
                    rdbtnNew.Text = "Add New Category"
                    rdbtnUpdate.Show()
                    rdbtnUpdate.Text = "Update Categories"
                    rdbtnView.Text = "View Categories"
                Case appWindow.Customer
                    lblProcess.Text = "Customer"
                    rdbtnNew.Text = "Add New Customer"
                    rdbtnUpdate.Show()
                    rdbtnUpdate.Text = "Update Customer Info"
                    rdbtnView.Text = "View Customers"
                Case appWindow.Invoice
                    lblProcess.Text = "Invoice"
                    rdbtnUpdate.Hide()
                    rdbtnNew.Text = "New Invoice"
                    rdbtnView.Text = "Invoice History"
            End Select
        Catch ex As Exception
            WriteErrLog(ex.Message, "SetControlTexts")
        End Try
    End Sub


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Try
            currentwindow = appWindow.Home
            rdbtnNew.Checked = False
            rdbtnUpdate.Checked = False
            rdbtnView.Checked = False
            If pnlProcess.Visible = True Then
                rdbtnNew.Checked = False
                rdbtnUpdate.Checked = False
                rdbtnView.Checked = False
                pnlInvoice.Hide()
                pnlSub.Hide()
                pnlProcess.Hide()
            End If
            pnlHome.Show()
            btnHome.Enabled = False
        Catch ex As Exception
            WriteErrLog(ex.Message, "btnHome_Click")
        End Try
    End Sub

    Private Sub rdbtnNewProduct_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnNew.CheckedChanged, rdbtnUpdate.CheckedChanged
        Try
            'Set visibility and caption for the required controls since the same controls are reused for each window
            If rdbtnNew.Checked Then
                ResetTxtVals()
                cmbMain.Hide()
                btnDeleteProduct.Hide()
                txtProdName.Show()

                Select Case currentwindow
                    Case appWindow.Product
                        lblProductName.Text = "Product Name"
                        btnAdd.Text = "Add Product"
                        UpdateCmbProdCategory()
                        cmbProdCategory.Show()
                        lblDescription.Text = "Description"
                        lblCategory.Show()
                        txtPriceAddress.Show()
                        lblPriceAddress.Text = "Price (In Rs)"
                        lblPriceAddress.Show()
                        txtQtyContact.Show()
                        lblDiscount.Show()
                        txtDiscount.Show()
                        lblQtyContact.Text = "Quantity"
                        lblQtyContact.Show()
                        pnlInvoice.Hide()
                        pnlSub.Show()
                    Case appWindow.Category
                        lblProductName.Text = "Category Name"
                        btnAdd.Text = "Add Category"
                        cmbProdCategory.Hide()
                        lblCategory.Hide()
                        txtPriceAddress.Hide()
                        lblPriceAddress.Hide()
                        lblDiscount.Hide()
                        txtDiscount.Hide()
                        txtQtyContact.Hide()
                        lblQtyContact.Hide()
                        pnlInvoice.Hide()
                        pnlSub.Show()
                    Case appWindow.Customer
                        lblProductName.Text = "Customer Name"
                        btnAdd.Text = "Add Customer"
                        lblCategory.Hide()
                        cmbProdCategory.Hide()
                        lblDescription.Text = "Email"
                        txtPriceAddress.Show()
                        lblPriceAddress.Text = "Address"
                        lblPriceAddress.Show()
                        lblDiscount.Hide()
                        txtDiscount.Hide()
                        txtQtyContact.Show()
                        lblQtyContact.Text = "Contact"
                        lblQtyContact.Show()
                        pnlInvoice.Hide()
                        pnlSub.Show()
                    Case appWindow.Invoice
                        pnlSub.Hide()
                        UpdateCmbInvCust()
                        UpdateCmbInvProducts()
                        pnlInvoice.Show()
                        pnlInvoice.BringToFront()
                End Select
            ElseIf rdbtnUpdate.Checked Then
                txtProdName.Hide()
                cmbMain.Show()
                btnDeleteProduct.Show()
                UpdateCmbMain()

                Select Case currentwindow
                    Case appWindow.Product
                        lblProductName.Text = "Select Product"
                        btnAdd.Text = "Update Product"
                        lblDescription.Text = "Description"
                        UpdateCmbProdCategory()
                        cmbProdCategory.Show()
                        lblCategory.Show()
                        lblPriceAddress.Text = "Price (In Rs)"
                        txtPriceAddress.Show()
                        lblPriceAddress.Show()
                        lblDiscount.Show()
                        txtDiscount.Show()
                        txtQtyContact.Show()
                        lblQtyContact.Text = "Quantity"
                        lblQtyContact.Show()
                        btnDeleteProduct.Text = "Delete Product"
                    Case appWindow.Category
                        lblProductName.Text = "Select Category"
                        btnAdd.Text = "Update Category"
                        lblDescription.Text = "Description"
                        cmbProdCategory.Hide()
                        lblCategory.Hide()
                        txtPriceAddress.Hide()
                        lblPriceAddress.Hide()
                        lblDiscount.Hide()
                        txtDiscount.Hide()
                        txtQtyContact.Hide()
                        lblQtyContact.Hide()
                        btnDeleteProduct.Text = "Delete Category"
                    Case appWindow.Customer
                        lblProductName.Text = "Customer Name"
                        btnAdd.Text = "Update Customer Info"
                        lblCategory.Hide()
                        cmbProdCategory.Hide()
                        lblDescription.Text = "Email"
                        txtPriceAddress.Show()
                        lblPriceAddress.Text = "Address"
                        lblPriceAddress.Show()
                        lblDiscount.Hide()
                        txtDiscount.Hide()
                        txtQtyContact.Show()
                        lblQtyContact.Text = "Contact"
                        lblQtyContact.Show()
                        btnDeleteProduct.Text = "Delete Customer"
                End Select
                pnlSub.Show()
            Else
                pnlSub.Hide()
            End If
        Catch ex As Exception
            WriteErrLog(ex.Message, "rdbtnNewProduct_CheckedChanged")
        End Try
    End Sub

    Private Sub rdbtnViewProducts_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnView.CheckedChanged
        Try
            If rdbtnView.Checked Then
                With grdView
                    .Location = pnlSub.Location
                    .Size = pnlSub.Size
                    .AutoGenerateColumns = True
                    Select Case currentwindow
                        Case appWindow.Product
                            .DataSource = products
                        Case appWindow.Category
                            .DataSource = categories
                        Case appWindow.Customer
                            .DataSource = customers
                        Case appWindow.Invoice
                            Dim showinvlist = invoices.Select(Function(i) New With
                                                                  {Key .Date = i.InvoiceDate,
                                                                  Key .Customer = i.Customer.Name,
                                                                  Key .Items = String.Join("/", i.Items.Select(Function(item) item.Product)),
                                                                  Key .PaymentMethod = i.PaymentOption,
                                                                  Key .TotalAmount = i.TotalAmount}).ToList()
                            .DataSource = showinvlist
                    End Select
                    .Show()
                    .BringToFront()
                End With
            Else
                grdView.Hide()
            End If
        Catch ex As Exception
            WriteErrLog(ex.Message, "rdbtnViewProducts_CheckedChanged")
        End Try
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnGenInvoice.Click
        Try
            Dim selectitem As Object
            Dim categoryName As Category = cmbProdCategory.SelectedItem
            Dim invoicestr As String

            If CheckInputValidity() = False Then
                Exit Sub
            End If
            If rdbtnNew.Checked Then
                'Verify if already present
                If ItemExists() Then Exit Sub
                'Add item
                Select Case currentwindow
                    Case appWindow.Product
                        selectitem = New Product(txtProdName.Text, txtDescEmail.Text, Decimal.Parse(txtPriceAddress.Text), Integer.Parse(txtQtyContact.Text), categoryName.Name, Decimal.Parse(txtDiscount.Text))
                        products.Add(selectitem)
                        SaveProducts()
                        MsgBox($"New product '{txtProdName.Text}' added successfully.", Title:=MsgboxHeader)
                    Case appWindow.Category
                        selectitem = New Category(txtProdName.Text, txtDescEmail.Text)
                        categories.Add(selectitem)
                        SaveCategories()
                        MsgBox($"New category '{txtProdName.Text}' added successfully.", Title:=MsgboxHeader)
                    Case appWindow.Customer
                        selectitem = New Customer(txtProdName.Text, txtDescEmail.Text, txtPriceAddress.Text, txtQtyContact.Text) 'rajath
                        customers.Add(selectitem)
                        SaveCustomers()
                        MsgBox($"New customer '{txtProdName.Text}' added successfully.", Title:=MsgboxHeader)
                    Case appWindow.Invoice
                        If ValidateInvoice() = False Then
                            Exit Sub
                        End If
                        selectitem = New Invoice(Now, cmbInvCust.Items(cmbInvCust.SelectedIndex), cartitems, lstboxPayment.SelectedItem.ToString, Decimal.Parse(lblGrndTotalVal.Text)) 'rajath
                        invoices.Add(selectitem)
                        SaveInvoices()
                        invoicestr = CreateInvoice()
                        Dim invoicefolder As String = System.IO.Path.Combine(Application.StartupPath, "Invoices")
                        Dim invoicepath As String = System.IO.Path.Combine(invoicefolder, $"{cmbInvCust.Text}_{Now.ToString("dd-MM-yyyy_HH-mm-ss")}.txt")
                        If Not Directory.Exists(invoicefolder) Then
                            ' Create the directory if it does not exist
                            Directory.CreateDirectory(invoicefolder)
                        End If
                        Using wrtr As New StreamWriter(invoicepath)
                            wrtr.Write(invoicestr)
                        End Using
                        'MsgBox(invoicestr, Title:=MsgboxHeader)
                        Process.Start("notepad.exe", invoicepath)
                    Case Else
                        Exit Sub
                End Select
                ResetTxtVals()
            ElseIf rdbtnUpdate.Checked Then
                Select Case currentwindow
                    Case appWindow.Product
                        selectitem = products.FirstOrDefault(Function(p) p.Name = cmbMain.Text)
                        If selectitem IsNot Nothing Then
                            With selectitem
                                .Category = categoryName.Name
                                .Description = txtDescEmail.Text
                                .Price = txtPriceAddress.Text
                                .Quantity = txtQtyContact.Text
                                .PercentgeDiscount = txtDiscount.Text
                            End With
                        End If
                        SaveProducts()
                        MsgBox("Changes have been updated.", Title:=MsgboxHeader)
                    Case appWindow.Category
                        selectitem = categories.FirstOrDefault(Function(p) p.Name = cmbMain.Text)
                        If selectitem IsNot Nothing Then
                            With selectitem
                                .Description = txtDescEmail.Text
                            End With
                        End If
                        SaveCategories()
                        MsgBox("Changes have been updated.", Title:=MsgboxHeader)
                    Case appWindow.Customer
                        selectitem = customers.FirstOrDefault(Function(p) p.Name = cmbMain.Text)
                        If selectitem IsNot Nothing Then
                            With selectitem
                                .Email = txtDescEmail.Text
                                .Address = txtPriceAddress.Text
                                .ContactNumber = txtQtyContact.Text
                            End With
                        End If
                        SaveCustomers()
                        MsgBox("Changes have been updated.", Title:=MsgboxHeader)
                    Case Else
                        Exit Sub
                End Select
            End If
            LoadDataFromFiles()
        Catch ex As Exception
            WriteErrLog(ex.Message, "btnAdd_Click")
        End Try
    End Sub
    Private Sub cmbProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMain.SelectedIndexChanged
        Try
            Dim selproduct As Object
            selproduct = cmbMain.SelectedItem

            Select Case currentwindow
                Case appWindow.Product
                    For Each item As Object In cmbProdCategory.Items
                        If item.GetType().GetProperty("Name").GetValue(item, Nothing).ToString() = selproduct.Category Then
                            cmbProdCategory.SelectedItem = item
                            Exit For
                        End If
                    Next
                    txtDescEmail.Text = selproduct.Description
                    txtPriceAddress.Text = selproduct.Price
                    txtQtyContact.Text = selproduct.Quantity
                    txtDiscount.Text = selproduct.PercentgeDiscount
                Case appWindow.Category
                    txtDescEmail.Text = selproduct.Description
                Case appWindow.Customer
                    txtDescEmail.Text = selproduct.Email
                    txtPriceAddress.Text = selproduct.Address
                    txtQtyContact.Text = selproduct.ContactNumber
                Case appWindow.Invoice
                    '.DataSource = invoices
            End Select

            If currentwindow = appWindow.Product Then
            End If

        Catch ex As Exception
            WriteErrLog(ex.Message, "UpdateCmbProdCategory")
        End Try
    End Sub
    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        Try
            Dim selectitem As Object

            If MsgBox($"Do you want to remove {cmbMain.Text} from your system?", MsgBoxStyle.YesNo, MsgboxHeader) = MsgBoxResult.No Then
                Exit Sub
            End If
            Select Case currentwindow
                Case appWindow.Product
                    selectitem = products.FirstOrDefault(Function(p) p.Name = cmbMain.Text)
                    If selectitem IsNot Nothing Then
                        products.Remove(selectitem)
                    End If
                    SaveProducts()
                Case appWindow.Category
                    selectitem = categories.FirstOrDefault(Function(p) p.Name = cmbMain.Text)
                    If selectitem IsNot Nothing Then
                        categories.Remove(selectitem)
                    End If
                    SaveCategories()
                Case appWindow.Customer
                    selectitem = customers.FirstOrDefault(Function(p) p.Name = cmbMain.Text)
                    If selectitem IsNot Nothing Then
                        customers.Remove(selectitem)
                    End If
                    SaveCustomers()
                Case Else
                    Exit Sub
            End Select
            MsgBox($"{cmbMain.Text} deleted successfully.", Title:=MsgboxHeader)
            LoadDataFromFiles()
            UpdateCmbMain()
        Catch ex As Exception
            WriteErrLog(ex.Message, "btnDeleteProduct_Click")
        End Try
    End Sub

    Private Sub cmbInvProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbInvProducts.SelectedIndexChanged
        Try
            Dim prod As Product = cmbInvProducts.SelectedItem
            txtInvQty.Text = 0
            lblAvailableQtyVal.Text = Val(prod.Quantity)
            lblInvPriceVal.Text = prod.Price
            lblInvDiscountVal.Text = prod.PercentgeDiscount

        Catch ex As Exception
            WriteErrLog(ex.Message, "cmbInvProducts_SelectedIndexChanged")
        End Try
    End Sub

    Private Sub txtInvQty_TextChanged(sender As Object, e As EventArgs) Handles txtInvQty.TextChanged
        Try
            If CheckInputValidity() = False Then
                Exit Sub
            End If
            lblInvAmountVal.Text = CalculateProductAmount(Decimal.Parse(lblInvPriceVal.Text), Val(txtInvQty.Text), Decimal.Parse(lblInvDiscountVal.Text))
        Catch ex As Exception
            WriteErrLog(ex.Message, "txtInvQty_TextChanged")
        End Try
    End Sub
    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click
        Try
            If cartitems IsNot Nothing Then
                cartitems.Clear()
            End If
            ResetTxtVals(True)
        Catch ex As Exception
            WriteErrLog(ex.Message, "btnClearCart_Click")
        End Try
    End Sub

    Private Sub btnViewCart_Click(sender As Object, e As EventArgs) Handles btnViewCart.Click
        Try
            If grdView.Visible Then
                grdView.Hide()
                btnViewCart.Text = "View Cart"
            Else
                With grdView
                    .Location = pnlInvoice.Location
                    .Size = grpCart.Size
                    .AutoGenerateColumns = True
                    .DataSource = cartitems
                    .Show()
                    .BringToFront()
                End With
                btnViewCart.Text = "Hide Cart"
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnAddCart_Click(sender As Object, e As EventArgs) Handles btnAddCart.Click
        Try
            If Val(txtInvQty.Text) > 0 Then
                Dim newitem As New Cart(cmbInvProducts.Text, Decimal.Parse(lblInvPriceVal.Text), Integer.Parse(txtInvQty.Text), Decimal.Parse(lblInvDiscountVal.Text))
                If cartitems Is Nothing Then
                    cartitems = New List(Of Cart)
                End If
                cartitems.Add(newitem)
                MsgBox($"Item: {cmbInvProducts.Text} (Qty: {txtInvQty.Text}) added to cart", Title:=MsgboxHeader)
                ShowGrandTotal()
                ResetTxtVals()
            End If
        Catch ex As Exception
            WriteErrLog(ex.Message, "btnAddCart_Click")
        End Try
    End Sub

    Private Sub txtTax_TextChanged(sender As Object, e As EventArgs) Handles txtTax.TextChanged, txtFlatDisc.TextChanged
        Try
            ShowGrandTotal()
        Catch ex As Exception
            WriteErrLog(ex.Message, "txtTax_TextChanged")
        End Try
    End Sub
    Private Sub lstboxPayment_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lstboxPayment.ItemCheck
        Try
            'Select only 1 item at a time
            If e.NewValue = CheckState.Checked Then
                ' Uncheck all other items
                For i As Integer = 0 To lstboxPayment.Items.Count - 1
                    If i <> e.Index Then
                        lstboxPayment.SetItemChecked(i, False)
                    End If
                Next
            End If
        Catch ex As Exception
            WriteErrLog(ex.Message, "lstboxPayment_ItemCheck")
        End Try
    End Sub
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Try
            Dim helpfile As String = System.IO.Path.Combine(Application.StartupPath, "Help.txt")
            If IO.File.Exists(helpfile) Then
                Process.Start("Notepad.exe", helpfile)
            End If
        Catch ex As Exception
            WriteErrLog(ex.Message, "btnHelp_Click")
        End Try
    End Sub

    '*******************************************************Load and Save data****************************************************

    Private Sub LoadDataFromFiles()
        Try
            'Initialize lists and load data from CSV files
            Select Case currentwindow
                Case appWindow.Home
                    categories = LoadCategories()
                    If categories.Count = 0 Then 'Default Category
                        categories.Add(New Category(defaultcategory, "General items")) 'rajath save
                    End If
                    products = LoadProducts()
                    customers = LoadCustomers()
                    invoices = LoadInvoices()
                Case appWindow.Product
                    products = LoadProducts()
                Case appWindow.Category
                    categories = LoadCategories()
                    If categories.Count = 0 Then 'Default Category
                        categories.Add(New Category(defaultcategory, "General items")) 'rajath save
                    End If
                Case appWindow.Customer
                    customers = LoadCustomers()
                Case appWindow.Invoice
                    invoices = LoadInvoices()
            End Select
        Catch ex As Exception
            WriteErrLog(ex.Message, "frmHome_Load")
        End Try
    End Sub

    Private Function LoadCategories() As List(Of Category)
        Try
            Dim categoryLines = ReadFromFile("categories.csv")
            Return categoryLines.Select(Function(line) Category.FromCsvString(line)).ToList()
        Catch ex As Exception
            WriteErrLog(ex.Message, "LoadCategories")
        End Try
    End Function

    Private Function LoadProducts() As List(Of Product)
        Try
            Dim productLines = ReadFromFile("products.csv")
            Return productLines.Select(Function(line) Product.FromCsvString(line)).ToList()
        Catch ex As Exception
            WriteErrLog(ex.Message, "LoadProducts")
        End Try
    End Function

    Private Function LoadCustomers() As List(Of Customer)
        Try
            Dim customerLines = ReadFromFile("customers.csv")
            Return customerLines.Select(Function(line) Customer.FromCsvString(line)).ToList()
        Catch ex As Exception
            WriteErrLog(ex.Message, "LoadCustomers")
        End Try
    End Function

    Private Function LoadInvoices() As List(Of Invoice)
        Try
            Dim invoiceLines = ReadFromFile("invoices.csv")
            Return invoiceLines.Select(Function(line) Invoice.FromCsvString(line)).ToList()
        Catch ex As Exception
            WriteErrLog(ex.Message, "LoadInvoices")
        End Try
    End Function

    Private Sub SaveCategories()
        Try
            WriteToFile("categories.csv", categories.Select(Function(c) c.ToCsvString()))
        Catch ex As Exception
            WriteErrLog(ex.Message, "SaveCategories")
        End Try
    End Sub

    Private Sub SaveProducts()
        Try
            WriteToFile("products.csv", products.Select(Function(p) p.ToCsvString()))
        Catch ex As Exception
            WriteErrLog(ex.Message, "SaveProducts")
        End Try
    End Sub

    Private Sub SaveCustomers()
        Try
            WriteToFile("customers.csv", customers.Select(Function(c) c.ToCsvString()))
        Catch ex As Exception
            WriteErrLog(ex.Message, "SaveCustomers")
        End Try
    End Sub

    Private Sub SaveInvoices()
        Try
            WriteToFile("invoices.csv", invoices.Select(Function(i) i.ToCsvString()))
        Catch ex As Exception
            WriteErrLog(ex.Message, "SaveInvoices")
        End Try
    End Sub
    '********************************************************Populate Combo Box Controls****************************************************
    Private Sub UpdateCmbProdCategory()
        Try
            cmbProdCategory.DataSource = categories
            cmbProdCategory.DisplayMember = "Name"
        Catch ex As Exception
            WriteErrLog(ex.Message, "UpdateCmbProdCategory")
        End Try
    End Sub
    Private Sub UpdateCmbInvCust()
        Try
            'rajath cmbInvCust.DataSource = customers.Select(Function(c) c.Name).ToList()
            cmbInvCust.DataSource = customers
            cmbInvCust.DisplayMember = "Name"
        Catch ex As Exception
            WriteErrLog(ex.Message, "UpdateCmbInvCust")
        End Try
    End Sub
    Private Sub UpdateCmbInvProducts()
        Try
            cmbInvProducts.DataSource = products
            cmbInvProducts.DisplayMember = "Name"
        Catch ex As Exception
            WriteErrLog(ex.Message, "UpdateCmbInvProducts")
        End Try
    End Sub

    Private Sub UpdateCmbMain()
        Try
            Select Case currentwindow
                Case appWindow.Product
                    cmbMain.DataSource = products
                Case appWindow.Category
                    cmbMain.DataSource = categories
                Case appWindow.Customer
                    cmbMain.DataSource = customers
                Case Else
                    Exit Sub
            End Select
            cmbMain.DisplayMember = "Name"
            cmbMain.ValueMember = "Name"

            If cmbMain.Items.Count = 0 Then
                cmbMain.Text = ""
                ResetTxtVals()
            End If
        Catch ex As Exception
            WriteErrLog(ex.Message, "UpdateCmbProdCategory")
        End Try
    End Sub
    '************************************************************ Data Validation****************************************************
    Private Function CheckInputValidity() As Boolean
        Try
            Select Case currentwindow
                Case appWindow.Product
                    If rdbtnNew.Checked Then
                        If txtProdName.Text = "" Then
                            MsgBox("Please update a valid product name", Title:=MsgboxHeader)
                            Return False
                        End If
                        txtProdName.Text = Replace(txtProdName.Text, ",", ";")
                        txtProdName.Text = Replace(txtProdName.Text, """", "'")
                    End If
                    Try
                        Integer.Parse(txtQtyContact.Text)
                    Catch ex As Exception
                        MsgBox("Entered quantity is invalid", Title:=MsgboxHeader)
                        Return False
                    End Try
                    Try
                        Decimal.Parse(txtPriceAddress.Text)
                    Catch ex As Exception
                        MsgBox("Please enter valid price", Title:=MsgboxHeader)
                        Return False
                    End Try
                    'Consider as zero if discount not updated
                    If txtDiscount.Text = "" Then txtDiscount.Text = 0
                    'Remove % char if entered
                    txtDiscount.Text = Replace(txtDiscount.Text, "%", "")
                    Try
                        Decimal.Parse(txtDiscount.Text)
                    Catch ex As Exception
                        MsgBox("Please enter valid discount rate", Title:=MsgboxHeader)
                        Return False
                    End Try
                    'rajath - Temporarily handled to escape while writing to CSV
                    txtDescEmail.Text = Replace(txtDescEmail.Text, ",", ";")
                    txtDescEmail.Text = Replace(txtDescEmail.Text, """", "'")
                Case appWindow.Category
                    If rdbtnNew.Checked Then
                        If txtProdName.Text = "" Then
                            MsgBox("Please update a category name", Title:=MsgboxHeader)
                            Return False
                        End If
                    End If
                    txtProdName.Text = Replace(txtProdName.Text, ",", ";")
                    txtProdName.Text = Replace(txtProdName.Text, """", "'")
                    txtDescEmail.Text = Replace(txtDescEmail.Text, ",", ";")
                    txtDescEmail.Text = Replace(txtDescEmail.Text, """", "'")
                Case appWindow.Customer
                    If rdbtnNew.Checked Then
                        If txtProdName.Text = "" Then
                            MsgBox("Please update customer name", Title:=MsgboxHeader)
                            Return False
                        End If
                    End If
                    'Considering only 10 digit contact numbers for now
                    Try
                        Double.Parse(txtQtyContact.Text)
                    Catch ex As Exception
                        MsgBox("Please enter a valid contact number", Title:=MsgboxHeader)
                        Return False
                    End Try
                    If Len(txtQtyContact.Text) <> 10 Then
                        MsgBox("Please enter a valid 10 digit contact number", Title:=MsgboxHeader)
                        Return False
                    End If
                    txtProdName.Text = Replace(txtProdName.Text, ",", ";")
                    txtProdName.Text = Replace(txtProdName.Text, """", "'")
                    txtDescEmail.Text = Replace(txtDescEmail.Text, ",", ";")
                    txtDescEmail.Text = Replace(txtDescEmail.Text, """", "'")
                    txtPriceAddress.Text = Replace(txtPriceAddress.Text, ",", ";")
                    txtPriceAddress.Text = Replace(txtPriceAddress.Text, """", "'")
                Case appWindow.Invoice
                    If txtInvQty.Text <> "" Then
                        Try
                            Integer.Parse(txtInvQty.Text)
                        Catch ex As Exception
                            MsgBox("Please enter a valid quantity value", Title:=MsgboxHeader)
                            Return False
                        End Try
                    End If
                    If Val(txtInvQty.Text) > Val(lblAvailableQtyVal.Text) Then
                        MsgBox("Entered quantity for the product is more than the available stock", Title:=MsgboxHeader)
                        txtInvQty.Text = 0
                        Return False
                    End If
                    'Consider as zero if discount not updated
                    If txtFlatDisc.Text = "" Then txtFlatDisc.Text = 0
                    'Remove % char if entered
                    txtFlatDisc.Text = Replace(txtFlatDisc.Text, "%", "")
                    Try
                        Decimal.Parse(txtFlatDisc.Text)
                    Catch ex As Exception
                        MsgBox("Please enter valid discount rate", Title:=MsgboxHeader)
                        Return False
                    End Try
                    'Consider as zero if discount not updated
                    If txtTax.Text = "" Then txtTax.Text = 0
                    'Remove % char if entered
                    txtTax.Text = Replace(txtTax.Text, "%", "")
                    Try
                        Decimal.Parse(txtTax.Text)
                    Catch ex As Exception
                        MsgBox("Please enter valid tax rate", Title:=MsgboxHeader)
                        Return False
                    End Try
                Case appWindow.Home
                    Return False
            End Select
            Return True
        Catch ex As Exception
            WriteErrLog(ex.Message, "CheckInputValidity")
        End Try
    End Function

    Private Function ItemExists() As Boolean
        Try
            Select Case currentwindow
                Case appWindow.Product
                    If products.Any(Function(p) p.Name = txtProdName.Text) Then
                        MsgBox("The product that you wish to add already exists.", Title:=MsgboxHeader)
                        Return True
                    End If
                Case appWindow.Category
                    If categories.Any(Function(p) p.Name = txtProdName.Text) Then
                        MsgBox("The category that you wish to add already exists.", Title:=MsgboxHeader)
                        Return True
                    End If
                Case appWindow.Customer
                    If customers.Any(Function(p) p.Name = txtProdName.Text) Then
                        MsgBox("The customer that you wish to add already exists.", Title:=MsgboxHeader)
                        Return True
                    End If
                Case Else
                    Exit Function
            End Select
        Catch ex As Exception
            WriteErrLog(ex.Message, "ItemExists")
        End Try
    End Function
    Private Function ValidateInvoice() As Boolean
        Try
            If cartitems Is Nothing OrElse cartitems.Count = 0 Then
                MsgBox("Your cart is empty", Title:=MsgboxHeader)
                Return False
            End If
            If cmbInvCust.Text = "" Then
                MsgBox("Please select a valid customer or add new customer info", Title:=MsgboxHeader)
                Return False
            End If
            If lstboxPayment.CheckedItems.Count = 0 Then
                MsgBox("Please select a payment method", Title:=MsgboxHeader)
                Return False
            End If
            Return True
        Catch ex As Exception
            WriteErrLog(ex.Message, "ValidateInvoice")
        End Try
    End Function
    '*******************************************************Invoice Generation****************************************************

    Private Sub ShowGrandTotal()
        Try
            Dim TotalAmt As Decimal = 0
            If cartitems IsNot Nothing AndAlso cartitems.Count > 0 Then
                'rajath - Commented due to issue where duplicate properties show in list. To be checked later 
                'lblTotalAmountVal.Text = cartitems.Sum(Function(c) c.Amount) + Decimal.Parse(lblInvAmountVal.Text)
                For Each item As Cart In cartitems
                    TotalAmt += item.Amount
                Next
                lblTotalAmountVal.Text = TotalAmt.ToString("F2")
                'TotalAmt = Decimal.Parse(lblTotalAmountVal.Text)
                lblTaxVal.Text = (Decimal.Parse(txtTax.Text) * TotalAmt / 100).ToString("F2")
                lblFlatDiscVal.Text = (Decimal.Parse(txtFlatDisc.Text) * TotalAmt / 100).ToString("F2")
                lblGrndTotalVal.Text = (TotalAmt - Decimal.Parse(lblFlatDiscVal.Text) + Decimal.Parse(lblTaxVal.Text)).ToString("F2")
            Else
                ResetTxtVals(True)
            End If
        Catch ex As Exception
            WriteErrLog(ex.Message, "ShowGrandTotal")
        End Try
    End Sub

    Private Function CreateInvoice() As String
        Try
            Dim spacing As String = " | "
            Dim strStrt As String = $"INVOICE{vbCrLf & vbCrLf}Date: {Now}{vbCrLf}Customer: {cmbInvCust.Text}{vbCrLf}PaymentMethod: {lstboxPayment.SelectedItem.ToString}{vbCrLf & vbCrLf}"
            Dim strend As String = $"Total: {lblTotalAmountVal.Text}{vbCrLf}Tax (@{txtTax.Text}%): {lblTaxVal.Text}{vbCrLf}Flat Discount (@{txtFlatDisc.Text}%): {lblFlatDiscVal.Text}{vbCrLf & vbCrLf}Grand Total (Rs): {lblGrndTotalVal.Text}"
            Dim items As String = ""
            For Each item As Cart In cartitems
                items &= $"Item:{item.Product}{spacing}Price:{item.Price}{spacing}Qty:{item.Quantity}{spacing}Discount(%):{item.Percentage_Discount}{spacing}Amount:{item.Amount}{vbCrLf}"
            Next
            Return (strStrt & items & vbCrLf & strend)
        Catch ex As Exception
            WriteErrLog(ex.Message, "CreateInvoice")
        End Try
    End Function
    '*******************************************************Reset Input Controls****************************************************

    Private Sub ResetTxtVals(Optional clearinvoice As Boolean = False)
        Try
            txtProdName.Text = ""
            txtDescEmail.Text = ""
            txtPriceAddress.Text = ""
            txtQtyContact.Text = ""
            txtDiscount.Text = 0
            txtInvQty.Text = 0
            If clearinvoice = True Then
                lblTotalAmountVal.Text = 0
                lblTaxVal.Text = 0
                lblFlatDiscVal.Text = 0
                lblGrndTotalVal.Text = 0
            End If
        Catch ex As Exception
            WriteErrLog(ex.Message, "ResetTxtVals")
        End Try
    End Sub

End Class
