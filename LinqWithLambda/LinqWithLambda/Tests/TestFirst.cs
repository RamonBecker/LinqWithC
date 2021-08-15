using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests {
    public class TestFirst : ITest {
        public void Test() {
            var customers = DataBase.DataBase.GetCustomers();

            var firstCustomer = customers.First();

            Console.WriteLine(firstCustomer.nome);

            var firstCustomerAge = customers.First(customer => customer.idade > 30);

            Console.WriteLine(firstCustomerAge.nome + " idade: " + firstCustomerAge.idade);

            try {
                var customerWithAgelLessTen = customers.First(customer => customer.idade < 10);

                Console.WriteLine(customerWithAgelLessTen.nome + " idade: " + customerWithAgelLessTen.idade);

            }
            catch (Exception ex) {
                Console.WriteLine("Não foi encontrado customer com idade menor que 10");
            }

            //var queryWithFirstOrDefault = customers.FirstOrDefault();
            var queryWithFirstOrDefault = customers.FirstOrDefault(customer => customer.idade > 30);
            Console.WriteLine("Usando FirstOrDefault: " + queryWithFirstOrDefault.nome);

            var customerWithAgeLessTenUsingFirstOrDefault = customers.FirstOrDefault(customer => customer.idade < 10);

            if (customerWithAgeLessTenUsingFirstOrDefault != null) {
                Console.WriteLine("Usando FirstOrDefault com idade menor que 10:" + customerWithAgeLessTenUsingFirstOrDefault.nome);
            }
            else {
                Console.WriteLine("Nao foi possível encontrar usando FirstOrDefault idade menor que 10");
            }

            //var idadeFirst = customers.Select(customer => customer.idade).FirstOrDefault(idade => idade < 10);
            //Console.WriteLine("Idade first:" + idadeFirst);

            var idades = customers.Select(customer => customer.idade);
            var idadeFirst = idades.FirstOrDefault(idade => idade < 10);

            Console.WriteLine("Idade first:" + idadeFirst);

            int myInt = default(int);

            Console.WriteLine("Default int:"+myInt);

        }
    }
}
