using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests {
    public class TestSingle : ITest {
        public void Test() {

            var customers = DataBase.DataBase.GetCustomers();

            ////  var customerSingle =  customers.Single(customer => customer.idade == 19);
            //// var customerSingle =  customers.Single(customer => customer.idade == 10);
            //var customerSingle = customers.SingleOrDefault(customer => customer.idade == 10);


            //if (customerSingle != null) {
            //    Console.WriteLine(customerSingle.id + " nome: " + customerSingle.nome + " idade: " + customerSingle.idade);
            //}
            //else {
            //    Console.WriteLine("Não foi possível encontrar este customer");
            //}

            // var customerSingleOrDefault = customers.SingleOrDefault(customer => customer.SecondIdade == 19);
            // var customerFirst = customers.First(customer => customer.SecondIdade == 19);
            //var customerSingle = customers.Single(customer => customer.SecondIdade == 19);
            // Console.WriteLine("isto é um customer: " + customerFirst.nome);

            var customerSingleOrDefault = customers.Single(customer => customer.idade > 20);
            //var customerFirst = customers.First(customer => customer.idade > 20);
            Console.WriteLine("Isto é o custumer selecionado: "+ customerSingleOrDefault.nome);


        }
    }
}
