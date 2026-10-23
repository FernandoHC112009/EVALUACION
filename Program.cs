using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Escribir la sintaxis para definir una funcion

            /*
            void NombreDeFuncion()
            {
                // cuerpo de la funcion
            }
            NombreDeFuncion();
            */

            // 2. Imprimir la secuencia: 2, 4, 6, 9, 12, 15, 19, 23, 27

            void Secuencia()
            {
                int numero = 2;
                Console.WriteLine(numero);

                for (int i = 0; i < 2; i++)
                {
                    numero += 2;
                    Console.WriteLine(numero);
                }

                for (int i = 0; i < 3; i++)
                {
                    numero += 3;
                    Console.WriteLine(numero);
                }

                for (int i = 0; i < 2; i++)
                {
                    numero += 4;
                    Console.WriteLine(numero);
                }

                numero += 4;
                Console.WriteLine(numero);
            }

            Secuencia();

            // 3. Ciclo descendente si se cumple la condicion

            double inicio = 5;
            double limite = 3;

            void CicloMasMenos(double inicio, double limite)
            {
                if (inicio > limite && (inicio * limite) < 8)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        Console.WriteLine(inicio);
                        inicio--;
                    }
                }
                else
                {
                    for (int i = 0; i < 9; i++)
                    {
                        Console.WriteLine(inicio);
                        inicio++;
                    }
                }
            }

            CicloMasMenos(inicio, limite);

            // 4. Saber si el numero es multiplo de 5

            bool NumeroMultiplo(int numero)
            {
                if (numero % 5 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            int numeroMultiplo = 10;
            bool resultado = NumeroMultiplo(numeroMultiplo);

            Console.WriteLine($"El numero {numeroMultiplo} es multiplo de 5: {resultado}");

            // 5. Funcion para imprimir el texto del examen

            void ImprimirExamen(string examen)
            {
                Console.WriteLine($"Examen: {examen}");
            }

            ImprimirExamen("Programacion III");
        }
    }
}
