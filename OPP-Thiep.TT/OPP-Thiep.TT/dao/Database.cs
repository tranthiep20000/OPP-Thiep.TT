using Product.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.dao
{
    /// <summary>
    /// Thông tin class Database
    /// CreatedBy: ThiepTT(04/04/2022)
    /// </summary>
    public class Database
    {
        /// <summary>
        /// Mảng đối tượng Product
        /// </summary>
        public Product[] productTable { get; set; }

        /// <summary>
        /// Mảng đối tượng Category
        /// </summary>
        public Category[] categoryTable { get; set; }

        /// <summary>
        /// Mảng đối tượng Accessotion
        /// </summary>
        public Accessotion[] accessotionTable { get; set; }

        public Database()
        {

        }

        /// <summary>
        /// Thêm một bản ghi
        /// CreatedBy: ThiepTT(04/04/2022)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public int InsertTable(string name, int row)
        {
            if( name == "productTable")
            {
                row = productTable.Length + 1;
                Console.WriteLine("Nhập mã sản phẩm: ");
                productTable[row].ProductCode = Int16.Parse(Console.ReadLine());

                Console.WriteLine("Nhập tên sản phẩm: ");
                productTable[row].ProductName = Console.ReadLine();

                Console.WriteLine("Nhập mã danh mục: ");
                productTable[row].CategoryCode = Int16.Parse(Console.ReadLine());
            }

            else if(name == "categoryTable")
            {
                row = productTable.Length + 1;
                Console.WriteLine("Nhập mã danh mục: ");
                categoryTable[row].CategoryCode = Int16.Parse(Console.ReadLine());

                Console.WriteLine("Nhập tên danh mục: ");
                categoryTable[row].CategoryName = Console.ReadLine();
            }

            else if(name == "accessotionTable")
            {
                row = productTable.Length + 1;
                Console.WriteLine("Nhập mã accessotionTable: ");
                accessotionTable[row].AccessotionCode = Int16.Parse(Console.ReadLine());

                Console.WriteLine("Nhập tên accessotionTable: ");
                accessotionTable[row].AccessotionName = Console.ReadLine();
            }
            return 0;
        }

        /// <summary>
        /// Lấy ra các bản ghi theo điều kiện
        /// CreatedBy: ThiepTT(04/04/2022)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="where"></param>
        public void SelectTable(string name, string where)
        {
            if (name == "productTable")
            {
                foreach (Product product in productTable)
                {
                    if(product.ProductName == where)
                    {
                        Console.WriteLine(product);
                    }    
                }
            }

            else if (name == "categoryTable")
            {
                foreach (Category category in categoryTable)
                {
                    if (category.CategoryName == where)
                    {
                        Console.WriteLine(category);
                    }
                }
            }

            else if (name == "accessotionTable")
            {
                foreach (Accessotion accessotion in accessotionTable)
                {
                    if (accessotion.AccessotionName == where)
                    {
                        Console.WriteLine(accessotion);
                    }
                }
            }
        }

        /// <summary>
        /// Sửa một bản ghi
        /// CreatedBy: ThiepTT(04/04/2022)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public int UpdateTable(string name , int row)
        {
            if (name == "productTable")
            {
                Console.WriteLine("Nhập mã sản phẩm: ");
                productTable[row].ProductCode = Int16.Parse(Console.ReadLine());

                Console.WriteLine("Nhập tên sản phẩm: ");
                productTable[row].ProductName = Console.ReadLine();

                Console.WriteLine("Nhập mã danh mục: ");
                productTable[row].CategoryCode = Int16.Parse(Console.ReadLine());
            }

            else if (name == "categoryTable")
            {
                Console.WriteLine("Nhập mã danh mục: ");
                categoryTable[row].CategoryCode = Int16.Parse(Console.ReadLine());

                Console.WriteLine("Nhập tên danh mục: ");
                categoryTable[row].CategoryName = Console.ReadLine();
            }

            else if (name == "accessotionTable")
            {
                Console.WriteLine("Nhập mã accessotionTable: ");
                accessotionTable[row].AccessotionCode = Int16.Parse(Console.ReadLine());

                Console.WriteLine("Nhập tên accessotionTable: ");
                accessotionTable[row].AccessotionName = Console.ReadLine();
            }
            return 0;
        }

        /// <summary>
        /// Xóa một bản ghi
        /// CreatedBy: ThiepTT(04/04/2022)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public bool DeleteTable(string name, int row)
        {
            if (name == "productTable")
            {
                productTable = productTable.Where((source, index) => index != row).ToArray();
            }

            else if (name == "categoryTable")
            {
                categoryTable = categoryTable.Where((source, index) => index != row).ToArray();
            }

            else if (name == "accessotionTable")
            {
                accessotionTable = accessotionTable.Where((source, index) => index != row).ToArray();
            }
            return true;
        }

        /// <summary>
        /// Xóa tất cả bản ghi 
        /// CreatedBy: ThiepTT(04/04/2022)
        /// </summary>
        /// <param name="name"></param>
        public void TruncateTable(string name)
        {
            if (name == "productTable")
            {
                Array.Clear(productTable, 0, productTable.Length);
            }

            else if (name == "categoryTable")
            {
                Array.Clear(categoryTable, 0, categoryTable.Length);
            }

            else if (name == "accessotionTable")
            {
                Array.Clear(accessotionTable, 0, accessotionTable.Length);
            }
           
        }

        public int UpdateTableById(int id, int row)
        {
            return 0;
        }

    }
}
