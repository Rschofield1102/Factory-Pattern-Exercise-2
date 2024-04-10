using System;
namespace FactoryPatternExercise2
{
	public class SQLDataAccess : IDataAccess
	{
		public SQLDataAccess()
		{
		}

        public void LoadData()
        {
            Console.WriteLine("I am reading data from sql database");
        }


        public void SaveData()
        {
            Console.WriteLine("I am saving data from a sql database");
        }
    }
}

