using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Graduate_App
{
    public partial class Form1 : Form
    {
        /*
         * 変数情報
         * 
         * 変数名: CSV_SAVE_DATA
         * 型: System.String型配列
         * 格納情報: .csvに格納されている情報を文字列変換し、レコード毎に格納
         * 
         * 変数名: Date_Portal
         * 型: DateTimePicker[] (Windows.Form.DateTimePicker)
         */
        static public string[] CSV_SAVE_DATA;
        readonly DateTimePicker[] Date_Portal = new DateTimePicker[10];
        readonly TextBox[] Log_Portal = new TextBox[10];
        readonly CSV_Access CSV = new CSV_Access();
        string[] Operation_Contents = new string[25];
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
                if (CSV_SAVE_DATA.Length != 1)
                    Add_List();
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
            Operation_Contents[0] = Company_Name.Text;
            Operation_Contents[1] = Service_Name.Text;
            Operation_Contents[2] = Company_URI.Text;
            if (Log_Doing.Checked)
                Operation_Contents[3] = "1";
            else if (Log_UnOfficial.Checked)
                Operation_Contents[3] = "2";
            else if (Log_Decline.Checked)
                Operation_Contents[3] = "3";
            int Contents_Index = 4;
            for (int index = 0; index < 10; index++)
            {
                if (Log_Portal[index].Text != "")
                {
                    Operation_Contents[Contents_Index] = (Date_Portal[index].Value.ToShortDateString());
                    Operation_Contents[Contents_Index + 1] = Log_Portal[index].Text;
                }
                Contents_Index += 2;
            }
            if (User_Note.Text.Contains(Environment.NewLine))
                Operation_Contents[24] = User_Note.Text.Replace(Environment.NewLine, " | ");
            else
                Operation_Contents[24] = User_Note.Text;

            //必須項目の空白チェック
            if (Company_Name.Text == "" || Service_Name.Text == "" || Log_Portal[0].Text == "")
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
                if (Log_Portal[0].Text == "")
                {
                    if (Company_Name.Text == "" || Service_Name.Text == "")
                        Error_String += ", \"活動履歴No.1\"";
                    else
                        Error_String = "\"活動履歴No.1\"";
                }
                MessageBox.Show(Error_String + "が入力されていません\n上記項目を入力し、もう一度\"" + CSV_Data_ADD.Text + "\"ボタンをクリックしてください。");
            }

            //空白無し
            else
            {
                if (List_Comp.SelectedIndex == 0)
                {
                    Array.Resize(ref CSV_SAVE_DATA, CSV_SAVE_DATA.Length + 1);
                    CSV_SAVE_DATA[CSV_SAVE_DATA.Length - 1] = string.Join(",", Operation_Contents);
                    CSV.Save_ALL(CSV_SAVE_DATA, false);
                    List_Comp.Items.Add(Company_Name.Text);
                    MessageBox.Show("新規登録しました\n企業名: " + Company_Name.Text, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Component_Reset();
                }
                else
                {
                    CSV_SAVE_DATA[List_Comp.SelectedIndex] = string.Join(",", Operation_Contents);
                    CSV.Save_ALL(CSV_SAVE_DATA, false);
                    List_Comp.Items.Insert(List_Comp.SelectedIndex, Company_Name.Text);
                    List_Comp.SelectedIndex--;
                    List_Comp.Items.RemoveAt(List_Comp.SelectedIndex + 1);
                    MessageBox.Show("上書き保存しました\n企業名: " + Company_Name.Text, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List_Comp.SelectedIndex > CSV_SAVE_DATA.Length - 1 || List_Comp.SelectedIndex < 0)
            {
                List_Comp.SelectedIndex = CSV_SAVE_DATA.Length - 1;
            }
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
                Operation_Contents = CSV.Load_LINE(CSV_SAVE_DATA, List_Comp.SelectedIndex);
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
                int CSV_index = 4;
                for (int index = 0; index < 10; index++)
                {
                    if (Operation_Contents[CSV_index + 1] != "")
                    {
                        Date_Portal[index].Value = DateTime.Parse(Operation_Contents[CSV_index]);
                        Log_Portal[index].Text = Operation_Contents[CSV_index + 1];
                    }
                    else
                    {
                        Date_Portal[index].Value = DateTime.Now;
                        Log_Portal[index].Text = "";
                    }
                    CSV_index += 2;
                }
                if (Operation_Contents[24].Contains(" | "))
                    Operation_Contents[24] = Operation_Contents[24].Replace(" | ", Environment.NewLine);
                User_Note.Text = Operation_Contents[24];
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
                    List_Comp.SelectedIndex -= 1;
                    List_Comp.Items.RemoveAt(delete_id);
                    CSV.Save_ALL(CSV_SAVE_DATA, false);
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
        }
        public void Add_List()
        {
            for (int line = 1; line < CSV_SAVE_DATA.Length; line++)
            {
                string[] CSV_DATA_LINE = CSV.Load_LINE(CSV_SAVE_DATA, line);
                List_Comp.Items.Add(CSV_DATA_LINE[0]);
            }
        }
    }
}