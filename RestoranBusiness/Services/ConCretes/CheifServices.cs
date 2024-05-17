using RestoranBusiness.Services.Abstracts;
using RestoranCore.Models;
using RestoranCore.RepostoryAbstract;
using RestoranData.RepostoryConcreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranBusiness.Services.ConCretes
{
    public  class CheifServices:ICheifServices

    {
        public ICheifRepostory _cheifRepostory;
        public CheifServices(ICheifRepostory cheifRepostory)
        {
            _cheifRepostory = cheifRepostory;
        }

        public async Task AddCheifAsync(Cheif cheif)
        {
            if (_cheifRepostory.GetAll().Any(x => x.Name == cheif.Name))
                await _cheifRepostory.AddAsync(cheif);
            throw new Exception();




        }

        public void DeleteCheif(int Id)
        {

            

        }

        public List<Cheif> GetAllCheifs()
        {
            return _cheifRepostory.GetAll();
        }

        public Cheif GetCheif(Func<Cheif, bool>? func = null)
        {
            return _cheifRepostory.Get(func);
        }

        public void UpdateCheifAsync(int Id, Cheif cheif)
        {
            //oldcheif = _cheifRepostory.Get(x=>x.Id == Id);
            //if(oldcheif==null) throw new Exception("bele cheif yoxdur");

        }
    }
}
