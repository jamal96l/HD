using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDesktop.Class
{
    class Reserva
    {
        private int ID_Reserva { get; set; }
        private int ID_Habitacion { get; set; }
        private int ID_Huesped { get; set; }
        private DateTime FechaCheckIn { get; set; }
        private DateTime FechaCheckOut { get; set; }
        private int CantidadAdultos { get; set; }
        private int CantidadNiños { get; set; }
        private int HuespedesAdicionales { get; set; }
    }
}
