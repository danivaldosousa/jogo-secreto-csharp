using System;

namespace AcertarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random NumeroAleatorio = new Random();
            int numeroSecreto = NumeroAleatorio.Next(1,101);

            do{
                Console.Write("Digite um numero de 1 a 100: ");
                int chute = int.Parse(Console.ReadLine());

                if(chute == numeroSecreto){
                    Console.WriteLine("Parabéns - Você acertou o número.");
                    break;
                }else if(chute < numeroSecreto){
                    Console.WriteLine("O número é maior.");
                }else{
                    Console.WriteLine("O número é menor.");
                }
            }while(true);
                Console.WriteLine("O jogo acabou. Você acertou o número secreto");
        }
    }
}
