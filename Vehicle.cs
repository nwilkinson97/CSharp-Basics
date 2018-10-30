namespace CSharp_Basics
{
    public class Vehicle
    {
	   private readonly string registrationNumber;

	   //public Vehicle()
	   //{
		  //System.Console.WriteLine("Vehicle is being initialzied");
	   //}

	   public Vehicle(string registrationNumber)
	   {
		  this.registrationNumber = registrationNumber;
		  System.Console.WriteLine("Vehicle is being initialized.  {0}", registrationNumber);
	   }
    }
}
