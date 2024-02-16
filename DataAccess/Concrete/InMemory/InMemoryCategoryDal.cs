using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public InMemoryCategoryDal()
        {

            _categories = new List<Category>
            {
                new Category{Id=1, CategoryName = "Yazılım"},
                new Category{Id=2, CategoryName="Network"},
                new Category{Id=3, CategoryName="Siber Güvenlik"}
            };

        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
           Category deleteToCategory = _categories.SingleOrDefault(c=>c.Id==category.Id);
            _categories.Remove(deleteToCategory);
        }

        public void DeleteById(int id)
        {
            _categories.Remove(_categories.SingleOrDefault(c=>c.Id==id));
        }

        public List<Category> GetAll()
        {
            return _categories.ToList();
        }

        public void Update(Category category)
        {
            Category updateCategory = _categories.SingleOrDefault(c=>c.Id == category.Id);
            updateCategory.CategoryName = category.CategoryName;
        }
    }
}
