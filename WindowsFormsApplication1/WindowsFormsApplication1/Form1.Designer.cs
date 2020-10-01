namespace WindowsFormsApplication1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.data_add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.corp_name = new System.Windows.Forms.Label();
            this.service = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.log_doing = new System.Windows.Forms.RadioButton();
            this.log_unofficial = new System.Windows.Forms.RadioButton();
            this.log_decline = new System.Windows.Forms.RadioButton();
            this.group_status = new System.Windows.Forms.GroupBox();
            this.group_log = new System.Windows.Forms.GroupBox();
            this.data_del = new System.Windows.Forms.Button();
            this.log_10th = new System.Windows.Forms.TextBox();
            this.date_10th = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.log_9th = new System.Windows.Forms.TextBox();
            this.date_9th = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.log_8th = new System.Windows.Forms.TextBox();
            this.date_8th = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.log_7th = new System.Windows.Forms.TextBox();
            this.date_7th = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.log_6th = new System.Windows.Forms.TextBox();
            this.date_6th = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.log_5th = new System.Windows.Forms.TextBox();
            this.date_5th = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.log_4th = new System.Windows.Forms.TextBox();
            this.date_4th = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.log_3rd = new System.Windows.Forms.TextBox();
            this.date_3rd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.log_2nd = new System.Windows.Forms.TextBox();
            this.date_2nd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.log_1st = new System.Windows.Forms.TextBox();
            this.date_1st = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.group_status.SuspendLayout();
            this.group_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "(新規登録)"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 508);
            this.listBox1.TabIndex = 0;
            // 
            // data_add
            // 
            this.data_add.Location = new System.Drawing.Point(6, 340);
            this.data_add.Name = "data_add";
            this.data_add.Size = new System.Drawing.Size(187, 29);
            this.data_add.TabIndex = 1;
            this.data_add.Text = "登録";
            this.data_add.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(586, 25);
            this.textBox1.TabIndex = 2;
            // 
            // corp_name
            // 
            this.corp_name.AutoSize = true;
            this.corp_name.Location = new System.Drawing.Point(217, 12);
            this.corp_name.Name = "corp_name";
            this.corp_name.Size = new System.Drawing.Size(62, 18);
            this.corp_name.TabIndex = 3;
            this.corp_name.Text = "企業名";
            // 
            // service
            // 
            this.service.AutoSize = true;
            this.service.Location = new System.Drawing.Point(195, 43);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(101, 18);
            this.service.TabIndex = 5;
            this.service.Text = "利用サービス";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(321, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(586, 25);
            this.textBox2.TabIndex = 4;
            // 
            // log_doing
            // 
            this.log_doing.AutoSize = true;
            this.log_doing.Location = new System.Drawing.Point(6, 24);
            this.log_doing.Name = "log_doing";
            this.log_doing.Size = new System.Drawing.Size(87, 22);
            this.log_doing.TabIndex = 6;
            this.log_doing.TabStop = true;
            this.log_doing.Text = "活動中";
            this.log_doing.UseVisualStyleBackColor = true;
            // 
            // log_unofficial
            // 
            this.log_unofficial.AutoSize = true;
            this.log_unofficial.Location = new System.Drawing.Point(239, 24);
            this.log_unofficial.Name = "log_unofficial";
            this.log_unofficial.Size = new System.Drawing.Size(105, 22);
            this.log_unofficial.TabIndex = 7;
            this.log_unofficial.TabStop = true;
            this.log_unofficial.Text = "内定獲得";
            this.log_unofficial.UseVisualStyleBackColor = true;
            // 
            // log_decline
            // 
            this.log_decline.AutoSize = true;
            this.log_decline.Location = new System.Drawing.Point(496, 24);
            this.log_decline.Name = "log_decline";
            this.log_decline.Size = new System.Drawing.Size(87, 22);
            this.log_decline.TabIndex = 8;
            this.log_decline.TabStop = true;
            this.log_decline.Text = "辞退等";
            this.log_decline.UseVisualStyleBackColor = true;
            // 
            // group_status
            // 
            this.group_status.Controls.Add(this.log_doing);
            this.group_status.Controls.Add(this.log_decline);
            this.group_status.Controls.Add(this.log_unofficial);
            this.group_status.Location = new System.Drawing.Point(198, 71);
            this.group_status.Name = "group_status";
            this.group_status.Size = new System.Drawing.Size(709, 55);
            this.group_status.TabIndex = 9;
            this.group_status.TabStop = false;
            this.group_status.Text = "ステータス";
            // 
            // group_log
            // 
            this.group_log.Controls.Add(this.data_del);
            this.group_log.Controls.Add(this.log_10th);
            this.group_log.Controls.Add(this.date_10th);
            this.group_log.Controls.Add(this.label12);
            this.group_log.Controls.Add(this.log_9th);
            this.group_log.Controls.Add(this.date_9th);
            this.group_log.Controls.Add(this.label11);
            this.group_log.Controls.Add(this.data_add);
            this.group_log.Controls.Add(this.log_8th);
            this.group_log.Controls.Add(this.date_8th);
            this.group_log.Controls.Add(this.label10);
            this.group_log.Controls.Add(this.log_7th);
            this.group_log.Controls.Add(this.date_7th);
            this.group_log.Controls.Add(this.label9);
            this.group_log.Controls.Add(this.log_6th);
            this.group_log.Controls.Add(this.date_6th);
            this.group_log.Controls.Add(this.label8);
            this.group_log.Controls.Add(this.log_5th);
            this.group_log.Controls.Add(this.date_5th);
            this.group_log.Controls.Add(this.label7);
            this.group_log.Controls.Add(this.log_4th);
            this.group_log.Controls.Add(this.date_4th);
            this.group_log.Controls.Add(this.label6);
            this.group_log.Controls.Add(this.log_3rd);
            this.group_log.Controls.Add(this.date_3rd);
            this.group_log.Controls.Add(this.label5);
            this.group_log.Controls.Add(this.log_2nd);
            this.group_log.Controls.Add(this.date_2nd);
            this.group_log.Controls.Add(this.label4);
            this.group_log.Controls.Add(this.log_1st);
            this.group_log.Controls.Add(this.date_1st);
            this.group_log.Controls.Add(this.label3);
            this.group_log.Location = new System.Drawing.Point(198, 133);
            this.group_log.Name = "group_log";
            this.group_log.Size = new System.Drawing.Size(709, 382);
            this.group_log.TabIndex = 10;
            this.group_log.TabStop = false;
            this.group_log.Text = "活動履歴";
            // 
            // data_del
            // 
            this.data_del.Location = new System.Drawing.Point(510, 340);
            this.data_del.Name = "data_del";
            this.data_del.Size = new System.Drawing.Size(187, 29);
            this.data_del.TabIndex = 36;
            this.data_del.Text = "クリア";
            this.data_del.UseVisualStyleBackColor = true;
            // 
            // log_10th
            // 
            this.log_10th.Location = new System.Drawing.Point(271, 304);
            this.log_10th.Name = "log_10th";
            this.log_10th.Size = new System.Drawing.Size(426, 25);
            this.log_10th.TabIndex = 35;
            // 
            // date_10th
            // 
            this.date_10th.Location = new System.Drawing.Point(65, 304);
            this.date_10th.Name = "date_10th";
            this.date_10th.Size = new System.Drawing.Size(200, 25);
            this.date_10th.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "No.10";
            // 
            // log_9th
            // 
            this.log_9th.Location = new System.Drawing.Point(271, 273);
            this.log_9th.Name = "log_9th";
            this.log_9th.Size = new System.Drawing.Size(426, 25);
            this.log_9th.TabIndex = 32;
            // 
            // date_9th
            // 
            this.date_9th.Location = new System.Drawing.Point(65, 273);
            this.date_9th.Name = "date_9th";
            this.date_9th.Size = new System.Drawing.Size(200, 25);
            this.date_9th.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "No.9";
            // 
            // log_8th
            // 
            this.log_8th.Location = new System.Drawing.Point(271, 242);
            this.log_8th.Name = "log_8th";
            this.log_8th.Size = new System.Drawing.Size(426, 25);
            this.log_8th.TabIndex = 29;
            // 
            // date_8th
            // 
            this.date_8th.Location = new System.Drawing.Point(65, 242);
            this.date_8th.Name = "date_8th";
            this.date_8th.Size = new System.Drawing.Size(200, 25);
            this.date_8th.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "No.8";
            // 
            // log_7th
            // 
            this.log_7th.Location = new System.Drawing.Point(271, 211);
            this.log_7th.Name = "log_7th";
            this.log_7th.Size = new System.Drawing.Size(426, 25);
            this.log_7th.TabIndex = 26;
            // 
            // date_7th
            // 
            this.date_7th.Location = new System.Drawing.Point(65, 211);
            this.date_7th.Name = "date_7th";
            this.date_7th.Size = new System.Drawing.Size(200, 25);
            this.date_7th.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "No.7";
            // 
            // log_6th
            // 
            this.log_6th.Location = new System.Drawing.Point(271, 180);
            this.log_6th.Name = "log_6th";
            this.log_6th.Size = new System.Drawing.Size(426, 25);
            this.log_6th.TabIndex = 23;
            // 
            // date_6th
            // 
            this.date_6th.Location = new System.Drawing.Point(65, 180);
            this.date_6th.Name = "date_6th";
            this.date_6th.Size = new System.Drawing.Size(200, 25);
            this.date_6th.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "No.6";
            // 
            // log_5th
            // 
            this.log_5th.Location = new System.Drawing.Point(271, 149);
            this.log_5th.Name = "log_5th";
            this.log_5th.Size = new System.Drawing.Size(426, 25);
            this.log_5th.TabIndex = 20;
            // 
            // date_5th
            // 
            this.date_5th.Location = new System.Drawing.Point(65, 149);
            this.date_5th.Name = "date_5th";
            this.date_5th.Size = new System.Drawing.Size(200, 25);
            this.date_5th.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "No.5";
            // 
            // log_4th
            // 
            this.log_4th.Location = new System.Drawing.Point(271, 118);
            this.log_4th.Name = "log_4th";
            this.log_4th.Size = new System.Drawing.Size(426, 25);
            this.log_4th.TabIndex = 17;
            // 
            // date_4th
            // 
            this.date_4th.Location = new System.Drawing.Point(65, 118);
            this.date_4th.Name = "date_4th";
            this.date_4th.Size = new System.Drawing.Size(200, 25);
            this.date_4th.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "No.4";
            // 
            // log_3rd
            // 
            this.log_3rd.Location = new System.Drawing.Point(271, 87);
            this.log_3rd.Name = "log_3rd";
            this.log_3rd.Size = new System.Drawing.Size(426, 25);
            this.log_3rd.TabIndex = 14;
            // 
            // date_3rd
            // 
            this.date_3rd.Location = new System.Drawing.Point(65, 87);
            this.date_3rd.Name = "date_3rd";
            this.date_3rd.Size = new System.Drawing.Size(200, 25);
            this.date_3rd.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "No.3";
            // 
            // log_2nd
            // 
            this.log_2nd.Location = new System.Drawing.Point(271, 56);
            this.log_2nd.Name = "log_2nd";
            this.log_2nd.Size = new System.Drawing.Size(426, 25);
            this.log_2nd.TabIndex = 11;
            // 
            // date_2nd
            // 
            this.date_2nd.Location = new System.Drawing.Point(65, 56);
            this.date_2nd.Name = "date_2nd";
            this.date_2nd.Size = new System.Drawing.Size(200, 25);
            this.date_2nd.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "No.2";
            // 
            // log_1st
            // 
            this.log_1st.Location = new System.Drawing.Point(271, 25);
            this.log_1st.Name = "log_1st";
            this.log_1st.Size = new System.Drawing.Size(426, 25);
            this.log_1st.TabIndex = 8;
            // 
            // date_1st
            // 
            this.date_1st.Location = new System.Drawing.Point(65, 25);
            this.date_1st.Name = "date_1st";
            this.date_1st.Size = new System.Drawing.Size(200, 25);
            this.date_1st.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "No.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 531);
            this.Controls.Add(this.group_log);
            this.Controls.Add(this.group_status);
            this.Controls.Add(this.service);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.corp_name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
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

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button data_add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label corp_name;
        private System.Windows.Forms.Label service;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton log_doing;
        private System.Windows.Forms.RadioButton log_unofficial;
        private System.Windows.Forms.RadioButton log_decline;
        private System.Windows.Forms.GroupBox group_status;
        private System.Windows.Forms.GroupBox group_log;
        private System.Windows.Forms.Button data_del;
        private System.Windows.Forms.TextBox log_10th;
        private System.Windows.Forms.DateTimePicker date_10th;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox log_9th;
        private System.Windows.Forms.DateTimePicker date_9th;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox log_8th;
        private System.Windows.Forms.DateTimePicker date_8th;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox log_7th;
        private System.Windows.Forms.DateTimePicker date_7th;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox log_6th;
        private System.Windows.Forms.DateTimePicker date_6th;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox log_5th;
        private System.Windows.Forms.DateTimePicker date_5th;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox log_4th;
        private System.Windows.Forms.DateTimePicker date_4th;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox log_3rd;
        private System.Windows.Forms.DateTimePicker date_3rd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox log_2nd;
        private System.Windows.Forms.DateTimePicker date_2nd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox log_1st;
        private System.Windows.Forms.DateTimePicker date_1st;
        private System.Windows.Forms.Label label3;
    }
}

