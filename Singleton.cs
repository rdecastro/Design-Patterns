using System;

/// <summary>
/// Singleton Design Pattern
/// NOTE: This is not thread-safe
/// </summary>
public class Singleton
{
    private static Singleton instance;

	private Singleton()
	{

	}

	public static Singleton Instance
	{
        get
		{
            if (instance == null)
			{
				instance = new Singleton();
			}
			return instance;
		}
	}

	public void MethodA()
	{
		Console.WriteLine("Singleton Method call");
	}
}
