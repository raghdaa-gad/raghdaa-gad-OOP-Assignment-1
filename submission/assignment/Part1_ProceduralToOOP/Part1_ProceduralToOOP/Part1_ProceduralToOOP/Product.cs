namespace Part1_ProceduralToOOP;

public class Product
{
       public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    
        public Product(int id, string name, double price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }
    
        public void ReduceStock(int quantity)
        {
            Stock -= quantity;
        }
        public bool HasEnoughStock(int quantity)
        {
            return quantity > 0 && Stock >= quantity;
        }
}