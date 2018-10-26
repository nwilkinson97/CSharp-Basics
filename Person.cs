using System;

namespace CSharp_Basics
{
    class Person
    {
	   public DateTime BirthDate { get; set; }
	   public int Age
	   {
		  get
		  {
			 var timeSpan = DateTime.Today - BirthDate;
			 var years = timeSpan.Days / 365;

			 return years;
		  }	
	   }

	   public string Name;


	   public void Introduce(string to)
	   {
		  System.Console.WriteLine("Hello {0} I am {1}", to ,Name);
	   }

	   public static Person Parse(string str)
	   {
		  var person = new Person();
		  person.Name = str;

		  return person;
	   }
    }
}
