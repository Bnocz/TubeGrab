namespace MagicTube.Models.DTO { 
using System.ComponentModel.DataAnnotations;

    public class VillaNumberCreateDTO
    {
        public int VillaNo { get; set; }
        [Required]
        public int VillaID { get; set; }
        public string SpecialDetails { get; set; }
    }
}
