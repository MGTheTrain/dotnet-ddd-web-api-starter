namespace {{cookiecutter.project_slug}}.Domain.SubDomainA;

/// <summary>
/// Represents SubdomainEntityA filter
/// </summary>
public class SubDomainAFilter
{
    public Guid Id { get; set; } 
    public DateTime DateTimeCreated { get; set; }
    public DateTime DateTimeUpdated { get; set; }
    // More attributes
}

// NOTE: Add other SubdomainEntityfilter for subdomain entitys in domain A