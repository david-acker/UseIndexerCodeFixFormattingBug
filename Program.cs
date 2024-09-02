var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var context = new DefaultHttpContext();
context.Response.Headers
    .Add("Header", "Value");

app.Run();
