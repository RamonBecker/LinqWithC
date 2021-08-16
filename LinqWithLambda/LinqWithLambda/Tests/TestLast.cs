using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests {
    public class TestLast : ITest {
        public void Test() {

            var customers = DataBase.DataBase.GetCustomers();

            var lastCustomer = customers.Last();

            Console.WriteLine(lastCustomer.nome);

            try {
                var erroCustomer = customers.Last(customer => customer.id < 0);

            }
            catch (Exception e) {
                Console.WriteLine("Nenhum customer com id menor que 0 encontrado!");
            }

            var erroCustomerWithOrDefault = customers.LastOrDefault(customer => customer.id < 0);

            if (erroCustomerWithOrDefault == null) {
                Console.WriteLine("Nenhum customer encontrado!");
            }

            var erroCustomerWithAge = customers.LastOrDefault(customer => customer.idade < 40);
            Console.WriteLine(erroCustomerWithAge.nome);

        }
    }
}
