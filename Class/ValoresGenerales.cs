using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDesktop.Class
{
    class ValoresGenerales
    {
        private int _CedulaJuridica;
        private string _NombreEmpresa;
        private int _ImpuestoVenta;
        private int _ImpuestoConsumo;
        private int _ImpuestoServicio;
        private string _Propietario;
        private string _Direccion;
        private TimeSpan _HoraCheckIn;
        private TimeSpan _HoraCheckOut;

        public int CedulaJuridica
        {
            get { return _CedulaJuridica; }
            set { _CedulaJuridica = value; }
        }

        public string NombreEmpresa
        {
            get { return _NombreEmpresa; }
            set { _NombreEmpresa = value; }
        }

        public int ImpuestoVenta
        {
            get { return _ImpuestoVenta; }
            set { _ImpuestoVenta = value; }
        }

        public int ImpuestoConsumo
        {
            get { return _ImpuestoConsumo; }
            set { _ImpuestoConsumo = value; }
        }

        public int ImpuestoServicio
        {
            get { return _ImpuestoServicio; }
            set { _ImpuestoServicio = value; }
        }

        public string Propietario
        {
            get { return _Propietario; }
            set { _Propietario = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public TimeSpan HoraCheckIn
        {
            get { return _HoraCheckIn; }
            set { _HoraCheckIn = value; }
        }

        public TimeSpan HoraCheckOut
        {
            get { return _HoraCheckOut; }
            set { _HoraCheckOut = value; }
        }
    }
}
