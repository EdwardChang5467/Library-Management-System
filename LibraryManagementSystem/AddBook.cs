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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("data source=localhost; database=reading_manage_system; port=3306; User Id=root; Password=wang20000309.");
            mySqlConnection.Open();

            String bookIdStr = textBox1.Text;
            int bookid = int.Parse(bookIdStr);
            String bookname = textBox3.Text;
            String bookwriter = textBox4.Text;
            String bookpublisher = textBox5.Text;
            String bookcountStr = textBox2.Text;
            int bookcount = int.Parse(bookcountStr);

            String findBookExistSql = "select bookId from book where bookName = '" + bookname + "'";
            String addBookUpdateSql = "update book set bookCount = bookCount + " + bookcount + " where bookId = " + bookid + " and bookName = '" + bookname + "'";
            String addBookInsertSql = "insert into book(bookId,bookName,bookWriter,bookPublisher,bookCount) values( " + bookid + ",'" + bookname + "','" + bookwriter + "','" + bookpublisher + "'," + bookcount + ")";

            MySqlCommand mySqlCommand1 = new MySqlCommand(findBookExistSql, mySqlConnection);
            if (Convert.ToInt32(mySqlCommand1.ExecuteScalar()) != 0)
            {
                MySqlCommand mySqlCommand2 = new MySqlCommand(addBookUpdateSql,mySqlConnection);
                int x = mySqlCommand2.ExecuteNonQuery();
                if(x == 1)
                {
                    MessageBox.Show("添加数量成功！");
                }
                else
                {
                    MessageBox.Show("添加数量失败！");
                }
            }
            else
            {
                MySqlCommand mySqlCommand3 = new MySqlCommand(addBookInsertSql,mySqlConnection);
                int y = mySqlCommand3.ExecuteNonQuery();
                if (y == 1)
                {
                    MessageBox.Show("添加书目成功！");
                }
                else
                {
                    MessageBox.Show("添加书目失败！");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
