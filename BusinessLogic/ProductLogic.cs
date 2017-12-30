using DataHandeler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProductLogic
    {
        ProductData productData = new ProductData();
        public void getData()
        {
            productData.getProductData();
        }
    }
}
