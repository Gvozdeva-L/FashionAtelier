namespace studio
{
    partial class Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrderOrder = new System.Windows.Forms.Button();
            this.btnMaterialOrder = new System.Windows.Forms.Button();
            this.btnStuffOrder = new System.Windows.Forms.Button();
            this.btnServiceOrder = new System.Windows.Forms.Button();
            this.cbNameServise = new System.Windows.Forms.ComboBox();
            this.cbMaster = new System.Windows.Forms.ComboBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnCleanOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.tbDescribeOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateOrder = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOrderEnd = new System.Windows.Forms.Button();
            this.tbMinPrice = new System.Windows.Forms.TextBox();
            this.tbMaxPrice = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbClientPhoneNum = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbFilterService = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbFilterMaster = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnFiltr = new System.Windows.Forms.Button();
            this.btnCleanFiltr = new System.Windows.Forms.Button();
            this.btnOffFiltr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(159)))), ((int)(((byte)(61)))));
            this.dgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(101)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column11,
            this.Column10,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.dgvOrders.Location = new System.Drawing.Point(141, 65);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1364, 431);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер замовлення";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Назва послуги";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Номер телефону клієнта";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ім\'я клієнта";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Майстер";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 170;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Дата оформлення";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Дата видачі";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Статус";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ціна";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 70;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Опис";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 170;
            // 
            // btnOrderOrder
            // 
            this.btnOrderOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.btnOrderOrder.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.btnOrderOrder.Location = new System.Drawing.Point(141, 2);
            this.btnOrderOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderOrder.Name = "btnOrderOrder";
            this.btnOrderOrder.Size = new System.Drawing.Size(139, 58);
            this.btnOrderOrder.TabIndex = 1;
            this.btnOrderOrder.TabStop = false;
            this.btnOrderOrder.Text = "Замовлення";
            this.btnOrderOrder.UseVisualStyleBackColor = false;
            this.btnOrderOrder.Click += new System.EventHandler(this.btnOrderOrder_Click);
            // 
            // btnMaterialOrder
            // 
            this.btnMaterialOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.btnMaterialOrder.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterialOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.btnMaterialOrder.Location = new System.Drawing.Point(285, 2);
            this.btnMaterialOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaterialOrder.Name = "btnMaterialOrder";
            this.btnMaterialOrder.Size = new System.Drawing.Size(139, 58);
            this.btnMaterialOrder.TabIndex = 2;
            this.btnMaterialOrder.Text = "Матеріали";
            this.btnMaterialOrder.UseVisualStyleBackColor = false;
            this.btnMaterialOrder.Click += new System.EventHandler(this.btnMaterialOrder_Click);
            // 
            // btnStuffOrder
            // 
            this.btnStuffOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.btnStuffOrder.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuffOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.btnStuffOrder.Location = new System.Drawing.Point(432, 2);
            this.btnStuffOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStuffOrder.Name = "btnStuffOrder";
            this.btnStuffOrder.Size = new System.Drawing.Size(139, 58);
            this.btnStuffOrder.TabIndex = 3;
            this.btnStuffOrder.Text = "Співробітники";
            this.btnStuffOrder.UseVisualStyleBackColor = false;
            this.btnStuffOrder.Click += new System.EventHandler(this.btnStuffOrder_Click);
            // 
            // btnServiceOrder
            // 
            this.btnServiceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.btnServiceOrder.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.btnServiceOrder.Location = new System.Drawing.Point(576, 2);
            this.btnServiceOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServiceOrder.Name = "btnServiceOrder";
            this.btnServiceOrder.Size = new System.Drawing.Size(139, 58);
            this.btnServiceOrder.TabIndex = 4;
            this.btnServiceOrder.Text = "Послуги";
            this.btnServiceOrder.UseVisualStyleBackColor = false;
            this.btnServiceOrder.Click += new System.EventHandler(this.btnServiceOrder_Click);
            // 
            // cbNameServise
            // 
            this.cbNameServise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.cbNameServise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbNameServise.FormattingEnabled = true;
            this.cbNameServise.Location = new System.Drawing.Point(149, 538);
            this.cbNameServise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNameServise.Name = "cbNameServise";
            this.cbNameServise.Size = new System.Drawing.Size(329, 32);
            this.cbNameServise.TabIndex = 5;
            this.cbNameServise.SelectedIndexChanged += new System.EventHandler(this.cbNameServise_SelectedIndexChanged_1);
            // 
            // cbMaster
            // 
            this.cbMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.cbMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMaster.FormattingEnabled = true;
            this.cbMaster.Location = new System.Drawing.Point(585, 538);
            this.cbMaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaster.Name = "cbMaster";
            this.cbMaster.Size = new System.Drawing.Size(329, 32);
            this.cbMaster.TabIndex = 6;
            // 
            // tbClientName
            // 
            this.tbClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.tbClientName.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientName.Location = new System.Drawing.Point(149, 665);
            this.tbClientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(329, 31);
            this.tbClientName.TabIndex = 9;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(585, 668);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(329, 32);
            this.cbStatus.TabIndex = 10;
            // 
            // btnCleanOrder
            // 
            this.btnCleanOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.btnCleanOrder.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.btnCleanOrder.Location = new System.Drawing.Point(149, 762);
            this.btnCleanOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCleanOrder.Name = "btnCleanOrder";
            this.btnCleanOrder.Size = new System.Drawing.Size(199, 50);
            this.btnCleanOrder.TabIndex = 11;
            this.btnCleanOrder.Text = "Очистити форму";
            this.btnCleanOrder.UseVisualStyleBackColor = false;
            this.btnCleanOrder.Click += new System.EventHandler(this.btnCleanOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(101)))), ((int)(((byte)(44)))));
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(245)))), ((int)(((byte)(210)))));
            this.btnAddOrder.Location = new System.Drawing.Point(1315, 725);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(191, 87);
            this.btnAddOrder.TabIndex = 13;
            this.btnAddOrder.Text = "Додати";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // tbDescribeOrder
            // 
            this.tbDescribeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.tbDescribeOrder.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescribeOrder.Location = new System.Drawing.Point(1048, 538);
            this.tbDescribeOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescribeOrder.Multiline = true;
            this.tbDescribeOrder.Name = "tbDescribeOrder";
            this.tbDescribeOrder.Size = new System.Drawing.Size(315, 168);
            this.tbDescribeOrder.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(580, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Майстер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(145, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Назва послуги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(145, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Номер телефона клієнта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.label4.Location = new System.Drawing.Point(145, 638);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "ПІБ клієнта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.label5.Location = new System.Drawing.Point(580, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Дата офрмлення замовлення";
            // 
            // dtpDateOrder
            // 
            this.dtpDateOrder.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.dtpDateOrder.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOrder.Location = new System.Drawing.Point(585, 607);
            this.dtpDateOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateOrder.Name = "dtpDateOrder";
            this.dtpDateOrder.Size = new System.Drawing.Size(328, 31);
            this.dtpDateOrder.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.label6.Location = new System.Drawing.Point(581, 640);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Статус";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.label7.Location = new System.Drawing.Point(1043, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Опис";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.label8.Location = new System.Drawing.Point(841, 734);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 26);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ціна";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnOrderEnd
            // 
            this.btnOrderEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(101)))), ((int)(((byte)(44)))));
            this.btnOrderEnd.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(245)))), ((int)(((byte)(210)))));
            this.btnOrderEnd.Location = new System.Drawing.Point(7, 282);
            this.btnOrderEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderEnd.Name = "btnOrderEnd";
            this.btnOrderEnd.Size = new System.Drawing.Size(129, 103);
            this.btnOrderEnd.TabIndex = 26;
            this.btnOrderEnd.Text = "Видати замовлення";
            this.btnOrderEnd.UseVisualStyleBackColor = false;
            this.btnOrderEnd.Click += new System.EventHandler(this.btnOrderEnd_Click);
            // 
            // tbMinPrice
            // 
            this.tbMinPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(125)))), ((int)(((byte)(51)))));
            this.tbMinPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMinPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.tbMinPrice.Location = new System.Drawing.Point(549, 766);
            this.tbMinPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMinPrice.Name = "tbMinPrice";
            this.tbMinPrice.ReadOnly = true;
            this.tbMinPrice.Size = new System.Drawing.Size(180, 34);
            this.tbMinPrice.TabIndex = 28;
            // 
            // tbMaxPrice
            // 
            this.tbMaxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(125)))), ((int)(((byte)(51)))));
            this.tbMaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMaxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.tbMaxPrice.Location = new System.Drawing.Point(995, 766);
            this.tbMaxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaxPrice.Name = "tbMaxPrice";
            this.tbMaxPrice.ReadOnly = true;
            this.tbMaxPrice.Size = new System.Drawing.Size(191, 34);
            this.tbMaxPrice.TabIndex = 29;
            // 
            // tbCost
            // 
            this.tbCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.tbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCost.Location = new System.Drawing.Point(779, 762);
            this.tbCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(168, 37);
            this.tbCost.TabIndex = 30;
            // 
            // tbClientPhoneNum
            // 
            this.tbClientPhoneNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.tbClientPhoneNum.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClientPhoneNum.Location = new System.Drawing.Point(151, 599);
            this.tbClientPhoneNum.Margin = new System.Windows.Forms.Padding(4);
            this.tbClientPhoneNum.Mask = "+38(999) 000-0000";
            this.tbClientPhoneNum.Name = "tbClientPhoneNum";
            this.tbClientPhoneNum.Size = new System.Drawing.Size(328, 31);
            this.tbClientPhoneNum.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.label9.Location = new System.Drawing.Point(559, 737);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 26);
            this.label9.TabIndex = 32;
            this.label9.Text = "Мінімальна ціна";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.label10.Location = new System.Drawing.Point(989, 737);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 26);
            this.label10.TabIndex = 33;
            this.label10.Text = "Максимальна ціна";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.label11.Location = new System.Drawing.Point(1608, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 31);
            this.label11.TabIndex = 34;
            this.label11.Text = "Фільтри";
            // 
            // cbFilterService
            // 
            this.cbFilterService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.cbFilterService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFilterService.FormattingEnabled = true;
            this.cbFilterService.Location = new System.Drawing.Point(1541, 132);
            this.cbFilterService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilterService.Name = "cbFilterService";
            this.cbFilterService.Size = new System.Drawing.Size(248, 26);
            this.cbFilterService.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.label12.Location = new System.Drawing.Point(1583, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 26);
            this.label12.TabIndex = 36;
            this.label12.Text = "Назва послуги";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.label13.Location = new System.Drawing.Point(1608, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 26);
            this.label13.TabIndex = 38;
            this.label13.Text = "Майстер";
            // 
            // cbFilterMaster
            // 
            this.cbFilterMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.cbFilterMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFilterMaster.FormattingEnabled = true;
            this.cbFilterMaster.Location = new System.Drawing.Point(1541, 191);
            this.cbFilterMaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilterMaster.Name = "cbFilterMaster";
            this.cbFilterMaster.Size = new System.Drawing.Size(248, 26);
            this.cbFilterMaster.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.label14.Location = new System.Drawing.Point(1608, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 26);
            this.label14.TabIndex = 40;
            this.label14.Text = "Статус";
            // 
            // cbFilterStatus
            // 
            this.cbFilterStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.cbFilterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFilterStatus.FormattingEnabled = true;
            this.cbFilterStatus.Location = new System.Drawing.Point(1541, 250);
            this.cbFilterStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilterStatus.Name = "cbFilterStatus";
            this.cbFilterStatus.Size = new System.Drawing.Size(248, 26);
            this.cbFilterStatus.TabIndex = 39;
            // 
            // btnFiltr
            // 
            this.btnFiltr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(101)))), ((int)(((byte)(44)))));
            this.btnFiltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFiltr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(245)))), ((int)(((byte)(210)))));
            this.btnFiltr.Location = new System.Drawing.Point(1532, 295);
            this.btnFiltr.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltr.Name = "btnFiltr";
            this.btnFiltr.Size = new System.Drawing.Size(141, 58);
            this.btnFiltr.TabIndex = 41;
            this.btnFiltr.Text = "Застосувати фільтри";
            this.btnFiltr.UseVisualStyleBackColor = false;
            this.btnFiltr.Click += new System.EventHandler(this.btnFiltr_Click);
            // 
            // btnCleanFiltr
            // 
            this.btnCleanFiltr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.btnCleanFiltr.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanFiltr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.btnCleanFiltr.Location = new System.Drawing.Point(1690, 303);
            this.btnCleanFiltr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCleanFiltr.Name = "btnCleanFiltr";
            this.btnCleanFiltr.Size = new System.Drawing.Size(103, 50);
            this.btnCleanFiltr.TabIndex = 42;
            this.btnCleanFiltr.Text = "Очистити фільтр";
            this.btnCleanFiltr.UseVisualStyleBackColor = false;
            this.btnCleanFiltr.Click += new System.EventHandler(this.btnCleanFiltr_Click);
            // 
            // btnOffFiltr
            // 
            this.btnOffFiltr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
            this.btnOffFiltr.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffFiltr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(81)))), ((int)(((byte)(30)))));
            this.btnOffFiltr.Location = new System.Drawing.Point(1541, 369);
            this.btnOffFiltr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOffFiltr.Name = "btnOffFiltr";
            this.btnOffFiltr.Size = new System.Drawing.Size(248, 34);
            this.btnOffFiltr.TabIndex = 43;
            this.btnOffFiltr.Text = "Прибрати фільтр";
            this.btnOffFiltr.UseVisualStyleBackColor = false;
            this.btnOffFiltr.Click += new System.EventHandler(this.btnOffFiltr_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(245)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1924, 846);
            this.Controls.Add(this.btnOffFiltr);
            this.Controls.Add(this.btnCleanFiltr);
            this.Controls.Add(this.btnFiltr);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbFilterStatus);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbFilterMaster);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbFilterService);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbClientPhoneNum);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbMaxPrice);
            this.Controls.Add(this.tbMinPrice);
            this.Controls.Add(this.btnOrderEnd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDateOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescribeOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnCleanOrder);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.cbMaster);
            this.Controls.Add(this.cbNameServise);
            this.Controls.Add(this.btnServiceOrder);
            this.Controls.Add(this.btnStuffOrder);
            this.Controls.Add(this.btnMaterialOrder);
            this.Controls.Add(this.btnOrderOrder);
            this.Controls.Add(this.dgvOrders);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Orders";
            this.Text = "Замовлення";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Orders_FormClosing);
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnOrderOrder;
        private System.Windows.Forms.Button btnMaterialOrder;
        private System.Windows.Forms.Button btnStuffOrder;
        private System.Windows.Forms.Button btnServiceOrder;
        private System.Windows.Forms.ComboBox cbNameServise;
        private System.Windows.Forms.ComboBox cbMaster;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnCleanOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.TextBox tbDescribeOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnOrderEnd;
        private System.Windows.Forms.TextBox tbMinPrice;
        private System.Windows.Forms.TextBox tbMaxPrice;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.MaskedTextBox tbClientPhoneNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbFilterService;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbFilterMaster;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbFilterStatus;
        private System.Windows.Forms.Button btnFiltr;
        private System.Windows.Forms.Button btnCleanFiltr;
        private System.Windows.Forms.Button btnOffFiltr;
    }
}

