namespace Single_Responsibility_Principle;

public class Program
{
	static void Main(string[] args)
	{

		Operation operation = new();

		operation.SaveOrder();
		operation.SendEmail();

		//00000000000000000000000000000000000

		OrderSaver orderSaver = new();
		EmailSender emailSender = new();

		orderSaver.SaveOrder();
		emailSender.SendEmail();

	}
}

#region Bad

public class Operation
{
	public void SaveOrder() => Console.WriteLine("Order saved.");

	public void SendEmail() => Console.WriteLine("Email sent.");
}

#endregion

/***********************************************************************************************/

#region Good

public class OrderSaver
{
	public void SaveOrder() => Console.WriteLine("Order saved.");
}

public class EmailSender
{
	public void SendEmail() => Console.WriteLine("Email sent.");
}

#endregion