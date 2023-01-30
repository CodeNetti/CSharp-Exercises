// See https://aka.ms/new-console-template for more information
Console.WriteLime("Vamos determinar se o número que você informar vai ser primo ou não");
Console.WriteLine("Para concluirmos precisamos de um divisor, Por favor digite:");
int d = 0;
d = Convert.ToInt32(Console.ReadLine());
 int r;
r = d % d;
if (r < 1)
{
    Console.WriteLine("Esse número é primo");
}
else
{
    Console.WriteLine(" Esse numero não é primo");
}



