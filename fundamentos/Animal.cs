using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos
{
    public abstract class Animal
    {
        public string Especie { get; set; }
        public string Nome { get; set; }

        //declaração de um metodo

        public abstract void EmitirSom()


    }
}
