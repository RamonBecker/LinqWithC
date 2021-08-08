using LinqWithLambda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests {
    public class TestSelect : ITest {
        public void Test() {
            var customers = DataBase.DataBase.GetCustomers();

            var firstQueryCustomers = from customer in customers
                                          //select new { customer.id, NomeCustomer = customer.nome };
                                      select new { customer.id, customer.nome };


            //foreach (var customer in firstQueryCustomers) {
            //    Console.WriteLine(customer.nome);
            //}

            var secondQueryWithLambda = customers.Select(customer => new { Description = "Customer Name" + customer.nome + " Age:"+ customer.idade});
            //var secondQueryWithLambda = customers.Select( customer => new { customer.id, NomeCustomer = customer.nome });
            //.Select(customer => customer.nome);
            //.Select(customer => new { customer.id, NomeCustomer = customer.nome }

            foreach (var customer in secondQueryWithLambda) {
                Console.WriteLine(customer.Description);
            }
        }
    }
}
