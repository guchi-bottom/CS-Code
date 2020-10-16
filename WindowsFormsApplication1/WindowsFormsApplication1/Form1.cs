﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Graduate_App
{
    public partial class Form1 : Form
    {
        static public string[] CSV_SAVE_DATA;
        DateTimePicker[] Date_Portal = new DateTimePicker[10];
        TextBox[] Log_Portal = new TextBox[10];
        CSV_Access CSV = new CSV_Access();
        public Form1()
        {
            SetProcessDPIAware();
            InitializeComponent();
            CSV.Load_ALL();
            Date_Portal[0] = Date_1;
            Date_Portal[1] = Date_2;
            Date_Portal[2] = Date_3;
            Date_Portal[3] = Date_4;
            Date_Portal[4] = Date_5;
            Date_Portal[5] = Date_6;
            Date_Portal[6] = Date_7;
            Date_Portal[7] = Date_8;
            Date_Portal[8] = Date_9;
            Date_Portal[9] = Date_10;
            Log_Portal[0] = Log_1;
            Log_Portal[1] = Log_2;
            Log_Portal[2] = Log_3;
            Log_Portal[3] = Log_4;
            Log_Portal[4] = Log_5;
            Log_Portal[5] = Log_6;
            Log_Portal[6] = Log_7;
            Log_Portal[7] = Log_8;
            Log_Portal[8] = Log_9;
            Log_Portal[9] = Log_10;
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List_Comp.SelectedIndex = 0;
                if (CSV_SAVE_DATA.Length != 1)
                {
                    Add_List();
                }
            }
            catch (NullReferenceException)
            {
                // DEBUG
                Close();
            }
            catch (Exception neko)
            {
                MessageBox.Show(MethodBase.GetCurrentMethod().Name + "\n" + neko.ToString());
                Close();
            }
        }
        private void CSV_Data_ADD_Clicked(object sender, EventArgs e)
        {
            try
            {
                string[] New_Contents = new string[26];
                New_Contents[1] = Company_Name.Text;
                New_Contents[2] = Service_Name.Text;
                New_Contents[3] = Company_URI.Text;
                if (Log_Doing.Checked)
                    New_Contents[4] = "1";
                else if (Log_UnOfficial.Checked)
                    New_Contents[4] = "2";
                else if (Log_Decline.Checked)
                    New_Contents[4] = "3";
                int Contents_Index = 5;
                for (int index = 0; index < 10; index++)
                {
                    if (Log_Portal[index].Text != "")
                    {
                        New_Contents[Contents_Index] = (Date_Portal[index].Value.ToShortDateString());
                        New_Contents[Contents_Index + 1] = Log_Portal[index].Text;
                    }
                    Contents_Index = Contents_Index + 2;
                }
                if (User_Note.Text.Contains(Environment.NewLine))
                    New_Contents[25] = User_Note.Text.Replace(Environment.NewLine, "   ");
                else
                    New_Contents[25] = User_Note.Text;
                if (Company_Name.Text == "" || Service_Name.Text == "" || Log_Portal[0].Text == "")
                {
                    string Error_String = "";
                    if (Company_Name.Text == "")
                    {
                        Error_String = "\"企業名\"";
                    }
                    if (Service_Name.Text == "")
                    {
                        if (Company_Name.Text == "")
                            Error_String = Error_String + ", \"利用サービス名\"";
                        else
                            Error_String = "\"利用サービス名\"";
                    }
                    if (Log_Portal[0].Text == "")
                    {
                        if (Company_Name.Text == "" || Service_Name.Text == "")
                            Error_String = Error_String + ", \"活動履歴No.1\"";
                        else
                            Error_String = "\"活動履歴No.1\"";
                    }
                    MessageBox.Show(Error_String + "が入力されていません\n上記項目を入力し、もう一度\"" + CSV_Data_ADD.Text + "\"ボタンをクリックしてください。");
                }
                else
                {
                    string[] Before_CSV_SAVE_DATA = CSV_SAVE_DATA;
                    if (List_Comp.SelectedIndex == 0)
                    {
                        Array.Resize(ref CSV_SAVE_DATA, CSV_SAVE_DATA.Length + 1);
                        New_Contents[0] = (CSV_SAVE_DATA.Length - 1).ToString();
                        List_Comp.Items.Add(Company_Name.Text);
                        CSV_SAVE_DATA[int.Parse(New_Contents[0])] = string.Join(",", New_Contents);
                        bool success = CSV.Save_ALL(CSV_SAVE_DATA);
                        if (success)
                        {
                            MessageBox.Show("新規登録しました\n企業名: " + Company_Name.Text, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Component_Reset();
                        }
                        else
                        {
                            CSV_SAVE_DATA = Before_CSV_SAVE_DATA;
                            List_Comp.Items.RemoveAt(List_Comp.Items.Count - 1);
                        }
                    }
                    else
                    {
                        int Insert_Index = List_Comp.SelectedIndex;
                        New_Contents[0] = (List_Comp.SelectedIndex).ToString();
                        List_Comp.Items.Insert(Insert_Index, Company_Name.Text);
                        List_Comp.SelectedIndex = 0;
                        List_Comp.Items.RemoveAt(Insert_Index + 1);
                        List_Comp.SelectedIndex = Insert_Index;
                        CSV_SAVE_DATA[int.Parse(New_Contents[0])] = string.Join(",", New_Contents);
                        bool success = CSV.Save_ALL(CSV_SAVE_DATA);
                        if (success)
                            MessageBox.Show("上書き保存しました\n企業名: " + Company_Name.Text, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            for (int Item = 1; Item < List_Comp.Items.Count; Item++)
                            {
                                List_Comp.Items.RemoveAt(Item);
                            }
                            CSV_SAVE_DATA = Before_CSV_SAVE_DATA;
                            Add_List();
                            List_Comp.SelectedIndex = Insert_Index;
                        }
                    }
                }
            }
            catch (Exception neko)
            {
                MessageBox.Show(MethodBase.GetCurrentMethod().Name + "\n" + neko.ToString());
            }
        }
        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (List_Comp.SelectedIndex == 0)
                {
                    Component_Reset();
                    CSV_Data_ADD.Text = "追加";
                    CSV_Data_DEL.Text = "クリア";
                }
                else
                {
                    CSV_Data_ADD.Text = "上書保存";
                    CSV_Data_DEL.Text = "削除";
                    string[] Insert_Data = CSV.Load_LINE(CSV_SAVE_DATA, List_Comp.SelectedIndex);
                    Company_Name.Text = Insert_Data[1];
                    Service_Name.Text = Insert_Data[2];
                    Company_URI.Text = Insert_Data[3];
                    switch (Insert_Data[4])
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
                    int CSV_index = 5;
                    for (int index = 0; index < 10; index++)
                    {
                        if (Insert_Data[CSV_index + 1] != "")
                        {
                            Date_Portal[index].Value = DateTime.Parse(Insert_Data[CSV_index]);
                            Log_Portal[index].Text = Insert_Data[CSV_index + 1];
                        }
                        else
                        {
                            Date_Portal[index].Value = DateTime.Now;
                            Log_Portal[index].Text = "";
                        }
                        CSV_index = CSV_index + 2;
                    }
                    if (Insert_Data[25].Contains("   "))
                        Insert_Data[25] = Insert_Data[25].Replace("   ", Environment.NewLine);
                    User_Note.Text = Insert_Data[25];
                }
            }
            catch (Exception neko)
            {
                MessageBox.Show(MethodBase.GetCurrentMethod().Name + "\n" + neko.ToString());
            }
        }

        private void CSV_Data_DEL_Click(object sender, EventArgs e)
        {
            DialogResult Ques = MessageBox.Show("情報を" + CSV_Data_DEL.Text + "します。\nよろしいですか?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Ques == DialogResult.Yes)
            {
                if (List_Comp.SelectedIndex == 0)
                    Component_Reset();
                else
                {
                    int delete_id = List_Comp.SelectedIndex;
                    var list = new List<string>();
                    list.AddRange(CSV_SAVE_DATA);
                    list.Remove(CSV_SAVE_DATA[List_Comp.SelectedIndex]);
                    CSV_SAVE_DATA = list.ToArray();
                    for (int index = List_Comp.SelectedIndex; index < CSV_SAVE_DATA.Length; index++)
                    {
                        string[] Before_Array = CSV.Load_LINE(CSV_SAVE_DATA, index);
                        int Before_ID = int.Parse(Before_Array[0]) - 1;
                        Before_Array[0] = Before_ID.ToString();
                        CSV_SAVE_DATA[index] = string.Join(",", Before_Array);
                    }
                    List_Comp.SelectedIndex = List_Comp.SelectedIndex - 1;
                    List_Comp.Items.RemoveAt(delete_id);
                    CSV.Save_ALL(CSV_SAVE_DATA);
                }
                MessageBox.Show("情報を" + CSV_Data_DEL.Text + "しました。", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Component_Reset()
        {
            Company_Name.Text = "";
            Service_Name.Text = "";
            Company_URI.Text = "";
            Log_Doing.Checked = true;
            int index = 0;
            while (index < 10)
            {
                Date_Portal[index].Value = DateTime.Now;
                Log_Portal[index].Text = "";
                index++;
            }
            User_Note.Text = "メモ";

        }

        public void Add_List()
        {
            for (int line = 1; line < CSV_SAVE_DATA.Length; line++)
            {
                string[] CSV_DATA_LINE = CSV.Load_LINE(CSV_SAVE_DATA, line);
                List_Comp.Items.Add(CSV_DATA_LINE[1]);
            }
        }
    }
}