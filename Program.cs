namespace CSharp_Basics
{
    partial class Program
    {

	   static void Main(string[] args)
	   {
		  //// This Method Calls Methods from Phase 1:  Basics of Classes
		  // ClassBasicsImplementation();

		  Inhertance();
	   }

	   private static void Inhertance()
	   {
		  //  Instatiate Class Object Text
		  //  This object inherits from the PresentationOjbect and the Text Class
		  //  Because of this we can access properties and methods in both classes.
		  //  This is because of Inheritance.
		  var text = new Text();

		  //  PresentationObject
		  text.Width = 100;
		  text.Height = 20;
		  text.Copy();
		  text.Duplicate();

		  //  Text
		  text.AddHyperlink("www.google.com");
	   }
    }
}
