namespace CafeDeLeMente
{
	   public class GoldCustomer : Customer
	   {
		  public void OfferVoucher()
		  {
			 // Type This.
			 // Here you will see the fields for the derived class
			 // -- Id
			 // -- Name
			 //  If you go to the Customer Class and set the access modifier to
			 //  protected
			 //  This will make it available to any derrived classes.  In this project
			 //  it would not make sense because now if we had to modify the CalculateRating
			 //  we would have to modify the code blocks in 2 seaprate classes.  Unless required
			 //  we should prevent using protected.
		  }
	   }    
}
