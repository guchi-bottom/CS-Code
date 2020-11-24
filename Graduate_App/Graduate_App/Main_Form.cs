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
using System.Windows.Forms;

namespace Graduate_App
{
    public partial class Main_Form : Form
    {
        //グローバル変数情報

        /* 変数, 配列名: CSV_RECORD
         * タイプ: List<string> (System.Collections.Generic.List<System.String>)
         * アクセスレベル: Public staic
         * 格納値情報: CSVから読み込まれた, CSVに書き込む情報(レコード)を保持    */
        public static List<string> CSV_RECORD = new List<string>();

        /* 変数, 配列名: Date_Portal
         * タイプ: DateTimePicker[] (System.Windows.Forms.DateTimePicker)
         * アクセスレベル: private readonly
         * 格納値情報: 活動履歴入力用のDateTimePickerコンポーネントに関する情報を保持    */
        private readonly DateTimePicker[] Date_Portal = new DateTimePicker[10];

        /* 変数, 配列名: Log_Portal
         * タイプ: TextBox[] (System.Windows.Forms.TextBox)
         * アクセスレベル: private readonly
         * 格納値情報: 活動履歴入力用のTextBoxコンポーネントに関する情報を保持    */
        private readonly TextBox[] Log_Portal = new TextBox[10];

        /* 変数, 配列名: Operation_Contents
         * タイプ: string[25] (System.String)
         * アクセスレベル: Public
         * 格納値情報: ListBoxで選択されたレコードに関する情報を格納    */
        public string[] Operation_Contents = new string[25];

        /* 変数, 配列名: List_Len_Ins_Del
         * タイプ: int[] (System.Int32)
         * アクセスレベル: Public static
         * 格納値情報: List(CSV_RECORD)の要素数, 挿入インデックス, 削除インデックスを保持    */
        public static int[] List_Len_Ins_Del = { 0, -1, 0 };

        /* 変数, 配列名: CSV_ACCESS
         * タイプ: class
         * アクセスレベル: private
         * 格納値情報: CSV_Aceessクラスを定義    */
        private CSV_Access CSV_ACCESS => new CSV_Access();

