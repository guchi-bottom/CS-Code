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
<<<<<<< HEAD
                string[] GET_CSV_RECORD = File.ReadAllLines(PATH + @"\きゃりろぐ\履歴情報.csv", Encoding.GetEncoding("UTF-8"));
                Main_Form.CSV_RECORD.AddRange(GET_CSV_RECORD);
=======
                Form.CSV_SAVE_DATA = File.ReadAllLines(PATH + @"\Files\就職活動履歴.csv", Encoding.GetEncoding("UTF-8"));
>>>>>>> parent of e9c1a98... Ver. 1.00書出し
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
<<<<<<< HEAD
                //2.
                //CSVファイルを開き、ヘッダーから順にListに保存されている情報を書き込む。
                StreamWriter Writing_File = new StreamWriter(PATH + @"\きゃりろぐ\履歴情報.csv", false, Encoding.UTF8);
                for (int index = 0; index < CSV_RECORD.Count; index++)
=======
                StreamWriter Writing_File = new StreamWriter(PATH + @"\Files\就職活動履歴.csv", false, Encoding.UTF8);
                for (int index = 0; index < CSV_SAVE_DATA.Length; index++)
>>>>>>> parent of e9c1a98... Ver. 1.00書出し
                {
                    string Save_Line = string.Join(",", CSV_SAVE_DATA[index]);
                    Writing_File.WriteLine("{0}", Save_Line);
                }
                Writing_File.Close();
                return true;
            }
            catch (IOException)
            {
<<<<<<< HEAD
                //3.Exception発生時にMessageBoxを表示し、ユーザーに通知をする。
                //切り替えポイント
#if DEBUG || RELEASE
                MessageBox.Show("別のアプリケーションによってCSVファイルが開かれているなどの理由により、正常に保存できませんでした\n"
                    + "起動しているプログラムを確認し、もう一度保存してください"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
#else
                MessageBox.Show("The CSV file could not be saved successfully, for example because it was opened by another application.\n"
                    + "Please check the running program and save again."
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
#endif
=======
                MessageBox.Show("別のアプリケーションによってCSVファイルが開かれているなどの理由により、正常に保存できませんでした\n起動しているプログラムを確認し、もう一度保存してください", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
>>>>>>> parent of e9c1a98... Ver. 1.00書出し
                return false;
            }
        }
        public void Check_CSV()
        {
<<<<<<< HEAD
            /* 名前: Save_ALL
             * タイプ: メソッド
             * 呼び出しタイミング: Main_Form.csから
             * 動作内容:
             * 1. フォルダの所在確認
             * 2. ファイルの所在確認
             * 3. ユーザーがフォルダ, ファイル生成に同意しなかった場合、MessageBoxを表示しプログラムを終了する    */

            //1.
            //CSVファイルを保存するフォルダを確認し、見つからなかった場合ユーザーに生成するか確認する。
            if (Directory.Exists(PATH + @"\きゃりろぐ") == false)
=======
            Console.WriteLine(PATH);
            if (Directory.Exists(PATH + @"\Files") == false)
>>>>>>> parent of e9c1a98... Ver. 1.00書出し
            {
                DialogResult check = MessageBox.Show("データを保存するフォルダが存在しません。\n作成しますか？"
                    , "Question"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1);
                if (check == DialogResult.Yes)
                {
<<<<<<< HEAD
                    Directory.CreateDirectory("きゃりろぐ");
                    List<string> header_first = new List<string>(1);
                    header_first.Add(Header);
                    Save_ALL(header_first, true);
                    //切り替えポイント
#if DEBUG || RELEASE
                    MessageBox.Show("作成完了しました\nフォルダパス: " + PATH + @"\きゃりろぐ\履歴情報.csv");
#else
                    MessageBox.Show("The creation is complete.\nFolder Path: " + PATH + @"\きゃりろぐ\履歴情報.csv");
#endif
=======
                    Directory.CreateDirectory("Files");
                    string[] header_first = { Header };
                    Save_ALL(header_first, true);
                    MessageBox.Show("作成完了しました\nフォルダパス: " + PATH + @"\Files\就職活動履歴.csv");
>>>>>>> parent of e9c1a98... Ver. 1.00書出し
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
<<<<<<< HEAD
                //2.
                //CSVファイルを確認し、見つからなかった場合ユーザーに生成するか確認する。
                if (File.Exists(PATH + @"\きゃりろぐ\履歴情報.csv") == false)
=======
                if (File.Exists(PATH + @"\Files\就職活動履歴.csv") == false)
>>>>>>> parent of e9c1a98... Ver. 1.00書出し
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
<<<<<<< HEAD
                        //切り替えポイント
#if DEBUG || RELEASE
                        MessageBox.Show("作成完了しました\nファイルパス: " + PATH + @"\きゃりろぐ\履歴情報.csv");
#else
                        MessageBox.Show("The creation is complete.\nFile Path: " + PATH + @"\きゃりろぐ\履歴情報.csv");
#endif
=======
                        MessageBox.Show("作成完了しました\nファイルパス: " + PATH + @"\Files\就職活動履歴.csv");
>>>>>>> parent of e9c1a98... Ver. 1.00書出し
                        Check_CSV();
                    }
                    else
                    {
<<<<<<< HEAD
                        //3.
                        //同意されなかった場合、MessageBoxを表示し終了する
                        //切り替えポイント
#if DEBUG || RELEASE
                        MessageBox.Show("データを保存するファイルが見つからないため、アプリケーションを終了します。");
#else
                        MessageBox.Show("Quit the application because the File to save the data was not found.");
#endif
=======
                        MessageBox.Show("データを保存するファイルが見つからないため、アプリケーションを終了します。");
>>>>>>> parent of e9c1a98... Ver. 1.00書出し
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}