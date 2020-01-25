using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Principiosfundamentais.AbstractClass
{
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly string _voltagem;

        public Eletrodomestico(string nome, string voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar();

        public abstract void Desligar();

        public virtual void Testar() { }

    }
}
