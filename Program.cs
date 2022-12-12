using System;
using System.Diagnostics.Contracts;

namespace ExtensionsMethods
{

    class Program
    {
        static void Main(string[]args)
        {
            int numero = 8;

            Console.WriteLine(numero.EhMaior(10)); //utilizando o método de extensão passamos o valor de 10 para comparar com o valor passado para ativacão do método  
                              //nesse caso o 8 (qeu será o valor do this no método de extensão)


            Console.WriteLine(numero.MultiplicaPor100());   //Neste exemplo, utilizando este método apenas multiplicamos o valor passado da instância por 100.



            //Utilizando o método de extesão para evitar a alterção da classe conta. 
           
             var Conta = new Conta();

             Conta.PagarConta(); //Método da classe 

             Conta.PagarContaComMetodoExtesao(); //Método de extensão 
   

        }


    }


}

















