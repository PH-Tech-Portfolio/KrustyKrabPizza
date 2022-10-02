using System.ComponentModel.DataAnnotations;

namespace KrustyKrabPizza.Models
{
    public class PizzaOrderModel
    {
        [Key]
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; }
        // ^Could add more values but don't feel like it. 
        // Will add bigger sql db to another project.
    }
}
