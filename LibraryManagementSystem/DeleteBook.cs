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
    public partial class DeleteBook : Form
    {
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("data source=localhost; database=reading_manage_system; port=3306; User Id=root; Password=wang20000309.");
            mySqlConnection.Open();
            String bookIdStr = textBox1.Text;
            int bookid = int.Parse(bookIdStr);
            String deleteBookSql = "delete from book where bookId = " + bookid + "";

            MySqlCommand mySqlCommand1 = new MySqlCommand(deleteBookSql,mySqlConnection);
            int x = mySqlCommand1.ExecuteNonQuery();
            if(x == 1)
            {
                MessageBox.Show("删除书目成功！");
            }
            else
            {
                MessageBox.Show("删除失败！图书馆无此书。");
            }
            mySqlConnection.Close();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
