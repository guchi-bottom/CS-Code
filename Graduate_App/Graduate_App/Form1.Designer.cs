namespace Graduate_App
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.List_Comp = new System.Windows.Forms.ListBox();
            this.CSV_Data_ADD = new System.Windows.Forms.Button();
            this.Company_Name = new System.Windows.Forms.TextBox();
            this.corp_name = new System.Windows.Forms.Label();
            this.service = new System.Windows.Forms.Label();
            this.Service_Name = new System.Windows.Forms.TextBox();
            this.Log_Doing = new System.Windows.Forms.RadioButton();
            this.Log_UnOfficial = new System.Windows.Forms.RadioButton();
            this.Log_Decline = new System.Windows.Forms.RadioButton();
            this.group_status = new System.Windows.Forms.GroupBox();
            this.group_log = new System.Windows.Forms.GroupBox();
            this.Date_1 = new System.Windows.Forms.DateTimePicker();
            this.Log_10 = new System.Windows.Forms.TextBox();
            this.Date_10 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.Log_9 = new System.Windows.Forms.TextBox();
            this.Date_9 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.Log_8 = new System.Windows.Forms.TextBox();
            this.Date_8 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.Log_7 = new System.Windows.Forms.TextBox();
            this.Date_7 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.Log_6 = new System.Windows.Forms.TextBox();
            this.Date_6 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Log_5 = new System.Windows.Forms.TextBox();
            this.Date_5 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Log_4 = new System.Windows.Forms.TextBox();
            this.Date_4 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Log_3 = new System.Windows.Forms.TextBox();
            this.Date_3 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Log_2 = new System.Windows.Forms.TextBox();
            this.Date_2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Log_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CSV_Data_DEL = new System.Windows.Forms.Button();
            this.Company_URI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.User_Note = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.group_status.SuspendLayout();
            this.group_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // List_Comp
            // 
            this.List_Comp.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.List_Comp.FormattingEnabled = true;
            this.List_Comp.ItemHeight = 28;
            this.List_Comp.Items.AddRange(new object[] {
            "(新規登録)"});
            this.List_Comp.Location = new System.Drawing.Point(12, 12);
            this.List_Comp.Margin = new System.Windows.Forms.Padding(2);
            this.List_Comp.Name = "List_Comp";
            this.List_Comp.Size = new System.Drawing.Size(176, 844);
            this.List_Comp.TabIndex = 0;
            this.List_Comp.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // CSV_Data_ADD
            // 
            this.CSV_Data_ADD.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CSV_Data_ADD.Location = new System.Drawing.Point(193, 830);
            this.CSV_Data_ADD.Margin = new System.Windows.Forms.Padding(2);
            this.CSV_Data_ADD.Name = "CSV_Data_ADD";
            this.CSV_Data_ADD.Size = new System.Drawing.Size(188, 42);
            this.CSV_Data_ADD.TabIndex = 1;
            this.CSV_Data_ADD.Text = "登録";
            this.CSV_Data_ADD.UseVisualStyleBackColor = true;
            this.CSV_Data_ADD.Click += new System.EventHandler(this.CSV_Data_ADD_Clicked);
            // 
            // Company_Name
            // 
            this.Company_Name.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Company_Name.Location = new System.Drawing.Point(322, 8);
            this.Company_Name.Margin = new System.Windows.Forms.Padding(2);
            this.Company_Name.Name = "Company_Name";
            this.Company_Name.Size = new System.Drawing.Size(586, 34);
            this.Company_Name.TabIndex = 2;
            // 
            // corp_name
            // 
            this.corp_name.AutoSize = true;
            this.corp_name.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.corp_name.Location = new System.Drawing.Point(221, 12);
            this.corp_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.corp_name.Name = "corp_name";
            this.corp_name.Size = new System.Drawing.Size(72, 28);
            this.corp_name.TabIndex = 3;
            this.corp_name.Text = "企業名";
            // 
            // service
            // 
            this.service.AutoSize = true;
            this.service.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.service.Location = new System.Drawing.Point(204, 53);
            this.service.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(110, 28);
            this.service.TabIndex = 5;
            this.service.Text = "利用サービス";
            // 
            // Service_Name
            // 
            this.Service_Name.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Service_Name.Location = new System.Drawing.Point(322, 50);
            this.Service_Name.Margin = new System.Windows.Forms.Padding(2);
            this.Service_Name.Name = "Service_Name";
            this.Service_Name.Size = new System.Drawing.Size(586, 34);
            this.Service_Name.TabIndex = 4;
            // 
            // Log_Doing
            // 
            this.Log_Doing.AutoSize = true;
            this.Log_Doing.Checked = true;
            this.Log_Doing.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Log_Doing.Location = new System.Drawing.Point(48, 31);
            this.Log_Doing.Margin = new System.Windows.Forms.Padding(2);
            this.Log_Doing.Name = "Log_Doing";
            this.Log_Doing.Size = new System.Drawing.Size(97, 32);
            this.Log_Doing.TabIndex = 6;
            this.Log_Doing.TabStop = true;
            this.Log_Doing.Text = "活動中";
            this.Log_Doing.UseVisualStyleBackColor = true;
            // 
            // Log_UnOfficial
            // 
            this.Log_UnOfficial.AutoSize = true;
            this.Log_UnOfficial.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Log_UnOfficial.Location = new System.Drawing.Point(290, 31);
            this.Log_UnOfficial.Margin = new System.Windows.Forms.Padding(2);
            this.Log_UnOfficial.Name = "Log_UnOfficial";
            this.Log_UnOfficial.Size = new System.Drawing.Size(117, 32);
            this.Log_UnOfficial.TabIndex = 7;
            this.Log_UnOfficial.TabStop = true;
            this.Log_UnOfficial.Text = "内定獲得";
            this.Log_UnOfficial.UseVisualStyleBackColor = true;
            // 
            // Log_Decline
            // 
            this.Log_Decline.AutoSize = true;
            this.Log_Decline.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Log_Decline.Location = new System.Drawing.Point(556, 31);
            this.Log_Decline.Margin = new System.Windows.Forms.Padding(2);
            this.Log_Decline.Name = "Log_Decline";
            this.Log_Decline.Size = new System.Drawing.Size(97, 32);
            this.Log_Decline.TabIndex = 8;
            this.Log_Decline.TabStop = true;
            this.Log_Decline.Text = "辞退等";
            this.Log_Decline.UseVisualStyleBackColor = true;
            // 
            // group_status
            // 
            this.group_status.Controls.Add(this.Log_Doing);
            this.group_status.Controls.Add(this.Log_Decline);
            this.group_status.Controls.Add(this.Log_UnOfficial);
            this.group_status.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.group_status.Location = new System.Drawing.Point(199, 132);
            this.group_status.Margin = new System.Windows.Forms.Padding(2);
            this.group_status.Name = "group_status";
            this.group_status.Padding = new System.Windows.Forms.Padding(2);
            this.group_status.Size = new System.Drawing.Size(708, 70);
            this.group_status.TabIndex = 9;
            this.group_status.TabStop = false;
            this.group_status.Text = "ステータス";
            // 
            // group_log
            // 
            this.group_log.Controls.Add(this.Date_1);
            this.group_log.Controls.Add(this.Log_10);
            this.group_log.Controls.Add(this.Date_10);
            this.group_log.Controls.Add(this.label12);
            this.group_log.Controls.Add(this.Log_9);
            this.group_log.Controls.Add(this.Date_9);
            this.group_log.Controls.Add(this.label11);
            this.group_log.Controls.Add(this.Log_8);
            this.group_log.Controls.Add(this.Date_8);
            this.group_log.Controls.Add(this.label10);
            this.group_log.Controls.Add(this.Log_7);
            this.group_log.Controls.Add(this.Date_7);
            this.group_log.Controls.Add(this.label9);
            this.group_log.Controls.Add(this.Log_6);
            this.group_log.Controls.Add(this.Date_6);
            this.group_log.Controls.Add(this.label8);
            this.group_log.Controls.Add(this.Log_5);
            this.group_log.Controls.Add(this.Date_5);
            this.group_log.Controls.Add(this.label7);
            this.group_log.Controls.Add(this.Log_4);
            this.group_log.Controls.Add(this.Date_4);
            this.group_log.Controls.Add(this.label6);
            this.group_log.Controls.Add(this.Log_3);
            this.group_log.Controls.Add(this.Date_3);
            this.group_log.Controls.Add(this.label5);
            this.group_log.Controls.Add(this.Log_2);
            this.group_log.Controls.Add(this.Date_2);
            this.group_log.Controls.Add(this.label4);
            this.group_log.Controls.Add(this.Log_1);
            this.group_log.Controls.Add(this.label3);
            this.group_log.Controls.Add(this.menuStrip1);
            this.group_log.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.group_log.Location = new System.Drawing.Point(199, 206);
            this.group_log.Margin = new System.Windows.Forms.Padding(2);
            this.group_log.Name = "group_log";
            this.group_log.Padding = new System.Windows.Forms.Padding(2);
            this.group_log.Size = new System.Drawing.Size(708, 454);
            this.group_log.TabIndex = 10;
            this.group_log.TabStop = false;
            this.group_log.Text = "活動履歴";
            // 
            // Date_1
            // 
            this.Date_1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Date_1.Location = new System.Drawing.Point(66, 34);
            this.Date_1.Margin = new System.Windows.Forms.Padding(2);
            this.Date_1.Name = "Date_1";
            this.Date_1.Size = new System.Drawing.Size(201, 34);
            this.Date_1.TabIndex = 37;
            // 
            // Log_10
            // 
            this.Log_10.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Log_10.Location = new System.Drawing.Point(272, 401);
            this.Log_10.Margin = new System.Windows.Forms.Padding(2);
            this.Log_10.Name = "Log_10";
            this.Log_10.Size = new System.Drawing.Size(426, 34);
            this.Log_10.TabIndex = 35;
            // 
            // Date_10
            // 
            this.Date_10.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Date_10.Location = new System.Drawing.Point(66, 401);
            this.Date_10.Margin = new System.Windows.Forms.Padding(2);
            this.Date_10.Name = "Date_10";
            this.Date_10.Size = new System.Drawing.Size(201, 34);
            this.Date_10.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(5, 410);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 25);
            this.label12.TabIndex = 33;
            this.label12.Text = "No.10";
            // 
            // Log_9
            // 
            this.Log_9.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Log_9.Location = new System.Drawing.Point(272, 360);
            this.Log_9.Margin = new System.Windows.Forms.Padding(2);
            this.Log_9.Name = "Log_9";
            this.Log_9.Size = new System.Drawing.Size(426, 34);
            this.Log_9.TabIndex = 32;
            // 
            // Date_9
            // 
            this.Date_9.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Date_9.Location = new System.Drawing.Point(66, 360);
            this.Date_9.Margin = new System.Windows.Forms.Padding(2);
            this.Date_9.Name = "Date_9";
            this.Date_9.Size = new System.Drawing.Size(201, 34);
            this.Date_9.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(5, 370);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "No.9";
            // 
            // Log_8
            // 
            this.Log_8.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Log_8.Location = new System.Drawing.Point(272, 319);
            this.Log_8.Margin = new System.Windows.Forms.Padding(2);
            this.Log_8.Name = "Log_8";
            this.Log_8.Size = new System.Drawing.Size(426, 34);
            this.Log_8.TabIndex = 29;
            // 
            // Date_8
            // 
            this.Date_8.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Date_8.Location = new System.Drawing.Point(66, 319);
            this.Date_8.Margin = new System.Windows.Forms.Padding(2);
            this.Date_8.Name = "Date_8";
            this.Date_8.Size = new System.Drawing.Size(201, 34);
            this.Date_8.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(5, 329);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "No.8";
            // 
            // Log_7
            // 
            this.Log_7.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Log_7.Location = new System.Drawing.Point(272, 278);
            this.Log_7.Margin = new System.Windows.Forms.Padding(2);
            this.Log_7.Name = "Log_7";
            this.Log_7.Size = new System.Drawing.Size(426, 34);
            this.Log_7.TabIndex = 26;
            // 
            // Date_7
            // 
            this.Date_7.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Date_7.Location = new System.Drawing.Point(66, 278);
            this.Date_7.Margin = new System.Windows.Forms.Padding(2);
            this.Date_7.Name = "Date_7";
            this.Date_7.Size = new System.Drawing.Size(201, 34);
            this.Date_7.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(5, 288);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "No.7";
            // 
            // Log_6
            // 
            this.Log_6.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Log_6.Location = new System.Drawing.Point(272, 238);
            this.Log_6.Margin = new System.Windows.Forms.Padding(2);
            this.Log_6.Name = "Log_6";
            this.Log_6.Size = new System.Drawing.Size(426, 34);
            this.Log_6.TabIndex = 23;
            // 
            // Date_6
            // 
            this.Date_6.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Date_6.Location = new System.Drawing.Point(66, 238);
            this.Date_6.Margin = new System.Windows.Forms.Padding(2);
            this.Date_6.Name = "Date_6";
            this.Date_6.Size = new System.Drawing.Size(201, 34);
            this.Date_6.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(5, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "No.6";
            // 
            // Log_5
            // 
            this.Log_5.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Log_5.Location = new System.Drawing.Point(272, 197);
            this.Log_5.Margin = new System.Windows.Forms.Padding(2);
            this.Log_5.Name = "Log_5";
            this.Log_5.Size = new System.Drawing.Size(426, 34);
            this.Log_5.TabIndex = 20;
            // 
            // Date_5
            // 
            this.Date_5.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Date_5.Location = new System.Drawing.Point(66, 197);
            this.Date_5.Margin = new System.Windows.Forms.Padding(2);
            this.Date_5.Name = "Date_5";
            this.Date_5.Size = new System.Drawing.Size(201, 34);
            this.Date_5.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(5, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "No.5";
            // 
            // Log_4
            // 
            this.Log_4.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Log_4.Location = new System.Drawing.Point(272, 156);
            this.Log_4.Margin = new System.Windows.Forms.Padding(2);
            this.Log_4.Name = "Log_4";
            this.Log_4.Size = new System.Drawing.Size(426, 34);
            this.Log_4.TabIndex = 17;
            // 
            // Date_4
            // 
            this.Date_4.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Date_4.Location = new System.Drawing.Point(66, 156);
            this.Date_4.Margin = new System.Windows.Forms.Padding(2);
            this.Date_4.Name = "Date_4";
            this.Date_4.Size = new System.Drawing.Size(201, 34);
            this.Date_4.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(5, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "No.4";
            // 
            // Log_3
            // 
            this.Log_3.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Log_3.Location = new System.Drawing.Point(272, 115);
            this.Log_3.Margin = new System.Windows.Forms.Padding(2);
            this.Log_3.Name = "Log_3";
            this.Log_3.Size = new System.Drawing.Size(426, 34);
            this.Log_3.TabIndex = 14;
            // 
            // Date_3
            // 
            this.Date_3.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Date_3.Location = new System.Drawing.Point(66, 115);
            this.Date_3.Margin = new System.Windows.Forms.Padding(2);
            this.Date_3.Name = "Date_3";
            this.Date_3.Size = new System.Drawing.Size(201, 34);
            this.Date_3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(5, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "No.3";
            // 
            // Log_2
            // 
            this.Log_2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Log_2.Location = new System.Drawing.Point(272, 74);
            this.Log_2.Margin = new System.Windows.Forms.Padding(2);
            this.Log_2.Name = "Log_2";
            this.Log_2.Size = new System.Drawing.Size(426, 34);
            this.Log_2.TabIndex = 11;
            // 
            // Date_2
            // 
            this.Date_2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Date_2.Location = new System.Drawing.Point(66, 74);
            this.Date_2.Margin = new System.Windows.Forms.Padding(2);
            this.Date_2.Name = "Date_2";
            this.Date_2.Size = new System.Drawing.Size(201, 34);
            this.Date_2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(5, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "No.2";
            // 
            // Log_1
            // 
            this.Log_1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Log_1.Location = new System.Drawing.Point(272, 34);
            this.Log_1.Margin = new System.Windows.Forms.Padding(2);
            this.Log_1.Name = "Log_1";
            this.Log_1.Size = new System.Drawing.Size(426, 34);
            this.Log_1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(5, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "No.1";
            // 
            // CSV_Data_DEL
            // 
            this.CSV_Data_DEL.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CSV_Data_DEL.Location = new System.Drawing.Point(720, 830);
            this.CSV_Data_DEL.Margin = new System.Windows.Forms.Padding(2);
            this.CSV_Data_DEL.Name = "CSV_Data_DEL";
            this.CSV_Data_DEL.Size = new System.Drawing.Size(188, 42);
            this.CSV_Data_DEL.TabIndex = 36;
            this.CSV_Data_DEL.Text = "クリア";
            this.CSV_Data_DEL.UseVisualStyleBackColor = true;
            this.CSV_Data_DEL.Click += new System.EventHandler(this.CSV_Data_DEL_Click);
            // 
            // Company_URI
            // 
            this.Company_URI.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Company_URI.Location = new System.Drawing.Point(322, 91);
            this.Company_URI.Margin = new System.Windows.Forms.Padding(2);
            this.Company_URI.Name = "Company_URI";
            this.Company_URI.Size = new System.Drawing.Size(586, 34);
            this.Company_URI.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(232, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 28);
            this.label1.TabIndex = 38;
            this.label1.Text = "URL";
            // 
            // User_Note
            // 
            this.User_Note.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.User_Note.Location = new System.Drawing.Point(199, 665);
            this.User_Note.Margin = new System.Windows.Forms.Padding(2);
            this.User_Note.Multiline = true;
            this.User_Note.Name = "User_Note";
            this.User_Note.Size = new System.Drawing.Size(708, 159);
            this.User_Note.TabIndex = 39;
            this.User_Note.Text = "メモ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(2, 29);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 32);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(918, 883);
            this.Controls.Add(this.User_Note);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Company_URI);
            this.Controls.Add(this.group_log);
            this.Controls.Add(this.CSV_Data_DEL);
            this.Controls.Add(this.group_status);
            this.Controls.Add(this.service);
            this.Controls.Add(this.Service_Name);
            this.Controls.Add(this.corp_name);
            this.Controls.Add(this.Company_Name);
            this.Controls.Add(this.List_Comp);
            this.Controls.Add(this.CSV_Data_ADD);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.group_status.ResumeLayout(false);
            this.group_status.PerformLayout();
            this.group_log.ResumeLayout(false);
            this.group_log.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox List_Comp;
        private System.Windows.Forms.Button CSV_Data_ADD;
        private System.Windows.Forms.TextBox Company_Name;
        private System.Windows.Forms.Label corp_name;
        private System.Windows.Forms.Label service;
        private System.Windows.Forms.TextBox Service_Name;
        private System.Windows.Forms.RadioButton Log_Doing;
        private System.Windows.Forms.RadioButton Log_UnOfficial;
        private System.Windows.Forms.RadioButton Log_Decline;
        private System.Windows.Forms.GroupBox group_status;
        private System.Windows.Forms.GroupBox group_log;
        private System.Windows.Forms.Button CSV_Data_DEL;
        private System.Windows.Forms.TextBox Log_10;
        private System.Windows.Forms.DateTimePicker Date_10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Log_9;
        private System.Windows.Forms.DateTimePicker Date_9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Log_8;
        private System.Windows.Forms.DateTimePicker Date_8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Log_7;
        private System.Windows.Forms.DateTimePicker Date_7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Log_6;
        private System.Windows.Forms.DateTimePicker Date_6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Log_5;
        private System.Windows.Forms.DateTimePicker Date_5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Log_4;
        private System.Windows.Forms.DateTimePicker Date_4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Log_3;
        private System.Windows.Forms.DateTimePicker Date_3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Log_2;
        private System.Windows.Forms.DateTimePicker Date_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Log_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Date_1;
        private System.Windows.Forms.TextBox Company_URI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox User_Note;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

