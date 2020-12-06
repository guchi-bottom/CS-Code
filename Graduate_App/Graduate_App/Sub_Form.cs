using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graduate_App
{
    public partial class Sub_Form : Form
    {
        //グローバル変数情報

        /* 変数, 配列名: Text_Init
         * タイプ: string (System.String)
         * アクセスレベル: Private
         * 格納値情報: TextBoxに格納する文字列を保持    */
        string Text_Init;
        public Sub_Form()
        {
            /* 名前: Sub_Form
             * タイプ: コンストラクタ
             * 呼び出しタイミング: クラス作成時
             * 動作内容:
             * 1. コンポーネントの初期化(Designer.cs)
             * 2. TestBoxに表示する文字列を指定し、表示する    */

            //1.
            InitializeComponent();
            //2.
            //言語変更
#if DEBUG || RELEASE
            Text_Init = "入力可能数: 1～" + (Main_Form.List_Len_Ins_Del[0]).ToString();
#else
            Text_Init = "Possible input values: 1 to" + (Main_Form.List_Len_Ins_Del[0]).ToString();
#endif
            textBox1.Text = Text_Init;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* 名前: button1_Click
             * タイプ: メソッド
             * 呼び出しタイミング: Button1のクリック時
             * 動作内容:
             * 1. 入力文字列が数字化判断
             * 2. レコードを並び替えるか確認し、ユーザーが同意したら処理をするように配列に代入する    */

            //1.
            if (int.TryParse(textBox1.Text, out _))
            {
                int Insert_Index = int.Parse(textBox1.Text);
                if (Insert_Index > Main_Form.List_Len_Ins_Del[0])
                    //言語変更
#if DEBUG || RELEASE
                    MessageBox.Show("有効な数字ではありません。もう一度入力してください。\n有効数字: 1～" + Main_Form.List_Len_Ins_Del[0] + ".");
#else
                    MessageBox.Show("The number entered is not valid.\n please enter a number between 1 and " + Main_Form.List_Len_Ins_Del[0] + ".");
#endif
                else
                {
                    //2.
                    //言語変更
#if DEBUG || RELEASE
                    DialogResult Check = MessageBox.Show("レコードを並び替えます。\n"
                        + "変更前: " + Main_Form.List_Len_Ins_Del[2] + "\n変更後: " + Insert_Index
                        + "\n\n実行しますか?"
                        , "Question"
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question);
#else
                    DialogResult Check = MessageBox.Show("Replace the records.\n"
                        + "Index before: " + Main_Form.List_Len_Ins_Del[2] + "\nIndex after: " + Insert_Index
                        + "\n\nAre you sure?"
                        , "Question"
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question);
#endif
                    if (Check == DialogResult.Yes)
                    {
                        if (Main_Form.List_Len_Ins_Del[2] != Insert_Index)
                        {
                            Main_Form.List_Len_Ins_Del[1] = Insert_Index;
                            Close();
                        }
                    }
                }
            }
            else
            {
                //入力文字列が数字だけではなかった場合
                //言語変更
#if DEBUG || RELEASE
                DialogResult Check = MessageBox.Show("入力された文字列が数字ではありません。\n数字を入力してください。"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Question);
#else
                DialogResult Check = MessageBox.Show("入力された文字列が数字ではありません。\n数字を入力してください。"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Question);
#endif
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /* 名前: textBox1_TextChanged
             * タイプ: メソッド
             * 呼び出しタイミング: TextBox1のテキストが変更されたとき
             * 動作内容:
             * 1. 文字色がデフォルトでは黒ではないため、デフォルトの文字列以外になった場合に色を変更する    */

            //1.
            if (textBox1.Text != Text_Init)
                textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            /* 名前: textBox1_TextChanged
             * タイプ: メソッド
             * 呼び出しタイミング: TextBox1がクリックされたとき
             * 動作内容:
             * 1. デフォルトの文字列の状態でクリックされたときに、格納している文字列を削除する    */

            //1.
            if (textBox1.Text == Text_Init)
                textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            /* 名前: textBox1_Leave
             * タイプ: メソッド
             * 呼び出しタイミング: TextBox1のコントロールが失われたとき
             * 動作内容:
             * 1. 空白の状態でコントロールを失った場合、デフォルトの文字列と文字色に変更する    */

            //1.
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.DarkGray;
                textBox1.Text = Text_Init;
            }
        }

        private void Sub_Form_MouseClick(object sender, MouseEventArgs e)
        {
            /* 名前: Sub_Form_MouseClick
             * タイプ: メソッド
             * 呼び出しタイミング: Form(コンポーネント以外)がクリックされた時
             * 動作内容:
             * 1. textBox1_Leaveを呼び出す    */

            //1.
            textBox1_Leave(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* 名前: button2_Click
             * タイプ: メソッド
             * 呼び出しタイミング: Button2がクリックされたとき
             * 動作内容:
             * 1. フォームを閉じ、制御をMain_Formへ戻す    */

            //1.
            Close();
        }

        private void Sub_Form_Load(object sender, EventArgs e)
        {
            /* 名前: Sub_Form_Load
             * タイプ: メソッド
             * 呼び出しタイミング: Sub_Formが読み込まれた時
             * 動作内容:
             * 1. インデックスを表示するコンポーネントに、現在のインデックス番号を格納する
             * 2. 各コンポーネントの表示文字列を変更する    */

            //1.
            label3.Text = Main_Form.List_Len_Ins_Del[2].ToString();

            //2.
            //言語変更
#if DEBUG || RELEASE
            label1.Text = "レコードを入れ替えます。";
            label2.Text = "変更前のレコード番号:";
            label4.Text = "変更したいレコード番号:";
            button1.Text = "入れ替え";
            button2.Text = "キャンセル";
#else
            label1.Text = "Replace the records.";
            label2.Text = "Current record number:";
            label4.Text = "The code number you want to insert:";
            button1.Text = "Sorting";
            button2.Text = "Cancel";
#endif
        }
    }
}
