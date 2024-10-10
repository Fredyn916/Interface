namespace Exemplo2
{
    public class GerenciadorAnimal
    {
        public void RealizarAcao(IAnimal animal)
        {
            animal.SomAnimal();
            animal.Comer();
            animal.Brincar();
        }
    }
}
