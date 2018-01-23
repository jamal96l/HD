using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDesktop.Class
{
    class TipoHabitacionComodidad
    {
        private int _IdComodidad;
        private int _IdTipo;

        public int IdComodidad
        {
            get { return _IdComodidad; }
            set { _IdComodidad = value; }
        }

        public int IdTipo
        {
            get { return _IdTipo; }
            set { _IdTipo = value; }
        }
    }
}
