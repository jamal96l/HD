using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDesktop.Class
{
    class Huesped
    {
        private int _IdHuesped;
        private string _Nombre;
        private string _PrimerApellido;
        private string _SegundoApellido;
        private string _Correo;
        private int _Telefono;
        private string _Nacionalidad;
        private DateTime _FechaDeNacimiento;

        public int IdHuesped
        {
            get { return _IdHuesped; }
            set { _IdHuesped = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string PrimerApellido
        {
            get { return _PrimerApellido; }
            set { _PrimerApellido = value; }
        }

        public string SegundoApellido
        {
            get { return _SegundoApellido; }
            set { _SegundoApellido = value; }
        }

        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }

        public int Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public string Nacionalidad
        {
            get { return _Nacionalidad; }
            set { _Nacionalidad = value; }
        }

        public DateTime FechaDeNacimiento
        {
            get { return _FechaDeNacimiento; }
            set { _FechaDeNacimiento = value; }
        }
    }
}