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
using static LibraryManagementSystem.UserLogin;

namespace LibraryManagementSystem
{
    public partial class borrowBook : Form
    {
        public borrowBook()
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
            String borrowBookIdStr = textBox1.Text;
            int borrowBookId = int.Parse(borrowBookIdStr);
            //获取userid的sql
            String userIdSql = "select UserId from useraccount where UserAccount = '" + userAccount + "' and UserPwd = '" + userPwd + "'";
            MySqlCommand mySqlCommand1 = new MySqlCommand(userIdSql, mySqlConnection);
            MySqlDataReader dr = mySqlCommand1.ExecuteReader();
            dr.Read();
            String idStr = dr["UserId"].ToString();
            int id = int.Parse(idStr);
            String date = DateTime.Now.ToString();
            dr.Close();

            //更新书籍信息sql
            String borrowBookSql = "update book set bookCount = bookCount - 1 where bookId = " + borrowBookId + " and bookCount > 0";
            //插入借书记录sql
            String insertBorrowBookSql = "insert into borrowbook(userId,bookId,borrowDate) values (" + id + ", " + borrowBookId + ",'" + date + "')";

            MySqlCommand mySqlCommand2 = new MySqlCommand(borrowBookSql, mySqlConnection);
            int x = mySqlCommand2.ExecuteNonQuery();
            MySqlCommand mySqlCommand3 = new MySqlCommand(insertBorrowBookSql, mySqlConnection);
            int y = mySqlCommand3.ExecuteNonQuery();

            if(x == 1 && y == 1)
            {
                MessageBox.Show("借书成功！请在一个月内归还书籍。");
            }
            else
            {
                MessageBox.Show("借书失败！请联系图书管理员解决此问题。");
            }

            mySqlConnection.Close();
        }

    }
}
