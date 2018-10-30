namespace CafeDeLeMente
{
    public class Customer
    {
	   public int Id { get; set; }
	   public string Name { get; set; }

	   public void Promote()
	   {
		  var calculator = new RateCalculator();
		  var rating = calculator.Calculate(this);

		  System.Console.WriteLine("Promote logic changed!");
	   }

	   private int CalculateRating()
	   {
		  return 0;
	   }
    }
}
