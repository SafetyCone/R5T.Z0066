using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface IWindowsDirectoryPaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        private IDirectoryPaths _DirectoryPaths => DirectoryPaths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="IDirectoryPaths.N001"/>
        public string N001 => _DirectoryPaths.N001;

        /// <inheritdoc cref="IDirectoryPaths.N002"/>
        public string N002 => _DirectoryPaths.N002;

        /// <inheritdoc cref="IDirectoryPaths.N003"/>
        public string N003 => _DirectoryPaths.N003;

        /// <inheritdoc cref="IDirectoryPaths.N004"/>
        public string N004 => _DirectoryPaths.N004;

        /// <inheritdoc cref="IDirectoryPaths.N005"/>
        public string N005 => _DirectoryPaths.N005;

        /// <inheritdoc cref="IDirectoryPaths.N006"/>
        public string N006 => _DirectoryPaths.N006;

        /// <inheritdoc cref="IDirectoryPaths.N007"/>
        public string N007 => _DirectoryPaths.N007;

        /// <inheritdoc cref="IDirectoryPaths.N008"/>
        public string N008 => _DirectoryPaths.N008;

        /// <inheritdoc cref="IDirectoryPaths.N009"/>
        public string N009 => _DirectoryPaths.N009;

        /// <inheritdoc cref="IDirectoryPaths.N010"/>
        public string N010 => _DirectoryPaths.N010;

        /// <inheritdoc cref="IPaths.N011"/>
        public string N011 => _DirectoryPaths.N011;
    }
}
