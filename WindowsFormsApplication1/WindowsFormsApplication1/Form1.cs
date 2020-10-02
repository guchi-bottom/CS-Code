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
            if (saved_data.Length != 1)
            {
                for (int i = 1; i < saved_data.Length; i++)
                {
                    string[] neko = saved_data[i].Split(',');
                    listBox1.Items.Add(neko[1]);
                }
            }
        }

        private void data_save()
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

            //企業名,サービス情報取得
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
            string saving_string = contents_id.ToString() + "," + name + "," + service + "," + i_status.ToString();
            for (int i = 0; i < log.Length; i++)
                saving_string = saving_string + "," + log[i];
            if (new_contents)
            {
                contents_id = saved_data.Length;
                Array.Resize(ref saved_data, saved_data.Length + 1);
                saved_data[saved_data.Length - 1] = saving_string;
                listBox1.Items.Add(name);
                data_save();
                MessageBox.Show("データを保存しました！", "Datasaving!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data_reset();
            }
            else
            {
                int insert_id = contents_id;
                saved_data[contents_id] = saving_string;
                listBox1.SelectedIndex = 0;
                listBox1.Items.RemoveAt(insert_id);
                listBox1.Items.Insert(insert_id, name);
                data_save();
                MessageBox.Show("データを上書き保存しました！", "Datasaving!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                new_contents = true;
                contents_id = saved_data.Length;
                data_add.Text = "新規追加";
                data_del.Text = "クリア";
                data_reset();
            }
            else
            {
                new_contents = false;
                contents_id = listBox1.SelectedIndex;
                data_add.Text = "更新";
                data_del.Text = "削除";
                data_load(contents_id);
            }
        }

        private void data_del_Click(object sender, EventArgs e)
        {
            DialogResult listen = DialogResult.Cancel;
            if (new_contents)
                listen = MessageBox.Show("入力された全ての情報をクリアします\n本当にクリアしますか？", "Queestion"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            else
                listen = MessageBox.Show("入力された全ての情報を削除します\n本当に削除しますか？", "Queestion"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (listen == DialogResult.OK)
            {
                if (new_contents == false)
                {
                    //リスト削除
                    int deleted_id = contents_id;
                    Console.WriteLine("表示インデックス 0へ");
                    listBox1.SelectedIndex = 0;
                    Console.WriteLine("アイテム削除");
                    listBox1.Items.RemoveAt(deleted_id);
                    //Listboxデータを削除してインデックスが変更された際にロードしてる。これが問題。
                    //データ削除
                    //Array.Clear(saved_data, contents_id, 1);
                    //中身をクリアしただけでインデックス自体存在。これがネックに。
                    Console.WriteLine("配列削除");
                    var list = new List<string>();
                    list.AddRange(saved_data);
                    list.Remove(saved_data[deleted_id]);
                    saved_data = list.ToArray();

                    //配列id変更
                    Console.WriteLine("ID変更");
                    for (int i = deleted_id; i < saved_data.Length; i++)
                    {
                        string[] neko = saved_data[i].Split(',');
                        int nekochan = int.Parse(neko[0]);
                        nekochan = nekochan - 1;
                        neko[0] = nekochan.ToString();
                        string nekko = string.Join(",", neko);
                        MessageBox.Show("ID編集" + nekko);
                        saved_data[i] = nekko;
                    }

                    //書き込み
                    //テストファイル生成して確認。ID上書き以外の動作。
                    //data_save()

                    //DEBUG
                    for (int i = 1; i < saved_data.Length; i++)
                        MessageBox.Show(saved_data[i]);
                }
                data_reset();
                listBox1.SelectedIndex = 0;
            }
        }

        private void data_reset()
        {
            name_company.Text = "";
            name_service.Text = "";

            log_doing.Checked = true;

            date_1st.Value = DateTime.Now;
            log_1st.Text = "";
            date_2nd.Value = DateTime.Now;
            log_2nd.Text = "";
            date_3rd.Value = DateTime.Now;
            log_3rd.Text = "";
            date_4th.Value = DateTime.Now;
            log_4th.Text = "";
            date_5th.Value = DateTime.Now;
            log_5th.Text = "";
            date_6th.Value = DateTime.Now;
            log_6th.Text = "";
            date_7th.Value = DateTime.Now;
            log_7th.Text = "";
            date_8th.Value = DateTime.Now;
            log_8th.Text = "";
            date_9th.Value = DateTime.Now;
            log_9th.Text = "";
            date_10th.Value = DateTime.Now;
            log_10th.Text = "";
        }

        private void data_load(int contents)
        {
            Console.WriteLine("データロード");
            data_reset();

            string[] loading_data = saved_data[contents].Split(',');
            name_company.Text = loading_data[1];
            name_service.Text = loading_data[2];
            if (loading_data[3] == "1")
                log_doing.Checked = true;
            else if (loading_data[3] == "2")
                log_unofficial.Checked = true;
            else if (loading_data[3] == "3")
                log_decline.Checked = true;
            date_1st.Value = DateTime.Parse(loading_data[4]);
            log_1st.Text = loading_data[5];

            //以下任意入力
            if (loading_data[7] != "")
            {
                date_2nd.Value = DateTime.Parse(loading_data[6] + " 00:00:00");
                log_2nd.Text = loading_data[7];
            }
            else
            {
                date_2nd.Value = DateTime.Now;
                log_2nd.Text = "";
            }
            if (loading_data[9] != "")
            {
                date_3rd.Value = DateTime.Parse(loading_data[8] + " 00:00:00");
                log_3rd.Text = loading_data[9];
            }
            else
            {
                date_3rd.Value = DateTime.Now;
                log_3rd.Text = "";
            }
            if (loading_data[11] != "")
            {
                date_4th.Value = DateTime.Parse(loading_data[10] + " 00:00:00");
                log_4th.Text = loading_data[11];
            }
            else
            {
                date_4th.Value = DateTime.Now;
                log_4th.Text = "";
            }
            if (loading_data[13] != "")
            {
                date_5th.Value = DateTime.Parse(loading_data[12] + " 00:00:00");
                log_5th.Text = loading_data[13];
            }
            else
            {
                date_5th.Value = DateTime.Now;
                log_5th.Text = "";
            }
            if (loading_data[15] != "")
            {
                date_6th.Value = DateTime.Parse(loading_data[14] + " 00:00:00");
                log_6th.Text = loading_data[15];
            }
            else
            {
                date_6th.Value = DateTime.Now;
                log_6th.Text = "";
            }
            if (loading_data[17] != "")
            {
                date_7th.Value = DateTime.Parse(loading_data[16] + " 00:00:00");
                log_7th.Text = loading_data[17];
            }
            else
            {
                date_7th.Value = DateTime.Now;
                log_7th.Text = "";
            }
            if (loading_data[19] != "")
            {
                date_8th.Value = DateTime.Parse(loading_data[18] + " 00:00:00");
                log_8th.Text = loading_data[19];
            }
            else
            {
                date_8th.Value = DateTime.Now;
                log_8th.Text = "";
            }
            if (loading_data[21] != "")
            {
                date_9th.Value = DateTime.Parse(loading_data[20] + " 00:00:00");
                log_9th.Text = loading_data[21];
            }
            else
            {
                date_9th.Value = DateTime.Now;
                log_9th.Text = "";
            }
            if (loading_data[23] != "")
            {
                date_10th.Value = DateTime.Parse(loading_data[22] + " 00:00:00");
                log_10th.Text = loading_data[23];
            }
            else
            {
                date_10th.Value = DateTime.Now;
                log_10th.Text = "";
            }
        }
    }
}