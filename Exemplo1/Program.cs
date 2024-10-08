using Exemplo1;
using System.Runtime.CompilerServices;

IAnimal animal;

int resposta = -1;

while (resposta < 0 || resposta > 3)
{
    Console.WriteLine("1 - Cachorro");
    Console.WriteLine("2 - Gato");
    Console.WriteLine("3 - Pássaro");

    resposta = int.Parse(Console.ReadLine());

    if (resposta < 0 || resposta > 3)
    {
        Console.WriteLine("Digite um número de um animal válido");
    }
}

switch(resposta)
{
    case 1:
        animal = new Cachorro();
        break;
    case 2:
        animal = new Gato();
        break;
    case 3:
        animal = new Passaro();
        break;
    default:
        animal = new Cachorro();
        break;
}

animal.SomAnimal();
animal.Brincar();
animal.Comer();