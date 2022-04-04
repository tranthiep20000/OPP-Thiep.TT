using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    /// <summary>
    /// Thông tin lớp Product
    /// CreatedBy: ThiepTT(04/04/2022)
    /// </summary>
    public class Product
    {
        #region property
        /// <summary>
        /// Mã Product
        /// </summary>
        public int ProductCode { get; set; }

        /// <summary>
        /// Tên Product
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Khóa chính bảng Category
        /// </summary>
        public int CategoryCode  { get; set; }
        #endregion
       
    }
}
