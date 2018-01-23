using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDesktop.Class
{
    class Hotel
    {
        private int _IdHotel;
        private string _Nombre;
        private string _Direccion;
        private int _Telefono;

        public int IdHotel
        {
            get { return _IdHotel; }
            set { _IdHotel = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public int Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
    }
}
