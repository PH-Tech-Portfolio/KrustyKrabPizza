using KrustyKrabPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KrustyKrabPizza.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        // Props
        [BindProperty]  // Binding custom pizza (below) to the pizza model (above). Allows creation of custom pizzas from the custom pizzas view
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        // Additional toppings
        //public bool HasTomatoSause { get; set; }
        //public bool HasCheese { get; set; }
        //public bool HasMushrooms { get; set; }
        //public bool HasPineapple { get; set; } // Should make label do something funny like be red or whatever idk
        //public bool HasTuna { get; set; }
        //public bool HasHam { get; set; }
        //public bool HasBeef { get; set; }

        // Methods
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.HasBeef)
                PizzaPrice += 4.99f;
            if (Pizza.HasTuna)
                PizzaPrice += 4.99f;
            if (Pizza.HasHam)
                PizzaPrice += 4.99f;


            if (Pizza.HasPineapple)
                PizzaPrice += 1.99f;
            if (Pizza.HasTomatoSause)
                PizzaPrice += 1.99f;
            if (Pizza.HasMushrooms)
                PizzaPrice += 1.99f;
            if (Pizza.HasCheese)
                PizzaPrice += 1.99f;


            // Might wanna use pizza.has instead, but step through and see

            return RedirectToPage("/Checkout/Checkout", new {
                // Main stuff
                Pizza.PizzaName,
                PizzaPrice, 
                // Toppings
                Pizza.HasTomatoSause,
                Pizza.HasCheese,
                Pizza.HasMushrooms,
                Pizza.HasPineapple,
                // Proteins
                Pizza.HasTuna,
                Pizza.HasHam,
                Pizza.HasBeef
            });
        }
    }
}
