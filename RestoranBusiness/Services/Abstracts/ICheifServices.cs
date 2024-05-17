using RestoranCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranBusiness.Services.Abstracts
{
    public  interface ICheifServices
    {
        Task AddCheifAsync(Cheif cheif);
        void DeleteCheif(int Id);
        void UpdateCheifAsync(int Id, Cheif cheif);
        Cheif GetCheif(Func<Cheif, bool>? func = null);
        List<Cheif> GetAllCheifs();
    }
}
