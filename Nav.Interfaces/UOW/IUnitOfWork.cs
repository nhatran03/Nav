using Nav.Interfaces.Repository;

namespace Nav.Interfaces.UOW
{
	public interface IUnitOfWork
	{
		void Register(IRepository repository);

		void Commit();
	}
}
