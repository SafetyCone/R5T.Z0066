using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface INonWindowsDirectoryPaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        private IDirectoryPaths _DirectoryPaths => DirectoryPaths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        ///// <summary>
        ///// <para><value></value></para>
        ///// </summary>
        //public string N00 => @"";

        /// <inheritdoc cref="IDirectoryPaths.N012"/>
        public string N001 => _DirectoryPaths.N012;

        /// <inheritdoc cref="IDirectoryPaths.N013"/>
        public string N002 => _DirectoryPaths.N013;

        /// <inheritdoc cref="IDirectoryPaths.N014"/>
        public string N003 => _DirectoryPaths.N014;

        /// <inheritdoc cref="IDirectoryPaths.N015"/>
        public string N004 => _DirectoryPaths.N015;

        /// <inheritdoc cref="IDirectoryPaths.N016"/>
        public string N005 => _DirectoryPaths.N016;

        /// <inheritdoc cref="IDirectoryPaths.N017"/>
        public string N006 => _DirectoryPaths.N017;

        /// <inheritdoc cref="IDirectoryPaths.N018"/>
        public string N007 => _DirectoryPaths.N018;

        /// <inheritdoc cref="IDirectoryPaths.N019"/>
        public string N008 => _DirectoryPaths.N019;

        /// <inheritdoc cref="IDirectoryPaths.N020"/>
        public string N009 => _DirectoryPaths.N020;
    }
}
