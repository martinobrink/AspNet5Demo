using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace WebApplication3
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            
            #region 1 - Hello World

            //app.Run(async context => await context.Response.WriteAsync("Hello Trifork!"));

            #endregion Hello World


            #region 2 - Middleware - Welcome Page

            //app.UseWelcomePage();

            #endregion 2 - Middleware - Welcome Page


            #region 3 - Middleware - Handcoded

            //app.Use(new Func<RequestDelegate, RequestDelegate>(nextHandler => async context =>
            //{
            //    await context.Response.WriteAsync("pre-processing1\n");
            //    await nextHandler(context);
            //    await context.Response.WriteAsync("post-processing1\n");
            //}));


            //app.Use(new Func<RequestDelegate, RequestDelegate>(nextHandler => async context =>
            //{
            //    await context.Response.WriteAsync("pre-processing2\n");
            //    await nextHandler(context);
            //    await context.Response.WriteAsync("post-processing2\n");
            //}));


            //app.Use(new Func<RequestDelegate, RequestDelegate>(nextHandler => async context =>
            //{
            //    await context.Response.WriteAsync("HALLELUJA!!!\n");
            //}));

            #endregion 3 - Middleware - Handcoded


            #region 4 - Middleware - Extension Method

            //app.UseMyMiddleware();

            #endregion  4 - Middleware - Extension Method


            #region 5 - Middleware - Mvc

            //app.UseMvc();
            
            #endregion 5 - Middleware - Mvc
        }


        public void ConfigureServices(IServiceCollection services)
        {

            #region 5 - Middleware - Mvc

            //services.AddMvc();

            #endregion 5 - Middleware - Mvc


            #region 6 - Dependency Injection - Calculator

            //services.AddTransient<ICalculator, Calculator>();

            #endregion  6 - Dependency Injection - Calculator

        }

    }

    #region  4 - Middleware - Extension Method

    //public static class MyMiddlewareExtensions
    //{
    //    public static void UseMyMiddleware(this IApplicationBuilder app)
    //    {
    //        app.Use(new Func<RequestDelegate, RequestDelegate>(nextHandler => async context =>
    //        {
    //            await context.Response.WriteAsync("MyMiddleware pre-processing\n");
    //            await nextHandler(context);//pass on processing to next middleware component in pipeline
    //            await context.Response.WriteAsync("MyMiddleware post-processing\n");
    //        }));
    //    }
    //}

    #endregion  4 - Middleware - Extension Method
}
