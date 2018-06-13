using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GeographyApp
{
     class Program
    {
        public static string conString = "Data Source=LAPTOP-0V2GT8F0\\SQLEXPRESS;Initial Catalog=HRDB;Integrated Security=True";
       

       [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }

        public static SqlConnection dbConnect()
        {
            return new SqlConnection(conString);
        }

    }

}
