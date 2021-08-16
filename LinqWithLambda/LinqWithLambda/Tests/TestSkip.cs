using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests {
    public class TestSkip : ITest {
        public void Test() {
            var customers = DataBase.DataBase.GetCustomers();

            var skipCustomer = customers.Skip(10);

            foreach (var customer in skipCustomer) {
             //   Console.WriteLine(customer.nome);
            }

            var skipWhileCustomer = customers.SkipWhile(customer => customer.idade != 40);

            foreach (var customer in skipWhileCustomer) {
                Console.WriteLine("Skip While:"+customer.nome+" Idade:"+customer.idade);
            }
        }
    }
}
