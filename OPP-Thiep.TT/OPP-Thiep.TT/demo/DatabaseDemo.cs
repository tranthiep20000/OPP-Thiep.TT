using Product.dao;
using Product.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.demo
{
    /// <summary>
    /// Thông tin class DatabaseDemo
    /// CreatedBy: ThiepTT(04/04/2022)
    /// </summary>
    public class DatabaseDemo : Database
    {
        
        public int InsertTableTest()
        {
            return 0;
        }

        public void SelectTableTest()
        {

        }

        public int UpdateTableTest()
        {
            return 0;
        }

        public bool DeleteTableTest()
        {
            return true;
        }

        public void TruncateTableTest()
        {

        }

        /// <summary>
        /// Tạo dữ liệu cho các mảng đối tượng
        /// CreatedBy: Thiep(04/04/2022)
        /// </summary>
        public void InitDatabase()
        {

            productTable = new Product[100];
            categoryTable = new Category[100];
            accessotionTable = new Accessotion[100];


            productTable[0] = new Product { ProductCode = 1, ProductName = "San pham 1", CategoryCode = 1 };
            productTable[1] = new Product { ProductCode = 2, ProductName = "San pham 2", CategoryCode = 2 };
            productTable[2] = new Product { ProductCode = 3, ProductName = "San pham 3", CategoryCode = 3 };
            productTable[3] = new Product { ProductCode = 4, ProductName = "San pham 4", CategoryCode = 4 };
            productTable[4] = new Product { ProductCode = 5, ProductName = "San pham 5", CategoryCode = 5 };
            productTable[5] = new Product { ProductCode = 6, ProductName = "San pham 6", CategoryCode = 6 };
            productTable[6] = new Product { ProductCode = 7, ProductName = "San pham 7", CategoryCode = 7 };
            productTable[7] = new Product { ProductCode = 8, ProductName = "San pham 8", CategoryCode = 8 };
            productTable[8] = new Product { ProductCode = 9, ProductName = "San pham 9", CategoryCode = 9 };
            productTable[9] = new Product { ProductCode = 10, ProductName = "San pham 10", CategoryCode = 10 };

            categoryTable[0] = new Category { CategoryCode = 1, CategoryName = "Danh muc 1" };
            categoryTable[1] = new Category { CategoryCode = 2, CategoryName = "Danh muc 2" };
            categoryTable[2] = new Category { CategoryCode = 3, CategoryName = "Danh muc 3" };
            categoryTable[3] = new Category { CategoryCode = 4, CategoryName = "Danh muc 4" };
            categoryTable[4] = new Category { CategoryCode = 5, CategoryName = "Danh muc 5" };
            categoryTable[5] = new Category { CategoryCode = 6, CategoryName = "Danh muc 6" };
            categoryTable[6] = new Category { CategoryCode = 7, CategoryName = "Danh muc 7" };
            categoryTable[7] = new Category { CategoryCode = 8, CategoryName = "Danh muc 8" };
            categoryTable[8] = new Category { CategoryCode = 9, CategoryName = "Danh muc 9" };
            categoryTable[9] = new Category { CategoryCode = 10, CategoryName = "Danh muc 10" };


            accessotionTable[0] = new Accessotion { AccessotionCode = 1, AccessotionName = "Accessotion 1" };
            accessotionTable[1] = new Accessotion { AccessotionCode = 2, AccessotionName = "Accessotion 2" };
            accessotionTable[2] = new Accessotion { AccessotionCode = 3, AccessotionName = "Accessotion 3" };
            accessotionTable[3] = new Accessotion { AccessotionCode = 4, AccessotionName = "Accessotion 4" };
            accessotionTable[4] = new Accessotion { AccessotionCode = 5, AccessotionName = "Accessotion 5" };
            accessotionTable[5] = new Accessotion { AccessotionCode = 6, AccessotionName = "Accessotion 6" };
            accessotionTable[6] = new Accessotion { AccessotionCode = 7, AccessotionName = "Accessotion 7" };
            accessotionTable[7] = new Accessotion { AccessotionCode = 8, AccessotionName = "Accessotion 8" };
            accessotionTable[8] = new Accessotion { AccessotionCode = 9, AccessotionName = "Accessotion 9" };
            accessotionTable[9] = new Accessotion { AccessotionCode = 10, AccessotionName = "Accessotion 10" };
        }
        /// <summary>
        /// In ra danh sách đối tượng
        /// CreatedBy: Thiep(04/04/2022)
        /// </summary>
        /// <param name="name"></param>
        public void PrintTableTest(string name)
        {
           if(name == "productTable")
           {
                foreach (Product product in productTable)
                {
                    Console.WriteLine(product);
                }
           }
           else if (name == "accessotionTable")
           {
                foreach (Accessotion accessotion in accessotionTable)
                {
                    Console.WriteLine(accessotion);
                }
           }
           else if (name == "categoryTable")
           {
                foreach (Category category in categoryTable)
                {
                    Console.WriteLine(category);
                }
           }
        }
    }
}
