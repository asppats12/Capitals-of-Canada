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

using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GeographyApp
{
   

    public partial class frmFStartPage : Form
    {
        public frmFStartPage()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();
            fm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection sql = null;
        SqlDataAdapter sda = null;
        DataSet ds;

        private void frmFStartPage_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
             sql = Program.dbConnect();
             sda = new SqlDataAdapter();
             ds = new DataSet();
             sql.Open();
             sda.SelectCommand = new SqlCommand("Select * from g_user ;", sql);
             sda.Fill(ds);


                dt.Columns.Add("Player");
                dt.Columns.Add("Score");

                dt.Rows.Add("", "");
                dt.Rows.Add("", "");
                dt.Rows.Add("", "");
                dt.Rows.Add("", "");
                dt.Rows.Add("", "");
                dt.Rows.Add("", "");
                dt.Rows.Add("", "");
                dt.Rows.Add("", "");
                dt.Rows.Add("", "");
                dt.Rows.Add("", "");

                dataGridView1.DataSource = dt;
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
            
        }

       
    }
}
