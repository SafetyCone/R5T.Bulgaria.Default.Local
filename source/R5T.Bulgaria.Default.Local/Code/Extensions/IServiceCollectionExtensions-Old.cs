﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;
using R5T.Visigothia;


namespace R5T.Bulgaria.Default.Local
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="LocalDropboxDirectoryPathProvider"/> implementation of <see cref="IDropboxDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddLocalDropboxDirectoryPathProvider_Old(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IUserProfileDirectoryPathProvider> userProfileDirectoryPathProviderAction)
        {
            services
                .AddSingleton<IDropboxDirectoryPathProvider, LocalDropboxDirectoryPathProvider>()
                .Run(stringlyTypedPathOperatorAction)
                .Run(userProfileDirectoryPathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="LocalDropboxDirectoryPathProvider"/> implementation of <see cref="IDropboxDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDropboxDirectoryPathProvider> AddLocalDropboxDirectoryPathProviderAction_Old(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IUserProfileDirectoryPathProvider> userProfileDirectoryPathProviderAction)
        {
            var serviceAction = ServiceAction<IDropboxDirectoryPathProvider>.New(() => services.AddLocalDropboxDirectoryPathProvider_Old(
                stringlyTypedPathOperatorAction,
                userProfileDirectoryPathProviderAction));

            return serviceAction;
        }
    }
}
