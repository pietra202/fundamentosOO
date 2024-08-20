using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos
{
    public class Cavaleiro : Personagem
    {
        public override void Apresentação()
        {
            Console.WriteLine("Eu sou o Lucrecio, vamos para a guerra");
        }

        public override void atacar()
        {
            Console.WriteLine();
        }

        public override void Batalha(Personagem p)
        {
            Console.WriteLine();
        }

        public override void defender()
        {
            Console.WriteLine();
        }

        public override void Evoluir()
        {
            Console.WriteLine();
        }
    }
}
