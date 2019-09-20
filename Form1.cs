using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Sqlite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
           
            
        }

        private void cmdExecuteQuery_Click(object sender, EventArgs e)
        {
            SQLiteConnection conx = new SQLiteConnection("Data Source=C:\\SQLite3\\myda.db;Version=3");
            conx.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conx;
            cmd.CommandText = querytxt.Text;
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                conx.Close();
                grid1.DataSource = dt;
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
    }
}
