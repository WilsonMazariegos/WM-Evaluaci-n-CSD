using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Evaluacion_IM
{
    class conexion
    {
        String cadena = "Data Source=DESKTOP-T8BBLEA\\SQLEXPRESS; Initial Catalog=DbEvaluacion; Integrated Security=True";
        public SqlConnection conection = new SqlConnection();

        public conexion(){
            conection.ConnectionString = cadena;
        }

        public void openConexion(){
            try{
                conection.Open();
                Console.WriteLine("Conexion realizada");
            }catch(Exception ex){
                Console.WriteLine("Conexion fallo "+ex);
            }
        }
        public void closeConexion(){
            try{
                conection.Close();
                Console.WriteLine("Conexion finalizada");
            }catch(Exception ex){
                Console.WriteLine("Conexion fallo "+ex);
            }
        }
    }
}
