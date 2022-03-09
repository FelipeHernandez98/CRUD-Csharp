using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCsharp.Logica
{
    class logicaUsuarios
    {
        private int id_usuario;
        private String usuario;
        private String contraseña;
        private byte[] icono;
        private String estado;

        public int Id_usuario
        {
            get { return id_usuario;  }
            set { id_usuario = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public byte[] Icono
        {
            get { return icono; }
            set { icono = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public logicaUsuarios()
        {

        }

        public logicaUsuarios(int id_usuario, string usuario, string contraseña, byte[] icono, string estado)
        {
            Id_usuario = id_usuario;
            Usuario = usuario;
            Contraseña = contraseña;
            Icono = icono;
            Estado = estado;
        }


    }
}
