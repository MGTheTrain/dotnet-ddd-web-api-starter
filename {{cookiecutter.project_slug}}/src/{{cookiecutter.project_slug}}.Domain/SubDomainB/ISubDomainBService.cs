namespace {{cookiecutter.project_slug}}.Domain.SubDomainB;

/// <summary>
/// Represents a service interface for managing SubdomainEntityB.
/// </summary>
public interface ISubDomainBService
{
    /// <summary>
    /// Creates new SubdomainEntityB asynchronously.
    /// </summary>
    /// <param name="subDomainEntityB">The SubdomainEntityB to create.</param>
    /// <returns>The created SubdomainEntityB.</returns>
    Task<SubDomainEntityB?> CreateAsync(SubDomainEntityB? subDomainEntityB);

    /// <summary>
    /// Gets SubDomainEntityB based on specified criteria asynchronously.
    /// </summary>
    /// <param name="filter">The criteria for filtering (optional).</param>
    /// <returns>A collection of SubDomainEntityB matching the specified criteria.</returns>
    Task<IEnumerable<SubDomainEntityB>?> GetAsync(SubDomainBFilter? filter);

    /// <summary>
    /// Gets SubDomainEntityB by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubdomainEntityB.</param>
    /// <returns>The SubdomainEntityB with the specified identifier.</returns>
    Task<SubDomainEntityB?> GetByIdAsync(Guid id);

    /// <summary>
    /// Updates existing SubDomainEntityB by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubdomainEntityB to update.</param>
    /// <param name="subDomainEntityB">The new SubdomainEntityB.</param>
    /// <returns>The updated SubdomainEntityB.</returns>
    Task<SubDomainEntityB?> UpdateByIdAsync(Guid id, SubDomainEntityB? subDomainEntityB);

    /// <summary>
    /// Deletes SubDomainEntityB by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubdomainEntityB to delete.</param>
    /// <returns>The deleted SubdomainEntityB.</returns>
    Task<SubDomainEntityB?> DeleteByIdAsync(Guid id);
}
