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
    public partial class frmQuestionPopUp : Form
    {

        private string question = "";
        private int quizScore = 0;
        //frmMain fm = new frmMain();
        public string result = "";
        SqlConnection sql = null;
        SqlDataAdapter sda = null;
        DataSet ds = new DataSet();
        frmLastPage flp = new frmLastPage();

        public void getQuestion(string ques)
        {
            this.question = ques;
            lblQuestion.Text = this.question;
        }

        public void passData(DataSet dsData)
        {
            ds = dsData.Copy();
        }


        public frmQuestionPopUp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            question = lblQuestion.Text;
            string expression = "question='" + lblQuestion.Text+"'";
            DataRow[] foundrow = ds.Tables[0].Select(expression);
            string val = foundrow[0].ItemArray[1].ToString(); //it returns 2 rows and we are taking only second row[answer column], hence itemArray is 1.
           
            if (txtAnswer.Text.ToUpper() == val.ToUpper())
            {
                quizScore++;
            }

           // MessageBox.Show(quizScore.ToString());
            flp.getScore(quizScore);
            this.Hide();
            txtAnswer.Clear();
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }


        public string Question
        {
            get
            {
                return question;
            }

            set
            {
                question = value;
            }
        }

        private void frmQuestionPopUp_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    sql = Program.dbConnect();
            //    sda = new SqlDataAdapter();
            //    ds = new DataSet();
            //    sql.Open();
            //    sda.SelectCommand = new SqlCommand("Select * from q_bank ;", sql);
            //    result = sda.SelectCommand.ExecuteScalar().ToString();
            //    sda.Fill(ds);
            //    // btnOne.Text = result;
            //    lblQuestion.Text = result;
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


            // finally
            //{
            //    sql.Close();
            //}
        }
    }
}
