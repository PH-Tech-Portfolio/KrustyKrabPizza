using KrustyKrabPizza.Data;
using KrustyKrabPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KrustyKrabPizza.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    // Binds multiple properties so they will be accessable in the view, specifying we can use GET
    public class CheckoutModel : PageModel
    {
        // Props, nullable,
        // NOTE: names of these properties have to be same as ones being passed in throgh link or else they will not bind
        public string? PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string? ImageTitle { get; set; }
        public bool HasTomatoSause { get; set; }
        public bool HasCheese { get; set; }
        public bool HasMushrooms { get; set; }
        public bool HasPineapple { get; set; }
        public bool HasTuna { get; set; }
        public bool HasHam { get; set; }
        public bool HasBeef { get; set; }
        public List<string> HasTheseList { get; set; } = new List<string>();
        public List<string> NotTheseList { get; set; } = new List<string>();

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            // Contect is our database
            _context = context;
        }


        // Methods
        public void OnGet()
        {
            // If values are null
            if (string.IsNullOrEmpty(PizzaName))
                PizzaName = "Custom";
            if (string.IsNullOrEmpty(ImageTitle))   // NOTE: not even passing this...
                ImageTitle = "Create";

            if (HasTuna)
                HasTheseList.Add("Tuna 🐟");
            else NotTheseList.Add("Tuna 🐟");
            if (HasBeef)
                HasTheseList.Add("Beef 🐄");
            else NotTheseList.Add("Beef 🐄");
            if (HasHam)
                HasTheseList.Add("Ham 🐷");
            else NotTheseList.Add("Ham 🐷");

            if (HasTomatoSause)
                HasTheseList.Add("Tomato 🍅");
            else NotTheseList.Add("Tomato 🍅");
            if (HasCheese)
                HasTheseList.Add("Cheese 🧀");
            else NotTheseList.Add("Cheese 🧀");
            if (HasMushrooms)
                HasTheseList.Add("Mushrooms 🍄");
            else NotTheseList.Add("Mushrooms 🍄");
            if (HasPineapple)
                HasTheseList.Add("Pineapple 🍍");
            else NotTheseList.Add("Pineapple 🍍");

            // Adding pizza order into database
            PizzaOrderModel pizzaOrder = new PizzaOrderModel() { 
                PizzaName = this.PizzaName,
                BasePrice = this.PizzaPrice
            };
            _context.PizzaOrders.Add(pizzaOrder);   // adds order to sql db
            _context.SaveChanges();                 //actually pushes to db 
        }
    }
}
