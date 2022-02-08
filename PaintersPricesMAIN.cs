using System;

namespace PaintersPrices
{
	class PaintersPrices
	{
		public static void Main(string[] args)
		{

			Console.WriteLine("What is the total wall area to be painted?");
			double wallArea = double.Parse(Console.ReadLine());

			Console.WriteLine("what is the total area to be avoided while painting (void)");
			double voidArea = double.Parse(Console.ReadLine());

			Console.WriteLine("The total area to be painted is");
			double areaOfWall = wallArea - voidArea;
			Console.WriteLine(areaOfWall);		

			Console.WriteLine("Please state price of 5l paint can");
			double priceOf5lPaintCan = double.Parse(Console.ReadLine());		

			Console.WriteLine("Please state hourly labor cost");
			double hourlyLaborCost = double.Parse(Console.ReadLine());			

			Console.WriteLine("Please state paint can coverage per square metre");
			double paintCanCoveragePerSquareMeter = double.Parse(Console.ReadLine());			

			Console.WriteLine("Please state time taken for job");
			double timeTakenForJob = double.Parse(Console.ReadLine());
			
			double totalCostOfJob = ((hourlyLaborCost*timeTakenForJob)+((areaOfWall/paintCanCoveragePerSquareMeter)*priceOf5lPaintCan));

			Console.WriteLine("what paint colour are you using?");
			string paintColour = Console.ReadLine();

			
				switch (paintColour)
				{
					case "Red":
						Console.WriteLine("Red Paint");
						break;

					case "Blue":
						Console.WriteLine("Blue Paint");
						break;


					case "Green":
						Console.WriteLine("Green Paint");
						break;

                    default:
					Console.WriteLine("Paint not available");
					break; 
				}
				
				Console.WriteLine("The cost of this job is " + totalCostOfJob + " with the paint colour " +paintColour); // calculates final cost and paint colour

			if (totalCostOfJob > 100) 
			{
				Console.WriteLine("Congratulations you qualify for a 10% discount");
				totalCostOfJob = totalCostOfJob * 0.9;
				Console.WriteLine("your new price is £" + totalCostOfJob);
					
			
			}





		



		}
	}
}