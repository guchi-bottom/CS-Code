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
        const string Header = "name,service,url,status,date_1,log_1,date_2,log_2,date_3,log_3,date_4,log_4,date_5,log_5,date_6,log_6,date_7,log_7,date_8,log_8,date_9,log_9,date_10,log_10,memo";
        readonly string PATH = Application.ExecutablePath.Substring(0, (Application.ExecutablePath).LastIndexOf(@"\"));
        public void Load_ALL()
        {
            try
            {
                Check_CSV();
                string[] GET_CSV_RECORD = File.ReadAllLines(PATH + @"\きゃりろぐ\履歴情報.csv", Encoding.GetEncoding("UTF-8"));
                Main_Form.CSV_RECORD.AddRange(GET_CSV_RECORD);
            }
            catch (IOException)
            {
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
        public List<string> Load_LINE(List<string> CSV_RECORD, int LINE_NO)
        {
            List<string> return_List = new List<string>(CSV_RECORD[LINE_NO].Split(','));
            return return_List;
        }
        public bool Save_ALL(List<string> CSV_RECORD, bool Initial_Start)
        {
            try
            {
                if (Initial_Start == false)
                    Check_CSV();
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
            if (Directory.Exists(PATH + @"\きゃりろぐ") == false)
            {
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
#if DEBUG || RELEASE
                    MessageBox.Show("作成完了しました\nフォルダパス: " + PATH + @"\きゃりろぐ\履歴情報.csv");
#else
                    MessageBox.Show("The creation is complete.\nFolder Path: " + PATH + @"\きゃりろぐ\履歴情報.csv");
#endif
                    Check_CSV();
                }
                else
                {
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
#if DEBUG || RELEASE
                        MessageBox.Show("作成完了しました\nファイルパス: " + PATH + @"\きゃりろぐ\履歴情報.csv");
#else
                        MessageBox.Show("The creation is complete.\nFile Path: " + PATH + @"\きゃりろぐ\履歴情報.csv");
#endif
                        Check_CSV();
                    }
                    else
                    {
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