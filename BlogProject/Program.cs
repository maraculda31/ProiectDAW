using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using BlogProject.Data;
using BlogProject.Repositories;
using BlogProject.Services;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.OpenApi.Models;
using BlogProject.Repositories.PostRepository;
using BlogProject.Repositories.UserRepository;
using BlogProject.Repositories.CommentRepository;
using BlogProject.Repositories.TagRepository;
using BlogProject.Repositories.RoleRepository;
using BlogProject.Controllers;
using Swashbuckle.AspNetCore.SwaggerUI;


namespace BlogProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BlogContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("data source=DESKTOP-C0IIQSI;initial catalog=BlogDatabase;Encrypt=False;trusted_connection=true")));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ITagRepository, TagRepository>();

          

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<ITagService, TagService>();
            // Add other service interfaces and implementations here

            services.AddControllersWithViews();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Blog API", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blog API v1");
                c.RoutePrefix = string.Empty;
                c.DocExpansion(DocExpansion.List);
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "comment",
                    pattern: "api/comments/{id}",
                    defaults: new { controller = "Comment", action = "GetCommentById" });

                endpoints.MapControllerRoute(
                    name: "post",
                    pattern: "api/posts/{id}",
                    defaults: new { controller = "Post", action = "GetPostById" });

                endpoints.MapControllerRoute(
                    name: "user",
                    pattern: "api/users/{id}",
                    defaults: new { controller = "User", action = "GetUserById" });

                endpoints.MapControllerRoute(
                    name: "role",
                    pattern: "api/roles/{id}",
                    defaults: new { controller = "Role", action = "GetRoleById" });

                endpoints.MapControllerRoute(
                    name: "tag",
                    pattern: "api/tags/{id}",
                    defaults: new { controller = "Tag", action = "GetTagById" });

                // Add additional MapControllerRoute for other controllers

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
