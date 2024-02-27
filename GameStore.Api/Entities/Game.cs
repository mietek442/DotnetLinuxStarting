using System.Data;
using System.ComponentModel.DataAnnotations;
namespace GameStore.Api.Entities;

public class Game
{   
    public int Id {get; set;}
    [Required]
    [StringLength(50)]
    public required string Name {get; set;}
    [Required]
    [StringLength(20)]
    public required string Genre {get; set;}
    [Required]
    [Range(1,99)]
    public decimal Price {get; set;}

    public required DateTime RelaseDate {get;set;}
    [Required]
    [StringLength(200)]
    public required string ImgUrl {get; set;}

}