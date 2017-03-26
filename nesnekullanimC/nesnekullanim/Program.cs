using System;

namespace nesnekullanim
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			CModel cm1 = new CModel();

			Console.Write("birseyler giriniz");
			cm1.Name = Console.ReadLine();

			Console.WriteLine(cm1.Name);


		}
	}
}
