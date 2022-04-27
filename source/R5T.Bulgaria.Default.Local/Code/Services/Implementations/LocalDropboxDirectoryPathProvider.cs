﻿using System;

using R5T.Lombardy;
using R5T.Visigothia;

using R5T.T0064;

using BulgariaBaseConstants = R5T.Bulgaria.Base.Constants;


namespace R5T.Bulgaria.Default.Local
{
    /// <summary>
    /// Gets the Dropbox directory path from the user profile directory path.
    /// </summary>
    [ServiceImplementationMarker]
    public class LocalDropboxDirectoryPathProvider : IDropboxDirectoryPathProvider, IServiceImplementation
    {
        public IUserProfileDirectoryPathProvider UserProfileDirectoryPathProvider { get; }
        public IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public LocalDropboxDirectoryPathProvider(IUserProfileDirectoryPathProvider userProfileDirectoryPathProvider, IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.UserProfileDirectoryPathProvider = userProfileDirectoryPathProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string GetDropboxDirectoryPath()
        {
            var userProfileDirectoryPath = this.UserProfileDirectoryPathProvider.GetUserProfileDirectoryPath();

            var dropboxDirectoryPath = this.StringlyTypedPathOperator.GetDirectoryPath(userProfileDirectoryPath, BulgariaBaseConstants.DropboxDirectoryName);
            return dropboxDirectoryPath;
        }
    }
}
