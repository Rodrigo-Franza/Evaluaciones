using System;
// Rodrigo Franza 331-10

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ejercicio = 0;


            // 1. Escribir la sintaxis para definir una función
            /*
            tipo_de_dato_devuelto identificador_de_la_función(parametros)
            {
                bloque de instrucciones
                return 
            }

            Notas: 
                1. Los parametros incluyen su tipo de dato, ejemplo: "int numero = 0".
                2. Cada parámetro es separado por comas.
                3. Return solo se utiliza cuando la función devuelve algún valor.
            */
            ejercicio++;
            Console.WriteLine($"\nEjercicio: #{ejercicio}");

            // 2. Definir un ciclo para imprimir la siguiente secuencia: 2, 4, 6, 9, 12, 15, 19, 23, 27
            ejercicio++;
            Console.WriteLine($"\nEjercicio: #{ejercicio}");

            int a = 2;
            int i;

            while (a <= 27)
            {
                if (a < 6)
                {
                    i = 2;
                }
                else if (a < 15)
                {
                    i = 3;
                }
                else
                {
                    i = 4;
                }

                Console.WriteLine(a);

                a += i;
            }

            // 3. Declarar e inicializar 2 variables: inicio, límite. Si el producto de ambos es menor que 8, e inicio es mayor que el límite, definir un ciclo descendente de 9 ejecuciones. En cualquier otro caso, definir un ciclo ascendente.
            ejercicio++;
            Console.WriteLine($"\nEjercicio: #{ejercicio}");

            int inicio = 4;

            int límite = 1;

            int contador;

            if (inicio * límite < 8 && inicio > límite)
            {
                contador = 0;
                for (int e = 9; e > 0; e -= 1)
                {
                    contador++;
                    Console.WriteLine($"Ejecución: {contador}");
                    Console.WriteLine($"Valor de 'e': {e}");
                }
            }
            else
            {
                for (int e = 1; e < 10; e += 1)
                {
                    Console.WriteLine($"'e': {e}");
                }
            }

            // 4. Definir e invocar una función para determinar si un número es múltiplo de 5. Si lo es, devolver true, si no, false. Imprimir empleando interpolación.
            ejercicio++;
            Console.WriteLine($"\nEjercicio: #{ejercicio}");

            bool EsMultiplo(int num)
            {
                if (num % 5 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            int num = 19;

            bool es_multiplo = EsMultiplo(num);

            if (es_multiplo)
            {
                Console.WriteLine($"{num} es múltiplo de 5!");
                Console.WriteLine($"Devolución de la funcion: {es_multiplo}");
            }
            else
            {
                Console.WriteLine($"{num} no es múltiplo de 5...");
                Console.WriteLine($"Devolución de la funcion: {es_multiplo}");
            }

            // 5. Definir e invocar una función vacía para imprimir: "Examen: Programación III", donde "Programación III" corresponda a un argumento.
            ejercicio++;
            Console.WriteLine($"\nEjercicio: #{ejercicio}");

            void darExamen(string materia)
            {
                Console.WriteLine($"Examen: {materia}");
            }

            darExamen("Programación III");

        }
    }
}