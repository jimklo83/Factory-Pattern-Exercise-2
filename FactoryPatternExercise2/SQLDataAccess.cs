using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from the SQL Database.");
            var productList = new List<Product>();
            return productList;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving to a SQL Database.");
        }
    }
}
