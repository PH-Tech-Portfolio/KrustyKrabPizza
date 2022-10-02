using KrustyKrabPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KrustyKrabPizza.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]  // Binding custom pizza (below) to the pizza model (above). Allows creation of custom pizzas from the custom pizzas view
        public PizzasModel Pizza { get; set; }
        public void OnGet()
        {
        }
    }
}
