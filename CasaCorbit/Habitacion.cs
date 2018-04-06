using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaCorbit
{
    class Habitacion:informacionGeneral
    {
        /*-----------------ATRIBUTOS---------------*/
        private string ocupando;
        private string[] ocupandos;

        /*-----------------CONSTRUCTOR---------------*/
        public Habitacion(string n, string d, string o, string t, sbyte maxCantidadOcupadores)
        {
            base.verNombre = n;
            base.verDescripcion = d;
            base.verTransfondo = t;
            ocupando = o;
            ocupandos = new string[maxCantidadOcupadores];
            for (sbyte i = 0; i < ocupandos.Length; i++)
                ocupandos[i] = "";
        }
        public Habitacion()
        {
            base.verNombre = "n/a";
            base.verDescripcion = "n/a";
            base.verTransfondo = "n/a";
            ocupando = "n/a";
            ocupandos = new string[5];
            for (sbyte i = 0; i < ocupandos.Length; i++)
                ocupandos[i] = "";
        }

        /*-----------------METODOS---------------*/
        public string miTransfondo
        {
            set => base.verTransfondo = value;
            get => base.verTransfondo;
        }

        public bool toctoc(string[] g)
        {
            return false;
        }

        public string toctoc()
        {
            string cache = "";

            for(sbyte i = 0; i < ocupandos.Length; i++)
            {
                if (ocupandos[i] == "")
                    break;

                cache = cache + ocupandos[i] + ", ";
            }

            return cache;
        }

        public string nombreHabitacion
        {
            set => base.verNombre = value;
            get => base.verNombre;
        }
        public string descripcionHabitacion //nombre descripcion
        {
            get => base.verDescripcion;
            set => base.verDescripcion = value;
        }
        public bool puertas(string [] habitacion)
        {
            return false;
        }
        public bool agregar_persona(string habitante)
        {
            sbyte i;
            for(i = 0; i < ocupandos.Length; i++)
            {
                Console.WriteLine(ocupandos[i]);
                if(ocupandos[i] == "")
                {
                    ocupandos[i] = habitante;
                    return true;
                }
            }

            return false;
        }
        public bool mover(string m)
        {
            return false;
        }

        public string salir(string expulsado)
        {
            if (ocupandos[ocupandos.Length-1] == expulsado) //ocupandos = max ocupandos (5), expulsado = nombre que se envia, ej "Raquel"
            {
                ocupandos[ocupandos.Length - 1] = "";
                return expulsado;
            }

            sbyte i;
            for (i = 0; i < ocupandos.Length; i++)//recorriendo
                if (ocupandos[i] == expulsado)//Se elimina, se deja vacio dentro de los arreglos
                    break;

            for(; i < ocupandos.Length-1; i++) //Se queda en la misma posicion del anterior ciclo for
            {
                ocupandos[i] = ocupandos[i + 1];//recorriendo arreglo

                if (ocupandos[i + 1] == "")//Rompe el ciclo si encuentra un vacio
                    break;
            }

            ocupandos[i] = "";

            return expulsado;

        }

        public void resetear()
        {
            for (sbyte i = 0; i < ocupandos.Length; i++)
                ocupandos[i] = "";
        }

        public string suceso(string victima, string evento)
        {
            return "holi compa";
        }

        public bool estasAhi(string sujetoHabitando)
        {
            for (sbyte i = 0; i < ocupandos.Length; i++)
                if (ocupandos[i] == sujetoHabitando)
                    return true; 
            
            return false;
        }

        public override string ToString() => base.ToString() + "\nhuespedes : " + toctoc();

    }
}
