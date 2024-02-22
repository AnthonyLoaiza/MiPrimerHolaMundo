using System;

namespace MiPrimerHolaMundo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string ingreso;
            Console.Title = "Ejercicio Matematico en consola";

            Console.WriteLine("Hola!");
            Console.WriteLine();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Ingrese por favor 3 Numeros a los cuales se les hara las siguientes operaciones");
            Console.WriteLine();
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Primer numero -- Hallará el cuadrado");
            Console.WriteLine("Segundo numero -- Hallará la raíz cuadrada");
            Console.WriteLine("Tercer numero -- Hallará la raíz cúbica");
            Console.WriteLine();
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Si tiene todo claro empecemos!!");
            Console.WriteLine();
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Ingrese el Primer Numero y oprima  Enter");
            Console.WriteLine();
            ingreso = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(ingreso, out numero))
            {
                var cuadradoResult = numero * numero;
                Console.WriteLine("El " + numero + " elevado al cuadrado es " + cuadradoResult);
            }
            else
            {
                Console.WriteLine("El valor ingresado no es numerico");
                Console.WriteLine();
                Console.WriteLine("Chao");
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Ingrese el Segundo Numero y oprima  Enter");
            Console.WriteLine();
            ingreso = Console.ReadLine();
            if (int.TryParse(ingreso, out numero))
            {
                var raizCuadradaResult = Math.Sqrt(numero);
                Console.WriteLine("La raiz cuadrada de  " + numero + " es  " + raizCuadradaResult);
            }
            else
            {
                Console.WriteLine("El valor ingresado no es numerico");
                Console.WriteLine();
                Console.WriteLine("Chao");
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Ingrese el Tercer Numero y oprima  Enter");
            Console.WriteLine();
            ingreso = Console.ReadLine();
            if (int.TryParse(ingreso, out numero))
            {
                var raizCubicaResult = Math.Pow(numero, 1.0 / 3.0);
                Console.WriteLine("La raiz cubica de  " + numero + " es  " + raizCubicaResult);
            }
            else
            {
                Console.WriteLine("El valor ingresado no es numerico");
                Console.WriteLine();
                Console.WriteLine("Chao");
                return;
            }
            Console.WriteLine();
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Gracias");
        }
    }
}
