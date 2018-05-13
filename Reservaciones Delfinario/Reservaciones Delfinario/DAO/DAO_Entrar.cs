using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones_Delfinario.DAO
{
    public class DAO_Entrar
    {
        private String Query = "";

        public String Entrar(String usuario, String Contraseña)
        {
            Query = "Select * from tbl_usuarios where usuario = '" + usuario + "' && clave = '" + Contraseña + "';";
            return Query;
        }

    }
}
