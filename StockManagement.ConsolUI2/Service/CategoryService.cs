using StockManagement.ConsoleUI.Data;
using StockManagement.ConsolUI2.Data;
using StockManagement.ConsolUI2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.ConsolUI2.Service
{
    public class CategoryService
    {

        CategoryData categoryData = new CategoryData();

        public void GetAll()
        {
            List<Category> categories = categoryData.GetAll();

            foreach (Category category in categories)
            {
                Console.WriteLine(category);
            }
        }

        public void GetById(int id)
        {
            Category? category = categoryData.GetById(id);

            if (category is null)
            {
                Console.WriteLine($"Aradığınız Id ye göre ürün bulunamadı :{id}");
                return;
            }

            Console.WriteLine(category);
        }
        public void Add(Category category)
        {
            categoryData.Add(category);
            Console.WriteLine($"Kategori eklendi: {category} ");

        }


    }
}
