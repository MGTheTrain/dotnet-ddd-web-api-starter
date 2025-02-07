namespace {{cookiecutter.project_slug}}.Persistence.DataAccess;

// This layer is only necessary if using DBContexts with ORMs like EF Core for SQL like database tables with a schema. Otherwise you can remove it along with {{cookiecutter.project_slug}}.PersistenceTest.
// Optionally consider Repository implementations utilizing DBContexts

public class SqlDbContext
{

}
