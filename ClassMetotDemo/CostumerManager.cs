using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CostumerManager
    { 
        private List<Costumer> _costumers = new List<Costumer>();
        public CostumerManager(List<Costumer> costumers)
        {
            _costumers = costumers;
        }
        
        public void PrintCostumerName(Costumer costumer)
        {
            Console.WriteLine(costumer.CostumerName + ' ' + costumer.CostumerSurname);
        }
        
        public void AddCostumer()
        {
            Costumer costumer = new Costumer();
            Console.WriteLine("Enter Customer ID:\n");
            costumer.CostumerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name:");
            costumer.CostumerName = Console.ReadLine();
            Console.WriteLine("Enter Customer Surname:");
            costumer.CostumerSurname = Console.ReadLine();
            Console.WriteLine("Enter Customer Adress:");
            costumer.CostumerAdress = Console.ReadLine();
            _costumers.Add(costumer);
            
        }
    }
}
