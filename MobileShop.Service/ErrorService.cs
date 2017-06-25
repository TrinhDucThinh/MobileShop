using System;
using MobileShop.Model.Models;
using MobileShop.Data.Repositories;
using MobileShop.Data.Infrastructure;

namespace MobileShop.Service
{
    public interface IErrorService
    {
        Error Add(Error error);
        void SaveChanges();
    }
    public class ErrorService : IErrorService
    {
        IErrorRepository _errorRepository;
        IUnitOfWork _unitOfWork;

        public ErrorService(IErrorRepository errorRepository,IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorRepository;
            this._unitOfWork = unitOfWork;
        }

        public Error Add(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}