        public Main_Form()
        {
            /* 名前: Main_Form
             * タイプ: コンストラクタ
             * 呼び出しタイミング: クラス作成時
             * 動作内容:
             * 1. コンポーネントの初期化(Designer.cs)
             * 2. コンポーネントに代入する(表示する)言語を選択し、代入
             * 3. CSVファイルを読み込む
             * 4. Date_Portal, Log_Portalにそれぞれ代入    */

            //テストコード(DEBUG, EN_DEBUGかどうかを判断)
#if DEBUG||EN_DEBUG
            MessageBox.Show("ねこちゃんはデバッグビルドをします。");
#endif
            //HDPI対応かどうかを確認
            SetProcessDPIAware();
            //1.
            //Visual Studioによって自動生成されたコード
            //コンポーネント情報を初期化(Main_Form.Designer.cs内)
            InitializeComponent();
            //2.
            //ビルド構成によって言語を切り替え(日本語, 英語)
            //コンポーネントの表示する文字列をここで切り替え
            //言語変更
#if DEBUG || RELEASE
            List_Comp.Items.Add("(新規登録)");
            corp_name.Text = "企業名";
            service.Text = "利用サービス";
            group_status.Text = "活動状況";
            Log_Doing.Text = "活動中";
            Log_UnOfficial.Text = "内定取得";
            Log_Decline.Text = "辞退等";
            group_log.Text = "活動履歴";
            label2.Text = "メモ";
            CSV_Data_ADD.Text = "登録";
            CSV_Data_DEL.Text = "クリア";
            Record_Sorting.Text = "並び替え";
#else
            List_Comp.Items.Add("(New Registration)");
            corp_name.Text = "Company name";
            service.Text = "Name of Service";
            group_status.Text = "Activity status";
            Log_Doing.Text = "In action";
            Log_UnOfficial.Text = "Getting a job offer";
            Log_Decline.Text = "Decline, etc.";
            group_log.Text = "Activity history";
            label2.Text = "Memo";
            CSV_Data_ADD.Text = "Registration";
            CSV_Data_DEL.Text = "Clear";
            Record_Sorting.Text = "Sording";
#endif
            //3.
            //CSV_Accessクラス内のメソッドを呼び出し
            //呼び出し先のメソッドでCSV_RECORDへ代入
            //レコード数を管理用配列に代入
            CSV_ACCESS.Load_ALL();
            Console.WriteLine("DEBUG: " + CSV_RECORD.Count);
            List_Len_Ins_Del[0] = CSV_RECORD.Count - 1;
            //4.
            //各種コンポーネントを配列へ代入
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
        /* 名前: SetProcessDPIAware
         * タイプ: メソッド
         * 呼び出しタイミング: コンストラクタから
         * 動作内容: 1. DLLファイルを参照し、DPI対応情報を参照する     */
        private void Form1_Load(object sender, EventArgs e)
        {
            /* 名前: Form1_Load
             * タイプ: メソッド
             * 呼び出しタイミング: フォームの読み込み時
             * 動作内容:
             * 1. CSVファイルから読み込まれたレコードがヘッダーだけでは無かった場合、ListBoxへ情報を格納するメソッドを呼び出す
             * 2. Exception発生時、プログラムを終了する    */
            try
            {
                List_Comp.SelectedIndex = 0;
                //1.
                //CSVファイルから読み込まれたレコードがヘッダーだけか判断
                if (CSV_RECORD.Count != 1)
                    //ListBoxに情報を格納するメソッドを呼び出す
                    Add_List();
            }
            catch (Exception)
            {
                //2.
                //ユーザーにプログラムを終了するとMessageBoxを表示
                //言語変更
#if DEBUG || RELEASE
                MessageBox.Show("CSVファイルが見つからないか、なんらかの問題が発生しているため、アプリケーションを終了します。"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
#else
                MessageBox.Show("Exit the application because the CSV file is not found or is experiencing some kind of problem."
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
#endif
                //プログラムを終了
                Close();
            }
        }
        private void CSV_Data_ADD_Clicked(object sender, EventArgs e)
        {
            /* 名前: CSV_Data_ADD_Clicked
             * タイプ: メソッド
             * 呼び出しタイミング: コンポーネント"CSV_Data_Add"(Button)がクリックされたとき
             * 動作内容:
             * 1. 必須情報が入力されているか確認
             * 2. コンポーネントに格納されている情報を処理用配列に代入
             * 3. 新規保存か上書き保存かを判別し、CSVファイルに書き込む    */

            //1.
            //企業名, サービス名、活動履歴 No.1が入力されているか確認
            //入力されていなかった場合、MessageBoxでユーザーに通知
            if (Company_Name.Text == "" || Service_Name.Text == "" || Log_Portal[0].Text == "")
            {
                string Error_String = "";
                if (Company_Name.Text == "")
                {
                    //言語変更
#if DEBUG || RELEASE
                    Error_String = "\"企業名\"";
#else
                    Error_String = "\"Company Name\"";
#endif
                }

                if (Service_Name.Text == "")
                {
                    if (Company_Name.Text == "")
                    {
                        //言語変更
#if DEBUG || RELEASE
                        Error_String += ", \"利用サービス名\"";
#else
                        Error_String += ", \"Name of Service\"";
#endif
                    }
                    else
                    {
                        //言語変更
#if DEBUG || RELEASE
                        Error_String = "\"利用サービス名\"";
#else
                        Error_String = "\"Name of Service\"";
#endif
                    }
                }
                if (Log_Portal[0].Text == "")
                {
                    if (Company_Name.Text == "" || Service_Name.Text == "")
                    {
                        //言語変更
#if DEBUG || RELEASE
                        Error_String += ", \"活動履歴 No.1\"";
#else
                        Error_String += ", \"Activity history No.1\"";
#endif
                    }
                    else
                    {
                        //言語変更
#if DEBUG || RELEASE
                        Error_String = "\"活動履歴 No.1\"";
#else
                        Error_String = "\"Activity history No.1\"";
#endif
                    }
                }
                //言語変更
#if DEBUG || RELEASE
                MessageBox.Show(Error_String + "が入力されていません\n上記項目を入力し、もう一度\"" + CSV_Data_ADD.Text + "\"ボタンをクリックしてください。");
#else
                MessageBox.Show("The " + Error_String + " has not been entered. \nPlease enter the above information and click the \"" + CSV_Data_ADD.Text + "\" button again.");
#endif
            }

            //2.
            //入力されている情報を配列へ代入
            else
            {
                Operation_Contents[0] = Company_Name.Text;
                Operation_Contents[1] = Service_Name.Text;
                Operation_Contents[2] = Company_URI.Text;
                if (Log_Doing.Checked)
                {
                    Operation_Contents[3] = "1";
                }
                else if (Log_UnOfficial.Checked)
                {
                    Operation_Contents[3] = "2";
                }
                else if (Log_Decline.Checked)
                {
                    Operation_Contents[3] = "3";
                }

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
                //CSVファイルではレコード内での改行をサポートしていないため、改行コードを置き換えて保存
                if (User_Note.Text.Contains(Environment.NewLine))
                {
                    Operation_Contents[24] = User_Note.Text.Replace(Environment.NewLine, " | ");
                }
                else
                {
                    Operation_Contents[24] = User_Note.Text;
                }

                //3.
                //処理用配列に格納されている文字列をコンマ区切りで結合
                //結合文字列をListへ格納しCSVファイルを保存
                if (List_Comp.SelectedIndex == 0)
                {
                    //新規登録
                    CSV_RECORD.Add(string.Join(",", Operation_Contents));
                    CSV_ACCESS.Save_ALL(CSV_RECORD, false);
                    List_Comp.Items.Add(Company_Name.Text);
                    //言語変更
#if DEBUG || RELEASE
                    MessageBox.Show("新規登録が完了しました。\n企業名: " + Company_Name.Text, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
#else
                    MessageBox.Show("Your information has been added to the system.\nCompany 名前: " + Company_Name.Text, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
                    //入力情報をリセット
                    Component_Reset();
                }
                else
                {
                    //上書保存
                    CSV_RECORD[List_Comp.SelectedIndex] = string.Join(",", Operation_Contents);
                    CSV_ACCESS.Save_ALL(CSV_RECORD, false);
                    List_Comp.Items.Insert(List_Comp.SelectedIndex, Company_Name.Text);
                    List_Comp.SelectedIndex--;
                    List_Comp.Items.RemoveAt(List_Comp.SelectedIndex + 1);
                    //言語変更
#if DEBUG || RELEASE
                    MessageBox.Show("上書保存が完了しました。\n企業名: " + Company_Name.Text, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
#else
                    MessageBox.Show("The information has been overwritten and saved.\nCompany 名前: " + Company_Name.Text, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
                }
                //レコード数を管理用配列に代入
                List_Len_Ins_Del[0] = CSV_RECORD.Count - 1;
            }
        }
        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* 名前: List_SelectedIndexChanged
             * タイプ: メソッド
             * 呼び出しタイミング: ListBoxの選択されているアイテムが変更されたとき
             * 動作内容:
             * 1. 選択されたアイテムが要素数を超えるなどの問題が発生した時に問題を吸収する
             * 2. 選択されたアイテムによって、コンポーネントの表示文字列などを変更する    */

            //1.
            //登録されていないアイテムを選択できてしまった場合、リストの最後の項目を選択する
            if (List_Comp.SelectedIndex > CSV_RECORD.Count - 1 || List_Comp.SelectedIndex < 0)
            {
                List_Comp.SelectedIndex = CSV_RECORD.Count - 1;
            }
            //選択されているレコードインデックスを管理用配列に代入
            List_Len_Ins_Del[2] = List_Comp.SelectedIndex;

            //2.
            //コンポーネントにレコード情報を表示する

            //コンポーネントに入力されている情報を削除
            Component_Reset();
            //新規登録を選択している場合
            if (List_Comp.SelectedIndex == 0)
            {
                //並び替え用のボタンを無効化
                Record_Sorting.Enabled = false;
                //言語変更
#if DEBUG || RELEASE
                CSV_Data_ADD.Text = "登録";
                CSV_Data_DEL.Text = "クリア";
#else
                CSV_Data_ADD.Text = "Registration";
                CSV_Data_DEL.Text = "Clear";
#endif
            }
            //レコードを選択している場合
            else
            {
                //複数のレコードが登録されていない場合、並び替え用のボタンを無効化
                if (List_Comp.Items.Count == 2)
                    Record_Sorting.Enabled = false;
                else
                    Record_Sorting.Enabled = true;
                //言語変更
#if DEBUG || RELEASE
                CSV_Data_ADD.Text = "上書保存";
                CSV_Data_DEL.Text = "削除";
#else
                CSV_Data_ADD.Text = "overwrite save";
                CSV_Data_DEL.Text = "Delete";
#endif
                //レコードをロードし、コンポーネントへそれぞれ代入する
                Operation_Contents = CSV_ACCESS.Load_LINE(CSV_RECORD, List_Comp.SelectedIndex);
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
                {
                    Operation_Contents[24] = Operation_Contents[24].Replace(" | ", Environment.NewLine);
                }
                User_Note.Text = Operation_Contents[24];
            }

        }
        private void CSV_Data_DEL_Click(object sender, EventArgs e)
        {
            /* 名前: CSV_Data_DEL_Click
             * タイプ: メソッド
             * 呼び出しタイミング: 情報を削除するボタンをクリックされたとき
             * 動作内容:
             * 1. ユーザーにMessageBoxで削除するか確認
             * 2. 同意された場合、データを削除    */

            //1.
            //削除・クリアするかユーザーに確認
            DialogResult Ques = DialogResult.No;
            //言語変更
#if DEBUG || RELEASE
            Ques = MessageBox.Show("情報を" + CSV_Data_DEL.Text + "します。\nよろしいですか?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
#else
            if (List_Comp.SelectedIndex == 0)
                Ques = MessageBox.Show("The system will erase the information you have entered.\nAre you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            else
                Ques = MessageBox.Show("The system will delete the registered information.\nAre you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
#endif
            //ユーザーが同意した場合、コンポーネントの文字列を削除しレコードの情報を削除する
            if (Ques == DialogResult.Yes)
            {
                //新規保存を選択している場合
                if (List_Comp.SelectedIndex == 0)
                {
                    Component_Reset();
                }
                //それ以外の場合
                else
                {
                    int delete_id = List_Comp.SelectedIndex;
                    CSV_RECORD.RemoveAt(delete_id);
                    List_Comp.Items.RemoveAt(delete_id);
                    List_Comp.SelectedIndex = delete_id - 1;
                    CSV_ACCESS.Save_ALL(CSV_RECORD, false);
                }
                //言語変更
#if DEBUG || RELEASE
                MessageBox.Show("情報を" + CSV_Data_DEL.Text + "しました。");
#else
                if (List_Comp.SelectedIndex == 0)
                    MessageBox.Show("The system has erased the information you entered.", "Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                else
                    MessageBox.Show("The system has deleted the registered information.", "Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
#endif
                //レコード数を管理用配列に代入
                List_Len_Ins_Del[0] = CSV_RECORD.Count - 1;
            }
        }
        public void Component_Reset()
        {
            /* 名前: Component_Reset
             * タイプ: メソッド
             * 呼び出しタイミング: コンポーネントに格納されている文字列を削除する場合
             * 動作内容:
             * 1. コンポーネントの情報を削除する    */

            //1.
            //コンポーネントに格納されている情報を初期化する
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
            /* 名前: Add_List
             * タイプ: メソッド
             * 呼び出しタイミング: フォームが読み出され、CSVファイルにレコードが1つ以上保存されている時
             * 動作内容:
             * 1. レコードから企業名を取り出し、ListBoxへ追加する    */

            //1.
            //レコードから企業名列にある情報を取り出し、ListBoxへ登録する
            for (int line = 1; line < CSV_RECORD.Count; line++)
            {
                string[] CSV_DATA_LINE = CSV_ACCESS.Load_LINE(CSV_RECORD, line);
                List_Comp.Items.Add(CSV_DATA_LINE[0]);
            }
        }

        private void Sorting_Record_Click(object sender, EventArgs e)
        {
            /* 名前: Sorting_Record_Click
             * タイプ: メソッド
             * 呼び出しタイミング: 並び替えをするコンポーネントボタンがクリックされた
             * 動作内容:
             * 1. Sab_Formをモーダルフォームとして呼び出し
             * 2. 変更先インデックスを指定されている場合、並び替える    */

            //1.
            //モーダルフォームとしてSub_Formを呼び出す
            Sub_Form sub = new Sub_Form();
            sub.ShowDialog(this);
            sub.Dispose();

            //2.
            //サブフォームで変更先のインデックスを指定する配列が変更されている場合、並び替えを行う。
            if (List_Len_Ins_Del[1] != -1)
            {
                string Insert_std = CSV_RECORD[List_Len_Ins_Del[2]];
                string Insert_com = List_Comp.SelectedItem.ToString();
                CSV_RECORD.RemoveAt(List_Len_Ins_Del[2]);
                List_Comp.Items.RemoveAt(List_Len_Ins_Del[2]);
                CSV_RECORD.Insert(List_Len_Ins_Del[1], Insert_std);
                List_Comp.Items.Insert(List_Len_Ins_Del[1], Insert_com);
                List_Comp.SelectedIndex = List_Len_Ins_Del[1];
                List_Len_Ins_Del[1] = -1;
                CSV_ACCESS.Save_ALL(CSV_RECORD, false);
            }
        }
    }
}