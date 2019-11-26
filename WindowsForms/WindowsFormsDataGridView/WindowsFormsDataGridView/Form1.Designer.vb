<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NorthwndDataSet = New WindowsFormsDataGridView.northwndDataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New WindowsFormsDataGridView.northwndDataSetTableAdapters.CustomersTableAdapter()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.RegionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostalCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NorthwndDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.CompanyNameDataGridViewTextBoxColumn, Me.ContactNameDataGridViewTextBoxColumn, Me.ContactTitleDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.RegionDataGridViewTextBoxColumn, Me.PostalCodeDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.FaxDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomersBindingSource
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        '
        'NorthwndDataSet
        '
        Me.NorthwndDataSet.DataSetName = "northwndDataSet"
        Me.NorthwndDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.NorthwndDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Frozen = True
        resources.ApplyResources(Me.CustomerIDDataGridViewTextBoxColumn, "CustomerIDDataGridViewTextBoxColumn")
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'CompanyNameDataGridViewTextBoxColumn
        '
        Me.CompanyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName"
        resources.ApplyResources(Me.CompanyNameDataGridViewTextBoxColumn, "CompanyNameDataGridViewTextBoxColumn")
        Me.CompanyNameDataGridViewTextBoxColumn.Name = "CompanyNameDataGridViewTextBoxColumn"
        '
        'ContactNameDataGridViewTextBoxColumn
        '
        Me.ContactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName"
        resources.ApplyResources(Me.ContactNameDataGridViewTextBoxColumn, "ContactNameDataGridViewTextBoxColumn")
        Me.ContactNameDataGridViewTextBoxColumn.Name = "ContactNameDataGridViewTextBoxColumn"
        '
        'ContactTitleDataGridViewTextBoxColumn
        '
        Me.ContactTitleDataGridViewTextBoxColumn.DataPropertyName = "ContactTitle"
        resources.ApplyResources(Me.ContactTitleDataGridViewTextBoxColumn, "ContactTitleDataGridViewTextBoxColumn")
        Me.ContactTitleDataGridViewTextBoxColumn.Name = "ContactTitleDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        resources.ApplyResources(Me.AddressDataGridViewTextBoxColumn, "AddressDataGridViewTextBoxColumn")
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.DataSource = Me.CustomersBindingSource
        Me.CityDataGridViewTextBoxColumn.DisplayMember = "City"
        resources.ApplyResources(Me.CityDataGridViewTextBoxColumn, "CityDataGridViewTextBoxColumn")
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CityDataGridViewTextBoxColumn.ValueMember = "City"
        '
        'RegionDataGridViewTextBoxColumn
        '
        Me.RegionDataGridViewTextBoxColumn.DataPropertyName = "Region"
        resources.ApplyResources(Me.RegionDataGridViewTextBoxColumn, "RegionDataGridViewTextBoxColumn")
        Me.RegionDataGridViewTextBoxColumn.Name = "RegionDataGridViewTextBoxColumn"
        '
        'PostalCodeDataGridViewTextBoxColumn
        '
        Me.PostalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode"
        resources.ApplyResources(Me.PostalCodeDataGridViewTextBoxColumn, "PostalCodeDataGridViewTextBoxColumn")
        Me.PostalCodeDataGridViewTextBoxColumn.Name = "PostalCodeDataGridViewTextBoxColumn"
        '
        'CountryDataGridViewTextBoxColumn
        '
        Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        resources.ApplyResources(Me.CountryDataGridViewTextBoxColumn, "CountryDataGridViewTextBoxColumn")
        Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        resources.ApplyResources(Me.PhoneDataGridViewTextBoxColumn, "PhoneDataGridViewTextBoxColumn")
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'FaxDataGridViewTextBoxColumn
        '
        Me.FaxDataGridViewTextBoxColumn.DataPropertyName = "Fax"
        resources.ApplyResources(Me.FaxDataGridViewTextBoxColumn, "FaxDataGridViewTextBoxColumn")
        Me.FaxDataGridViewTextBoxColumn.Name = "FaxDataGridViewTextBoxColumn"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NorthwndDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NorthwndDataSet As northwndDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As northwndDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanyNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents RegionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PostalCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
