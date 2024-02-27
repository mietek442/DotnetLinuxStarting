using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace GameStore.Api.Dtos;

public record GameDto(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateTime RelaseDate,
    string ImgUrl
);


public record CreateGameDto(
    [Required][StringLength(50)]string Name,
    [Required][StringLength(50)]string Genre,
    [Range(1,100)]decimal Price,
    DateTime RelaseDate,
    [Url][StringLength(100)]string ImgUrl
);

public record UpdateGameDto(
    [Required][StringLength(50)]string Name,
    [Required][StringLength(50)]string Genre,
    [Range(1,100)]decimal Price,
    DateTime RelaseDate,
    [Url][StringLength(100)]string ImgUrl
);