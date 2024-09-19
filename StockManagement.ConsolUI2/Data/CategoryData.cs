using StockManagement.ConsolUI2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.ConsolUI2.Data
{
    public class CategoryData
    {

        private List<Category> categories = new List<Category>()
{
         new Category(1,"Elbise","Elbise Açıklaması"),
         new Category(2,"Elektronik","Elektronik Açıklama"),
         new Category(3,"Dekorasyon","Dekorasyon Açıklama"),
         new Category(4,"Spor Aletleri","Spor Aletleri Açıklama"),
};

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category? GetById(int id)
        {
            // L1 
            Category? category = categories.SingleOrDefault(x => x.Id == id);
            return category;
        }

        public Category Add(Category category)
        {
            categories.Add(category);
            return category;
        }
    }
}
