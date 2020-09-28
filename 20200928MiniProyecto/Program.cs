using System;

namespace MiniProyecto28septiembre
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Pedir al usuario que introduzca su nombre.
                Mostrar en pantalla el mensaje “Cliente..” con el nombre introducido.*/
            Console.WriteLine("Hola. Introduzca a continuacion su nombre");
            string nombreusuario = Console.ReadLine();
            Console.WriteLine("Bienvenido al sistema cliente " + nombreusuario);

            /*  Pedir al usuario su edad y guardarlo en una variable de tipo int. 
                Mostrar en pantalla el mensaje “Cliente (nombre) de (edad) años”.*/
            Console.WriteLine("Ahora, por favor, introduzca su edad");
            string edadusuariotxt = Console.ReadLine();
            int edadusuario = Convert.ToInt32(edadusuariotxt);
            Console.WriteLine("Cliente " + nombreusuario + ", de " + edadusuario + " años");
            if (edadusuario <= 17)
            {
                Console.WriteLine("Usted por ser menor de edad no puede alquilar un coche");
            }

            /*  Preguntar al usuario si tiene carnet de conducir. Aceptar sólo la respuesta S, s, N o n.
                Dependiendo de si es sí o no, poner el valor de un booleano a true o false.*/
            if (edadusuario >= 18)
                Console.WriteLine("¿Tiene usted carnet de conducir? (S)i o (N)o");
            string respuestaTec = Console.ReadLine();
            string respuestaMayuscula = respuestaTec.ToUpper();

            bool respuesta;

            if (respuestaMayuscula == "S")
            {
                respuesta = true;
                Console.WriteLine("si tienes carnet de conducir");

                /*  Mostrar en pantalla el mensaje “Cliente (nombre) de (edad) años” 
                    y dependiendo de si ha dicho que tiene o no tiene carnet acabar la frase con 
                    “con carnet de conducir” o “sin carnet de conducir”.*/
                Console.WriteLine("Cliente " + nombreusuario + " de " + edadusuario + ", con carnet de conducir");
                Console.WriteLine("¿Donde recogerá el coches?");
                Console.WriteLine("1. Bilbao.");
                Console.WriteLine("2. Madrid.");
                Console.WriteLine("3. Barcelona.");
                Console.WriteLine("4. Santander.");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Su coche le espera en Bilbao.");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Su coche le espera en Madrid.");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Su coche le espera en Barcelona.");
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Su coche le espera en Santander.");
                }
                Console.WriteLine("¿Cuántos días quieres el coche?");
                int dias = Int32.Parse(Console.ReadLine());
                int diasSem = 7;
                int semanas = dias / diasSem;
                Console.Write(" Y alquilas el coche durante ");
                if (semanas > 0)
                {
                    Console.Write(semanas + " semanas y " + dias % 7 + " días");
                }
                else if (semanas < 1)
                {
                    Console.Write(dias + " días");
                }
                int precioDia = 10;
                Console.WriteLine(" por un precio de " + (dias - semanas) * precioDia + " Euros.");//DESCUENTO POR SEMANA AQUI
            }
            else if (respuestaMayuscula == "N")
            {
                respuesta = false;
                Console.WriteLine("No tienes carnet de conducir");
            }
            else
            {
                Console.WriteLine("Llegó al final del programa");
            }
        }
    }
}
