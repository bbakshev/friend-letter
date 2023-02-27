using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace FriendLetter
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args); // creates a web host

      builder.Services.AddControllersWithViews(); // enable the Model-View-Controller (MVC) framework as a service. It's added through dependecy injection

      WebApplication app = builder.Build(); // creates the actual host of the app

      app.UseRouting(); // specifies that we want our host to match the website URL to routes that we create within our app.

      app.MapControllerRoute( // establishes a convention for our routes to follow
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );

      app.Run(); // method called on app runs the host
    }
  }
}