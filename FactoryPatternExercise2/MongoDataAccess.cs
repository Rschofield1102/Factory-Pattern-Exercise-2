using System;
namespace FactoryPatternExercise2
{
	public class MongoDataAccess : IDataAccess
	{
		public MongoDataAccess()
		{
		}

        public void LoadData()
        {
            Console.WriteLine("I am reading data from  mongo database");
        }


        public void SaveData()
        {
            Console.WriteLine("I am saving data from a mogo database");
        }
    }
}

