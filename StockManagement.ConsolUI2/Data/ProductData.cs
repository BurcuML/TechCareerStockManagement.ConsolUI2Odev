﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using StockManagement.ConsolUI2.Models;
namespace StockManagement.ConsoleUI.Data;

public class ProductData
{

    private List<Product> products = new List<Product>()
{
    new Product(1,"Beymen Takım Elbise",15000,250),
    new Product(2,"Prada Çanta",60000,10),
    new Product(3,"Hk Vision Drone",400000,25),
    new Product(4,"Dyson Süpürge",32000,200),
    new Product(5,"Karaca Vazo",500,1000),
    new Product(6,"Kütahya Porselen Ayna",1500,200),
    new Product(7, "Adidas Futbol Topu",5000,1254),
    new Product(8,"Delta Yoga Matı",2000,531)
};

    public Product Add(Product product)
    {
        products.Add(product);
        return product;
    }

    public double TotalProductPriceSum()
    {
        double total = products.Sum(x => x.Price);
        return total;
    }

    public List<Product> GetAllPriceRange(double min, double max)
    {
        // 1. Yöntem
        //List<Product> filteredProducts = new List<Product>();

        //foreach (Product product in products)
        //{
        //    if (product.Price >= min && product.Price <= max)
        //    {
        //       filteredProducts.Add(product);
        //    }
        //}
        //return filteredProducts;


        var filteredProducts = products.Where(x => x.Price <= max && x.Price >= min).ToList();
        return filteredProducts;

        // Where(lambda[Dönüş tipi : bool]) : Verilerin filtrelenmesi için kullanılır.
    }

    public List<Product> GetAllProductNameContains(string text)
    {
        // 1. Yöntem
        //List<Product> filteredProducts = new List<Product>();

        //foreach (Product product in products) 
        //{
        //    if (product.Name.Contains(text,StringComparison.InvariantCultureIgnoreCase))
        //    {
        //        filteredProducts.Add(product); 
        //    }
        //}
        //return filteredProducts;


        // FindAll(lambda[Dönüş tipi : bool]) : Where.ToList den farkı işin sonunda sadece Liste döndürür.
        var filteredProducts = products.FindAll(x => x.Name.Contains(text));
        return filteredProducts;
    }

    public Product? GetById(int id)
    {
        //1. Yöntem
        //Product? product = null;
        //foreach (Product item in products)
        //{
        //    if (item.Id == id)
        //    {
        //        product = item;
        //        break;
        //    }
        //}
        //return product;

        // L1 
        Product? product = products.SingleOrDefault(x => x.Id == id);

        // Product? product = products.Where(x => x.Id == id).SingleOrDefault();

        //Product? product = products.FirstOrDefault(x=> x.Id ==id);
        return product;
    }


    public Product Delete(int id)
    {
        Product? product = GetById(id);

        if (product is not null)
        {
            products.Remove(product);
        }
        else
        {
            return null;
        }

        return product;



    }

    public List<Product> GetAll()
    {
        return products;
    }

    public List<Product> GetAllProductsByStockRange(int min, int max)
    {
        List<Product> filtered = products.FindAll(x => x.Stock <= max && x.Stock >= min);
        return filtered;
    }


    public List<Product> GetAllProductsOrderByAscendingName()
    {
        List<Product> orderBy = products.OrderBy(x => x.Name).ToList();
        return orderBy;
    }

    public List<Product> GetAllProductsOrderByDescendingName()
    {
        List<Product> orderBy = products.OrderByDescending(x => x.Name).ToList();
        return orderBy;
    }

    public Product GetExpensiveProduct()
    {
        Product expensiveProduct = products.OrderBy(x => x.Price).FirstOrDefault();
        return expensiveProduct;
    }

    public Product GetCheapProduct()
    {
        Product cheapProduct = products.OrderBy(x => x.Price).LastOrDefault();
        return cheapProduct;
    }
}
