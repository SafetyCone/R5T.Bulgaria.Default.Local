using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;
using R5T.Visigothia;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Bulgaria.Default.Local
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="LocalDropboxDirectoryPathProvider"/> implementation of <see cref="IDropboxDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDropboxDirectoryPathProvider> AddLocalDropboxDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IUserProfileDirectoryPathProvider> userProfileDirectoryPathProviderAction)
        {
            var serviceAction = _.New<IDropboxDirectoryPathProvider>(services => services.AddLocalDropboxDirectoryPathProvider(
                stringlyTypedPathOperatorAction,
                userProfileDirectoryPathProviderAction));

            return serviceAction;
        }
    }
}
