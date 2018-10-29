namespace CSharp_Basics
{
    class DbMigrator
    {
	   public readonly Logger _logger;

	   public DbMigrator(Logger logger)
	   {
		  _logger = logger;
	   }	 
	   
	   public void Migrate()
	   {
		  _logger.Log("Database Migration is complete.");
	   }
    }
}
