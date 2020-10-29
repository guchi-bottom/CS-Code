using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Graduate_App
{
    public class CSV_Access
    {
        string[] Header = { "id,name,service,url,status,date_1,log_1,date_2,log_2,date_3,log_3,date_4,log_4,date_5,log_5,date_6,log_6,date_7,log_7,date_8,log_8,date_9,log_9,date_10,log_10,memo" };
        public void Load_ALL()
        {
            try
            {
                Form1.CSV_SAVE_DATA = File.ReadAllLines("就職活動履歴.csv", Encoding.GetEncoding("UTF-8"));
            }
            catch (FileNotFoundException)
            {
                bool Create = Create_CSV_File(Header);
                if (Create)
                {
                    MessageBox.Show("ファイル作ったやで(＾ω＾）");
                    Form1.CSV_SAVE_DATA = File.ReadAllLines("就職活動履歴.csv", Encoding.GetEncoding("UTF-8"));
                }
            }
            catch (IOException)
            {
                MessageBox.Show("別のアプリケーションによってCSVファイルが開かれているなどの理由により、正常に起動が行えませんでした\n起動しているプログラムを確認し、もう一度起動してください", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception neko)
            {
                MessageBox.Show(MethodBase.GetCurrentMethod().Name + "\n" + neko.ToString());
            }
        }
        public string[] Load_LINE(string[] CSV_SAVE_DATA, int LINE_NO)
        {
            try
            {
                string[] LOAD_DATA_LINES = CSV_SAVE_DATA[LINE_NO].Split(',');
                return LOAD_DATA_LINES;
            }
            catch (Exception neko)
            {
                return null;
            }
        }
        public bool Save_ALL(string[] CSV_SAVE_DATA)
        {
            try
            {
                StreamWriter Writing_File = new StreamWriter("就職活動履歴.csv", false, Encoding.UTF8);
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
            catch (Exception neko)
            {
                MessageBox.Show(MethodBase.GetCurrentMethod().Name + "\n" + neko.ToString());
                return false;
            }
        }
        public bool Create_CSV_File(string[] CSV_SAVE_DATA)
        {
            try
            {
                DialogResult Response = MessageBox.Show("起動に必要なCSVファイルが見つかりませんでした\nCSVファイルを作成しますか？", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Response == DialogResult.Yes)
                {
                    Save_ALL(CSV_SAVE_DATA);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception neko)
            {
                MessageBox.Show(MethodBase.GetCurrentMethod().Name + "\n" + neko.ToString());
                return false;
            }
        }
    }
}