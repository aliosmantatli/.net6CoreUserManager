using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NETCoreIdentityCustom.Areas.Identity.Data
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }

        [Required]
        public string? Ad { get; set; }

        [Required]
        public string? Soyad { get; set; }

        public string? Aciklama { get; set; }

        [Required]
        public string? BelgeUrl { get; set; }

        public bool OnayDurumu { get; set; }

        public DateTime? OnayTarihi { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

    }
}
