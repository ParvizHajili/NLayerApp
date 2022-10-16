using Core.Entities.Common;

namespace Core.Entities
{
    public class ProductFeature : BaseEntity
    {
        public int Id { get; set; }
        public string Colour { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
