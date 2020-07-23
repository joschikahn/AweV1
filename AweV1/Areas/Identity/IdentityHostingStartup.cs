using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(AweV1.Areas.Identity.IdentityHostingStartup))]
namespace AweV1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {

        }
    }
}