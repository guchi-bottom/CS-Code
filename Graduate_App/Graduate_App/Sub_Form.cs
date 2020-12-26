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
using System.Drawing;
using System.Windows.Forms;

namespace Graduate_App
{
    public partial class Sub_Form : Form
    {
        string Text_Init;
        public Sub_Form()
        {
            InitializeComponent();
#if DEBUG || RELEASE
            Text_Init = "入力可能数: 1～" + (Main_Form.List_Len_Ins_Del[0]).ToString();
#else
            Text_Init = "Possible input values: 1 to" + (Main_Form.List_Len_Ins_Del[0]).ToString();
#endif
            textBox1.Text = Text_Init;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int reject; //Try.Parse用
            if (int.TryParse(textBox1.Text, out reject))
            {
                int Insert_Index = int.Parse(textBox1.Text);
                if (Insert_Index > Main_Form.List_Len_Ins_Del[0])
#if DEBUG || RELEASE
                    MessageBox.Show("有効な数字ではありません。もう一度入力してください。\n有効数字: 1～" + Main_Form.List_Len_Ins_Del[0] + ".");
#else
                    MessageBox.Show("The number entered is not valid.\n please enter a number between 1 and " + Main_Form.List_Len_Ins_Del[0] + ".");
#endif
                else
                {
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
            if (textBox1.Text != Text_Init)
                textBox1.ForeColor = Color.Black;
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Text_Init)
                textBox1.Text = "";
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.DarkGray;
                textBox1.Text = Text_Init;
            }
        }
        private void Sub_Form_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1_Leave(sender, e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Sub_Form_Load(object sender, EventArgs e)
        {
            label3.Text = Main_Form.List_Len_Ins_Del[2].ToString();
#if DEBUG || RELEASE
            Name = "レコードの並び替え";
            label1.Text = "レコードを入れ替えます。";
            label2.Text = "変更前のレコード番号:";
            label4.Text = "変更したいレコード番号:";
            button1.Text = "入れ替え";
            button2.Text = "キャンセル";
#else
            Name = "Sorting of records";
            label1.Text = "Replace the records.";
            label2.Text = "Current record number:";
            label4.Text = "The code number you want to insert:";
            button1.Text = "Sorting";
            button2.Text = "Cancel";
#endif
        }
    }
}
