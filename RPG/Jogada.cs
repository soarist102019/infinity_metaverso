using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

abstract class Jogada
{
    protected Random dado = new Random();
    protected int mover, dano, defesa, escolha, soma = 0;

    abstract protected void Atacar();
    abstract protected void Andar();
    abstract protected void Defender();

}