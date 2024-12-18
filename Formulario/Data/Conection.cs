using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace Formulario.Data
{

   




    internal class Conection
    {

            public static string server = "127.0.0.1";
            public static string DataBase = "login";
            public static string User = "root";
            public static string passw = "123456";

        public static MySqlConnection connMaster = new MySqlConnection();

        public static void OpenConection()
        {
            String connectionString = $"server={server}; database={DataBase};user={User};password={passw};";

            connMaster = new MySqlConnection(connectionString);



            connMaster.Open();

            if (connMaster.State == ConnectionState.Open)
            {
                {
                    MessageBox.Show("Conexion realizada");
                }

            }
            else
            {
                MessageBox.Show("No se ha establecido conexion");
            }
        }

        public void CloseConection()
        {


        }
    }
}
