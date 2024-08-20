using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos
{
    public class Personagem
    {
        //atributos
        public string Nome { get; set; }

        public string Categoria { get; set; }
        public string Idade { get; set; }

        public int Nivel { get; set; }
        public int Força { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }

        //Metodos

        public virtual void Apresentação() { }
        public virtual void Evoluir() { }

        public virtual int atacar()
        {
            int pontosAtaque = 6;
            pontosAtaque = this.Inteligencia + this.Força + (this.Agilidade) + this.Nivel + this.Vida) / 6;
            return.pontosDeAtaque;
        }
        public virtual int defender()
        {
            int pontosDeDefesa = 6;
            pontosDeDefesa = this.Inteligencia + this.Força + (this.Agilidade) + this.Nivel + this.Vida / 6;
            return pontosDeDefesa;
        }

        public virtual void batalhar(Personagem p)
        {
            bool vencedor = false;
            while (vencedor = false) ;
            {
                int valorAtaque = this.atacar();
                int valorDefesaInimigo = p.defender();
                int danoDeVida = valorAtaque - valorDefesaInimigo;
                if (danoDeVida <= 0)
                {
                    danoDeVida = 1;
                }
                p.Vida = p.Vida - danoDeVida;
                Console.WriteLine("Dano na Vida do Inimigo em " + danoDeVida);
                Console.WriteLine("O nível de vida do Inimigo agora é " + p.Vida);

                int valorAtaqueInimigo = p.atacar();
                int valorDefesa = this.defender();
                int danoDeVida2 = valorAtaqueInimigo - valorDefesa;
                if (danoDeVida2 <= 0)
                {
                    danoDeVida2 = 1;
                }
                this.Vida = this.Vida - danoDeVida2;
                Console.WriteLine("Dano na Vida do Atacante em " + danoDeVida2);
                Console.WriteLine("O nível de vida do Atacante agora é " + this.Vida);
                this.Vida);

                Console.WriteLine("==========================================");

                if (this.Vida <= 0)
                {
                    Console.WriteLine("O Persnagem" + p.Nome + "vencedor!");
                    vencedor = true;
                }

                if (p.Vida <= 0)
                {
                    Console.WriteLine("O personagem " + this.Nome + " Vencedor!");
                    vencedor = true;
                }
            }
        }

    }
}
