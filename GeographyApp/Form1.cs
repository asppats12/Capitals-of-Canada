using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GeographyApp
{
    public partial class Form1 : Form
    {
        SqlConnection sql = null;
        SqlDataAdapter sda = null;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            sql = Program.dbConnect();
            sda = new SqlDataAdapter();
            ds = new DataSet();
            sql.Open();
            sda.SelectCommand = new SqlCommand("Select * from q_bank",sql);
            String result = sda.SelectCommand.ExecuteScalar().ToString();
            sda.Fill(ds);
            
            btn1.Text = result;

            sql.Close();
            
        }
    }
}
