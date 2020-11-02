/*
 * This source code has been written by a student of Hokkaido Information University.
 * The author is not responsible for any problems that may arise from the use of this software.
 * 
 * Copyright (c) 2020 Yuuki Sakaguchi
 * Released under the MIT license.
 * https://opensource.org/licenses/mit-license.php
 */

using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Graduate_App
{
    public class CSV_Access
    {
        /*
         * Global Variable Information
         * 
         * Variable Name:
         * Type:
         * Protection Level: 
         * Data Information: 
         */
        const string Header = "id,name,service,url,status,date_1,log_1,date_2,log_2,date_3,log_3,date_4,log_4,date_5,log_5,date_6,log_6,date_7,log_7,date_8,log_8,date_9,log_9,date_10,log_10,memo";
        readonly string PATH = Application.ExecutablePath.Substring(0, (Application.ExecutablePath).LastIndexOf(@"\"));
        public void Load_ALL()
        {
            try
            {
                Check_CSV();
                Form.CSV_SAVE_DATA = File.ReadAllLines(PATH + @"\Files\就職活動履歴.csv", Encoding.GetEncoding("UTF-8"));
            }
            catch (IOException)
            {
                MessageBox.Show("別のアプリケーションによってCSVファイルが開かれているなどの理由により、正常に起動できませんでした\n"
                    + "起動しているプログラムを確認し、もう一度起動してください"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
        public string[] Load_LINE(string[] CSV_SAVE_DATA, int LINE_NO)
        {
            string[] LOAD_DATA_LINES = CSV_SAVE_DATA[LINE_NO].Split(',');
            return LOAD_DATA_LINES;
        }
        public bool Save_ALL(string[] CSV_SAVE_DATA, bool Initial_Start)
        {
            try
            {
                if(Initial_Start == false)
                    Check_CSV();
                StreamWriter Writing_File = new StreamWriter(PATH + @"\Files\就職活動履歴.csv", false, Encoding.UTF8);
                for (int index = 0; index < CSV_SAVE_DATA.Length; index++)
                {
                    string Save_Line = string.Join(",", CSV_SAVE_DATA[index]);
                    Writing_File.WriteLine("{0}", Save_Line);
                }
                Writing_File.Close();
                return true;
            }
            catch (IOException)
            {
                MessageBox.Show("別のアプリケーションによってCSVファイルが開かれているなどの理由により、正常に保存できませんでした\n起動しているプログラムを確認し、もう一度保存してください", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void Check_CSV()
        {
            Console.WriteLine(PATH);
            if (Directory.Exists(PATH + @"\Files") == false)
            {
                DialogResult check = MessageBox.Show("データを保存するフォルダが存在しません。\n作成しますか？"
                    , "Question"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1);
                if (check == DialogResult.Yes)
                {
                    Directory.CreateDirectory("Files");
                    string[] header_first = { Header };
                    Save_ALL(header_first, true);
                    MessageBox.Show("作成完了しました\nフォルダパス: " + PATH + @"\Files\就職活動履歴.csv");
                    Check_CSV();
                }
                else
                {
                    MessageBox.Show("データを保存するフォルダが見つからないため、アプリケーションを終了します。");
                    Environment.Exit(0);
                }
            }
            else
            {
                if (File.Exists(PATH + @"\Files\就職活動履歴.csv") == false)
                {
                    DialogResult check = MessageBox.Show("データを保存するファイルが存在しません。\n作成しますか？"
                        , "Question"
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question
                        , MessageBoxDefaultButton.Button1);
                    if (check == DialogResult.Yes)
                    {
                        string[] header_first = { Header };
                        Save_ALL(header_first, true);
                        MessageBox.Show("作成完了しました\nファイルパス: " + PATH + @"\Files\就職活動履歴.csv");
                        Check_CSV();
                    }
                    else
                    {
                        MessageBox.Show("データを保存するファイルが見つからないため、アプリケーションを終了します。");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}