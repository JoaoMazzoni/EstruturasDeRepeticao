//Ler um número e ler quantas vezes será incrementado em cima desse número

int n1 = 0, max = 0;
int contador = 0;
int aux;


Console.WriteLine("Digite um número: ");
n1 = int.Parse(Console.ReadLine());



Console.WriteLine("\nDigite o número incrementador: ");
max = int.Parse(Console.ReadLine());



Console.WriteLine("\nAqui é For");

aux = n1;
for (int i = 0; i <= max; i++)
{
    Console.WriteLine(aux);
    aux++;
    

}


Console.WriteLine("\nAqui é o Do-while");

aux = n1;
do
{
    Console.WriteLine(aux);
    aux++;
    contador++;

} while (contador <= max);



Console.WriteLine("\nAqui é o While");
aux = n1;

contador = 0;
while (contador <= max) 
{
    
    Console.WriteLine(aux);
    aux++;
    contador++;

}