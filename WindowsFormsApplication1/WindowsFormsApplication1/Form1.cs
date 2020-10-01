using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] saved_data;

        bool new_contents = true;
        int contents_id = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                saved_data = File.ReadAllLines("data/data_file.csv", Encoding.GetEncoding("UTF-8"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StreamWriter file = new StreamWriter("data/data_file.csv", false, Encoding.UTF8);
                for (int i = 0; i < saved_data.Length; i++)
                {
                    string[] writing_code = saved_data[i].Split(',');
                    file.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23}"
                        , writing_code[0], writing_code[1], writing_code[2], writing_code[3], writing_code[4], writing_code[5]
                        , writing_code[6], writing_code[7], writing_code[8], writing_code[9], writing_code[10], writing_code[11]
                        , writing_code[12], writing_code[13], writing_code[14], writing_code[15], writing_code[16], writing_code[17]
                        , writing_code[18], writing_code[19], writing_code[20], writing_code[21], writing_code[22], writing_code[23]);
                }
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_add_Click(object sender, EventArgs e)
        {
            //id,name,service,status,date_1,log_1,date_2,log_2,date_3,log_3,date_4,log_4,date_5,log_5,
            //date_6,log_6,date_7,log_7,date_8,log_8,date_9,log_9,date_10,log_10

            //企業名, サービス情報取得
            string name = name_company.Text, service = name_service.Text;

            //活動状況取得
            int i_status = 0;
            foreach (RadioButton log in group_log.Controls) //エラー
            /*型 'System.InvalidCastException' のハンドルされていない例外が Graduations.exe で発生しました
              追加情報:型 'System.Windows.Forms.Button' のオブジェクトを型 'System.Windows.Forms.RadioButton' にキャストできません。*/
            {
                switch (log.Text)
                {
                    case "log_doing":
                        i_status = 1;
                        break;
                    case "log_unofficial":
                        i_status = 2;
                        break;
                    case "log_decline":
                        i_status = 3;
                        break;
                }
            }

            //活動履歴確認
            MessageBox.Show(date_1st.Value.ToString(), "chech");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                new_contents = true;
                contents_id = saved_data.Length;
                data_add.Text = "新規追加";
                data_del.Text = "クリア";
            }
            else
            {
                new_contents = false;
                contents_id = listBox1.SelectedIndex;
                data_add.Text = "更新";
                data_del.Text = "削除";
            }
        }

        private void data_del_Click(object sender, EventArgs e)
        {

        }
    }
}
