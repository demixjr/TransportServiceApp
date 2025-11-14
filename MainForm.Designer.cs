namespace TransportServiceApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.роботаЗТаблицямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientDataGrid = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportServiceDBDataSet = new TransportServiceApp.TransportServiceDBDataSet();
            this.clientTableAdapter = new TransportServiceApp.TransportServiceDBDataSetTableAdapters.ClientTableAdapter();
            this.DriverDataGrid = new System.Windows.Forms.DataGridView();
            this.driverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceYearsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTableAdapter = new TransportServiceApp.TransportServiceDBDataSetTableAdapters.DriverTableAdapter();
            this.DriverLicenseDataGrid = new System.Windows.Forms.DataGridView();
            this.licenseIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverLicenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverLicenseTableAdapter = new TransportServiceApp.TransportServiceDBDataSetTableAdapters.DriverLicenseTableAdapter();
            this.RouteDataGrid = new System.Windows.Forms.DataGridView();
            this.routeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedTimeHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeTableAdapter = new TransportServiceApp.TransportServiceDBDataSetTableAdapters.RouteTableAdapter();
            this.ServiceDataGrid = new System.Windows.Forms.DataGridView();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new TransportServiceApp.TransportServiceDBDataSetTableAdapters.ServiceTableAdapter();
            this.ServiceTypeDataGrid = new System.Windows.Forms.DataGridView();
            this.serviceTypeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTypeTableAdapter = new TransportServiceApp.TransportServiceDBDataSetTableAdapters.ServiceTypeTableAdapter();
            this.TransportDataGrid = new System.Windows.Forms.DataGridView();
            this.transportIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensePlateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportTableAdapter = new TransportServiceApp.TransportServiceDBDataSetTableAdapters.TransportTableAdapter();
            this.TransportTypeDataGrid = new System.Windows.Forms.DataGridView();
            this.transportTypeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportTypeTableAdapter = new TransportServiceApp.TransportServiceDBDataSetTableAdapters.TransportTypeTableAdapter();
            this.клієнтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.водіїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.водійськіПосвідченняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршрутиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.послугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типиПослугToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автотранспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типиАвтотранспортуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportServiceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverLicenseDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverLicenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransportDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransportTypeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.роботаЗТаблицямиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1431, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // роботаЗТаблицямиToolStripMenuItem
            // 
            this.роботаЗТаблицямиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клієнтиToolStripMenuItem,
            this.водіїToolStripMenuItem,
            this.водійськіПосвідченняToolStripMenuItem,
            this.маршрутиToolStripMenuItem,
            this.послугиToolStripMenuItem,
            this.типиПослугToolStripMenuItem,
            this.автотранспортToolStripMenuItem,
            this.типиАвтотранспортуToolStripMenuItem});
            this.роботаЗТаблицямиToolStripMenuItem.Name = "роботаЗТаблицямиToolStripMenuItem";
            this.роботаЗТаблицямиToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.роботаЗТаблицямиToolStripMenuItem.Text = "Робота з таблицями";
            // 
            // ClientDataGrid
            // 
            this.ClientDataGrid.AutoGenerateColumns = false;
            this.ClientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.ClientDataGrid.DataSource = this.clientBindingSource;
            this.ClientDataGrid.Location = new System.Drawing.Point(0, 31);
            this.ClientDataGrid.Name = "ClientDataGrid";
            this.ClientDataGrid.RowHeadersWidth = 51;
            this.ClientDataGrid.RowTemplate.Height = 24;
            this.ClientDataGrid.Size = new System.Drawing.Size(679, 110);
            this.ClientDataGrid.TabIndex = 1;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.transportServiceDBDataSet;
            // 
            // transportServiceDBDataSet
            // 
            this.transportServiceDBDataSet.DataSetName = "TransportServiceDBDataSet";
            this.transportServiceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // DriverDataGrid
            // 
            this.DriverDataGrid.AutoGenerateColumns = false;
            this.DriverDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.driverIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.experienceYearsDataGridViewTextBoxColumn,
            this.licenseIDDataGridViewTextBoxColumn});
            this.DriverDataGrid.DataSource = this.driverBindingSource;
            this.DriverDataGrid.Location = new System.Drawing.Point(0, 147);
            this.DriverDataGrid.Name = "DriverDataGrid";
            this.DriverDataGrid.RowHeadersWidth = 51;
            this.DriverDataGrid.RowTemplate.Height = 24;
            this.DriverDataGrid.Size = new System.Drawing.Size(805, 110);
            this.DriverDataGrid.TabIndex = 2;
            // 
            // driverIDDataGridViewTextBoxColumn
            // 
            this.driverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID";
            this.driverIDDataGridViewTextBoxColumn.HeaderText = "DriverID";
            this.driverIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driverIDDataGridViewTextBoxColumn.Name = "driverIDDataGridViewTextBoxColumn";
            this.driverIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            this.phoneDataGridViewTextBoxColumn1.Width = 125;
            // 
            // experienceYearsDataGridViewTextBoxColumn
            // 
            this.experienceYearsDataGridViewTextBoxColumn.DataPropertyName = "ExperienceYears";
            this.experienceYearsDataGridViewTextBoxColumn.HeaderText = "ExperienceYears";
            this.experienceYearsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.experienceYearsDataGridViewTextBoxColumn.Name = "experienceYearsDataGridViewTextBoxColumn";
            this.experienceYearsDataGridViewTextBoxColumn.Width = 125;
            // 
            // licenseIDDataGridViewTextBoxColumn
            // 
            this.licenseIDDataGridViewTextBoxColumn.DataPropertyName = "LicenseID";
            this.licenseIDDataGridViewTextBoxColumn.HeaderText = "LicenseID";
            this.licenseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licenseIDDataGridViewTextBoxColumn.Name = "licenseIDDataGridViewTextBoxColumn";
            this.licenseIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.transportServiceDBDataSet;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // DriverLicenseDataGrid
            // 
            this.DriverLicenseDataGrid.AutoGenerateColumns = false;
            this.DriverLicenseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverLicenseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licenseIDDataGridViewTextBoxColumn1,
            this.licenseNumberDataGridViewTextBoxColumn,
            this.licenseCategoryDataGridViewTextBoxColumn,
            this.issueDateDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn});
            this.DriverLicenseDataGrid.DataSource = this.driverLicenseBindingSource;
            this.DriverLicenseDataGrid.Location = new System.Drawing.Point(0, 263);
            this.DriverLicenseDataGrid.Name = "DriverLicenseDataGrid";
            this.DriverLicenseDataGrid.RowHeadersWidth = 51;
            this.DriverLicenseDataGrid.RowTemplate.Height = 24;
            this.DriverLicenseDataGrid.Size = new System.Drawing.Size(679, 110);
            this.DriverLicenseDataGrid.TabIndex = 3;
            // 
            // licenseIDDataGridViewTextBoxColumn1
            // 
            this.licenseIDDataGridViewTextBoxColumn1.DataPropertyName = "LicenseID";
            this.licenseIDDataGridViewTextBoxColumn1.HeaderText = "LicenseID";
            this.licenseIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.licenseIDDataGridViewTextBoxColumn1.Name = "licenseIDDataGridViewTextBoxColumn1";
            this.licenseIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.licenseIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // licenseNumberDataGridViewTextBoxColumn
            // 
            this.licenseNumberDataGridViewTextBoxColumn.DataPropertyName = "LicenseNumber";
            this.licenseNumberDataGridViewTextBoxColumn.HeaderText = "LicenseNumber";
            this.licenseNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licenseNumberDataGridViewTextBoxColumn.Name = "licenseNumberDataGridViewTextBoxColumn";
            this.licenseNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // licenseCategoryDataGridViewTextBoxColumn
            // 
            this.licenseCategoryDataGridViewTextBoxColumn.DataPropertyName = "LicenseCategory";
            this.licenseCategoryDataGridViewTextBoxColumn.HeaderText = "LicenseCategory";
            this.licenseCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licenseCategoryDataGridViewTextBoxColumn.Name = "licenseCategoryDataGridViewTextBoxColumn";
            this.licenseCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            this.issueDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            this.expiryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverLicenseBindingSource
            // 
            this.driverLicenseBindingSource.DataMember = "DriverLicense";
            this.driverLicenseBindingSource.DataSource = this.transportServiceDBDataSet;
            // 
            // driverLicenseTableAdapter
            // 
            this.driverLicenseTableAdapter.ClearBeforeFill = true;
            // 
            // RouteDataGrid
            // 
            this.RouteDataGrid.AutoGenerateColumns = false;
            this.RouteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RouteDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeIDDataGridViewTextBoxColumn,
            this.routeFromDataGridViewTextBoxColumn,
            this.routeToDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.estimatedTimeHoursDataGridViewTextBoxColumn});
            this.RouteDataGrid.DataSource = this.routeBindingSource;
            this.RouteDataGrid.Location = new System.Drawing.Point(0, 379);
            this.RouteDataGrid.Name = "RouteDataGrid";
            this.RouteDataGrid.RowHeadersWidth = 51;
            this.RouteDataGrid.RowTemplate.Height = 24;
            this.RouteDataGrid.Size = new System.Drawing.Size(679, 110);
            this.RouteDataGrid.TabIndex = 4;
            // 
            // routeIDDataGridViewTextBoxColumn
            // 
            this.routeIDDataGridViewTextBoxColumn.DataPropertyName = "RouteID";
            this.routeIDDataGridViewTextBoxColumn.HeaderText = "RouteID";
            this.routeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.routeIDDataGridViewTextBoxColumn.Name = "routeIDDataGridViewTextBoxColumn";
            this.routeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.routeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // routeFromDataGridViewTextBoxColumn
            // 
            this.routeFromDataGridViewTextBoxColumn.DataPropertyName = "RouteFrom";
            this.routeFromDataGridViewTextBoxColumn.HeaderText = "RouteFrom";
            this.routeFromDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.routeFromDataGridViewTextBoxColumn.Name = "routeFromDataGridViewTextBoxColumn";
            this.routeFromDataGridViewTextBoxColumn.Width = 125;
            // 
            // routeToDataGridViewTextBoxColumn
            // 
            this.routeToDataGridViewTextBoxColumn.DataPropertyName = "RouteTo";
            this.routeToDataGridViewTextBoxColumn.HeaderText = "RouteTo";
            this.routeToDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.routeToDataGridViewTextBoxColumn.Name = "routeToDataGridViewTextBoxColumn";
            this.routeToDataGridViewTextBoxColumn.Width = 125;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // estimatedTimeHoursDataGridViewTextBoxColumn
            // 
            this.estimatedTimeHoursDataGridViewTextBoxColumn.DataPropertyName = "EstimatedTimeHours";
            this.estimatedTimeHoursDataGridViewTextBoxColumn.HeaderText = "EstimatedTimeHours";
            this.estimatedTimeHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estimatedTimeHoursDataGridViewTextBoxColumn.Name = "estimatedTimeHoursDataGridViewTextBoxColumn";
            this.estimatedTimeHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.transportServiceDBDataSet;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // ServiceDataGrid
            // 
            this.ServiceDataGrid.AutoGenerateColumns = false;
            this.ServiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn1,
            this.driverIDDataGridViewTextBoxColumn1,
            this.serviceTypeIDDataGridViewTextBoxColumn,
            this.transportIDDataGridViewTextBoxColumn,
            this.routeIDDataGridViewTextBoxColumn1,
            this.serviceStatusDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.ServiceDataGrid.DataSource = this.serviceBindingSource;
            this.ServiceDataGrid.Location = new System.Drawing.Point(0, 495);
            this.ServiceDataGrid.Name = "ServiceDataGrid";
            this.ServiceDataGrid.RowHeadersWidth = 51;
            this.ServiceDataGrid.RowTemplate.Height = 24;
            this.ServiceDataGrid.Size = new System.Drawing.Size(1435, 110);
            this.ServiceDataGrid.TabIndex = 5;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientIDDataGridViewTextBoxColumn1
            // 
            this.clientIDDataGridViewTextBoxColumn1.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn1.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn1.Name = "clientIDDataGridViewTextBoxColumn1";
            this.clientIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // driverIDDataGridViewTextBoxColumn1
            // 
            this.driverIDDataGridViewTextBoxColumn1.DataPropertyName = "DriverID";
            this.driverIDDataGridViewTextBoxColumn1.HeaderText = "DriverID";
            this.driverIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.driverIDDataGridViewTextBoxColumn1.Name = "driverIDDataGridViewTextBoxColumn1";
            this.driverIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // serviceTypeIDDataGridViewTextBoxColumn
            // 
            this.serviceTypeIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceTypeID";
            this.serviceTypeIDDataGridViewTextBoxColumn.HeaderText = "ServiceTypeID";
            this.serviceTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceTypeIDDataGridViewTextBoxColumn.Name = "serviceTypeIDDataGridViewTextBoxColumn";
            this.serviceTypeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // transportIDDataGridViewTextBoxColumn
            // 
            this.transportIDDataGridViewTextBoxColumn.DataPropertyName = "TransportID";
            this.transportIDDataGridViewTextBoxColumn.HeaderText = "TransportID";
            this.transportIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transportIDDataGridViewTextBoxColumn.Name = "transportIDDataGridViewTextBoxColumn";
            this.transportIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // routeIDDataGridViewTextBoxColumn1
            // 
            this.routeIDDataGridViewTextBoxColumn1.DataPropertyName = "RouteID";
            this.routeIDDataGridViewTextBoxColumn1.HeaderText = "RouteID";
            this.routeIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.routeIDDataGridViewTextBoxColumn1.Name = "routeIDDataGridViewTextBoxColumn1";
            this.routeIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // serviceStatusDataGridViewTextBoxColumn
            // 
            this.serviceStatusDataGridViewTextBoxColumn.DataPropertyName = "ServiceStatus";
            this.serviceStatusDataGridViewTextBoxColumn.HeaderText = "ServiceStatus";
            this.serviceStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceStatusDataGridViewTextBoxColumn.Name = "serviceStatusDataGridViewTextBoxColumn";
            this.serviceStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.transportServiceDBDataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // ServiceTypeDataGrid
            // 
            this.ServiceTypeDataGrid.AutoGenerateColumns = false;
            this.ServiceTypeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceTypeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceTypeIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.serviceDescriptionDataGridViewTextBoxColumn});
            this.ServiceTypeDataGrid.DataSource = this.serviceTypeBindingSource;
            this.ServiceTypeDataGrid.Location = new System.Drawing.Point(0, 611);
            this.ServiceTypeDataGrid.Name = "ServiceTypeDataGrid";
            this.ServiceTypeDataGrid.RowHeadersWidth = 51;
            this.ServiceTypeDataGrid.RowTemplate.Height = 24;
            this.ServiceTypeDataGrid.Size = new System.Drawing.Size(430, 110);
            this.ServiceTypeDataGrid.TabIndex = 6;
            // 
            // serviceTypeIDDataGridViewTextBoxColumn1
            // 
            this.serviceTypeIDDataGridViewTextBoxColumn1.DataPropertyName = "ServiceTypeID";
            this.serviceTypeIDDataGridViewTextBoxColumn1.HeaderText = "ServiceTypeID";
            this.serviceTypeIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.serviceTypeIDDataGridViewTextBoxColumn1.Name = "serviceTypeIDDataGridViewTextBoxColumn1";
            this.serviceTypeIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.serviceTypeIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceDescriptionDataGridViewTextBoxColumn
            // 
            this.serviceDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ServiceDescription";
            this.serviceDescriptionDataGridViewTextBoxColumn.HeaderText = "ServiceDescription";
            this.serviceDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceDescriptionDataGridViewTextBoxColumn.Name = "serviceDescriptionDataGridViewTextBoxColumn";
            this.serviceDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceTypeBindingSource
            // 
            this.serviceTypeBindingSource.DataMember = "ServiceType";
            this.serviceTypeBindingSource.DataSource = this.transportServiceDBDataSet;
            // 
            // serviceTypeTableAdapter
            // 
            this.serviceTypeTableAdapter.ClearBeforeFill = true;
            // 
            // TransportDataGrid
            // 
            this.TransportDataGrid.AutoGenerateColumns = false;
            this.TransportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransportDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportIDDataGridViewTextBoxColumn1,
            this.transportTypeIDDataGridViewTextBoxColumn,
            this.licensePlateNumberDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.seatsDataGridViewTextBoxColumn,
            this.fuelTypeDataGridViewTextBoxColumn,
            this.fuelCapacityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.TransportDataGrid.DataSource = this.transportBindingSource;
            this.TransportDataGrid.Location = new System.Drawing.Point(0, 727);
            this.TransportDataGrid.Name = "TransportDataGrid";
            this.TransportDataGrid.RowHeadersWidth = 51;
            this.TransportDataGrid.RowTemplate.Height = 24;
            this.TransportDataGrid.Size = new System.Drawing.Size(1431, 110);
            this.TransportDataGrid.TabIndex = 7;
            // 
            // transportIDDataGridViewTextBoxColumn1
            // 
            this.transportIDDataGridViewTextBoxColumn1.DataPropertyName = "TransportID";
            this.transportIDDataGridViewTextBoxColumn1.HeaderText = "TransportID";
            this.transportIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.transportIDDataGridViewTextBoxColumn1.Name = "transportIDDataGridViewTextBoxColumn1";
            this.transportIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.transportIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // transportTypeIDDataGridViewTextBoxColumn
            // 
            this.transportTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TransportTypeID";
            this.transportTypeIDDataGridViewTextBoxColumn.HeaderText = "TransportTypeID";
            this.transportTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transportTypeIDDataGridViewTextBoxColumn.Name = "transportTypeIDDataGridViewTextBoxColumn";
            this.transportTypeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // licensePlateNumberDataGridViewTextBoxColumn
            // 
            this.licensePlateNumberDataGridViewTextBoxColumn.DataPropertyName = "LicensePlateNumber";
            this.licensePlateNumberDataGridViewTextBoxColumn.HeaderText = "LicensePlateNumber";
            this.licensePlateNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licensePlateNumberDataGridViewTextBoxColumn.Name = "licensePlateNumberDataGridViewTextBoxColumn";
            this.licensePlateNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // seatsDataGridViewTextBoxColumn
            // 
            this.seatsDataGridViewTextBoxColumn.DataPropertyName = "Seats";
            this.seatsDataGridViewTextBoxColumn.HeaderText = "Seats";
            this.seatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seatsDataGridViewTextBoxColumn.Name = "seatsDataGridViewTextBoxColumn";
            this.seatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // fuelTypeDataGridViewTextBoxColumn
            // 
            this.fuelTypeDataGridViewTextBoxColumn.DataPropertyName = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.HeaderText = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fuelTypeDataGridViewTextBoxColumn.Name = "fuelTypeDataGridViewTextBoxColumn";
            this.fuelTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // fuelCapacityDataGridViewTextBoxColumn
            // 
            this.fuelCapacityDataGridViewTextBoxColumn.DataPropertyName = "FuelCapacity";
            this.fuelCapacityDataGridViewTextBoxColumn.HeaderText = "FuelCapacity";
            this.fuelCapacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fuelCapacityDataGridViewTextBoxColumn.Name = "fuelCapacityDataGridViewTextBoxColumn";
            this.fuelCapacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // transportBindingSource
            // 
            this.transportBindingSource.DataMember = "Transport";
            this.transportBindingSource.DataSource = this.transportServiceDBDataSet;
            // 
            // transportTableAdapter
            // 
            this.transportTableAdapter.ClearBeforeFill = true;
            // 
            // TransportTypeDataGrid
            // 
            this.TransportTypeDataGrid.AutoGenerateColumns = false;
            this.TransportTypeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransportTypeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportTypeIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1});
            this.TransportTypeDataGrid.DataSource = this.transportTypeBindingSource;
            this.TransportTypeDataGrid.Location = new System.Drawing.Point(0, 843);
            this.TransportTypeDataGrid.Name = "TransportTypeDataGrid";
            this.TransportTypeDataGrid.RowHeadersWidth = 51;
            this.TransportTypeDataGrid.RowTemplate.Height = 24;
            this.TransportTypeDataGrid.Size = new System.Drawing.Size(317, 110);
            this.TransportTypeDataGrid.TabIndex = 8;
            // 
            // transportTypeIDDataGridViewTextBoxColumn1
            // 
            this.transportTypeIDDataGridViewTextBoxColumn1.DataPropertyName = "TransportTypeID";
            this.transportTypeIDDataGridViewTextBoxColumn1.HeaderText = "TransportTypeID";
            this.transportTypeIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.transportTypeIDDataGridViewTextBoxColumn1.Name = "transportTypeIDDataGridViewTextBoxColumn1";
            this.transportTypeIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.transportTypeIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // transportTypeBindingSource
            // 
            this.transportTypeBindingSource.DataMember = "TransportType";
            this.transportTypeBindingSource.DataSource = this.transportServiceDBDataSet;
            // 
            // transportTypeTableAdapter
            // 
            this.transportTypeTableAdapter.ClearBeforeFill = true;
            // 
            // клієнтиToolStripMenuItem
            // 
            this.клієнтиToolStripMenuItem.Name = "клієнтиToolStripMenuItem";
            this.клієнтиToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.клієнтиToolStripMenuItem.Text = "Клієнти";
            this.клієнтиToolStripMenuItem.Click += new System.EventHandler(this.клієнтиToolStripMenuItem_Click);
            // 
            // водіїToolStripMenuItem
            // 
            this.водіїToolStripMenuItem.Name = "водіїToolStripMenuItem";
            this.водіїToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.водіїToolStripMenuItem.Text = "Водії";
            this.водіїToolStripMenuItem.Click += new System.EventHandler(this.водіїToolStripMenuItem_Click);
            // 
            // водійськіПосвідченняToolStripMenuItem
            // 
            this.водійськіПосвідченняToolStripMenuItem.Name = "водійськіПосвідченняToolStripMenuItem";
            this.водійськіПосвідченняToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.водійськіПосвідченняToolStripMenuItem.Text = "Водійські посвідчення";
            this.водійськіПосвідченняToolStripMenuItem.Click += new System.EventHandler(this.водійськіПосвідченняToolStripMenuItem_Click);
            // 
            // маршрутиToolStripMenuItem
            // 
            this.маршрутиToolStripMenuItem.Name = "маршрутиToolStripMenuItem";
            this.маршрутиToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.маршрутиToolStripMenuItem.Text = "Маршрути";
            this.маршрутиToolStripMenuItem.Click += new System.EventHandler(this.маршрутиToolStripMenuItem_Click);
            // 
            // послугиToolStripMenuItem
            // 
            this.послугиToolStripMenuItem.Name = "послугиToolStripMenuItem";
            this.послугиToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.послугиToolStripMenuItem.Text = "Послуги";
            this.послугиToolStripMenuItem.Click += new System.EventHandler(this.послугиToolStripMenuItem_Click);
            // 
            // типиПослугToolStripMenuItem
            // 
            this.типиПослугToolStripMenuItem.Name = "типиПослугToolStripMenuItem";
            this.типиПослугToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.типиПослугToolStripMenuItem.Text = "Типи послуг";
            this.типиПослугToolStripMenuItem.Click += new System.EventHandler(this.типиПослугToolStripMenuItem_Click);
            // 
            // автотранспортToolStripMenuItem
            // 
            this.автотранспортToolStripMenuItem.Name = "автотранспортToolStripMenuItem";
            this.автотранспортToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.автотранспортToolStripMenuItem.Text = "Автотранспорт";
            this.автотранспортToolStripMenuItem.Click += new System.EventHandler(this.автотранспортToolStripMenuItem_Click);
            // 
            // типиАвтотранспортуToolStripMenuItem
            // 
            this.типиАвтотранспортуToolStripMenuItem.Name = "типиАвтотранспортуToolStripMenuItem";
            this.типиАвтотранспортуToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.типиАвтотранспортуToolStripMenuItem.Text = "Типи автотранспорту";
            this.типиАвтотранспортуToolStripMenuItem.Click += new System.EventHandler(this.типиАвтотранспортуToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 1055);
            this.Controls.Add(this.TransportTypeDataGrid);
            this.Controls.Add(this.TransportDataGrid);
            this.Controls.Add(this.ServiceTypeDataGrid);
            this.Controls.Add(this.ServiceDataGrid);
            this.Controls.Add(this.RouteDataGrid);
            this.Controls.Add(this.DriverLicenseDataGrid);
            this.Controls.Add(this.DriverDataGrid);
            this.Controls.Add(this.ClientDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автотранспортні послуги";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportServiceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriverLicenseDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverLicenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransportDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransportTypeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem роботаЗТаблицямиToolStripMenuItem;
        private System.Windows.Forms.DataGridView ClientDataGrid;
        private TransportServiceDBDataSet transportServiceDBDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private TransportServiceDBDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView DriverDataGrid;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private TransportServiceDBDataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceYearsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView DriverLicenseDataGrid;
        private System.Windows.Forms.BindingSource driverLicenseBindingSource;
        private TransportServiceDBDataSetTableAdapters.DriverLicenseTableAdapter driverLicenseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView RouteDataGrid;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private TransportServiceDBDataSetTableAdapters.RouteTableAdapter routeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedTimeHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView ServiceDataGrid;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private TransportServiceDBDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView ServiceTypeDataGrid;
        private System.Windows.Forms.BindingSource serviceTypeBindingSource;
        private TransportServiceDBDataSetTableAdapters.ServiceTypeTableAdapter serviceTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView TransportDataGrid;
        private System.Windows.Forms.BindingSource transportBindingSource;
        private TransportServiceDBDataSetTableAdapters.TransportTableAdapter transportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView TransportTypeDataGrid;
        private System.Windows.Forms.BindingSource transportTypeBindingSource;
        private TransportServiceDBDataSetTableAdapters.TransportTypeTableAdapter transportTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportTypeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem клієнтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem водіїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem водійськіПосвідченняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маршрутиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem послугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типиПослугToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автотранспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типиАвтотранспортуToolStripMenuItem;
    }
    
}

/*using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Restauraunt1
{
    partial class MainForm:Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(778, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(778, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Система управління рестораном";
            Load += this.MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
    }
}
*/