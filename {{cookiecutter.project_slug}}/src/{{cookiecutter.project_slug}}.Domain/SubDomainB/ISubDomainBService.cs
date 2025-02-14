namespace {{cookiecutter.project_slug}}.Domain.SubDomainB;

/// <summary>
/// Represents a service interface
/// </summary>
public interface ISubDomainBService
{
    /// <summary>
    /// Creates new SubDomainBEntity asynchronously.
    /// </summary>
    /// <param name="subDomainBEntity">The SubDomainBEntity to create.</param>
    /// <returns>The created SubDomainBEntity.</returns>
    Task<SubDomainBEntity?> CreateAsync(SubDomainBEntity? subDomainBEntity);

    /// <summary>
    /// Gets SubDomainBEntity based on specified criteria asynchronously.
    /// </summary>
    /// <param name="filter">The criteria for filtering (optional).</param>
    /// <returns>A collection of SubDomainBEntity matching the specified criteria.</returns>
    Task<IEnumerable<SubDomainBEntity>?> GetAsync(SubDomainBFilter? filter);

    /// <summary>
    /// Gets SubDomainBEntity by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubDomainBEntity.</param>
    /// <returns>The SubDomainBEntity with the specified identifier.</returns>
    Task<SubDomainBEntity?> GetByIdAsync(Guid id);

    /// <summary>
    /// Updates existing SubDomainBEntity by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubDomainBEntity to update.</param>
    /// <param name="subDomainBEntity">The new SubDomainBEntity.</param>
    /// <returns>The updated SubDomainBEntity.</returns>
    Task<SubDomainBEntity?> UpdateByIdAsync(Guid id, SubDomainBEntity? subDomainBEntity);

    /// <summary>
    /// Deletes SubDomainBEntity by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubDomainBEntity to delete.</param>
    /// <returns>The deleted SubDomainBEntity.</returns>
    Task<SubDomainBEntity?> DeleteByIdAsync(Guid id);
}
