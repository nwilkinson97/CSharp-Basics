using System.Collections.Generic;

namespace CSharp_Basics
{
    class Customer
    {
	   public int Id;
	   public string Name;
	   public List<Order> Orders = new List<Order>();

	   public Customer()
	   {

	   }

	   public Customer(int id) : this()
	   {
		  this.Id = id;
	   }

	   public Customer(int id, string name) : this(id)
	   {
		  this.Name = name;
	   }
    }
}
