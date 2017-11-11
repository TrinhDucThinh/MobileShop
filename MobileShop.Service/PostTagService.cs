using MobileShop.Model.Models;

namespace MobileShop.Service
{
    public interface IPostTagService
    {
        void Add(PostTag postTag);
        void Update(PostTag postTag);
        void Delete(PostTag postTag);

        
    }

    internal class PostTagService
    {
    }
}