using Shop.Data.Infrastructure;
using Shop.Data.Reponsitory;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public interface IPostCategoryService
    {
        void Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        void Delete(int id);
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllByParentId(int id);
        PostCategory GetById(int id);
    }
    public class PostCategoryService : IPostCategoryService
    {
        private readonly IPostCategoryReponsitory _postCategoryReponsitory;
        private readonly UnitOfWork _unitOfWork;
        public PostCategoryService(IPostCategoryReponsitory postCategoryReponsitory,UnitOfWork unitOfWork)
        {
            _postCategoryReponsitory = postCategoryReponsitory;
            _unitOfWork = unitOfWork;
        }
        public void Add(PostCategory postCategory)
        {
            _postCategoryReponsitory.Add(postCategory);
        }

        public void Delete(int id)
        {
            _postCategoryReponsitory.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryReponsitory.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentId(int id)
        {
            return _postCategoryReponsitory.GetMulti(x => x.Status && x.ParentID == id);
        }

        public PostCategory GetById(int id)
        {
            return _postCategoryReponsitory.GetSingleById(id); 
        }

        public void Update(PostCategory postCategory)
        {
             _postCategoryReponsitory.Update(postCategory);
        }
    }
}
