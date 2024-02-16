using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class CategoryOperation
    {
        CategoryManager _categoryManager = new CategoryManager(new InMemoryCategoryDal());

        int _id = 0;
        string _categoryName;

        public void GetAll()
        {
            Console.WriteLine($"╔{new String('═', 27)}╗");
            Console.WriteLine(String.Format("║ {0,-3} ║ {1, -20}║", "Id", "Kategori Adı"));
            Console.WriteLine($"╚{new String('═', 27)}╝");

            foreach (var category in _categoryManager.GetAll())
            {
                Console.WriteLine(String.Format("║ {0,-3} | {1, -20}║", category.Id, category.CategoryName));
            }
            Console.WriteLine($"╚{new String('═', 27)}╝");
        }

        public void Add()
        {
            Console.Write("Kategory ID  : ");
            _id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kategori Adı : ");
            _categoryName = Console.ReadLine();

            Category newCategory = new Category
            {
                Id = _id,
                CategoryName = _categoryName
            };

            _categoryManager.Add(newCategory);
            Console.WriteLine();
        }

        public void DeleteById()
        {
            Console.Write("Silmek istediğiniz Kayıt ID : ");
            _id = Int32.Parse(Console.ReadLine());
            _categoryManager.DeleteById(_id);
        }

        public void Update()
        {
            Console.Write("Güncellemek istediğiniz <Kategori ID> : ");
            _id = Int32.Parse(Console.ReadLine());

            Category updateCategory = _categoryManager.GetAll().SingleOrDefault(c=>c.Id==_id);

            Console.Write("Kategori Adı : ");
            _categoryName = Console.ReadLine();

            updateCategory.Id = _id;
            updateCategory.CategoryName = _categoryName;
            _categoryManager.Update(updateCategory);
        }
    }
}
