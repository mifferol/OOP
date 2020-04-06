using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IVisits
    {
        IEnumerable<Visits> GetAllVisits();
        int AddVisits(Visits visits);
        int UpdateVisits(Visits visits);
        int DeleteVisits(int id);
        Visits GetVisitsData(int id);

    }
}
