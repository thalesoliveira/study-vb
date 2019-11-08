<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim ContactNameLabel As System.Windows.Forms.Label
        Dim ContactTitleLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim PostalCodeLabel As System.Windows.Forms.Label
        Dim RegionLabel As System.Windows.Forms.Label
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTitleTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.PostalCodeTextBox = New System.Windows.Forms.TextBox()
        Me.RegionTextBox = New System.Windows.Forms.TextBox()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        ContactNameLabel = New System.Windows.Forms.Label()
        ContactTitleLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        PostalCodeLabel = New System.Windows.Forms.Label()
        RegionLabel = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(EF_DAL.Customer)
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerBindingNavigator.BindingSource = Me.CustomerBindingSource
        Me.CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerBindingNavigatorSaveItem})
        Me.CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerBindingNavigator.Name = "CustomerBindingNavigator"
        Me.CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(630, 29)
        Me.CustomerBindingNavigator.TabIndex = 0
        Me.CustomerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 26)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CustomerBindingNavigatorSaveItem
        '
        Me.CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerBindingNavigatorSaveItem.Enabled = False
        Me.CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerBindingNavigatorSaveItem.Name = "CustomerBindingNavigatorSaveItem"
        Me.CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 26)
        Me.CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(80, 84)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 1
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(198, 81)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AddressTextBox.TabIndex = 2
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(80, 112)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(35, 17)
        CityLabel.TabIndex = 3
        CityLabel.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(198, 109)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CityTextBox.TabIndex = 4
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Location = New System.Drawing.Point(80, 140)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(112, 17)
        CompanyNameLabel.TabIndex = 5
        CompanyNameLabel.Text = "Company Name:"
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(198, 137)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CompanyNameTextBox.TabIndex = 6
        '
        'ContactNameLabel
        '
        ContactNameLabel.AutoSize = True
        ContactNameLabel.Location = New System.Drawing.Point(80, 168)
        ContactNameLabel.Name = "ContactNameLabel"
        ContactNameLabel.Size = New System.Drawing.Size(101, 17)
        ContactNameLabel.TabIndex = 7
        ContactNameLabel.Text = "Contact Name:"
        '
        'ContactNameTextBox
        '
        Me.ContactNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "ContactName", True))
        Me.ContactNameTextBox.Location = New System.Drawing.Point(198, 165)
        Me.ContactNameTextBox.Name = "ContactNameTextBox"
        Me.ContactNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ContactNameTextBox.TabIndex = 8
        '
        'ContactTitleLabel
        '
        ContactTitleLabel.AutoSize = True
        ContactTitleLabel.Location = New System.Drawing.Point(80, 196)
        ContactTitleLabel.Name = "ContactTitleLabel"
        ContactTitleLabel.Size = New System.Drawing.Size(91, 17)
        ContactTitleLabel.TabIndex = 9
        ContactTitleLabel.Text = "Contact Title:"
        '
        'ContactTitleTextBox
        '
        Me.ContactTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "ContactTitle", True))
        Me.ContactTitleTextBox.Location = New System.Drawing.Point(198, 193)
        Me.ContactTitleTextBox.Name = "ContactTitleTextBox"
        Me.ContactTitleTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ContactTitleTextBox.TabIndex = 10
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(80, 224)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(61, 17)
        CountryLabel.TabIndex = 11
        CountryLabel.Text = "Country:"
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(198, 221)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CountryTextBox.TabIndex = 12
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(80, 252)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(89, 17)
        CustomerIDLabel.TabIndex = 13
        CustomerIDLabel.Text = "Customer ID:"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(198, 249)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CustomerIDTextBox.TabIndex = 14
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(80, 280)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(34, 17)
        FaxLabel.TabIndex = 15
        FaxLabel.Text = "Fax:"
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(198, 277)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FaxTextBox.TabIndex = 16
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(80, 308)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(53, 17)
        PhoneLabel.TabIndex = 17
        PhoneLabel.Text = "Phone:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(198, 305)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PhoneTextBox.TabIndex = 18
        '
        'PostalCodeLabel
        '
        PostalCodeLabel.AutoSize = True
        PostalCodeLabel.Location = New System.Drawing.Point(80, 336)
        PostalCodeLabel.Name = "PostalCodeLabel"
        PostalCodeLabel.Size = New System.Drawing.Size(88, 17)
        PostalCodeLabel.TabIndex = 19
        PostalCodeLabel.Text = "Postal Code:"
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "PostalCode", True))
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(198, 333)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PostalCodeTextBox.TabIndex = 20
        '
        'RegionLabel
        '
        RegionLabel.AutoSize = True
        RegionLabel.Location = New System.Drawing.Point(80, 364)
        RegionLabel.Name = "RegionLabel"
        RegionLabel.Size = New System.Drawing.Size(57, 17)
        RegionLabel.TabIndex = 21
        RegionLabel.Text = "Region:"
        '
        'RegionTextBox
        '
        Me.RegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Region", True))
        Me.RegionTextBox.Location = New System.Drawing.Point(198, 361)
        Me.RegionTextBox.Name = "RegionTextBox"
        Me.RegionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.RegionTextBox.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 479)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(CompanyNameLabel)
        Me.Controls.Add(Me.CompanyNameTextBox)
        Me.Controls.Add(ContactNameLabel)
        Me.Controls.Add(Me.ContactNameTextBox)
        Me.Controls.Add(ContactTitleLabel)
        Me.Controls.Add(Me.ContactTitleTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(FaxLabel)
        Me.Controls.Add(Me.FaxTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(PostalCodeLabel)
        Me.Controls.Add(Me.PostalCodeTextBox)
        Me.Controls.Add(RegionLabel)
        Me.Controls.Add(Me.RegionTextBox)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents CompanyNameTextBox As TextBox
    Friend WithEvents ContactNameTextBox As TextBox
    Friend WithEvents ContactTitleTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents FaxTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents PostalCodeTextBox As TextBox
    Friend WithEvents RegionTextBox As TextBox
End Class
