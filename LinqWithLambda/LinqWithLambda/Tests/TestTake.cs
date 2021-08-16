using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests {
    public class TestTake : ITest {
        public void Test() {
            var customers = DataBase.DataBase.GetCustomers();

            var firstTenCustomer = customers.Take(10);


            foreach (var customer in firstTenCustomer) {
                Console.WriteLine(customer.nome);
            }
            Console.WriteLine("\n");
            //var takeWhileCustomers = customers.TakeWhile(customer => customer.idade != 40);
            var takeWhileCustomers = customers.TakeWhile(customer => !(customer.idade == 40));

            foreach (var customer in takeWhileCustomers) {
                Console.WriteLine("Take while: " + customer.nome + " idade:" + customer.idade);
            }
        }
    }
}
