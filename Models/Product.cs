using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_ProductManager_Public2.Models;
[Table("products")]
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id", Order = 1)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Product name is required.")]
    [MinLength(3, ErrorMessage = "Product name must be at least {1} characters.")]
    [MaxLength(100, ErrorMessage = "Product name must be at most {1} characters.")]
    [Column("name", Order = 2)]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Cost is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Cost must be greater than 0.")]
    [Column("cost", Order = 3)]
    public double Cost { get; set; }
}
