using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJCALA
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Básica 2025.");
            calucle();
            Console.ReadKey();
        }

        static float Soma(float A, float B)
        {
            return A + B;
        }

        static float Multiplica(float A, float B)
        {
            return A * B;
        }

        static float Subtrai(float A, float B)
        {
            return A - B;
        }

        static float Divide(float A, float B)
        {
            return A / B;
        }

        static float DigitaFloat(String mensagem)
        {
            float ret = 0;
            bool ok;
            do
            {
                Console.Write(mensagem);
                String snum = Console.ReadLine();
                ok = float.TryParse(snum, out ret);
                if (!ok)
                {
                    Console.WriteLine("Número digitado invalido...");
                }
            } while (!ok);
            return ret;
        }

        static void calucle()
        {

            float A = DigitaFloat("Digite o primeiro valor: ");
            float B = DigitaFloat("Digite o segundo valor: ");

            Console.Write("Qual operação? +,-,* ou /");

            string op;
            bool ok;

            do
            {
                op = Console.ReadLine();
                ok = (op == "+" || op == "-" || op == "*" || op == "/");

                if (!ok)
                {
                    Console.WriteLine("Operação solicitada não existe.");
                }

            } while (!ok);


            float resultado = 0;

            switch (op)
            {
                case "+": resultado = Soma(A, B); break;
                case "-": resultado = Subtrai(A, B); break;
                case "*": resultado = Multiplica(A, B); break;
                case "/": resultado = Divide(A, B); break;
                default: resultado = 0; Console.WriteLine("Operador não existe"); break;
            }

            Console.WriteLine("Resultado: " + A + " " + op + " " + B + " = "  + resultado);

        }

    }
}