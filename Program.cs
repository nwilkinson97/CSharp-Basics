using CafeDeLeMente;

namespace CSharp_Basics
{
    partial class Program
    {
	   static void Main(string[] args)
	   {
		  //// This Method Calls Methods from Phase 1:  Basics of Classes
		  // ClassBasicsImplementation();

		  Inhertance();
		  Composition();
		  AccessModifier_Private();
		  AccessModifier_Internal();

	   }

	   private static void AccessModifier_Internal()
	   {
		  var customer = new Customer();
		  ////  By changing the access modifier to the rate calculator to
		  ////  internal the Rate Calculator no longer is accessible.
		  ////  however we can still access the customer class.
		  //var RateCalculator = new RateCalculator();  
	   }

	   private static void AccessModifier_Private()
	   {
		  //var customer = new Customer();
		  //// Access Modifier of private prevents us from accessing the business
		  //// logic of the class.  This prevents us from updating code in multiple
		  //// areas.
		  //var i = customer.CalculateRating();
	   }

	   private static void Composition()
	   {
		  var DbMigrator = new DbMigrator(new Logger());
		  var Installer = new Installer(new Logger());

		  DbMigrator.Migrate();
		  Installer.Install();
	   }

	   private static void Inhertance()
	   {
		  //  Instatiate Class Object Text
		  //  This object inherits from the PresentationOjbect and the Text Class
		  //  Because of this we can access properties and methods in both classes.
		  //  This is because of Inheritance.

		  //  PresentationObject
		  var text = new Text
		  {
			 
			 Width = 100,
			 Height = 20
		  };

		  text.Copy();
		  text.Duplicate();

		  //  Text
		  text.AddHyperlink("www.google.com");
	   }
    }
}
