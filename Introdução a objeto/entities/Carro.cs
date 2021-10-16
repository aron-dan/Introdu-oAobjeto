using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introdução_a_objeto.entities
{
    public abstract class Carro
    {
        public Roda Rodas {get; set;}
        public string chassi { get; set; }
        public int Porta { get; set; }
        public int Velocidade { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public Cambio Cambio { get; set; }
        public int Ano { get; set; }
        public string Combustive { get; set; }
        public Tipo Tipo { get; set; }
        public Fabricante Fabricante { get; set; }

        public abstract void acelear();
        public abstract string frear(string desejaFrear);
        public abstract bool farois(bool isDark);
        public abstract void mudarmarcha();

        public override void farois()
        {
            if (isDark)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string frear(bool desejaFrear)
        {
            if (desejaFrear)
            {
                return "Ocondutor quer frear";
                return "carro em moviemneto";
            }
        }

    }
}
