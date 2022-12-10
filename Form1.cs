using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        //DataSet dataSet; // �\�`���̃f�[�^���������̈�֊i�[����N���X
        DataTable table; // �\�`���̃f�[�^
        //DataRow rows; // �f�[�^��ǉ�
        


        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // �C���X�^���X����
            //dataSet= new DataSet();
            table = new DataTable("Table");
            

            // �J�����̒ǉ�
            table.Columns.Add("title", typeof(string));
            table.Columns.Add("message", typeof(string));
            
            // �������֊i�[
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