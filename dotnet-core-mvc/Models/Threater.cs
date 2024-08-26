using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_core_mvc.Models;

[Table("threaters")]
public class Threater {

    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("location")]
    public string? Location { get; set; }

    [Column("created_at")]
    public DateTime Created_at { get; set; }

}