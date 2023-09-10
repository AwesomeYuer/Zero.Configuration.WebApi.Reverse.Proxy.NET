using Microshaoft;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpForwarder();

var app = builder.Build();

app.UseFileServer();

string proxyPathBaseString = builder.Configuration.GetValue(nameof(proxyPathBaseString), "api/proxy");

app.UseRouting();
app.UseZeroConfigurationWebApiReverseProxy(pathBaseString: proxyPathBaseString);



app.Run();
