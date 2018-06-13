using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeographyApp
{
    public partial class frmLastPage : Form
    {
        SqlConnection sql = null;
        SqlDataAdapter sda = null;

        static int displayScore = 0;
        string username = "";

        public frmLastPage()
        {
            InitializeComponent();
            lblScore.Text = displayScore.ToString();
        }

        public void getScore(int score)
        {
            displayScore = score;

        }

        private void btnSUbmit_Click(object sender, EventArgs e)
        {
            try
            {
                sql = Program.dbConnect();
                sql.Open();
                string query = "Insert into g_user (Name, Score) VALUES(@username, @displayScore)";

                SqlCommand cmd = new SqlCommand(query, sql);
                SqlParameter p1 = cmd.Parameters.Add("@username", SqlDbType.VarChar, 50, "Name");
                SqlParameter p2 = cmd.Parameters.Add("@displayScore", SqlDbType.Int, 4, "Score");

                p1.Value = txtName.Text;
                p2.Value = displayScore;
                
                cmd.ExecuteNonQuery();
                sql.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }

        }
    }
}
