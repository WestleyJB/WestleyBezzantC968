using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace C968
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();


        //methods for products
        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }
        public static bool RemoveProduct(int prodID)
        {
            bool success = false;
            foreach (Product prod in Products)
            {
                if (prodID == prod.ProductID)
                {
                    Products.Remove(prod);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("ERROR: Could not remove product. Please try again.");
                    return success = false;
                }
            }
            return success;
        }
        public static Product LookupProduct(int prodID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == prodID)
                {
                    return prod;
                }
            }
            return null;
        }
        public static void UpdateProduct(int prodID, Product updatedProduct)
        {
            foreach (Product currentProduct in Products)
            {
                if (currentProduct.ProductID == prodID)
                {
                    currentProduct.Name = updatedProduct.Name;
                    currentProduct.Inventory = updatedProduct.Inventory;
                    currentProduct.Price = updatedProduct.Price;
                    currentProduct.Max = updatedProduct.Max;
                    currentProduct.Min = updatedProduct.Min;
                    currentProduct.AssociatedParts = updatedProduct.AssociatedParts;
                    return;
                }
            }
        }


        //methods for parts
        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }
        public static bool DeletePart(int part)
        {
            Part partToDelete = LookupPart(part);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                Parts.Remove(partToDelete);
                return true;
            }
        }
        public static Part LookupPart(int partID)
        {
            foreach (Part part in Parts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }
        public static void UpdatePart(int partID, Part part)
        {
            DeletePart(partID);
            AddPart(part);
        }
        public static void ExampleItems()
        {
            Product exampleProd = new Product(1, "Unicycle", 18, 100.0m, 100, 1);
            Product exampleProd2 = new Product(2, "Bicycle", 7, 200.0m, 100, 1);
            Products.Add(exampleProd);
            Products.Add(exampleProd2);

            Part exampleInPart = new InHousePart(1, "Bike Wheel", 34, 20.0m, 100, 1, 001);
            Part exampleOutPart = new OutsourcedPart(2, "Bike Seat", 76, 15.0m, 100, 2, "Bicycles LLC");
            Parts.Add(exampleInPart);
            Parts.Add(exampleOutPart);

        }
    }
}

