using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContinuarEnElPrograma();
        }
            static void Calculo()
            {
                char operador;
                Console.WriteLine("Ingrese la operacion que desea realizar(+,-,*,/)");
                operador = Convert.ToChar(Console.ReadLine());
                dynamic num1;
                dynamic num2;
                Console.WriteLine("Ingrese el primer numero:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero:");
                num2 = Convert.ToInt32(Console.ReadLine());

                switch (operador)
                {
                    case '+':
                        Console.WriteLine($"El resultado de sumar {num1} y {num2} es : {num1 + num2}");
                        break;
                    case '-':
                        Console.WriteLine($"El resultado de restar {num1} y {num2} es : {num1 - num2}");
                        break;
                    case '*':
                        Console.WriteLine($"El resultado de multiplicar {num1} y {num2} es : {num1 * num2}");
                        break;
                    case '/':
                        Console.WriteLine($"El resultado de dividir {num1} y {num2} es : {num1 / num2}");
                        Console.WriteLine($"Y el resto es: {num1 % num2}");
                        break;
                    default:
                        Console.WriteLine("El operador ingresado fue incorrecto.");
                        break;
                }

            }
            static void ContinuarEnElPrograma()
            {
                string stop = "y";

                while (stop != "n")
                {
                    Calculo();
                    Console.WriteLine("Presione N para finalizar o cualquier tecla para continuar.");
                    stop = Console.ReadLine();
                    stop.ToLower();
                }
            }
        }
    }

