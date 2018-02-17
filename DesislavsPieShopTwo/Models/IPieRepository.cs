using System.Collections.Generic;

namespace DesislavsPieShopTwo.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
    }
}
