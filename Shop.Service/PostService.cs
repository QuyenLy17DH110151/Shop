using Shop.Data.Infrastructure;
using Shop.Data.Reponsitory;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shop.Data.Reponsitory.PostReponsitory;

namespace Shop.Service
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page,int pageSize,out int totalRow);
        IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);
        Post GetById(int id);
        IEnumerable<Post> GetAllTagPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChange();  
    }
    public class PostService : IPostService
    {
        private readonly IPostReponsitory _postReponsitory;
        private readonly IUnitOfWork _unitOfWork;
        public PostService(IPostReponsitory postReponsitory,IUnitOfWork unitOfWork)
        {
            _postReponsitory = postReponsitory;
            _unitOfWork = unitOfWork;
        }
        public void Add(Post post)
        {
            _postReponsitory.Add(post);
        }

        public void Delete(int id)
        {
            _postReponsitory.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
           return _postReponsitory.GetAll(new string[] { "PostCategogy" });
        }

        public IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _postReponsitory.GetMultiPaging(x=>x.Status && x.CategoryID==categoryId, out totalRow, page, pageSize, new string[] { "Category" });
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postReponsitory.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<Post> GetAllTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //By tag
            return _postReponsitory.GetAllByTag(tag,page,pageSize,out totalRow);
        }

        public Post GetById(int id)
        {
            return _postReponsitory.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postReponsitory.Update(post);
        }
    }
}
