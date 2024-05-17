using RestoranCore.Models;
using RestoranCore.RepostoryAbstract;
using RestoranData.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranData.RepostoryConcreate
{
    public class CheifRepostory : GenericRepostory<Cheif>, ICheifRepostory
    {
        public CheifRepostory(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
