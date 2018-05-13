using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones_Delfinario.DTO
{
    public class DTO_Entrar
    {
        private String ms_Usuario;
        private String ms_Contraseña;

        public String Usuario
        {
            get
            {
                return ms_Usuario;
            }
            set
            {
                ms_Usuario = value;
            }
        }

        public String Contraseña
        {
            get
            {
                return ms_Contraseña;
            }
            set
            {
                ms_Contraseña = value;
            }
        }
    }
}
