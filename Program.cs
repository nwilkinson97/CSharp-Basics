﻿namespace CSharp_Basics
{
    class Program
    {
	   static void Main(string[] args)
	   {
		  IntroductionToClasses();
		  ClassConstructors();
		  Methods();
	   }

	   private static void Methods()
	   {
		  try
		  {
			 // Create a new Point then consume the object to set the intial point
			 var point = new Point(10, 20);
			 System.Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

			 // Move the current point to a new location
			 // use the new keyword to perform this action on the same line
			 point.Move(new Point(40, 60));
			 System.Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

			 // Use the overload to provide 2 integer values and assign coordinates
			 point.Move(100, 200);
			 System.Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

			 point.Move(null);
		  }
		  catch (System.Exception ex)
		  {
			 System.Console.WriteLine(ex.Message);
		  }

	   }

	   private static void ClassConstructors()
	   {
		  var customer = new Customer();
		  System.Console.WriteLine(customer.Id);
		  System.Console.WriteLine(customer.Name);
	   }

	   private static void IntroductionToClasses()
	   {
		  // Basic Class Object Instatiated
		  var p1 = new Person(); 
		  p1.Name = "Thing 1"; 
		  p1.Introduce("Thing 2"); 

		  //  Using Statics which can be accessed via 
		  //  the object and not an instance. 
		  var p2 = Person.Parse("Thing King"); 
		  p2.Introduce("Super Thing"); 

		  //  Using the Object Initializer for the Person Class 
		  var p3 = new Person() 
		  {
			 Name = "Kid Dynamite" 
		  };

		  p3.Introduce("Chocolate Thunda"); 
	   }
    }
}
