namespace MobileShop.Web.Models
{
    public class PostTagViewModel
    {
        public int PostID { get; set; }

        public string TagID { get; set; }

        public virtual PostViewModel Post { set; get; }

        public virtual TagViewModel Tag { set; get; }
    }
}