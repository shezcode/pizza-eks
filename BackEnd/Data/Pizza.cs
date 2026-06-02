namespace PizzeriaApi.Data
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public PizzaSize Size { get; set; }
        public decimal Price { get; set; }
        public bool Vegetarian { get; set; }
    }

    public enum PizzaSize
    {
        Small,
        Medium,
        Large
    }
}
