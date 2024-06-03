using System.ComponentModel.DataAnnotations;

namespace Barbershop.Features
{
    public class EditClient
    {
        public Guid? ClientID { get; set; }

        [Required, MaxLength(255)]
        public string? Name { get; init; }

        [Required, MaxLength(255)]
        public string? Surname { get; init; }

        [Required, MaxLength(255)]
        public string? LastName { get; init; }

        [Required, MaxLength(255), EmailAddress]
        public string? Email { get; init; }

        [Required, MaxLength(255)]
        public string? Day { get; init; }
    }
}
