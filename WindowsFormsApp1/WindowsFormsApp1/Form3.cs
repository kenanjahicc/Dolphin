using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked == true) {
                String ime = textBox1.Text;
                String email = textBox2.Text;
                String password = textBox3.Text;
                database21DataSet1.User.AddUserRow(ime, password,email);
                this.Hide();
                Form5 f = new Form5();
                f.ShowDialog();
                /*System.Data.OleDb.OleDbConnection oledbconnect = new System.Data.OleDb.OleDbConnection(@"Provider=C:\Users\kenan\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database21.accdb;
                Jet OLEDB:Database");
                oledbconnect.Open();
                System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
                cmd.CommandText = "INSERT User (Username,Password,Email) VALUES ("+ime+","+password+","+email+")";
                cmd.Connection = oledbconnect;
                cmd.ExecuteNonQuery();
                oledbconnect.Close();
                */
                /*if (ime != "" && email != "" && password != "") {
                    
                }*/
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
