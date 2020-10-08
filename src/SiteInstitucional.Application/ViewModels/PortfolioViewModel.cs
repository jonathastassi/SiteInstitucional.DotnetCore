using System;

namespace SiteInstitucional.Application
{
    public class PortfolioViewModel
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Image { get; private set; }

        public PortfolioViewModel(string title, string image)
        {
            Title = title;
            Image = image;
        }
    }
}