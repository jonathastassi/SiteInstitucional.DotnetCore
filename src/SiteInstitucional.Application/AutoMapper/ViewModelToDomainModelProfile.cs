
using AutoMapper;
using SiteInstitucional.Domain;

namespace SiteInstitucional.Application
{
    public class ViewModelToDomainModelProfile : Profile
    {
        public ViewModelToDomainModelProfile()
        {
            CreateMap<PortfolioViewModel, Portfolio>().ReverseMap();
        }
    }
}