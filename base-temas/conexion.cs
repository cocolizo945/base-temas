using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Wind
{
    public class conexion
    {
        public conexion()
        {
        }

        public static MySqlConnection conex(){
            string server = "localhost";
            string user = "root";
            string pass = "123456789";
            string db = "libreria";
			
            string chain = "server ="+server+"; user ="+user+"; pwd="+pass+"; database="+db+" ;";
			
            try{MySqlConnection cn = new MySqlConnection(chain);
                MessageBox.Show("conexion exitosa");
                    
                return cn;
				
            }catch(MySqlException ex){
                MessageBox.Show(ex.Message + "\n conexion fallida");
                return null;
				
            }
        }
    }
}