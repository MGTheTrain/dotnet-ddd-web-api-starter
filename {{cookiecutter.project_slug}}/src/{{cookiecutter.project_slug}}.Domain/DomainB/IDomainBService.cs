namespace {{cookiecutter.project_slug}}.Domain.DomainB;

/// <summary>
/// Represents a service interface for managing domain model B.
/// </summary>
public interface IDomainBService
{
    /// <summary>
    /// Creates new domain model B asynchronously.
    /// </summary>
    /// <param name="DomainB">The domain model B to create.</param>
    /// <returns>The created domain model B.</returns>
    Task<DomainB?> CreateAsync(DomainB? DomainB);

    /// <summary>
    /// Gets DomainB based on specified criteria asynchronously.
    /// </summary>
    /// <param name="filter">The criteria for filtering DomainB (optional).</param>
    /// <returns>A collection of DomainB matching the specified criteria.</returns>
    Task<IEnumerable<DomainB>?> GetAsync(DomainBFilter? filter);

    /// <summary>
    /// Gets DomainB by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the domain model B.</param>
    /// <returns>The domain model B with the specified identifier.</returns>
    Task<DomainB?> GetByIdAsync(Guid id);

    /// <summary>
    /// Updates existing DomainB by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the domain model B to update.</param>
    /// <param name="DomainB">The new domain model B.</param>
    /// <returns>The updated domain model B.</returns>
    Task<DomainB?> UpdateByIdAsync(Guid id, DomainB? DomainB);

    /// <summary>
    /// Deletes DomainB by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the domain model B to delete.</param>
    /// <returns>The deleted domain model B.</returns>
    Task<DomainB?> DeleteByIdAsync(Guid id);
}
