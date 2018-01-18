using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDesktop.Class
{
    class ValoresGenerales
    {
        public int CedulaJuridica { get; set; }
        public String NombreEmpresa { get; set; }
        public int ImpuestoVenta { get; set; }
        public int ImpuestoConsumo { get; set; }
        public int ImpuestoServicio { get; set; }
        public String Propietario { get; set; }
        public String Direccion { get; set; }
        public TimeSpan HoraCheckIn { get; set; }
        public TimeSpan HoraCheckOut { get; set; }
    }
}
