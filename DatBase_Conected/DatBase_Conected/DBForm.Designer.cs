namespace DatBase_Conected
{
    partial class DBForm
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
            this.dgvRepairInfo = new System.Windows.Forms.DataGridView();
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.tabPageVehicle = new System.Windows.Forms.TabPage();
            this.gbIUDVeh = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIUDVehID = new System.Windows.Forms.TextBox();
            this.bVehUpdate = new System.Windows.Forms.Button();
            this.bVehDelete = new System.Windows.Forms.Button();
            this.bVehInsert = new System.Windows.Forms.Button();
            this.gbVehFilter = new System.Windows.Forms.GroupBox();
            this.cbVehFilter = new System.Windows.Forms.CheckBox();
            this.cbMinMile = new System.Windows.Forms.CheckBox();
            this.cbMaxMile = new System.Windows.Forms.CheckBox();
            this.tbVehFilter = new System.Windows.Forms.TextBox();
            this.nudMinMile = new System.Windows.Forms.NumericUpDown();
            this.nudMaxMile = new System.Windows.Forms.NumericUpDown();
            this.gbVehFind = new System.Windows.Forms.GroupBox();
            this.LFindPlate = new System.Windows.Forms.Label();
            this.LFindVeh = new System.Windows.Forms.Label();
            this.tbVehFindPlate = new System.Windows.Forms.TextBox();
            this.bFindVehByPlate = new System.Windows.Forms.Button();
            this.gbVehSort = new System.Windows.Forms.GroupBox();
            this.cbSortVehDesc = new System.Windows.Forms.CheckBox();
            this.rbSortVehPrice = new System.Windows.Forms.RadioButton();
            this.rbSortVehPlate = new System.Windows.Forms.RadioButton();
            this.rbSortVehID = new System.Windows.Forms.RadioButton();
            this.LVehicle = new System.Windows.Forms.Label();
            this.dgvVehicle = new System.Windows.Forms.DataGridView();
            this.tabPageRepairs = new System.Windows.Forms.TabPage();
            this.gbIUDRep = new System.Windows.Forms.GroupBox();
            this.LIUDRepID = new System.Windows.Forms.Label();
            this.tbIUDRepID = new System.Windows.Forms.TextBox();
            this.bRepUpdate = new System.Windows.Forms.Button();
            this.bRepDelete = new System.Windows.Forms.Button();
            this.bRepInsert = new System.Windows.Forms.Button();
            this.gbSortRep = new System.Windows.Forms.GroupBox();
            this.cbSortRepDesc = new System.Windows.Forms.CheckBox();
            this.rbSortRepCost = new System.Windows.Forms.RadioButton();
            this.rbSortRepID = new System.Windows.Forms.RadioButton();
            this.gbFindRep = new System.Windows.Forms.GroupBox();
            this.LFindRepID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRepFindID = new System.Windows.Forms.TextBox();
            this.bFindPartsByRepID = new System.Windows.Forms.Button();
            this.gbRepairs = new System.Windows.Forms.GroupBox();
            this.LRepSum = new System.Windows.Forms.Label();
            this.tbRepairExID = new System.Windows.Forms.TextBox();
            this.bRepairVehicle = new System.Windows.Forms.Button();
            this.bRepairCrew = new System.Windows.Forms.Button();
            this.LRepairs = new System.Windows.Forms.Label();
            this.tabPagePath = new System.Windows.Forms.TabPage();
            this.gbIUDPath = new System.Windows.Forms.GroupBox();
            this.LIUDPathID = new System.Windows.Forms.Label();
            this.bPathInsert = new System.Windows.Forms.Button();
            this.tbIUDPathID = new System.Windows.Forms.TextBox();
            this.bPathUpdate = new System.Windows.Forms.Button();
            this.bPathDelete = new System.Windows.Forms.Button();
            this.gbFinddPaths = new System.Windows.Forms.GroupBox();
            this.lbPoints = new System.Windows.Forms.ListBox();
            this.bClearPoints = new System.Windows.Forms.Button();
            this.LFintPaths = new System.Windows.Forms.Label();
            this.bFindPathByPoints = new System.Windows.Forms.Button();
            this.LPaths = new System.Windows.Forms.Label();
            this.gbPathsSort = new System.Windows.Forms.GroupBox();
            this.cbSortPathsDesc = new System.Windows.Forms.CheckBox();
            this.rbSortPathPass = new System.Windows.Forms.RadioButton();
            this.rbSortPathID = new System.Windows.Forms.RadioButton();
            this.dgvPaths = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepairInfo)).BeginInit();
            this.tabMainControl.SuspendLayout();
            this.tabPageVehicle.SuspendLayout();
            this.gbIUDVeh.SuspendLayout();
            this.gbVehFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinMile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMile)).BeginInit();
            this.gbVehFind.SuspendLayout();
            this.gbVehSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).BeginInit();
            this.tabPageRepairs.SuspendLayout();
            this.gbIUDRep.SuspendLayout();
            this.gbSortRep.SuspendLayout();
            this.gbFindRep.SuspendLayout();
            this.gbRepairs.SuspendLayout();
            this.tabPagePath.SuspendLayout();
            this.gbIUDPath.SuspendLayout();
            this.gbFinddPaths.SuspendLayout();
            this.gbPathsSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaths)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRepairInfo
            // 
            this.dgvRepairInfo.AllowUserToAddRows = false;
            this.dgvRepairInfo.AllowUserToDeleteRows = false;
            this.dgvRepairInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepairInfo.Location = new System.Drawing.Point(17, 124);
            this.dgvRepairInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvRepairInfo.Name = "dgvRepairInfo";
            this.dgvRepairInfo.ReadOnly = true;
            this.dgvRepairInfo.Size = new System.Drawing.Size(543, 154);
            this.dgvRepairInfo.TabIndex = 0;
            // 
            // tabMainControl
            // 
            this.tabMainControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMainControl.Controls.Add(this.tabPageVehicle);
            this.tabMainControl.Controls.Add(this.tabPageRepairs);
            this.tabMainControl.Controls.Add(this.tabPagePath);
            this.tabMainControl.Location = new System.Drawing.Point(14, 14);
            this.tabMainControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(829, 428);
            this.tabMainControl.TabIndex = 1;
            // 
            // tabPageVehicle
            // 
            this.tabPageVehicle.Controls.Add(this.gbIUDVeh);
            this.tabPageVehicle.Controls.Add(this.gbVehFilter);
            this.tabPageVehicle.Controls.Add(this.gbVehFind);
            this.tabPageVehicle.Controls.Add(this.gbVehSort);
            this.tabPageVehicle.Controls.Add(this.LVehicle);
            this.tabPageVehicle.Controls.Add(this.dgvVehicle);
            this.tabPageVehicle.Location = new System.Drawing.Point(4, 24);
            this.tabPageVehicle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageVehicle.Name = "tabPageVehicle";
            this.tabPageVehicle.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageVehicle.Size = new System.Drawing.Size(821, 756);
            this.tabPageVehicle.TabIndex = 1;
            this.tabPageVehicle.Text = "Управление транспортом";
            this.tabPageVehicle.UseVisualStyleBackColor = true;
            // 
            // gbIUDVeh
            // 
            this.gbIUDVeh.Controls.Add(this.label4);
            this.gbIUDVeh.Controls.Add(this.tbIUDVehID);
            this.gbIUDVeh.Controls.Add(this.bVehUpdate);
            this.gbIUDVeh.Controls.Add(this.bVehDelete);
            this.gbIUDVeh.Controls.Add(this.bVehInsert);
            this.gbIUDVeh.Location = new System.Drawing.Point(17, 32);
            this.gbIUDVeh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbIUDVeh.Name = "gbIUDVeh";
            this.gbIUDVeh.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbIUDVeh.Size = new System.Drawing.Size(243, 103);
            this.gbIUDVeh.TabIndex = 45;
            this.gbIUDVeh.TabStop = false;
            this.gbIUDVeh.Text = "Работа с данными";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "ID:";
            // 
            // tbIUDVehID
            // 
            this.tbIUDVehID.Location = new System.Drawing.Point(157, 67);
            this.tbIUDVehID.Name = "tbIUDVehID";
            this.tbIUDVehID.Size = new System.Drawing.Size(81, 21);
            this.tbIUDVehID.TabIndex = 41;
            this.tbIUDVehID.TextChanged += new System.EventHandler(this.tbIUDVehID_TextChanged);
            // 
            // bVehUpdate
            // 
            this.bVehUpdate.Enabled = false;
            this.bVehUpdate.Location = new System.Drawing.Point(4, 29);
            this.bVehUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bVehUpdate.Name = "bVehUpdate";
            this.bVehUpdate.Size = new System.Drawing.Size(109, 28);
            this.bVehUpdate.TabIndex = 39;
            this.bVehUpdate.Text = "Обновить по ID";
            this.bVehUpdate.UseVisualStyleBackColor = true;
            this.bVehUpdate.Click += new System.EventHandler(this.bVehUpdate_Click);
            // 
            // bVehDelete
            // 
            this.bVehDelete.Enabled = false;
            this.bVehDelete.Location = new System.Drawing.Point(4, 63);
            this.bVehDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bVehDelete.Name = "bVehDelete";
            this.bVehDelete.Size = new System.Drawing.Size(109, 28);
            this.bVehDelete.TabIndex = 40;
            this.bVehDelete.Text = "Удалить по ID";
            this.bVehDelete.UseVisualStyleBackColor = true;
            this.bVehDelete.Click += new System.EventHandler(this.bVehDelete_Click);
            // 
            // bVehInsert
            // 
            this.bVehInsert.Location = new System.Drawing.Point(139, 29);
            this.bVehInsert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bVehInsert.Name = "bVehInsert";
            this.bVehInsert.Size = new System.Drawing.Size(99, 28);
            this.bVehInsert.TabIndex = 38;
            this.bVehInsert.Text = "Вставить";
            this.bVehInsert.UseVisualStyleBackColor = true;
            this.bVehInsert.Click += new System.EventHandler(this.bVehInsert_Click);
            // 
            // gbVehFilter
            // 
            this.gbVehFilter.Controls.Add(this.cbVehFilter);
            this.gbVehFilter.Controls.Add(this.cbMinMile);
            this.gbVehFilter.Controls.Add(this.cbMaxMile);
            this.gbVehFilter.Controls.Add(this.tbVehFilter);
            this.gbVehFilter.Controls.Add(this.nudMinMile);
            this.gbVehFilter.Controls.Add(this.nudMaxMile);
            this.gbVehFilter.Location = new System.Drawing.Point(286, 32);
            this.gbVehFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbVehFilter.Name = "gbVehFilter";
            this.gbVehFilter.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbVehFilter.Size = new System.Drawing.Size(314, 103);
            this.gbVehFilter.TabIndex = 25;
            this.gbVehFilter.TabStop = false;
            this.gbVehFilter.Text = "Фильтры";
            // 
            // cbVehFilter
            // 
            this.cbVehFilter.AutoSize = true;
            this.cbVehFilter.Location = new System.Drawing.Point(5, 22);
            this.cbVehFilter.Name = "cbVehFilter";
            this.cbVehFilter.Size = new System.Drawing.Size(182, 19);
            this.cbVehFilter.TabIndex = 12;
            this.cbVehFilter.Text = "Номер должен содержать:";
            this.cbVehFilter.UseVisualStyleBackColor = true;
            this.cbVehFilter.CheckedChanged += new System.EventHandler(this.ChangeFilter_Handler);
            // 
            // cbMinMile
            // 
            this.cbMinMile.AutoSize = true;
            this.cbMinMile.Location = new System.Drawing.Point(5, 48);
            this.cbMinMile.Name = "cbMinMile";
            this.cbMinMile.Size = new System.Drawing.Size(125, 19);
            this.cbMinMile.TabIndex = 15;
            this.cbMinMile.Text = "Пробег не менее";
            this.cbMinMile.UseVisualStyleBackColor = true;
            this.cbMinMile.CheckedChanged += new System.EventHandler(this.ChangeFilter_Handler);
            // 
            // cbMaxMile
            // 
            this.cbMaxMile.AutoSize = true;
            this.cbMaxMile.Location = new System.Drawing.Point(5, 75);
            this.cbMaxMile.Name = "cbMaxMile";
            this.cbMaxMile.Size = new System.Drawing.Size(126, 19);
            this.cbMaxMile.TabIndex = 13;
            this.cbMaxMile.Text = "Пробег не более:";
            this.cbMaxMile.UseVisualStyleBackColor = true;
            this.cbMaxMile.CheckedChanged += new System.EventHandler(this.ChangeFilter_Handler);
            // 
            // tbVehFilter
            // 
            this.tbVehFilter.Location = new System.Drawing.Point(193, 20);
            this.tbVehFilter.Name = "tbVehFilter";
            this.tbVehFilter.Size = new System.Drawing.Size(116, 21);
            this.tbVehFilter.TabIndex = 10;
            this.tbVehFilter.TextChanged += new System.EventHandler(this.ChangeFilter_Handler);
            // 
            // nudMinMile
            // 
            this.nudMinMile.Location = new System.Drawing.Point(193, 47);
            this.nudMinMile.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.nudMinMile.Name = "nudMinMile";
            this.nudMinMile.Size = new System.Drawing.Size(116, 21);
            this.nudMinMile.TabIndex = 17;
            this.nudMinMile.ValueChanged += new System.EventHandler(this.ChangeFilter_Handler);
            // 
            // nudMaxMile
            // 
            this.nudMaxMile.Location = new System.Drawing.Point(193, 74);
            this.nudMaxMile.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.nudMaxMile.Name = "nudMaxMile";
            this.nudMaxMile.Size = new System.Drawing.Size(116, 21);
            this.nudMaxMile.TabIndex = 18;
            this.nudMaxMile.ValueChanged += new System.EventHandler(this.ChangeFilter_Handler);
            // 
            // gbVehFind
            // 
            this.gbVehFind.Controls.Add(this.LFindPlate);
            this.gbVehFind.Controls.Add(this.LFindVeh);
            this.gbVehFind.Controls.Add(this.tbVehFindPlate);
            this.gbVehFind.Controls.Add(this.bFindVehByPlate);
            this.gbVehFind.Location = new System.Drawing.Point(610, 204);
            this.gbVehFind.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbVehFind.Name = "gbVehFind";
            this.gbVehFind.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbVehFind.Size = new System.Drawing.Size(195, 144);
            this.gbVehFind.TabIndex = 24;
            this.gbVehFind.TabStop = false;
            this.gbVehFind.Text = "Найти";
            // 
            // LFindPlate
            // 
            this.LFindPlate.AutoSize = true;
            this.LFindPlate.Location = new System.Drawing.Point(5, 86);
            this.LFindPlate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFindPlate.Name = "LFindPlate";
            this.LFindPlate.Size = new System.Drawing.Size(49, 15);
            this.LFindPlate.TabIndex = 25;
            this.LFindPlate.Text = "Номер:";
            // 
            // LFindVeh
            // 
            this.LFindVeh.AutoSize = true;
            this.LFindVeh.Location = new System.Drawing.Point(5, 17);
            this.LFindVeh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFindVeh.Name = "LFindVeh";
            this.LFindVeh.Size = new System.Drawing.Size(193, 45);
            this.LFindVeh.TabIndex = 25;
            this.LFindVeh.Text = "Номер гаража для транспорта, \r\nв котором содержится \r\nтранспорт с заданым номером" +
    ".";
            // 
            // tbVehFindPlate
            // 
            this.tbVehFindPlate.Location = new System.Drawing.Point(59, 83);
            this.tbVehFindPlate.Name = "tbVehFindPlate";
            this.tbVehFindPlate.Size = new System.Drawing.Size(116, 21);
            this.tbVehFindPlate.TabIndex = 23;
            // 
            // bFindVehByPlate
            // 
            this.bFindVehByPlate.Location = new System.Drawing.Point(59, 110);
            this.bFindVehByPlate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bFindVehByPlate.Name = "bFindVehByPlate";
            this.bFindVehByPlate.Size = new System.Drawing.Size(116, 28);
            this.bFindVehByPlate.TabIndex = 19;
            this.bFindVehByPlate.Text = "Найти";
            this.bFindVehByPlate.UseVisualStyleBackColor = true;
            this.bFindVehByPlate.Click += new System.EventHandler(this.bFindVehByPlate_Click);
            // 
            // gbVehSort
            // 
            this.gbVehSort.Controls.Add(this.cbSortVehDesc);
            this.gbVehSort.Controls.Add(this.rbSortVehPrice);
            this.gbVehSort.Controls.Add(this.rbSortVehPlate);
            this.gbVehSort.Controls.Add(this.rbSortVehID);
            this.gbVehSort.Location = new System.Drawing.Point(610, 32);
            this.gbVehSort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbVehSort.Name = "gbVehSort";
            this.gbVehSort.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbVehSort.Size = new System.Drawing.Size(195, 166);
            this.gbVehSort.TabIndex = 22;
            this.gbVehSort.TabStop = false;
            this.gbVehSort.Text = "Отсортировать";
            // 
            // cbSortVehDesc
            // 
            this.cbSortVehDesc.AutoSize = true;
            this.cbSortVehDesc.Location = new System.Drawing.Point(8, 132);
            this.cbSortVehDesc.Name = "cbSortVehDesc";
            this.cbSortVehDesc.Size = new System.Drawing.Size(101, 19);
            this.cbSortVehDesc.TabIndex = 13;
            this.cbSortVehDesc.Text = "по убыванию";
            this.cbSortVehDesc.UseVisualStyleBackColor = true;
            this.cbSortVehDesc.CheckedChanged += new System.EventHandler(this.SortVehicle);
            // 
            // rbSortVehPrice
            // 
            this.rbSortVehPrice.AutoSize = true;
            this.rbSortVehPrice.Location = new System.Drawing.Point(8, 92);
            this.rbSortVehPrice.Name = "rbSortVehPrice";
            this.rbSortVehPrice.Size = new System.Drawing.Size(156, 34);
            this.rbSortVehPrice.TabIndex = 9;
            this.rbSortVehPrice.Text = "Отсортировать \r\nпо цене обслуживания";
            this.rbSortVehPrice.UseVisualStyleBackColor = true;
            this.rbSortVehPrice.CheckedChanged += new System.EventHandler(this.SortVehicle);
            // 
            // rbSortVehPlate
            // 
            this.rbSortVehPlate.AutoSize = true;
            this.rbSortVehPlate.Location = new System.Drawing.Point(8, 54);
            this.rbSortVehPlate.Name = "rbSortVehPlate";
            this.rbSortVehPlate.Size = new System.Drawing.Size(141, 34);
            this.rbSortVehPlate.TabIndex = 8;
            this.rbSortVehPlate.Text = "Отсортировать \r\nпо номерному знаку";
            this.rbSortVehPlate.UseVisualStyleBackColor = true;
            this.rbSortVehPlate.CheckedChanged += new System.EventHandler(this.SortVehicle);
            // 
            // rbSortVehID
            // 
            this.rbSortVehID.AutoSize = true;
            this.rbSortVehID.Location = new System.Drawing.Point(8, 29);
            this.rbSortVehID.Name = "rbSortVehID";
            this.rbSortVehID.Size = new System.Drawing.Size(149, 19);
            this.rbSortVehID.TabIndex = 7;
            this.rbSortVehID.Text = "Отсортировать по ID";
            this.rbSortVehID.UseVisualStyleBackColor = true;
            this.rbSortVehID.CheckedChanged += new System.EventHandler(this.SortVehicle);
            // 
            // LVehicle
            // 
            this.LVehicle.AutoSize = true;
            this.LVehicle.Location = new System.Drawing.Point(14, 14);
            this.LVehicle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LVehicle.Name = "LVehicle";
            this.LVehicle.Size = new System.Drawing.Size(207, 15);
            this.LVehicle.TabIndex = 3;
            this.LVehicle.Text = "Общая информация о транспорте";
            // 
            // dgvVehicle
            // 
            this.dgvVehicle.AllowUserToAddRows = false;
            this.dgvVehicle.AllowUserToDeleteRows = false;
            this.dgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicle.Location = new System.Drawing.Point(17, 141);
            this.dgvVehicle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.ReadOnly = true;
            this.dgvVehicle.Size = new System.Drawing.Size(583, 207);
            this.dgvVehicle.TabIndex = 1;
            // 
            // tabPageRepairs
            // 
            this.tabPageRepairs.Controls.Add(this.gbIUDRep);
            this.tabPageRepairs.Controls.Add(this.gbSortRep);
            this.tabPageRepairs.Controls.Add(this.gbFindRep);
            this.tabPageRepairs.Controls.Add(this.gbRepairs);
            this.tabPageRepairs.Controls.Add(this.dgvRepairInfo);
            this.tabPageRepairs.Controls.Add(this.LRepairs);
            this.tabPageRepairs.Location = new System.Drawing.Point(4, 24);
            this.tabPageRepairs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageRepairs.Name = "tabPageRepairs";
            this.tabPageRepairs.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageRepairs.Size = new System.Drawing.Size(821, 756);
            this.tabPageRepairs.TabIndex = 2;
            this.tabPageRepairs.Text = "Ремонтные работы";
            this.tabPageRepairs.UseVisualStyleBackColor = true;
            // 
            // gbIUDRep
            // 
            this.gbIUDRep.Controls.Add(this.LIUDRepID);
            this.gbIUDRep.Controls.Add(this.tbIUDRepID);
            this.gbIUDRep.Controls.Add(this.bRepUpdate);
            this.gbIUDRep.Controls.Add(this.bRepDelete);
            this.gbIUDRep.Controls.Add(this.bRepInsert);
            this.gbIUDRep.Location = new System.Drawing.Point(17, 32);
            this.gbIUDRep.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbIUDRep.Name = "gbIUDRep";
            this.gbIUDRep.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbIUDRep.Size = new System.Drawing.Size(243, 88);
            this.gbIUDRep.TabIndex = 44;
            this.gbIUDRep.TabStop = false;
            this.gbIUDRep.Text = "Работа с данными";
            // 
            // LIUDRepID
            // 
            this.LIUDRepID.AutoSize = true;
            this.LIUDRepID.Location = new System.Drawing.Point(131, 61);
            this.LIUDRepID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LIUDRepID.Name = "LIUDRepID";
            this.LIUDRepID.Size = new System.Drawing.Size(22, 15);
            this.LIUDRepID.TabIndex = 37;
            this.LIUDRepID.Text = "ID:";
            // 
            // tbIUDRepID
            // 
            this.tbIUDRepID.Location = new System.Drawing.Point(158, 58);
            this.tbIUDRepID.Name = "tbIUDRepID";
            this.tbIUDRepID.Size = new System.Drawing.Size(81, 21);
            this.tbIUDRepID.TabIndex = 36;
            this.tbIUDRepID.TextChanged += new System.EventHandler(this.tbIUDRepID_TextChanged);
            // 
            // bRepUpdate
            // 
            this.bRepUpdate.Enabled = false;
            this.bRepUpdate.Location = new System.Drawing.Point(5, 20);
            this.bRepUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bRepUpdate.Name = "bRepUpdate";
            this.bRepUpdate.Size = new System.Drawing.Size(109, 28);
            this.bRepUpdate.TabIndex = 34;
            this.bRepUpdate.Text = "Обновить по ID";
            this.bRepUpdate.UseVisualStyleBackColor = true;
            this.bRepUpdate.Click += new System.EventHandler(this.bRepUpdate_Click);
            // 
            // bRepDelete
            // 
            this.bRepDelete.Enabled = false;
            this.bRepDelete.Location = new System.Drawing.Point(5, 54);
            this.bRepDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bRepDelete.Name = "bRepDelete";
            this.bRepDelete.Size = new System.Drawing.Size(109, 28);
            this.bRepDelete.TabIndex = 35;
            this.bRepDelete.Text = "Удалить по ID";
            this.bRepDelete.UseVisualStyleBackColor = true;
            this.bRepDelete.Click += new System.EventHandler(this.bRepDelete_Click);
            // 
            // bRepInsert
            // 
            this.bRepInsert.Location = new System.Drawing.Point(140, 20);
            this.bRepInsert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bRepInsert.Name = "bRepInsert";
            this.bRepInsert.Size = new System.Drawing.Size(99, 28);
            this.bRepInsert.TabIndex = 33;
            this.bRepInsert.Text = "Вставить";
            this.bRepInsert.UseVisualStyleBackColor = true;
            this.bRepInsert.Click += new System.EventHandler(this.bRepInsert_Click);
            // 
            // gbSortRep
            // 
            this.gbSortRep.Controls.Add(this.cbSortRepDesc);
            this.gbSortRep.Controls.Add(this.rbSortRepCost);
            this.gbSortRep.Controls.Add(this.rbSortRepID);
            this.gbSortRep.Location = new System.Drawing.Point(568, 32);
            this.gbSortRep.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbSortRep.Name = "gbSortRep";
            this.gbSortRep.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbSortRep.Size = new System.Drawing.Size(195, 121);
            this.gbSortRep.TabIndex = 26;
            this.gbSortRep.TabStop = false;
            this.gbSortRep.Text = "Отсортировать";
            // 
            // cbSortRepDesc
            // 
            this.cbSortRepDesc.AutoSize = true;
            this.cbSortRepDesc.Location = new System.Drawing.Point(8, 94);
            this.cbSortRepDesc.Name = "cbSortRepDesc";
            this.cbSortRepDesc.Size = new System.Drawing.Size(101, 19);
            this.cbSortRepDesc.TabIndex = 13;
            this.cbSortRepDesc.Text = "по убыванию";
            this.cbSortRepDesc.UseVisualStyleBackColor = true;
            this.cbSortRepDesc.CheckedChanged += new System.EventHandler(this.SortRepair);
            // 
            // rbSortRepCost
            // 
            this.rbSortRepCost.AutoSize = true;
            this.rbSortRepCost.Location = new System.Drawing.Point(8, 54);
            this.rbSortRepCost.Name = "rbSortRepCost";
            this.rbSortRepCost.Size = new System.Drawing.Size(150, 34);
            this.rbSortRepCost.TabIndex = 8;
            this.rbSortRepCost.Text = "Отсортировать \r\nпо полной стоимости";
            this.rbSortRepCost.UseVisualStyleBackColor = true;
            this.rbSortRepCost.CheckedChanged += new System.EventHandler(this.SortRepair);
            // 
            // rbSortRepID
            // 
            this.rbSortRepID.AutoSize = true;
            this.rbSortRepID.Location = new System.Drawing.Point(8, 29);
            this.rbSortRepID.Name = "rbSortRepID";
            this.rbSortRepID.Size = new System.Drawing.Size(149, 19);
            this.rbSortRepID.TabIndex = 7;
            this.rbSortRepID.Text = "Отсортировать по ID";
            this.rbSortRepID.UseVisualStyleBackColor = true;
            this.rbSortRepID.CheckedChanged += new System.EventHandler(this.SortRepair);
            // 
            // gbFindRep
            // 
            this.gbFindRep.Controls.Add(this.LFindRepID);
            this.gbFindRep.Controls.Add(this.label2);
            this.gbFindRep.Controls.Add(this.tbRepFindID);
            this.gbFindRep.Controls.Add(this.bFindPartsByRepID);
            this.gbFindRep.Location = new System.Drawing.Point(568, 159);
            this.gbFindRep.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbFindRep.Name = "gbFindRep";
            this.gbFindRep.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbFindRep.Size = new System.Drawing.Size(195, 119);
            this.gbFindRep.TabIndex = 25;
            this.gbFindRep.TabStop = false;
            this.gbFindRep.Text = "Найти";
            // 
            // LFindRepID
            // 
            this.LFindRepID.AutoSize = true;
            this.LFindRepID.Location = new System.Drawing.Point(5, 62);
            this.LFindRepID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFindRepID.Name = "LFindRepID";
            this.LFindRepID.Size = new System.Drawing.Size(82, 15);
            this.LFindRepID.TabIndex = 25;
            this.LFindRepID.Text = "ID (repair_id):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Списко деталей, \r\nзатраченых при ремонте";
            // 
            // tbRepFindID
            // 
            this.tbRepFindID.Location = new System.Drawing.Point(92, 59);
            this.tbRepFindID.Name = "tbRepFindID";
            this.tbRepFindID.Size = new System.Drawing.Size(98, 21);
            this.tbRepFindID.TabIndex = 23;
            // 
            // bFindPartsByRepID
            // 
            this.bFindPartsByRepID.Location = new System.Drawing.Point(92, 86);
            this.bFindPartsByRepID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bFindPartsByRepID.Name = "bFindPartsByRepID";
            this.bFindPartsByRepID.Size = new System.Drawing.Size(99, 28);
            this.bFindPartsByRepID.TabIndex = 19;
            this.bFindPartsByRepID.Text = "Найти";
            this.bFindPartsByRepID.UseVisualStyleBackColor = true;
            this.bFindPartsByRepID.Click += new System.EventHandler(this.bFindPartsByRepID_Click);
            // 
            // gbRepairs
            // 
            this.gbRepairs.Controls.Add(this.LRepSum);
            this.gbRepairs.Controls.Add(this.tbRepairExID);
            this.gbRepairs.Controls.Add(this.bRepairVehicle);
            this.gbRepairs.Controls.Add(this.bRepairCrew);
            this.gbRepairs.Location = new System.Drawing.Point(270, 32);
            this.gbRepairs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbRepairs.Name = "gbRepairs";
            this.gbRepairs.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbRepairs.Size = new System.Drawing.Size(290, 86);
            this.gbRepairs.TabIndex = 6;
            this.gbRepairs.TabStop = false;
            this.gbRepairs.Text = "Вывести сумму ремонтных работ";
            // 
            // LRepSum
            // 
            this.LRepSum.AutoSize = true;
            this.LRepSum.Location = new System.Drawing.Point(5, 57);
            this.LRepSum.Name = "LRepSum";
            this.LRepSum.Size = new System.Drawing.Size(146, 15);
            this.LRepSum.TabIndex = 6;
            this.LRepSum.Text = "ID бригады/транспорта:";
            // 
            // tbRepairExID
            // 
            this.tbRepairExID.Location = new System.Drawing.Point(157, 54);
            this.tbRepairExID.Name = "tbRepairExID";
            this.tbRepairExID.Size = new System.Drawing.Size(125, 21);
            this.tbRepairExID.TabIndex = 5;
            // 
            // bRepairVehicle
            // 
            this.bRepairVehicle.Location = new System.Drawing.Point(157, 21);
            this.bRepairVehicle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bRepairVehicle.Name = "bRepairVehicle";
            this.bRepairVehicle.Size = new System.Drawing.Size(125, 27);
            this.bRepairVehicle.TabIndex = 4;
            this.bRepairVehicle.Text = "по транспорту";
            this.bRepairVehicle.UseVisualStyleBackColor = true;
            this.bRepairVehicle.Click += new System.EventHandler(this.GetSpecialRepair);
            // 
            // bRepairCrew
            // 
            this.bRepairCrew.Location = new System.Drawing.Point(8, 18);
            this.bRepairCrew.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bRepairCrew.Name = "bRepairCrew";
            this.bRepairCrew.Size = new System.Drawing.Size(125, 27);
            this.bRepairCrew.TabIndex = 3;
            this.bRepairCrew.Text = "по бригаде";
            this.bRepairCrew.UseVisualStyleBackColor = true;
            this.bRepairCrew.Click += new System.EventHandler(this.GetSpecialRepair);
            // 
            // LRepairs
            // 
            this.LRepairs.AutoSize = true;
            this.LRepairs.Location = new System.Drawing.Point(14, 14);
            this.LRepairs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LRepairs.Name = "LRepairs";
            this.LRepairs.Size = new System.Drawing.Size(215, 15);
            this.LRepairs.TabIndex = 2;
            this.LRepairs.Text = "Информация о ремонтных работах";
            // 
            // tabPagePath
            // 
            this.tabPagePath.Controls.Add(this.gbIUDPath);
            this.tabPagePath.Controls.Add(this.gbFinddPaths);
            this.tabPagePath.Controls.Add(this.LPaths);
            this.tabPagePath.Controls.Add(this.gbPathsSort);
            this.tabPagePath.Controls.Add(this.dgvPaths);
            this.tabPagePath.Location = new System.Drawing.Point(4, 24);
            this.tabPagePath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPagePath.Name = "tabPagePath";
            this.tabPagePath.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPagePath.Size = new System.Drawing.Size(821, 400);
            this.tabPagePath.TabIndex = 3;
            this.tabPagePath.Text = "Управление перевозками";
            this.tabPagePath.UseVisualStyleBackColor = true;
            // 
            // gbIUDPath
            // 
            this.gbIUDPath.Controls.Add(this.LIUDPathID);
            this.gbIUDPath.Controls.Add(this.bPathInsert);
            this.gbIUDPath.Controls.Add(this.tbIUDPathID);
            this.gbIUDPath.Controls.Add(this.bPathUpdate);
            this.gbIUDPath.Controls.Add(this.bPathDelete);
            this.gbIUDPath.Location = new System.Drawing.Point(17, 39);
            this.gbIUDPath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbIUDPath.Name = "gbIUDPath";
            this.gbIUDPath.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbIUDPath.Size = new System.Drawing.Size(243, 96);
            this.gbIUDPath.TabIndex = 43;
            this.gbIUDPath.TabStop = false;
            this.gbIUDPath.Text = "Работа с данными";
            // 
            // LIUDPathID
            // 
            this.LIUDPathID.AutoSize = true;
            this.LIUDPathID.Location = new System.Drawing.Point(130, 70);
            this.LIUDPathID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LIUDPathID.Name = "LIUDPathID";
            this.LIUDPathID.Size = new System.Drawing.Size(22, 15);
            this.LIUDPathID.TabIndex = 49;
            this.LIUDPathID.Text = "ID:";
            // 
            // bPathInsert
            // 
            this.bPathInsert.Location = new System.Drawing.Point(130, 29);
            this.bPathInsert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bPathInsert.Name = "bPathInsert";
            this.bPathInsert.Size = new System.Drawing.Size(109, 28);
            this.bPathInsert.TabIndex = 45;
            this.bPathInsert.Text = "Вставить";
            this.bPathInsert.UseVisualStyleBackColor = true;
            this.bPathInsert.Click += new System.EventHandler(this.bPathInsert_Click);
            // 
            // tbIUDPathID
            // 
            this.tbIUDPathID.Location = new System.Drawing.Point(157, 67);
            this.tbIUDPathID.Name = "tbIUDPathID";
            this.tbIUDPathID.Size = new System.Drawing.Size(81, 21);
            this.tbIUDPathID.TabIndex = 48;
            this.tbIUDPathID.TextChanged += new System.EventHandler(this.tbIUDPathID_TextChanged);
            // 
            // bPathUpdate
            // 
            this.bPathUpdate.Enabled = false;
            this.bPathUpdate.Location = new System.Drawing.Point(4, 29);
            this.bPathUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bPathUpdate.Name = "bPathUpdate";
            this.bPathUpdate.Size = new System.Drawing.Size(109, 28);
            this.bPathUpdate.TabIndex = 46;
            this.bPathUpdate.Text = "Обновить по ID";
            this.bPathUpdate.UseVisualStyleBackColor = true;
            this.bPathUpdate.Click += new System.EventHandler(this.bPathUpdate_Click);
            // 
            // bPathDelete
            // 
            this.bPathDelete.Enabled = false;
            this.bPathDelete.Location = new System.Drawing.Point(4, 63);
            this.bPathDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bPathDelete.Name = "bPathDelete";
            this.bPathDelete.Size = new System.Drawing.Size(109, 28);
            this.bPathDelete.TabIndex = 47;
            this.bPathDelete.Text = "Удалить по ID";
            this.bPathDelete.UseVisualStyleBackColor = true;
            this.bPathDelete.Click += new System.EventHandler(this.bPathDelete_Click);
            // 
            // gbFinddPaths
            // 
            this.gbFinddPaths.Controls.Add(this.lbPoints);
            this.gbFinddPaths.Controls.Add(this.bClearPoints);
            this.gbFinddPaths.Controls.Add(this.LFintPaths);
            this.gbFinddPaths.Controls.Add(this.bFindPathByPoints);
            this.gbFinddPaths.Location = new System.Drawing.Point(273, 166);
            this.gbFinddPaths.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbFinddPaths.Name = "gbFinddPaths";
            this.gbFinddPaths.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbFinddPaths.Size = new System.Drawing.Size(218, 219);
            this.gbFinddPaths.TabIndex = 29;
            this.gbFinddPaths.TabStop = false;
            this.gbFinddPaths.Text = "Найти";
            // 
            // lbPoints
            // 
            this.lbPoints.FormattingEnabled = true;
            this.lbPoints.ItemHeight = 15;
            this.lbPoints.Location = new System.Drawing.Point(8, 54);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPoints.Size = new System.Drawing.Size(202, 124);
            this.lbPoints.TabIndex = 30;
            this.lbPoints.SelectedIndexChanged += new System.EventHandler(this.lbPoints_SelectedIndexChanged);
            // 
            // bClearPoints
            // 
            this.bClearPoints.Location = new System.Drawing.Point(8, 184);
            this.bClearPoints.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bClearPoints.Name = "bClearPoints";
            this.bClearPoints.Size = new System.Drawing.Size(82, 28);
            this.bClearPoints.TabIndex = 30;
            this.bClearPoints.Text = "clear";
            this.bClearPoints.UseVisualStyleBackColor = true;
            this.bClearPoints.Click += new System.EventHandler(this.bClearPoints_Click);
            // 
            // LFintPaths
            // 
            this.LFintPaths.AutoSize = true;
            this.LFintPaths.Location = new System.Drawing.Point(5, 17);
            this.LFintPaths.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFintPaths.Name = "LFintPaths";
            this.LFintPaths.Size = new System.Drawing.Size(205, 30);
            this.LFintPaths.TabIndex = 25;
            this.LFintPaths.Text = "Маршруты, которые проходят \r\nчерез один из выбранных пунктов";
            // 
            // bFindPathByPoints
            // 
            this.bFindPathByPoints.Enabled = false;
            this.bFindPathByPoints.Location = new System.Drawing.Point(94, 184);
            this.bFindPathByPoints.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bFindPathByPoints.Name = "bFindPathByPoints";
            this.bFindPathByPoints.Size = new System.Drawing.Size(116, 28);
            this.bFindPathByPoints.TabIndex = 19;
            this.bFindPathByPoints.Text = "Найти";
            this.bFindPathByPoints.UseVisualStyleBackColor = true;
            this.bFindPathByPoints.Click += new System.EventHandler(this.bFindPathByPoints_Click);
            // 
            // LPaths
            // 
            this.LPaths.AutoSize = true;
            this.LPaths.Location = new System.Drawing.Point(14, 14);
            this.LPaths.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LPaths.Name = "LPaths";
            this.LPaths.Size = new System.Drawing.Size(123, 15);
            this.LPaths.TabIndex = 28;
            this.LPaths.Text = "Маршруты и пункты";
            // 
            // gbPathsSort
            // 
            this.gbPathsSort.Controls.Add(this.cbSortPathsDesc);
            this.gbPathsSort.Controls.Add(this.rbSortPathPass);
            this.gbPathsSort.Controls.Add(this.rbSortPathID);
            this.gbPathsSort.Location = new System.Drawing.Point(273, 39);
            this.gbPathsSort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbPathsSort.Name = "gbPathsSort";
            this.gbPathsSort.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbPathsSort.Size = new System.Drawing.Size(218, 121);
            this.gbPathsSort.TabIndex = 27;
            this.gbPathsSort.TabStop = false;
            this.gbPathsSort.Text = "Отсортировать";
            // 
            // cbSortPathsDesc
            // 
            this.cbSortPathsDesc.AutoSize = true;
            this.cbSortPathsDesc.Location = new System.Drawing.Point(8, 94);
            this.cbSortPathsDesc.Name = "cbSortPathsDesc";
            this.cbSortPathsDesc.Size = new System.Drawing.Size(101, 19);
            this.cbSortPathsDesc.TabIndex = 13;
            this.cbSortPathsDesc.Text = "по убыванию";
            this.cbSortPathsDesc.UseVisualStyleBackColor = true;
            this.cbSortPathsDesc.CheckedChanged += new System.EventHandler(this.SortPaths);
            // 
            // rbSortPathPass
            // 
            this.rbSortPathPass.AutoSize = true;
            this.rbSortPathPass.Location = new System.Drawing.Point(8, 54);
            this.rbSortPathPass.Name = "rbSortPathPass";
            this.rbSortPathPass.Size = new System.Drawing.Size(180, 34);
            this.rbSortPathPass.TabIndex = 8;
            this.rbSortPathPass.Text = "Отсортировать \r\nпо количеству пассажиров";
            this.rbSortPathPass.UseVisualStyleBackColor = true;
            this.rbSortPathPass.CheckedChanged += new System.EventHandler(this.SortPaths);
            // 
            // rbSortPathID
            // 
            this.rbSortPathID.AutoSize = true;
            this.rbSortPathID.Location = new System.Drawing.Point(8, 29);
            this.rbSortPathID.Name = "rbSortPathID";
            this.rbSortPathID.Size = new System.Drawing.Size(149, 19);
            this.rbSortPathID.TabIndex = 7;
            this.rbSortPathID.Text = "Отсортировать по ID";
            this.rbSortPathID.UseVisualStyleBackColor = true;
            this.rbSortPathID.CheckedChanged += new System.EventHandler(this.SortPaths);
            // 
            // dgvPaths
            // 
            this.dgvPaths.AllowUserToAddRows = false;
            this.dgvPaths.AllowUserToDeleteRows = false;
            this.dgvPaths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaths.Location = new System.Drawing.Point(17, 141);
            this.dgvPaths.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvPaths.Name = "dgvPaths";
            this.dgvPaths.ReadOnly = true;
            this.dgvPaths.Size = new System.Drawing.Size(243, 244);
            this.dgvPaths.TabIndex = 2;
            // 
            // DBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 456);
            this.Controls.Add(this.tabMainControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "DBForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DBForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepairInfo)).EndInit();
            this.tabMainControl.ResumeLayout(false);
            this.tabPageVehicle.ResumeLayout(false);
            this.tabPageVehicle.PerformLayout();
            this.gbIUDVeh.ResumeLayout(false);
            this.gbIUDVeh.PerformLayout();
            this.gbVehFilter.ResumeLayout(false);
            this.gbVehFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinMile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMile)).EndInit();
            this.gbVehFind.ResumeLayout(false);
            this.gbVehFind.PerformLayout();
            this.gbVehSort.ResumeLayout(false);
            this.gbVehSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            this.tabPageRepairs.ResumeLayout(false);
            this.tabPageRepairs.PerformLayout();
            this.gbIUDRep.ResumeLayout(false);
            this.gbIUDRep.PerformLayout();
            this.gbSortRep.ResumeLayout(false);
            this.gbSortRep.PerformLayout();
            this.gbFindRep.ResumeLayout(false);
            this.gbFindRep.PerformLayout();
            this.gbRepairs.ResumeLayout(false);
            this.gbRepairs.PerformLayout();
            this.tabPagePath.ResumeLayout(false);
            this.tabPagePath.PerformLayout();
            this.gbIUDPath.ResumeLayout(false);
            this.gbIUDPath.PerformLayout();
            this.gbFinddPaths.ResumeLayout(false);
            this.gbFinddPaths.PerformLayout();
            this.gbPathsSort.ResumeLayout(false);
            this.gbPathsSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaths)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRepairInfo;
        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.TabPage tabPageVehicle;
        private System.Windows.Forms.TabPage tabPageRepairs;
        private System.Windows.Forms.Label LRepairs;
        private System.Windows.Forms.TabPage tabPagePath;
        private System.Windows.Forms.Button bRepairVehicle;
        private System.Windows.Forms.Button bRepairCrew;
        private System.Windows.Forms.GroupBox gbRepairs;
        private System.Windows.Forms.Label LRepSum;
        private System.Windows.Forms.TextBox tbRepairExID;
        private System.Windows.Forms.Label LVehicle;
        private System.Windows.Forms.DataGridView dgvVehicle;
        private System.Windows.Forms.TextBox tbVehFilter;
        private System.Windows.Forms.CheckBox cbVehFilter;
        private System.Windows.Forms.CheckBox cbMaxMile;
        private System.Windows.Forms.CheckBox cbMinMile;
        private System.Windows.Forms.NumericUpDown nudMaxMile;
        private System.Windows.Forms.NumericUpDown nudMinMile;
        private System.Windows.Forms.Button bFindVehByPlate;
        private System.Windows.Forms.GroupBox gbVehSort;
        private System.Windows.Forms.RadioButton rbSortVehPrice;
        private System.Windows.Forms.RadioButton rbSortVehPlate;
        private System.Windows.Forms.RadioButton rbSortVehID;
        private System.Windows.Forms.CheckBox cbSortVehDesc;
        private System.Windows.Forms.TextBox tbVehFindPlate;
        private System.Windows.Forms.GroupBox gbVehFind;
        private System.Windows.Forms.Label LFindVeh;
        private System.Windows.Forms.Label LFindPlate;
        private System.Windows.Forms.GroupBox gbVehFilter;
        private System.Windows.Forms.GroupBox gbFindRep;
        private System.Windows.Forms.Label LFindRepID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRepFindID;
        private System.Windows.Forms.Button bFindPartsByRepID;
        private System.Windows.Forms.GroupBox gbSortRep;
        private System.Windows.Forms.CheckBox cbSortRepDesc;
        private System.Windows.Forms.RadioButton rbSortRepCost;
        private System.Windows.Forms.RadioButton rbSortRepID;
        private System.Windows.Forms.DataGridView dgvPaths;
        private System.Windows.Forms.Label LPaths;
        private System.Windows.Forms.GroupBox gbPathsSort;
        private System.Windows.Forms.CheckBox cbSortPathsDesc;
        private System.Windows.Forms.RadioButton rbSortPathPass;
        private System.Windows.Forms.RadioButton rbSortPathID;
        private System.Windows.Forms.GroupBox gbFinddPaths;
        private System.Windows.Forms.Label LFintPaths;
        private System.Windows.Forms.Button bFindPathByPoints;
        private System.Windows.Forms.Button bClearPoints;
        private System.Windows.Forms.ListBox lbPoints;
        private System.Windows.Forms.Label LIUDRepID;
        private System.Windows.Forms.TextBox tbIUDRepID;
        private System.Windows.Forms.Button bRepDelete;
        private System.Windows.Forms.Button bRepUpdate;
        private System.Windows.Forms.Button bRepInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIUDVehID;
        private System.Windows.Forms.Button bVehDelete;
        private System.Windows.Forms.Button bVehUpdate;
        private System.Windows.Forms.Button bVehInsert;
        private System.Windows.Forms.GroupBox gbIUDPath;
        private System.Windows.Forms.Label LIUDPathID;
        private System.Windows.Forms.Button bPathInsert;
        private System.Windows.Forms.TextBox tbIUDPathID;
        private System.Windows.Forms.Button bPathUpdate;
        private System.Windows.Forms.Button bPathDelete;
        private System.Windows.Forms.GroupBox gbIUDVeh;
        private System.Windows.Forms.GroupBox gbIUDRep;
    }
}

