using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.entity
{
    /// <summary>
    /// Thông tin lớp Category
    /// CreatedBy: ThiepTT(04/04/2022)
    /// </summary>
    public class Category
    {
        #region property
        /// <summary>
        /// Mã Category
        /// </summary>
        public int CategoryCode { get; set; }

        /// <summary>
        /// Tên Category
        /// </summary>
        public string CategoryName { get; set; }


        #endregion

    }
}
