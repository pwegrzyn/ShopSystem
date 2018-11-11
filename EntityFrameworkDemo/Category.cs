using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class Category
    {
        // Primary key
        public int CategoryId { get; set; }
        [Index(IsUnique = true)]
        [StringLength(450)]
        public String Name { get; set; }
        public String Description { get; set; }

        // Navigation properties
        private readonly ObservableListSource<Product> _products = new ObservableListSource<Product>();
        public virtual ObservableListSource<Product> Products { get { return _products; } }

        public static void PrintAllCategories()
        {
            using (var context = new ProdContext())
            {
                var categoriesNames = context.Categories.Select(c => c.Name).ToList<String>();
                Console.WriteLine("Available Categories:");
                foreach (var cat in categoriesNames)
                {
                    Console.WriteLine(cat);
                }
            }
        }

        public static void PrintProductsInCategoriesJoin()
        {
            using (var context = new ProdContext())
            {
                var query = from c in context.Categories
                            join p in context.Products
                            on c.CategoryId equals p.CategoryId into productGroup
                            select new
                            {
                                CategoryId = c.CategoryId,
                                CategoryName = c.Name,
                                ProductCount = productGroup.Count(),
                                Products = productGroup
                            };

                var query2 = context.Categories.GroupJoin(context.Products, p => p.CategoryId, c => c.CategoryId,
                    (category, productGroup) => new
                    {
                        CategoryId = category.CategoryId,
                        CategoryName = category.Name,
                        ProductCount = productGroup.Count(),
                        Products = productGroup
                    });

                foreach(var category in query2)
                {
                    Console.WriteLine("CategoryID: {0}", category.CategoryId);
                    Console.WriteLine("Product count: {0}", category.ProductCount);
                    foreach(var prod in category.Products)
                    {
                        Console.WriteLine(" ProductID: {0}", prod.ProductId);
                    }
                    Console.WriteLine("");
                }
            }
        }

        public static void PrintProductsInCategoriesNavigationProperties()
        {
            using (var context = new ProdContext())
            {
                var query = from c in context.Categories
                            select new
                            {
                                CategoryId = c.CategoryId,
                                CategoryName = c.Name,
                                ProductCount = c.Products.Count(),
                                Products = c.Products
                            };

                var query2 = context.Categories.Select(c => new
                    {
                        CategoryId = c.CategoryId,
                        CategoryName = c.Name,
                        ProductCount = c.Products.Count(),
                        Products = c.Products
                    });

                foreach (var category in query2)
                {
                    Console.WriteLine("CategoryID: {0}", category.CategoryId);
                    Console.WriteLine("Product count: {0}", category.ProductCount);
                    foreach (var prod in category.Products)
                    {
                        Console.WriteLine(" ProductID: {0}", prod.ProductId);
                    }
                    Console.WriteLine("");
                }
            }
        }

        public static void PrintProductsInCategoriesLazyEager()
        {
            using (var context = new ProdContext())
            {
                var query = from c in context.Categories
                            select new
                            {
                                CategoryId = c.CategoryId,
                                CategoryName = c.Name,
                                ProductCount = c.Products.Count(),
                                Products = c.Products
                            };

                var query2 = context.Categories.Include("Products").Select(c => new
                {
                    CategoryId = c.CategoryId,
                    CategoryName = c.Name,
                    ProductCount = c.Products.Count(),
                    Products = c.Products
                });

                foreach (var category in query2)
                {
                    Console.WriteLine("CategoryID: {0}", category.CategoryId);
                    Console.WriteLine("Product count: {0}", category.ProductCount);
                    foreach (var prod in category.Products)
                    {
                        Console.WriteLine(" ProductID: {0}", prod.ProductId);
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
