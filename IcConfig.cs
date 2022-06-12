using ChartModule.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ChartModule
{
    public class IcConfig
    {
        
        public  static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ChartDbContext>(options =>
                {
                    options.UseInMemoryDatabase("Test2");
                    /*if (MyGlobal.IsAttached)
                    {
                        options.UseInMemoryDatabase("Test");
                    }
                    else
                    {
                        options.UseSqlite(
                            Configuration.GetConnectionString("DefaultConnection"));
                    }*/
                }
            );
            
            /*services.AddTransient<EmailSentService>();
            services.AddTransient<EmailTemplateService>();
            services.AddTransient<EmailSettingService>();
            services.AddTransient<EmailHtmlManipulator>();
            services.AddTransient<EmailService>();*/
            
          
        }
    }
}