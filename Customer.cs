namespace CSharp_Basics
{
    partial class Program
    {
	   class Customer
	   {
		  public int Id { get; set; }
		  public string Name { get; set; }

		  public void Promote()
		  {
			 var rating = CalculateRating();

			 if (rating == 0)
			 {
				System.Console.WriteLine("Promoted to Level 1");
			 }
			 else
			 {
				System.Console.WriteLine("Promoted to Level 2");
			 }
			 
		  }

		  private int CalculateRating()
		  {
			 return 0;
		  }
	   }
    }
}
