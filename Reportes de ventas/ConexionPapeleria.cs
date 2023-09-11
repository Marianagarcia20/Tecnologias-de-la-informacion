using SqlClient = System.Data.SqlClient;

namespace Reportes_de_ventas
{
    internal class ConexionPapeleria
    {
       
        public static SqlClient.SqlConnection conexion = new SqlClient.SqlConnection(@"data source= LENOVO20\SQLEXPRESS ; initial catalog =papeleria; integrated security=SSPI; persist security info = false; trusted_connection = yes;");
        // Nos permite ejecutar los comandos que tiene almacenados de sql
        public static SqlClient.SqlCommand cmd;
        // Permite leer los datos
        public static SqlClient.SqlDataReader sqlread;
    }
}
