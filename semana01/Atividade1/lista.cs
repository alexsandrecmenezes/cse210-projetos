using System;

class Program
{
    static void Main(string[] args)
    {
    {
        List<int> numeros = new List<int>();
        //Peça ao usuário uma série de números e adicione cada um deles a uma lista. Pare quando o usuário inserir 0.
        
        int numerodigitado = -1;
        while (numerodigitado != 0)
        {
            Console.Write("Digite um número: Use 0 para sair. ");
            string numerodigitado1 = Console.ReadLine();
            numerodigitado = int.Parse(numerodigitado1);
            
            if (numerodigitado != 0)
            {
                numeros.Add(numerodigitado);
            }
        }

        int soma = 0;
        for (int i = 0; i < numeros.Count; i++)
        {
            soma += numeros[i];
        }
       
        Console.WriteLine("A soma dos numeros digitados é:" + soma);

        float media = ((float)soma) / numeros.Count;
        Console.WriteLine("A média dos numeros é:" + media);

        
        int maior = numeros[0];

        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                
                maior = numero;
            }
        }

        Console.WriteLine("O valor maior é:" + maior);
    }
}
}