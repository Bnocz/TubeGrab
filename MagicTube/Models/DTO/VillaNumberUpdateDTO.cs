namespace MagicTube.Models.DTO { 
using System.ComponentModel.DataAnnotations;

    public class VillaNumberUpdateDTO
    {
        public int VillaNo { get; set; }
        [Required]
        public int VillaID { get; set; }
        public string SpecialDetails { get; set; }
    }
}
