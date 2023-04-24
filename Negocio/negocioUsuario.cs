using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Entidades;


namespace Negocio
{
    public class  negocioUsuario
    {

        private usuarioDao userDao = new usuarioDao();

        public bool registrarse(usuario user)
        {
            return userDao.insertarUsuario(user);

        }

        public bool existeUsuario(usuario user)
        {
            return userDao.existeUsuario(user);
        }

        public usuario cargarSession(usuario user)
        {
            return userDao.cargarSession(user);
        }

        public bool cargarPP(string pp,usuario user)
        {

            return userDao.cargarPP(pp, user);
            
        }

    }
}
