using PortfolioApi.Enums;

namespace PortfolioApi.Models
{
    public class SpecialSkills : BaseClass
    {
        public DisplayType DisplayType { get; set; }
        public string Title { get; set; }
        public int Percentage { get; set; }
    }
}
