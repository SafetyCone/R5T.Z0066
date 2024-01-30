using System;

using R5T.T0131;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface IRelativeWindowsDirectoryPaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private IRelativeDirectoryPaths _RelativeDirectoryPaths => RelativeDirectoryPaths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="IRelativeDirectoryPaths.N001"/>
        public string N001 => _RelativeDirectoryPaths.N001;

        /// <inheritdoc cref="IRelativeDirectoryPaths.N002"/>
        public string N002 => _RelativeDirectoryPaths.N002;

        /// <inheritdoc cref="IRelativeDirectoryPaths.N003"/>
        public string N003 => _RelativeDirectoryPaths.N003;

        /// <inheritdoc cref="IRelativeDirectoryPaths.N004"/>
        public string N004 => _RelativeDirectoryPaths.N004;

        /// <inheritdoc cref="IRelativeDirectoryPaths.N005"/>
        public string N005 => _RelativeDirectoryPaths.N005;
    }
}
