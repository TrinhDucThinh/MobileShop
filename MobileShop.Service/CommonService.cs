using MobileShop.Common;
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
    public interface ICommonService
    {
        Footer GetFooter();
    }
    public class CommonService : ICommonService
    {
        IFooterRepository _footerRepository;
        IUnitOfWork _unitOfWork;

        public CommonService(IFooterRepository footerRepository, IUnitOfWork unitOfWork)
        {
            this._footerRepository = footerRepository;
            this._unitOfWork = unitOfWork;
        }
        public Footer GetFooter()
        {
            return _footerRepository.GetSingleByCondition(x=>x.ID==CommonConstants.DefaultFooterID);
        }
    }
}
