using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class BookDisplay : Form
    {
        public BookDisplay()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("data source=localhost; database=reading_manage_system; port=3306; User Id=root; Password=wang20000309.");
            mySqlConnection.Open();
            String bookname = textBox1.Text;
            String bookNameSql = "select bookId,bookName,bookWriter,bookPublisher from book where bookName like '%" + bookname + "%'";
            MySqlCommand mySqlCommand = new MySqlCommand(bookNameSql,mySqlConnection);
            MySqlDataReader dr = mySqlCommand.ExecuteReader();  
            if (!dr.HasRows)
            {
                MessageBox.Show("查不到此书！");
            }
            listView1.Items.Clear();
            // 向列表添加数据
            this.listView1.BeginUpdate();
            while(dr.Read())
            {
                ListViewItem list = new ListViewItem();
                list.SubItems[0].Text = dr["bookId"].ToString();
                list.SubItems.Add(dr["bookName"].ToString());
                list.SubItems.Add(dr["bookWriter"].ToString());
                list.SubItems.Add(dr["bookPublisher"].ToString());
                this.listView1.Items.Add(list);
            }
            this.listView1.EndUpdate();

            dr.Close();
            mySqlCommand.ExecuteNonQuery();
            this.Controls.Add(listView1);
            mySqlConnection.Close();
        }

        private void BookDisplay_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
