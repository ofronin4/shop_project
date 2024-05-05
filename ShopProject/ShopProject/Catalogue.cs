using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject
{
    internal class Catalogue
    {
        List <Category> categories = new List <Category> ();

        public string Catalogue_Name { get; set; }

        public Catalogue() { }

        public void Display()
        {
            foreach (Category category in categories)
            {
                Console.WriteLine($" {category.Category_Name}");
                category.Display();
            }
        }
        public void Add()
        {
            Console.WriteLine("Enter category name: ");
            string category_name = Console.ReadLine();
            Category category = GetCategory(category_name);
            if (category == null)
            {
                category.Category_Name = category_name;
                categories.Add(category);
            }
        }
        public void Remove()
        {
            Console.WriteLine("Enter category name: ");
            string category_name = Console.ReadLine();
            Category category = GetCategory(category_name);
            if (category != null)
            {
                categories.Remove(category);
            }
        }
        public void RemoveProduct()
        {
            Console.WriteLine("Enter category name: ");
            string category_name = Console.ReadLine();
            Category category = GetCategory(category_name);
            if (category != null)
            {
                category.Remove();
            }
        }
        public void AddProduct()
        {
            Console.WriteLine("Enter category name: ");
            string category_name = Console.ReadLine();
            Category category = GetCategory(category_name);
            category.Add();
        }
        public Category GetCategory(string category_name)
        {
            foreach (Category category in categories)
            {
                if (category.Category_Name == category_name) return category;
            }
            return null;
        }
        public IProduct GetProduct(double id)
        {
            foreach (Category category in categories)
            {
                return category.GetProduct(id);
            }
            return null;
        }
    }
}
