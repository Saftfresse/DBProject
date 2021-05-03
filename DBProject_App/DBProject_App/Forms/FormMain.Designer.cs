namespace DBProject_App
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tc_main = new System.Windows.Forms.TabControl();
            this.tp_vehicles = new System.Windows.Forms.TabPage();
            this.panel_vehicles_form = new System.Windows.Forms.Panel();
            this.btn_vehicles_formSave = new System.Windows.Forms.Button();
            this.date_vehicles_tuv = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.num_vehicles_totalDist = new System.Windows.Forms.NumericUpDown();
            this.num_vehicles_usage = new System.Windows.Forms.NumericUpDown();
            this.tb_vehicles_brand = new System.Windows.Forms.TextBox();
            this.combo_vehicles_tireType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.combo_vehicles_garage = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_vehicles_numPlate_p3 = new System.Windows.Forms.MaskedTextBox();
            this.tb_vehicles_numPlate_p2 = new System.Windows.Forms.MaskedTextBox();
            this.tb_vehicles_numPlate_p1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_vehicles_t2 = new System.Windows.Forms.Label();
            this.btn_vehicles_formHide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.view_vehicles = new System.Windows.Forms.ListView();
            this.ch_vehicles_numPlate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_vehicles_building = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_vehicles_tireType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_vehicles_brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_vehicles_totalkm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_vehicles_tuv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_vehicles_gasUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_vehicles_inUse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.context_vehicles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.context_vehicles_editEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.context_vehicles_deleteEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_vehicles_layoutBottom = new System.Windows.Forms.Panel();
            this.cb_vehicles_filter_toggleTuv = new System.Windows.Forms.CheckBox();
            this.cb_vehicles_filter_toggleUsage = new System.Windows.Forms.CheckBox();
            this.cb_vehicles_filter_toggleTotal = new System.Windows.Forms.CheckBox();
            this.cb_vehicles_filter_toggleTire = new System.Windows.Forms.CheckBox();
            this.cb_vehicles_filter_toggleBuilding = new System.Windows.Forms.CheckBox();
            this.btn_vehicle_filter_reset = new System.Windows.Forms.Button();
            this.date_vehicles_filter_tuvUpper = new System.Windows.Forms.DateTimePicker();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.date_vehicles_filter_tuvLower = new System.Windows.Forms.DateTimePicker();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.num_vehicles_filter_usage = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.num_vehicles_filter_totalUpper = new System.Windows.Forms.NumericUpDown();
            this.num_vehicles_filter_totalLower = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.combo_vehicles_filter_tire = new System.Windows.Forms.ComboBox();
            this.combo_vehicles_filter_building = new System.Windows.Forms.ComboBox();
            this.btn_vehicle_reloadList = new System.Windows.Forms.Button();
            this.label_vehicles_t1 = new System.Windows.Forms.Label();
            this.btn_vehicles_filterExpand = new System.Windows.Forms.Button();
            this.tb_vehicles_filterText = new System.Windows.Forms.TextBox();
            this.btn_vehicles_addVehicle = new System.Windows.Forms.Button();
            this.tp_orders = new System.Windows.Forms.TabPage();
            this.panel_orders_form = new System.Windows.Forms.Panel();
            this.tb_orders_destStreet = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_orders_destPoint = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.tb_orders_startStreet = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.lbl_orders_numberText = new System.Windows.Forms.Label();
            this.lbl_orders_number = new System.Windows.Forms.Label();
            this.tb_orders_duration = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.num_orders_distance = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_orders_startPoint = new System.Windows.Forms.TextBox();
            this.combo_orders_driver = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.num_orders_amount = new System.Windows.Forms.NumericUpDown();
            this.num_orders_customerId = new System.Windows.Forms.NumericUpDown();
            this.btn_orders_formSave = new System.Windows.Forms.Button();
            this.date_orders_date = new System.Windows.Forms.DateTimePicker();
            this.tb_orders_customerData = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.combo_orders_vehicle = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_orders_formHide = new System.Windows.Forms.Button();
            this.view_orders = new System.Windows.Forms.ListView();
            this.ch_orders_orderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_orders_customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_orders_driver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_orders_vehicleNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_orders_startPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_orders_startAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_orders_destinationAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_orders_destinationPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_orders_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_orders_distance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_orders_duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_orders_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.context_orders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.context_orders_editOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.context_orders_deleteOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.context_orders_showCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_orders_layoutBottom = new System.Windows.Forms.Panel();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.tb_orders_filter_durationTo = new System.Windows.Forms.MaskedTextBox();
            this.tb_orders_filter_durationFrom = new System.Windows.Forms.MaskedTextBox();
            this.cb_orders_filter_duration = new System.Windows.Forms.CheckBox();
            this.label57 = new System.Windows.Forms.Label();
            this.cb_orders_filter_amount = new System.Windows.Forms.CheckBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.num_orders_filter_amountTo = new System.Windows.Forms.NumericUpDown();
            this.num_orders_filter_amountFrom = new System.Windows.Forms.NumericUpDown();
            this.cb_orders_filter_distance = new System.Windows.Forms.CheckBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.num_orders_filter_distanceTo = new System.Windows.Forms.NumericUpDown();
            this.num_orders_filter_distanceFrom = new System.Windows.Forms.NumericUpDown();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.cb_orders_filter_date = new System.Windows.Forms.CheckBox();
            this.date_orders_filter_to = new System.Windows.Forms.DateTimePicker();
            this.date_orders_filter_from = new System.Windows.Forms.DateTimePicker();
            this.cb_orders_filter_numPlate = new System.Windows.Forms.CheckBox();
            this.label48 = new System.Windows.Forms.Label();
            this.tb_orders_filter_numPlate = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.num_orders_filter_driver = new System.Windows.Forms.NumericUpDown();
            this.cb_orders_filter_driverId = new System.Windows.Forms.CheckBox();
            this.label41 = new System.Windows.Forms.Label();
            this.num_orders_filter_customer = new System.Windows.Forms.NumericUpDown();
            this.cb_orders_filter_customerId = new System.Windows.Forms.CheckBox();
            this.btn_orders_refreshList = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label_orders_t1 = new System.Windows.Forms.Label();
            this.btn_orders_filterExpand = new System.Windows.Forms.Button();
            this.tb_orders_filterText = new System.Windows.Forms.TextBox();
            this.btn_orders_addOrder = new System.Windows.Forms.Button();
            this.tp_customers = new System.Windows.Forms.TabPage();
            this.panel_customer_form = new System.Windows.Forms.Panel();
            this.lbl_customer_numberText = new System.Windows.Forms.Label();
            this.lbl_customer_numer = new System.Windows.Forms.Label();
            this.tb_customer_phone = new System.Windows.Forms.TextBox();
            this.tb_customer_surname = new System.Windows.Forms.TextBox();
            this.btn_customer_saveForm = new System.Windows.Forms.Button();
            this.tb_customer_lastname = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.btn_customer_hideForm = new System.Windows.Forms.Button();
            this.view_customers = new System.Windows.Forms.ListView();
            this.ch_customer_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_customer_surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_customer_lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_customer_phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.context_customers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.context_customer_editCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.context_customer_deleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.context_customer_viewCustomerOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_customer_layoutBottom = new System.Windows.Forms.Panel();
            this.cb_customer_filterId = new System.Windows.Forms.CheckBox();
            this.label60 = new System.Windows.Forms.Label();
            this.num_customer_filter_num = new System.Windows.Forms.NumericUpDown();
            this.btn_customer_reloadList = new System.Windows.Forms.Button();
            this.label_customer_t1 = new System.Windows.Forms.Label();
            this.tb_customer_filterText = new System.Windows.Forms.TextBox();
            this.btn_customers_addCustomer = new System.Windows.Forms.Button();
            this.tp_reports = new System.Windows.Forms.TabPage();
            this.btn_reports_openWeekly = new System.Windows.Forms.Button();
            this.btn_reports_openDayly = new System.Windows.Forms.Button();
            this.btn_reports_openVehicles = new System.Windows.Forms.Button();
            this.btn_reports_openCustomerData = new System.Windows.Forms.Button();
            this.btn_reports_openCustomerInvoices = new System.Windows.Forms.Button();
            this.btn_reports_openOrders = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStip_btn_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_close = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_navigation_reports = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_navigation_customers = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_navigation_orders = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_navigation_vehicles = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label61 = new System.Windows.Forms.Label();
            this.tc_main.SuspendLayout();
            this.tp_vehicles.SuspendLayout();
            this.panel_vehicles_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_vehicles_totalDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_vehicles_usage)).BeginInit();
            this.context_vehicles.SuspendLayout();
            this.panel_vehicles_layoutBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_vehicles_filter_usage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_vehicles_filter_totalUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_vehicles_filter_totalLower)).BeginInit();
            this.tp_orders.SuspendLayout();
            this.panel_orders_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_customerId)).BeginInit();
            this.context_orders.SuspendLayout();
            this.panel_orders_layoutBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_filter_amountTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_filter_amountFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_filter_distanceTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_filter_distanceFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_filter_driver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_filter_customer)).BeginInit();
            this.tp_customers.SuspendLayout();
            this.panel_customer_form.SuspendLayout();
            this.context_customers.SuspendLayout();
            this.panel_customer_layoutBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_customer_filter_num)).BeginInit();
            this.tp_reports.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_main
            // 
            this.tc_main.Controls.Add(this.tp_vehicles);
            this.tc_main.Controls.Add(this.tp_orders);
            this.tc_main.Controls.Add(this.tp_customers);
            this.tc_main.Controls.Add(this.tp_reports);
            this.tc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_main.ItemSize = new System.Drawing.Size(20, 20);
            this.tc_main.Location = new System.Drawing.Point(0, 0);
            this.tc_main.Multiline = true;
            this.tc_main.Name = "tc_main";
            this.tc_main.SelectedIndex = 0;
            this.tc_main.Size = new System.Drawing.Size(866, 691);
            this.tc_main.TabIndex = 0;
            this.tc_main.SelectedIndexChanged += new System.EventHandler(this.tc_main_SelectedIndexChanged);
            // 
            // tp_vehicles
            // 
            this.tp_vehicles.Controls.Add(this.panel_vehicles_form);
            this.tp_vehicles.Controls.Add(this.view_vehicles);
            this.tp_vehicles.Controls.Add(this.panel_vehicles_layoutBottom);
            this.tp_vehicles.Location = new System.Drawing.Point(4, 24);
            this.tp_vehicles.Name = "tp_vehicles";
            this.tp_vehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tp_vehicles.Size = new System.Drawing.Size(858, 663);
            this.tp_vehicles.TabIndex = 0;
            this.tp_vehicles.Text = "Fuhrpark";
            this.tp_vehicles.UseVisualStyleBackColor = true;
            // 
            // panel_vehicles_form
            // 
            this.panel_vehicles_form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_vehicles_form.Controls.Add(this.btn_vehicles_formSave);
            this.panel_vehicles_form.Controls.Add(this.date_vehicles_tuv);
            this.panel_vehicles_form.Controls.Add(this.label12);
            this.panel_vehicles_form.Controls.Add(this.label11);
            this.panel_vehicles_form.Controls.Add(this.num_vehicles_totalDist);
            this.panel_vehicles_form.Controls.Add(this.num_vehicles_usage);
            this.panel_vehicles_form.Controls.Add(this.tb_vehicles_brand);
            this.panel_vehicles_form.Controls.Add(this.combo_vehicles_tireType);
            this.panel_vehicles_form.Controls.Add(this.label10);
            this.panel_vehicles_form.Controls.Add(this.label9);
            this.panel_vehicles_form.Controls.Add(this.combo_vehicles_garage);
            this.panel_vehicles_form.Controls.Add(this.label8);
            this.panel_vehicles_form.Controls.Add(this.label7);
            this.panel_vehicles_form.Controls.Add(this.label6);
            this.panel_vehicles_form.Controls.Add(this.label5);
            this.panel_vehicles_form.Controls.Add(this.label4);
            this.panel_vehicles_form.Controls.Add(this.tb_vehicles_numPlate_p3);
            this.panel_vehicles_form.Controls.Add(this.tb_vehicles_numPlate_p2);
            this.panel_vehicles_form.Controls.Add(this.tb_vehicles_numPlate_p1);
            this.panel_vehicles_form.Controls.Add(this.label2);
            this.panel_vehicles_form.Controls.Add(this.label_vehicles_t2);
            this.panel_vehicles_form.Controls.Add(this.btn_vehicles_formHide);
            this.panel_vehicles_form.Controls.Add(this.label1);
            this.panel_vehicles_form.Controls.Add(this.label3);
            this.panel_vehicles_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_vehicles_form.Location = new System.Drawing.Point(3, 3);
            this.panel_vehicles_form.Name = "panel_vehicles_form";
            this.panel_vehicles_form.Size = new System.Drawing.Size(852, 614);
            this.panel_vehicles_form.TabIndex = 2;
            this.panel_vehicles_form.Visible = false;
            // 
            // btn_vehicles_formSave
            // 
            this.btn_vehicles_formSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_vehicles_formSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_vehicles_formSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vehicles_formSave.Location = new System.Drawing.Point(8, 257);
            this.btn_vehicles_formSave.Name = "btn_vehicles_formSave";
            this.btn_vehicles_formSave.Size = new System.Drawing.Size(115, 23);
            this.btn_vehicles_formSave.TabIndex = 23;
            this.btn_vehicles_formSave.Text = "Speichern";
            this.btn_vehicles_formSave.UseVisualStyleBackColor = true;
            this.btn_vehicles_formSave.Click += new System.EventHandler(this.btn_vehicles_formSave_Click);
            // 
            // date_vehicles_tuv
            // 
            this.date_vehicles_tuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_vehicles_tuv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_vehicles_tuv.Location = new System.Drawing.Point(138, 128);
            this.date_vehicles_tuv.Name = "date_vehicles_tuv";
            this.date_vehicles_tuv.Size = new System.Drawing.Size(138, 22);
            this.date_vehicles_tuv.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(203, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "l/100 km";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(231, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "km";
            // 
            // num_vehicles_totalDist
            // 
            this.num_vehicles_totalDist.DecimalPlaces = 2;
            this.num_vehicles_totalDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_vehicles_totalDist.Location = new System.Drawing.Point(138, 98);
            this.num_vehicles_totalDist.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.num_vehicles_totalDist.Name = "num_vehicles_totalDist";
            this.num_vehicles_totalDist.Size = new System.Drawing.Size(90, 22);
            this.num_vehicles_totalDist.TabIndex = 19;
            this.num_vehicles_totalDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_vehicles_totalDist.ThousandsSeparator = true;
            this.num_vehicles_totalDist.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.num_vehicles_totalDist.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // num_vehicles_usage
            // 
            this.num_vehicles_usage.DecimalPlaces = 2;
            this.num_vehicles_usage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_vehicles_usage.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.num_vehicles_usage.Location = new System.Drawing.Point(138, 158);
            this.num_vehicles_usage.Name = "num_vehicles_usage";
            this.num_vehicles_usage.Size = new System.Drawing.Size(63, 22);
            this.num_vehicles_usage.TabIndex = 18;
            this.num_vehicles_usage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_vehicles_usage.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.num_vehicles_usage.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // tb_vehicles_brand
            // 
            this.tb_vehicles_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vehicles_brand.Location = new System.Drawing.Point(138, 67);
            this.tb_vehicles_brand.Name = "tb_vehicles_brand";
            this.tb_vehicles_brand.Size = new System.Drawing.Size(243, 22);
            this.tb_vehicles_brand.TabIndex = 17;
            // 
            // combo_vehicles_tireType
            // 
            this.combo_vehicles_tireType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_vehicles_tireType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_vehicles_tireType.FormattingEnabled = true;
            this.combo_vehicles_tireType.Location = new System.Drawing.Point(138, 217);
            this.combo_vehicles_tireType.Name = "combo_vehicles_tireType";
            this.combo_vehicles_tireType.Size = new System.Drawing.Size(243, 24);
            this.combo_vehicles_tireType.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Reifentyp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Garage";
            // 
            // combo_vehicles_garage
            // 
            this.combo_vehicles_garage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_vehicles_garage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_vehicles_garage.FormattingEnabled = true;
            this.combo_vehicles_garage.Location = new System.Drawing.Point(138, 187);
            this.combo_vehicles_garage.Name = "combo_vehicles_garage";
            this.combo_vehicles_garage.Size = new System.Drawing.Size(243, 24);
            this.combo_vehicles_garage.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ø Verbrauch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "TÜV bis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kilometerstand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Marke";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kennzeichen";
            // 
            // tb_vehicles_numPlate_p3
            // 
            this.tb_vehicles_numPlate_p3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vehicles_numPlate_p3.Location = new System.Drawing.Point(218, 37);
            this.tb_vehicles_numPlate_p3.Mask = "####";
            this.tb_vehicles_numPlate_p3.Name = "tb_vehicles_numPlate_p3";
            this.tb_vehicles_numPlate_p3.Size = new System.Drawing.Size(40, 22);
            this.tb_vehicles_numPlate_p3.TabIndex = 5;
            // 
            // tb_vehicles_numPlate_p2
            // 
            this.tb_vehicles_numPlate_p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vehicles_numPlate_p2.Location = new System.Drawing.Point(182, 37);
            this.tb_vehicles_numPlate_p2.Mask = "LL";
            this.tb_vehicles_numPlate_p2.Name = "tb_vehicles_numPlate_p2";
            this.tb_vehicles_numPlate_p2.Size = new System.Drawing.Size(28, 22);
            this.tb_vehicles_numPlate_p2.TabIndex = 4;
            // 
            // tb_vehicles_numPlate_p1
            // 
            this.tb_vehicles_numPlate_p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vehicles_numPlate_p1.Location = new System.Drawing.Point(138, 37);
            this.tb_vehicles_numPlate_p1.Mask = "LLL";
            this.tb_vehicles_numPlate_p1.Name = "tb_vehicles_numPlate_p1";
            this.tb_vehicles_numPlate_p1.Size = new System.Drawing.Size(36, 22);
            this.tb_vehicles_numPlate_p1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 1);
            this.label2.TabIndex = 2;
            this.label2.Text = "HR";
            // 
            // label_vehicles_t2
            // 
            this.label_vehicles_t2.AutoSize = true;
            this.label_vehicles_t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vehicles_t2.Location = new System.Drawing.Point(5, 5);
            this.label_vehicles_t2.Name = "label_vehicles_t2";
            this.label_vehicles_t2.Size = new System.Drawing.Size(118, 20);
            this.label_vehicles_t2.TabIndex = 1;
            this.label_vehicles_t2.Text = "Fahrzeugdaten";
            // 
            // btn_vehicles_formHide
            // 
            this.btn_vehicles_formHide.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_vehicles_formHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_vehicles_formHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vehicles_formHide.Location = new System.Drawing.Point(160, 257);
            this.btn_vehicles_formHide.Name = "btn_vehicles_formHide";
            this.btn_vehicles_formHide.Size = new System.Drawing.Size(115, 23);
            this.btn_vehicles_formHide.TabIndex = 0;
            this.btn_vehicles_formHide.Text = "Abbrechen";
            this.btn_vehicles_formHide.UseVisualStyleBackColor = true;
            this.btn_vehicles_formHide.Click += new System.EventHandler(this.btn_vehicles_formHide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "-";
            // 
            // view_vehicles
            // 
            this.view_vehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_vehicles_numPlate,
            this.ch_vehicles_building,
            this.ch_vehicles_tireType,
            this.ch_vehicles_brand,
            this.ch_vehicles_totalkm,
            this.ch_vehicles_tuv,
            this.ch_vehicles_gasUsage,
            this.ch_vehicles_inUse});
            this.view_vehicles.ContextMenuStrip = this.context_vehicles;
            this.view_vehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_vehicles.FullRowSelect = true;
            this.view_vehicles.GridLines = true;
            this.view_vehicles.Location = new System.Drawing.Point(3, 3);
            this.view_vehicles.MultiSelect = false;
            this.view_vehicles.Name = "view_vehicles";
            this.view_vehicles.Size = new System.Drawing.Size(852, 614);
            this.view_vehicles.TabIndex = 0;
            this.view_vehicles.UseCompatibleStateImageBehavior = false;
            this.view_vehicles.View = System.Windows.Forms.View.Details;
            this.view_vehicles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.view_vehicles_MouseDoubleClick);
            // 
            // ch_vehicles_numPlate
            // 
            this.ch_vehicles_numPlate.Text = "Kennzeichen";
            this.ch_vehicles_numPlate.Width = 90;
            // 
            // ch_vehicles_building
            // 
            this.ch_vehicles_building.Text = "Gebäude";
            this.ch_vehicles_building.Width = 150;
            // 
            // ch_vehicles_tireType
            // 
            this.ch_vehicles_tireType.Text = "Reifentyp";
            this.ch_vehicles_tireType.Width = 110;
            // 
            // ch_vehicles_brand
            // 
            this.ch_vehicles_brand.Text = "Marke";
            this.ch_vehicles_brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_vehicles_brand.Width = 120;
            // 
            // ch_vehicles_totalkm
            // 
            this.ch_vehicles_totalkm.Text = "Kilometerstand";
            this.ch_vehicles_totalkm.Width = 110;
            // 
            // ch_vehicles_tuv
            // 
            this.ch_vehicles_tuv.Text = "TÜV-Fälligkeit";
            this.ch_vehicles_tuv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_vehicles_tuv.Width = 80;
            // 
            // ch_vehicles_gasUsage
            // 
            this.ch_vehicles_gasUsage.Text = "Verbrauch";
            this.ch_vehicles_gasUsage.Width = 70;
            // 
            // ch_vehicles_inUse
            // 
            this.ch_vehicles_inUse.Text = "In Verwendung";
            this.ch_vehicles_inUse.Width = 90;
            // 
            // context_vehicles
            // 
            this.context_vehicles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.context_vehicles_editEntry,
            this.context_vehicles_deleteEntry});
            this.context_vehicles.Name = "context_vehicles";
            this.context_vehicles.Size = new System.Drawing.Size(182, 48);
            // 
            // context_vehicles_editEntry
            // 
            this.context_vehicles_editEntry.Name = "context_vehicles_editEntry";
            this.context_vehicles_editEntry.Size = new System.Drawing.Size(181, 22);
            this.context_vehicles_editEntry.Text = "Fahrzeug bearbeiten";
            this.context_vehicles_editEntry.Click += new System.EventHandler(this.context_vehicles_editEntry_Click);
            // 
            // context_vehicles_deleteEntry
            // 
            this.context_vehicles_deleteEntry.Name = "context_vehicles_deleteEntry";
            this.context_vehicles_deleteEntry.Size = new System.Drawing.Size(181, 22);
            this.context_vehicles_deleteEntry.Text = "Fahrzeug entfernen";
            this.context_vehicles_deleteEntry.Click += new System.EventHandler(this.context_vehicles_deleteEntry_Click);
            // 
            // panel_vehicles_layoutBottom
            // 
            this.panel_vehicles_layoutBottom.Controls.Add(this.cb_vehicles_filter_toggleTuv);
            this.panel_vehicles_layoutBottom.Controls.Add(this.cb_vehicles_filter_toggleUsage);
            this.panel_vehicles_layoutBottom.Controls.Add(this.cb_vehicles_filter_toggleTotal);
            this.panel_vehicles_layoutBottom.Controls.Add(this.cb_vehicles_filter_toggleTire);
            this.panel_vehicles_layoutBottom.Controls.Add(this.cb_vehicles_filter_toggleBuilding);
            this.panel_vehicles_layoutBottom.Controls.Add(this.btn_vehicle_filter_reset);
            this.panel_vehicles_layoutBottom.Controls.Add(this.date_vehicles_filter_tuvUpper);
            this.panel_vehicles_layoutBottom.Controls.Add(this.label36);
            this.panel_vehicles_layoutBottom.Controls.Add(this.label35);
            this.panel_vehicles_layoutBottom.Controls.Add(this.date_vehicles_filter_tuvLower);
            this.panel_vehicles_layoutBottom.Controls.Add(this.label34);
            this.panel_vehicles_layoutBottom.Controls.Add(this.label33);
            this.panel_vehicles_layoutBottom.Controls.Add(this.num_vehicles_filter_usage);
            this.panel_vehicles_layoutBottom.Controls.Add(this.label32);
            this.panel_vehicles_layoutBottom.Controls.Add(this.label31);
            this.panel_vehicles_layoutBottom.Controls.Add(this.label30);
            this.panel_vehicles_layoutBottom.Controls.Add(this.label29);
            this.panel_vehicles_layoutBottom.Controls.Add(this.num_vehicles_filter_totalUpper);
            this.panel_vehicles_layoutBottom.Controls.Add(this.num_vehicles_filter_totalLower);
            this.panel_vehicles_layoutBottom.Controls.Add(this.label28);
            this.panel_vehicles_layoutBottom.Controls.Add(this.label27);
            this.panel_vehicles_layoutBottom.Controls.Add(this.label26);
            this.panel_vehicles_layoutBottom.Controls.Add(this.combo_vehicles_filter_tire);
            this.panel_vehicles_layoutBottom.Controls.Add(this.combo_vehicles_filter_building);
            this.panel_vehicles_layoutBottom.Controls.Add(this.btn_vehicle_reloadList);
            this.panel_vehicles_layoutBottom.Controls.Add(this.label_vehicles_t1);
            this.panel_vehicles_layoutBottom.Controls.Add(this.btn_vehicles_filterExpand);
            this.panel_vehicles_layoutBottom.Controls.Add(this.tb_vehicles_filterText);
            this.panel_vehicles_layoutBottom.Controls.Add(this.btn_vehicles_addVehicle);
            this.panel_vehicles_layoutBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_vehicles_layoutBottom.Location = new System.Drawing.Point(3, 617);
            this.panel_vehicles_layoutBottom.Name = "panel_vehicles_layoutBottom";
            this.panel_vehicles_layoutBottom.Size = new System.Drawing.Size(852, 43);
            this.panel_vehicles_layoutBottom.TabIndex = 1;
            // 
            // cb_vehicles_filter_toggleTuv
            // 
            this.cb_vehicles_filter_toggleTuv.AutoSize = true;
            this.cb_vehicles_filter_toggleTuv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_vehicles_filter_toggleTuv.Location = new System.Drawing.Point(374, 106);
            this.cb_vehicles_filter_toggleTuv.Name = "cb_vehicles_filter_toggleTuv";
            this.cb_vehicles_filter_toggleTuv.Size = new System.Drawing.Size(15, 14);
            this.cb_vehicles_filter_toggleTuv.TabIndex = 29;
            this.cb_vehicles_filter_toggleTuv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_vehicles_filter_toggleTuv.UseVisualStyleBackColor = true;
            // 
            // cb_vehicles_filter_toggleUsage
            // 
            this.cb_vehicles_filter_toggleUsage.AutoSize = true;
            this.cb_vehicles_filter_toggleUsage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_vehicles_filter_toggleUsage.Location = new System.Drawing.Point(374, 79);
            this.cb_vehicles_filter_toggleUsage.Name = "cb_vehicles_filter_toggleUsage";
            this.cb_vehicles_filter_toggleUsage.Size = new System.Drawing.Size(15, 14);
            this.cb_vehicles_filter_toggleUsage.TabIndex = 28;
            this.cb_vehicles_filter_toggleUsage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_vehicles_filter_toggleUsage.UseVisualStyleBackColor = true;
            // 
            // cb_vehicles_filter_toggleTotal
            // 
            this.cb_vehicles_filter_toggleTotal.AutoSize = true;
            this.cb_vehicles_filter_toggleTotal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_vehicles_filter_toggleTotal.Location = new System.Drawing.Point(374, 51);
            this.cb_vehicles_filter_toggleTotal.Name = "cb_vehicles_filter_toggleTotal";
            this.cb_vehicles_filter_toggleTotal.Size = new System.Drawing.Size(15, 14);
            this.cb_vehicles_filter_toggleTotal.TabIndex = 27;
            this.cb_vehicles_filter_toggleTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_vehicles_filter_toggleTotal.UseVisualStyleBackColor = true;
            // 
            // cb_vehicles_filter_toggleTire
            // 
            this.cb_vehicles_filter_toggleTire.AutoSize = true;
            this.cb_vehicles_filter_toggleTire.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_vehicles_filter_toggleTire.Location = new System.Drawing.Point(346, 79);
            this.cb_vehicles_filter_toggleTire.Name = "cb_vehicles_filter_toggleTire";
            this.cb_vehicles_filter_toggleTire.Size = new System.Drawing.Size(15, 14);
            this.cb_vehicles_filter_toggleTire.TabIndex = 26;
            this.cb_vehicles_filter_toggleTire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_vehicles_filter_toggleTire.UseVisualStyleBackColor = true;
            // 
            // cb_vehicles_filter_toggleBuilding
            // 
            this.cb_vehicles_filter_toggleBuilding.AutoSize = true;
            this.cb_vehicles_filter_toggleBuilding.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_vehicles_filter_toggleBuilding.Location = new System.Drawing.Point(346, 51);
            this.cb_vehicles_filter_toggleBuilding.Name = "cb_vehicles_filter_toggleBuilding";
            this.cb_vehicles_filter_toggleBuilding.Size = new System.Drawing.Size(15, 14);
            this.cb_vehicles_filter_toggleBuilding.TabIndex = 25;
            this.cb_vehicles_filter_toggleBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_vehicles_filter_toggleBuilding.UseVisualStyleBackColor = true;
            // 
            // btn_vehicle_filter_reset
            // 
            this.btn_vehicle_filter_reset.BackColor = System.Drawing.Color.LightGray;
            this.btn_vehicle_filter_reset.FlatAppearance.BorderSize = 0;
            this.btn_vehicle_filter_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vehicle_filter_reset.Location = new System.Drawing.Point(7, 103);
            this.btn_vehicle_filter_reset.Name = "btn_vehicle_filter_reset";
            this.btn_vehicle_filter_reset.Size = new System.Drawing.Size(333, 23);
            this.btn_vehicle_filter_reset.TabIndex = 23;
            this.btn_vehicle_filter_reset.Text = "Alle Filter zurücksetzen";
            this.btn_vehicle_filter_reset.UseVisualStyleBackColor = false;
            // 
            // date_vehicles_filter_tuvUpper
            // 
            this.date_vehicles_filter_tuvUpper.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_vehicles_filter_tuvUpper.Location = new System.Drawing.Point(618, 102);
            this.date_vehicles_filter_tuvUpper.Name = "date_vehicles_filter_tuvUpper";
            this.date_vehicles_filter_tuvUpper.Size = new System.Drawing.Size(97, 20);
            this.date_vehicles_filter_tuvUpper.TabIndex = 22;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(598, 106);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(20, 13);
            this.label36.TabIndex = 21;
            this.label36.Text = "bis";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(390, 105);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(98, 16);
            this.label35.TabIndex = 20;
            this.label35.Text = "TÜV - Zeitraum";
            // 
            // date_vehicles_filter_tuvLower
            // 
            this.date_vehicles_filter_tuvLower.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_vehicles_filter_tuvLower.Location = new System.Drawing.Point(499, 102);
            this.date_vehicles_filter_tuvLower.Name = "date_vehicles_filter_tuvLower";
            this.date_vehicles_filter_tuvLower.Size = new System.Drawing.Size(97, 20);
            this.date_vehicles_filter_tuvLower.TabIndex = 19;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(556, 79);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(52, 13);
            this.label34.TabIndex = 18;
            this.label34.Text = "l / 100km";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(390, 77);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(70, 16);
            this.label33.TabIndex = 17;
            this.label33.Text = "Verbrauch";
            // 
            // num_vehicles_filter_usage
            // 
            this.num_vehicles_filter_usage.DecimalPlaces = 2;
            this.num_vehicles_filter_usage.Location = new System.Drawing.Point(499, 75);
            this.num_vehicles_filter_usage.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_vehicles_filter_usage.Name = "num_vehicles_filter_usage";
            this.num_vehicles_filter_usage.Size = new System.Drawing.Size(57, 20);
            this.num_vehicles_filter_usage.TabIndex = 16;
            // 
            // label32
            // 
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label32.Location = new System.Drawing.Point(367, 43);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(1, 87);
            this.label32.TabIndex = 15;
            this.label32.Text = "label32";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(390, 49);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(97, 16);
            this.label31.TabIndex = 14;
            this.label31.Text = "Kilometerstand";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(688, 51);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(21, 13);
            this.label30.TabIndex = 13;
            this.label30.Text = "km";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(575, 51);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(37, 13);
            this.label29.TabIndex = 12;
            this.label29.Text = "km bis";
            // 
            // num_vehicles_filter_totalUpper
            // 
            this.num_vehicles_filter_totalUpper.DecimalPlaces = 2;
            this.num_vehicles_filter_totalUpper.Location = new System.Drawing.Point(612, 47);
            this.num_vehicles_filter_totalUpper.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.num_vehicles_filter_totalUpper.Name = "num_vehicles_filter_totalUpper";
            this.num_vehicles_filter_totalUpper.Size = new System.Drawing.Size(76, 20);
            this.num_vehicles_filter_totalUpper.TabIndex = 11;
            // 
            // num_vehicles_filter_totalLower
            // 
            this.num_vehicles_filter_totalLower.DecimalPlaces = 2;
            this.num_vehicles_filter_totalLower.Location = new System.Drawing.Point(499, 47);
            this.num_vehicles_filter_totalLower.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.num_vehicles_filter_totalLower.Name = "num_vehicles_filter_totalLower";
            this.num_vehicles_filter_totalLower.Size = new System.Drawing.Size(76, 20);
            this.num_vehicles_filter_totalLower.TabIndex = 10;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(7, 77);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(65, 16);
            this.label28.TabIndex = 9;
            this.label28.Text = "Reifentyp";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(7, 49);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 16);
            this.label27.TabIndex = 8;
            this.label27.Text = "Garage";
            // 
            // label26
            // 
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label26.Location = new System.Drawing.Point(5, 43);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(839, 1);
            this.label26.TabIndex = 7;
            this.label26.Text = "label26";
            // 
            // combo_vehicles_filter_tire
            // 
            this.combo_vehicles_filter_tire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_vehicles_filter_tire.FormattingEnabled = true;
            this.combo_vehicles_filter_tire.Location = new System.Drawing.Point(79, 74);
            this.combo_vehicles_filter_tire.Name = "combo_vehicles_filter_tire";
            this.combo_vehicles_filter_tire.Size = new System.Drawing.Size(261, 21);
            this.combo_vehicles_filter_tire.TabIndex = 6;
            // 
            // combo_vehicles_filter_building
            // 
            this.combo_vehicles_filter_building.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_vehicles_filter_building.FormattingEnabled = true;
            this.combo_vehicles_filter_building.Location = new System.Drawing.Point(79, 47);
            this.combo_vehicles_filter_building.Name = "combo_vehicles_filter_building";
            this.combo_vehicles_filter_building.Size = new System.Drawing.Size(261, 21);
            this.combo_vehicles_filter_building.TabIndex = 5;
            // 
            // btn_vehicle_reloadList
            // 
            this.btn_vehicle_reloadList.FlatAppearance.BorderSize = 0;
            this.btn_vehicle_reloadList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_vehicle_reloadList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vehicle_reloadList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vehicle_reloadList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_vehicle_reloadList.Location = new System.Drawing.Point(0, 6);
            this.btn_vehicle_reloadList.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_vehicle_reloadList.Name = "btn_vehicle_reloadList";
            this.btn_vehicle_reloadList.Size = new System.Drawing.Size(31, 31);
            this.btn_vehicle_reloadList.TabIndex = 4;
            this.btn_vehicle_reloadList.Text = "↻";
            this.btn_vehicle_reloadList.UseVisualStyleBackColor = true;
            this.btn_vehicle_reloadList.Click += new System.EventHandler(this.btn_vehicle_reloadList_Click);
            // 
            // label_vehicles_t1
            // 
            this.label_vehicles_t1.AutoSize = true;
            this.label_vehicles_t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vehicles_t1.Location = new System.Drawing.Point(389, 14);
            this.label_vehicles_t1.Name = "label_vehicles_t1";
            this.label_vehicles_t1.Size = new System.Drawing.Size(46, 16);
            this.label_vehicles_t1.TabIndex = 3;
            this.label_vehicles_t1.Text = "Suche";
            // 
            // btn_vehicles_filterExpand
            // 
            this.btn_vehicles_filterExpand.BackColor = System.Drawing.Color.LightGray;
            this.btn_vehicles_filterExpand.FlatAppearance.BorderSize = 0;
            this.btn_vehicles_filterExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vehicles_filterExpand.Location = new System.Drawing.Point(738, 10);
            this.btn_vehicles_filterExpand.Name = "btn_vehicles_filterExpand";
            this.btn_vehicles_filterExpand.Size = new System.Drawing.Size(106, 23);
            this.btn_vehicles_filterExpand.TabIndex = 2;
            this.btn_vehicles_filterExpand.Text = "Filter erweitern ▲";
            this.btn_vehicles_filterExpand.UseVisualStyleBackColor = false;
            this.btn_vehicles_filterExpand.Click += new System.EventHandler(this.btn_vehicles_filterExpand_Click);
            // 
            // tb_vehicles_filterText
            // 
            this.tb_vehicles_filterText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_vehicles_filterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vehicles_filterText.Location = new System.Drawing.Point(438, 11);
            this.tb_vehicles_filterText.Name = "tb_vehicles_filterText";
            this.tb_vehicles_filterText.Size = new System.Drawing.Size(294, 22);
            this.tb_vehicles_filterText.TabIndex = 1;
            this.tb_vehicles_filterText.TextChanged += new System.EventHandler(this.tb_vehicles_filterText_TextChanged);
            // 
            // btn_vehicles_addVehicle
            // 
            this.btn_vehicles_addVehicle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_vehicles_addVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vehicles_addVehicle.Location = new System.Drawing.Point(34, 7);
            this.btn_vehicles_addVehicle.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_vehicles_addVehicle.Name = "btn_vehicles_addVehicle";
            this.btn_vehicles_addVehicle.Size = new System.Drawing.Size(134, 31);
            this.btn_vehicles_addVehicle.TabIndex = 0;
            this.btn_vehicles_addVehicle.Text = "Fahrzeug hinzufügen";
            this.btn_vehicles_addVehicle.UseVisualStyleBackColor = true;
            this.btn_vehicles_addVehicle.Click += new System.EventHandler(this.btn_vehicles_addVehicle_Click);
            // 
            // tp_orders
            // 
            this.tp_orders.Controls.Add(this.panel_orders_form);
            this.tp_orders.Controls.Add(this.view_orders);
            this.tp_orders.Controls.Add(this.panel_orders_layoutBottom);
            this.tp_orders.Location = new System.Drawing.Point(4, 24);
            this.tp_orders.Name = "tp_orders";
            this.tp_orders.Padding = new System.Windows.Forms.Padding(3);
            this.tp_orders.Size = new System.Drawing.Size(858, 638);
            this.tp_orders.TabIndex = 1;
            this.tp_orders.Text = "Bestellungen";
            this.tp_orders.UseVisualStyleBackColor = true;
            // 
            // panel_orders_form
            // 
            this.panel_orders_form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_orders_form.Controls.Add(this.tb_orders_destStreet);
            this.panel_orders_form.Controls.Add(this.label16);
            this.panel_orders_form.Controls.Add(this.tb_orders_destPoint);
            this.panel_orders_form.Controls.Add(this.label40);
            this.panel_orders_form.Controls.Add(this.tb_orders_startStreet);
            this.panel_orders_form.Controls.Add(this.label39);
            this.panel_orders_form.Controls.Add(this.lbl_orders_numberText);
            this.panel_orders_form.Controls.Add(this.lbl_orders_number);
            this.panel_orders_form.Controls.Add(this.tb_orders_duration);
            this.panel_orders_form.Controls.Add(this.label14);
            this.panel_orders_form.Controls.Add(this.num_orders_distance);
            this.panel_orders_form.Controls.Add(this.label25);
            this.panel_orders_form.Controls.Add(this.label13);
            this.panel_orders_form.Controls.Add(this.tb_orders_startPoint);
            this.panel_orders_form.Controls.Add(this.combo_orders_driver);
            this.panel_orders_form.Controls.Add(this.label24);
            this.panel_orders_form.Controls.Add(this.num_orders_amount);
            this.panel_orders_form.Controls.Add(this.num_orders_customerId);
            this.panel_orders_form.Controls.Add(this.btn_orders_formSave);
            this.panel_orders_form.Controls.Add(this.date_orders_date);
            this.panel_orders_form.Controls.Add(this.tb_orders_customerData);
            this.panel_orders_form.Controls.Add(this.label15);
            this.panel_orders_form.Controls.Add(this.combo_orders_vehicle);
            this.panel_orders_form.Controls.Add(this.label17);
            this.panel_orders_form.Controls.Add(this.label18);
            this.panel_orders_form.Controls.Add(this.label19);
            this.panel_orders_form.Controls.Add(this.label20);
            this.panel_orders_form.Controls.Add(this.label21);
            this.panel_orders_form.Controls.Add(this.label22);
            this.panel_orders_form.Controls.Add(this.label23);
            this.panel_orders_form.Controls.Add(this.btn_orders_formHide);
            this.panel_orders_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_orders_form.Location = new System.Drawing.Point(3, 3);
            this.panel_orders_form.Name = "panel_orders_form";
            this.panel_orders_form.Size = new System.Drawing.Size(852, 589);
            this.panel_orders_form.TabIndex = 3;
            this.panel_orders_form.Visible = false;
            // 
            // tb_orders_destStreet
            // 
            this.tb_orders_destStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_orders_destStreet.Location = new System.Drawing.Point(138, 209);
            this.tb_orders_destStreet.Name = "tb_orders_destStreet";
            this.tb_orders_destStreet.Size = new System.Drawing.Size(403, 22);
            this.tb_orders_destStreet.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 212);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "Abholstraße";
            // 
            // tb_orders_destPoint
            // 
            this.tb_orders_destPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_orders_destPoint.Location = new System.Drawing.Point(138, 181);
            this.tb_orders_destPoint.Name = "tb_orders_destPoint";
            this.tb_orders_destPoint.Size = new System.Drawing.Size(403, 22);
            this.tb_orders_destPoint.TabIndex = 40;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(7, 184);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(58, 16);
            this.label40.TabIndex = 39;
            this.label40.Text = "Abholort";
            // 
            // tb_orders_startStreet
            // 
            this.tb_orders_startStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_orders_startStreet.Location = new System.Drawing.Point(138, 153);
            this.tb_orders_startStreet.Name = "tb_orders_startStreet";
            this.tb_orders_startStreet.Size = new System.Drawing.Size(403, 22);
            this.tb_orders_startStreet.TabIndex = 38;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(7, 156);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(81, 16);
            this.label39.TabIndex = 37;
            this.label39.Text = "Abholstraße";
            // 
            // lbl_orders_numberText
            // 
            this.lbl_orders_numberText.AutoSize = true;
            this.lbl_orders_numberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orders_numberText.Location = new System.Drawing.Point(393, 7);
            this.lbl_orders_numberText.Name = "lbl_orders_numberText";
            this.lbl_orders_numberText.Size = new System.Drawing.Size(97, 16);
            this.lbl_orders_numberText.TabIndex = 36;
            this.lbl_orders_numberText.Text = "Bestellnummer";
            this.lbl_orders_numberText.Visible = false;
            // 
            // lbl_orders_number
            // 
            this.lbl_orders_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_orders_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orders_number.Location = new System.Drawing.Point(496, 2);
            this.lbl_orders_number.Name = "lbl_orders_number";
            this.lbl_orders_number.Size = new System.Drawing.Size(44, 26);
            this.lbl_orders_number.TabIndex = 35;
            this.lbl_orders_number.Text = "0";
            this.lbl_orders_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_orders_number.Visible = false;
            // 
            // tb_orders_duration
            // 
            this.tb_orders_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_orders_duration.Location = new System.Drawing.Point(138, 298);
            this.tb_orders_duration.Mask = "###:90:00";
            this.tb_orders_duration.Name = "tb_orders_duration";
            this.tb_orders_duration.PromptChar = '#';
            this.tb_orders_duration.Size = new System.Drawing.Size(90, 22);
            this.tb_orders_duration.TabIndex = 34;
            this.tb_orders_duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_orders_duration.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(230, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 16);
            this.label14.TabIndex = 33;
            this.label14.Text = "km";
            // 
            // num_orders_distance
            // 
            this.num_orders_distance.DecimalPlaces = 2;
            this.num_orders_distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_orders_distance.Location = new System.Drawing.Point(138, 268);
            this.num_orders_distance.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.num_orders_distance.Name = "num_orders_distance";
            this.num_orders_distance.Size = new System.Drawing.Size(90, 22);
            this.num_orders_distance.TabIndex = 32;
            this.num_orders_distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_orders_distance.ThousandsSeparator = true;
            this.num_orders_distance.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(7, 302);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 16);
            this.label25.TabIndex = 31;
            this.label25.Text = "Fahrtdauer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Entfernung";
            // 
            // tb_orders_startPoint
            // 
            this.tb_orders_startPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_orders_startPoint.Location = new System.Drawing.Point(138, 125);
            this.tb_orders_startPoint.Name = "tb_orders_startPoint";
            this.tb_orders_startPoint.Size = new System.Drawing.Size(403, 22);
            this.tb_orders_startPoint.TabIndex = 28;
            // 
            // combo_orders_driver
            // 
            this.combo_orders_driver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_orders_driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_orders_driver.FormattingEnabled = true;
            this.combo_orders_driver.Location = new System.Drawing.Point(138, 65);
            this.combo_orders_driver.Name = "combo_orders_driver";
            this.combo_orders_driver.Size = new System.Drawing.Size(402, 24);
            this.combo_orders_driver.TabIndex = 27;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(231, 329);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 16);
            this.label24.TabIndex = 26;
            this.label24.Text = "€";
            // 
            // num_orders_amount
            // 
            this.num_orders_amount.DecimalPlaces = 2;
            this.num_orders_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_orders_amount.Location = new System.Drawing.Point(138, 326);
            this.num_orders_amount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_orders_amount.Name = "num_orders_amount";
            this.num_orders_amount.Size = new System.Drawing.Size(90, 22);
            this.num_orders_amount.TabIndex = 25;
            this.num_orders_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_orders_amount.ThousandsSeparator = true;
            this.num_orders_amount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // num_orders_customerId
            // 
            this.num_orders_customerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_orders_customerId.Location = new System.Drawing.Point(138, 37);
            this.num_orders_customerId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.num_orders_customerId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_orders_customerId.Name = "num_orders_customerId";
            this.num_orders_customerId.Size = new System.Drawing.Size(80, 22);
            this.num_orders_customerId.TabIndex = 24;
            this.num_orders_customerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_orders_customerId.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.num_orders_customerId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_orders_formSave
            // 
            this.btn_orders_formSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_orders_formSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_orders_formSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders_formSave.Location = new System.Drawing.Point(6, 364);
            this.btn_orders_formSave.Name = "btn_orders_formSave";
            this.btn_orders_formSave.Size = new System.Drawing.Size(115, 23);
            this.btn_orders_formSave.TabIndex = 23;
            this.btn_orders_formSave.Text = "Speichern";
            this.btn_orders_formSave.UseVisualStyleBackColor = true;
            this.btn_orders_formSave.Click += new System.EventHandler(this.btn_orders_formSave_Click);
            // 
            // date_orders_date
            // 
            this.date_orders_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_orders_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_orders_date.Location = new System.Drawing.Point(138, 237);
            this.date_orders_date.Name = "date_orders_date";
            this.date_orders_date.Size = new System.Drawing.Size(138, 22);
            this.date_orders_date.TabIndex = 22;
            // 
            // tb_orders_customerData
            // 
            this.tb_orders_customerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_orders_customerData.Location = new System.Drawing.Point(224, 37);
            this.tb_orders_customerData.Name = "tb_orders_customerData";
            this.tb_orders_customerData.ReadOnly = true;
            this.tb_orders_customerData.Size = new System.Drawing.Size(316, 22);
            this.tb_orders_customerData.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Datum";
            // 
            // combo_orders_vehicle
            // 
            this.combo_orders_vehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_orders_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_orders_vehicle.FormattingEnabled = true;
            this.combo_orders_vehicle.Location = new System.Drawing.Point(138, 95);
            this.combo_orders_vehicle.Name = "combo_orders_vehicle";
            this.combo_orders_vehicle.Size = new System.Drawing.Size(402, 24);
            this.combo_orders_vehicle.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 16);
            this.label17.TabIndex = 12;
            this.label17.Text = "Abholort";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 11;
            this.label18.Text = "Fahrzeug";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 16);
            this.label19.TabIndex = 10;
            this.label19.Text = "Fahrer";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 328);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 16);
            this.label20.TabIndex = 9;
            this.label20.Text = "Betrag";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 16);
            this.label21.TabIndex = 8;
            this.label21.Text = "Kunde";
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Location = new System.Drawing.Point(6, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(205, 1);
            this.label22.TabIndex = 2;
            this.label22.Text = "HR";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(5, 5);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(138, 20);
            this.label23.TabIndex = 1;
            this.label23.Text = "Bestellungsdetails";
            // 
            // btn_orders_formHide
            // 
            this.btn_orders_formHide.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_orders_formHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_orders_formHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders_formHide.Location = new System.Drawing.Point(158, 364);
            this.btn_orders_formHide.Name = "btn_orders_formHide";
            this.btn_orders_formHide.Size = new System.Drawing.Size(115, 23);
            this.btn_orders_formHide.TabIndex = 0;
            this.btn_orders_formHide.Text = "Abbrechen";
            this.btn_orders_formHide.UseVisualStyleBackColor = true;
            this.btn_orders_formHide.Click += new System.EventHandler(this.btn_orders_formHide_Click);
            // 
            // view_orders
            // 
            this.view_orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_orders_orderId,
            this.ch_orders_customer,
            this.ch_orders_driver,
            this.ch_orders_vehicleNum,
            this.ch_orders_startPoint,
            this.ch_orders_startAdress,
            this.ch_orders_destinationAdress,
            this.ch_orders_destinationPoint,
            this.ch_orders_date,
            this.ch_orders_distance,
            this.ch_orders_duration,
            this.ch_orders_price});
            this.view_orders.ContextMenuStrip = this.context_orders;
            this.view_orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_orders.FullRowSelect = true;
            this.view_orders.GridLines = true;
            this.view_orders.Location = new System.Drawing.Point(3, 3);
            this.view_orders.Name = "view_orders";
            this.view_orders.Size = new System.Drawing.Size(852, 589);
            this.view_orders.TabIndex = 1;
            this.view_orders.UseCompatibleStateImageBehavior = false;
            this.view_orders.View = System.Windows.Forms.View.Details;
            this.view_orders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.view_orders_MouseDoubleClick);
            // 
            // ch_orders_orderId
            // 
            this.ch_orders_orderId.Text = "Bestell #";
            this.ch_orders_orderId.Width = 55;
            // 
            // ch_orders_customer
            // 
            this.ch_orders_customer.Text = "Kunde";
            this.ch_orders_customer.Width = 43;
            // 
            // ch_orders_driver
            // 
            this.ch_orders_driver.Text = "Fahrer";
            this.ch_orders_driver.Width = 90;
            // 
            // ch_orders_vehicleNum
            // 
            this.ch_orders_vehicleNum.Text = "Fahrzeug";
            this.ch_orders_vehicleNum.Width = 80;
            // 
            // ch_orders_startPoint
            // 
            this.ch_orders_startPoint.Text = "Abholort";
            this.ch_orders_startPoint.Width = 100;
            // 
            // ch_orders_startAdress
            // 
            this.ch_orders_startAdress.Text = "Abholstraße";
            this.ch_orders_startAdress.Width = 100;
            // 
            // ch_orders_destinationAdress
            // 
            this.ch_orders_destinationAdress.Text = "Zielstraße";
            this.ch_orders_destinationAdress.Width = 100;
            // 
            // ch_orders_destinationPoint
            // 
            this.ch_orders_destinationPoint.Text = "Zielort";
            this.ch_orders_destinationPoint.Width = 100;
            // 
            // ch_orders_date
            // 
            this.ch_orders_date.Text = "Datum";
            this.ch_orders_date.Width = 70;
            // 
            // ch_orders_distance
            // 
            this.ch_orders_distance.Text = "Entfernung";
            this.ch_orders_distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ch_orders_distance.Width = 65;
            // 
            // ch_orders_duration
            // 
            this.ch_orders_duration.Text = "Dauer";
            // 
            // ch_orders_price
            // 
            this.ch_orders_price.Text = "Preis";
            this.ch_orders_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // context_orders
            // 
            this.context_orders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.context_orders_editOrder,
            this.context_orders_deleteOrder,
            this.context_orders_showCustomer});
            this.context_orders.Name = "context_vehicles";
            this.context_orders.Size = new System.Drawing.Size(189, 70);
            // 
            // context_orders_editOrder
            // 
            this.context_orders_editOrder.Name = "context_orders_editOrder";
            this.context_orders_editOrder.Size = new System.Drawing.Size(188, 22);
            this.context_orders_editOrder.Text = "Bestellung bearbeiten";
            this.context_orders_editOrder.Click += new System.EventHandler(this.context_orders_editOrder_Click);
            // 
            // context_orders_deleteOrder
            // 
            this.context_orders_deleteOrder.Name = "context_orders_deleteOrder";
            this.context_orders_deleteOrder.Size = new System.Drawing.Size(188, 22);
            this.context_orders_deleteOrder.Text = "Bestellung entfernen";
            this.context_orders_deleteOrder.Click += new System.EventHandler(this.context_orders_deleteOrder_Click);
            // 
            // context_orders_showCustomer
            // 
            this.context_orders_showCustomer.Name = "context_orders_showCustomer";
            this.context_orders_showCustomer.Size = new System.Drawing.Size(188, 22);
            this.context_orders_showCustomer.Text = "Kunde aufrufen";
            this.context_orders_showCustomer.Click += new System.EventHandler(this.context_orders_showCustomer_Click);
            // 
            // panel_orders_layoutBottom
            // 
            this.panel_orders_layoutBottom.Controls.Add(this.label59);
            this.panel_orders_layoutBottom.Controls.Add(this.label58);
            this.panel_orders_layoutBottom.Controls.Add(this.tb_orders_filter_durationTo);
            this.panel_orders_layoutBottom.Controls.Add(this.tb_orders_filter_durationFrom);
            this.panel_orders_layoutBottom.Controls.Add(this.cb_orders_filter_duration);
            this.panel_orders_layoutBottom.Controls.Add(this.label57);
            this.panel_orders_layoutBottom.Controls.Add(this.cb_orders_filter_amount);
            this.panel_orders_layoutBottom.Controls.Add(this.label54);
            this.panel_orders_layoutBottom.Controls.Add(this.label55);
            this.panel_orders_layoutBottom.Controls.Add(this.label56);
            this.panel_orders_layoutBottom.Controls.Add(this.num_orders_filter_amountTo);
            this.panel_orders_layoutBottom.Controls.Add(this.num_orders_filter_amountFrom);
            this.panel_orders_layoutBottom.Controls.Add(this.cb_orders_filter_distance);
            this.panel_orders_layoutBottom.Controls.Add(this.label51);
            this.panel_orders_layoutBottom.Controls.Add(this.label52);
            this.panel_orders_layoutBottom.Controls.Add(this.label53);
            this.panel_orders_layoutBottom.Controls.Add(this.num_orders_filter_distanceTo);
            this.panel_orders_layoutBottom.Controls.Add(this.num_orders_filter_distanceFrom);
            this.panel_orders_layoutBottom.Controls.Add(this.label50);
            this.panel_orders_layoutBottom.Controls.Add(this.label49);
            this.panel_orders_layoutBottom.Controls.Add(this.cb_orders_filter_date);
            this.panel_orders_layoutBottom.Controls.Add(this.date_orders_filter_to);
            this.panel_orders_layoutBottom.Controls.Add(this.date_orders_filter_from);
            this.panel_orders_layoutBottom.Controls.Add(this.cb_orders_filter_numPlate);
            this.panel_orders_layoutBottom.Controls.Add(this.label48);
            this.panel_orders_layoutBottom.Controls.Add(this.tb_orders_filter_numPlate);
            this.panel_orders_layoutBottom.Controls.Add(this.label42);
            this.panel_orders_layoutBottom.Controls.Add(this.num_orders_filter_driver);
            this.panel_orders_layoutBottom.Controls.Add(this.cb_orders_filter_driverId);
            this.panel_orders_layoutBottom.Controls.Add(this.label41);
            this.panel_orders_layoutBottom.Controls.Add(this.num_orders_filter_customer);
            this.panel_orders_layoutBottom.Controls.Add(this.cb_orders_filter_customerId);
            this.panel_orders_layoutBottom.Controls.Add(this.btn_orders_refreshList);
            this.panel_orders_layoutBottom.Controls.Add(this.label37);
            this.panel_orders_layoutBottom.Controls.Add(this.label38);
            this.panel_orders_layoutBottom.Controls.Add(this.label_orders_t1);
            this.panel_orders_layoutBottom.Controls.Add(this.btn_orders_filterExpand);
            this.panel_orders_layoutBottom.Controls.Add(this.tb_orders_filterText);
            this.panel_orders_layoutBottom.Controls.Add(this.btn_orders_addOrder);
            this.panel_orders_layoutBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_orders_layoutBottom.Location = new System.Drawing.Point(3, 592);
            this.panel_orders_layoutBottom.Name = "panel_orders_layoutBottom";
            this.panel_orders_layoutBottom.Size = new System.Drawing.Size(852, 43);
            this.panel_orders_layoutBottom.TabIndex = 2;
            // 
            // label59
            // 
            this.label59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label59.Location = new System.Drawing.Point(7, 130);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(544, 1);
            this.label59.TabIndex = 57;
            this.label59.Text = "label59";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(562, 108);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(20, 13);
            this.label58.TabIndex = 56;
            this.label58.Text = "bis";
            // 
            // tb_orders_filter_durationTo
            // 
            this.tb_orders_filter_durationTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_orders_filter_durationTo.Location = new System.Drawing.Point(584, 104);
            this.tb_orders_filter_durationTo.Mask = "###:90:00";
            this.tb_orders_filter_durationTo.Name = "tb_orders_filter_durationTo";
            this.tb_orders_filter_durationTo.PromptChar = '#';
            this.tb_orders_filter_durationTo.Size = new System.Drawing.Size(90, 20);
            this.tb_orders_filter_durationTo.TabIndex = 55;
            this.tb_orders_filter_durationTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_orders_filter_durationTo.ValidatingType = typeof(System.DateTime);
            // 
            // tb_orders_filter_durationFrom
            // 
            this.tb_orders_filter_durationFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_orders_filter_durationFrom.Location = new System.Drawing.Point(471, 104);
            this.tb_orders_filter_durationFrom.Mask = "###:90:00";
            this.tb_orders_filter_durationFrom.Name = "tb_orders_filter_durationFrom";
            this.tb_orders_filter_durationFrom.PromptChar = '#';
            this.tb_orders_filter_durationFrom.Size = new System.Drawing.Size(90, 20);
            this.tb_orders_filter_durationFrom.TabIndex = 54;
            this.tb_orders_filter_durationFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_orders_filter_durationFrom.ValidatingType = typeof(System.DateTime);
            // 
            // cb_orders_filter_duration
            // 
            this.cb_orders_filter_duration.AutoSize = true;
            this.cb_orders_filter_duration.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_orders_filter_duration.Location = new System.Drawing.Point(346, 107);
            this.cb_orders_filter_duration.Name = "cb_orders_filter_duration";
            this.cb_orders_filter_duration.Size = new System.Drawing.Size(15, 14);
            this.cb_orders_filter_duration.TabIndex = 53;
            this.cb_orders_filter_duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_orders_filter_duration.UseVisualStyleBackColor = true;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(362, 106);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(45, 16);
            this.label57.TabIndex = 52;
            this.label57.Text = "Dauer";
            // 
            // cb_orders_filter_amount
            // 
            this.cb_orders_filter_amount.AutoSize = true;
            this.cb_orders_filter_amount.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_orders_filter_amount.Location = new System.Drawing.Point(346, 81);
            this.cb_orders_filter_amount.Name = "cb_orders_filter_amount";
            this.cb_orders_filter_amount.Size = new System.Drawing.Size(15, 14);
            this.cb_orders_filter_amount.TabIndex = 51;
            this.cb_orders_filter_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_orders_filter_amount.UseVisualStyleBackColor = true;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(362, 80);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(48, 16);
            this.label54.TabIndex = 50;
            this.label54.Text = "Betrag";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(660, 83);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(13, 13);
            this.label55.TabIndex = 49;
            this.label55.Text = "€";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(547, 83);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(29, 13);
            this.label56.TabIndex = 48;
            this.label56.Text = "€ bis";
            // 
            // num_orders_filter_amountTo
            // 
            this.num_orders_filter_amountTo.DecimalPlaces = 2;
            this.num_orders_filter_amountTo.Location = new System.Drawing.Point(584, 79);
            this.num_orders_filter_amountTo.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.num_orders_filter_amountTo.Name = "num_orders_filter_amountTo";
            this.num_orders_filter_amountTo.Size = new System.Drawing.Size(76, 20);
            this.num_orders_filter_amountTo.TabIndex = 47;
            // 
            // num_orders_filter_amountFrom
            // 
            this.num_orders_filter_amountFrom.DecimalPlaces = 2;
            this.num_orders_filter_amountFrom.Location = new System.Drawing.Point(471, 79);
            this.num_orders_filter_amountFrom.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.num_orders_filter_amountFrom.Name = "num_orders_filter_amountFrom";
            this.num_orders_filter_amountFrom.Size = new System.Drawing.Size(76, 20);
            this.num_orders_filter_amountFrom.TabIndex = 46;
            // 
            // cb_orders_filter_distance
            // 
            this.cb_orders_filter_distance.AutoSize = true;
            this.cb_orders_filter_distance.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_orders_filter_distance.Location = new System.Drawing.Point(346, 55);
            this.cb_orders_filter_distance.Name = "cb_orders_filter_distance";
            this.cb_orders_filter_distance.Size = new System.Drawing.Size(15, 14);
            this.cb_orders_filter_distance.TabIndex = 45;
            this.cb_orders_filter_distance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_orders_filter_distance.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(362, 53);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(71, 16);
            this.label51.TabIndex = 44;
            this.label51.Text = "Entfernung";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(660, 55);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(21, 13);
            this.label52.TabIndex = 43;
            this.label52.Text = "km";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(547, 55);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(37, 13);
            this.label53.TabIndex = 42;
            this.label53.Text = "km bis";
            // 
            // num_orders_filter_distanceTo
            // 
            this.num_orders_filter_distanceTo.DecimalPlaces = 2;
            this.num_orders_filter_distanceTo.Location = new System.Drawing.Point(584, 51);
            this.num_orders_filter_distanceTo.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.num_orders_filter_distanceTo.Name = "num_orders_filter_distanceTo";
            this.num_orders_filter_distanceTo.Size = new System.Drawing.Size(76, 20);
            this.num_orders_filter_distanceTo.TabIndex = 41;
            // 
            // num_orders_filter_distanceFrom
            // 
            this.num_orders_filter_distanceFrom.DecimalPlaces = 2;
            this.num_orders_filter_distanceFrom.Location = new System.Drawing.Point(471, 51);
            this.num_orders_filter_distanceFrom.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.num_orders_filter_distanceFrom.Name = "num_orders_filter_distanceFrom";
            this.num_orders_filter_distanceFrom.Size = new System.Drawing.Size(76, 20);
            this.num_orders_filter_distanceFrom.TabIndex = 40;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(7, 143);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(47, 16);
            this.label50.TabIndex = 39;
            this.label50.Text = "Datum";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(292, 143);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(20, 13);
            this.label49.TabIndex = 38;
            this.label49.Text = "bis";
            // 
            // cb_orders_filter_date
            // 
            this.cb_orders_filter_date.AutoSize = true;
            this.cb_orders_filter_date.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_orders_filter_date.Location = new System.Drawing.Point(522, 142);
            this.cb_orders_filter_date.Name = "cb_orders_filter_date";
            this.cb_orders_filter_date.Size = new System.Drawing.Size(15, 14);
            this.cb_orders_filter_date.TabIndex = 37;
            this.cb_orders_filter_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_orders_filter_date.UseVisualStyleBackColor = true;
            // 
            // date_orders_filter_to
            // 
            this.date_orders_filter_to.Location = new System.Drawing.Point(315, 139);
            this.date_orders_filter_to.Name = "date_orders_filter_to";
            this.date_orders_filter_to.Size = new System.Drawing.Size(200, 20);
            this.date_orders_filter_to.TabIndex = 36;
            // 
            // date_orders_filter_from
            // 
            this.date_orders_filter_from.Location = new System.Drawing.Point(89, 139);
            this.date_orders_filter_from.Name = "date_orders_filter_from";
            this.date_orders_filter_from.Size = new System.Drawing.Size(200, 20);
            this.date_orders_filter_from.TabIndex = 35;
            // 
            // cb_orders_filter_numPlate
            // 
            this.cb_orders_filter_numPlate.AutoSize = true;
            this.cb_orders_filter_numPlate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_orders_filter_numPlate.Location = new System.Drawing.Point(314, 107);
            this.cb_orders_filter_numPlate.Name = "cb_orders_filter_numPlate";
            this.cb_orders_filter_numPlate.Size = new System.Drawing.Size(15, 14);
            this.cb_orders_filter_numPlate.TabIndex = 34;
            this.cb_orders_filter_numPlate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_orders_filter_numPlate.UseVisualStyleBackColor = true;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(8, 106);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(139, 16);
            this.label48.TabIndex = 33;
            this.label48.Text = "Fahrzeugkennzeichen";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_orders_filter_numPlate
            // 
            this.tb_orders_filter_numPlate.Location = new System.Drawing.Point(224, 104);
            this.tb_orders_filter_numPlate.Name = "tb_orders_filter_numPlate";
            this.tb_orders_filter_numPlate.Size = new System.Drawing.Size(83, 20);
            this.tb_orders_filter_numPlate.TabIndex = 32;
            this.tb_orders_filter_numPlate.Text = "GÖ-TS-000";
            this.tb_orders_filter_numPlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(8, 79);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(110, 16);
            this.label42.TabIndex = 31;
            this.label42.Text = "Personalnummer";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_orders_filter_driver
            // 
            this.num_orders_filter_driver.Location = new System.Drawing.Point(224, 78);
            this.num_orders_filter_driver.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.num_orders_filter_driver.Name = "num_orders_filter_driver";
            this.num_orders_filter_driver.Size = new System.Drawing.Size(83, 20);
            this.num_orders_filter_driver.TabIndex = 30;
            // 
            // cb_orders_filter_driverId
            // 
            this.cb_orders_filter_driverId.AutoSize = true;
            this.cb_orders_filter_driverId.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_orders_filter_driverId.Location = new System.Drawing.Point(314, 81);
            this.cb_orders_filter_driverId.Name = "cb_orders_filter_driverId";
            this.cb_orders_filter_driverId.Size = new System.Drawing.Size(15, 14);
            this.cb_orders_filter_driverId.TabIndex = 29;
            this.cb_orders_filter_driverId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_orders_filter_driverId.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(8, 53);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(101, 16);
            this.label41.TabIndex = 28;
            this.label41.Text = "Kundennummer";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_orders_filter_customer
            // 
            this.num_orders_filter_customer.Location = new System.Drawing.Point(224, 52);
            this.num_orders_filter_customer.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.num_orders_filter_customer.Name = "num_orders_filter_customer";
            this.num_orders_filter_customer.Size = new System.Drawing.Size(83, 20);
            this.num_orders_filter_customer.TabIndex = 27;
            // 
            // cb_orders_filter_customerId
            // 
            this.cb_orders_filter_customerId.AutoSize = true;
            this.cb_orders_filter_customerId.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_orders_filter_customerId.Location = new System.Drawing.Point(314, 55);
            this.cb_orders_filter_customerId.Name = "cb_orders_filter_customerId";
            this.cb_orders_filter_customerId.Size = new System.Drawing.Size(15, 14);
            this.cb_orders_filter_customerId.TabIndex = 26;
            this.cb_orders_filter_customerId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_orders_filter_customerId.UseVisualStyleBackColor = true;
            // 
            // btn_orders_refreshList
            // 
            this.btn_orders_refreshList.FlatAppearance.BorderSize = 0;
            this.btn_orders_refreshList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_orders_refreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders_refreshList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orders_refreshList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_orders_refreshList.Location = new System.Drawing.Point(0, 6);
            this.btn_orders_refreshList.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_orders_refreshList.Name = "btn_orders_refreshList";
            this.btn_orders_refreshList.Size = new System.Drawing.Size(31, 31);
            this.btn_orders_refreshList.TabIndex = 18;
            this.btn_orders_refreshList.Text = "↻";
            this.btn_orders_refreshList.UseVisualStyleBackColor = true;
            this.btn_orders_refreshList.Click += new System.EventHandler(this.btn_orders_refreshList_Click);
            // 
            // label37
            // 
            this.label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label37.Location = new System.Drawing.Point(338, 43);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(1, 88);
            this.label37.TabIndex = 17;
            this.label37.Text = "label37";
            // 
            // label38
            // 
            this.label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label38.Location = new System.Drawing.Point(7, 43);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(839, 1);
            this.label38.TabIndex = 16;
            this.label38.Text = "label38";
            // 
            // label_orders_t1
            // 
            this.label_orders_t1.AutoSize = true;
            this.label_orders_t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orders_t1.Location = new System.Drawing.Point(389, 14);
            this.label_orders_t1.Name = "label_orders_t1";
            this.label_orders_t1.Size = new System.Drawing.Size(46, 16);
            this.label_orders_t1.TabIndex = 6;
            this.label_orders_t1.Text = "Suche";
            // 
            // btn_orders_filterExpand
            // 
            this.btn_orders_filterExpand.BackColor = System.Drawing.Color.LightGray;
            this.btn_orders_filterExpand.FlatAppearance.BorderSize = 0;
            this.btn_orders_filterExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders_filterExpand.Location = new System.Drawing.Point(738, 10);
            this.btn_orders_filterExpand.Name = "btn_orders_filterExpand";
            this.btn_orders_filterExpand.Size = new System.Drawing.Size(106, 23);
            this.btn_orders_filterExpand.TabIndex = 5;
            this.btn_orders_filterExpand.Text = "Filter erweitern ▲";
            this.btn_orders_filterExpand.UseVisualStyleBackColor = false;
            this.btn_orders_filterExpand.Click += new System.EventHandler(this.btn_orders_filterExpand_Click);
            // 
            // tb_orders_filterText
            // 
            this.tb_orders_filterText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_orders_filterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_orders_filterText.Location = new System.Drawing.Point(438, 11);
            this.tb_orders_filterText.Name = "tb_orders_filterText";
            this.tb_orders_filterText.Size = new System.Drawing.Size(294, 22);
            this.tb_orders_filterText.TabIndex = 4;
            this.tb_orders_filterText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_orders_filterText_KeyDown);
            // 
            // btn_orders_addOrder
            // 
            this.btn_orders_addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders_addOrder.Location = new System.Drawing.Point(34, 6);
            this.btn_orders_addOrder.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_orders_addOrder.Name = "btn_orders_addOrder";
            this.btn_orders_addOrder.Size = new System.Drawing.Size(134, 31);
            this.btn_orders_addOrder.TabIndex = 0;
            this.btn_orders_addOrder.Text = "Neue Bestellung";
            this.btn_orders_addOrder.UseVisualStyleBackColor = true;
            this.btn_orders_addOrder.Click += new System.EventHandler(this.btn_orders_addOrder_Click);
            // 
            // tp_customers
            // 
            this.tp_customers.Controls.Add(this.panel_customer_form);
            this.tp_customers.Controls.Add(this.view_customers);
            this.tp_customers.Controls.Add(this.panel_customer_layoutBottom);
            this.tp_customers.Location = new System.Drawing.Point(4, 24);
            this.tp_customers.Name = "tp_customers";
            this.tp_customers.Padding = new System.Windows.Forms.Padding(3);
            this.tp_customers.Size = new System.Drawing.Size(858, 663);
            this.tp_customers.TabIndex = 2;
            this.tp_customers.Text = "Kunden";
            this.tp_customers.UseVisualStyleBackColor = true;
            // 
            // panel_customer_form
            // 
            this.panel_customer_form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_customer_form.Controls.Add(this.lbl_customer_numberText);
            this.panel_customer_form.Controls.Add(this.lbl_customer_numer);
            this.panel_customer_form.Controls.Add(this.tb_customer_phone);
            this.panel_customer_form.Controls.Add(this.tb_customer_surname);
            this.panel_customer_form.Controls.Add(this.btn_customer_saveForm);
            this.panel_customer_form.Controls.Add(this.tb_customer_lastname);
            this.panel_customer_form.Controls.Add(this.label43);
            this.panel_customer_form.Controls.Add(this.label44);
            this.panel_customer_form.Controls.Add(this.label45);
            this.panel_customer_form.Controls.Add(this.label46);
            this.panel_customer_form.Controls.Add(this.label47);
            this.panel_customer_form.Controls.Add(this.btn_customer_hideForm);
            this.panel_customer_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_customer_form.Location = new System.Drawing.Point(3, 3);
            this.panel_customer_form.Name = "panel_customer_form";
            this.panel_customer_form.Size = new System.Drawing.Size(852, 590);
            this.panel_customer_form.TabIndex = 5;
            this.panel_customer_form.Visible = false;
            // 
            // lbl_customer_numberText
            // 
            this.lbl_customer_numberText.AutoSize = true;
            this.lbl_customer_numberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer_numberText.Location = new System.Drawing.Point(234, 9);
            this.lbl_customer_numberText.Name = "lbl_customer_numberText";
            this.lbl_customer_numberText.Size = new System.Drawing.Size(101, 16);
            this.lbl_customer_numberText.TabIndex = 27;
            this.lbl_customer_numberText.Text = "Kundennummer";
            this.lbl_customer_numberText.Visible = false;
            // 
            // lbl_customer_numer
            // 
            this.lbl_customer_numer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_customer_numer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer_numer.Location = new System.Drawing.Point(337, 4);
            this.lbl_customer_numer.Name = "lbl_customer_numer";
            this.lbl_customer_numer.Size = new System.Drawing.Size(44, 26);
            this.lbl_customer_numer.TabIndex = 26;
            this.lbl_customer_numer.Text = "0";
            this.lbl_customer_numer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_customer_numer.Visible = false;
            // 
            // tb_customer_phone
            // 
            this.tb_customer_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customer_phone.Location = new System.Drawing.Point(138, 97);
            this.tb_customer_phone.Name = "tb_customer_phone";
            this.tb_customer_phone.Size = new System.Drawing.Size(243, 22);
            this.tb_customer_phone.TabIndex = 25;
            // 
            // tb_customer_surname
            // 
            this.tb_customer_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customer_surname.Location = new System.Drawing.Point(138, 37);
            this.tb_customer_surname.Name = "tb_customer_surname";
            this.tb_customer_surname.Size = new System.Drawing.Size(243, 22);
            this.tb_customer_surname.TabIndex = 24;
            // 
            // btn_customer_saveForm
            // 
            this.btn_customer_saveForm.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_customer_saveForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_customer_saveForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer_saveForm.Location = new System.Drawing.Point(9, 132);
            this.btn_customer_saveForm.Name = "btn_customer_saveForm";
            this.btn_customer_saveForm.Size = new System.Drawing.Size(115, 23);
            this.btn_customer_saveForm.TabIndex = 23;
            this.btn_customer_saveForm.Text = "Speichern";
            this.btn_customer_saveForm.UseVisualStyleBackColor = true;
            this.btn_customer_saveForm.Click += new System.EventHandler(this.btn_customer_saveForm_Click);
            // 
            // tb_customer_lastname
            // 
            this.tb_customer_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customer_lastname.Location = new System.Drawing.Point(138, 67);
            this.tb_customer_lastname.Name = "tb_customer_lastname";
            this.tb_customer_lastname.Size = new System.Drawing.Size(243, 22);
            this.tb_customer_lastname.TabIndex = 17;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(6, 100);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(102, 16);
            this.label43.TabIndex = 10;
            this.label43.Text = "Telefonnummer";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(6, 70);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(74, 16);
            this.label44.TabIndex = 9;
            this.label44.Text = "Nachname";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(6, 40);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(63, 16);
            this.label45.TabIndex = 8;
            this.label45.Text = "Vorname";
            // 
            // label46
            // 
            this.label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label46.Location = new System.Drawing.Point(6, 26);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(165, 1);
            this.label46.TabIndex = 2;
            this.label46.Text = "HR";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(5, 5);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(64, 20);
            this.label47.TabIndex = 1;
            this.label47.Text = "Kunden";
            // 
            // btn_customer_hideForm
            // 
            this.btn_customer_hideForm.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_customer_hideForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_customer_hideForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer_hideForm.Location = new System.Drawing.Point(161, 132);
            this.btn_customer_hideForm.Name = "btn_customer_hideForm";
            this.btn_customer_hideForm.Size = new System.Drawing.Size(115, 23);
            this.btn_customer_hideForm.TabIndex = 0;
            this.btn_customer_hideForm.Text = "Abbrechen";
            this.btn_customer_hideForm.UseVisualStyleBackColor = true;
            this.btn_customer_hideForm.Click += new System.EventHandler(this.btn_customer_hideForm_Click);
            // 
            // view_customers
            // 
            this.view_customers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_customer_number,
            this.ch_customer_surname,
            this.ch_customer_lastname,
            this.ch_customer_phone});
            this.view_customers.ContextMenuStrip = this.context_customers;
            this.view_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_customers.FullRowSelect = true;
            this.view_customers.GridLines = true;
            this.view_customers.Location = new System.Drawing.Point(3, 3);
            this.view_customers.Name = "view_customers";
            this.view_customers.Size = new System.Drawing.Size(852, 590);
            this.view_customers.TabIndex = 4;
            this.view_customers.UseCompatibleStateImageBehavior = false;
            this.view_customers.View = System.Windows.Forms.View.Details;
            this.view_customers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.view_customers_MouseDoubleClick);
            // 
            // ch_customer_number
            // 
            this.ch_customer_number.Text = "Kundennummer";
            this.ch_customer_number.Width = 100;
            // 
            // ch_customer_surname
            // 
            this.ch_customer_surname.Text = "Vorname";
            this.ch_customer_surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ch_customer_surname.Width = 200;
            // 
            // ch_customer_lastname
            // 
            this.ch_customer_lastname.Text = "Nachname";
            this.ch_customer_lastname.Width = 220;
            // 
            // ch_customer_phone
            // 
            this.ch_customer_phone.Text = "Telefonnummer";
            this.ch_customer_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_customer_phone.Width = 180;
            // 
            // context_customers
            // 
            this.context_customers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.context_customer_editCustomer,
            this.context_customer_deleteCustomer,
            this.context_customer_viewCustomerOrders});
            this.context_customers.Name = "context_vehicles";
            this.context_customers.Size = new System.Drawing.Size(255, 70);
            // 
            // context_customer_editCustomer
            // 
            this.context_customer_editCustomer.Name = "context_customer_editCustomer";
            this.context_customer_editCustomer.Size = new System.Drawing.Size(254, 22);
            this.context_customer_editCustomer.Text = "Kunde bearbeiten";
            this.context_customer_editCustomer.Click += new System.EventHandler(this.context_customer_editCustomer_Click);
            // 
            // context_customer_deleteCustomer
            // 
            this.context_customer_deleteCustomer.Name = "context_customer_deleteCustomer";
            this.context_customer_deleteCustomer.Size = new System.Drawing.Size(254, 22);
            this.context_customer_deleteCustomer.Text = "Kunde entfernen";
            this.context_customer_deleteCustomer.Click += new System.EventHandler(this.context_customer_deleteCustomer_Click);
            // 
            // context_customer_viewCustomerOrders
            // 
            this.context_customer_viewCustomerOrders.Name = "context_customer_viewCustomerOrders";
            this.context_customer_viewCustomerOrders.Size = new System.Drawing.Size(254, 22);
            this.context_customer_viewCustomerOrders.Text = "Bestellungen des Kunden ansehen";
            this.context_customer_viewCustomerOrders.Click += new System.EventHandler(this.context_customer_viewCustomerOrders_Click);
            // 
            // panel_customer_layoutBottom
            // 
            this.panel_customer_layoutBottom.Controls.Add(this.cb_customer_filterId);
            this.panel_customer_layoutBottom.Controls.Add(this.label60);
            this.panel_customer_layoutBottom.Controls.Add(this.num_customer_filter_num);
            this.panel_customer_layoutBottom.Controls.Add(this.btn_customer_reloadList);
            this.panel_customer_layoutBottom.Controls.Add(this.label_customer_t1);
            this.panel_customer_layoutBottom.Controls.Add(this.tb_customer_filterText);
            this.panel_customer_layoutBottom.Controls.Add(this.btn_customers_addCustomer);
            this.panel_customer_layoutBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_customer_layoutBottom.Location = new System.Drawing.Point(3, 593);
            this.panel_customer_layoutBottom.Name = "panel_customer_layoutBottom";
            this.panel_customer_layoutBottom.Size = new System.Drawing.Size(852, 67);
            this.panel_customer_layoutBottom.TabIndex = 3;
            // 
            // cb_customer_filterId
            // 
            this.cb_customer_filterId.AutoSize = true;
            this.cb_customer_filterId.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_customer_filterId.Location = new System.Drawing.Point(826, 42);
            this.cb_customer_filterId.Name = "cb_customer_filterId";
            this.cb_customer_filterId.Size = new System.Drawing.Size(15, 14);
            this.cb_customer_filterId.TabIndex = 27;
            this.cb_customer_filterId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_customer_filterId.UseVisualStyleBackColor = true;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(501, 43);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(101, 16);
            this.label60.TabIndex = 9;
            this.label60.Text = "Kundennummer";
            // 
            // num_customer_filter_num
            // 
            this.num_customer_filter_num.Location = new System.Drawing.Point(703, 39);
            this.num_customer_filter_num.Name = "num_customer_filter_num";
            this.num_customer_filter_num.Size = new System.Drawing.Size(120, 20);
            this.num_customer_filter_num.TabIndex = 8;
            // 
            // btn_customer_reloadList
            // 
            this.btn_customer_reloadList.FlatAppearance.BorderSize = 0;
            this.btn_customer_reloadList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_customer_reloadList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer_reloadList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer_reloadList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_customer_reloadList.Location = new System.Drawing.Point(0, 6);
            this.btn_customer_reloadList.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_customer_reloadList.Name = "btn_customer_reloadList";
            this.btn_customer_reloadList.Size = new System.Drawing.Size(31, 31);
            this.btn_customer_reloadList.TabIndex = 7;
            this.btn_customer_reloadList.Text = "↻";
            this.btn_customer_reloadList.UseVisualStyleBackColor = true;
            this.btn_customer_reloadList.Click += new System.EventHandler(this.btn_customer_reloadList_Click);
            // 
            // label_customer_t1
            // 
            this.label_customer_t1.AutoSize = true;
            this.label_customer_t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer_t1.Location = new System.Drawing.Point(501, 14);
            this.label_customer_t1.Name = "label_customer_t1";
            this.label_customer_t1.Size = new System.Drawing.Size(46, 16);
            this.label_customer_t1.TabIndex = 6;
            this.label_customer_t1.Text = "Suche";
            // 
            // tb_customer_filterText
            // 
            this.tb_customer_filterText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_customer_filterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customer_filterText.Location = new System.Drawing.Point(550, 11);
            this.tb_customer_filterText.Name = "tb_customer_filterText";
            this.tb_customer_filterText.Size = new System.Drawing.Size(294, 22);
            this.tb_customer_filterText.TabIndex = 4;
            this.tb_customer_filterText.TextChanged += new System.EventHandler(this.tb_customer_filterText_TextChanged);
            // 
            // btn_customers_addCustomer
            // 
            this.btn_customers_addCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customers_addCustomer.Location = new System.Drawing.Point(34, 7);
            this.btn_customers_addCustomer.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_customers_addCustomer.Name = "btn_customers_addCustomer";
            this.btn_customers_addCustomer.Size = new System.Drawing.Size(134, 31);
            this.btn_customers_addCustomer.TabIndex = 0;
            this.btn_customers_addCustomer.Text = "Neuer Kunde";
            this.btn_customers_addCustomer.UseVisualStyleBackColor = true;
            this.btn_customers_addCustomer.Click += new System.EventHandler(this.btn_customers_addCustomer_Click);
            // 
            // tp_reports
            // 
            this.tp_reports.Controls.Add(this.label61);
            this.tp_reports.Controls.Add(this.btn_reports_openWeekly);
            this.tp_reports.Controls.Add(this.btn_reports_openDayly);
            this.tp_reports.Controls.Add(this.btn_reports_openVehicles);
            this.tp_reports.Controls.Add(this.btn_reports_openCustomerData);
            this.tp_reports.Controls.Add(this.btn_reports_openCustomerInvoices);
            this.tp_reports.Controls.Add(this.btn_reports_openOrders);
            this.tp_reports.Location = new System.Drawing.Point(4, 24);
            this.tp_reports.Name = "tp_reports";
            this.tp_reports.Size = new System.Drawing.Size(858, 663);
            this.tp_reports.TabIndex = 3;
            this.tp_reports.Text = "Berichte";
            this.tp_reports.UseVisualStyleBackColor = true;
            // 
            // btn_reports_openWeekly
            // 
            this.btn_reports_openWeekly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_reports_openWeekly.FlatAppearance.BorderSize = 0;
            this.btn_reports_openWeekly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_reports_openWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports_openWeekly.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports_openWeekly.ForeColor = System.Drawing.Color.Black;
            this.btn_reports_openWeekly.Location = new System.Drawing.Point(382, 189);
            this.btn_reports_openWeekly.Name = "btn_reports_openWeekly";
            this.btn_reports_openWeekly.Size = new System.Drawing.Size(180, 180);
            this.btn_reports_openWeekly.TabIndex = 5;
            this.btn_reports_openWeekly.Text = "Wöchentliche Zusammenfassung";
            this.btn_reports_openWeekly.UseVisualStyleBackColor = false;
            this.btn_reports_openWeekly.Click += new System.EventHandler(this.btn_reports_openWeekly_Click);
            // 
            // btn_reports_openDayly
            // 
            this.btn_reports_openDayly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_reports_openDayly.FlatAppearance.BorderSize = 0;
            this.btn_reports_openDayly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_reports_openDayly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports_openDayly.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports_openDayly.ForeColor = System.Drawing.Color.Black;
            this.btn_reports_openDayly.Location = new System.Drawing.Point(382, 3);
            this.btn_reports_openDayly.Name = "btn_reports_openDayly";
            this.btn_reports_openDayly.Size = new System.Drawing.Size(180, 180);
            this.btn_reports_openDayly.TabIndex = 4;
            this.btn_reports_openDayly.Text = "Tägliche Zusammenfassung";
            this.btn_reports_openDayly.UseVisualStyleBackColor = false;
            this.btn_reports_openDayly.Click += new System.EventHandler(this.btn_reports_openDayly_Click);
            // 
            // btn_reports_openVehicles
            // 
            this.btn_reports_openVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_reports_openVehicles.FlatAppearance.BorderSize = 0;
            this.btn_reports_openVehicles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_reports_openVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports_openVehicles.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports_openVehicles.ForeColor = System.Drawing.Color.Black;
            this.btn_reports_openVehicles.Location = new System.Drawing.Point(189, 189);
            this.btn_reports_openVehicles.Name = "btn_reports_openVehicles";
            this.btn_reports_openVehicles.Size = new System.Drawing.Size(180, 180);
            this.btn_reports_openVehicles.TabIndex = 3;
            this.btn_reports_openVehicles.Text = "Fuhrparkdaten";
            this.btn_reports_openVehicles.UseVisualStyleBackColor = false;
            this.btn_reports_openVehicles.Click += new System.EventHandler(this.btn_reports_openVehicles_Click);
            // 
            // btn_reports_openCustomerData
            // 
            this.btn_reports_openCustomerData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_reports_openCustomerData.FlatAppearance.BorderSize = 0;
            this.btn_reports_openCustomerData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_reports_openCustomerData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports_openCustomerData.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports_openCustomerData.ForeColor = System.Drawing.Color.Black;
            this.btn_reports_openCustomerData.Location = new System.Drawing.Point(3, 189);
            this.btn_reports_openCustomerData.Name = "btn_reports_openCustomerData";
            this.btn_reports_openCustomerData.Size = new System.Drawing.Size(180, 180);
            this.btn_reports_openCustomerData.TabIndex = 2;
            this.btn_reports_openCustomerData.Text = "Kundendaten";
            this.btn_reports_openCustomerData.UseVisualStyleBackColor = false;
            this.btn_reports_openCustomerData.Click += new System.EventHandler(this.btn_reports_openCustomerData_Click);
            // 
            // btn_reports_openCustomerInvoices
            // 
            this.btn_reports_openCustomerInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_reports_openCustomerInvoices.FlatAppearance.BorderSize = 0;
            this.btn_reports_openCustomerInvoices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_reports_openCustomerInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports_openCustomerInvoices.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports_openCustomerInvoices.ForeColor = System.Drawing.Color.Black;
            this.btn_reports_openCustomerInvoices.Location = new System.Drawing.Point(189, 3);
            this.btn_reports_openCustomerInvoices.Name = "btn_reports_openCustomerInvoices";
            this.btn_reports_openCustomerInvoices.Size = new System.Drawing.Size(180, 180);
            this.btn_reports_openCustomerInvoices.TabIndex = 1;
            this.btn_reports_openCustomerInvoices.Text = "Kundenrechnungen";
            this.btn_reports_openCustomerInvoices.UseVisualStyleBackColor = false;
            this.btn_reports_openCustomerInvoices.Click += new System.EventHandler(this.btn_reports_openCustomerInvoices_Click);
            // 
            // btn_reports_openOrders
            // 
            this.btn_reports_openOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_reports_openOrders.FlatAppearance.BorderSize = 0;
            this.btn_reports_openOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_reports_openOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports_openOrders.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports_openOrders.ForeColor = System.Drawing.Color.Black;
            this.btn_reports_openOrders.Location = new System.Drawing.Point(3, 3);
            this.btn_reports_openOrders.Name = "btn_reports_openOrders";
            this.btn_reports_openOrders.Size = new System.Drawing.Size(180, 180);
            this.btn_reports_openOrders.TabIndex = 0;
            this.btn_reports_openOrders.Text = "Bestellungen";
            this.btn_reports_openOrders.UseVisualStyleBackColor = false;
            this.btn_reports_openOrders.Click += new System.EventHandler(this.btn_reports_openOrders_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.toolStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStrip_close});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(866, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStip_btn_refresh});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton1.Text = "Datei";
            // 
            // toolStip_btn_refresh
            // 
            this.toolStip_btn_refresh.Name = "toolStip_btn_refresh";
            this.toolStip_btn_refresh.Size = new System.Drawing.Size(158, 22);
            this.toolStip_btn_refresh.Text = "Alles aktualisieren";
            this.toolStip_btn_refresh.Click += new System.EventHandler(this.toolStip_btn_refresh_Click);
            // 
            // toolStrip_close
            // 
            this.toolStrip_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_close.ForeColor = System.Drawing.Color.White;
            this.toolStrip_close.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_close.Image")));
            this.toolStrip_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_close.Name = "toolStrip_close";
            this.toolStrip_close.Size = new System.Drawing.Size(54, 22);
            this.toolStrip_close.Text = "Beenden";
            this.toolStrip_close.Click += new System.EventHandler(this.toolStrip_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(9)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 691);
            this.panel1.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_navigation_reports);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 319);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(4);
            this.panel7.Size = new System.Drawing.Size(205, 40);
            this.panel7.TabIndex = 4;
            // 
            // btn_navigation_reports
            // 
            this.btn_navigation_reports.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_navigation_reports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_navigation_reports.FlatAppearance.BorderSize = 0;
            this.btn_navigation_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_navigation_reports.Location = new System.Drawing.Point(4, 4);
            this.btn_navigation_reports.Name = "btn_navigation_reports";
            this.btn_navigation_reports.Size = new System.Drawing.Size(197, 32);
            this.btn_navigation_reports.TabIndex = 0;
            this.btn_navigation_reports.Text = "Berichte";
            this.btn_navigation_reports.UseVisualStyleBackColor = false;
            this.btn_navigation_reports.Click += new System.EventHandler(this.btn_navigation_reports_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_navigation_customers);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 279);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(4);
            this.panel6.Size = new System.Drawing.Size(205, 40);
            this.panel6.TabIndex = 3;
            // 
            // btn_navigation_customers
            // 
            this.btn_navigation_customers.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_navigation_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_navigation_customers.FlatAppearance.BorderSize = 0;
            this.btn_navigation_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_navigation_customers.Location = new System.Drawing.Point(4, 4);
            this.btn_navigation_customers.Name = "btn_navigation_customers";
            this.btn_navigation_customers.Size = new System.Drawing.Size(197, 32);
            this.btn_navigation_customers.TabIndex = 0;
            this.btn_navigation_customers.Text = "Kunden";
            this.btn_navigation_customers.UseVisualStyleBackColor = false;
            this.btn_navigation_customers.Click += new System.EventHandler(this.btn_navigation_customers_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_navigation_orders);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 239);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(4);
            this.panel5.Size = new System.Drawing.Size(205, 40);
            this.panel5.TabIndex = 2;
            // 
            // btn_navigation_orders
            // 
            this.btn_navigation_orders.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_navigation_orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_navigation_orders.FlatAppearance.BorderSize = 0;
            this.btn_navigation_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_navigation_orders.Location = new System.Drawing.Point(4, 4);
            this.btn_navigation_orders.Name = "btn_navigation_orders";
            this.btn_navigation_orders.Size = new System.Drawing.Size(197, 32);
            this.btn_navigation_orders.TabIndex = 0;
            this.btn_navigation_orders.Text = "Bestellungen";
            this.btn_navigation_orders.UseVisualStyleBackColor = false;
            this.btn_navigation_orders.Click += new System.EventHandler(this.btn_navigation_orders_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_navigation_vehicles);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 199);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(4);
            this.panel4.Size = new System.Drawing.Size(205, 40);
            this.panel4.TabIndex = 1;
            // 
            // btn_navigation_vehicles
            // 
            this.btn_navigation_vehicles.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_navigation_vehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_navigation_vehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_navigation_vehicles.Location = new System.Drawing.Point(4, 4);
            this.btn_navigation_vehicles.Name = "btn_navigation_vehicles";
            this.btn_navigation_vehicles.Size = new System.Drawing.Size(197, 32);
            this.btn_navigation_vehicles.TabIndex = 0;
            this.btn_navigation_vehicles.Text = "Fuhrpark";
            this.btn_navigation_vehicles.UseVisualStyleBackColor = false;
            this.btn_navigation_vehicles.Click += new System.EventHandler(this.btn_navigation_vehicles_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 199);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DBProject_App.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip);
            this.panel2.Controls.Add(this.tc_main);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(205, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 691);
            this.panel2.TabIndex = 4;
            // 
            // label61
            // 
            this.label61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label61.Location = new System.Drawing.Point(375, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(1, 369);
            this.label61.TabIndex = 6;
            this.label61.Text = "label61";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oracle Datenbank Projekt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tc_main.ResumeLayout(false);
            this.tp_vehicles.ResumeLayout(false);
            this.panel_vehicles_form.ResumeLayout(false);
            this.panel_vehicles_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_vehicles_totalDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_vehicles_usage)).EndInit();
            this.context_vehicles.ResumeLayout(false);
            this.panel_vehicles_layoutBottom.ResumeLayout(false);
            this.panel_vehicles_layoutBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_vehicles_filter_usage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_vehicles_filter_totalUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_vehicles_filter_totalLower)).EndInit();
            this.tp_orders.ResumeLayout(false);
            this.panel_orders_form.ResumeLayout(false);
            this.panel_orders_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_customerId)).EndInit();
            this.context_orders.ResumeLayout(false);
            this.panel_orders_layoutBottom.ResumeLayout(false);
            this.panel_orders_layoutBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_filter_amountTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_filter_amountFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_filter_distanceTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_filter_distanceFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_filter_driver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_orders_filter_customer)).EndInit();
            this.tp_customers.ResumeLayout(false);
            this.panel_customer_form.ResumeLayout(false);
            this.panel_customer_form.PerformLayout();
            this.context_customers.ResumeLayout(false);
            this.panel_customer_layoutBottom.ResumeLayout(false);
            this.panel_customer_layoutBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_customer_filter_num)).EndInit();
            this.tp_reports.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_main;
        private System.Windows.Forms.TabPage tp_vehicles;
        private System.Windows.Forms.TabPage tp_orders;
        private System.Windows.Forms.TabPage tp_customers;
        private System.Windows.Forms.TabPage tp_reports;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton toolStrip_close;
        private System.Windows.Forms.ListView view_vehicles;
        private System.Windows.Forms.ColumnHeader ch_vehicles_numPlate;
        private System.Windows.Forms.ColumnHeader ch_vehicles_brand;
        private System.Windows.Forms.ColumnHeader ch_vehicles_tuv;
        private System.Windows.Forms.Panel panel_vehicles_layoutBottom;
        private System.Windows.Forms.Button btn_vehicles_addVehicle;
        private System.Windows.Forms.ContextMenuStrip context_vehicles;
        private System.Windows.Forms.ToolStripMenuItem context_vehicles_editEntry;
        private System.Windows.Forms.ToolStripMenuItem context_vehicles_deleteEntry;
        private System.Windows.Forms.ToolStripMenuItem toolStip_btn_refresh;
        private System.Windows.Forms.ListView view_orders;
        private System.Windows.Forms.ColumnHeader ch_orders_date;
        private System.Windows.Forms.ColumnHeader ch_orders_customer;
        private System.Windows.Forms.ColumnHeader ch_orders_price;
        private System.Windows.Forms.Panel panel_orders_layoutBottom;
        private System.Windows.Forms.Button btn_orders_addOrder;
        private System.Windows.Forms.ColumnHeader ch_orders_startAdress;
        private System.Windows.Forms.ColumnHeader ch_orders_destinationAdress;
        private System.Windows.Forms.TextBox tb_vehicles_filterText;
        private System.Windows.Forms.Button btn_vehicles_filterExpand;
        private System.Windows.Forms.Label label_vehicles_t1;
        private System.Windows.Forms.ListView view_customers;
        private System.Windows.Forms.ColumnHeader ch_customer_number;
        private System.Windows.Forms.ColumnHeader ch_customer_surname;
        private System.Windows.Forms.ColumnHeader ch_customer_lastname;
        private System.Windows.Forms.ColumnHeader ch_customer_phone;
        private System.Windows.Forms.Panel panel_customer_layoutBottom;
        private System.Windows.Forms.Button btn_customers_addCustomer;
        private System.Windows.Forms.Label label_orders_t1;
        private System.Windows.Forms.Button btn_orders_filterExpand;
        private System.Windows.Forms.TextBox tb_orders_filterText;
        private System.Windows.Forms.Label label_customer_t1;
        private System.Windows.Forms.TextBox tb_customer_filterText;
        private System.Windows.Forms.Button btn_reports_openWeekly;
        private System.Windows.Forms.Button btn_reports_openDayly;
        private System.Windows.Forms.Button btn_reports_openVehicles;
        private System.Windows.Forms.Button btn_reports_openCustomerData;
        private System.Windows.Forms.Button btn_reports_openCustomerInvoices;
        private System.Windows.Forms.Button btn_reports_openOrders;
        private System.Windows.Forms.ContextMenuStrip context_orders;
        private System.Windows.Forms.ToolStripMenuItem context_orders_editOrder;
        private System.Windows.Forms.ToolStripMenuItem context_orders_deleteOrder;
        private System.Windows.Forms.ToolStripMenuItem context_orders_showCustomer;
        private System.Windows.Forms.ContextMenuStrip context_customers;
        private System.Windows.Forms.ToolStripMenuItem context_customer_editCustomer;
        private System.Windows.Forms.ToolStripMenuItem context_customer_deleteCustomer;
        private System.Windows.Forms.Panel panel_vehicles_form;
        private System.Windows.Forms.Button btn_vehicles_formHide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_vehicles_t2;
        private System.Windows.Forms.DateTimePicker date_vehicles_tuv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown num_vehicles_totalDist;
        private System.Windows.Forms.NumericUpDown num_vehicles_usage;
        private System.Windows.Forms.TextBox tb_vehicles_brand;
        private System.Windows.Forms.ComboBox combo_vehicles_tireType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combo_vehicles_garage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tb_vehicles_numPlate_p3;
        private System.Windows.Forms.MaskedTextBox tb_vehicles_numPlate_p2;
        private System.Windows.Forms.MaskedTextBox tb_vehicles_numPlate_p1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_vehicles_formSave;
        private System.Windows.Forms.Panel panel_orders_form;
        private System.Windows.Forms.MaskedTextBox tb_orders_duration;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown num_orders_distance;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_orders_startPoint;
        private System.Windows.Forms.ComboBox combo_orders_driver;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown num_orders_amount;
        private System.Windows.Forms.NumericUpDown num_orders_customerId;
        private System.Windows.Forms.Button btn_orders_formSave;
        private System.Windows.Forms.DateTimePicker date_orders_date;
        private System.Windows.Forms.TextBox tb_orders_customerData;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox combo_orders_vehicle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btn_orders_formHide;
        private System.Windows.Forms.ColumnHeader ch_vehicles_building;
        private System.Windows.Forms.ColumnHeader ch_vehicles_tireType;
        private System.Windows.Forms.ColumnHeader ch_vehicles_totalkm;
        private System.Windows.Forms.ColumnHeader ch_vehicles_gasUsage;
        private System.Windows.Forms.ColumnHeader ch_vehicles_inUse;
        private System.Windows.Forms.Button btn_vehicle_reloadList;
        private System.Windows.Forms.ComboBox combo_vehicles_filter_tire;
        private System.Windows.Forms.ComboBox combo_vehicles_filter_building;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker date_vehicles_filter_tuvUpper;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DateTimePicker date_vehicles_filter_tuvLower;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown num_vehicles_filter_usage;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown num_vehicles_filter_totalUpper;
        private System.Windows.Forms.NumericUpDown num_vehicles_filter_totalLower;
        private System.Windows.Forms.Button btn_vehicle_filter_reset;
        private System.Windows.Forms.CheckBox cb_vehicles_filter_toggleTuv;
        private System.Windows.Forms.CheckBox cb_vehicles_filter_toggleUsage;
        private System.Windows.Forms.CheckBox cb_vehicles_filter_toggleTotal;
        private System.Windows.Forms.CheckBox cb_vehicles_filter_toggleTire;
        private System.Windows.Forms.CheckBox cb_vehicles_filter_toggleBuilding;
        private System.Windows.Forms.ToolStripMenuItem context_customer_viewCustomerOrders;
        private System.Windows.Forms.Button btn_customer_reloadList;
        private System.Windows.Forms.Panel panel_customer_form;
        private System.Windows.Forms.TextBox tb_customer_phone;
        private System.Windows.Forms.TextBox tb_customer_surname;
        private System.Windows.Forms.Button btn_customer_saveForm;
        private System.Windows.Forms.TextBox tb_customer_lastname;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Button btn_customer_hideForm;
        private System.Windows.Forms.Label lbl_customer_numberText;
        private System.Windows.Forms.Label lbl_customer_numer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_navigation_reports;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_navigation_customers;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_navigation_orders;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_navigation_vehicles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_orders_destStreet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_orders_destPoint;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox tb_orders_startStreet;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label lbl_orders_numberText;
        private System.Windows.Forms.Label lbl_orders_number;
        private System.Windows.Forms.ColumnHeader ch_orders_orderId;
        private System.Windows.Forms.ColumnHeader ch_orders_driver;
        private System.Windows.Forms.ColumnHeader ch_orders_vehicleNum;
        private System.Windows.Forms.ColumnHeader ch_orders_startPoint;
        private System.Windows.Forms.ColumnHeader ch_orders_destinationPoint;
        private System.Windows.Forms.ColumnHeader ch_orders_distance;
        private System.Windows.Forms.ColumnHeader ch_orders_duration;
        private System.Windows.Forms.Button btn_orders_refreshList;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.NumericUpDown num_orders_filter_driver;
        private System.Windows.Forms.CheckBox cb_orders_filter_driverId;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown num_orders_filter_customer;
        private System.Windows.Forms.CheckBox cb_orders_filter_customerId;
        private System.Windows.Forms.CheckBox cb_orders_filter_numPlate;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox tb_orders_filter_numPlate;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.CheckBox cb_orders_filter_date;
        private System.Windows.Forms.DateTimePicker date_orders_filter_to;
        private System.Windows.Forms.DateTimePicker date_orders_filter_from;
        private System.Windows.Forms.CheckBox cb_orders_filter_amount;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.NumericUpDown num_orders_filter_amountTo;
        private System.Windows.Forms.NumericUpDown num_orders_filter_amountFrom;
        private System.Windows.Forms.CheckBox cb_orders_filter_distance;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.NumericUpDown num_orders_filter_distanceTo;
        private System.Windows.Forms.NumericUpDown num_orders_filter_distanceFrom;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.MaskedTextBox tb_orders_filter_durationTo;
        private System.Windows.Forms.MaskedTextBox tb_orders_filter_durationFrom;
        private System.Windows.Forms.CheckBox cb_orders_filter_duration;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.NumericUpDown num_customer_filter_num;
        private System.Windows.Forms.CheckBox cb_customer_filterId;
        private System.Windows.Forms.Label label61;
    }
}

