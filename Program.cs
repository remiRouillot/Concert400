using Concert400.Components;
using Concert400.Components.Account;
using Concert400.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Aumerial.EntityFrameworkCore;
using MudBlazor.Services;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Concert400
{
    public class Program
    {
        private static string PromptText(string label, bool hidden)
        {
            Console.Write(label + ":");
            var input = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && input.Length > 0)
                {
                    Console.Write("\b \b");
                    input = input[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write(hidden ? "*" : keyInfo.KeyChar);
                    input += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            Console.WriteLine();
            return input;
        }
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            Environment.SetEnvironmentVariable("server", PromptText("IP/Host", false));
            Environment.SetEnvironmentVariable("user", PromptText("Username", false));
            Environment.SetEnvironmentVariable("password", PromptText("Password", true));


            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddCascadingAuthenticationState();
            builder.Services.AddScoped<IdentityUserAccessor>();
            builder.Services.AddScoped<IdentityRedirectManager>();
            builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
            builder.Services.AddAuthentication(options =>
                {
                    options.DefaultScheme = IdentityConstants.ApplicationScheme;
                    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
                })
                .AddIdentityCookies();

            var connectionString = $"server={Environment.GetEnvironmentVariable("server")};user={Environment.GetEnvironmentVariable("user")};password={Environment.GetEnvironmentVariable("password")};schema=CONCERTEF";
            //builder.Services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseNTi(
            //        connectionString, 
            //        opt => opt.VarfieldMaxLength(512, 512, 1024)
            //    )
            //);
            builder.Services.AddPooledDbContextFactory<ApplicationDbContext>(options =>
                options.UseNTi(
                    connectionString,
                    opt => opt.VarfieldMaxLength(512, 512, 1024)
                ), 10
            );
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNTi(
                    connectionString,
                    opt => opt.VarfieldMaxLength(512, 512, 1024)
                )
            );
            builder.Services.AddScoped(p => p.GetRequiredService<IDbContextFactory<ApplicationDbContext>>().CreateDbContext());
            builder.Services.AddQuickGridEntityFrameworkAdapter();
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();
            builder.Services.AddMudServices();
            builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<IdentityRole>()
                .AddRoleManager<RoleManager<IdentityRole>>()
                .AddRoleStore<RoleStore<IdentityRole, ApplicationDbContext>>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddSignInManager()
                .AddDefaultTokenProviders();

            builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                context.ResetDatabase(false);
            }


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
                app.UseMigrationsEndPoint();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            // Add additional endpoints required by the Identity /Account Razor components.
            app.MapAdditionalIdentityEndpoints();

            app.Run();
        }
    }
}
