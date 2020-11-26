/* License Information
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
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Graduate_App
{
    public class CSV_Access
    {
        //グローバル変数情報

        /* 変数, 配列名: Header
         * タイプ: string (System.String)
         * アクセスレベル: const
         * 格納値情報: CSVファイルに書き込むヘッダーの文字列を保持    */
        const string Header = "name,service,url,status,date_1,log_1,date_2,log_2,date_3,log_3,date_4,log_4,date_5,log_5,date_6,log_6,date_7,log_7,date_8,log_8,date_9,log_9,date_10,log_10,memo";

        /* 変数, 配列名: PATH
         * タイプ: string (System.String)
         * アクセスレベル: readonly private
         * 格納値情報: 起動.exeファイルのファイル所在パスを保持    */
        readonly string PATH = Application.ExecutablePath.Substring(0, (Application.ExecutablePath).LastIndexOf(@"\"));
        public void Load_ALL()
        {
            /* 名前: Load_ALL
             * タイプ: メソッド
             * 呼び出しタイミング: Main_Form.csから
             * 動作内容:
             * 1. CSVファイルからレコードを読み込み、レコード保持用Listに格納する
             * 2. Exception発生時、MessageBoxを表示しプログラムを終了する    */
            try
            {
                //1.
                //CSVファイルの存在確認をし、ファイルからレコードを読み込む。
                Check_CSV();
                string[] GET_CSV_RECORD = File.ReadAllLines(PATH + @"\きゃりろぐ\履歴情報.csv", Encoding.GetEncoding("UTF-8"));
                Main_Form.CSV_RECORD.AddRange(GET_CSV_RECORD);
            }
            catch (IOException)
            {
                //2.
                //ファイルが見つからないなどの問題が発生した場合、MessageBoxを表示しプログラムを終了する。
                //切り替えポイント
#if DEBUG || RELEASE
                MessageBox.Show("別のアプリケーションによってCSVファイルが開かれているなどの理由により、正常に起動できませんでした\n"
                    + "起動しているプログラムを確認し、もう一度起動してください"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
#else
                MessageBox.Show("It could not be started successfully, for example because a CSV file has been opened by another application.\n"
                    +"Please check the program you are running and start it again."
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
#endif
                Environment.Exit(0);
            }
        }
        public string[] Load_LINE(List<string> CSV_RECORD, int LINE_NO)
        {
            /* 名前: Load_LINE
             * タイプ: メソッド
             * 呼び出しタイミング: Main_Form.csから
             * 動作内容:
             * 1. 表示したいレコードを返却する    */
            //1.
            //CSVファイルから読み込んだレコードから表示したいレコードを抜き出し、コンマで分割した文字列配列を返却する
            return CSV_RECORD[LINE_NO].Split(',');
        }
        public bool Save_ALL(List<string> CSV_RECORD, bool Initial_Start)
        {
            /* 名前: Save_ALL
             * タイプ: メソッド
             * 呼び出しタイミング: Main_Form.csから
             * 動作内容:
             * 1. 初期起動時以外にファイルの所在確認をする
             * 2. CSVファイルを開き、レコードを１行ずつ書き込む
             * 3. Exception発生時にMessageBoxを表示する    */

            try
            {
                //1.
                //CSVファイルの所在チェックを行うメソッドを起動する
                if (Initial_Start == false)
                    Check_CSV();
                //2.
                //CSVファイルを開き、ヘッダーから順にListに保存されている情報を書き込む。
                StreamWriter Writing_File = new StreamWriter(PATH + @"\きゃりろぐ\履歴情報.csv", false, Encoding.UTF8);
                for (int index = 0; index < CSV_RECORD.Count; index++)
                {
                    string Save_Line = string.Join(",", CSV_RECORD[index]);
                    Writing_File.WriteLine("{0}", Save_Line);
                }
                Writing_File.Close();
                return true;
            }
            catch (IOException)
            {
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
                return false;
            }
        }
        public void Check_CSV()
        {
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
            {
                //切り替えポイント
#if DEBUG || RELEASE
                DialogResult check = MessageBox.Show("データを保存するフォルダが存在しません。\n作成しますか？"
                    , "Question"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1);
#else
                DialogResult check = MessageBox.Show("The folder where I store my data does not exist.\nCreate?"
                    , "Question"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1);
#endif
                if (check == DialogResult.Yes)
                {
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
                    Check_CSV();
                }
                else
                {
                    //3.
                    //同意されなかった場合、MessageBoxを表示し終了する
                    //切り替えポイント
#if DEBUG || RELEASE
                    MessageBox.Show("データを保存するフォルダが見つからないため、アプリケーションを終了します。");
#else
                    MessageBox.Show("Quit the application because the folder to save the data was not found.");
#endif
                    Environment.Exit(0);
                }
            }
            else
            {
                //2.
                //CSVファイルを確認し、見つからなかった場合ユーザーに生成するか確認する。
                if (File.Exists(PATH + @"\きゃりろぐ\履歴情報.csv") == false)
                {
#if DEBUG || RELEASE
                    DialogResult check = MessageBox.Show("データを保存するフォルダが存在しません。\n作成しますか？"
                        , "Question"
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question
                        , MessageBoxDefaultButton.Button1);
#else
                    DialogResult check = MessageBox.Show("No file to save the data.\nCreate?"
                        , "Question"
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question
                        , MessageBoxDefaultButton.Button1);
#endif
                    if (check == DialogResult.Yes)
                    {
                        List<string> header_first = new List<string>(1);
                        header_first.Add(Header);
                        Save_ALL(header_first, true);
                        //切り替えポイント
#if DEBUG || RELEASE
                        MessageBox.Show("作成完了しました\nファイルパス: " + PATH + @"\きゃりろぐ\履歴情報.csv");
#else
                        MessageBox.Show("The creation is complete.\nFile Path: " + PATH + @"\きゃりろぐ\履歴情報.csv");
#endif
                        Check_CSV();
                    }
                    else
                    {
                        //3.
                        //同意されなかった場合、MessageBoxを表示し終了する
                        //切り替えポイント
#if DEBUG || RELEASE
                        MessageBox.Show("データを保存するファイルが見つからないため、アプリケーションを終了します。");
#else
                        MessageBox.Show("Quit the application because the File to save the data was not found.");
#endif
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}