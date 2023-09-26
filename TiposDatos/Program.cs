using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TiposDatos
{
    internal class Program
    {

        struct Auto             //struct para crear estructuras es como una clase pero mas simple
        {                     

            public string marca;
            public int modelo;
            public string tipo;
        }
        static void Main(string[] args)
        {
            //Tipos de datos
            int num1, num2; //variable tipo entero
            long large = 0; //enteros numeros grandes
            byte b = 255; //despues de 256 da error y solo positivos
            short s = 255; //mas grande que el byte pero mas pequeño que el int
            float flotante = 3.14f;
            double doble = 25.564894D; //flotante con numeros grandes
            decimal deci = 2555.36m;
            Boolean boleano = false;
            char caracter = 'a'; //solo un caracter
            string cadena = "Hoy es lunes";

            var variable = "Mi nombre es"; //var se convierte en la variable pero no se puede cambiar el valor despues
            dynamic dinamico = 20; // tambien se convierte en la variable pero puede cambiar su valor 
            dinamico = "esto es C#";
           

            Auto carro;     //struct
            carro.marca = "BMW";
            carro.tipo = "Sedan";
            carro.modelo = 2024;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Marca: " + " Tipo: " + " Modelo: ");
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(carro.marca + " " + carro.tipo + "  " + carro.modelo); //contatenacion

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Carro:{0} Tipo:{1} Marca:{2}", carro.marca, carro.tipo, carro.modelo); //referencia

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Carro:{carro.marca}\nTipo:{carro.tipo}\nModelo:{carro.modelo}"); //interpolacion

            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("-----------------------------------------------");

            Console.ForegroundColor = ConsoleColor.White;
            num1 = 20; num2 = 5;
            Console.WriteLine(num1+num2);
            Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
            Console.WriteLine("La multiplicacion es: {0}", num1 * num2);
            Console.WriteLine("Digite un numero");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite un numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            int resultado = num1 - num2;
            int resultado2 = num1 / num2;
            // num1 = int.Parse(Console.ReadLine()); otra forma de pasar string to int

            Console.WriteLine(flotante + doble); //solo de esta forma se puede porque son diferentes tipos
           // float resultado3 = flotante + float.Parse(doble.ToString());
            var resultado3 = flotante + doble;
            Console.WriteLine($"La resta es {resultado}");
            Console.WriteLine($"La division es {resultado}");

            int[] notas = new int[] {100,80,90,78}; //puede ponerse sin el new int[]
            //                          0  1  2 3
            string[] estudiantes = new string[4];
            estudiantes[0] = "Luis";
            estudiantes[1] = "Maria";
            estudiantes[2] = "Karla";
            estudiantes[3] = "Carlos";

            for (int i = 0; i <=3; i++)  //for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine(notas[i]);
            }

            if (true)
            {

            }
            while (true) 
            { 
            
            }

            Console.ReadLine();

        }
    }


}
