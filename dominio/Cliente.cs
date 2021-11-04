using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyFarmaceutica.dominio
{
    class Cliente
    {
        public int Documento { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }

        public Cliente(int doc,string nom, string ape)
        {
            Documento = doc;
            NombreCliente = nom;
            ApellidoCliente = ape;
        }

        public Cliente()
        {
        }
    }
}
