﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

namespace LanzhouBeefNoodles
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );                //通过Add*方法进行注册

            services.AddMvc();//注册MVC
            services.AddTransient<INoodleRepository, NoodleRepository>();    //<接口,实现>
            services.AddTransient<IFeedbackRepository, FeedbackRepository>();//把仓库依赖注入系统
            


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            //app.UseMvcWithDefaultRoute();//设置默认路由

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
                //{domain}/noodlees/lists
            });

            app.Map("/test", build =>
             {
                 build.Run(async context =>
                 {
                     await context.Response.WriteAsync("hello from test");
                 });
             });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
            //不会被执行
        }
    }
}
