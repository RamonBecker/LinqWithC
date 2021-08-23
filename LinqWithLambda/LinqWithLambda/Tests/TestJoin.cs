using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests {
    public class TestJoin : ITest {
        public void Test() {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();

            //var customersOrders = customers.Join(
            //    orders,
            //    customer => customer.id,
            //    order => order.CustomerID,
            //    //(customer, order) => new { Customer = customer, Order = order }
            //    (customer, order) => new { Name = customer.nome, TotalValue = order.TotalValue, CreateDate = order.CreatedDate }
            //    );

            //foreach (var customerOrder in customersOrders) {
            //    //Console.WriteLine("The customer " + customerOrder.Customer.nome
            //    //    + " purchased " + customerOrder.Order.TotalValue.ToString("c2")
            //    //    + " in " + customerOrder.Order.CreatedDate.ToString("dd/MM/yyyy"));
            //    Console.WriteLine("The customer " + customerOrder.Name
            //        + " purchased " + customerOrder.TotalValue.ToString("c2")
            //        + " in " + customerOrder.CreateDate.ToString("dd/MM/yyyy"));

            var customersOrders = customers.GroupJoin(
                orders,
                customer => customer.id,
                order => order.CustomerID,
                //(customer, order) => new { Customer = customer, Order = order }
                (customer, allOrders) => new { Customer = customer, AllOrders = allOrders }
                );

            foreach (var customerOrder in customersOrders) {

                Console.WriteLine("The customer " + customerOrder.Customer.nome
                    + " purchased ");
                foreach (var order in customerOrder.AllOrders) {
                    Console.WriteLine("Total value " + order.TotalValue.ToString("c2")
                        +" in " + order.CreatedDate.ToString("dd/MM/yyyy"));
                }

                //Console.WriteLine("The customer " + customerOrder.Customer.nome
                //    + " purchased " + customerOrder.Order.TotalValue.ToString("c2")
                //    + " in " + customerOrder.Order.CreatedDate.ToString("dd/MM/yyyy"));
            }
        }
    }
}
}
