using System;

class Program
{
    static void Main(string[] args)
    {
       Random geradorAlexatorio = new Random();
       int numeroAleatorio = geradorAlexatorio.Next(1, 100);

       int numerodigitado = 0;

       while (numerodigitado != numeroAleatorio)
       {
           Console.Write("Digite um número aleatorio entre 1 a 100?");
           string numero = Console.ReadLine();
           numerodigitado = int.Parse(numero);

           if (numerodigitado < numeroAleatorio)
           {
               Console.WriteLine("O número digitado é menor que o número aleatório. Tente novamente.");
           }
           else if (numerodigitado > numeroAleatorio)
           {
               Console.WriteLine("O número digitado é maior que o número aleatório.");
           }
           else
           {
               Console.WriteLine("Parabéns! Você acertou o número aleatório.");
           }
       }

       
    }
}