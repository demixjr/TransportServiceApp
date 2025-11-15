namespace TransportServiceApp
{
    partial class TransportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransportForm));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTransport = new System.Windows.Forms.DataGridView();
            this.transportIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.transportTableAdapter = new TransportServiceApp.TransportServiceDBDataSetTableAdapters.TransportTableAdapter();
            this.panelSorting = new System.Windows.Forms.Panel();
            this.btnSort = new System.Windows.Forms.Button();
            this.cmbSortOrder = new System.Windows.Forms.ComboBox();
            this.cmbSortField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtMaxYear = new System.Windows.Forms.TextBox();
            this.txtMinYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAggregate = new System.Windows.Forms.Panel();
            this.lblAggregateResult = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelJoin = new System.Windows.Forms.Panel();
            this.btnJoin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelFilterStatus = new System.Windows.Forms.Panel();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.btnFilterStatus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportServiceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransport)).BeginInit();
            this.panelSorting.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelAggregate.SuspendLayout();
            this.panelJoin.SuspendLayout();
            this.panelFilterStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.transportBindingSource;
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
            this.toolStripButtonSave});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1282, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // transportBindingSource
            // 
            this.transportBindingSource.DataMember = "Transport";
            this.transportBindingSource.DataSource = this.transportServiceDBDataSet;
            // 
            // transportServiceDBDataSet
            // 
            this.transportServiceDBDataSet.DataSetName = "TransportServiceDBDataSet";
            this.transportServiceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonSave.Text = "Зберегти";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // dataGridViewTransport
            // 
            this.dataGridViewTransport.AutoGenerateColumns = false;
            this.dataGridViewTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportIDDataGridViewTextBoxColumn,
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
            this.dataGridViewTransport.DataSource = this.transportBindingSource;
            this.dataGridViewTransport.Location = new System.Drawing.Point(12, 343);
            this.dataGridViewTransport.Name = "dataGridViewTransport";
            this.dataGridViewTransport.RowHeadersWidth = 51;
            this.dataGridViewTransport.RowTemplate.Height = 24;
            this.dataGridViewTransport.Size = new System.Drawing.Size(1258, 346);
            this.dataGridViewTransport.TabIndex = 1;
            // 
            // transportIDDataGridViewTextBoxColumn
            // 
            this.transportIDDataGridViewTextBoxColumn.DataPropertyName = "TransportID";
            this.transportIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.transportIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transportIDDataGridViewTextBoxColumn.Name = "transportIDDataGridViewTextBoxColumn";
            this.transportIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.transportIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // transportTypeIDDataGridViewTextBoxColumn
            // 
            this.transportTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TransportTypeID";
            this.transportTypeIDDataGridViewTextBoxColumn.HeaderText = "Тип ID";
            this.transportTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transportTypeIDDataGridViewTextBoxColumn.Name = "transportTypeIDDataGridViewTextBoxColumn";
            this.transportTypeIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // licensePlateNumberDataGridViewTextBoxColumn
            // 
            this.licensePlateNumberDataGridViewTextBoxColumn.DataPropertyName = "LicensePlateNumber";
            this.licensePlateNumberDataGridViewTextBoxColumn.HeaderText = "Номерний знак";
            this.licensePlateNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licensePlateNumberDataGridViewTextBoxColumn.Name = "licensePlateNumberDataGridViewTextBoxColumn";
            this.licensePlateNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Бренд";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 90;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 90;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Рік";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 70;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Вмістимість";
            this.capacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // seatsDataGridViewTextBoxColumn
            // 
            this.seatsDataGridViewTextBoxColumn.DataPropertyName = "Seats";
            this.seatsDataGridViewTextBoxColumn.HeaderText = "Місць";
            this.seatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seatsDataGridViewTextBoxColumn.Name = "seatsDataGridViewTextBoxColumn";
            this.seatsDataGridViewTextBoxColumn.Width = 70;
            // 
            // fuelTypeDataGridViewTextBoxColumn
            // 
            this.fuelTypeDataGridViewTextBoxColumn.DataPropertyName = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.HeaderText = "Тип палива";
            this.fuelTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fuelTypeDataGridViewTextBoxColumn.Name = "fuelTypeDataGridViewTextBoxColumn";
            this.fuelTypeDataGridViewTextBoxColumn.Width = 90;
            // 
            // fuelCapacityDataGridViewTextBoxColumn
            // 
            this.fuelCapacityDataGridViewTextBoxColumn.DataPropertyName = "FuelCapacity";
            this.fuelCapacityDataGridViewTextBoxColumn.HeaderText = "Об\'єм бака";
            this.fuelCapacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fuelCapacityDataGridViewTextBoxColumn.Name = "fuelCapacityDataGridViewTextBoxColumn";
            this.fuelCapacityDataGridViewTextBoxColumn.Width = 90;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 90;
            // 
            // transportTableAdapter
            // 
            this.transportTableAdapter.ClearBeforeFill = true;
            // 
            // panelSorting
            // 
            this.panelSorting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSorting.Controls.Add(this.btnSort);
            this.panelSorting.Controls.Add(this.cmbSortOrder);
            this.panelSorting.Controls.Add(this.cmbSortField);
            this.panelSorting.Controls.Add(this.label1);
            this.panelSorting.Location = new System.Drawing.Point(12, 40);
            this.panelSorting.Name = "panelSorting";
            this.panelSorting.Size = new System.Drawing.Size(467, 60);
            this.panelSorting.TabIndex = 2;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(339, 14);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(117, 30);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Сортувати";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cmbSortOrder
            // 
            this.cmbSortOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortOrder.FormattingEnabled = true;
            this.cmbSortOrder.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.cmbSortOrder.Location = new System.Drawing.Point(249, 18);
            this.cmbSortOrder.Name = "cmbSortOrder";
            this.cmbSortOrder.Size = new System.Drawing.Size(70, 24);
            this.cmbSortOrder.TabIndex = 2;
            // 
            // cmbSortField
            // 
            this.cmbSortField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortField.FormattingEnabled = true;
            this.cmbSortField.Items.AddRange(new object[] {
            "Brand",
            "Model",
            "Year",
            "Capacity",
            "Seats",
            "FuelCapacity"});
            this.cmbSortField.Location = new System.Drawing.Point(105, 18);
            this.cmbSortField.Name = "cmbSortField";
            this.cmbSortField.Size = new System.Drawing.Size(120, 24);
            this.cmbSortField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сортування:";
            // 
            // panelFilter
            // 
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.btnFilter);
            this.panelFilter.Controls.Add(this.txtMaxYear);
            this.panelFilter.Controls.Add(this.txtMinYear);
            this.panelFilter.Controls.Add(this.label2);
            this.panelFilter.Location = new System.Drawing.Point(12, 141);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(467, 60);
            this.panelFilter.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(323, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(103, 30);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Фільтрувати";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtMaxYear
            // 
            this.txtMaxYear.Location = new System.Drawing.Point(229, 18);
            this.txtMaxYear.Name = "txtMaxYear";
            this.txtMaxYear.Size = new System.Drawing.Size(70, 22);
            this.txtMaxYear.TabIndex = 2;
            this.txtMaxYear.Text = "2024";
            // 
            // txtMinYear
            // 
            this.txtMinYear.Location = new System.Drawing.Point(144, 18);
            this.txtMinYear.Name = "txtMinYear";
            this.txtMinYear.Size = new System.Drawing.Size(70, 22);
            this.txtMinYear.TabIndex = 1;
            this.txtMinYear.Text = "2010";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Рік випуску від/до:";
            // 
            // panelAggregate
            // 
            this.panelAggregate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAggregate.Controls.Add(this.lblAggregateResult);
            this.panelAggregate.Controls.Add(this.btnMin);
            this.panelAggregate.Controls.Add(this.btnMax);
            this.panelAggregate.Controls.Add(this.btnAvg);
            this.panelAggregate.Controls.Add(this.label3);
            this.panelAggregate.Location = new System.Drawing.Point(709, 156);
            this.panelAggregate.Name = "panelAggregate";
            this.panelAggregate.Size = new System.Drawing.Size(483, 60);
            this.panelAggregate.TabIndex = 4;
            // 
            // lblAggregateResult
            // 
            this.lblAggregateResult.AutoSize = true;
            this.lblAggregateResult.Location = new System.Drawing.Point(280, 21);
            this.lblAggregateResult.Name = "lblAggregateResult";
            this.lblAggregateResult.Size = new System.Drawing.Size(0, 16);
            this.lblAggregateResult.TabIndex = 4;
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(214, 14);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(70, 30);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "Мін.";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(138, 14);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(70, 30);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "Макс.";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(62, 14);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(70, 30);
            this.btnAvg.TabIndex = 1;
            this.btnAvg.Text = "Сер.";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Місць:";
            // 
            // panelJoin
            // 
            this.panelJoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelJoin.Controls.Add(this.btnJoin);
            this.panelJoin.Controls.Add(this.label4);
            this.panelJoin.Location = new System.Drawing.Point(709, 40);
            this.panelJoin.Name = "panelJoin";
            this.panelJoin.Size = new System.Drawing.Size(380, 60);
            this.panelJoin.TabIndex = 5;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(120, 15);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(245, 30);
            this.btnJoin.TabIndex = 1;
            this.btnJoin.Text = "Об\'єднати з типами транспорту";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Об\'єднання:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 700);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(130, 16);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Готовий до роботи";
            // 
            // panelFilterStatus
            // 
            this.panelFilterStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilterStatus.Controls.Add(this.cmbStatusFilter);
            this.panelFilterStatus.Controls.Add(this.btnFilterStatus);
            this.panelFilterStatus.Controls.Add(this.label6);
            this.panelFilterStatus.Location = new System.Drawing.Point(12, 236);
            this.panelFilterStatus.Name = "panelFilterStatus";
            this.panelFilterStatus.Size = new System.Drawing.Size(467, 60);
            this.panelFilterStatus.TabIndex = 8;
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Items.AddRange(new object[] {
            "всі",
            "доступна",
            "недоступна"});
            this.cmbStatusFilter.Location = new System.Drawing.Point(152, 19);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(150, 24);
            this.cmbStatusFilter.TabIndex = 2;
            // 
            // btnFilterStatus
            // 
            this.btnFilterStatus.Location = new System.Drawing.Point(339, 15);
            this.btnFilterStatus.Name = "btnFilterStatus";
            this.btnFilterStatus.Size = new System.Drawing.Size(105, 30);
            this.btnFilterStatus.TabIndex = 1;
            this.btnFilterStatus.Text = "Фільтрувати";
            this.btnFilterStatus.UseVisualStyleBackColor = true;
            this.btnFilterStatus.Click += new System.EventHandler(this.btnFilterStatus_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Статус транспорту:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(830, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Переглянути увесь автотранспорт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 725);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelFilterStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panelJoin);
            this.Controls.Add(this.panelAggregate);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelSorting);
            this.Controls.Add(this.dataGridViewTransport);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "TransportForm";
            this.Text = "Транспортні послуги - Управління базою даних";
            this.Load += new System.EventHandler(this.TransportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportServiceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransport)).EndInit();
            this.panelSorting.ResumeLayout(false);
            this.panelSorting.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelAggregate.ResumeLayout(false);
            this.panelAggregate.PerformLayout();
            this.panelJoin.ResumeLayout(false);
            this.panelJoin.PerformLayout();
            this.panelFilterStatus.ResumeLayout(false);
            this.panelFilterStatus.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.DataGridView dataGridViewTransport;
        private TransportServiceDBDataSet transportServiceDBDataSet;
        private System.Windows.Forms.BindingSource transportBindingSource;
        private TransportServiceDBDataSetTableAdapters.TransportTableAdapter transportTableAdapter;
        private System.Windows.Forms.Panel panelSorting;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cmbSortOrder;
        private System.Windows.Forms.ComboBox cmbSortField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtMaxYear;
        private System.Windows.Forms.TextBox txtMinYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelAggregate;
        private System.Windows.Forms.Label lblAggregateResult;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelJoin;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelFilterStatus;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Button btnFilterStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportIDDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Button button1;
    }
}