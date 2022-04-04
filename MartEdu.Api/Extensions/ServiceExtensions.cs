﻿using MartEdu.Data.IRepositories;
using MartEdu.Data.Repositories;
using MartEdu.Service.Interfaces;
using MartEdu.Service.Services;
using Microsoft.Extensions.DependencyInjection;


namespace MartEdu.Api.Extensions
{
    internal static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IAuthorService, AuthorService>();
        }
    }
}
