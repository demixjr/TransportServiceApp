namespace TransportServiceApp
{
    partial class ServiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportServiceDBDataSet = new TransportServiceApp.TransportServiceDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTableAdapter = new TransportServiceApp.TransportServiceDBDataSetTableAdapters.ServiceTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSortOrder = new System.Windows.Forms.ComboBox();
            this.cmbSortField = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFilterDate = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbDateField = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFilterPrice = new System.Windows.Forms.Button();
            this.numMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.numMinPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnServicesByDate = new System.Windows.Forms.Button();
            this.dtpSingleDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnServiceStats = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFindByClient = new System.Windows.Forms.Button();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnServicesWithoutDriver = new System.Windows.Forms.Button();
            this.btnCurrentServices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportServiceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPrice)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.serviceBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1184, 31);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Додати";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.transportServiceDBDataSet;
            // 
            // transportServiceDBDataSet
            // 
            this.transportServiceDBDataSet.DataSetName = "TransportServiceDBDataSet";
            this.transportServiceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Загальна кількість елементів";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Видалити";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Перемістити на початок";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Перемістити назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Позиція";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Поточна позиція";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Перемістити вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Перемістити в кінець";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.driverIDDataGridViewTextBoxColumn,
            this.serviceTypeIDDataGridViewTextBoxColumn,
            this.transportIDDataGridViewTextBoxColumn,
            this.routeIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 300);
            this.dataGridView1.TabIndex = 1;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ID послуги";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Дата початку";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Дата завершення";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Ціна (грн)";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ID клієнта";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverIDDataGridViewTextBoxColumn
            // 
            this.driverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID";
            this.driverIDDataGridViewTextBoxColumn.HeaderText = "ID водія";
            this.driverIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driverIDDataGridViewTextBoxColumn.Name = "driverIDDataGridViewTextBoxColumn";
            this.driverIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceTypeIDDataGridViewTextBoxColumn
            // 
            this.serviceTypeIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceTypeID";
            this.serviceTypeIDDataGridViewTextBoxColumn.HeaderText = "ID типу послуги";
            this.serviceTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceTypeIDDataGridViewTextBoxColumn.Name = "serviceTypeIDDataGridViewTextBoxColumn";
            this.serviceTypeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // transportIDDataGridViewTextBoxColumn
            // 
            this.transportIDDataGridViewTextBoxColumn.DataPropertyName = "TransportID";
            this.transportIDDataGridViewTextBoxColumn.HeaderText = "ID транспорту";
            this.transportIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transportIDDataGridViewTextBoxColumn.Name = "transportIDDataGridViewTextBoxColumn";
            this.transportIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // routeIDDataGridViewTextBoxColumn
            // 
            this.routeIDDataGridViewTextBoxColumn.DataPropertyName = "RouteID";
            this.routeIDDataGridViewTextBoxColumn.HeaderText = "ID маршруту";
            this.routeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.routeIDDataGridViewTextBoxColumn.Name = "routeIDDataGridViewTextBoxColumn";
            this.routeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSortOrder);
            this.groupBox1.Controls.Add(this.cmbSortField);
            this.groupBox1.Controls.Add(this.btnSort);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортування послуг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Напрямок";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поле";
            // 
            // cmbSortOrder
            // 
            this.cmbSortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortOrder.FormattingEnabled = true;
            this.cmbSortOrder.Location = new System.Drawing.Point(130, 45);
            this.cmbSortOrder.Name = "cmbSortOrder";
            this.cmbSortOrder.Size = new System.Drawing.Size(110, 24);
            this.cmbSortOrder.TabIndex = 2;
            // 
            // cmbSortField
            // 
            this.cmbSortField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortField.FormattingEnabled = true;
            this.cmbSortField.Location = new System.Drawing.Point(10, 45);
            this.cmbSortField.Name = "cmbSortField";
            this.cmbSortField.Size = new System.Drawing.Size(110, 24);
            this.cmbSortField.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(10, 75);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(230, 25);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Сортувати";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFilterDate);
            this.groupBox2.Controls.Add(this.dtpTo);
            this.groupBox2.Controls.Add(this.dtpFrom);
            this.groupBox2.Controls.Add(this.cmbDateField);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(280, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 110);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фільтр за датою";
            // 
            // btnFilterDate
            // 
            this.btnFilterDate.Location = new System.Drawing.Point(10, 75);
            this.btnFilterDate.Name = "btnFilterDate";
            this.btnFilterDate.Size = new System.Drawing.Size(280, 25);
            this.btnFilterDate.TabIndex = 4;
            this.btnFilterDate.Text = "Фільтрувати за датою";
            this.btnFilterDate.UseVisualStyleBackColor = true;
            this.btnFilterDate.Click += new System.EventHandler(this.btnFilterDate_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(150, 45);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(140, 22);
            this.dtpTo.TabIndex = 3;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(10, 45);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(130, 22);
            this.dtpFrom.TabIndex = 2;
            // 
            // cmbDateField
            // 
            this.cmbDateField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateField.FormattingEnabled = true;
            this.cmbDateField.Location = new System.Drawing.Point(10, 45);
            this.cmbDateField.Name = "cmbDateField";
            this.cmbDateField.Size = new System.Drawing.Size(130, 24);
            this.cmbDateField.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Поле для пошуку";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFilterPrice);
            this.groupBox3.Controls.Add(this.numMaxPrice);
            this.groupBox3.Controls.Add(this.numMinPrice);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(600, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 110);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фільтр за ціною (грн)";
            // 
            // btnFilterPrice
            // 
            this.btnFilterPrice.Location = new System.Drawing.Point(10, 75);
            this.btnFilterPrice.Name = "btnFilterPrice";
            this.btnFilterPrice.Size = new System.Drawing.Size(230, 25);
            this.btnFilterPrice.TabIndex = 4;
            this.btnFilterPrice.Text = "Фільтрувати за ціною";
            this.btnFilterPrice.UseVisualStyleBackColor = true;
            this.btnFilterPrice.Click += new System.EventHandler(this.btnFilterPrice_Click);
            // 
            // numMaxPrice
            // 
            this.numMaxPrice.DecimalPlaces = 2;
            this.numMaxPrice.Location = new System.Drawing.Point(130, 45);
            this.numMaxPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMaxPrice.Name = "numMaxPrice";
            this.numMaxPrice.Size = new System.Drawing.Size(110, 22);
            this.numMaxPrice.TabIndex = 3;
            this.numMaxPrice.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numMinPrice
            // 
            this.numMinPrice.DecimalPlaces = 2;
            this.numMinPrice.Location = new System.Drawing.Point(10, 45);
            this.numMinPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMinPrice.Name = "numMinPrice";
            this.numMinPrice.Size = new System.Drawing.Size(110, 22);
            this.numMinPrice.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Максимум";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Мінімум";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnServicesByDate);
            this.groupBox4.Controls.Add(this.dtpSingleDate);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(870, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 110);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Послуги на дату";
            // 
            // btnServicesByDate
            // 
            this.btnServicesByDate.Location = new System.Drawing.Point(10, 75);
            this.btnServicesByDate.Name = "btnServicesByDate";
            this.btnServicesByDate.Size = new System.Drawing.Size(180, 25);
            this.btnServicesByDate.TabIndex = 2;
            this.btnServicesByDate.Text = "Знайти активні послуги";
            this.btnServicesByDate.UseVisualStyleBackColor = true;
            this.btnServicesByDate.Click += new System.EventHandler(this.btnServicesByDate_Click);
            // 
            // dtpSingleDate
            // 
            this.dtpSingleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSingleDate.Location = new System.Drawing.Point(10, 45);
            this.dtpSingleDate.Name = "dtpSingleDate";
            this.dtpSingleDate.Size = new System.Drawing.Size(180, 22);
            this.dtpSingleDate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Дата";
            // 
            // btnServiceStats
            // 
            this.btnServiceStats.Location = new System.Drawing.Point(720, 265);
            this.btnServiceStats.Name = "btnServiceStats";
            this.btnServiceStats.Size = new System.Drawing.Size(120, 35);
            this.btnServiceStats.TabIndex = 6;
            this.btnServiceStats.Text = "Статистика послуг";
            this.btnServiceStats.UseVisualStyleBackColor = true;
            this.btnServiceStats.Click += new System.EventHandler(this.btnServiceStats_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(1041, 265);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(120, 35);
            this.btnShowAll.TabIndex = 7;
            this.btnShowAll.Text = "Всі послуги";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(12, 210);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(147, 18);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Готово до роботи...";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFindByClient);
            this.groupBox5.Controls.Add(this.txtClientID);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(280, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 110);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Пошук за клієнтом";
            // 
            // btnFindByClient
            // 
            this.btnFindByClient.Location = new System.Drawing.Point(10, 75);
            this.btnFindByClient.Name = "btnFindByClient";
            this.btnFindByClient.Size = new System.Drawing.Size(180, 25);
            this.btnFindByClient.TabIndex = 2;
            this.btnFindByClient.Text = "Знайти послуги";
            this.btnFindByClient.UseVisualStyleBackColor = true;
            this.btnFindByClient.Click += new System.EventHandler(this.btnFindByClient_Click);
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(10, 45);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(180, 22);
            this.txtClientID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID клієнта";
            // 
            // btnServicesWithoutDriver
            // 
            this.btnServicesWithoutDriver.BackColor = System.Drawing.Color.Gainsboro;
            this.btnServicesWithoutDriver.Location = new System.Drawing.Point(570, 176);
            this.btnServicesWithoutDriver.Name = "btnServicesWithoutDriver";
            this.btnServicesWithoutDriver.Size = new System.Drawing.Size(150, 35);
            this.btnServicesWithoutDriver.TabIndex = 10;
            this.btnServicesWithoutDriver.Text = "Послуги без водія";
            this.btnServicesWithoutDriver.UseVisualStyleBackColor = false;
            this.btnServicesWithoutDriver.Click += new System.EventHandler(this.btnServicesWithoutDriver_Click);
            // 
            // btnCurrentServices
            // 
            this.btnCurrentServices.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCurrentServices.Location = new System.Drawing.Point(838, 176);
            this.btnCurrentServices.Name = "btnCurrentServices";
            this.btnCurrentServices.Size = new System.Drawing.Size(150, 35);
            this.btnCurrentServices.TabIndex = 11;
            this.btnCurrentServices.Text = "Поточні послуги";
            this.btnCurrentServices.UseVisualStyleBackColor = false;
            this.btnCurrentServices.Click += new System.EventHandler(this.btnCurrentServices_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 632);
            this.Controls.Add(this.btnCurrentServices);
            this.Controls.Add(this.btnServicesWithoutDriver);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnServiceStats);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "ServiceForm";
            this.Text = "Управління послугами";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportServiceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPrice)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TransportServiceDBDataSet transportServiceDBDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private TransportServiceDBDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSortOrder;
        private System.Windows.Forms.ComboBox cmbSortField;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFilterDate;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ComboBox cmbDateField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFilterPrice;
        private System.Windows.Forms.NumericUpDown numMaxPrice;
        private System.Windows.Forms.NumericUpDown numMinPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnServicesByDate;
        private System.Windows.Forms.DateTimePicker dtpSingleDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnServiceStats;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFindByClient;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnServicesWithoutDriver;
        private System.Windows.Forms.Button btnCurrentServices;
    }
}