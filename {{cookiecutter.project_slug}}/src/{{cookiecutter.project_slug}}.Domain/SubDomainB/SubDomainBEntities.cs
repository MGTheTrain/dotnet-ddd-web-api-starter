using System.ComponentModel.DataAnnotations;

namespace {{cookiecutter.project_slug}}.Domain.SubDomainB;

/// <summary>
/// Represents SubDomainBEntity
/// </summary>
public class SubDomainBEntity : IValidatableObject
{
    /// <summary>
    /// Default constructor
    /// </summary>
    public SubDomainBEntity()
    {
        Id = Guid.NewGuid();
        DateTimeCreated = DateTime.UtcNow;
        DateTimeUpdated = DateTime.UtcNow;
        // More attributes
    }

    /// <summary>
    /// Sets the properties
    /// </summary>
    /// <param name="subDomainBEntity">The updated SubDomainAEntity.</param>
    public void SetProperties(SubDomainBEntity subDomainBEntity)
    {
        DateTimeUpdated = SubDomainBEntity.DateTimeUpdated;
        // More attributes
    }

    public Guid Id { get; internal set; } 
    public DateTime DateTimeCreated { get; internal set; }
    public DateTime DateTimeUpdated { get; set; }
    // More attributes
    

    /// <summary>
    /// Validates properties
    /// </summary>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Id == Guid.Empty)
        {
            yield return new ValidationResult($"{nameof(SubDomainBEntity)}.{nameof(Id)} can't be empty");
        }

        if (DateTimeCreated == default(DateTime))
        {
            yield return new ValidationResult($"{nameof(SubDomainBEntity)}.{nameof(DateTimeCreated)} can't be empty");
        }

        if (DateTimeUpdated == default(DateTime))
        {
            yield return new ValidationResult($"{nameof(SubDomainBEntity)}.{nameof(DateTimeUpdated)} can't be empty");
        }
        yield return ValidationResult.Success;
    }

    // NOTE: Add other entities
}