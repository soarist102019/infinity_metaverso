using RPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

class Mago : Jogada
{
    public Mago()
    {

        do
        {

            Console.WriteLine("Você escolheu ser um mago.\n" +
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

        mover = dado.Next(1, 4);

        Console.WriteLine($"Você correu por {mover} espaços\n" +
            $"Aperte enter para continuar a jogar.");
        Console.ReadLine();

    }

    protected override void Atacar()
    {
            Console.WriteLine("Qual desses elementos você quer usar no ataque?\n" +
            "1 - Fogo\n" +
            "2 - Terra\n" +
            "3 - Água\n" +
            "4 - Ar\n");

            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    dano = dado.Next(1, 7);
                    Console.WriteLine($"Você usou a bola de fogo e causou {dano} de dano.");
                    break;
                case 2:
                    dano = dado.Next(1, 7);
                    Console.WriteLine($"Você usou a bola de terra e causou {dano} de dano.");
                    break;
                case 3:
                    dano = dado.Next(1, 7);
                    Console.WriteLine($"Você usou a bola de água e causou {dano} de dano.");
                    break;
                case 4:
                    dano = dado.Next(1, 7);
                    Console.WriteLine($"Você usou a bola de ar e causou {dano} de dano.");                  
                    break;
                default:
                    break;

            }

        Console.WriteLine($"Aperte enter para continuar a jogar.");
        Console.ReadLine();
    }

    protected override void Defender()
    {

        defesa = dado.Next(1, 7);

        Console.WriteLine($"Você defendeu {defesa} de dano com a sua barreira de ar\n" +
            $"Aperte enter para continuar a jogar.");
        Console.ReadLine();

    }
}