using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
   public class MongoDataAccess : IDataAccess
    {
        public static List<Product> products = new List<Product>()
        {
            new Product(){Name = "Xbox" , Price = 499},
            new Product(){Name = "Bike" , Price = 150},
            new Product(){Name = "Lightsaber" , Price = 650},
            new Product(){Name = "Sneakers" , Price = 120},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from the Mongo Data Access.");

            return products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to the Mongo Data Access.");
        }

        
    }
}
