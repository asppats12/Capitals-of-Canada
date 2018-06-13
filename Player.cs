using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GeographyApp
{
    class Player
    {

        private String username;
        private int score;
        // private Connection conn;
        SqlConnection db = new SqlConnection();

        public Player()
        {
            this.score = 0;
        }

        public Player(String username, String score)
        {
            this.username = username;
            this.score = Int32.Parse(score);
        }

        public int getScore()
        {
            return score;
        }

        public String getUsername()
        {
            return username;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        public void updatescore()
        {
            this.score++;
        }
        public void updatePlayerDB()
        {
            try
            {
                SqlCommand s = new SqlCommand("insert into G_USER values (?,?)", db);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
