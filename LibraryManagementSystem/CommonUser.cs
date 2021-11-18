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
    public partial class CommonUser : Form
    {
        public CommonUser()
        {
            InitializeComponent();
        }

        private void CommonUser_Load(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("data source=localhost; database=reading_manage_system; port=3306; User Id=root; Password=wang20000309.");
            mySqlConnection.Open();
            String userNameSql = "select user.userId,userName from user,useraccount where user.userId = useraccount.UserId and UserAccount = '" + userAccount + "' and UserPwd = '" + userPwd +"'";
            MySqlCommand mySqlCommand1 = new MySqlCommand(userNameSql, mySqlConnection);
            MySqlDataReader dr = mySqlCommand1.ExecuteReader();
            dr.Read();
            String name = dr["userName"].ToString();
            username.Text = name;
            dr.Close();
            mySqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin login = new UserLogin();
            login.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdatePwd updatePwd = new UpdatePwd();
            updatePwd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookDisplay bookDisplay = new BookDisplay();
            bookDisplay.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            borrowBook borrow = new borrowBook();
            borrow.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
        }
    }
}
