using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaCorbit
{
    class Personajes:informacionGeneral
    {
        /*-----------------ATRIBUTOS---------------*/
        private sbyte edad;
        private string genero;
        private string especie;
        private string profesion;
        private sbyte locura;//hacer constructor database json

        /*-----------------METODOS---------------*/
        public Personajes() : base() {
            edad = 0;
            genero = "Queen gender drag";
            especie = "humano";
            miProfesion = "Doctor patricio calamardo";
            locura = 1;
        }


        public string miNombre
        {
            set => base.verNombre= value;
            get => base.verNombre;        
        }

        public sbyte miEdad
        {
            set => edad = value;
            get => edad;
        }

        public string miGenero
        {
            set => genero = value;
            get => genero;
        }

        public string miEspecie
        {
            set => especie = value;
            get => especie;
        }

        public string miProfesion
        {
            set => profesion = value;
            get => profesion;
        }

        public string miDescripcion
        {
            set => base.verDescripcion = value;
            get => base.verDescripcion;
        }

        public string miHistoria
        {
            set => base.verTransfondo = value;
            get => base.verTransfondo;
        }
        public override string ToString() => base.ToString() + "\nedad : " + edad + "\nespecie :" + especie + "\ngenero : " + genero + "\nprofesion :" + profesion + "\nlocura : " + locura; 

    }
}
