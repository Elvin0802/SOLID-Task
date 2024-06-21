namespace Open_Closed_Principle;

public class Program
{
	static void Main(string[] args)
	{
		Process process = new();
		process.ProcessShape("Square");

		//00000000000000000000000000000000000

		Circle circle = new();
		circle.Process();

		Square square = new();
		square.Process();
	}
}

#region Bad

public class Process
{
	public void ProcessShape(string shape)
	{
		if (shape == "Circle")
			Console.WriteLine("Processing Circle");
		else if (shape == "Square")
			Console.WriteLine("Processing Square");
	}
}

#endregion

/***************************************************************************************/

#region Good

public abstract class Shape
{
	public abstract void Process();
}

public class Circle : Shape
{
	public override void Process() => Console.WriteLine("Processing Circle");
}

public class Square : Shape
{
	public override void Process() => Console.WriteLine("Processing Square");
}

#endregion
