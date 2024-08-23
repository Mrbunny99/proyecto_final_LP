using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {


        public static OleDbConnection conexion = null;
        public static OleDbConnection getCon()
        {
            if (conexion == null)
            {
                try
                {
                    OleDbConnectionStringBuilder b = new OleDbConnectionStringBuilder();
                    b.Provider = "Microsoft.ACE.OLEDB.12.0";
                    b.DataSource = "C:\\Arquitectura_capas\\Arquitectura_capas\\Arquitectura 3 capas\\bin\\contacts.accdb";
                    conexion = new OleDbConnection(b.ToString());
                    conexion.Open();
                }
                catch (OleDbException e)
                {
                    Console.WriteLine(e.Message);
                    System.Environment.Exit(1);
                }
            }
            return conexion;
        }

        public static void execute(String sql)
        {
            OleDbCommand cmd = new OleDbCommand(sql, getCon());
            cmd.ExecuteNonQuery();
        }

        public static OleDbDataReader read(String sql)
        {
            OleDbCommand cmd = new OleDbCommand(sql, getCon());
            return cmd.ExecuteReader();
        }
    }
}
