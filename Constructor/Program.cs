using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();
            contacto1.Nombre = "Jose";
            contacto1.Celular = "6878728937";
            contacto1.Telefono = "8720689";
            contacto1.Correo = "Jose_Pablo@gmail.com";

            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Correo: " + contacto1.Correo);
            Console.WriteLine("Direccion: " + contacto1.Direccion);

            Contacto contacto2 =
                new Contacto("Juan", "Juan_Zaragoza@gmail.com");
            Console.WriteLine("Contacto 2: ");
            Console.WriteLine("Nombre: " + contacto2.Nombre);
            Console.WriteLine("Direccion: " + contacto2.Direccion);

            Console.Read();
        }
    }
}
