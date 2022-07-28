using System.ComponentModel.DataAnnotations;

namespace FluentValidationTJI.Models
{
    public class Alpha
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        public string ModelName { get;set;} = null!;

        [Required]
        public string ModelType { get;set;} = null!;

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public string CreatedBy { get; set; } = null!;
        [Required]
        public DateTime EditedDate { get; set; }

        [Required]
        public string EditedBy { get; set; } = null!;

        [Required]
        public int OriginModelId { get; set; }

        public DateTime? LastRebalanced { get; set; }

        public string? ChangeReason { get; set; }
        public DateTime? LastChangeReason { get; set; }

        [Required]
        public int ModelLevel { get; set; }

        [Required]
        public bool UseRestrictions { get; set; }

        [Required]
        public bool IsDynamic { get; set; }

        public DateTime? DynamicEffectiveDate { get; set; }
    }
}
