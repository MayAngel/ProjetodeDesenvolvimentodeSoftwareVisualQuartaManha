namespace ListaExercicio.Views


public class Exe02
{
    public static void Renderizar()
    {
        double real, dolar;
        Console.WriteLine("Digite o valor em R$: ");
        real = Convert.ToDouble(Console.ReadLine());
        dolar = real / 5.17;
        Console.WriteLine($"dolar: { dolar }");
        
    }
}

//Crie um algoritmo que permita fazer três conversões monetárias. 
//O algoritmo deve receber o valor em real (R$) e apresentar os valores convertidos
// em:
//Dólar (1 dólar = 5,17 reais)
//Euro (1 euro = 6,14 reais)
//Peso argentino (1 peso argentino = 0,05 reais)//
