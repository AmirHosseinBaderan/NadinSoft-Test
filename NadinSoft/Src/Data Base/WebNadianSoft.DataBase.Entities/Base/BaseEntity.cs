namespace WebNadianSoft.DataBase.Entities;

public record BaseEntity
{
    public BaseEntity()
    {
        CreateDate = DateTime.Now;
        Status = 0;
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    public DateTime CreateDate { get; set; }

    [Required]
    public int Status { get; set; }
}
