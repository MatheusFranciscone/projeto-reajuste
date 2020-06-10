using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_reajuste
{
    //classe concreta
    class Designer : Funcionario //herança da classe abstrata
    {
        public override void Reajustar() //sobscrevendo o metodo da classe abstrata
        {
            salario += 500;
        }
    }
}
