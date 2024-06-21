namespace Dependency_Inversion_Principle;

public class Program
{
	static void Main(string[] args)
	{

		BadLightBulb badLightBulb = new();

		BadSwitch badSwitch = new(badLightBulb);

		badSwitch.Operate();

		//000000000000000000000000000000000000000000000

		LightBulb lightBulb = new();

		GoodSwitch goodSwitch = new(lightBulb);

		goodSwitch.Operate();

	}
}


#region Bad

public class BadLightBulb
{
	public void TurnOn() => Console.WriteLine("Bad LightBulb turned on.");
}

public class BadSwitch
{
	private BadLightBulb _lightBulb;

	public BadSwitch(BadLightBulb lightBulb) => _lightBulb = lightBulb;

	public void Operate() => _lightBulb.TurnOn();
}

#endregion

/*************************************************************************************************/

#region Good

public interface IDevice
{
	void TurnOn();
}

public class LightBulb : IDevice
{
	public void TurnOn() => Console.WriteLine("LightBulb turned on.");
}

public class GoodSwitch
{
	private IDevice _device;

	public GoodSwitch(IDevice device) => _device = device;

	public void Operate() => _device.TurnOn();
}

#endregion
