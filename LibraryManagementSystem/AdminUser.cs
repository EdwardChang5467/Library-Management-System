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
    public partial class AdminUser : Form
    {
        public AdminUser()
        {
            InitializeComponent();
           
        }

        private void AdminUser_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInfoDisplay userInfo = new UserInfoDisplay();
            userInfo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin login = new UserLogin();
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookInfoDisplay bookInfo = new BookInfoDisplay();
            bookInfo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BorrowReturnBookDisplay brbd = new BorrowReturnBookDisplay();
            brbd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddBook addbook = new AddBook();
            addbook.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DeleteBook deletebook = new DeleteBook();
            deletebook.Show();
        }

        private void adminname_Click(object sender, EventArgs e)
        {

        }
    }
}
