using Product.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.dao
{
   
    public class CategoryDAO : Category
    {
        Database database = new Database();
        /// <summary>
        /// Thêm một bản ghi vào categoryTable
        /// CreatedBy: ThiepTT(04/04/2022)
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public int Insert(int row)
        {
            database.InsertTable("categoryTable", row);
            return 0;
        }

        /// <summary>
        /// Cập nhật một bản ghi của Category
        /// CreatedBy: ThiepTT(04/04/2022)
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public int Update(int row)
        {
            Console.WriteLine("Nhập mã danh mục: ");
            database.categoryTable[row].CategoryCode = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Nhập tên danh mục: ");
            database.categoryTable[row].CategoryName = Console.ReadLine();
            return 0;
        }

        /// <summary>
        /// Xóa một bản ghi của Category
        /// CreatedBy: ThiepTT(04/04/2022)
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public bool Delete(int row)
        {
            database.categoryTable = database.categoryTable.Where((source, index) => index != row).ToArray();
            return true;
        }

        /// <summary>
        /// Lấy tất cả bản ghi của Category
        /// CreatedBy: ThiepTT(04/04/2022)
        /// </summary>
        public void FindAll()
        {
            foreach (Category category in database.categoryTable)
            {
                Console.WriteLine(category);
            }
        }

        /// <summary>
        /// Lấy thông tin một bản ghi của Category
        /// CreatedBy: ThiepTT(04/04/2022)
        /// </summary>
        /// <param name="id"></param>
        public void FindById(int id)
        {
            foreach (Category category in database.categoryTable)
            {
                if (category.CategoryCode == id)
                {
                    Console.WriteLine(category);
                }
            }
        }
    }
}
