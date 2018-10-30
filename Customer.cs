using System.Collections.Generic;

namespace CSharp_Basics
{
    class Customer_old
    {
	   public int Id;
	   public string Name;
	   public readonly List<Order> Orders = new List<Order>();

	   public Customer_old()
	   {

	   }

	   public Customer_old(int id) : this()
	   {
		  this.Id = id;
	   }

	   public Customer_old(int id, string name) : this(id)
	   {
		  this.Name = name;
	   }

	   public void Promote()
	   {
		  // ....
	   }
    }
}
