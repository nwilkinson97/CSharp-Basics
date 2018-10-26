using System;

namespace CSharp_Basics
{
    class Person
    {
	   public DateTime BirthDate { get;  private set; }
	   public int Age
	   {
		  get
		  {
			 var timeSpan = DateTime.Today - BirthDate;
			 var years = timeSpan.Days / 365;

			 return years;
		  }	
	   }

	   public string Name { get; set; }
	   public string UserName { get; set; }

	   public Person()
	   {

	   }

	   public Person(DateTime birthDate)
	   {
		  BirthDate = birthDate;
	   }

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
