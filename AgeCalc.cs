// See https://aka.ms/new-console-template for more information


	String YourName;
	Console.WriteLine("What is your Name?");
	YourName = Console.ReadLine();
	Console.WriteLine("Hello {0}", YourName);
	Console.WriteLine("What is your age?");
//Input of Age
	int YourAge = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Name: {0}", YourName);
	Console.WriteLine("Age: {0}", YourAge);
	Console.WriteLine("What year is it?");
//Input of Year 
	int CurrentYear = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("What year do you want to know your age?");
	int YearInput = Convert.ToInt32(Console.ReadLine());
	int AgeFuture = YearInput - CurrentYear + YourAge;
	int AgePast = YourAge - (CurrentYear - YearInput);

// Age formula for past
		if (CurrentYear >= YearInput)
	{
		Console.WriteLine("Age: {0}", AgePast);
	}
// Age Formula for Future
		else if (CurrentYear <= YearInput)
	{
		Console.WriteLine("Age: {0}", AgeFuture);
	}
