using System;
namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
		public ListDataAccess()
		{

          
		}
        public void LoadData()
		{
			Console.WriteLine("I am reading data from list database");
		}


		public void SaveData()
		{
			Console.WriteLine("I am saving data from a list database");
		}

    }
}

