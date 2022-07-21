using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    [Table("pizzas")]
    public class Pizza
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

        [Column("ingredients", TypeName = "text")]
        public string Ingredients { get; set; }

        [Column("photo")]
        public string? Photo { get; set; }

        [Required]
        [Column("price", TypeName ="decimal(5,2)")]
        public decimal Price { get; set; }


        public Pizza()
        {

        }

        public Pizza(string name, string ingredients, string photo, decimal price)
        {
            this.Name = name;
            this.Ingredients = ingredients;
            this.Photo = photo;
            this.Price = price;
        }

    }
}
