namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which database will you be using?");
            var userDatabase = Console.ReadLine();
            var database = DataAccessFactory.GetDataAccessType(userDatabase);

            database.LoadData();
            database.SaveData();
        }
    }
}
