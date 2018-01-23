using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDesktop.Class
{
    class HuespedReserva
    {
        private int _IdReserva;
        private int _IdHuesped;

        public int IdReserva
        {
            get { return _IdReserva; }
            set { _IdReserva = value; }
        }

        public int IdHuesped
        {
            get { return _IdHuesped; }
            set { _IdHuesped = value; }
        }
    }
}
