using MobileShop.Model.Models;
using System.Collections.Generic;
using System;
using MobileShop.Data.Repositories;
using MobileShop.Data.Infrastructure;

namespace MobileShop.Service
{
    //public interface IPostService
    //{
    //    void Delete(int id);

    //    void Add(Post post);

    //    void Update(Post post);

    //    IEnumerable<Post> GetAll();

    //    IEnumerable<Post> GetAllPagging(int page, int pageSize, out int total);

    //    IEnumerable<Post> GetAllByTag(string keyword, int page, int pageSize, out int total);
    //}

    //public class PostService : IPostService
    //{
    //    IPostRepository _postRepository;
    //    IUnitOfWork _unitOfWork;

    //    public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
    //    {
    //        this._postRepository = postRepository;
    //        this._unitOfWork = unitOfWork;
    //    }

    //    public void Add(Post post)
    //    {
    //        _postRepository.Add(post);
    //    }

    //    public void Delete(int id)
    //    {
    //        _postRepository.Delete(id);
    //    }

    //    public IEnumerable<Post> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<Post> GetAllByTag(string keyword, int page, int pageSize, out int total)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<Post> GetAllPagging(int page, int pageSize, out int total)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Post post)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public interface IPostService
    {
        void Add(Post post);

        void Update(Post post);

        void Delete(int id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);

        Post GetById(int id);

        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChanges();
    }

    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status && x.CategoryID == categoryId, out totalRow, page, pageSize, new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //TODO: Select all post by tag
            return _postRepository.GetAllByTag(tag, page, pageSize, out totalRow);

        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}