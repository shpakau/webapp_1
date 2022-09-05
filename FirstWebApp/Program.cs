var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();

// app.MapGet("/", () => "Привет");

// app.MapGet("/about", () => RouteMethods.About());

// app.MapGet("/hi/{name}", (string name) => RouteMethods.Hi(name));

// app.MapGet("/calc/{x},{y}", (int x, int y) => RouteMethods.Sum(x, y));

////  третья часть

app.UseRouting();

app.UseEndpoints(endpoint => 
  endpoint.MapControllerRoute(
      name: "Default",
      pattern: "api/{controller}/{action}/{arg?}"
      )
  );

app.Run();