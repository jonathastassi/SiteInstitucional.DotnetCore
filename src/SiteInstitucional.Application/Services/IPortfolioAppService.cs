using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiteInstitucional.Application
{
    public interface IPortfolioAppService
    {
        Task<PortfolioViewModel> Insert(PortfolioViewModel entity);

        Task<IEnumerable<PortfolioViewModel>> GetLatests(int n = 0);
    }
}
