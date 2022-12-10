using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        //DataSet dataSet; // 表形式のデータをメモリ領域へ格納するクラス
        DataTable table; // 表形式のデータ
        //DataRow rows; // データを追加
        


        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // インスタンス生成
            //dataSet= new DataSet();
            table = new DataTable("Table");
            

            // カラムの追加
            table.Columns.Add("title", typeof(string));
            table.Columns.Add("message", typeof(string));
            
            // メモリへ格納
            //dataSet.Tables.Add(table);
            dataGridView1.DataSource = table;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Clear btn
        private void btn_new_Click(object sender, EventArgs e)
        {
            textTitle.Clear();
            textMessage.Clear();
        }

        // save btn
        private void btn_save_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textTitle.Text,textMessage.Text);


            textTitle.Clear();
            textMessage.Clear();

        }

     

        // delete tbn
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            //table.Rows.RemoveAt(index);
            table.Rows[index].Delete();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}