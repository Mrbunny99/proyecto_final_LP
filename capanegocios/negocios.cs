using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace capanegocios
{
    public class negocios
    {
               

        public static void Insertar(string firstname, string lastname,string address, string phone, string email)
        {
            Conexion.execute("insert into contact (firstname,lastname,address,phone,email) values ('" + firstname + "','" + lastname  +"','" + address + "','" + phone + "','" + email + "')");

        }
        
    }
}
