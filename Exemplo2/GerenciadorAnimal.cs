using Exemplo1;
using System;
using System.Collections.Generic;
namespace Exemplo2
{
    public class GerenciadorAnimal
    {
        public void RealizarAcao(IAnimal animal)
        {
            animal.SomAnimal();
            animal.Comer();
            animal.Brincar();
            animal.SomAnimal();
            animal.SomAnimal();
        }
    }
}
