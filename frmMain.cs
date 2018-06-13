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

    public partial class frmMain : Form
    {
        frmQuestionPopUp qp = null;
        public string result = "";
        SqlConnection sql = null;
        SqlDataAdapter sda = null;
        DataSet ds;
        

        Player player;

        public DataSet getQuestion()
        {
            ds = new DataSet();
            sql = Program.dbConnect();
            sda = new SqlDataAdapter();
            ds = new DataSet();
            sql.Open();
            sda.SelectCommand = new SqlCommand("Select * from q_bank ;", sql);
            sda.Fill(ds);
            return ds;
        }
       
        private void frmMain_Load(object sender, EventArgs e)
        {
            player = new Player();
            qp = new frmQuestionPopUp();
            getQuestion();
            qp.passData(ds);
        }

        public frmMain()
        {
            InitializeComponent();    
        }
        
        private void btnOne_Click(object sender, EventArgs e)
        {
            qp.getQuestion(ds.Tables[0].Rows[0]["question"].ToString());
            qp.Show();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            qp.getQuestion(ds.Tables[0].Rows[1]["question"].ToString());
            qp.Show();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            qp.getQuestion(ds.Tables[0].Rows[2]["question"].ToString());
            qp.Show();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            qp.getQuestion(ds.Tables[0].Rows[3]["question"].ToString());
            qp.Show();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            qp.getQuestion(ds.Tables[0].Rows[4]["question"].ToString());
            qp.Show();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            qp.getQuestion(ds.Tables[0].Rows[5]["question"].ToString());
            qp.Show();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            qp.getQuestion(ds.Tables[0].Rows[6]["question"].ToString());
            qp.Show();
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            qp.getQuestion(ds.Tables[0].Rows[7]["question"].ToString());
            qp.Show();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            qp.getQuestion(ds.Tables[0].Rows[8]["question"].ToString());
            qp.Show();
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            qp.getQuestion(ds.Tables[0].Rows[9]["question"].ToString());
            qp.Show();
        }

        private void btnEleven_Click(object sender, EventArgs e)
        {
            qp.getQuestion(ds.Tables[0].Rows[10]["question"].ToString());
            qp.Show();
        }

        private void btnTwelve_Click(object sender, EventArgs e)
        {
            qp.getQuestion(ds.Tables[0].Rows[11]["question"].ToString());
            qp.Show();
        }

        private void btnThirteen_Click(object sender, EventArgs e)
        {
            qp.getQuestion(ds.Tables[0].Rows[12]["question"].ToString());
            qp.Show();
        }

        private void btnFourteen_Click(object sender, EventArgs e)
        {
            qp.getQuestion(ds.Tables[0].Rows[13]["question"].ToString());
            qp.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            frmLastPage flp = new frmLastPage();
            flp.Show();
        }
    }
}

