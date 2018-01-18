using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDesktop.Class
{
    class Comodidad
    {
        private int _IdComodidad;
        private string _Nombre;

        public int IdComodidad
        {
            get { return _IdComodidad; }
            set { _IdComodidad = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
    }
}
