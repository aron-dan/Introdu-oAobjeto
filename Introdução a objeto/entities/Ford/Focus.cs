using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introdução_a_objeto.entities.Ford
{
    class Focus : Carro
    {
        private bool isDark;

        public override void acelear()
        {
            base.Velocidade += 25;
        }

        public override bool farois(bool isDark)
        {
            throw new NotImplementedException();
        }

        public override string frear(string desejaFrear)
        {
            throw new NotImplementedException();
        }

        public override string mudarmarcha(string marcha)
        {
            switch (marcha)
            {
                case  "aumentar";
                    if (marcha == 5)
                    {
                        return "impossive";
                    }
            }
        }

        public override void mudarmarcha()
        {
            throw new NotImplementedException();
        }
    }
}
