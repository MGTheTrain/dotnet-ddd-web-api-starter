namespace {{cookiecutter.project_slug}}.Domain.SubDomainA;

/// <summary>
/// Represents a service interface for managing SubdomainEntityA.
/// </summary>
public interface ISubDomainAService
{
    /// <summary>
    /// Creates new SubdomainEntityA asynchronously.
    /// </summary>
    /// <param name="subDomainEntityA">The SubdomainEntityA to create.</param>
    /// <returns>The created SubdomainEntityA.</returns>
    Task<SubDomainEntityA?> CreateAsync(SubDomainEntityA? subDomainEntityA);

    /// <summary>
    /// Gets SubDomainEntityA based on specified criteria asynchronously.
    /// </summary>
    /// <param name="filter">The criteria for filtering (optional).</param>
    /// <returns>A collection of SubDomainEntityA matching the specified criteria.</returns>
    Task<IEnumerable<SubDomainEntityA>?> GetAsync(SubDomainAFilter? filter);

    /// <summary>
    /// Gets SubDomainEntityA by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubdomainEntityA.</param>
    /// <returns>The SubdomainEntityA with the specified identifier.</returns>
    Task<SubDomainEntityA?> GetByIdAsync(Guid id);

    /// <summary>
    /// Updates existing SubDomainEntityA by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubdomainEntityA to update.</param>
    /// <param name="subDomainEntityA">The new SubdomainEntityA.</param>
    /// <returns>The updated SubdomainEntityA.</returns>
    Task<SubDomainEntityA?> UpdateByIdAsync(Guid id, SubDomainEntityA? subDomainEntityA);

    /// <summary>
    /// Deletes SubDomainEntityA by its unique identifier asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the SubdomainEntityA to delete.</param>
    /// <returns>The deleted SubdomainEntityA.</returns>
    Task<SubDomainEntityA?> DeleteByIdAsync(Guid id);
}
