using SiteInstitucional.Domain;

namespace SiteInstitucional.Infra
{
    public class PortfolioRepository : BaseRepository<Portfolio>, IPortfolioRepository
    {
        public PortfolioRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
