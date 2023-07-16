using Quartz;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Logging.AddConsole();
builder.Services.AddQuartz(configurator => {
    // no access to LoggerFactory here because no serviceprovider
    // builder.Logging is a IloggingBuilder not an ILoggerFactory
    // not sure how to fix this
    configurator.SetLoggerFactory(null!/* what to put here */);
}).AddQuartzHostedService();

await builder.Build().RunAsync();