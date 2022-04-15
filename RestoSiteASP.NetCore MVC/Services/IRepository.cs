using RestoSiteASP.NetCore_MVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoSiteASP.NetCore_MVC.Services
{
    public interface IRepository
    {
         void Add(Image image);
         void Remove(int id);
         void Update(int id, Image image);
         Image Get(int id);
        IEnumerable<Image> GetAll();
        
    }
}
