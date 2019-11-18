using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba_CarlosMoya.clases
{
    class Asiento:Recibo
    {
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public void Asiento()
        {

        }
    }
}
