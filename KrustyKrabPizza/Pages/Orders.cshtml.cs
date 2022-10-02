using KrustyKrabPizza.Data;
using KrustyKrabPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KrustyKrabPizza.Pages
{
    public class OrdersModel : PageModel
    {
        // Properties
        public List<PizzaOrderModel> PizzaOrders { get; set; }

        // Using dependancy injection again to access db
        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext contect)
        {
            _context = contect;
        }

        // Methods
        public void OnGet()
        {
            PizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}
