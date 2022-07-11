
// using System.Reflection;
// using Identity.Api;
// using Identity.Api.Database;
// using Identity.Api.Extensions;
// using IdentityServer4.EntityFramework.DbContexts;
// using Microsoft.Extensions.Options;
// using Serilog;

// var builder = WebApplication.CreateBuilder(args);

// builder.Configuration
// .SetBasePath(Directory.GetCurrentDirectory())
// .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
// .AddEnvironmentVariables()
// .AddUserSecrets(Assembly.GetExecutingAssembly(), true);

// builder.WebHost.CaptureStartupErrors(false);
// builder.WebHost.ConfigureAppConfiguration(x => x.AddConfiguration(builder.Configuration));
// builder.WebHost.UseStartup<Program>();
// builder.WebHost.UseContentRoot(Directory.GetCurrentDirectory());

// string? appName = typeof(Program).Namespace;
// var logger = new LoggerConfiguration()
//     .MinimumLevel.Verbose()
//     .Enrich.WithProperty("ApplicationContext", appName)
//     .Enrich.FromLogContext()
//     .WriteTo.Console()
//     .ReadFrom.Configuration(builder.Configuration)
//     .Enrich.FromLogContext()
//     .CreateLogger();

// builder.Logging.ClearProviders();
// builder.Logging.AddSerilog(logger);

// try
// {
//     Log.Information("Configuring web host ({ApplicationContext})...", appName);
//     var host = Host.CreateDefaultBuilder().Build();

//     Log.Information("Applying migrations ({ApplicationContext})...", appName);
//     host.MigrateDbContext<PersistedGrantDbContext>((_, __) => { })
//         .MigrateDbContext<ApplicationDbContext>((context, services) =>
//         {
//             var env = services.GetService<IWebHostEnvironment>();
//             var logger = services.GetService<ILogger<ApplicationDbContextSeed>>();
//             var settings = services.GetService<IOptions<AppSettings>>();

//             new ApplicationDbContextSeed()
//                 .SeedAsync(context, env, logger, settings)
//                 .Wait();
//         })
//         .MigrateDbContext<ConfigurationDbContext>((context, services) =>
//         {
//             new ConfigurationDbContextSeed()
//                 .SeedAsync(context, builder.Configuration)
//                 .Wait();
//         });

//     Log.Information("Starting web host ({ApplicationContext})...", appName);
//     host.Run();

//     return 0;
// }
// catch (Exception ex)
// {
//     Log.Fatal(ex, "Program terminated unexpectedly ({ApplicationContext})!", appName);
//     return 1;
// }
// finally
// {
//     Log.CloseAndFlush();
// }

// // Add services to the container.
// builder.Services.AddControllers();
// // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();

// app.Run();
