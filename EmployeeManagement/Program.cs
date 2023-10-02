using EmployeeManagement.Models;
//using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddMvc(options => options.EnableEndpointRouting=false).AddXmlSerializerFormatters();
builder.Services.AddScoped<IEmployeeRepository, MockEmployeeRepository>();
var app = builder.Build();


app.UseStaticFiles();
//app.UseMvcWithDefaultRoute();
app.UseMvc(routes =>
{
    routes.MapRoute("default", "{controller=Home}/{action=EmployeeList}/{id?}");
});

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello world!");
});
app.Run();
