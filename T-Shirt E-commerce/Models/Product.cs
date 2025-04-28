namespace T_Shirt_E_commerce.Models
{
    
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }          // <--- this line is very important
            public string Description { get; set; }
            public decimal Price { get; set; }
            public string ImageUrl { get; set; }
        }
 }


