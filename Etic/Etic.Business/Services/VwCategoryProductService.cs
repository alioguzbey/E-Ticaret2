using Etic.Data.Abstract;
using Etic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etic.Business.Services
{
    public class VwCategoryProductService : IVwCategoryProductService
    {
        IVwCategoryProductDal _vwCategoryProductDal;

        public VwCategoryProductService(IVwCategoryProductDal vwCategoryProductDal)
        {
            _vwCategoryProductDal = vwCategoryProductDal;
        }

        public IList<VwCategoryProduct> List(string catSeoName)
        {
            return _vwCategoryProductDal.GetAll(x => x.SeoLinkCat == catSeoName);
        }
    }
    public interface IVwCategoryProductService
    {
        public IList<VwCategoryProduct> List(string catSeoName);
    }
}
