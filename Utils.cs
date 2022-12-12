using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods
{
    public static class Utils //Para criar um método de extensão é necessário que a classe e o método sejam estáticos.
    {
        //Este método irá verificar se um número é maior que o outro 
        public static bool EhMaior(this int param, int secondParam) //O primeiro parâmetro com o this, define o tipo que será tratado, nesse caso int.
        {                                                           //Esse parâmetro irá pegar a instancia do objeto na qual estamos utilizando o método.
            return param > secondParam;                             //O segundo parâmetro se refere ao valor passado para comparação.
        }                                                           //No caso de ser um método de um único parêmtro esse método receber o valor de seu parâmtro do objeto înstânciado apenas.  
    
        

        //Este método multiplica valor por 100

        public static int MultiplicaPor100(this int param)
        {
            return param * 100;
        }


        //Método de extensão da classe conta (criaremos um ao invés  de modificar a já existente e funcional).

        public static void PagarContaComMetodoExtesao(this Conta conta)
        {
           Console.WriteLine("Pagando a conta pelo método de extensão");
        }


    }
}                                                               
