using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDesktop.Class
{
    class Estado
    {
        private int _IdEstado;
        private string _Nombre;

        public int IdEstado
        {
            get { return _IdEstado; }
            set { _IdEstado = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

    }
}