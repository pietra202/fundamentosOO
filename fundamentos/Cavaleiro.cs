using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fundamentos;

namespace Fundamentos
{
    public class Cavaleiro : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Olá, eu sou o Cavaleiro " + this.Nome + " tenho " + this.Vida + " pontos de vida.\nInteligência: " + this.Inteligencia + "\nAgilidade: " + this.Agilidade + "\nForça: " + this.Forca + "\nNível atual é: " + this.Nivel);
            Console.WriteLine("==================================================");
        }
    }
}