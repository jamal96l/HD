using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDesktop.Class
{
    class Reserva
    {
        private int _IdReserva;
        private int _IdHabitacion;
        private int _IdHuesped;
        private DateTime _FechaCheckIn;
        private DateTime _FechaCheckOut;
        private int _CantidadAdultos;
        private int _CantidadNiños;
        private int _HuespedesAdicionales;

        public int IdReserva
        {
            get { return _IdReserva; }
            set { _IdReserva = value; }
        }

        public int IdHabitacion
        {
            get { return _IdHabitacion; }
            set { _IdHabitacion = value; }
        }

        public int IdHuesped
        {
            get { return _IdHuesped; }
            set { _IdHuesped = value; }
        }

        public DateTime FechaCheckIn
        {
            get { return _FechaCheckIn; }
            set { _FechaCheckIn = value; }
        }

        public DateTime FechaCheckOut
        {
            get { return _FechaCheckOut; }
            set { _FechaCheckOut = value; }
        }

        public int CantidadAdultos
        {
            get { return _CantidadAdultos; }
            set { _CantidadAdultos = value; }
        }

        public int CantidadNiños
        {
            get { return _CantidadNiños; }
            set { _CantidadNiños = value; }
        }

        public int HuespedesAdicionales
        {
            get { return _HuespedesAdicionales; }
            set { _HuespedesAdicionales = value; }
        }
    }
}
