using LinqWithLambda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.DataBase {
    public static class DataBase {
        public static List<Customer> GetCustomers() {

            var customers = new List<Customer>();

            for (int i = 0; i <= 50; i++) {

                var customer = new Customer();

                customer.id = i;
                customer.nome = $"Customer {i.ToString()}";
                customer.idade = 19 + i;

                customers.Add(customer);
            }

            return customers;
        }

        public static List<Order> GetOrders() {

            var orders = new List<Order>();

            var customerID = 0;

            for (int i = 0; i <= 1000; i++) {
                var order = new Order();
                order.Id = i;

                if (customerID > 50) {
                    customerID = 0;
                }

                order.CustomerID = customerID;
                order.CreatedDate = DateTime.Now;
                order.TotalValue = 10 * i;

                orders.Add(order);

                customerID++;
            }

            return orders;
        }
    }
}
