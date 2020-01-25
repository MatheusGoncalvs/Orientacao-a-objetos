using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Principiosfundamentais.AbstractClass
{
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, string voltagem) : base(nome, voltagem)
        {
        }

        public CafeteiraEspressa() 
            : base("Padrao", "220w") { }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            AquecerAgua();
            MoerGraos();
        }

        public override void Testar()
        {
            //Testar cafeteira
        }


        public override void Desligar()
        {
            //Verificar recipiente de água
        }

        public override void Ligar()
        {
            //Resfriar o aquecedor
        }
    }
}
