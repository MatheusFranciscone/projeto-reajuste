using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_reajuste
{
    //classe cocreta
    class Programador : Funcionario //herança da classe abstrata
    {
        public override void Reajustar() //sobcrevendo o metodo da classe abstrata
        {
            salario += 1000;
        }
    }
}
