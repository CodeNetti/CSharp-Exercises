// See https://aka.ms/new-console-template for more information
int maior = 0, menor = 0, i = 0, tl = 0, numero = 0;
Console.WriteLine("Vamos determinar o Maior e Menor numéro que você digitar");
Console.WriteLine(" Quantos números você deseja  informar");
tl = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe  o primeiro número:");
numero = Convert.ToInt32(Console.ReadLine());
maior = numero;
menor = numero;
i = 2;
while( i <=  tl)
{
    Console.WriteLine($"Informe o {i} numero");
    numero = Convert.ToInt32(Console.ReadLine());
    i++;

 
    
    if(numero  > maior)
    {
        maior = numero;
    }

    if (numero < menor)
    {
        menor = numero;
    }


}
Console.WriteLine($"O maior número é: {maior}");
Console.WriteLine($"O menor número é: {menor}");
Console.ReadKey();