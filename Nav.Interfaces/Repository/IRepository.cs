using Nav.Interfaces.UOW;

namespace Nav.Interfaces.Repository
{
	public interface IRepository
	{
		void Submit();
	}

	public interface IRepository<T> : IRepository where T : class { }

	public abstract class GenericRepository<T> : IRepository<T> where T : class
	{
		public GenericRepository(IUnitOfWork unitOfWork)
		{
			unitOfWork.Register(this);
		}
		public void Submit()
		{
			
		}
	}
}
