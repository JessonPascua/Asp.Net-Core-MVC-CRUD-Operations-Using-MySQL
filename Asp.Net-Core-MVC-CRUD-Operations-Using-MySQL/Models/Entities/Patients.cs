using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Asp.Net_Core_MVC_CRUD_Operations_Using_MySQL.Models.Entities
{
    [PersonalData]
    public class Patients
    {
        [Key]
        [PersonalData]
        [Column(TypeName = "INT")]
        public int Id { get; set; }

        [Required]
        [PersonalData]
        [Column(TypeName = "VARCHAR(100)")]
        public string? FristName { get; set; }

        [Required]
        [PersonalData]
        [Column(TypeName = "VARCHAR(100)")]
        public string? LastName { get; set; }

        [Required]
        [PersonalData]
        [Column(TypeName = "VARCHAR(100)")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "The Physician field is required333.")]
        [PersonalData]
        [Column(TypeName = "INT")]
        public int DoctorId { get; set; }

        [Required]
        [PersonalData]
        [Column(TypeName = "DATETIME")]
        public DateTime AppointmentDate { get; set; }

        [ForeignKey("DoctorId")]
        public virtual Physicians Physician { get; set; } = null!;
    }
}
