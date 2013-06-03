using System;

/// <summary>
/// Singleton Design Pattern
/// NOTE: This is thread-safe
///       Based from: http://msdn.microsoft.com/en-us/library/ff650316.aspx
/// </summary>
public sealed class ThreadSafeSingleton
{
    private static volatile ThreadSafeSingleton instance;
	private static object syncRoot = new Object();

	private ThreadSafeSingleton()
	{

	}

	public static ThreadSafeSingleton Instance
	{
		get
		{
			if (instance == null)
			{
				lock (syncRoot)
				{
					if (instance == null)
					{
						instance = new ThreadSafeSingleton();
					}
				}
			}
			return instance;
		}
	}

	public void MethodA()
	{
		Console.WriteLine("Thread-Safe Singleton Method call");
	}
}
