using System;

class Program
{
    static void Main(string[] args)
    {
    Console.Write("Digite a sua nota:");
        string nota = Console.ReadLine();
        int numero = int.Parse(nota);
        if (numero >= 97)
        { 
            Console.WriteLine("Sua nota é A+");
        }
        else if (numero > 93 && numero < 97)
        {
            Console.WriteLine("Sua nota é A");
        }
        else if (numero >= 90 && numero <= 93)
        {
            Console.WriteLine("Sua nota é A-");
        }
        else if (numero >= 87 && numero < 90)
        {
            Console.WriteLine("Sua nota é B+");
        }
        else if (numero >= 83 && numero < 87)
        {
            Console.WriteLine("Sua nota é B");
        }
        else if (numero >= 80 && numero < 83)
        {
            Console.WriteLine("Sua nota é B");
        }
        else if (numero >= 70)
        {
            Console.WriteLine("Sua nota é C");
        }
        else if (numero >= 60)
        {
            Console.WriteLine("Sua nota é D");
        }
        else
        {
            Console.WriteLine("Sua nota é F. Você terá que repetir a materia.");
        }
             
       
    }
}