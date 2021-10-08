
using System;
using Microsoft.Extensions.DependencyInjection;

namespace LiteUploadHandler
{
    public static class LiteUploadHandlerDependencyInjection
    {
        public static IServiceCollection AddLiteUploadHandler(this IServiceCollection services, Action<ValidationConfigInfo> config)
        {
            ValidationConfigInfo validationConfiguration = new ValidationConfigInfo();
            services.AddSingleton<ILiteUploadHandler>(cfg=> {
                config(validationConfiguration);
                return new LiteUploadHandler(validationConfiguration);
            });

            return services;
        }
    }

}