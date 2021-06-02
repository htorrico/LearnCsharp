using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarar variables
            int edad = 0;
            string nombre = "";
            bool EsPeruano = false;
            double sueldo = 8000;


            //Declarar objetos 

            //primera forma
            Persona persona1 = null;
            persona1 = new Persona();
            persona1.Apellidos = "Torrico";
            persona1.Nombres = "Hugo";

            //Segunda forma
            Persona persona2 = new Persona();
            persona2.Apellidos = "Espinosa";
            persona2.Nombres = "Ivan";

            //Tercera forma
            Persona persona3 = new Persona
            {
                Apellidos = "Vicuña",
                Nombres = "Diego"
            };










            Console.WriteLine("Hello world");
            Console.Read();
        }
    }
}
