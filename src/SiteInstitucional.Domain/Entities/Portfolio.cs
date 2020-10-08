
namespace SiteInstitucional.Domain
{
    public class Portfolio : BaseEntity
    {
        public bool Visible { get; private set; }
        public string Title { get; private set; }
        public string Image { get; private set; }

        public Portfolio()
        {
        }

        public Portfolio(bool visible, string title, string image)
        {
            Visible = visible;
            Title = title;
            Image = image;
        }

        public void SetVisible(bool value)
        {
            this.Visible = value;
        }
    }
}
