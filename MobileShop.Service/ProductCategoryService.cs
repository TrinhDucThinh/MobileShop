using MobileShop.Data.Infrastructure;
using MobileShop.Data.Repositories;
using MobileShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop.Service
{
    public interface IProductCategoryService 
    {
        ProductCategory Add(ProductCategory ProductCategory);

        void Update(ProductCategory productCategory);

        ProductCategory Delete(int id);

        void SaveChanges();

        IEnumerable<ProductCategory> GetAll(string keyword);

        ProductCategory GetByID(int id);

    }

    public class ProductCategoryService : IProductCategoryService
    {
        private IUnitOfWork _unitOfWork;
        private IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryService(IUnitOfWork unitOfWork, IProductCategoryRepository productCategoryRepository)
        {
            this._productCategoryRepository = productCategoryRepository;
            this._unitOfWork = unitOfWork;
        }
        public ProductCategory Add(ProductCategory ProductCategory)
        {
            return _productCategoryRepository.Add(ProductCategory);
        }

        public ProductCategory Delete(int id)
        {
            return _productCategoryRepository.Delete(id);
        }

        public IEnumerable<ProductCategory> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _productCategoryRepository.GetMulti(x => x.Name.Contains(keyword) || x.Description.Contains(keyword));
            else
                return _productCategoryRepository.GetAll();

        }

        public IEnumerable<ProductCategory> GetAllByParentId(int parentId)
        {
            return _productCategoryRepository.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public ProductCategory GetByID(int id)
        {
            return _productCategoryRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductCategory ProductCategory)
        {
            _productCategoryRepository.Update(ProductCategory);
        }

    }
}
