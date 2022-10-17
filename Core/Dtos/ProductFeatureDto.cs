namespace Core.Dtos
{
    public class ProductFeatureDto
    {
        public int Id { get; set; }
        public string Colour { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public int ProductId { get; set; }
    }
}
