namespace WebNadianSoft.DataBase.Entities;

public record Product : BaseEntity
{
    [Required]
    public string Name { get; set; }

    [Required]
    public Guid ManufactureId { get; set; }

    [Required]
    public string ManufactureEmail { get; set; }

    [Required]
    public string ManufacturePhone { get; set; }
}
