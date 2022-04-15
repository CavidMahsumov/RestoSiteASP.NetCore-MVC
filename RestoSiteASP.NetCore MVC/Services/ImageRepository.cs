using RestoSiteASP.NetCore_MVC.Data;
using RestoSiteASP.NetCore_MVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoSiteASP.NetCore_MVC.Services
{
    public class ImageRepository : IRepository
    {
        private readonly ImageDbContext _context;

        public ImageRepository(ImageDbContext context)
        {
            _context = context;
        }

        public void Add(Image image)
        {
            throw new NotImplementedException();
        }

        public Image Get(int id)
        {
            var image = _context.Images.Where(i => i.Id == id).ToArray();
            return image[0];
        }

        public IEnumerable<Image> GetAll()
        {
            return _context.Images.ToList();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Image image)
        {
            throw new NotImplementedException();
        }
    }
}
