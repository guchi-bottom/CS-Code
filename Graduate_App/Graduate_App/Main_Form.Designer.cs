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
            this.CSV_Data_ADD = new System.Windows.Forms.Button();
            this.Company_Name = new System.Windows.Forms.TextBox();
            this.corp_name = new System.Windows.Forms.Label();
            this.service = new System.Windows.Forms.Label();
            this.Service_Name = new System.Windows.Forms.TextBox();
            this.Log_Doing = new System.Windows.Forms.RadioButton();
            this.Log_UnOfficial = new System.Windows.Forms.RadioButton();
            this.Log_Decline = new System.Windows.Forms.RadioButton();
            this.group_status = new System.Windows.Forms.GroupBox();
            this.L_Date_0 = new System.Windows.Forms.DateTimePicker();
            this.L_Text_0 = new System.Windows.Forms.TextBox();
            this.L_Label_0 = new System.Windows.Forms.Label();
            this.CSV_Data_DEL = new System.Windows.Forms.Button();
            this.Company_URI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.User_Note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Record_Sorting = new System.Windows.Forms.Button();
            this.Comp_Panel = new System.Windows.Forms.Panel();
            this.Item_0 = new System.Windows.Forms.Label();
            this.Log_Panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.group_status.SuspendLayout();
            this.Comp_Panel.SuspendLayout();
            this.Log_Panel.SuspendLayout();
            this.SuspendLayout();
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
            // L_Date_0
            // 
            resources.ApplyResources(this.L_Date_0, "L_Date_0");
            this.L_Date_0.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.L_Date_0.Name = "L_Date_0";
            // 
            // L_Text_0
            // 
            resources.ApplyResources(this.L_Text_0, "L_Text_0");
            this.L_Text_0.Name = "L_Text_0";
            this.L_Text_0.TextChanged += new System.EventHandler(this.L_Text_TextChanged);
            this.L_Text_0.Leave += new System.EventHandler(this.L_Text_Leave);
            // 
            // L_Label_0
            // 
            resources.ApplyResources(this.L_Label_0, "L_Label_0");
            this.L_Label_0.Name = "L_Label_0";
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
            // Comp_Panel
            // 
            resources.ApplyResources(this.Comp_Panel, "Comp_Panel");
            this.Comp_Panel.Controls.Add(this.Item_0);
            this.Comp_Panel.Name = "Comp_Panel";
            // 
            // Item_0
            // 
            this.Item_0.BackColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.Item_0, "Item_0");
            this.Item_0.ForeColor = System.Drawing.Color.White;
            this.Item_0.Name = "Item_0";
            this.Item_0.Click += new System.EventHandler(this.Item_Clicked);
            // 
            // Log_Panel
            // 
            this.Log_Panel.Controls.Add(this.label4);
            this.Log_Panel.Controls.Add(this.L_Date_0);
            this.Log_Panel.Controls.Add(this.L_Label_0);
            this.Log_Panel.Controls.Add(this.L_Text_0);
            resources.ApplyResources(this.Log_Panel, "Log_Panel");
            this.Log_Panel.Name = "Log_Panel";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Main_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.Log_Panel);
            this.Controls.Add(this.Comp_Panel);
            this.Controls.Add(this.corp_name);
            this.Controls.Add(this.Record_Sorting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.User_Note);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Company_URI);
            this.Controls.Add(this.CSV_Data_DEL);
            this.Controls.Add(this.group_status);
            this.Controls.Add(this.service);
            this.Controls.Add(this.Service_Name);
            this.Controls.Add(this.Company_Name);
            this.Controls.Add(this.CSV_Data_ADD);
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.group_status.ResumeLayout(false);
            this.group_status.PerformLayout();
            this.Comp_Panel.ResumeLayout(false);
            this.Log_Panel.ResumeLayout(false);
            this.Log_Panel.PerformLayout();
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
        private System.Windows.Forms.Button CSV_Data_DEL;
        private System.Windows.Forms.TextBox L_Text_0;
        private System.Windows.Forms.Label L_Label_0;
        private System.Windows.Forms.DateTimePicker L_Date_0;
        private System.Windows.Forms.TextBox Company_URI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox User_Note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Record_Sorting;
        private System.Windows.Forms.Panel Comp_Panel;
        private System.Windows.Forms.Label Item_0;
        private System.Windows.Forms.Panel Log_Panel;
        private System.Windows.Forms.Label label4;
    }
}

