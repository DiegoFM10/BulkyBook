using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key] //Data Annotation Validator to declare "Id" as a primary key and identity column to Entity Framework
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;//Al igualar la variable se le agrega un valor predeterminado
    }
}
