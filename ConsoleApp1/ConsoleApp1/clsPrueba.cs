using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class clsPrueba
    {
        static List<Persona> personas = new List<Persona>();

        static void Main(string[] args)
        {
            llenarLista();

            foreach (var item in personas){
                System.Diagnostics.Debug.Print(item.nombres);
                System.Console.WriteLine(item.nombres);
            }

            System.Console.ReadKey();
        }

        static void llenarLista() {
            agPersona("Gustavo", "Tun", 19, "Cobán");
            agPersona("Andrea", "Ibáñez", 20, "Táctic");
            agPersona("Emanuel", "De la Cruz", 20, "Cobán");
            agPersona("Carlos", "Caal", 19, "Cobán");
            agPersona("hola", "", 12, "");
        } 
        

        /// <summary>
        /// Método que permite agregar personas a una lista
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="edad">Edad de la persona</param>
        /// <param name="direccion">Dirección de la persona</param>
        static void agPersona(string nombre, string apellido, int edad, string direccion) {
            Persona p = new Persona();
            p.nombres = nombre;
            p.apellidos = apellido;
            p.edad = edad;
            p.direccion = direccion;
            personas.Add(p);
        }
    }
}
