using System;

namespace ListaExercicios.Views
{
    public class Exe01
    
    {

        public static void Renderizar ()
        {
        int altura, largura;
        double area;
        Console.WriteLine("Escreva a altura: ");
        altura = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escreva a largura: ");
        largura = Convert.ToInt32(Console.ReadLine());
        area=largura*altura;
        Console.WriteLine($"Área:   { area }");
        }
    }
}