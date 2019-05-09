using Nav.Entities.Operators;
using System.Data.Entity;

namespace Nav.EntityFrameWork
{
	public class NavContext : DbContext
	{
		public NavContext() : base("name=default")
        {
			Database.SetInitializer(new DropCreateDatabaseAlways<NavContext>());
		}
		public DbSet<Operators> Openators { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//Adds configurations for Student from separate class
			
		}

		
	}
}
