using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

class Guerreiro : Jogada
{
    public Guerreiro()
    {

        do
        {

            Console.WriteLine("Você escolheu ser um guerreiro.\n" +
                "O que quer fazer agora?\n" +
                "1 - Atacar\n" +
                "2 - Andar\n" +
                "3 - Defender\n" +
                "0 - voltar para a escolha de personagem");

            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {

                case 1:

                    Atacar();

                    Console.Clear();

                    break;

                case 2:

                    Andar();

                    Console.Clear();

                    break;


                case 3:

                    Defender();

                    Console.Clear();

                    break;


                case 0:

                    goto sair;


                default:
                    break;
            }

        } while (true);

    sair: { }

    }

    protected override void Andar()
    {

        mover = dado.Next(1, 3);

        Console.WriteLine($"Você andou {mover} passos\n" +
            $"Aperte enter para continuar a jogar.");
        Console.ReadLine();

    }

    protected override void Atacar()
    {

        dano = dado.Next(1, 7);
        soma += dano;
        dano = dado.Next(1, 7);
        soma += dano;

        Console.WriteLine($"Você desferiu dois golpes e acertou um dano de {soma}\n" +
            $"Aperte enter para continuar a jogar.");
        Console.ReadLine();
        soma = 0;
    }

    protected override void Defender()
    {

        defesa = dado.Next(1, 7);

        Console.WriteLine($"Você defendeu {defesa} de dano com o seu escudo\n" +
            $"Aperte enter para continuar a jogar.");
        Console.ReadLine();

    }
}