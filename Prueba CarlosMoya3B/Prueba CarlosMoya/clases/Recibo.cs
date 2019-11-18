using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba_CarlosMoya.clases
{
    class Recibo:Cliente
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
        }
        public void recibo()
        {

        }
        public int CalcularTotal()
        {

        }

    }
}
