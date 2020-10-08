using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using SiteInstitucional.Domain;

namespace SiteInstitucional.Application
{
    public class PortfolioAppService : IPortfolioAppService
    {
        private readonly IPortfolioRepository portfolioRepository;
        private readonly IMapper mapper;

        public PortfolioAppService(
            IPortfolioRepository portfolioRepository,
            IMapper mapper
        )
        {
            this.portfolioRepository = portfolioRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<PortfolioViewModel>> GetLatests(int n)
        {
            var items = await this.portfolioRepository.GetAll(x => x.Visible == true, x => x.CreatedAt, false, n);
            return this.mapper.Map<IEnumerable<PortfolioViewModel>>(items);
        }

        public async Task<PortfolioViewModel> Insert(PortfolioViewModel entity)
        {
            var model = this.mapper.Map<Portfolio>(entity);
            model.SetVisible(true);
            var inserted = this.portfolioRepository.Add(model);
            await this.portfolioRepository.unitOfWork.Commit();
            return this.mapper.Map<PortfolioViewModel>(inserted);
        }
    }
}
