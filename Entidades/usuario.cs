using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class usuario
    {
        private string nombreUsuario;
        private string contraseña;
        private string mail;
        private string pp;
        private string estado;
        public usuario()
        {
            this.nombreUsuario = "null";
            this.contraseña = "null";
            this.mail = "null";
            this.pp = "null";
            this.Estado = "false";

        }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Pp { get => pp; set => pp = value; }

        public usuario(string nombreUsuario, string contraseña, string pp,string mail)
        {
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.mail = mail;
            this.pp = pp;
        }


    }
}
