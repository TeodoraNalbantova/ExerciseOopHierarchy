using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Customer
    {
        private List<Order> _orderHistory = new();
        public IReadOnlyCollection<Order> OrderHistory => this._orderHistory.AsReadOnly();
        public string Name { get; set; }
        public string Email { get; set; }
        //Constructor accepting the two properties 
        public Customer(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        //adds the given order to the _orderHistory list.
        public void AddOrder(Order order)
        {
            this._orderHistory.Add(order);
        }
    }
}
