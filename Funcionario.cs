using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_reajuste
{
    public abstract class Funcionario //classe abstrata
    {
        public string nome;
        public decimal salario;

        public abstract void Reajustar(); //criação do metodo abstrato
    }
}
