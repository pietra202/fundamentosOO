using fundamentos;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using static fundamentos.livro;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        // exemplo de comentaria
        /*Livro -Livro1 = new Livro();

        Livro1.Titulo = "Harry Potter";
        Livro1.Editora = "Editora Abril";
        Livro1.Autor = "J.K.H.";
        Livro1.AnoLancamento = 2001;

        Livro Livro2 = new Livro();

        Livro2.Titulo = "programando em C#";
        Livro2.Editora = "Editora nova";
        Livro2.AnoLancamento = 1982;
        Livro2.Autor = "Gustavo Castello";

        Livro Livro3 = new Livro();

        Livro3.Titulo = "Pai Rico Pai Pobre";
        Livro3.Editora = "Minha Editora";
        Livro3.Autor = "Cristiano de paula";
        Livro3.AnoLancamento = 2000;


        Aluno aluno1 = new Aluno();
        Aluno aluno2 = new Aluno();

        //preencher os atributos dos objeto
        aluno1.Nome = "Pietra";
        aluno1.RM = "1234TI";
        aluno1.Email = "pipispietragodoifelipe@gmail.com";
        aluno1.Nascimento = new DateOnly(2007, 08, 29);

        aluno2.Nome = "Eloá Franco dos Reis Silva";
        aluno2.RM = "4467TI";
        aluno2.Email = "paulinha.juju@sp.senai.br";
        aluno2.Nascimento = new DateOnly(2007, 02, 12);

        //imprimir na tela
        Console.WriteLine();
        Console.WriteLine("Aluno 1");
        Console.WriteLine("Nome: " + aluno1.Nome);
        Console.WriteLine("=================================");


        Console.WriteLine("E-mail" + aluno1.Email);
        Console.WriteLine("Nascimento" + aluno1.Nascimento);
        Console.WriteLine("=================================");



        Console.WriteLine();


        Console.WriteLine("Aluno 2");
        Console.WriteLine("Nome: " + aluno2.Nome);
        Console.WriteLine("=================================");


        Console.WriteLine("E-mail" + aluno2.Email);
        Console.WriteLine("Nascimento" + aluno2.Nascimento);
        Console.WriteLine("=================================");

        //instanciar um objeto do tipo produto
        Produto p1 = new Produto();
        p1.Codigo = 123456;
        p1.Nome = "Coca-cola 2 Litros";
        p1.Preco = 12.99;
        p1.Estoque = 69;
        //chamar o metodo quantidade estoque 
        p1.QuantidadeEstoque();
        p1.Estoque = 85;
        //chamar o metodo quantidade estoque
        p1.QuantidadeEstoque();

        Console.WriteLine("=================================");
        Console.WriteLine();

        //instanciar um objeto de tipo Carro
        Carro.carro1 = new Carro()
            carro1.Marca = "Ferrari";
        carro1.Modelo = "488";
        carro1.Velocidade = 80;

        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Desacelerar();

        Console.WriteLine("=================================");
        Console.WriteLine();

        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "José";
        pessoa1.Idade = 18;

        pessoa1.Envelhecer(5);
        pessoa1.Envelhecer(2);

        Console.WriteLine("=================================");
        Console.WriteLine();

        Funcionario func1 = new Funcionario();
        func1.Nome = "Luis Santos";
        func1.Idade = 20;
        func1.Cargo = "Aprendiz";
        func1.Salario = 1400.00;
        func1.ApresentarSe();

        Console.WriteLine("===============================");
        Console.WrileLine();
        */

        /*
        //instanciar objeto 
        Animal animal1 = new Animal();

        //incerindo dados do atribue
        animal1.Especie = "cachorro";

        //chamando o metodo dp objeto
        animal1.EmitirSom();

        //imprimindo a informação na tela
        Console.WriteLine("O Animal" * animal1 Especie * "Emitiu um som");
        */

        /*
        Gato gato = new Gato();
        gato.Nome = "Frajola";
        Console.WriteLine(gato.Nome + "faz: ");
        gato.EmitirSom();
        */


        /*
        Galinha galinha = new Galinha();
        galinha.Nome = "Joana darci";
        Console.WriteLine(galinha.Nome + "faz: ");
        Galinha.EmitirSom(); 
        */


        /*
        Porco porco = new Porco();
        porco.Nome = "Calabreso";
        Console.WriteLine(porco.Nome + "faz: ");
        Porco.EmitirSom();
        */



        Mago merlior = new Mago();
        merlior.Nome = "Mago Merlior";
        merlior.Vida = 100;
        merlior.Inteligencia = 87;
        merlior.Agilidade = 55;
        merlior.Forca = 62;
        merlior.Nivel = 1;

        Elfo elfo = new Elfo();
        elfo.Nome = "Azula";
        elfo.Vida = 100;
        elfo.Inteligencia = 83;
        elfo.Forca = 56;
        elfo.Agilidade = 90;
        elfo.Nivel = 1;


        merlior.apresentarSe();
        elfo.apresentarSe();

        int ataque = merlior.atacar();
        int defesa = merlior.defender();
        Console.WriteLine("Força do Ataque: " + ataque);
        Console.WriteLine("Força do Defesa: " + defesa);
    }
}