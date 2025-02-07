// Incorporate required dependencies from the infrastructure, persistence, domain and application layer

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add swagger definitions
// ```cs 
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen(c =>
// {
//     c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
//     {
//         Title = "{{cookiecutter.project_slug}}",
//         Version = "v1",
//         TermsOfService = new Uri("https://example.com/terms"),
//         Contact = new OpenApiContact
//         {
//             Name = "<your name>",
//             Email = "<your email>"
//         },
//         License = new OpenApiLicense
//         {
//             Name = "MgTheTrain License",
//             Url = new Uri("https://github.com/MGTheTrain/multi-media-management-service")
//         },
//         Description = @"API documentation for the {{cookiecutter.project_slug}}",
//     });
//     c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
//     {
//         In = ParameterLocation.Header,
//         Description = "Add JWT with Bearer here",
//         Name = "Authorization",
//         Type = SecuritySchemeType.ApiKey
//     });
//     c.AddSecurityRequirement(new OpenApiSecurityRequirement {
//     {
//         new OpenApiSecurityScheme
//         {
//           Reference = new OpenApiReference
//           {
//               Type = ReferenceType.SecurityScheme,
//               Id = "Bearer"
//           }
//           },
//           new string[] { }
//         }
//     });
//     var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
//     c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
// });
// ```

// Consider dependency injection through appsettings.json files when creating singleton or transient instances, e.g.:
// ```cs
// if (builder.Configuration["BlobStorageProvider"]! == "Gcp")
// {
//     var gcpBlobConnectorSettings = new GcpBlobConnectorSettings();
//     gcpBlobConnectorSettings.ConnectionString = builder.Configuration.GetSection("gcpBlobConnectorSettings")["ConnectionString"]!;
//     ...
//     builder.Services.AddSingleton<IBlobConnector, GcpBlobConnector>(
//     x => new GcpBlobConnector(
//         Options.Create<GcpBlobConnectorSettings>(gcpBlobConnectorSettings))
//     );
// }
// ...
// builder.Services.AddTransient<ISubDomainAService, SubDomainAService>(); // utilizes Db Contexts
// builder.Services.Singleton<ISubDomainBService, SubDomainBService>();
// ```

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Incorporate additional middleware if necessary

app.UseRouting();
app.UseAuthorization();

app.MapControllers();
app.Run();