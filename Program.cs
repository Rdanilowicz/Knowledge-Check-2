namespace Knowledge_Check_2
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How many records do you want to add? ");
			var numberOfRecords = int.Parse(Console.ReadLine());

			var recordList = new List<ChildClass>();
			for (int i = 0; i < numberOfRecords; i++)
			{
				// In this loop, populate the object's properties using Console.ReadLine()
				
				// Create instance of childclass
				var childclass = new ChildClass();

				Console.WriteLine("Enter the value for Property: ");
				childclass.Property = Console.ReadLine();

				Console.WriteLine("Enter the value for Additional Property: ");
				childclass.AdditionalProperty = Console.ReadLine();

				// Adds objects to the list
				recordList.Add(childclass);
			}

			// Print out the list of records using Console.WriteLine()
			foreach (var record in recordList)
			{
				Console.WriteLine(record.ToString());
			}
			Console.ReadKey();
		}
	}
}
