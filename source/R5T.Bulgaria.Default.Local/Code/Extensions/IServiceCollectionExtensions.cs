﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;
using R5T.Visigothia;

using R5T.T0063;


namespace R5T.Bulgaria.Default.Local
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="LocalDropboxDirectoryPathProvider"/> implementation of <see cref="IDropboxDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddLocalDropboxDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IUserProfileDirectoryPathProvider> userProfileDirectoryPathProviderAction)
        {
            services
                .Run(stringlyTypedPathOperatorAction)
                .Run(userProfileDirectoryPathProviderAction)
                .AddSingleton<IDropboxDirectoryPathProvider, LocalDropboxDirectoryPathProvider>()
                ;

            return services;
        }
    }
}
