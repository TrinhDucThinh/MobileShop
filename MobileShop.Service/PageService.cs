using MobileShop.Data.Infrastructure;
using MobileShop.Data.Repositories;
using MobileShop.Model.Models;
using System;
using System.Collections.Generic;

namespace MobileShop.Service
{
    public interface IPageService
    {
        void Add(Page page);

        void Update(Page page);

        void Delete(int id);

        IEnumerable<Page> GetAll();

        IEnumerable<Page> GetAllPaging(int page, int pageSize, out int totalRow);

        Page GetByAlias(string alias);

        void SaveChanges();
    }

    public class PageService : IPageService
    {
        private IPageRepository _pageRepository;
        private IUnitOfWork _unitOfWork;

        public PageService(IPageRepository pageRepository, IUnitOfWork unitOfWork)
        {
            this._pageRepository = pageRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Page page)
        {
            _pageRepository.Add(page);
        }

        public void Delete(int id)
        {
            _pageRepository.Delete(id);
        }

        public IEnumerable<Page> GetAll()
        {
            return _pageRepository.GetAll();
        }

        public IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Page> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _pageRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Page GetByAlias(string alias)
        {
            return _pageRepository.GetSingleByCondition(x => x.Alias == alias);
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            throw new NotImplementedException();
        }

        public void Update(Page page)
        {
            _pageRepository.Update(page);
        }
    }
}