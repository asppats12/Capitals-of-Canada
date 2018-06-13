using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GeographyApp
{
    //SERVER NAME:LAPTOP-0V2GT8F0\SQLEXPRESS
    static class Program
    {
         [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmFStartPage());
           
           
        }

        public static string conString = "Data Source=desktop-ef112ac\\sqlexpress01;Initial Catalog=canadian_capitals;Integrated Security=True";


        public static SqlConnection dbConnect()
        {
            return new SqlConnection(conString);
        }
    }
}
