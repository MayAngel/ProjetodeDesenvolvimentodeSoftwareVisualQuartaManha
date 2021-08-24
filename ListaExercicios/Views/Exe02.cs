using System;   

namespace ListaExercicios.Views
{
    public class Exe02

    {
        public static void Renderizar ()
        {
            const double VALOR_DOLAR_ATUAL = 5.17;
            double real, dolar;
            Console.WriteLine("Digite o valor em real: ");
            real=Convert.ToDouble(Console.ReadLine());
            dolar=real/5.17;
            Console.WriteLine($"Dolar:  { dolar.ToString("F2") }");
        }
        
    }
}