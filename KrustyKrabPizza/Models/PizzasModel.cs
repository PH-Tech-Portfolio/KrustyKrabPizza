namespace KrustyKrabPizza.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 15.99f;
        public bool HasTomatoSause { get; set; }
        public bool HasCheese { get; set; }
        public bool HasMushrooms { get; set; }
        public bool HasPineapple { get; set; } // Should make label do something funny like be red or whatever idk
        public bool HasTuna { get; set; }
        public bool HasHam { get; set; }
        public bool HasBeef { get; set; }
        public float FinalPrice { get; set; }
    }
}
