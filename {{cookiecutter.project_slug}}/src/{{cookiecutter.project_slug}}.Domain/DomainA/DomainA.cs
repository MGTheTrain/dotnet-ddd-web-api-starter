using System.ComponentModel.DataAnnotations;

namespace {{cookiecutter.project_slug}}.Domain.DomainA;

/// <summary>
/// Represents domain model A information
/// </summary>
public class DomainA : IValidatableObject
{
    /// <summary>
    /// Default constructor
    /// </summary>
    public DomainA()
    {
        Id = Guid.NewGuid();
        DateTimeCreated = DateTime.UtcNow;
        DateTimeUpdated = DateTime.UtcNow;
        // More attributes
    }

    /// <summary>
    /// Sets the properties
    /// </summary>
    /// <param name="DomainA">The updated domain model A.</param>
    public void SetProperties(DomainA DomainA)
    {
        DateTimeUpdated = DomainA.DateTimeUpdated;
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
            yield return new ValidationResult($"{nameof(DomainA)}.{nameof(Id)} can't be empty");
        }

        if (DateTimeCreated == default(DateTime))
        {
            yield return new ValidationResult($"{nameof(DomainA)}.{nameof(DateTimeCreated)} can't be empty");
        }

        if (DateTimeUpdated == default(DateTime))
        {
            yield return new ValidationResult($"{nameof(DomainA)}.{nameof(DateTimeUpdated)} can't be empty");
        }
        yield return ValidationResult.Success;
    }
}