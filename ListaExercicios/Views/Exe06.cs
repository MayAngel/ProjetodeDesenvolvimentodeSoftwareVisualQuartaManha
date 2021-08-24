using System;

namespace ListaExercicios.Views
{
    public class Exe06
    {
        public static void Renderizar()
        {
            const int VALOR_MAXIMO = 1001;
            const int TAMANHO_VETOR = 100;
            Random random = new Random();
            int[] numeros = new int[TAMANHO_VETOR];
            //TAMANHO_VETOR ou numeros.length    
            //Populando o vetor com numeros aleatorios
            for (int i = 0; i < TAMANHO_VETOR; i++)
            {
                numeros[i] = random.Next(VALOR_MAXIMO);
            } 
            //Imprimir vetor não ordenado
            foreach (int numero in numeros)
            {
                Console.WriteLine($"{ numero } ");                
            }
            Console.WriteLine("\n\n");

            //Ordenar o vetor automaticamente
            //Array.Sort(numeros);
            

            // //Ordenar o vetor utilizando o bublle sort;
            // bool troca = false;
            // do
            // {
            //     troca = false;
            //     for (int i = 0; i < TAMANHO_VETOR - 1; i++)
            //     {
            //         if (numeros[i] > numeros[i+1])
            //         {
            //             int aux = numeros[i];
            //             numeros[i] = numeros[i+1];
            //             numeros[i + 1] = aux;
            //             troca = true;                    
            //         }            
            //     }
            // }while(troca);    

            //Imprimir vetor ordenado
            foreach (int numero in numeros)
            {
                Console.WriteLine($"{ numero } ");                
            }
            Console.WriteLine("\n\n");
        }        
    }
}