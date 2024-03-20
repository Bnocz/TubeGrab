namespace MagicTube.Models.DTO
using System.ComponentModel.DataAnnotations;
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
    [StringLength(30)]
    public String Name { get; set; }
    public DateTime CreatedDate { get; set; }

    public int Occupancy { get; set; }

    public int Sqft { get; set; }
}
}
