namespace Interface_Segregation_Principle;

public class Program
{
	static void Main(string[] args)
	{

		BadWorker badWorker = new ();
		BadRobot badRobot = new ();
		
		badWorker.Work();
		badRobot.Work();

		badWorker.Eat();
		badRobot.Eat();

		//00000000000000000000000000000000000

		Worker worker = new ();
		Robot robot = new ();

		worker.Work();
		robot.Work();

		worker.Eat();

	}
}


#region Bad

public interface IBadWorker
{
	void Work();
	void Eat();
}

public class BadWorker : IBadWorker
{
	public void Work() => Console.WriteLine("Working.");

	public void Eat() => Console.WriteLine("Eating.");
}

public class BadRobot : IBadWorker
{
	public void Work() => Console.WriteLine("Working.");

	public void Eat() => throw new NotImplementedException();
}

#endregion

/*************************************************************************************************/

#region Good

public interface IWorker
{
	void Work();
}

public interface IHuman
{
	void Eat();
}

public class Worker : IWorker, IHuman
{
	public void Work() => Console.WriteLine("Working.");

	public void Eat() => Console.WriteLine("Eating.");
}

public class Robot : IWorker
{
	public void Work() => Console.WriteLine("Working.");
}

#endregion
