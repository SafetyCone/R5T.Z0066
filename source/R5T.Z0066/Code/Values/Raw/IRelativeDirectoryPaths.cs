using System;

using R5T.T0131;


namespace R5T.Z0066.Raw
{
    [ValuesMarker]
    public partial interface IRelativeDirectoryPaths : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private IRelativePaths _RelativePaths => RelativePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="IRelativePaths.N008"/>
        public string N001 => _RelativePaths.N008;

        /// <inheritdoc cref="IRelativePaths.N009"/>
        public string N002 => _RelativePaths.N009;

        /// <inheritdoc cref="IRelativePaths.N010"/>
        public string N003 => _RelativePaths.N010;

        /// <inheritdoc cref="IRelativePaths.N011"/>
        public string N004 => _RelativePaths.N011;

        /// <inheritdoc cref="IRelativePaths.N012"/>
        public string N005 => _RelativePaths.N012;
    }
}
