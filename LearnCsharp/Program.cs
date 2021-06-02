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
            persona1.Edad = 33;

            //Segunda forma
            Persona persona2 = new Persona();
            persona2.Apellidos = "Espinosa";
            persona2.Nombres = "Ivan";
            persona2.Edad = 45;

            //Tercera forma
            Persona persona3 = new Persona
            {
                Apellidos = "Vicuña",
                Nombres = "Diego",
                Edad=40
            };
            Persona persona4 = new Persona
            {
                Apellidos = "Mendoza",
                Nombres = "Franz",
                Edad=20
            };
            Persona persona5 = new Persona
            {
                Apellidos = "Cadenas",
                Nombres = "Oswaldo",
                Edad=28
            };

            Persona persona6 = new Persona
            {
                Apellidos = "Ordoñez",
                Nombres = "Liz",
                Edad=18
            };

            Persona persona7 = new Persona
            {
                Apellidos = "Riega",
                Nombres = "Renzo",
                Edad=15
            };

            //Utilizar los objetos
            //Mostrando uno por uno
            Console.WriteLine(persona1.Nombres + " "+ persona1.Apellidos);
            Console.WriteLine(persona2.Nombres + " " + persona2.Apellidos);
            Console.WriteLine(persona3.Nombres + " " + persona3.Apellidos);

            //Crear una colección de personas

            List<Persona> personas = new List<Persona>();
            personas.Add(persona1);
            personas.Add(persona2);
            personas.Add(persona3);
            personas.Add(persona4);
            personas.Add(persona5);
            personas.Add(persona6);
            personas.Add(persona7);

            //Bucles en C#
            Console.WriteLine(" ");
            foreach (var item in personas)
            {
                Console.WriteLine(item.Nombres + " " + item.Apellidos);
            }

            //Quien es el mayor de todos
            //Quien es el menor de todos

            string PersonaMayor = string.Empty;
            int EdadMayor = 0;


            Console.WriteLine(" ");
            foreach (var item in personas)
            {
                if (item.Edad > EdadMayor)
                { 
                    EdadMayor = item.Edad;
                    PersonaMayor = item.Nombres + " " + item.Apellidos;
                }
            }
                        
            Console.WriteLine("El mayor es " + PersonaMayor + " con " + Convert.ToString( EdadMayor) + " años");
            

            Console.Read();
        }
    }
}
