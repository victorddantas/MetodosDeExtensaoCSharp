using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods
{
    public class Conta
    {

        //Podemos  manter o principio solid aberto/fechado, que diz que ua classe está fechada a modificações e aberta a extensões, onde ao invés de fazer
        //uma alteração nesta classe criamos um método de extensão.
        

        public void PagarConta()
        {
            Console.WriteLine("Pagando Conta pelo método da classe");
        }
    }
}
