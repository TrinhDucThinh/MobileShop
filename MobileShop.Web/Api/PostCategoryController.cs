using MobileShop.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MobileShop.Service;
using MobileShop.Model.Models;

namespace MobileShop.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;

        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) : base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request,()=> {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest,ModelState);
                }else
                {
                    var listCategory = _postCategoryService.GetAll();
                    response = request.CreateResponse(HttpStatusCode.OK, listCategory);
                }
                return response;
            });
        }

        public HttpResponseMessage Post(HttpRequestMessage request,PostCategory postCategory)
        {
            return CreateHttpResponse(request,()=> {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    response = request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }else
                {
                    var category=_postCategoryService.Add(postCategory);
                    _postCategoryService.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.OK,category);
                }
                return response;
            });
        }

        public HttpResponseMessage Put(HttpRequestMessage request,PostCategory postCategory)
        {
            return CreateHttpResponse(request,()=> {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    response = request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }else
                {
                    _postCategoryService.Update(postCategory);
                    _postCategoryService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage request,int id)
        {
            return CreateHttpResponse(request,()=> {
                HttpResponseMessage response = null;
                _postCategoryService.Delete(id);
                _postCategoryService.SaveChanges();
                response = request.CreateResponse();
                return response;
            });
        }

    }
}
