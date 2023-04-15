using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

class Ranger : Jogada
{
    public Ranger()
    {

        do
        {

            Console.WriteLine("Você escolheu ser um ranger.\n" +
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

        mover = dado.Next(1, 6);

        Console.WriteLine($"Você pulou {mover} espaços\n" +
            $"Aperte enter para continuar a jogar.");
        Console.ReadLine();

    }

    protected override void Atacar()
    {

        dano = dado.Next(1, 7);

        Console.WriteLine($"Você usou seu arco e flecha e acertou um dano de {soma}\n" +
            $"Aperte enter para continuar a jogar.");
        Console.ReadLine();

    }

    protected override void Defender()
    {

        defesa = dado.Next(1, 7);

        Console.WriteLine($"Você se esquivou de {defesa} de dano\n" +
            $"Aperte enter para continuar a jogar.");
        Console.ReadLine();

    }
}