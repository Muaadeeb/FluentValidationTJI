namespace FluentValidationTJI.Models.Dto;

public class AlphaDto
{
    public int Id { get; set; }
        
    public string ModelName { get; set; } = null!;
        
    public string ModelType { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime EditedDate { get; set; }

    public string EditedBy { get; set; } = null!;

    public int OriginModelId { get; set; }

    public DateTime? LastRebalanced { get; set; }

    public string? ChangeReason { get; set; }
    public DateTime? LastChangeReason { get; set; }

    public int ModelLevel { get; set; }

    public bool UseRestrictions { get; set; }

    public bool? IsDynamic { get; set; }

    public DateTime? DynamicEffectiveDate { get; set; }

    public SomeString[]? SampleArrayString { get; set; }
}

public record SomeString(string SampleString);