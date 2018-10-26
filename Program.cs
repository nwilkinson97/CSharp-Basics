using System;

namespace CSharp_Basics
{
    class Program
    {
	   static void Main(string[] args)
	   {
		  IntroductionToClasses();
		  ClassConstructors();
		  Methods();
		  MethodsUsingParmas();
		  MethodsUsingTheOutParameter();
		  FieldsReadOnlyModifier();
		  AccessModifierPrivate();
		  UsingPropertiesInClasses();
	   }

	   private static void UsingPropertiesInClasses()
	   {
		  var person = new Person();
		  person.BirthDate = new DateTime(1995, 1, 1);
		  Console.WriteLine(person.Age);
	   }

	   private static void AccessModifierPrivate()
	   {
		  var person = new Person();
		  person.BirthDate = new DateTime(1995, 1, 1);
		  Console.WriteLine(person.BirthDate);
	   }

	   private static void FieldsReadOnlyModifier()
	   {
		  //  New customer object
		  var customer = new Customer(1);

		  //  Add Two Orders
		  customer.Orders.Add(new Order());
		  customer.Orders.Add(new Order());

		  //  Promote Customer
		  customer.Promote();

		  //  Display Count of Orders
		  Console.WriteLine(customer.Orders.Count);
	   }

	   private static void MethodsUsingTheOutParameter()
	   {
		  //  Using the integer parse method requires us
		  //  to catch the exception and process the eror.
		  try
		  {
			 var num = int.Parse("abc");
		  }
		  catch (Exception ex)
		  {
			 Console.WriteLine(ex.Message);
		  }

		  // ---------------------------------------------------
		  // ---------------------------------------------------

		  //  Using the Try Parse Command
		  int n1;
		  var rslt1 = int.TryParse("abc", out n1);
		  //  Displaying Results
		  if (rslt1)
			 Console.WriteLine(n1);
		  else
			 Console.WriteLine("Conversion Failed");

		  // ---------------------------------------------------
		  // ---------------------------------------------------

		  //  Using Tryparse and decalring the integer variable inline
		  var rslt2 = int.TryParse("20", out int n2);
		  //  Displaying Results
		  if (rslt2)
			 Console.WriteLine(n2);
		  else
			 Console.WriteLine("Conversion Failed");

	   }

	   private static void MethodsUsingParmas()
	   {
		  var calculator = new Calculator();
		  Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
		  Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
	   }

	   private static void Methods()
	   {
		  try
		  {
			 // Create a new Point then consume the object to set the intial point
			 var point = new Point(10, 20);
			 Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

			 // Move the current point to a new location
			 // use the new keyword to perform this action on the same line
			 point.Move(new Point(40, 60));
			 Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

			 // Use the overload to provide 2 integer values and assign coordinates
			 point.Move(100, 200);
			 Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

			 point.Move(null);
		  }
		  catch (Exception ex)
		  {
			 Console.WriteLine(ex.Message);
		  }

	   }

	   private static void ClassConstructors()
	   {
		  var customer = new Customer();
		  Console.WriteLine(customer.Id);
		  Console.WriteLine(customer.Name);
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
