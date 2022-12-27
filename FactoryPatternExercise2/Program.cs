namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            
                Console.WriteLine("What database would you like to work with");
                Console.WriteLine("Type: list");
                Console.WriteLine("Type: sql");
                Console.WriteLine("Type: mongo");

                var userInput = Console.ReadLine();
            
            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            db.SaveData();
            var products = db.LoadData();

            foreach(var item in products)
            {
                Console.WriteLine($"Name: {item.Name} Price: {item.Price}");
            }
        }
    }
}
