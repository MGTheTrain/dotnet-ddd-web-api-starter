namespace {{cookiecutter.project_slug}}.Domain.SubDomainB;

/// <summary>
/// Represents SubdomainEntityB filter
/// </summary>
public class SubDomainBFilter
{
    public Guid Id { get; set; } 
    public DateTime DateTimeCreated { get; set; }
    public DateTime DateTimeUpdated { get; set; }
    // More attributes
}

// NOTE: Add other SubdomainEntityfilter for subdomain entitys in domain B