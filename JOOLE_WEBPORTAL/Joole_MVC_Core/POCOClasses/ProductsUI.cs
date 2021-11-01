using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joole_MVC_Core.POCOClasses
{
    public class ProductsUI
    {
        [Required]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Series { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int ModelYear { get; set; }
        [Required]
        public int SubCategoryID { get; set; }
    }
}
