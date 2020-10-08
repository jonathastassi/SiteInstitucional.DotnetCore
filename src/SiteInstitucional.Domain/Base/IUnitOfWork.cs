using System.Threading.Tasks;

namespace SiteInstitucional.Domain
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
