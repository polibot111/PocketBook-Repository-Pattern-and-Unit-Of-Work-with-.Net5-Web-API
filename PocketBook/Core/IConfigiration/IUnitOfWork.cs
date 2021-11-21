using System.Threading.Tasks;
using PocketBook.Core.IRepositories;

namespace PocketBook.Core.IConfigiration
{
    public interface IUnitOfWork
    {
         IUserRespository Users {get;}

         Task CompleteAsync();
    }
}