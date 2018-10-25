namespace CSharp_Basics
{
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

		  //  Using the Object Initializer for the Person Class
		  var p3 = new Person()
		  {
			 Name = "Kid Dynamite"
		  };

		  p3.Introduce("Chocolate Thunda");		  
	   }
    }
}
