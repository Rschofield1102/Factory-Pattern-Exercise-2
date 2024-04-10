namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to access list, sql, or mongo?");
            string userInput = Console.ReadLine();

            var info = DataAccessFactory.GetDataAccessType(userInput);

            info.LoadData();
            info.SaveData();


        }
    }
}
