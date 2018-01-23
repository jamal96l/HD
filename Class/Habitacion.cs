using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDesktop.Class
{
    class Habitacion
    {
        private int _IdHabitacion;
        private int _IdEstado;
        private int _ExtensionTelefonica;
        private int _IdTipo;
        private int _IdHotel;

        public int IdHabitacion
        {
            get { return _IdHabitacion; }
            set { _IdHabitacion = value; }
        }

        public int IdEstado
        {
            get { return _IdEstado; }
            set { _IdEstado = value; }
        }

        public int ExtensionTelefonica
        {
            get { return _ExtensionTelefonica; }
            set { _ExtensionTelefonica = value; }
        }

        public int IdTipo
        {
            get { return _IdTipo; }
            set { _IdTipo = value; }
        }

        public int IdHotel
        {
            get { return _IdHotel; }
            set { _IdHotel = value; }
        }
    }
}
