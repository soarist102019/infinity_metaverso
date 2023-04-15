using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RPG
{
    class Program
    {
        public static int personagem;
        public static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Olá! Qual personagem você quer ser?\n" + "1 - Guerreiro\n" + "2 - Mago\n" + "3 - Ranger");

                Program.personagem = int.Parse(Console.ReadLine());

                switch (Program.personagem)
                {
                    case 1:
                        Guerreiro guerreiro = new Guerreiro();

                        Console.Read();

                        break;

                    case 2:
                        Mago mago = new Mago();

                        Console.Read();

                        break;

                    case 3:
                        Ranger ranger = new Ranger();

                        Console.Read();

                        break;

                    default:
                        break;
                }
            } while (true);


        }
    }
}