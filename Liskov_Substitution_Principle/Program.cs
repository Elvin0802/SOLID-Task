namespace Liskov_Substitution_Principle;

public class Program
{
	static void Main(string[] args)
	{

		BadBird badBird = new();
		badBird.Fly();

		BadOstrich badOstrich = new();
		badOstrich.Fly();

		//000000000000000000000000000000000000000

		FlyingBird flyingBird = new();
		flyingBird.Move();

		Ostrich ostrich = new();
		ostrich.Move();

	}
}


#region Bad

public class BadBird
{
	public virtual void Fly() => Console.WriteLine("Bad Bird is flying.");
}

public class BadOstrich : BadBird
{
	public override void Fly() => throw new NotImplementedException();
}

#endregion

/***************************************************************************************/

#region Good

public class Bird
{
	public virtual void Move() => Console.WriteLine("Bird is moving.");
}

public class FlyingBird : Bird
{
	public override void Move() => Console.WriteLine("Bird is flying.");
}

public class Ostrich : Bird
{
	public override void Move() => Console.WriteLine("Ostrich is running.");
}

#endregion
