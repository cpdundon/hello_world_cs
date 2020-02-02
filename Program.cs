using System;

namespace DotnetBot {
	public static class Program {
		
		public static void Main(string[] args) {

			string message = "";
			if (args.length < 1) {
				message = "Welcome to .NET Core!";
			}
			else {
				foreach (string item in args) {
					message += item;
				}
			}
			Console.WriteLine(message);
			Console.WriteLine(message);
		}
	}
}
