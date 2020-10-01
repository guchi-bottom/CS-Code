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

            listBox1.SelectedIndex = 0;
            Console.WriteLine("Length:" + saved_data.Length);
        }

        private void data_saving()
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
            if (log_doing.Checked)
                i_status = 1;
            else if (log_unofficial.Checked)
                i_status = 2;
            else if (log_decline.Checked)
                i_status = 3;

            string[] log = new string[20];
            //配列初期化
            for (int i = 0; i < log.Length; i++) log[i] = "";
            //活動履歴取得
                if (log_1st.Text != "")
                {
                    log[0] = (date_1st.Value.ToString()).Substring(0, 10);
                    log[1] = log_1st.Text;
                }
                if (log_2nd.Text != "")
                {
                    log[2] = (date_2nd.Value.ToString()).Substring(0, 10);
                    log[3] = log_2nd.Text;
                }
                if (log_3rd.Text != "")
                {
                    log[4] = (date_3rd.Value.ToString()).Substring(0, 10);
                    log[5] = log_3rd.Text;
                }
                if (log_4th.Text != "")
                {
                    log[6] = (date_4th.Value.ToString()).Substring(0, 10);
                    log[7] = log_4th.Text;
                }
                if (log_5th.Text != "")
                {
                    log[8] = (date_5th.Value.ToString()).Substring(0, 10);
                    log[9] = log_5th.Text;
                }
                if (log_6th.Text != "")
                {
                    log[10] = (date_6th.Value.ToString()).Substring(0, 10);
                    log[11] = log_6th.Text;
                }
                if (log_7th.Text != "")
                {
                    log[12] = (date_7th.Value.ToString()).Substring(0, 10);
                    log[13] = log_7th.Text;
                }
                if (log_8th.Text != "")
                {
                    log[14] = (date_8th.Value.ToString()).Substring(0, 10);
                    log[15] = log_8th.Text;
                }
                if (log_9th.Text != "")
                {
                    log[16] = (date_9th.Value.ToString()).Substring(0, 10);
                    log[17] = log_9th.Text;
                }
                if (log_10th.Text != "")
                {
                    log[18] = (date_10th.Value.ToString()).Substring(0, 10);
                    log[19] = log_10th.Text;
                }

            //新規保存時
            if (new_contents)
            {
                contents_id = saved_data.Length;
                string saving_string = contents_id.ToString() + "," + name + "," + service + "," + i_status.ToString();
                for (int i = 0; i < log.Length; i++)
                    saving_string = saving_string + "," + log[i];
                Array.Resize(ref saved_data, saved_data.Length + 1);
                saved_data[saved_data.Length - 1] = saving_string;
                listBox1.Items.Add(name);
            }
            MessageBox.Show("データを保存しました！", "Data saving!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            data_saving();
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
