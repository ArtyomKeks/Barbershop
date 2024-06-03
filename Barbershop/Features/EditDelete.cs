using System.ComponentModel.DataAnnotations;

namespace Barbershop.Features
{
    public class EditDelete
    {
        [Required, MaxLength(255)]
        public string? Email { get; set; }

        [MaxLength(255)]
        public string? Day { get; set; }

        public string? command { get; set; }
    }
}
