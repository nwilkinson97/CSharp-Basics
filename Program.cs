namespace CSharp_Basics
{
    class Person
    {
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

    class Program
    {
	   static void Main(string[] args)
	   {
		  // Basic Class Object Instatiated
		  var p1 = new Person();
		  p1.Name = "Thing 1";
		  p1.Introduce("Thing 2");

		  //  Using Statics which can be accessed via 
		  //  the object and not an instance.
		  var p2 = Person.Parse("Thing King");
		  p2.Introduce("Super Thing");

		  var p3 = new Person()
		  {
			 Name = "Kid Dynamite"
		  };

		  p3.Introduce("Chocolate Thunda");

		  
	   }
    }
}
