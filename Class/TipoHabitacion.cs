using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDesktop.Class
{
    class TipoHabitacion
    {
        private int _IdTipo;
        private string _Nombre;
        private int _Capacidad;
        private float _PrecioDiario;

        public int IdTipo
        {
            get { return _IdTipo; }
            set { _IdTipo = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public int Capacidad
        {
            get { return _Capacidad; }
            set { _Capacidad = value; }
        }

        public float PrecioDiario
        {
            get { return _PrecioDiario; }
            set { _PrecioDiario = value; }
        }
    }
}
