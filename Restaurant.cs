using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{

    public class Restaurant
    {
        // поле клиенти и поле меню 
        private List<Customer> _customers = new List<Customer>();
        private List<MenuItem> _menu = new List<MenuItem>();

        // добавяме клиент
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        //този метод ми добавя елемнт към менюто
        public void AddMenuItem(MenuItem item)
        {
            _menu.Add(item);
        }



        //този метод дава конкретно ястие, което е зад даден номер в менюто.Трябва да провери длаи е валиден индекса.
        public MenuItem GetMenuItem(int index)
        {
            //ако има грешка.
            if (index >= _menu.Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            return _menu[index];
        }


        // взимаме клиент и му добавяме поръчка.
        public void PlaceOrder(Customer customer, Order order)
        {
            customer.AddOrder(order);
        }
        //показва елементите на менюто.
        public void DisplayMenu()
        {
            Console.WriteLine("Menu Items:");
            foreach (MenuItem item in _menu)
            {
                Console.WriteLine(item);
            }
        }
        // показва поръчката на даден клиент. Списъка с поръчки на деден клинет.
        public void DisplayOrderHistory(Customer customer)
        {
            //списък с поръчки.
            Console.WriteLine($"{customer.Name}'s Order History:");
            //взимам си всяка една от поръчките на клиента и му връщам обшата сума.
            foreach (Order order in customer.OrderHistory)
            {
                //всяка една от поръчките обща стойност.
                Console.WriteLine($"Order Total: ${order.GetTotal()}");
                //общата сума на тази поръчка е толкова.

                //поръчката има елементи. това елементите на поръчката.
                foreach (MenuItem item in order.Items)
                {
                    Console.WriteLine($"  {item}");
                }
            }
        }

    }
}
