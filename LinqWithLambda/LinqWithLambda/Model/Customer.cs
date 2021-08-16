using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Model {
    public class Customer {
        public int id {get; set;}
        public string nome { get; set; }
        public int idade { get; set; }


        public int SecondIdade {
            get {
                Console.WriteLine("Eu sou isso"+nome);
                return idade;
            }
        }
    }
}
