using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos
{
    public class Mago : Personagem
    {
        public override void Apresentação()
        {
            Console.WriteLine("Oii ! Eu me chamo Melior" +);
        }

        public override void atacar()
        {
            Console.WriteLine("4 elementos, 30");
        }

        public override void Batalha()
        {
            Console.WriteLine("30-20 = 10");
        }

        public override void defender()
        {
            Console.WriteLine("20");
        }

        public override void Evoluir()
        {
            Console.WriteLine("5");
        }
    }
}
