using System;
using System.Collections.Generic;
using System.Text;

namespace ReactjsCoreTest.Application.ViewModel
{
   public class ProductViewModel
    {
        public string ObjectId { get; set; }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }

        public decimal OriginalPrice { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }
    }
}
