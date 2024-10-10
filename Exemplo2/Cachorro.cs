namespace Exemplo2;

public class Cachorro : IAnimal
{
    public void SomAnimal()
    {
        Console.WriteLine("Au au...");
    }

    public void Brincar()
    {
        Console.WriteLine("Brincando de pegar a bolinha...");
    }

    public void Comer()
    {
        Console.WriteLine("Comendo um bife...");
    }
}
