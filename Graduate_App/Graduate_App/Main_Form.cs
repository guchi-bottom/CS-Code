/* LICENSE INFORMATION
 * 
 * This source code has been written by a student of Hokkaido Information University.
 * The author is not responsible for any problems that may arise from the use of this software.
 *
 * Copyright (c) 2020 Yuuki Sakaguchi
 * Released under the MIT license.
 * https://opensource.org/licenses/mit-license.php
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Graduate_App
{
    public partial class Main_Form : Form
    {
        public static List<string> CSV_RECORD = new List<string>();
        List<Label> C_Labels = new List<Label>();
        List<Label> L_Labels = new List<Label>();
        List<DateTimePicker> L_Date = new List<DateTimePicker>();
        List<TextBox> L_Text = new List<TextBox>();
        public List<string> Operation_Contents = new List<string>();
        private int Selected_Index = 0;
        Panel C_P;
        Panel L_P;
        private Label Label;
        private DateTimePicker Dates;
        private new TextBox Text;
        public static int[] List_Len_Ins_Del;

        private CSV_Access CSV_ACCESS => new CSV_Access();

        public Main_Form()
        {
            C_P = Comp_Panel;
            L_P = Log_Panel;
            SetProcessDPIAware();
            InitializeComponent();
            Name = "就職活動履歴管理アプリケーション きゃりろぐ - Ver. 1.00";
            corp_name.Text = "企業名";
            service.Text = "利用サービス";
            group_status.Text = "活動状況";
            Log_Doing.Text = "活動中";
            Log_UnOfficial.Text = "内定取得";
            Log_Decline.Text = "辞退等";
            label2.Text = "メモ";
            CSV_Data_ADD.Text = "登録";
            CSV_Data_DEL.Text = "クリア";
            CSV_ACCESS.Load_ALL();
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                C_Labels.Add(Item_0);
                L_Labels.Add(L_Label_0);
                L_Date.Add(L_Date_0);
                L_Text.Add(L_Text_0);
                for (int line = 1; line < CSV_RECORD.Count; line++)
                {
                    Console.WriteLine("line: " + line);
                    List<string> CSV_DATA_LINE = CSV_ACCESS.Load_LINE(CSV_RECORD, line);
                    Add_Company_Name_Label(CSV_DATA_LINE[0], int.Parse(CSV_DATA_LINE[3]));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("CSVファイルが見つからないか、なんらかの問題が発生しているため、アプリケーションを終了します。"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                Close();
            }
        }
        private void CSV_Data_ADD_Clicked(object sender, EventArgs e)
        {
            if (Company_Name.Text == "" || Service_Name.Text == "" || L_Text[0].Text == "")
            {
                string Error_String = "";
                if (Company_Name.Text == "")
                    Error_String = "\"企業名\"";

                if (Service_Name.Text == "")
                {
                    if (Company_Name.Text == "")

                        Error_String += ", \"利用サービス名\"";
                    else
                        Error_String = "\"利用サービス名\"";
                }
                if (L_Text[0].Text == "")
                {
                    if (Company_Name.Text == "" || Service_Name.Text == "")
                        Error_String += ", \"活動履歴 No.1\"";
                    else
                        Error_String = "\"活動履歴 No.1\"";
                }
                MessageBox.Show(Error_String + "が入力されていません\n上記項目を入力し、もう一度\"" + CSV_Data_ADD.Text + "\"ボタンをクリックしてください。");
            }
            else
            {
                Operation_Contents.Clear();

                Operation_Contents.Add(Company_Name.Text);
                Operation_Contents.Add(Service_Name.Text);
                Operation_Contents.Add(Company_URI.Text);
                if (Log_Doing.Checked)
                {
                    Operation_Contents.Add("1");
                }
                else if (Log_UnOfficial.Checked)
                {
                    Operation_Contents.Add("2");
                }
                else if (Log_Decline.Checked)
                {
                    Operation_Contents.Add("3");
                }
                if (User_Note.Text.Contains(Environment.NewLine))
                {
                    Operation_Contents.Add(User_Note.Text.Replace(Environment.NewLine, " | "));
                }
                else
                {
                    if (User_Note.Text != "")
                        Operation_Contents.Add(User_Note.Text);
                    else
                        Operation_Contents.Add("---");
                }
                for (int i = 0; i < L_Text.Count; i++)
                    Operation_Contents.Add(L_Date[i].Value.ToShortDateString() + "-" + L_Text[i].Text);
                /*
                 * ここに企業活動履歴を入力
                 */
                if (Selected_Index == 0)
                {
                    CSV_RECORD.Add(string.Join(",", Operation_Contents));
                    CSV_ACCESS.Save_ALL(CSV_RECORD, false);
                    Add_Company_Name_Label(Operation_Contents[0], int.Parse(Operation_Contents[3]));
                    MessageBox.Show("新規登録が完了しました。\n企業名: " + Company_Name.Text, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Component_Reset();
                }
                else
                {
                    CSV_RECORD[Selected_Index] = string.Join(",", Operation_Contents);
                    CSV_ACCESS.Save_ALL(CSV_RECORD, false);
                    C_Labels[Selected_Index].Text = Operation_Contents[0];
                    MessageBox.Show("上書保存が完了しました。\n企業名: " + Company_Name.Text, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void CSV_Data_DEL_Click(object sender, EventArgs e)
        {
            DialogResult Ques = DialogResult.No;
            Ques = MessageBox.Show("情報を" + CSV_Data_DEL.Text + "します。\nよろしいですか?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Ques == DialogResult.Yes)
            {
                if (Selected_Index == 0)
                    Component_Reset();
                else
                {
                    for (int i = Selected_Index; i < Comp_Panel.Controls.Count - 1; i++)
                        C_Labels[i].Text = C_Labels[i + 1].Text;
                    Comp_Panel.Controls.Remove(C_Labels[Comp_Panel.Controls.Count - 1]);
                    CSV_RECORD.RemoveAt(Selected_Index);
                    CSV_ACCESS.Save_ALL(CSV_RECORD, false);
                }
                MessageBox.Show("情報を" + CSV_Data_DEL.Text + "しました。");
            }
        }
        public void Component_Reset()
        {
            Company_Name.Text = "";
            Service_Name.Text = "";
            Company_URI.Text = "";
            Log_Doing.Checked = true;
            User_Note.Text = "";
            L_Date[0].Value = DateTime.Now;
            L_Text[0].Text = "";
            if (L_Labels.Count != 1)
            {
                for (int i = L_Labels.Count - 1; i >= 1; i--)
                {
                    Console.WriteLine("For i: " + i);
                    Log_Panel.Controls.Remove(L_Labels[i]);
                    L_Labels.Remove(L_Labels[i]);
                    Log_Panel.Controls.Remove(L_Date[i]);
                    L_Date.Remove(L_Date[i]);
                    Log_Panel.Controls.Remove(L_Text[i]);
                    L_Text.Remove(L_Text[i]);
                }
            }
        }
        public void Add_Company_Name_Label(string comp_name, int Background_Color_No)
        {
            C_P = Comp_Panel;
            Label = new Label
            {
                Name = "Item_" + Comp_Panel.Controls.Count.ToString(),
                Text = comp_name,
                Location = new Point(0, 30 * Comp_Panel.Controls.Count),
                Size = new Size(180, 30),
                Font = new Font("Yu Gothic UI", 10.2f),
                AutoSize = false,
                AutoEllipsis = true
            };
            Label.Click += new EventHandler(Item_Clicked);
            Comp_Panel.Controls.Add(Label);
            Label_BackColor_Set(Label, Background_Color_No);
            C_Labels.Add(Label);
        }
        public void Label_BackColor_Set(Label Label, int Background_Color_No)
        {
            switch (Background_Color_No)
            {
                case 0:
                    Label.Font = new Font("Yu Gothic UI", 10.2f);
                    Label.ForeColor = Color.Black;
                    Label.BackColor = Color.Empty;
                    break;
                case 1:
                    Label.Font = new Font("Yu Gothic UI", 10.2f);
                    Label.ForeColor = Color.Black;
                    Label.BackColor = Color.YellowGreen;
                    break;
                case 2:
                    Label.Font = new Font("Yu Gothic UI", 10.2f);
                    Label.ForeColor = Color.Black;
                    Label.BackColor = Color.Yellow;
                    break;
                case 3:
                    Label.Font = new Font("Yu Gothic UI", 10.2f);
                    Label.ForeColor = Color.Black;
                    Label.BackColor = Color.Orange;
                    break;
                case 4:
                    Label.Font = new Font("Yu Gothic UI", 10.2f, FontStyle.Underline);
                    Label.ForeColor = Color.White;
                    Label.BackColor = Color.Blue;
                    break;
                default:
                    break;
            }
        }
        private void Sorting_Record_Click(object sender, EventArgs e)
        {
            /*
             * 
             * ソートは一回お休み
            Sub_Form sub = new Sub_Form();
            sub.ShowDialog(this);
            sub.Dispose();
            if (List_Len_Ins_Del[1] != -1)
            {
                string Insert_std = CSV_RECORD[List_Len_Ins_Del[2]];
                string Insert_com = .SelectedItem.ToString();
                CSV_RECORD.RemoveAt(List_Len_Ins_Del[2]);
                .Items.RemoveAt(List_Len_Ins_Del[2]);
                CSV_RECORD.Insert(List_Len_Ins_Del[1], Insert_std);
                .Items.Insert(List_Len_Ins_Del[1], Insert_com);
                Selected_Index = List_Len_Ins_Del[1];
                List_Len_Ins_Del[1] = -1;
                CSV_ACCESS.Save_ALL(CSV_RECORD, false);
            }*/
        }
        private void Item_Clicked(object sender, EventArgs e)
        {
            if (Selected_Index != int.Parse(((Label)sender).Name.Substring(5)))
            {
                if (Selected_Index == 0)
                    Label_BackColor_Set(C_Labels[Selected_Index], 0);
                else
                    Label_BackColor_Set(C_Labels[Selected_Index]
                        , int.Parse(Operation_Contents[3]));
                Component_Reset();
                Selected_Index = int.Parse(((Label)sender).Name.Substring(5));
                Label_BackColor_Set((Label)sender, 4);
                //データロードしてね
                if (Selected_Index == 0)
                {
                    CSV_Data_ADD.Text = "登録";
                    CSV_Data_DEL.Text = "クリア";
                }
                else
                {
                    CSV_Data_ADD.Text = "上書保存";
                    CSV_Data_DEL.Text = "削除";
                    Operation_Contents = CSV_ACCESS.Load_LINE(CSV_RECORD, Selected_Index);
                    Company_Name.Text = Operation_Contents[0];
                    Service_Name.Text = Operation_Contents[1];
                    Company_URI.Text = Operation_Contents[2];
                    switch (Operation_Contents[3])
                    {
                        case "1":
                            Log_Doing.Checked = true;
                            break;
                        case "2":
                            Log_UnOfficial.Checked = true;
                            break;
                        case "3":
                            Log_Decline.Checked = true;
                            break;
                        default:
                            Log_Doing.Checked = true;
                            break;
                    }
                    if (Operation_Contents.Count >= 5)
                    {
                        if (Operation_Contents[4] == "---" || Operation_Contents[4] == "")
                            Operation_Contents[4] = "";
                        else if (Operation_Contents[4].Contains(" | "))
                            Operation_Contents[4] = Operation_Contents[4].Replace(" | ", Environment.NewLine);
                        User_Note.Text = Operation_Contents[4];
                        if (Operation_Contents.Count >= 6)
                        {
                            string[] Log_Code = Operation_Contents[5].Split('-');
                            Console.WriteLine(Log_Code[0]);
                            L_Date[0].Value = DateTime.Parse(Log_Code[0] + " 00:00:00");

                            //dateTimePicker1.Value.ToShortDateString();
                            L_Text[0].Text = Log_Code[1];
                            for (int i = 6; i < Operation_Contents.Count; i++)
                            {
                                Log_Code = Operation_Contents[i].Split('-');
                                if(Log_Code[1] != "")
                                {
                                Log_Items_Add();
                                Console.WriteLine("Debug: " + Operation_Contents[i]);
                                Console.WriteLine("Log_Code: " + Log_Code[0]);
                                L_Date[i - 5].Value = DateTime.Parse(Log_Code[0]);
                                L_Text[i - 5].Text = Log_Code[1];
                                }
                            }
                        }
                    }
                }
            }
        }
        private void L_Text_Leave(object sender, EventArgs e)
        {
            //最初の１個目以外適応に修正
            //l_Textでアクセス(カウント)
            if (L_Text.Count != 1)
            {
                if (L_Text_No_entry(L_Text[L_Text.Count - 1]) == true)
                    Log_Items_Delete();
            }
        }
        private bool L_Text_No_entry(TextBox text)
        {
            if (text.Text == "")
                return true;
            else
                return false;
        }
        private void L_Text_TextChanged(object sender, EventArgs e)
        {
            if (L_Text_No_entry((TextBox)sender) == false && ((TextBox)sender).Name == L_Text[L_Text.Count - 1].Name)
                Log_Items_Add();
        }
        private void Log_Items_Add()
        {
            L_P = Log_Panel;
            Label = new Label
            {
                Name = "L_Label_" + L_Labels.Count,
                Text = "No." + (L_Labels.Count + 1),
                Location = new Point(2, L_Labels[L_Labels.Count - 1].Location.Y + 40),
                Size = new Size(50, 25),
                Font = new Font("Yu Gothic UI", 9),
                AutoSize = true
            };
            L_P.Controls.Add(Label);
            L_Labels.Add(Label);

            Dates = new DateTimePicker
            {
                Name = "L_Date_" + L_Date.Count,
                Location = new Point(64, L_Date[L_Date.Count - 1].Location.Y + 40),
                Size = new Size(155, 34),
                Font = new Font("Yu Gothic UI", 10.2f),
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "yyyy/MM/dd"
            };
            L_P.Controls.Add(Dates);
            L_Date.Add(Dates);

            Text = new TextBox
            {
                Name = "L_Text_" + L_Text.Count,
                Location = new Point(224, L_Text[L_Text.Count - 1].Location.Y + 40),
                Size = new Size(443, 34),
                Font = new Font("Yu Gothic UI", 10.2f)
            };
            Text.TextChanged += new EventHandler(L_Text_TextChanged);
            L_P.Controls.Add(Text);
            L_Text.Add(Text);
            for (int i = L_Text.Count - 1; i < L_Text.Count; i++)
                Console.WriteLine(i + ": " + L_Text[i].Location);
        }
        private void Log_Items_Delete()
        {
            L_P.Controls.Remove(L_Labels[L_Labels.Count - 1]);
            L_Labels.Remove(L_Labels[L_Labels.Count - 1]);

            L_P.Controls.Remove(L_Date[L_Date.Count - 1]);
            L_Date.Remove(L_Date[L_Date.Count - 1]);

            L_P.Controls.Remove(L_Text[L_Text.Count - 1]);
            L_Text.Remove(L_Text[L_Text.Count - 1]);
        }
    }
}