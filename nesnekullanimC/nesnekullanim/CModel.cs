using System;
namespace nesnekullanim
{
	public class CModel
	{
		string name;

		public string Name
		{
			get { return name;}
			set
			{
				if (value.Length < 5)
				{
					name = "hatali sifre girdiniz";
				}
				else
				{
					name = value;
				}
			}
		}




	}
}
