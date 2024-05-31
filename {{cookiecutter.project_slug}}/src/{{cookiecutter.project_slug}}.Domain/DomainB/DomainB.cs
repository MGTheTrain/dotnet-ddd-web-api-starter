using System.ComponentModel.DataAnnotations;

namespace {{cookiecutter.project_slug}}.Domain.DomainB;

/// <summary>
/// Represents domain model A information
/// </summary>
public class DomainB : IValidatableObject
{
    /// <summary>
    /// Default constructor
    /// </summary>
    public DomainB()
    {
        Id = Guid.NewGuid();
        DateTimeCreated = DateTime.UtcNow;
        DateTimeUpdated = DateTime.UtcNow;
        // More attributes
    }

    /// <summary>
    /// Sets the properties
    /// </summary>
    /// <param name="DomainB">The updated domain model A.</param>
    public void SetProperties(DomainB DomainB)
    {
        DateTimeUpdated = DomainB.DateTimeUpdated;
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
            yield return new ValidationResult($"{nameof(DomainB)}.{nameof(Id)} can't be empty");
        }

        if (DateTimeCreated == default(DateTime))
        {
            yield return new ValidationResult($"{nameof(DomainB)}.{nameof(DateTimeCreated)} can't be empty");
        }

        if (DateTimeUpdated == default(DateTime))
        {
            yield return new ValidationResult($"{nameof(DomainB)}.{nameof(DateTimeUpdated)} can't be empty");
        }
        yield return ValidationResult.Success;
    }
}