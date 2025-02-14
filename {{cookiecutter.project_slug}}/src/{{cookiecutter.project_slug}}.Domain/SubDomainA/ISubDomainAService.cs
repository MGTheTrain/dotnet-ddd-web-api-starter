namespace {{cookiecutter.project_slug}}.Domain.SubDomainA;

/// <summary>
/// Represents a service interface
/// </summary>
public interface ISubDomainAService
{
    /// <summary>
    /// Creates new SubDomainAEntity asynchronously.
    /// </summary>
    /// <param name="subDomainAEntity">The SubDomainAEntity to create.</param>
    /// <returns>The created SubDomainAEntity.</returns>
    Task<SubDomainAEntity?> CreateAsync(SubDomainAEntity? subDomainAEntity);

    /// <summary>
    /// Gets SubDomainAEntity based on specified criteria asynchronously.
    /// </summary>
    /// <param name="filter">The criteria for filtering (optional).</param>
    /// <returns>A collection of SubDomainAEntity matching the specified criteria.</returns>
    Task<IEnumerable<SubDomainAEntity>?> GetAsync(SubDomainAFilter? filter);

    /// <summary>
    /// Gets SubDomainAEntity by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubDomainAEntity.</param>
    /// <returns>The SubDomainAEntity with the specified identifier.</returns>
    Task<SubDomainAEntity?> GetByIdAsync(Guid id);

    /// <summary>
    /// Updates existing SubDomainAEntity by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubDomainAEntity to update.</param>
    /// <param name="subDomainAEntity">The new SubDomainAEntity.</param>
    /// <returns>The updated SubDomainAEntity.</returns>
    Task<SubDomainAEntity?> UpdateByIdAsync(Guid id, SubDomainAEntity? subDomainAEntity);

    /// <summary>
    /// Deletes SubDomainAEntity by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubDomainAEntity to delete.</param>
    /// <returns>The deleted SubDomainAEntity.</returns>
    Task<SubDomainAEntity?> DeleteByIdAsync(Guid id);
}
