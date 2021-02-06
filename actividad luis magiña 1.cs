using System;

public class Program
{
	public static void Main()
	{
		int a = 34;
		int b = 23;
		int c = 56;

		Console.WriteLine("aacb={0}{0}{2}{1}",a,b,c);

		Console.WriteLine("bca={1}{2}{0}",a,b,c);

		Console.WriteLine("bcb={0}{1}{0}",b,c);

	}
}