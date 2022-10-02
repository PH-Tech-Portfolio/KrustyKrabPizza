using KrustyKrabPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KrustyKrabPizza.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> FakePizzaDb { get; set; } = new List<PizzasModel>() { 
            new PizzasModel() {
                ImageTitle="MeatFeast",
                PizzaName="Thicc Krabby",
                BasePrice=14.99f,
                HasTomatoSause=true,
                HasCheese=true,
                FinalPrice=17.99f
            },
            new PizzasModel() {
                ImageTitle="Vegetarian",
                PizzaName="Skinny Squid",
                BasePrice=11.99f,
                HasTomatoSause=true,
                HasCheese=false,
                HasMushrooms=true,
                FinalPrice=15.99f
            },
            new PizzasModel() {
                ImageTitle="Bolognese",
                PizzaName="Dairy gone bye bye",
                BasePrice=10.99f,
                HasTomatoSause=true,
                HasCheese=false,
                FinalPrice=13.99f
            },
            new PizzasModel() {
                ImageTitle="Hawaiian",
                PizzaName="The Sinner",
                BasePrice=20.99f,
                HasTomatoSause=false,
                HasCheese=false,
                HasPineapple=true,
                HasTuna=true,
                FinalPrice=42.0f
            },
            new PizzasModel() {
                ImageTitle="Pepperoni",
                PizzaName="Everything",
                BasePrice=20.99f,
                HasTomatoSause=true,
                HasCheese=true,
                FinalPrice=25.99f
            },
            
        };

        public void OnGet()
        {
        }
    }
}
