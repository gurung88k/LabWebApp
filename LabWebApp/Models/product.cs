using System.ComponentModel.DataAnnotations;
namespace LabWebApp.Models
{
    public class Product
    {
        private decimal price;

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Price), "Price cannot be negative");
                }
                price = value;
            }
        }
        public string Description { get; set; }
    }
}
