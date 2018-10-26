using System;

namespace CSharp_Basics
{
    class Person
    {
	   private DateTime _birthDate;

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

	   public void SetBirthDate(DateTime birthDate)
	   {
		  _birthDate = birthDate;
	   }

	   public DateTime GetBirthDate()
	   {
		  return _birthDate;
	   }
    }
}
