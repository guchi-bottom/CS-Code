namespace Graduate_App
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
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
            this.label2 = new System.Windows.Forms.Label();
            this.Record_Sorting = new System.Windows.Forms.Button();
            this.group_status.SuspendLayout();
            this.group_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // List_Comp
            // 
            resources.ApplyResources(this.List_Comp, "List_Comp");
            this.List_Comp.FormattingEnabled = true;
            this.List_Comp.Name = "List_Comp";
            this.List_Comp.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // CSV_Data_ADD
            // 
            resources.ApplyResources(this.CSV_Data_ADD, "CSV_Data_ADD");
            this.CSV_Data_ADD.Name = "CSV_Data_ADD";
            this.CSV_Data_ADD.UseVisualStyleBackColor = true;
            this.CSV_Data_ADD.Click += new System.EventHandler(this.CSV_Data_ADD_Clicked);
            // 
            // Company_Name
            // 
            resources.ApplyResources(this.Company_Name, "Company_Name");
            this.Company_Name.Name = "Company_Name";
            // 
            // corp_name
            // 
            resources.ApplyResources(this.corp_name, "corp_name");
            this.corp_name.Name = "corp_name";
            // 
            // service
            // 
            resources.ApplyResources(this.service, "service");
            this.service.Name = "service";
            // 
            // Service_Name
            // 
            resources.ApplyResources(this.Service_Name, "Service_Name");
            this.Service_Name.Name = "Service_Name";
            // 
            // Log_Doing
            // 
            resources.ApplyResources(this.Log_Doing, "Log_Doing");
            this.Log_Doing.Checked = true;
            this.Log_Doing.Name = "Log_Doing";
            this.Log_Doing.TabStop = true;
            this.Log_Doing.UseVisualStyleBackColor = true;
            // 
            // Log_UnOfficial
            // 
            resources.ApplyResources(this.Log_UnOfficial, "Log_UnOfficial");
            this.Log_UnOfficial.Name = "Log_UnOfficial";
            this.Log_UnOfficial.TabStop = true;
            this.Log_UnOfficial.UseVisualStyleBackColor = true;
            // 
            // Log_Decline
            // 
            resources.ApplyResources(this.Log_Decline, "Log_Decline");
            this.Log_Decline.Name = "Log_Decline";
            this.Log_Decline.TabStop = true;
            this.Log_Decline.UseVisualStyleBackColor = true;
            // 
            // group_status
            // 
            this.group_status.Controls.Add(this.Log_Doing);
            this.group_status.Controls.Add(this.Log_Decline);
            this.group_status.Controls.Add(this.Log_UnOfficial);
            resources.ApplyResources(this.group_status, "group_status");
            this.group_status.Name = "group_status";
            this.group_status.TabStop = false;
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
            resources.ApplyResources(this.group_log, "group_log");
            this.group_log.Name = "group_log";
            this.group_log.TabStop = false;
            // 
            // Date_1
            // 
            resources.ApplyResources(this.Date_1, "Date_1");
            this.Date_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_1.Name = "Date_1";
            // 
            // Log_10
            // 
            resources.ApplyResources(this.Log_10, "Log_10");
            this.Log_10.Name = "Log_10";
            // 
            // Date_10
            // 
            resources.ApplyResources(this.Date_10, "Date_10");
            this.Date_10.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_10.Name = "Date_10";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // Log_9
            // 
            resources.ApplyResources(this.Log_9, "Log_9");
            this.Log_9.Name = "Log_9";
            // 
            // Date_9
            // 
            resources.ApplyResources(this.Date_9, "Date_9");
            this.Date_9.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_9.Name = "Date_9";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // Log_8
            // 
            resources.ApplyResources(this.Log_8, "Log_8");
            this.Log_8.Name = "Log_8";
            // 
            // Date_8
            // 
            resources.ApplyResources(this.Date_8, "Date_8");
            this.Date_8.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_8.Name = "Date_8";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // Log_7
            // 
            resources.ApplyResources(this.Log_7, "Log_7");
            this.Log_7.Name = "Log_7";
            // 
            // Date_7
            // 
            resources.ApplyResources(this.Date_7, "Date_7");
            this.Date_7.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_7.Name = "Date_7";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // Log_6
            // 
            resources.ApplyResources(this.Log_6, "Log_6");
            this.Log_6.Name = "Log_6";
            // 
            // Date_6
            // 
            resources.ApplyResources(this.Date_6, "Date_6");
            this.Date_6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_6.Name = "Date_6";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // Log_5
            // 
            resources.ApplyResources(this.Log_5, "Log_5");
            this.Log_5.Name = "Log_5";
            // 
            // Date_5
            // 
            resources.ApplyResources(this.Date_5, "Date_5");
            this.Date_5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_5.Name = "Date_5";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // Log_4
            // 
            resources.ApplyResources(this.Log_4, "Log_4");
            this.Log_4.Name = "Log_4";
            // 
            // Date_4
            // 
            resources.ApplyResources(this.Date_4, "Date_4");
            this.Date_4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_4.Name = "Date_4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // Log_3
            // 
            resources.ApplyResources(this.Log_3, "Log_3");
            this.Log_3.Name = "Log_3";
            // 
            // Date_3
            // 
            resources.ApplyResources(this.Date_3, "Date_3");
            this.Date_3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_3.Name = "Date_3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // Log_2
            // 
            resources.ApplyResources(this.Log_2, "Log_2");
            this.Log_2.Name = "Log_2";
            // 
            // Date_2
            // 
            resources.ApplyResources(this.Date_2, "Date_2");
            this.Date_2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_2.Name = "Date_2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Log_1
            // 
            resources.ApplyResources(this.Log_1, "Log_1");
            this.Log_1.Name = "Log_1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // CSV_Data_DEL
            // 
            resources.ApplyResources(this.CSV_Data_DEL, "CSV_Data_DEL");
            this.CSV_Data_DEL.Name = "CSV_Data_DEL";
            this.CSV_Data_DEL.UseVisualStyleBackColor = true;
            this.CSV_Data_DEL.Click += new System.EventHandler(this.CSV_Data_DEL_Click);
            // 
            // Company_URI
            // 
            resources.ApplyResources(this.Company_URI, "Company_URI");
            this.Company_URI.Name = "Company_URI";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // User_Note
            // 
            resources.ApplyResources(this.User_Note, "User_Note");
            this.User_Note.Name = "User_Note";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Record_Sorting
            // 
            resources.ApplyResources(this.Record_Sorting, "Record_Sorting");
            this.Record_Sorting.Name = "Record_Sorting";
            this.Record_Sorting.UseVisualStyleBackColor = true;
            this.Record_Sorting.Click += new System.EventHandler(this.Sorting_Record_Click);
            // 
            // Main_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.Record_Sorting);
            this.Controls.Add(this.label2);
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
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.group_status.ResumeLayout(false);
            this.group_status.PerformLayout();
            this.group_log.ResumeLayout(false);
            this.group_log.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Record_Sorting;
        internal System.Windows.Forms.ListBox List_Comp;
    }
}

