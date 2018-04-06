using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaCorbit
{
    class informacionGeneral
    {
        private string nombre;
        private string descripcion;
        private string transfondo;

        public informacionGeneral()
        {
            transfondo = "No tiene historia";
            nombre = "No existente";
            descripcion = "descripcion vacia";
        }

        public informacionGeneral(string miNombre, string miDescripcion, string miHistoria)
        {
            nombre = miNombre;
            descripcion = miDescripcion;
            transfondo = miHistoria;
        }

        public string verTransfondo
        {
            get => transfondo;
            set => transfondo = value;
        }

        public string verNombre
        {
            set => nombre = value;
            get => nombre;
        }

        public string verDescripcion
        {
            set => descripcion = value;
            get => descripcion;
        }

        public override string ToString() => "nombre : " + nombre + "\ndescripcion : " + descripcion + "\ntransfondo : " + transfondo;
    }
}
