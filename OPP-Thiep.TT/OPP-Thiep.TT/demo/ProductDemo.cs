using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.demo
{
    public class ProductDemo : Product
    {
        #region method
        /// <summary>
        /// Tạo một đối tượng Product
        /// CreatedBy: ThiepTT(04/04/2022)
        /// </summary>
        public void CreateProductTest()
        {

        }

        /// <summary>
        /// In ra thông tin của đối tượng
        /// CreatedBy: ThiepTT(04/04/2022)
        /// </summary>
        /// <param name="product"></param>
        public void PrintProduct(Product product)
        {
            foreach (product in productTable)
            {
                Console.WriteLine(product);
            }
        }
        #endregion


    }
}
