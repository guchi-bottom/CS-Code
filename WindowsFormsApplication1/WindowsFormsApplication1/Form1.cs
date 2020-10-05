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
using System.Reflection;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] saved_data;
        bool new_contents = true;
        int contents_id = 0;

        DateTimePicker[] date_portal = new DateTimePicker[10];
        TextBox[] log_portal = new TextBox[10];

        public Form1()
        {
            SetProcessDPIAware();
            InitializeComponent();
            date_portal[0] = date_1st;
            date_portal[1] = date_2nd;
            date_portal[2] = date_3rd;
            date_portal[3] = date_4th;
            date_portal[4] = date_5th;
            date_portal[5] = date_6th;
            date_portal[6] = date_7th;
            date_portal[7] = date_8th;
            date_portal[8] = date_9th;
            date_portal[9] = date_10th;
            log_portal[0] = log_1st;
            log_portal[1] = log_2nd;
            log_portal[2] = log_3rd;
            log_portal[3] = log_4th;
            log_portal[4] = log_5th;
            log_portal[5] = log_6th;
            log_portal[6] = log_7th;
            log_portal[7] = log_8th;
            log_portal[8] = log_9th;
            log_portal[9] = log_10th;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly myAssembly = Assembly.GetEntryAssembly();
            string path = (myAssembly.Location).Substring(0, (myAssembly.Location).LastIndexOf("\\"));
            try
            {
                saved_data = File.ReadAllLines("data_file/data_file.csv", Encoding.GetEncoding("UTF-8"));
            }
            catch (FileNotFoundException ex)
            {
                DialogResult checking = MessageBox.Show("データをセーブするためのCSVファイルが見つかりません。\nCSVファイルを作成しますか?", "初期起動時エラー"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (checking == DialogResult.OK)
                {
                    saved_data[0] = "id,name,service,url,status,date_1,log_1,date_2,log_2,date_3,log_3,date_4,log_4,date_5,log_5,date_6,log_6,date_7,log_7,date_8,log_8,date_9,log_9,date_10,log_10,memo";
                    data_save();
                    MessageBox.Show("作成完了しました。\nプログラムを起動します。", "作成完了"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                DialogResult checking = MessageBox.Show("データをセーブするためのディレクトリ, ファイルが見つかりません。\nディレクトリ, ファイルを作成しますか?", "初期起動時エラー", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (checking == DialogResult.Yes)
                {
                    path = path + "\\data_file";
                    Directory.CreateDirectory(path);
                    string[] header_csv = new string[1];
                    header_csv[0] = "id,name,service,url,status,date_1,log_1,date_2,log_2,date_3,log_3,date_4,log_4,date_5,log_5,date_6,log_6,date_7,log_7,date_8,log_8,date_9,log_9,date_10,log_10,memo";
                    saved_data = header_csv;
                    data_save();
                    MessageBox.Show("作成完了しました。\nプログラムを起動します。", "作成完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("深刻なエラーが発生しました。プログラムを終了します。", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
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
            Console.WriteLine("data_save()");
            try
            {
                Console.WriteLine("try - data_save");
                StreamWriter file = new StreamWriter("data_file/data_file.csv", false, Encoding.UTF8);
                for (int i = 0; i < saved_data.Length; i++)
                {
                    string[] writing_code = saved_data[i].Split(',');
                    file.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25}"
                    , writing_code[0], writing_code[1], writing_code[2], writing_code[3], writing_code[4], writing_code[5]
                    , writing_code[6], writing_code[7], writing_code[8], writing_code[9], writing_code[10], writing_code[11]
                    , writing_code[12], writing_code[13], writing_code[14], writing_code[15], writing_code[16], writing_code[17]
                    , writing_code[18], writing_code[19], writing_code[20], writing_code[21], writing_code[22], writing_code[23]
                    , writing_code[24], writing_code[25]);
                }
                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("catch - data_save");
                MessageBox.Show("ファイルへの書き込みに失敗しました。\nファイルが存在するか, ファイルが開かれていないか確認して再実行してください。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_add_Click(object sender, EventArgs e)
        {
            Console.WriteLine("data_add_Click");

            //企業名,サービス情報取得
            string name = name_company.Text, service = name_service.Text, www_uri = URI.Text, note_string = note.Text;

            //活動状況取得
            int i_status = 0;
            if (log_doing.Checked)
                i_status = 1;
            else if (log_unofficial.Checked)
                i_status = 2;
            else if (log_decline.Checked)
                i_status = 3;

            string[] log = new string[20];
            int log_index = 0;
            //配列初期化
            for (int i = 0; i < 10; i++)
            {
                if (log_portal[i].Text != "")
                {
                    log[log_index] = (date_portal[i].Value.ToString()).Substring(0, 10);
                    log[log_index + 1] = log_portal[i].Text;
                    log_index = log_index + 2;
                }
            }

            string saving_string = contents_id.ToString() + "," + name + "," + service + "," + www_uri + "," + i_status.ToString();
            for (int i = 0; i < log.Length; i++)
                saving_string = saving_string + "," + log[i];
            saving_string = saving_string + "," + note_string;
            if (new_contents)
            {
                Console.WriteLine("data_add_Click - 新規保存");
                contents_id = saved_data.Length;
                Array.Resize(ref saved_data, saved_data.Length + 1);
                saved_data[saved_data.Length - 1] = saving_string;
                listBox1.Items.Add(name);
                data_save();
                MessageBox.Show("データを保存しました！", "Data saving!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data_reset();
            }
            else
            {
                Console.WriteLine("data_add_Click - 上書き保存");
                int insert_id = contents_id;
                saved_data[contents_id] = saving_string;
                listBox1.SelectedIndex = 0;
                listBox1.Items.RemoveAt(insert_id);
                listBox1.Items.Insert(insert_id, name);
                data_save();
                MessageBox.Show("データを上書き保存しました！", "Data saving!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("listBox1_SelectedIndexChanged");
            if (listBox1.SelectedIndex == 0)
            {
                Console.WriteLine("listBox1_SelectedIndexChanged - 新規登録");
                new_contents = true;
                contents_id = saved_data.Length;
                data_add.Text = "新規追加";
                data_del.Text = "クリア";
                data_reset();
            }
            else
            {
                Console.WriteLine("listBox1_SelectedIndexChanged - 登録情報読み込み No." + listBox1.SelectedIndex);
                new_contents = false;
                contents_id = listBox1.SelectedIndex;
                data_add.Text = "更新";
                data_del.Text = "削除";
                data_load(contents_id);
            }
        }

        private void data_del_Click(object sender, EventArgs e)
        {
            Console.WriteLine("data_del_Click");
            DialogResult listen = DialogResult.Cancel;
            if (new_contents)
                listen = MessageBox.Show("入力された全ての情報をクリアします\n本当にクリアしますか？", "Queestion"
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            else
            {
                listen = MessageBox.Show("入力された全ての情報を削除します\n本当に削除しますか？", "Queestion"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (listen == DialogResult.OK)
                {
                    Console.WriteLine("data_del_Click - データ削除");
                    if (new_contents == false)
                    {
                        //リスト削除
                        int deleted_id = contents_id;
                        Console.WriteLine("表示インデックス 0へ");
                        listBox1.SelectedIndex = 0;
                        Console.WriteLine("アイテム削除");
                        listBox1.Items.RemoveAt(deleted_id);
                        //データ削除
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
                            saved_data[i] = nekko;
                        }
                        data_save();
                    }
                }
                data_reset();
                listBox1.SelectedIndex = 0;
            }
        }

        private void data_reset()
        {
            name_company.Text = "";
            name_service.Text = "";
            URI.Text = "";

            log_doing.Checked = true;

            for (int i = 0; i < 10; i++)
            {
                date_portal[i].Value = DateTime.Now;
                log_portal[i].Text = "";
            }

            note.Text = "メモ";
        }

        private void data_load(int contents)
        {
            Console.WriteLine("データロード");
            data_reset();

            string[] loading_data = saved_data[contents].Split(',');
            // DEBUG
            Console.WriteLine("loading_data.Length: " + loading_data.Length);
            // DEBUG
            name_company.Text = loading_data[1];
            name_service.Text = loading_data[2];
            URI.Text = loading_data[3];
            if (loading_data[4] == "1")
                log_doing.Checked = true;
            else if (loading_data[4] == "2")
                log_unofficial.Checked = true;
            else if (loading_data[4] == "3")
                log_decline.Checked = true;

            int index = 5;
            for (int i = 0; i < 10; i++)
            {
                if (loading_data[index + 1] != "")
                {
                    date_portal[i].Value = DateTime.Parse(loading_data[index] + " 00:00:00");
                    log_portal[i].Text = loading_data[index + 1];
                }
                else
                {
                    date_portal[i].Value = DateTime.Now;
                    log_portal[i].Text = "";
                }
                index = index + 2;
            }
            note.Text = loading_data[25];
            //OutOfIndex
        }

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern bool SetProcessDPIAware();
    }
}